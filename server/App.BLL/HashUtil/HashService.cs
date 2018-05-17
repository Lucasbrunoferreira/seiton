using System;
using System.Collections.Generic;
using System.Text;

namespace App.BLL.HashUtil
{
    public static class HashService
    {
        private static string GenerateSalt()
        {
            return BCrypt.BCryptHelper.GenerateSalt(BCrypt.SaltRevision.Revision2B);
        }

        public static string HashPassword(string text)
        {
            return BCrypt.BCryptHelper.HashPassword(text, GenerateSalt());
        }

        public static bool CheckPassword(string text, string hashed)
        {
            return BCrypt.BCryptHelper.CheckPassword(text, hashed);
        }
    }
}
