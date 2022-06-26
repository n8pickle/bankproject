using System;
namespace Domain;

public class Transaction {
    public int Id {get; set;}
    public Guid UserId {get; set;}
    public int Amount {get; set;}
    public int TransactionTypeId {get; set;}
    public DateTime TransactionDate {get; set;}
    public int AccountId {get; set;}
    public int TransferAccountId {get; set;}
    public int Deleted {get; set;}
}