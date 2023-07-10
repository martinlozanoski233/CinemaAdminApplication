using System.ComponentModel.DataAnnotations;
using System;

namespace CinemaAdminApplication.Models
{
    public class Ticket
    {
        public Guid Id { get; set; }

        public string MovieTitle { get; set; }
       
        public DateTime Date { get; set; }
       
        public TimeSpan Time { get; set; }
       
        public int Seat { get; set; }
        
        public int Price { get; set; }
    }
}
