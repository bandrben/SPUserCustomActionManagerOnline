using BandR;
using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading;
using System.Web;
using System.Windows.Forms;

namespace SPUserCustomActionManagerOnline
{
    public partial class Form1 : System.Windows.Forms.Form
    {

        private AboutForm aboutForm = null;
        private BackgroundWorker bgw = null;
        private int statusWindowOutputBatchSize = GenUtil.SafeToInt(ConfigurationManager.AppSettings["statusWindowOutputBatchSize"]);
        private bool showFullErrMsgs = GenUtil.SafeToBool(ConfigurationManager.AppSettings["showFullErrMsgs"]);
        private bool ErrorOccurred = false;
        private const int _defaultSeq = 1000;



        /// <summary>
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            toolStripStatusLabel1.Text = "";

            // #testing
            if (Environment.MachineName.IsEqual("PERSEUS"))
            {
            }

            this.FormClosed += Form1_FormClosed;

            LoadSettingsFromRegistry();

            imageBandR.Visible = true;
            imageBandRwait.Visible = false;

            lblNoErrorFound.Visible = lblErrorFound.Visible = false;


            // #testing
            var i = 0;
            dataGridView1.Columns[i++].ReadOnly = false; // select
            dataGridView1.Columns[i++].ReadOnly = true; // ID
            dataGridView1.Columns[i++].ReadOnly = false; // Name
            dataGridView1.Columns[i++].ReadOnly = false; // Descr
            dataGridView1.Columns[i++].ReadOnly = false; // Seq
            dataGridView1.Columns[i++].ReadOnly = false; // ScriptSrc
            dataGridView1.Columns[i++].ReadOnly = false; // ScriptBlock

            //int n = dataGridView1.Rows.Add();
            //dataGridView1.Rows[n].Cells[0].Value = false;
            //dataGridView1.Rows[n].Cells[1].Value = "TEST1";

            //n = dataGridView1.Rows.Add();
            //dataGridView1.Rows[n].Cells[0].Value = false;
            //dataGridView1.Rows[n].Cells[1].Value = "TEST2";

            //dataGridView1.Rows.RemoveAt(0);
        }



     

        /// <summary>
        /// </summary>
        private ICredentials BuildCreds()
        {
            var userName = tbUsername.Text.Trim();
            var passWord = tbPassword.Text.Trim();
            var domain = tbDomain.Text.Trim();

            if (!cbIsSPOnline.Checked)
            {
                return new NetworkCredential(userName, passWord, domain);
            }
            else
            {
                return new SharePointOnlineCredentials(userName, GenUtil.BuildSecureString(passWord));
            }
        }

        /// <summary>
        /// </summary>
        private void ctx_ExecutingWebRequest_FixForMixedMode(object sender, WebRequestEventArgs e)
        {
            // to support mixed mode auth
            e.WebRequestExecutor.RequestHeaders.Add("X-FORMS_BASED_AUTH_ACCEPTED", "f");
        }

        /// <summary>
        /// </summary>
        private void FixCtxForMixedMode(ClientContext ctx)
        {
            if (!cbIsSPOnline.Checked)
            {
                ctx.ExecutingWebRequest += new EventHandler<WebRequestEventArgs>(ctx_ExecutingWebRequest_FixForMixedMode);
            }
        }




        /// <summary>
        /// </summary>
        private void LoadSettingsFromRegistry()
        {
            var msg = "";
            var json = "";

            if (RegistryHelper.GetRegStuff(out json, out msg) && !json.IsNull())
            {
                var obj = JsonExtensionMethod.FromJson<CustomRegistrySettings>(json);

                tbSiteUrl.Text = obj.siteUrl;
                tbUsername.Text = obj.userName;
                tbPassword.Text = obj.passWord;
                tbDomain.Text = obj.domain;
                cbIsSPOnline.Checked = GenUtil.SafeToBool(obj.isSPOnline);
            }
        }

        /// <summary>
        /// </summary>
        private void SaveSettingsToRegistry()
        {
            var msg = "";

            var obj = new CustomRegistrySettings
            {
                siteUrl = tbSiteUrl.Text.Trim(),
                userName = tbUsername.Text.Trim(),
                passWord = tbPassword.Text.Trim(),
                domain = tbDomain.Text.Trim(),
                isSPOnline = cbIsSPOnline.Checked ? "1" : "0",
            };
            var json = JsonExtensionMethod.ToJson(obj);

            RegistryHelper.SaveRegStuff(json, out msg);
        }





