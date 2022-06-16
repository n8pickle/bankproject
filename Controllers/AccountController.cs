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
    public async Task<IActionResult> CreateAccount([FromBody]Account account) {
        try {
            await _accountService.CreateAccount(account);
            return Ok();
        } catch (Exception e) {
            return StatusCode(400, e);
        }
    }

    [HttpGet]
    public async Task<IActionResult> GetAccountsByUser(int userId) {
        try {
            return Ok(await _accountService.GetAccountByUserId(userId));
        } catch (Exception e) {
            return StatusCode(400, e);
        }
    }

    [HttpPatch]
    [Route("{accountId}/balance/{amount}")]
    public async Task<IActionResult> UpdateAccountBalance([FromRoute]int accountId, [FromRoute]int amount) {
        try {
            await _accountService.UpdateAccountBalance(amount, accountId);
            return Ok();
        } catch (Exception e) {
            return StatusCode(400, e);
        }
    }

    [HttpPut]
    [Route("{accountId}")]
    public async Task<IActionResult> UpdateAccountData([FromBody]Account account) {
        try {
            await _accountService.UpdateAccountData(account);
            return Ok();
        } catch (Exception e) {
            return StatusCode(400, e);
        }
    }

    [HttpDelete]
    [Route("{accountId}")]
    public async Task<IActionResult> DeleteAccount([FromRoute]int accountId) {
        try {
            await _accountService.DeleteAccount(accountId);
            return Ok();
        } catch (Exception e) {
            return StatusCode(400, e);
        }
    }
}