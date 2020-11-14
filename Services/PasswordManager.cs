using System;
using System.Collections.Generic;
using System.Linq;
using PersonalAPI.Context;

namespace PersonalAPI.Services
{
    public class PasswordManager : IPasswordManager
    {
        private readonly PersonalContext _context;

        public PasswordManager(PersonalContext context)
        {
            _context = context;
        }

        public List<Models.PasswordManager> GetAllPasswords()
        {
            var data = _context.PasswordManager.ToList();

            return data;
        }

        public List<Models.PasswordManager> GetPasswords(string service)
        {
            var data = _context.PasswordManager.Where(x => x.PlatformName.Equals(service)).ToList();

            return data;
        }
    }
}
