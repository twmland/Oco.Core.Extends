using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oco.Core.Extends.DefaultTypeExtendMethods
{
    /// <summary>
    /// 物件的 擴充方法
    /// </summary>
    public static class ObjectExtends
    {
       /// <summary>
       /// 自指定物件中取出特定Property Name 的Proeperty 的Attribute Instance
       /// </summary>
       /// <typeparam name="TAttribute"></typeparam>
       /// <param name="inst"></param>
       /// <param name="propertyName"></param>
       /// <returns></returns>
        public static  TAttribute   GetAttribute<TAttribute>(this object inst,string propertyName) where TAttribute : Attribute
        {
            return inst.GetType().GetProperties().GetAttribute<TAttribute>(propertyName);
        }
    }
}
