﻿namespace IdeaSpend.API
{
    /// <summary>
    /// The simplify object contain information of the <see cref="UserEntity"/>
    /// </summary>
    public class RegisterDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string RepeatPassword { get; set; }
    }
}