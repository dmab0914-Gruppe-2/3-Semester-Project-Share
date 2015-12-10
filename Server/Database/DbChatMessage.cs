using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Library;

namespace Server.Database
{
    public class DbChatMessage : IDbChatMessage
    {
        private DbContext dbContext;
        private DbFile dbFile;
        //private DbUser dbUser;
        private IUserController userController;

        public DbChatMessage()
        {
            dbContext = new DbContext();
            dbFile = new DbFile();
            userController = new UserController();
            //dbUser = new DbUser();
        }

        /// <summary>
        /// Adds a message to the ChatMessage table and adds the references to FileChats
        /// </summary>
        /// <param name="chatMessage">a ChatMessage</param>
        /// <param name="fileId">fileId for the given file the message is going to be added to</param>
        /// <returns></returns>
        public bool SendMessageToFile(ChatMessage chatMessage, int fileId)
        {
            try
            {
                File file = dbFile.GetFile(fileId);
                chatMessage.Sender = userController.FindUserById(chatMessage.Sender.Id);
                TransactionOptions options = new TransactionOptions();
                options.IsolationLevel = IsolationLevel.ReadCommitted;
                using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, options))
                {
                    dbContext.ChatMessages.InsertOnSubmit(chatMessage);
                    dbContext.FileChats.InsertOnSubmit(new FileChat{chatMessage = chatMessage, file = file});
                    dbContext.SubmitChanges();
                    scope.Complete(); //TODO check if the data added to db were sucessfull / valid.
                }
            }
            catch (Exception e)
            {
                return false;
                throw new Exception("Chat not added to file \n" + e);
            }
            return true;
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the top 20 messages
        /// </summary>
        /// <returns>top 20 messages to file</returns>
        public List<ChatMessage> GetTop20ChatMessages(int fileId)
        {
            List<ChatMessage> messages = new List<ChatMessage>();
            var list = 
                (from filechat in dbContext.FileChats
                where filechat.file.Id == fileId
                orderby filechat.chatMessage.Id
                 select filechat.chatMessage.Id).Take(20);
            foreach (int messageId in list)
            {
                messages.Add(GetChatMessage(messageId));
            }
            return messages;

            //var messages = (from chatMessage in dbContext.ChatMessages
            //                orderby chatMessage.Id
            //                select chatMessage).Take(20);
            //return messages.ToList();
        }


        public List<ChatMessage> GetMoreChatMessages(int from, int fileId)
        {
            throw new NotImplementedException();
        }

        public ChatMessage GetChatMessage(int id)
        {
            ChatMessage message = 
                (from chat in dbContext.ChatMessages
                where chat.Id == id
                select chat).SingleOrDefault();
            return message;
        }
    }
}
