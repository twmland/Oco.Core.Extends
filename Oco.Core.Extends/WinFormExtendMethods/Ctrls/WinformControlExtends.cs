using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oco.Core.Extends.WinFormExtendMethods.Ctrls
{
   /// <summary>
   /// WinForm 控制項的擴充方法  
   /// </summary>
    public static class WinformControlExtends
    {
        /// <summary>
        /// 回傳控制項去頭尾半型空的後的Text 屬性值 
        /// </summary>
        /// <param name="inst"></param>
        /// <returns></returns>
        public static string GetTrimText(this Control inst )
        {
            return inst.Text.Trim();
        }

        /// <summary>
        /// 檢查控制項 Text 屬性是否没有內容
        /// </summary>
        /// <param name="inst"></param>
        /// <returns></returns>
        public static bool IsTextEmpty(this Control inst)
        {
           return   string.IsNullOrWhiteSpace(inst.Text);
        }
    }
}
