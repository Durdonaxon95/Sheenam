//=================================================
//Copyright (c) Coalition of Good-Hearted Engineers
//FreeTo Use To Find Comfort and Peace
//=================================================


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sheenam.Api.Models.Foundation.Guests;
using Sheenam.API.Services.Foundation.Guests.Exceptions;
using Sheenam.API.Services.Foundation.Guests.Exeptions;

namespace Sheenam.Api.Tests.Unit.Services.Foundation.Guests
{
    public partial class GuestServiceTests
    {
        [Fact]
        public async Task ShouldThrowValidationExceptionOnAddIfGuestsNullAndLogItAsync()
        {
            //given
            Guest nullGuests = null;    
            var nullGuestException = new NullGuestException();

            var expectedGuestValidationException =
                new GuestValidationException(nullGuestException);

            //when
            ValueTask<Guest> addGuetsTask =
                this.guestService.AddGuestAsync(nullGuests);

            //then
            await Assert.ThrowsAsync<GuestValidationException>(() =>
                addGuetsTask.AsTask());
        }
    }
}
