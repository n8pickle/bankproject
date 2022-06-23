using System.Threading.Tasks;
using Domain;
namespace Repository;

public interface ITransactionRepository {
    Task CreateTransaction(Transaction transaction);
    Task<List<Transaction>> GetAllTransactionsByAccount(int accountId);
    Task<List<Transaction>> GetAllTransactionsByUserId(int userId);
    Task DeleteTransactionsByAccount(int accoundId);
    Task DeleteTransactionById(int transactionId);
    Task<Transaction> GetTransactionById(int transactionId);

}