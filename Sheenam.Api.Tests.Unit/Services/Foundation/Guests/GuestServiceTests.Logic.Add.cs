//=================================================
//Copyright (c) Coalition of Good-Hearted Engineers
//FreeTo Use To Find Comfort and Peace
//=================================================


using FluentAssertions;
using Force.DeepCloner;
using Moq;
using Sheenam.Api.Models.Foundation.Guests;
using Sheenam.API.Brokers.Storages;
using Sheenam.API.Services.Foundation.Guests;
using Tynamix.ObjectFiller;

namespace Sheenam.Api.Tests.Unit.Services.Foundation.Guests
{
    public partial class GuestServiceTests
    {
        public GuestServiceTests()
        {
            this.storageBrokerMock = new Mock<IStorageBroker>();
            this.guestService = new GuestService(this.storageBrokerMock.Object);
        }

        [Fact]
        public async Task ShouldAddGuestAsync()
        {
            //given
            Guest randomGuest = CreateRandomGuest();
            Guest inputGuest = randomGuest;
            Guest storageBroker = inputGuest;
            Guest expectedGuest = storageBroker.DeepClone();

            this.storageBrokerMock.Setup(broker =>
               broker.InsertGuestAsync(inputGuest))
                .ReturnsAsync(storageBroker);

            //when
            Guest actualGuest =
                await this.guestService.AddGuestAsync(inputGuest);

            //then 
            actualGuest.Should().BeEquivalentTo(expectedGuest);

            this.storageBrokerMock.Verify(broker =>
            broker.InsertGuestAsync(inputGuest),
               Times.Once);

            this.storageBrokerMock.VerifyNoOtherCalls();
        }
    }
}
