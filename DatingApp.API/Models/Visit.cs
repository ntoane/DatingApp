using System;

namespace DatingApp.API.Models
{
    public class Visit
    {
        public int VisitorId { get; set; }
        public int VisiteeId { get; set; }
        public DateTime DateAdded { get; set; }
        public virtual User Visitor { get; set; }
        public virtual User Visitee { get; set; }
    }
}