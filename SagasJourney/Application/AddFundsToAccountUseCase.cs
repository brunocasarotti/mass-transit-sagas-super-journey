using System;
using System.Threading.Tasks;
using Domain;

namespace Application
{
    public interface IAddFundsToAccountUseCase
    {
        Task<Account> Execute(Guid accountId, decimal amount);
    }

    public class AddFundsToAccountUseCase : IAddFundsToAccountUseCase
    {
        private readonly IAccountRepository _accountRepository;

        public AddFundsToAccountUseCase(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public async Task<Account> Execute(Guid accountId, decimal amount)
        {
            var account = await _accountRepository.Get(accountId);
            account.AddFunds(amount);
            return await _accountRepository.Update(account);
        }
    }
}