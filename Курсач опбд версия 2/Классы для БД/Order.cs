using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсач_опбд_версия_2
{
    public class Order
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public DateTime GetTime { get; set; }
        public int SkatesId { get; set; }
        public int UserId { get; set; }
        public Skates Skates { get; set; }
        public User User { get; set; }
        public DateTime GiveTime { get; set; }
        public float Fine { get; set; }
        public bool IsHanded { get; set; }
    }
}
