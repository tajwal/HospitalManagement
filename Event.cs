//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HospitalManagament
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class Event
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Event()
        {
            this.allDay = false;
            this.Status = true;
            this.URL = "javascript:void(0)";
        }
    
        public long Id { get; set; }
        [DataMember(Name = "start")]
        public Nullable<System.DateTime> Start { get; set; }
        [DataMember(Name = "end")]
        public Nullable<System.DateTime> End { get; set; }
        [DataMember(Name = "allDay")]
        public Nullable<bool> allDay { get; set; }
        public long UserId { get; set; }
        [DataMember(Name = "title")]
        public string Name { get; set; }
        [DataMember(Name = "description")]
        public string Description { get; set; }
        public Nullable<bool> Status { get; set; }
        public string StartDateStr { get; set; }
        public Nullable<System.TimeSpan> StartTime { get; set; }
        public string EndDateStr { get; set; }
        public Nullable<System.TimeSpan> EndTime { get; set; }
        [DataMember(Name = "url")]
        public string URL { get; set; }
    
        public virtual User User { get; set; }
    }
}
