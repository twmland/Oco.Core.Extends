using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oco.Core.Extends.ExtendTypes
{
    public abstract class BaseListItemModel<TValue>
    {
        public TValue ItemValue { get; set; }
        public override string ToString()
        {
            var memberInfo = typeof(TValue).GetMember(ItemValue.ToString()).First();
            var attr = Attribute.GetCustomAttribute(memberInfo, typeof(DescriptionAttribute)) as DescriptionAttribute;
            if (attr == null) { return ItemValue.ToString(); }
            else if (attr.Description == "")
            {
                return ItemValue.ToString();
            }
            else
            {
                return attr.Description;
            }
        }
    }
}
