﻿using System;


namespace SalesWebMvc.Services
{
    public class DbConcurrencyException : ApplicationException
    {
        public DbConcurrencyException(string message) : base(message)
        {

        }
    }

}
