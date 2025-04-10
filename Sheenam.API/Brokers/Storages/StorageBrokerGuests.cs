//=================================================
//Copyright (c) Coalition of Good-Hearted Engineers
//Free To Use Comfort and Peace
//=================================================

using Microsoft.EntityFrameworkCore;
using Sheenam.Api.Models.Foundation.Guests;

namespace Sheenam.API.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Guest> Guests { get; set; } = null!;
    }
}
