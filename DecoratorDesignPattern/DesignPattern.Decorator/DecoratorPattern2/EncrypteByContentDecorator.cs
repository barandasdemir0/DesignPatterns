using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.DecoratorPattern2
{
    public class EncrypteByContentDecorator : Decorator
    {

        private readonly ISendMessage _sendMessage;
        Context context = new Context();
        public EncrypteByContentDecorator(ISendMessage sendMessage) : base(sendMessage)
        {
            _sendMessage = sendMessage;
        }
        public void SendMessageByEncryptoContent(Message message)
        {
            message.MessageSender = "Takım Lideri";
            message.MessageReceiver = "Yazılım Ekibi";
            message.MessageContent = "Saat 17 de publish islemi var";
            message.MessageSubject = "publish";
            string data = "";
            data = message.MessageSubject;
            char[] chars = data.ToCharArray();
            foreach (var item in chars)
            {
                message.MessageContent += Convert.ToChar(item + 3).ToString();
            }
            context.Messages.Add(message);
            context.SaveChanges();

        }

        public override void SendMessage(Message message)
        {
            base.SendMessage(message);
            SendMessageByEncryptoContent(message);
        }
    }
}
