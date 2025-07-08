//=================================================
//Copyright (c) Coalition of Good-Hearted Engineers
//FreeTo Use To Find Comfort and Peace
//=================================================


using Xeptions;

namespace Sheenam.API.Services.Foundation.Guests.Exeptions
{
    public class NullGuestException:Xeption
    {
        public NullGuestException()
         :base(message:"Guest is null")
        { }
    }
}
