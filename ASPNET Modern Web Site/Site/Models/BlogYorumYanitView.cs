//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BugraSite.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BlogYorumYanitView
    {
        public int Id { get; set; }
        public Nullable<int> BlogId { get; set; }
        public Nullable<int> BlogYorumId { get; set; }
        public string Yorum { get; set; }
        public int BloglarId { get; set; }
        public int BlogYorumlarId { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
    }
}
