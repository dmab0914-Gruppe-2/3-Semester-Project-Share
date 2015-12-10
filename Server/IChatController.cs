using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public interface IChatController
    {
        bool SendMessage(Library.ChatMessage chatMessage, Library.File myFile);
    }
}
