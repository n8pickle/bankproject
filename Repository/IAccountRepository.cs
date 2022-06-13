using Domain;
using System.Threading.Tasks;
namespace Repository;

public interface IAccountRepository {
    Task CreateAccount(Account account);
    Task UpdateAccountBalance(int amount, int accountId);
}