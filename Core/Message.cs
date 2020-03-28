using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Message
    {
        public long MessageID{get;}
        public string TextMessage { get; set;}
        public User MsgReceiver { get; set;}
        public User MsgSender { get; set;}
        public Chat ChatField { get; set;}
        public List <Attachment> Attachments { get; set;}
        public DateTime MesssageDT { get;}

        public Message(long messageID, string textMessage, User msgReceiver, User msgSender, Chat chatField, DateTime messsageDT)
        {
            MessageID = messageID;
            TextMessage = textMessage ?? throw new ArgumentNullException(nameof(textMessage));
            MsgReceiver = msgReceiver ?? throw new ArgumentNullException(nameof(msgReceiver));
            MsgSender = msgSender ?? throw new ArgumentNullException(nameof(msgSender));
            ChatField = chatField ?? throw new ArgumentNullException(nameof(chatField));
            MesssageDT = messsageDT;
        }

        public void AddAttachment(Attachment attachment)
        {
            Attachments.Add(attachment);
        }
    }
}
