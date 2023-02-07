﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9.Models
{
    internal class Ticket
    {
        [Key]
        public Guid IdTicket { get; set; }
        public Passanger Passanger {get; set;}
        public Point PointArrival { get; set; }
        public Point PointDeparture { get; set; }
        public DateTime DateArrive { get; set; }

    }
}
