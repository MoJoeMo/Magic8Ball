using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magic8Ball.Interfaces;

namespace Magic8Ball.Messages
{
    public class MessageService : IMessageService
    {
        public MessageService()
        {
            SetupMessages();
        }

        private List<string> messages = new List<string>();

        private void SetupMessages()
        {
            messages = new List<string>() { 
                "Signs point to yes.", 
                "Yes.",
                "Reply hazy, try again.", 
                "Without a doubt.", 
                "My sources say no.", 
                "As I see it, yes.", 
                "You may rely on it.", 
                "Concentrate and ask again.", 
                "Outlook not so good.", 
                "It is decidedly so.", 
                "Better not tell you now.", 
                "Very doubtful.", 
                "Yes - definitely.", 
                "It is certain.", 
                "Cannot predict now.", 
                "Most likely.", 
                "Ask again later.", 
                "My reply is no.", 
                "Outlook good.", 
                "Don't count on it."
            };
        }

        public string GetMessage()
        {
            Random random = new Random();
            int index = random.Next(0, messages.Count - 1);

            return messages[index];
        }
    }
}
