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
            return dbChatMessage.SendMessageToFile(chatMessage, myFile.Id);
        }
    }
}
