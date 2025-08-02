using DesignPattern.Decorator.DAL;
using DesignPattern.Decorator.DecoratorPattern2;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.Kestrel.Transport.NamedPipes;

namespace DesignPattern.Decorator.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            Message message = new Message();
            message.MessageContent = "Bu bir content Mesajı";
            message.MessageSender = "ADMİN İK";
            message.MessageReceiver = "Herkes";
            message.MessageSubject = "Deneme Yapıyoruz";
            CreateNewMessage createNewMessage = new CreateNewMessage();
            createNewMessage.SendMessage(message);
            return View();
        }
        public IActionResult Index2()
        {
            Message message = new Message();
            message.MessageContent = "Bu bir şifreli subject Mesajı";
            message.MessageSender = "Team Leader";
            message.MessageReceiver = "Herkes";
            message.MessageSubject = "Merhaba";
            CreateNewMessage createNewMessage = new CreateNewMessage();
            EncryptoBySubject encryptoBySubject = new EncryptoBySubject(createNewMessage);
            encryptoBySubject.SendMessageByEncryptoSubject(message);
            return View();
        }
    }
}
