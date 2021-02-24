using Domain;

namespace Application
{
    public interface ICreateAccountUseCase
    {
        Account Execute();
    }

    public class CreateAccountUseCase : ICreateAccountUseCase
    {
        private readonly IAccountRepository _accountRepository;

        public CreateAccountUseCase(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        
        public Account Execute()
        {
            var newAccount = new Account();
            _accountRepository.Save(newAccount);

            return newAccount;
        }
    }
}