// AuthenticationService.cs
public static class AuthenticationService
{
    public static bool IsUserAuthenticated(string username, string password)
    {
        // Simulate authentication logic
        return username == "admin" && password == "secret";
    }
}
