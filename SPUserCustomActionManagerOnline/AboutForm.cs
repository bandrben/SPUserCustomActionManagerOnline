using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SPUserCustomActionManagerOnline
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();

            tbAbout.Text = @" *** Welcome to SPUserCustomActionManagerOnline ***

Created by Ben Steinhauser of B&R Business Solutions.

=====================================================

Sample to add jQuery to site:
* Assuming jQuery file is in root site of site collection Site Assets library.

ScriptSrc:
~SiteCollection/SiteAssets/jquery-1.11.3.min.js

ScriptBlock:
$(document).ready(function () {
  console.log(""helloworld."");
});


=====================================================
SharePoint URL Token Replacement:

~controlTemplates
The URL of the ControlTemplates virtual folder for the current website.

~layouts
The URL of the Layouts virtual folder for the current website.

~site
The URL of the current website.

~sitecollection
The URL of the parent site collection of the current website.

";

            tbAbout.AppendText(" ");
            tbAbout.ReadOnly = true;

        }
    }
}
