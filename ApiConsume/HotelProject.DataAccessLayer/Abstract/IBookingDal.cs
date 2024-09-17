using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Abstract
{
    public interface IBookingDal:IGenericDal<Booking>
    {
        void BookingStatusChangeApproved(int id);
        void BookingStatusChangeCancel(int id);
        void BookingStatusChangeWait(int id);
        int GetBookingCount();
        List<Booking> Last6Bookings();
    }
}
