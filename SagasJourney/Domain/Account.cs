using System;

namespace Domain
{
    public class Account
    {
        public Account()
        {
            Id = Guid.NewGuid();
            Status = Status.New;
        }

        public Guid Id { get; set; }
        public Status Status { get; set; }
        public string Remark { get; set; }
        public decimal Amount { get; set; }

        public void AddFunds(decimal amount)
        {
            if (Status == Status.New)
                Status = Status.Open;
            
            Amount = amount;
        }

        public void Close(string remark)
        {
            Remark = remark;
            Status = Status.Closed;
        }
    }
}