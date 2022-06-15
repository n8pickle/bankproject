using System.Threading.Tasks;
using Domain;
using Services;
using Microsoft.AspNetCore.Mvc;
namespace Controllers;

// localhost:5000/api/account POST

[Route("api/[controller]")]
public class AccountController : Controller {

    private IAccountService _accountService;

    public AccountController(IAccountService accountService) {
        _accountService = accountService;
    }

    [HttpPost]
    public async Task CreateAccount([FromBody]Account account) {
        try {
            await _accountService.CreateAccount(account);
        } catch (Exception e) {
            Console.WriteLine(e);
        }
    }
}