﻿//=================================================
//Copyright (c) Coalition of Good-Hearted Engineers
//FreeTo Use To Find Comfort and Peace
//=================================================

using EFxceptions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Sheenam.API.Brokers.Storages
{
    public partial class StorageBroker : EFxceptionsContext,IStorageBroker
    {
        private readonly IConfiguration configuration;
        

        public StorageBroker(IConfiguration configuration)            
        {
            this.configuration = configuration;
            this.Database.Migrate();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = 
                this.configuration.GetConnectionString(name: "DefaultConnection");

            optionsBuilder.UseSqlServer(connectionString);
            
        }
        public override void Dispose(){}
    }
}
