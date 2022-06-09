namespace Repository;

public interface IAccountRepository {
    Task UpdateAccountBalance(int amount, int accountId);
}