using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсач_опбд_версия_2
{
    public class Skates
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Manufacturer { get; set; }
        public float Price { get; set; }
        public int Size { get; set; }
        public int Count { get; set; }
        public bool isDeleted { get; set; }
        public WriteoffSkates WriteoffSkates { get; set; }
        public Order Order { get; set; }
    }
}
