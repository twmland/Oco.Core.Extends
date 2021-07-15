using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oco.Core.Extends.WinFormExtends.DefaultTypes
{
   /// <summary>
   /// string 型別的擴充方法
   /// </summary>
    public static  class StringExtends
    {
        
        /// <summary>
        /// 不考慮大小寫,判斷字串是內容相同
        /// </summary>
        /// <param name="inst"></param>
        /// <param name="targetString"></param>
        /// <returns></returns>
        public static bool EqualsIgnoreCase(this string inst, string targetString)
        {
            var rtnV = inst.ToUpper().Equals(targetString.ToUpper());
            return rtnV;
        }
    }
}
