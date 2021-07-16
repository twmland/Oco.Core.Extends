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
   /// PropertyInfo 的擴充方法
   /// </summary>
    public static class PropertyInfoExtends
    {
        /// <summary>
        /// 取得PropertyInfo的特定 Attribute Instance
        /// </summary>
        /// <typeparam name="TAttribute">特定Attribute 的型別</typeparam>
        /// <param name="inst">Property Instance</param>
        /// <returns></returns>
        public static TAttribute GetAttribute<TAttribute>(this PropertyInfo inst ) where TAttribute : Attribute
        {
            var attr = Attribute.GetCustomAttributes( inst,typeof( TAttribute)) as TAttribute;
            return attr;
        }

        /// <summary>
        /// 取得指定名稱PropertyInfo的特定 Attribute Instance
        /// </summary>
        /// <typeparam name="TAttribute">特定Attribute 的型別</typeparam>
        /// <param name="inst">Property Instance</param>
        /// <returns></returns>
        public static TAttribute GetAttribute<TAttribute>(this PropertyInfo[] inst, string propertyName) where TAttribute : Attribute
        {
            var p = inst.FirstOrDefault(m => m.Name == propertyName);
            if (p == null) { return null; }
            var attr = GetAttribute<TAttribute>(p);
            return attr;
        }

        /// <summary>將PropertyInfo 轉為 Color 型態的值</summary>
        /// <param name="inst"></param>
        /// <returns></returns>
        public static Color? ToColor(this PropertyInfo inst)
        {

            var rtnV = inst.ToStructValue<Color>();
            return rtnV;
        }

        /// <summary>將PropertyInfo 轉為數值型態資料的值  </summary>
        /// <typeparam name="TTarget"></typeparam>
        /// <param name="inst"></param>
        /// <returns></returns>
        public static TTarget? ToStructValue<TTarget>(this PropertyInfo inst) where TTarget : struct
        {
            // 型態不對無法轉換,回傳null
            if (!inst.IsDeclaringType<TTarget>())
            { return null;}
            var obj = new TTarget();
            var value = (TTarget)inst.GetValue(obj);
            return value;
        }

        public static bool IsDeclaringType<TDeclareType>(this PropertyInfo inst)
        {
            if (inst.DeclaringType == typeof(TDeclareType))
            {
                return true;
            }
            else 
            {
                return false;
            }
        } 

    }
}
