using System.Threading.Tasks;
using Domain;
namespace Repository;

public interface ITransactionRepository {
    Task CreateTransaction(Transaction transaction);
    Task<List<Transaction>> GetAllTransactionsByAccount(int accountId);
}