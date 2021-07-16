using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oco.Core.Extends.DefaultTypeExtendMethods
{
   /// <summary>
   /// 布林值的擴充方法
   /// </summary>
    public static class BoolExtends
    {
        /// <summary>
        /// 將布林值轉換為整數(true: 1, false: 0)
        /// </summary>
        /// <param name="inst"></param>
        /// <returns></returns>
        public static int ToInt32(this bool inst)
        {
            if (inst) 
            { return 1; }
            else
            {
                return 0;
            }
        }
    }
}
