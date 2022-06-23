using System.Threading.Tasks;
using Domain;
namespace Services;

public interface IAccountService {
    Task CreateAccount(Account account);
    Task<List<Account>> GetAccountByUserId(int accountId);
    Task UpdateAccountBalance(int amount, int accountId);
    Task UpdateAccountData(Account account);
    Task DeleteAccount(int accountId);
}