﻿
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using Treinando_Crud.Models;

namespace Treinando_Crud.DataBase
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<Employee> Employees { get; set; }
    }
}
