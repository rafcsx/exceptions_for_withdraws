using System;

namespace withdraw_exception.Entities.Exceptions
{
    class AccountException : ApplicationException
    {
        public AccountException(string message) : base(message)
        {}
    }
}