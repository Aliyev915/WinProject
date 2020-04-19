using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class CmbTypes
    {
        public int Id { get; set; }
        public string typeName { get; set; }
        public bool Deleted { get; set; }

        public override string ToString()
        {
            return typeName;
        }
    }
}
