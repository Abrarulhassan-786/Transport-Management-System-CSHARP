//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBMS_RMS_PROJECT.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Passenger
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Passenger()
        {
            this.tbl_Passenger_Detial = new HashSet<tbl_Passenger_Detial>();
            this.tbl_Ticket = new HashSet<tbl_Ticket>();
        }
    
        public int P_ID { get; set; }
        public string p_Name { get; set; }
        public Nullable<int> p_Phone_No { get; set; }
        public string P_Age { get; set; }
        public Nullable<int> P_Seat_number { get; set; }
        public string P_Gender { get; set; }
        public Nullable<int> Train_No { get; set; }
    
        public virtual tbl_Train tbl_Train { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Passenger_Detial> tbl_Passenger_Detial { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Ticket> tbl_Ticket { get; set; }
    }
}
