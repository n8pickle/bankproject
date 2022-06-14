using Domain;
using System.Threading.Tasks;
namespace Services;

public interface ITransactionService {
    Task CreateTransaction(Transaction trans);
    Task<List<Transaction>> GetAllTransactionsByAccount(int accountId);
}