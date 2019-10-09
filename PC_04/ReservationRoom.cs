//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PC_04
{
    using System;
    using System.Collections.Generic;
    
    public partial class ReservationRoom
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ReservationRoom()
        {
            this.ReservationCheckOuts = new HashSet<ReservationCheckOut>();
            this.ReservationRequestItems = new HashSet<ReservationRequestItem>();
        }
    
        public int ID { get; set; }
        public int ReservationID { get; set; }
        public int RoomID { get; set; }
        public System.DateTime StartDateTime { get; set; }
        public int DurationNights { get; set; }
        public int RoomPrice { get; set; }
        public System.DateTime CheckInDateTime { get; set; }
        public System.DateTime CheckOutDateTime { get; set; }
    
        public virtual Reservation Reservation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReservationCheckOut> ReservationCheckOuts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReservationRequestItem> ReservationRequestItems { get; set; }
        public virtual Room Room { get; set; }
    }
}
