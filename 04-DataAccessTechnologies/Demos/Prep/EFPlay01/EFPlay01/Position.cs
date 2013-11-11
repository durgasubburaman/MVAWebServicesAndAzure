//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFPlay01
{
    using System;
    using System.Collections.Generic;
    
    public partial class Position
    {
        public int PositionID { get; set; }
        public System.DateTime ReportedAt { get; set; }
        public Nullable<float> Latitude { get; set; }
        public Nullable<float> Longitude { get; set; }
        public float DistanceFromLast { get; set; }
        public int CruiseID { get; set; }
        public Nullable<int> PlaceID { get; set; }
        public Nullable<int> TimeZoneID { get; set; }
    
        public virtual Cruise Cruise { get; set; }
        public virtual Place Place { get; set; }
        public virtual TimeZone TimeZone { get; set; }
    }
}
