using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    [Table(Name = "ChatMessage")]
    public class ChatMessage
    {
        [Column(Name = "id", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column(Name = "[time]")]
        public DateTime Time { get; set; }
        [Column(Name = "message")]
        public string Message { get; set; }
        [Column(Name = "sender" )] private int? userId;
        private EntityRef<User> _user = new EntityRef<User>( );
        [Association(IsForeignKey = true, Storage = "_user", ThisKey = "userId" )]
        public User Sender {
            get { return _user.Entity; }
            set { _user.Entity = value; }
        }

        public ChatMessage(string message, User user)
        {
            this.Message = message;
            this.Sender = user;
            this.Time = DateTime.Now;
        }

        public ChatMessage()
        {
            this.Time = DateTime.Now;
        }
    }
}
