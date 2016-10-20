using BandR;
using Microsoft.SharePoint.Client;
using System;
using System.IO;
using System.Security;
using System.Linq;
using System.Linq.Expressions;
using System.Collections;
using System.Collections.Generic;

namespace SPCustomActionConsoleTester
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CreateLogOutputFile();

                cout("Started...");
                cout();

                //Test_DeleteActions();
                //Test_ReadActions();
                //Test_ReadSingleAction();
                Test_AddAction();

            }
            catch (Exception exc)
            {
                cout("ERROR", exc.ToString());
            }

            cout();
            cout("Done. Press any key.");
            Console.ReadLine();

            if (_file != null)
            {
                _file.Dispose();
            }
        }

        /// <summary>
        /// </summary>
        private static void Test_DeleteActions()
        {
            var targetSite = new Uri("https://banderaapps.sharepoint.com/sites/dev");
            var login = "bsteinhauser@banderaapps.onmicrosoft.com";
            var password = "Changeme18!";

            var securePassword = new SecureString();
            foreach (char c in password)
            {
                securePassword.AppendChar(c);
            }

            var onlineCredentials = new SharePointOnlineCredentials(login, securePassword);

            using (ClientContext ctx = new ClientContext(targetSite))
            {
                ctx.Credentials = onlineCredentials;

                Web web = ctx.Web;
                ctx.Load(web, w => w.Title);
                ctx.ExecuteQuery();
                cout(web.Title);

                var actions = ctx.Site.UserCustomActions;

                ctx.Load(actions);
                ctx.ExecuteQuery();

                cout("actions count", actions.Count);

                for (int i = actions.Count - 1; i >= 0; i--)
                {
                    var curAction = actions[i];

                    if (curAction.Name.StartsWith("TestHelloWorld"))
                    {
                        curAction.DeleteObject();
                        cout("Deleting", curAction.Id, curAction.Name, curAction.ScriptSrc);
                    }
                }

                if (ctx.HasPendingRequest)
                {
                    ctx.ExecuteQuery();
                    cout("Action(s) deleted.");
                }

            }
        }

        /// <summary>
        /// </summary>
        private static void Test_ReadSingleAction()
        {
            var targetSite = new Uri("https://banderaapps.sharepoint.com/sites/dev");
            var login = "bsteinhauser@banderaapps.onmicrosoft.com";
            var password = "Changeme18!";

            var securePassword = new SecureString();
            foreach (char c in password)
            {
                securePassword.AppendChar(c);
            }

            var onlineCredentials = new SharePointOnlineCredentials(login, securePassword);

            using (ClientContext ctx = new ClientContext(targetSite))
            {
                ctx.Credentials = onlineCredentials;

                Web web = ctx.Web;
                ctx.Load(web, w => w.Title);
                ctx.ExecuteQuery();
                cout(web.Title);

                var actions = ctx.Site.UserCustomActions;

                ctx.Load(actions);
                ctx.ExecuteQuery();

                cout("actions count", actions.Count);

                foreach (UserCustomAction action in actions)
                {
                    if (action.ScriptSrc.Contains("TestHelloWorld.js"))
                    {
                        cout(" -- ", action.Id, action.Name, action.ScriptSrc);
                    }
                }

            }
        }

        /// <summary>
        /// </summary>
        private static void Test_AddAction()
        {
            var targetSite = new Uri("https://banderaapps.sharepoint.com/sites/dev");
            var login = "bsteinhauser@banderaapps.onmicrosoft.com";
            var password = "Changeme18!";

            var securePassword = new SecureString();
            foreach (char c in password)
            {
                securePassword.AppendChar(c);
            }

            var onlineCredentials = new SharePointOnlineCredentials(login, securePassword);

            using (ClientContext ctx = new ClientContext(targetSite))
            {
                ctx.Credentials = onlineCredentials;

                Web web = ctx.Web;
                ctx.Load(web, w => w.Title);
                ctx.ExecuteQuery();
                cout(web.Title);

                AddScript(ctx, "TestHelloWorld1", null, 1000, "~SiteCollection/SiteAssets/TestHelloWorld1.js", null);
                AddScript(ctx, "TestHelloWorld2", null, 1000, "~SiteCollection/SiteAssets/TestHelloWorld2.js", null);
                AddScript(ctx, "TestHelloWorldCust3", null, 1000, null, "console.log('hello world from cust3.');");

            }
        }

        /// <summary>
        /// </summary>
        private static void AddScript(ClientContext ctx, string name, string descr, int seq, string scriptSrc, string scriptBlock)
        {
            var site = ctx.Site;
            UserCustomAction customAction = site.UserCustomActions.Add();
            customAction.Location = "ScriptLink";

            if (!scriptSrc.IsNull())
            {
                customAction.ScriptSrc = scriptSrc; // "~SiteCollection/SiteAssets/TestHelloWorld1.js";
            }
            else if (!scriptBlock.IsNull())
            {
                customAction.ScriptBlock = scriptBlock;
            }
            else
            {
                cout("ABORT: no script src or block found.");
                return;
            }

            if (!descr.IsNull()) customAction.Description = descr;
            if (!name.IsNull()) customAction.Name = name;

            customAction.Sequence = seq;

            customAction.Update();

            ctx.ExecuteQuery();

            cout("Custom Action Added.", scriptSrc.IsNull() ? scriptBlock : scriptSrc);
        }

        /// <summary>
        /// </summary>
        private static void Test_ReadActions()
        {
            var targetSite = new Uri("https://banderaapps.sharepoint.com/sites/dev");
            var login = "bsteinhauser@banderaapps.onmicrosoft.com";
            var password = "Changeme18!";

            var securePassword = new SecureString();
            foreach (char c in password)
            {
                securePassword.AppendChar(c);
            }

            var onlineCredentials = new SharePointOnlineCredentials(login, securePassword);

            using (ClientContext ctx = new ClientContext(targetSite))
            {
                ctx.Credentials = onlineCredentials;

                Web web = ctx.Web;
                ctx.Load(web, w => w.Title);
                ctx.ExecuteQuery();
                cout(web.Title);

                var actions = ctx.Site.UserCustomActions;

                ctx.Load(actions);
                ctx.ExecuteQuery();

                cout("actions count", actions.Count);

                foreach (UserCustomAction action in actions)
                {
                    cout(" -- ", action.Id, action.Name, action.ScriptSrc);

                }


            }
        }

        #region "Ouput"

        /// <summary>
        /// </summary>
        static void cout(params object[] objs)
        {
            string output = "";

            for (int i = 0; i < objs.Length; i++)
            {
                if (objs[i] == null) objs[i] = "";

                string delim = " : ";

                if (i == objs.Length - 1) delim = "";

                output += string.Format("{0}{1}", objs[i], delim);
            }
            output += Environment.NewLine;

            Console.Write(output);

            coutFile(objs);
        }

        /// <summary>
        /// </summary>
        static void coutFile(params object[] objs)
        {
            string output = "";

            for (int i = 0; i < objs.Length; i++)
            {
                if (objs[i] == null) objs[i] = "";

                string delim = "";

                if (!outToCsv)
                {
                    delim = " : ";
                }
                else
                {
                    objs[i] = NormalizeForCsv(objs[i].ToString());
                    delim = ",";
                }

                if (i == objs.Length - 1) delim = "";

                output += string.Format("{0}{1}", objs[i], delim);
            }
            output += Environment.NewLine;

            _file.Write(output);
        }

        /// <summary>
        /// </summary>
        static string NormalizeForCsv(string s)
        {
            s = System.Text.RegularExpressions.Regex.Replace(s, @"\r\n|\n\r|\n|\r", "\r\n");

            if (s.Contains(",") || s.Contains("\r\n"))
            {
                s = string.Concat("\"", s, "\"");
            }

            return s;
        }

        /// <summary>
        /// </summary>
        private static void CreateLogOutputFile()
        {
            _file = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory.TrimEnd(new char[] { '\\' }) + "\\output.txt");
        }

        private static StreamWriter _file;
        private static DateTime _curDateTime = DateTime.Now;
        private const bool outToCsv = false;

        #endregion

    }
}
