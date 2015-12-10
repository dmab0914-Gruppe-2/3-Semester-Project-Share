using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if (myFile.Title.Equals(""))
            {
                return false;
            }
            else if (myFile.Id != 0)
            {
                return false;
            }
            
            return dbChatMessage.SendMessageToFile(chatMessage, myFile.Id);
        }
    }
}
