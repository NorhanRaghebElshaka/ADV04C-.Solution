using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assimngent.part04
{
    internal class BoardMember : Employee
    {
        public override int VacationStock { get; set; } = int.MinValue;

        public void Resign()
        {

        }
    }
}
