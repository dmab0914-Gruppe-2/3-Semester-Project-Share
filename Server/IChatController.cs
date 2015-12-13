using System.Collections.Generic;

namespace Server
{
    public interface IChatController
    {
        bool SendMessage(Library.ChatMessage chatMessage, Library.File myFile);
        List<Library.ChatMessage> GetLast20MessagesFromFile(Library.File file);

        List<Library.ChatMessage> GetNewMessagesFromFile(Library.File file, int lastMessageId);
    }
}
