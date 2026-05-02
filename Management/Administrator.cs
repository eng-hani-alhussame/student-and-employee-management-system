using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management
{
    public class Administrator : Management
    {
        public Administrator() { }

        public override void getData_emp()
        {
            Console.WriteLine("\n\t--- Administrator Mode Activated ---");
            base.getData_emp();
        }
    }
}