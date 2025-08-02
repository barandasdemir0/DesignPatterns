using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.DecoratorPattern2
{
    public class Decorator : ISendMessage
    {

        private readonly ISendMessage _sendMessage;

        public Decorator(ISendMessage sendMessage)
        {
            _sendMessage = sendMessage;
        }

        virtual public void SendMessage(Message message)
        {
            message.MessageReceiver = "EveryBody";
            message.MessageSender = "Admin";
            message.MessageContent = "Bu bir toplantı mesajıdır";
            message.MessageSubject = "Toplantı";
            _sendMessage.SendMessage(message);
        }
    }
}
