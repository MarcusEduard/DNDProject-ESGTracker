using System.Security.Claims;
using WebApp.Services.Http;
using Microsoft.AspNetCore.Components.Authorization;

namespace WebApp.Auth;

public class CustomAuthProvider : AuthenticationStateProvider
{
    private readonly IAuthService authService;

    public CustomAuthProvider(IAuthService authService)
    {
        this.authService = authService;
        authService.OnAuthStateChanged += AuthStateChanged;
    }

    public override async Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        ClaimsPrincipal principal = await authService.GetAuthAsync();

        return new AuthenticationState(principal);
    }

    private void AuthStateChanged(ClaimsPrincipal principal)
    {
        NotifyAuthenticationStateChanged(
            Task.FromResult(
                new AuthenticationState(principal)
            )
        );
    }
}