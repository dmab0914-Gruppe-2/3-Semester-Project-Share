﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class File : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        FileService.FileUpLoadServiceClient fileService = new FileService.FileUpLoadServiceClient();
    }
}