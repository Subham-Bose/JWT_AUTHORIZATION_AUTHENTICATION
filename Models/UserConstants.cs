﻿namespace JwtLoginAuthenticationAuthorization.Models;

public class UserConstants
{
    public static List<UserModel> Users = new()
    {
        new UserModel() {Username = "Test", Password = "Test", Role = "Test"}
    };
}
