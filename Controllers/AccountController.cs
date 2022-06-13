using System.Threading.Tasks;
using Domain;
using Services;
using Microsoft.AspNetCore.Mvc;
namespace Controllers;

[Route("api/[controller]")]
public class AccountController : Controller {

    private IAccountService _accountService;

    public AccountController(IAccountService accountService) {
        _accountService = accountService;
    }

    [Route("/account")]
    public async Task CreateAccount(Account account) {
        try {
            await _accountService.CreateAccount(account);
        } catch (Exception e) {
            Console.WriteLine(e);
        }
    }
}