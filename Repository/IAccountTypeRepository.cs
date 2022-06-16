using System.Threading.Tasks;
using Domain;
namespace Repository;

public interface IAccountTypeRepository {
    Task CreateAccountType(AccountType accountType);
    Task<AccountType> GetAccountType(int accountId);
}