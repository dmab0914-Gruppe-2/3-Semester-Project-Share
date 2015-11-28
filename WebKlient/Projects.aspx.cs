using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Projects : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ProjectService.ProjectServiceClient projectService = new ProjectService.ProjectServiceClient();
        ListView1.DataSource = projectService.GetAllProjects().ToList();
        ListView1.DataBind();
         //   projectService.GetProject(1).
    }
}