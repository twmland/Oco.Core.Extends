using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oco.Core.Extends.DefaultTypeExtendMethods
{
  
    /// <summary>
    /// Int 32 的 擴充方法
    /// </summary>
    public static class Int32Extends
    {
        /// <summary>
        /// Int32 轉換為布林值(0:false, 非0:true)
        /// </summary>
        public static bool ToBool(this int inst)
        {
            if (inst != 0) { return true; }
            else
            {
                return false;
            }
        }
    }
}
