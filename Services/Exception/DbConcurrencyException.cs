﻿namespace Treinando_Crud.Services.Exception
{
    public class DbConcurrencyException : ApplicationException
    {
        public DbConcurrencyException(string message) :base(message)
        {
        }
    }
}
