using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FileService;
using Library;

public partial class File : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        ChatService.ChatServiceClient chatService = new ChatService.ChatServiceClient();
        FileService.FileUpLoadServiceClient fileService = new FileService.FileUpLoadServiceClient();
      //  var id = Convert.ToInt32(Request.QueryString[ID]);
      //  string qs = Request.QueryString[ID];
        string param1 = Request.Url.ToString().Split('=')[1];
        int id = Convert.ToInt32(param1);
        Library.File hest = fileService.getFileById(id);
        List<ChatMessage> kat = chatService.GetLast20MessagesFromFile(hest).ToList();
        Repeater2.DataSource = kat;
        Repeater2.DataBind();
      
    }
}