using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.DecoratorPattern2
{
    public class EncryptoBySubject:Decorator
    {
        private readonly ISendMessage _message;
        Context context = new Context();

        public EncryptoBySubject(ISendMessage sendMessage) : base(sendMessage)
        {
            _message = sendMessage;
        }
        public void SendMessageByEncryptoSubject(Message message)
        {
            message.MessageSender = "İnsan Kaynakları";
            message.MessageReceiver = "Yazılım Ekibi";
            message.MessageContent = "Saat 12 de toplantı var";
            message.MessageSubject = "Toplantı";
            string data = "";
            data = message.MessageSubject;
            char[] chars = data.ToCharArray();
            foreach (var item in chars)
            {
                message.MessageSubject += Convert.ToChar(item + 3).ToString();
            }
            context.Messages.Add(message);
            context.SaveChanges();

        }

        public override void SendMessage(Message message)
        {
            base.SendMessage(message);
            SendMessageByEncryptoSubject(message);
        }
    }
}
