using System.Threading.Tasks;
using Database;
using Domain;
namespace Repository;

// This is the class that talks to the database
public class TransactionRepository : ITransactionRepository {
    private MyDbContext _dbContext;

    // This is the database context. It allows us to access the database
    public TransactionRepository(MyDbContext dbContext) {
        _dbContext = dbContext;
    }

    public async Task CreateTransaction(Transaction trans) {
        // Make sure the method that you use is Async
        await _dbContext.Transaction.AddAsync(trans);
        // Make sure to save changes if you add or update the database
        await _dbContext.SaveChangesAsync();
    }
}