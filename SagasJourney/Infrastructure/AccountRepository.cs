using System;
using System.Threading.Tasks;
using Domain;

namespace Infrastructure
{
    public class AccountRepository : IAccountRepository
    {
        public Task Save(Account account)
        {
            throw new NotImplementedException();
        }

        public Task<Account> Update(Account account)
        {
            throw new NotImplementedException();
        }

        public Task<Account> Get(Guid accountId)
        {
            throw new NotImplementedException();
        }
    }
}