namespace Domain;

public class Transaction {
    public int Id {get; set;}
    public int UserId {get; set;}
    public int TransactionTypeId {get; set;}
    public DateTime TransactionDate {get; set;}
    public int AccountIdId {get; set;}
}