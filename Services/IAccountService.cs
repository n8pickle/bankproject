using System.Threading.Tasks;
using Domain;
namespace Services;

public interface IAccountService {
    Task CreateAccount(Account account);
}