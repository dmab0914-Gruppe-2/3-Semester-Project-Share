﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Project : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ProjectService.ProjectServiceClient projectService = new ProjectService.ProjectServiceClient();
        FileService.FileUpLoadServiceClient fileService = new FileService.FileUpLoadServiceClient();
       
    }
}