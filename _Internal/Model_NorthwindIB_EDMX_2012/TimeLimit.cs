//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models.NorthwindIB.EDMX_2012
{
    using System;
    using System.Collections.Generic;
    
    public partial class TimeLimit
    {
        public int Id { get; set; }
        public System.TimeSpan MaxTime { get; set; }
        public Nullable<System.TimeSpan> MinTime { get; set; }
        public Nullable<System.DateTimeOffset> CreationDate { get; set; }
        public Nullable<System.DateTime> ModificationDate { get; set; }
        public System.Data.Spatial.DbGeometry Geometry1 { get; set; }
        public System.Data.Spatial.DbGeography Geography1 { get; set; }
        public Nullable<int> TimeGroupId { get; set; }
    }
}
