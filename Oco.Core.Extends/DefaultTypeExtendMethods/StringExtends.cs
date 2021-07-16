using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Oco.Core.Extends.DefaultTypeExtendMethods
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

        /// <summary>
        /// 將字串轉為數字
        /// </summary>
        /// <param name="int32Text"></param>
        /// <returns></returns>
        public static int ToInt32(this string int32Text)
        {
            return Convert.ToInt32(int32Text);
        }

        /// <summary>
        /// 將字串轉為單精度浮點數
        /// </summary>
        /// <param name="int32Text"></param>
        /// <returns></returns>
        public static float ToFloat(this string floatText)
        {
            return Convert.ToSingle(floatText);
        }

        /// <summary>
        /// 將字串轉為倍精度浮點數
        /// </summary>
        /// <param name="int32Text"></param>
        /// <returns></returns>
        public static double ToDouble(this string doubleText)
        {
            return Convert.ToDouble(doubleText);
        }

        /// <summary>
        /// 字串本身是否空白
        /// </summary>
        /// <param name="inst"></param>
        /// <returns></returns>
        public static bool IsEmpty(this string inst)
        {
            return string.IsNullOrWhiteSpace(inst);
        }

        /// <summary>
        /// 將字串轉成 Color 的Property 
        /// </summary>
        /// <param name="inst"></param>
        /// <returns></returns>
        private static PropertyInfo ToColorProperty(this string inst)
        {
            var property = typeof(Color).GetProperties().FirstOrDefault(
                   m => m.Name.EqualsIgnoreCase(inst)
              );
            return property;
        }

        /// <summary>
        /// 將字串轉成背景色, 如果無法轉換就轉成預設的背景色
        /// </summary>
        /// <param name="inst"></param>
        /// <returns></returns>
        public static Color ToBackColor(this string inst)
        {
            var peoperty = inst.ToColorProperty();
            if (peoperty == null) { return ColorExtends.DefaultBackColor; }
            else 
            {
                var color = peoperty.ToColor();
                if (color.HasValue) { return color.Value; }
                else { return ColorExtends.DefaultBackColor; }
            }
        }

        /// <summary>
        /// 將字串轉成前景色, 如果無法轉換就轉成預設的背景色
        /// </summary>
        /// <param name="inst"></param>
        /// <returns></returns>
        public static Color ToForeColor(this string inst)
        {
            var peoperty = inst.ToColorProperty();
            if (peoperty == null) { return ColorExtends.DefaultForeColor; }
            else
            {
                var color = peoperty.ToColor();
                if (color.HasValue) { return color.Value; }
                else { return ColorExtends.DefaultForeColor; }
            }
        }

    }

}
