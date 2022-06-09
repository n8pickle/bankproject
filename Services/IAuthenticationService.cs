using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Domain.DTO;

namespace Services
{
	public interface IAuthenticationService
	{
		Task<bool> SignInAsync(SignIn signIn);
		Task SignOutAsync();
		Task<IdentityResult> CreateUserAsync(User user);
	}
}