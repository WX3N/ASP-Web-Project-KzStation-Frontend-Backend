//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projek.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cart
    {
        public int AlbumId { get; set; }
        public int CustomerId { get; set; }
        public int Qty { get; set; }
    
        public virtual Album Album { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
