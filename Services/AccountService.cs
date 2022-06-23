using Repository;
using Domain;
using Domain.DTO;
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

    public async Task<List<Account>> GetAccountByUserId(int userId) {
        return await _accountRepo.GetAccountByUserId(userId);
    }

    public async Task UpdateAccountBalance(int amount, int accountId) {
        await _accountRepo.UpdateAccountBalance(amount, accountId);
    }

    public async Task UpdateAccountData(Account account) {
        await _accountRepo.UpdateAccountData(account);
    }
    
    public async Task DeleteAccount(int accountId) {
        await _accountRepo.DeleteAccount(accountId);
    }

    public async Task TransferBalance(Transfer transfer) {
        await _accountRepo.TransferBalance(transfer);
    }

    public async Task Deposit(Balance balance) {
        // await new Promise();
        return;
    }
}