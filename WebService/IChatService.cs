using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Library;

namespace WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IChatService" in both code and config file together.
    [ServiceContract]
    public interface IChatService
    {
        [OperationContract]
        bool SendMessageToFile(Library.ChatMessage message, Library.File file);

        [OperationContract]
        List<ChatMessage> GetLast20MessagesFromFile(Library.File file);
        
        [OperationContract]
        List<ChatMessage> GetNewMessagesFromFile(Library.File file, int lastMessage);
    }
}
