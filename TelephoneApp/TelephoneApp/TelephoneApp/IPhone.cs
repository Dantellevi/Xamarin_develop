using System.Threading.Tasks;

namespace TelephoneApp
{
   public interface IPhone
    {
        Task Call(string phoneNumber);
    }
}
