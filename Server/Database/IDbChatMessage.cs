using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Server.Database
{
    public interface IDbChatMessage
    {
        bool SendMessageToFile(ChatMessage chatMessage, int fileId);
        List<ChatMessage> GetTop20ChatMessages(int fileId);
        List<ChatMessage> GetMoreChatMessages(int from, int fileId);
        ChatMessage GetChatMessage(int id);
    }
}
