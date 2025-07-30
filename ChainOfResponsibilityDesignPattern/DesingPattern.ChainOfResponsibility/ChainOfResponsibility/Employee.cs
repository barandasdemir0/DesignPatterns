using DesingPattern.ChainOfResponsibility.Models;

namespace DesingPattern.ChainOfResponsibility.ChainOfResponsibility
{

    // Soyut (abstract) sınıf: Zincirdeki her bir çalışanın ortak özelliği
    public abstract class Employee
    {

        // Zincirdeki bir sonraki çalışanı tutacak alan (protected: alt sınıflar görebilir)
        protected Employee NextApprover;
        // Zincirin bir sonraki halkasını ayarlayan metot
        public void SetNextApprover(Employee superVisor)
        {
            this.NextApprover = superVisor;
        }

        // Alt sınıfların zorunlu olarak override edeceği soyut işlem metodu
        public abstract void ProcessRequest(CustomerProcessViewModel req);
    }
}
