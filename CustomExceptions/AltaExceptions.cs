using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptions
{
    public class AltaExceptions : Exception
    {
        public AltaExceptions() : base(ExceptionMessages.CREATE_LINE_INVENTORY_EXCEPTION_MESSAGE())
        {

        }
    }
}
