using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Oco.Core.Extends.DefaultTypeExtendMethods
{
   /// <summary>
   /// Date Time 擴充方法
   /// </summary>
    public static  class DateTimeExtends
    {

        /// <summary>
        /// 取得時間戳記(yyyyMMddHHmmssfff)
        /// </summary>
        /// <param name="inst"></param>
        /// <returns></returns>
        public static string GetTimeText_yyyyMMddHHmmssfff(this DateTime inst)
        {
            var rtnV = inst.ToString("yyyyMMddHHmmssfff");
            
            return rtnV;
        }

        /// <summary>
        /// 延遲1millisec取得時間戳記(yyyyMMddHHmmssfff)
        /// </summary>
        /// <param name="inst"></param>
        /// <returns></returns>
        public static string GetTimeTextDelay1MilliSec(this DateTime inst)
        {
            Thread.Sleep(1);
            var rtnV = inst.GetTimeText_yyyyMMddHHmmssfff();
            return rtnV;
        }
    }
}
