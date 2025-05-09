//=================================================
//Copyright (c) Coalition of Good-Hearted Engineers
//FreeTo Use To Find Comfort and Peace
//=================================================


using Sheenam.Api.Models.Foundation.Guests;
using System.Threading.Tasks;

namespace Sheenam.API.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Guest> InsertGuestAsync(Guest guest);
    }
}