        /// <summary>
        /// </summary>
        private List<int> ConvertToListOfInts(string s)
        {
            var lst = new List<int>();

            if (!s.IsNull())
            {
                lst = GenUtil.NormalizeEol(s)
                    .Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => Convert.ToInt32(x))
                    .Distinct().ToList();
            }

            return lst;
        }

        /// <summary>
        /// </summary>
        private List<string> ConvertToListOfStrings(string s)
        {
            var lst = new List<string>();

            if (!s.IsNull())
            {
                lst = GenUtil.NormalizeEol(s)
                    .Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries)
                    .Distinct().ToList();
            }

            return lst;
        }





        /// <summary>
        /// </summary>
        void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (aboutForm != null)
            {
                aboutForm.Dispose();
            }

            SaveSettingsToRegistry();
        }

        /// <summary>
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// </summary>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (aboutForm == null)
            {
                aboutForm = new AboutForm();
            }

            aboutForm.Show();
            aboutForm.Focus();
        }

        /// <summary>
        /// </summary>
        private void DisableFormControls()
        {
            toolStripStatusLabel1.Text = "Running...";

            imageBandR.Visible = false;
            imageBandRwait.Visible = true;

            btnTestConnection.Enabled = false;

            lnkClear.Enabled = false;
            lnkExport.Enabled = false;

            btnLoadActions.Enabled = false;
            btnSaveSelChanges.Enabled = false;
            btnDelSel.Enabled = false;
            btnAddAction.Enabled = false;
        }

        /// <summary>
        /// </summary>
        private void EnableFormControls()
        {
            toolStripStatusLabel1.Text = "";

            imageBandR.Visible = true;
            imageBandRwait.Visible = false;

            btnTestConnection.Enabled = true;

            lnkClear.Enabled = true;
            lnkExport.Enabled = true;

            btnLoadActions.Enabled = true;
            btnSaveSelChanges.Enabled = true;
            btnDelSel.Enabled = true;
            btnAddAction.Enabled = true;
        }





        /// <summary>
        /// Combine function params as strings with separator, no line breaks.
        /// </summary>
        public string CombineFnParmsToString(params object[] objs)
        {
            string output = "";
            string delim = ": ";

            for (int i = 0; i < objs.Length; i++)
            {
                if (objs[i] == null) objs[i] = "";
                if (i == objs.Length - 1) delim = "";
                output += string.Concat(objs[i], delim);
            }

            return output;
        }

        /// <summary>
        /// Build message for status window, prepend datetime, append message (already combined with separator), append newline chars.
        /// </summary>
        public string BuildCoutMessage(string msg)
        {
            return string.Format("{0}: {1}\r\n", DateTime.Now.ToLongTimeString(), msg);
        }

        /// <summary>
        /// Standard status dumping function, immediately dumps to status window.
        /// </summary>
        public void cout(params object[] objs)
        {
            tbStatus.AppendText(BuildCoutMessage(CombineFnParmsToString(objs)));
        }

        string tcout_buffer;
        int tcout_counter;

        /// <summary>
        /// Threaded status dumping function, uses buffer to only dump to status window peridocially, batch size configured in app.config.
        /// </summary>
        public void tcout(params object[] objs)
        {
            tcout_counter++;
            tcout_buffer += BuildCoutMessage(CombineFnParmsToString(objs));

            var batchSize = statusWindowOutputBatchSize == 0 ? 1 : statusWindowOutputBatchSize;

            if (tcout_counter % batchSize == 0)
            {
                bgw.ReportProgress(0, tcout_buffer);
                InitCoutBuffer();
            }
        }

        /// <summary>
        /// Reset status buffer.
        /// </summary>
        private void InitCoutBuffer()
        {
            tcout_counter = 0;
            tcout_buffer = "";
        }

        /// <summary>
        /// Flush status buffer to status window (since using mod operator).
        /// </summary>
        private void FlushCoutBuffer()
        {
            if (!tcout_buffer.IsNull())
            {
                tbStatus.AppendText(tcout_buffer);
                InitCoutBuffer();
            }
        }

        /// <summary>
        /// Threaded callback function, dump input to status window, already formatted with datetime, combined params, and linebreaks.
        /// </summary>
        private void BgwReportProgress(object sender, ProgressChangedEventArgs e)
        {
            tbStatus.AppendText(e.UserState.ToString());
        }





        /// <summary>
        /// </summary>
        private void lnkClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tbStatus.ResetText();
        }

        /// <summary>
        /// </summary>
        private void lnkExport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SaveLogToFile(null);
            MessageBox.Show("Log saved to EXE folder.");
        }

        /// <summary>
        /// </summary>
        void SaveLogToFile(string action)
        {
            if (!action.IsNull())
            {
                action = action.Trim().ToUpper() + "_";
            }

            var exportFilePath = AppDomain.CurrentDomain.BaseDirectory;
            if (!System.IO.Directory.Exists(exportFilePath.CombineFS("data")))
                System.IO.Directory.CreateDirectory(exportFilePath.CombineFS("data"));
            exportFilePath = exportFilePath.CombineFS("data\\log" + "_" + action.SafeTrim() + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".txt");

            System.IO.File.WriteAllText(exportFilePath, tbStatus.Text + "\r\n[EOF]");

            cout("Log saved to EXE folder.");
        }





        /// <summary>
        /// </summary>
        private string GetExcMsg(Exception ex)
        {
            if (showFullErrMsgs)
                return ex.ToString();
            else
                return ex.Message;
        }





        /// <summary>
        /// </summary>
        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            DisableFormControls();
            InitCoutBuffer();
            tbStatus.Text = "";
            lblNoErrorFound.Visible = lblErrorFound.Visible = ErrorOccurred = false;

            bgw = new BackgroundWorker();
            bgw.DoWork += new DoWorkEventHandler(bgw_TestConnection);
            bgw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgw_TestConnection_End);
            bgw.ProgressChanged += new ProgressChangedEventHandler(BgwReportProgress);
            bgw.WorkerReportsProgress = true;
            bgw.WorkerSupportsCancellation = true;
            bgw.RunWorkerAsync();
        }

        /// <summary>
        /// </summary>
        private void bgw_TestConnection(object sender, DoWorkEventArgs e)
        {
            try
            {
                var targetSite = new Uri(tbSiteUrl.Text.Trim());

                using (ClientContext ctx = new ClientContext(targetSite))
                {
                    ctx.Credentials = BuildCreds();
                    FixCtxForMixedMode(ctx);

                    Site site = ctx.Site;
                    ctx.Load(site, x => x.ServerRelativeUrl);
                    ctx.ExecuteQuery();
                    tcout("Site loaded", site.ServerRelativeUrl);
                }
            }
            catch (Exception ex)
            {
                tcout(" *** ERROR", GetExcMsg(ex));
                ErrorOccurred = true;
            }
        }

        /// <summary>
        /// </summary>
        private void bgw_TestConnection_End(object sender, RunWorkerCompletedEventArgs e)
        {
            FlushCoutBuffer();
            lblErrorFound.Visible = ErrorOccurred; lblNoErrorFound.Visible = !ErrorOccurred;
            EnableFormControls();
        }





        /// <summary>
        /// </summary>
        private void imageBandR_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.bandrsolutions.com/?utm_source=SPUserCustomActionManagerOnline&utm_medium=application&utm_campaign=SPUserCustomActionManagerOnline");
        }







        /// <summary>
        /// </summary>
        private void UpdateGrid(List<UserActionObject> lstUserActionObjs)
        {
            dataGridView1.Rows.Clear();

            foreach (UserActionObject userActionObj in lstUserActionObjs)
            {
                UpdateGrid(userActionObj);
            }
        }

        /// <summary>
        /// </summary>
        private void UpdateGrid(UserActionObject userActionObj)
        {
            int i = 0;
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[i++].Value = false;
            dataGridView1.Rows[n].Cells[i++].Value = userActionObj.id;
            dataGridView1.Rows[n].Cells[i++].Value = userActionObj.name;
            dataGridView1.Rows[n].Cells[i++].Value = userActionObj.descr;
            dataGridView1.Rows[n].Cells[i++].Value = userActionObj.seq.ToString();
            dataGridView1.Rows[n].Cells[i++].Value = userActionObj.scriptSrc;
            dataGridView1.Rows[n].Cells[i++].Value = userActionObj.scriptBlock;
        }








        /// <summary>
        /// </summary>
        private void btnLoadActions_Click(object sender, EventArgs e)
        {
            DisableFormControls();
            InitCoutBuffer();
            tbStatus.Text = "";
            lblNoErrorFound.Visible = lblErrorFound.Visible = ErrorOccurred = false;

            bgw = new BackgroundWorker();
            bgw.DoWork += new DoWorkEventHandler(bgw_LoadActions);
            bgw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgw_LoadActions_End);
            bgw.ProgressChanged += new ProgressChangedEventHandler(BgwReportProgress);
            bgw.WorkerReportsProgress = true;
            bgw.WorkerSupportsCancellation = true;
            bgw.RunWorkerAsync();           
        }

        /// <summary>
        /// </summary>
        private void bgw_LoadActions(object sender, DoWorkEventArgs e)
        {
            var lstUserActionObjs = new List<UserActionObject>();

            try
            {
                var targetSite = new Uri(tbSiteUrl.Text.Trim());

                using (ClientContext ctx = new ClientContext(targetSite))
                {
                    ctx.Credentials = BuildCreds();
                    FixCtxForMixedMode(ctx);

                    Site site = ctx.Site;
                    ctx.Load(site, x => x.ServerRelativeUrl);
                    ctx.ExecuteQuery();
                    tcout("Site loaded", site.ServerRelativeUrl);

                    var spActions = ctx.Site.UserCustomActions;

                    ctx.Load(spActions);
                    ctx.ExecuteQuery();

                    tcout("UserCustomActions Count", spActions.Count);

                    var spActionsSorted = spActions.ToList<UserCustomAction>().OrderBy(x => x.Sequence).ThenBy(x => x.Name);

                    foreach (UserCustomAction spAction in spActionsSorted)
                    {
                        var userActionObj = new BandR.UserActionObject();

                        userActionObj.id = spAction.Id.ToString();
                        userActionObj.name = spAction.Name;
                        userActionObj.descr = spAction.Description;
                        userActionObj.seq = spAction.Sequence;

                        userActionObj.scriptBlock = spAction.ScriptBlock;
                        userActionObj.scriptSrc = spAction.ScriptSrc;

                        lstUserActionObjs.Add(userActionObj);

                        tcout("Found UserCustomAction", userActionObj.id, userActionObj.name, userActionObj.seq);
                        if (!userActionObj.descr.IsNull())
                            tcout("Description", userActionObj.descr);
                        if (!userActionObj.scriptBlock.IsNull())
                            tcout("ScriptBlock", userActionObj.scriptBlock);
                        if (!userActionObj.scriptSrc.IsNull())
                            tcout("ScriptSrc", userActionObj.scriptSrc);
                    }
                }
            }
            catch (Exception ex)
            {
                tcout(" *** ERROR", GetExcMsg(ex));
                ErrorOccurred = true;
            }

            e.Result = new List<object>() { lstUserActionObjs };
        }

        /// <summary>
        /// </summary>
        private void bgw_LoadActions_End(object sender, RunWorkerCompletedEventArgs e)
        {
            FlushCoutBuffer();
            lblErrorFound.Visible = ErrorOccurred; lblNoErrorFound.Visible = !ErrorOccurred;
            EnableFormControls();

            var lstResults = e.Result as List<object>;
            var lstUserActionObjs = lstResults[0] as List<UserActionObject>;

            UpdateGrid(lstUserActionObjs);
        }






        private void btnDelSel_Click(object sender, EventArgs e)
        {
            DisableFormControls();
            InitCoutBuffer();
            tbStatus.Text = "";
            lblNoErrorFound.Visible = lblErrorFound.Visible = ErrorOccurred = false;

            bgw = new BackgroundWorker();
            bgw.DoWork += new DoWorkEventHandler(bgw_DelSel);
            bgw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgw_DelSel_End);
            bgw.ProgressChanged += new ProgressChangedEventHandler(BgwReportProgress);
            bgw.WorkerReportsProgress = true;
            bgw.WorkerSupportsCancellation = true;
            bgw.RunWorkerAsync();           
        }

        /// <summary>
        /// </summary>
        private void bgw_DelSel(object sender, DoWorkEventArgs e)
        {
            var lstUserActionObjs = new List<UserActionObject>();

            try
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    var k = 0;
                    var userActionObj = new BandR.UserActionObject();

                    userActionObj.selected = Convert.ToBoolean(dataGridView1.Rows[i].Cells[k++].Value);
                    userActionObj.id = dataGridView1.Rows[i].Cells[k++].Value.SafeTrim();
                    userActionObj.name = dataGridView1.Rows[i].Cells[k++].Value.SafeTrim();
                    userActionObj.descr = dataGridView1.Rows[i].Cells[k++].Value.SafeTrim();
                    userActionObj.seq = Convert.ToInt32(dataGridView1.Rows[i].Cells[k++].Value);
                    userActionObj.scriptSrc = dataGridView1.Rows[i].Cells[k++].Value.SafeTrim();
                    userActionObj.scriptBlock = dataGridView1.Rows[i].Cells[k++].Value.SafeTrim();

                    lstUserActionObjs.Add(userActionObj);
                }

                var targetSite = new Uri(tbSiteUrl.Text.Trim());

                using (ClientContext ctx = new ClientContext(targetSite))
                {
                    ctx.Credentials = BuildCreds();
                    FixCtxForMixedMode(ctx);

                    Site site = ctx.Site;
                    ctx.Load(site, x => x.ServerRelativeUrl);
                    ctx.ExecuteQuery();
                    tcout("Site loaded", site.ServerRelativeUrl);

                    var spActions = ctx.Site.UserCustomActions;
                    ctx.Load(spActions);
                    ctx.ExecuteQuery();

                    tcout("UserCustomActions Count", spActions.Count);

                    for (int i = spActions.Count - 1; i >= 0; i--)
                    {
                        var curSpAction = spActions[i];

                        if (lstUserActionObjs.Any(x => Guid.Parse(x.id) == curSpAction.Id && x.selected))
                        {
                            curSpAction.DeleteObject();
                            lstUserActionObjs.RemoveAll(x => Guid.Parse(x.id) == curSpAction.Id && x.selected);
                            tcout("Deleting", curSpAction.Id, curSpAction.Name);
                        }
                    }

                    if (ctx.HasPendingRequest)
                    {
                        ctx.ExecuteQuery();
                        tcout("Action(s) deleted.");
                    }                  
                }
            }
            catch (Exception ex)
            {
                tcout(" *** ERROR", GetExcMsg(ex));
                ErrorOccurred = true;
            }

            e.Result = new List<object>() { lstUserActionObjs };
        }

        /// <summary>
        /// </summary>
        private void bgw_DelSel_End(object sender, RunWorkerCompletedEventArgs e)
        {
            FlushCoutBuffer();
            lblErrorFound.Visible = ErrorOccurred; lblNoErrorFound.Visible = !ErrorOccurred;
            EnableFormControls();

            var lstResults = e.Result as List<object>;
            var lstUserActionObjs = lstResults[0] as List<UserActionObject>;

            UpdateGrid(lstUserActionObjs);
        }








        /// <summary>
        /// </summary>
        private void btnAddAction_Click(object sender, EventArgs e)
        {
            // tbActionName optional
            // tbActionDescr optional
            // tbScriptSeq optional, int, default is set in const
            // tbScriptSrc MuEx with next
            // tbScriptBlock MuEx with prev

            if (tbScriptSrc.Text.IsNull() && tbScriptBlock.Text.IsNull())
            {
                return;
            }

            DisableFormControls();
            InitCoutBuffer();
            tbStatus.Text = "";
            lblNoErrorFound.Visible = lblErrorFound.Visible = ErrorOccurred = false;

            bgw = new BackgroundWorker();
            bgw.DoWork += new DoWorkEventHandler(bgw_AddAction);
            bgw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgw_AddAction_End);
            bgw.ProgressChanged += new ProgressChangedEventHandler(BgwReportProgress);
            bgw.WorkerReportsProgress = true;
            bgw.WorkerSupportsCancellation = true;
            bgw.RunWorkerAsync();
        }

        /// <summary>
        /// </summary>
        private void bgw_AddAction(object sender, DoWorkEventArgs e)
        {
            UserActionObject userActionObj = null;

            try
            {
                var targetSite = new Uri(tbSiteUrl.Text.Trim());

                using (ClientContext ctx = new ClientContext(targetSite))
                {
                    ctx.Credentials = BuildCreds();
                    FixCtxForMixedMode(ctx);

                    Site site = ctx.Site;
                    ctx.Load(site, x => x.ServerRelativeUrl);
                    ctx.ExecuteQuery();
                    tcout("Site loaded", site.ServerRelativeUrl);

                    userActionObj = new UserActionObject();

                    userActionObj.name = tbActionName.Text.Trim();
                    userActionObj.descr = tbActionDescr.Text.Trim();
                    userActionObj.seq = GenUtil.SafeToInt(tbScriptSeq.Text.Trim());
                    if (userActionObj.seq <= 0) userActionObj.seq = _defaultSeq;
                    userActionObj.scriptSrc = tbScriptSrc.Text.Trim();
                    userActionObj.scriptBlock = tbScriptBlock.Text.Trim();

                    AddScript(ctx, site, ref userActionObj);
                }
            }
            catch (Exception ex)
            {
                tcout(" *** ERROR", GetExcMsg(ex));
                ErrorOccurred = true;
            }

            e.Result = new List<object>() { userActionObj };
        }

        /// <summary>
        /// </summary>
        private void AddScript(ClientContext ctx, Site site, ref UserActionObject userActionObj)
        {
            UserCustomAction spUserCustomAction = site.UserCustomActions.Add();

            spUserCustomAction.Location = "ScriptLink";

            if (!userActionObj.scriptSrc.IsNull())
            {
                spUserCustomAction.ScriptSrc = userActionObj.scriptSrc;
            }
            
            if (!userActionObj.scriptBlock.IsNull())
            {
                spUserCustomAction.ScriptBlock = userActionObj.scriptBlock;
            }

            if (!userActionObj.descr.IsNull())
            {
                spUserCustomAction.Description = userActionObj.descr;
            }

            if (!userActionObj.name.IsNull())
            {
                spUserCustomAction.Name = userActionObj.name;
            }

            spUserCustomAction.Sequence = userActionObj.seq;

            spUserCustomAction.Update();

            ctx.Load(spUserCustomAction, x => x.Id, x => x.Name);
            ctx.ExecuteQuery();

            userActionObj.id = spUserCustomAction.Id.ToString();

            tcout("Action added", userActionObj.id);
        }

        /// <summary>
        /// </summary>
        private void bgw_AddAction_End(object sender, RunWorkerCompletedEventArgs e)
        {
            FlushCoutBuffer();
            lblErrorFound.Visible = ErrorOccurred; lblNoErrorFound.Visible = !ErrorOccurred;
            EnableFormControls();

            var lstResults = e.Result as List<object>;
            var userActionObj = lstResults[0] as UserActionObject;

            UpdateGrid(userActionObj);

            tbActionName.Text = "";
            tbActionDescr.Text = "";
            tbScriptSeq.Text = "";
            tbScriptSrc.Text = "";
            tbScriptBlock.Text = "";
        }





        /// <summary>
        /// </summary>
        private void btnSaveSelChanges_Click(object sender, EventArgs e)
        {
            DisableFormControls();
            InitCoutBuffer();
            tbStatus.Text = "";
            lblNoErrorFound.Visible = lblErrorFound.Visible = ErrorOccurred = false;

            bgw = new BackgroundWorker();
            bgw.DoWork += new DoWorkEventHandler(bgw_SaveSelChanges);
            bgw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgw_SaveSelChanges_End);
            bgw.ProgressChanged += new ProgressChangedEventHandler(BgwReportProgress);
            bgw.WorkerReportsProgress = true;
            bgw.WorkerSupportsCancellation = true;
            bgw.RunWorkerAsync();           

        }

        private void bgw_SaveSelChanges(object sender, DoWorkEventArgs e)
        {
            var lstUserActionObjs = new List<UserActionObject>();

            try
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    var k = 0;
                    var userActionObj = new BandR.UserActionObject();

                    userActionObj.selected = Convert.ToBoolean(dataGridView1.Rows[i].Cells[k++].Value);
                    userActionObj.id = dataGridView1.Rows[i].Cells[k++].Value.SafeTrim();
                    userActionObj.name = dataGridView1.Rows[i].Cells[k++].Value.SafeTrim();
                    userActionObj.descr = dataGridView1.Rows[i].Cells[k++].Value.SafeTrim();
                    userActionObj.seq = Convert.ToInt32(dataGridView1.Rows[i].Cells[k++].Value);
                    userActionObj.scriptSrc = dataGridView1.Rows[i].Cells[k++].Value.SafeTrim();
                    userActionObj.scriptBlock = dataGridView1.Rows[i].Cells[k++].Value.SafeTrim();

                    lstUserActionObjs.Add(userActionObj);
                }

                var targetSite = new Uri(tbSiteUrl.Text.Trim());

                using (ClientContext ctx = new ClientContext(targetSite))
                {
                    ctx.Credentials = BuildCreds();
                    FixCtxForMixedMode(ctx);

                    Site site = ctx.Site;
                    ctx.Load(site, x => x.ServerRelativeUrl);
                    ctx.ExecuteQuery();
                    tcout("Site loaded", site.ServerRelativeUrl);

                    var spActions = ctx.Site.UserCustomActions;
                    ctx.Load(spActions);
                    ctx.ExecuteQuery();

                    tcout("UserCustomActions Count", spActions.Count);

                    for (int i = spActions.Count - 1; i >= 0; i--)
                    {
                        var changed = false;
                        var curSpAction = spActions[i];
                        var curGridAction = lstUserActionObjs.FirstOrDefault(x => Guid.Parse(x.id) == curSpAction.Id); // && x.selected

                        if (curGridAction != null)
                        {
                            if (curGridAction.scriptSrc.IsNull() && curGridAction.scriptBlock.IsNull())
                            {
                                // invalid option
                                tcout(" *** Skipping update, cannot save CustomAction with both ScriptSrc and ScriptBlock filled", curGridAction.id, curGridAction.name);
                                continue;
                            }

                            if (curSpAction.Name != curGridAction.name && !curGridAction.name.IsNull())
                            {
                                curSpAction.Name = curGridAction.name;
                                changed = true;
                            }

                            if (curSpAction.Description != curGridAction.descr)
                            {
                                curSpAction.Description = curGridAction.descr.IsNull() ? null : curGridAction.descr;
                                changed = true;
                            }

                            if (curSpAction.Sequence != curGridAction.seq)
                            {
                                curSpAction.Sequence = curGridAction.seq <= 0 ? _defaultSeq : curGridAction.seq;
                                changed = true;
                            }

                            if (curSpAction.ScriptSrc != curGridAction.scriptSrc)
                            {
                                curSpAction.ScriptSrc = curGridAction.scriptSrc.IsNull() ? null : curGridAction.scriptSrc;
                                changed = true;
                            }

                            if (curSpAction.ScriptBlock != curGridAction.scriptBlock)
                            {
                                curSpAction.ScriptBlock = curGridAction.scriptBlock.IsNull() ? null : curGridAction.scriptBlock;
                                changed = true;
                            }

                            if (changed)
                            {
                                curSpAction.Update();
                            }
                        }
                    }

                    if (ctx.HasPendingRequest)
                    {
                        ctx.ExecuteQuery();
                        tcout("Action(s) updated.");
                    }
                }
            }
            catch (Exception ex)
            {
                tcout(" *** ERROR", GetExcMsg(ex));
                ErrorOccurred = true;
            }

            e.Result = new List<object>() { lstUserActionObjs };
        }

        private void bgw_SaveSelChanges_End(object sender, RunWorkerCompletedEventArgs e)
        {
            FlushCoutBuffer();
            lblErrorFound.Visible = ErrorOccurred; lblNoErrorFound.Visible = !ErrorOccurred;
            EnableFormControls();

            var lstResults = e.Result as List<object>;
            var lstUserActionObjs = lstResults[0] as List<UserActionObject>;

            UpdateGrid(lstUserActionObjs);
        }











        private void tbActionName_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Optional, if left blank the CustomAction GUID will be used.";
        }

        private void tbActionName_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";

        }

        private void tbScriptSeq_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Required, but if left blank the default value " + _defaultSeq.ToString() + " will be used.";
        }

        private void tbScriptSeq_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void tbScriptSrc_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "URL to JavaScript file. Cannot be external domain, must be in SharePoint. Supports placeholders like '~SiteCollection' or '~Site'.";
        }

        private void tbScriptSrc_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void tbScriptBlock_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter actual JavaScript here to run in browser.";
        }

        private void tbScriptBlock_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void dataGridView1_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = ""; // TBD
        }

        private void dataGridView1_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }






    }
}
