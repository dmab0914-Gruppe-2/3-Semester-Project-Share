using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    [Table(Name = "FileChat")]
    public class FileChat
    {

        [Column(IsPrimaryKey = true, Name = "fileID")]
        private int fileId;
        private EntityRef<File> _file;
        [Association(IsForeignKey = true, Storage = "_file", ThisKey = "fileId")]
        public File file
        {
            get { return _file.Entity; }
            set { _file.Entity = value; }
        }

        [Column(IsPrimaryKey = true, Name = "chatMessageID")]
        private int chatMessageId;
        private EntityRef<ChatMessage> _chatMessage;
        [Association(IsForeignKey = true, Storage = "_chatMessage", ThisKey = "chatMessageId")]
        public ChatMessage chatMessage
        {
            get { return _chatMessage.Entity; }
            set { _chatMessage.Entity = value; }
        }
    }
}
