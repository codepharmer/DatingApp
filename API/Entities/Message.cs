using System;

namespace API.Entities
{
    public class Message
    {
        // public Message(int id, string senderUsername, int recipientId, int recipient, DateTime myProperty)
        // {
        //     this.Id = id;
        //     this.SenderUsername = senderUsername;
        //     this.RecipientId = recipientId;
        //     this.Recipient = recipient;
        //     this.MyProperty = myProperty;

        // }
        public int Id { get; set; }
        public int SenderId { get; set; }
        public string SenderUsername { get; set; }
        public AppUser Sender { get; set; }
        public int RecipientId { get; set; }
        public string RecipientUsername { get; set; }
        public AppUser Recipient { get; set; }
        public string Content { get; set; }
        public DateTime? DateRead { get; set; }
        public DateTime MessageSent { get; set; } = DateTime.UtcNow;
        public bool SenderDeleted { get; set; }
        public bool RecipientDeleted { get; set; } 
    }
}