using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using Server.Database;

namespace Server
{
    public class ChatController : IChatController
    {
        //private DbContext dbContext;
        private readonly IDbChatMessage dbChatMessage;

        public ChatController()
        {
            dbChatMessage = new DbChatMessage();
        }

        public bool SendMessage(Library.ChatMessage chatMessage, Library.File myFile)
        {
            if (chatMessage.Sender == null)
            {
                return false;
            }
            else if (chatMessage.Message.Equals(""))
            {
                return false;
            }
            if (myFile == null)
            {
                return false;
            }
            else if (myFile.Id == 0)
            {
                return false;
            }
            
            return dbChatMessage.SendMessageToFile(chatMessage, myFile.Id);
        }

        public List<ChatMessage> GetLast20MessagesFromFile(Library.File file)
        {
            if (file == null)
            {
                return null;
            }
            else
            {
                return dbChatMessage.GetTop20ChatMessages(file.Id);
            }

        }


        public List<ChatMessage> GetNewMessagesFromFile(File file, int lastMessageId)
        {
            if (file == null)
            {
                return null;
            }
            else
            {
                return dbChatMessage.GetMoreChatMessages(file.Id, lastMessageId);
            }
            throw new NotImplementedException();
        }
    }
}
