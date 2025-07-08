//=================================================
//Copyright (c) Coalition of Good-Hearted Engineers
//FreeTo Use To Find Comfort and Peace
//=================================================


using Xeptions;

namespace Sheenam.API.Services.Foundation.Guests.Exceptions
{
    public class GuestValidationException:Xeption
    {
        public GuestValidationException(Xeption innerException)
         :base(message:"Guest validation error occurred, fix the errors and try again",
              innerException)
        { }
    }
}
