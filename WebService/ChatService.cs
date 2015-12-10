using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Server;

namespace WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ChatService" in both code and config file together.
    public class ChatService : IChatService
    {
        IChatController chatController = new ChatController();
        public bool SendMessage(Library.ChatMessage message, Library.File file)
        {
            return chatController.SendMessage(message, file);
            throw new NotImplementedException();
        }
    }
}
