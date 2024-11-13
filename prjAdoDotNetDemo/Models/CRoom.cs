using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjAdoDotNetDemo.Models
{
    public class CRoom
    {
        public int fId { get; set; }
        public string fName { get; set; }
        public int fQty { get; set; }
        public decimal fPrice { get; set; }
        public decimal fCost { get; set; }
        public string fMemo { get; set; }
        public byte[] fImage { get; set; }
    }
}
