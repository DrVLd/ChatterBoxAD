using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    abstract public class Chat
    {
        public long ChatID{get;}
        public List<Message> ChatMessages { get; set;}

        protected Chat(long chatID)
        {
            ChatID = chatID;
            ChatMessages = new List<Message>();
        }

        public void AddMessage(Message message)
        {
            ChatMessages.Add(message);
        }
    }
}
