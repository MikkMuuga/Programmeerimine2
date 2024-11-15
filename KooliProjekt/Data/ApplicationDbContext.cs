﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceLine> InvoicesLine { get; set; }
        public DbSet<Budget> Budgets { get; set; }
        public DbSet<Materials> Materials { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<WorkersMachines> WorkersMachines { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}