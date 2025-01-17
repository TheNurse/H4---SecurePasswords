﻿namespace SecurePasswordLogic.User
{
    public interface IUser
    {
        int Id { get; set; }
        
        string Username { get; set; }
        
        string Salt { get; set; }
        
        string Password { get; set; }
    }
}