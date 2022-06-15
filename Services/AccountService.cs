using Repository;
using Domain;
using System.Threading.Tasks;
namespace Services;

public class AccountService : IAccountService {

    private IAccountRepository _accountRepo;
    public AccountService(IAccountRepository accountRepo) {
        _accountRepo = accountRepo;
    }

    public async Task CreateAccount(Account account) {
        await _accountRepo.CreateAccount(account);
    }
}