//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Airport
    {
        public Airport()
        {
            this.Flights = new HashSet<Flight>();
            this.Flights1 = new HashSet<Flight>();
            this.Tickets = new HashSet<Ticket>();
            this.Tickets1 = new HashSet<Ticket>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Flight> Flights { get; set; }
        public virtual ICollection<Flight> Flights1 { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
        public virtual ICollection<Ticket> Tickets1 { get; set; }
    }
}