using Domain;
using System.Threading.Tasks;
namespace Repository;

public interface IAccountRepository {
    Task CreateAccount(Account account);
    Task<List<Account>> GetAccountByUserId(int accountId);
    Task UpdateAccountBalance(int amount, int accountId);
    Task UpdateAccountData(Account account);
    Task DeleteAccount(int accountId);
}