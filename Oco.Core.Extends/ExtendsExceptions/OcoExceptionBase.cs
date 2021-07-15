using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oco.Core.Extends.ExtendsExceptions
{
    public abstract class OcoExceptionBase:Exception
    {
        public OcoExceptionBase(string message) : base(message)
        {

        }
    }
}
