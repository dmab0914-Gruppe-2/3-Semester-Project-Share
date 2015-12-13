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
        public bool SendMessageToFile(Library.ChatMessage message, Library.File file)
        {
            return chatController.SendMessage(message, file);
            throw new NotImplementedException();
        }


        public List<Library.ChatMessage> GetLast20MessagesFromFile(Library.File file)
        {
            return chatController.GetLast20MessagesFromFile(file);
            throw new NotImplementedException();
        }


        public List<Library.ChatMessage> GetNewMessagesFromFile(Library.File file, int lastMessage)
        {
            return chatController.GetNewMessagesFromFile(file, lastMessage);
        }
    }
}
