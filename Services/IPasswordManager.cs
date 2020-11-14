using System;
using System.Collections.Generic;

namespace PersonalAPI.Services
{
    public interface IPasswordManager
    {
        List<Models.PasswordManager> GetAllPasswords();
        List<Models.PasswordManager> GetPasswords(string service);
    }
}
