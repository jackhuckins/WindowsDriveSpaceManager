﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Windows_Drive_Space_Manager_Web
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DiskSpaceResources.Resources.PrepareDiskTable("MB");
            gvResults.DataSource = DiskSpaceResources.Resources.DiskTable;
            gvResults.DataBind();
        }
    }
}
