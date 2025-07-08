//=================================================
//Copyright (c) Coalition of Good-Hearted Engineers
//FreeTo Use To Find Comfort and Peace
//=================================================

using System.Threading.Tasks;
using Sheenam.Api.Models.Foundation.Guests;

namespace Sheenam.API.Services.Foundation.Guests
{
    public interface IGuestService
    {
        ValueTask<Guest> AddGuestAsync(Guest guest);
    }
}
