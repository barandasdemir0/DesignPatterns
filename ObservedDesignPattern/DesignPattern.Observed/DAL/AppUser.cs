using Microsoft.AspNetCore.Identity;

namespace DesignPattern.Observed.DAL
{
    public class AppUser:IdentityUser<int> //ıd değeri string olarak tutulur ıdentity kütüphanesinde ama int olarak tutuyoruz böylece int ekledik ve aşağıda ıdentity Kütüphanesine ekleme yapıyoruz yani özelleştiriyoruz
    {
        public string? Name { get; set; }
        public string? SurName { get; set; }
        public string? City { get; set; }
        public string? District { get; set; }
    }
}
