using System;
using System.Threading.Tasks;
using Domain;

namespace Application
{
    public interface ICloseAccountUseCase
    {
        Task<Account> Execute(Guid accountId, string remark);
    }

    public class CloseAccountUseCase : ICloseAccountUseCase
    {
        private readonly IAccountRepository _accountRepository;

        public CloseAccountUseCase(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public async Task<Account> Execute(Guid accountId, string remark)
        {
            var account = await _accountRepository.Get(accountId);
            account.Close(remark);
            await _accountRepository.Update(account);
            return account;
        }
    }
}