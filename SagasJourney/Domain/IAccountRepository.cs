using System;
using System.Threading.Tasks;

namespace Domain
{
    public interface IAccountRepository
    {
        Task Save(Account account);
        Task<Account> Update(Account account);
        Task<Account> Get(Guid accountId);
    }
}