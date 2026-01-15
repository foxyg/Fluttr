using System;
using System.Security.Claims;

namespace API.Extensions;

public static class ClaimsPrincipalExtension
{
    public static string GetMemberId(this ClaimsPrincipal user)
    {
        return user.FindFirstValue(ClaimTypes.NameIdentifier)
            ?? throw new Exception("Cannot get meberId from token");
    }

    public static string GetUsername(this ClaimsPrincipal user)
    {
        var username = user.FindFirstValue(ClaimTypes.Name) ?? throw new Exception("Cannot get username from token");
        return username;
    }
}
