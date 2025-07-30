using DesingPattern.ChainOfResponsibility.DAL;
using DesingPattern.ChainOfResponsibility.Models;

namespace DesingPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public class Treasurer : Employee//veznedar
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();
            if (req.Amount <= 100000)
            {
                CustomerProcess customer = new();
                customer.Amount = req.Amount.ToString();
                customer.Name = req.Name;
                customer.EmployeeNameSurname = "Veznedar - Ayşe Çınar";
                customer.Description = "Para İşlemi Onaylandı,müşterinin talep ettiği tutar ödendi";
                context.CustomerProcesses.Add(customer);
                context.SaveChanges();
            }
            else if(NextApprover != null)
            {
                CustomerProcess customer = new();
                customer.Amount = req.Amount.ToString();
                customer.Name = req.Name;
                customer.EmployeeNameSurname = "Veznedar - Ayşe Çınar";
                customer.Description = "Para İşlemi Onaylanmadı,müşterinin talep ettiği tutar ödenemedi işlem müdür yardımcısına yönlendirildi";
                context.CustomerProcesses.Add(customer);
                context.SaveChanges();
                NextApprover.ProcessRequest(req);

            }
        }
    }
}
