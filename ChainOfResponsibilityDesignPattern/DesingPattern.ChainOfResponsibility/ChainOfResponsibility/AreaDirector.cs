using DesingPattern.ChainOfResponsibility.DAL;
using DesingPattern.ChainOfResponsibility.Models;

namespace DesingPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public class AreaDirector : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();
            if (req.Amount <= 400000)
            {
                CustomerProcess customer = new();
                customer.Amount = req.Amount.ToString();
                customer.Name = req.Name;
                customer.EmployeeNameSurname = "Bölge Müdürü - Zeynep Yılmaz";
                customer.Description = "Para İşlemi Onaylandı,müşterinin talep ettiği tutar ödendi";
                context.CustomerProcesses.Add(customer);
                context.SaveChanges();
            }
            else
            {
                CustomerProcess customer = new();
                customer.Amount = req.Amount.ToString();
                customer.Name = req.Name;
                customer.EmployeeNameSurname = "Bölge Müdürü - Zeynep Yılmaz";
                customer.Description = "Para İşlemi Onaylanmadı,müşterinin talep ettiği tutar ödenemedi işlem Bölge müdürünün günlük limitini aştığı için Gerçekleştirilemedi";
                context.CustomerProcesses.Add(customer);
                context.SaveChanges();
                NextApprover.ProcessRequest(req);

            }
        }
    }
}
