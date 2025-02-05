using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendingData.Busines.Models
{
    public class MouseModel
    {
        public int? Id { get; set; }

        public int X { get; set; }

        public int Y { get; set; }

        public DateTime T { get; set; }
    }
}
