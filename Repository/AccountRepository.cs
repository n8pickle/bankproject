using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Database;
using Domain;
namespace Repository;

public class AccountRepository : IAccountRepository {

    private MyDbContext _dbContext;

    public AccountRepository(MyDbContext dbContext) {
        _dbContext = dbContext;
    }
    public async Task UpdateAccountBalance(int amount, int accountId) {
        var account = await _dbContext.Account.Where((a) => a.Id == accountId).FirstOrDefaultAsync();
        if (account == null) {
            throw new Exception("The account could not be found");
        }
        
        account.Balance += amount;
        await _dbContext.SaveChangesAsync();
    }
}