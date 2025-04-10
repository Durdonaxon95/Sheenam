//=================================================
//Copyright (c) Coalition of Good-Hearted Engineers
//Free To Use Comfort and Peace
//=================================================

namespace Sheenam.Api.Models.Foundation.Guests
{
    public class Guest
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public DateTimeOffset DateOfBirth { get; set; }
        public GenderType Gender { get; set; }
    }
}
