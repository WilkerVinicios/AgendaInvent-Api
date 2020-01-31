﻿using Common.Resources;
using System;
using System.Text.RegularExpressions;

namespace Common.Validation
{
    public class EmailAssertionConcern
    {
        public static void AssertIsValid(string email, string emailInvalido)
        {
            if (!Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))
                throw new Exception(Errors.EmailInvalido);
        }
    }
}
