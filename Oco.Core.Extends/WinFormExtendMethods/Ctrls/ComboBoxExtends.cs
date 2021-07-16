using Oco.Core.Extends.ExtendTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oco.Core.Extends.WinFormExtendMethods.Ctrls
{
    /// <summary>
    /// Combo Box 控制項擴充方法 
    /// </summary>
    public static  class ComboBoxExtends
    {
        /// <summary>
        /// 重設 ComboBox 選項, 預設值型態不明
        /// </summary>
        /// <typeparam name="TType"></typeparam>
        /// <param name="inst"></param>
        /// <param name="lst">選項的集合</param>
        /// <param name="defaultValue"></param>
        public static void ResetItems<TType>(this ComboBox inst, IEnumerable<TType> lst, object defaultValue)
        {
            var ary = lst.Select(m =>(object)m).ToArray();
            inst.Items.Clear();

            if (ary.Any())
            {

                inst.Items.AddRange(ary.ToArray());
                inst.SelectedIndex = 0;
                if (defaultValue == null) { return; }
                var defaultItem = ary.Where(m => m.ToString().Equals(defaultValue.ToString())).FirstOrDefault();
                if (defaultItem != null)
                {
                    inst.SelectedItem = defaultValue;
                }
            }

        }


        /// <summary>
        ///  重設 ComboBox 選項, 預設值型態由泛型的型態參數獲得
        /// </summary>
        /// <typeparam name="TItem"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="inst"></param>
        /// <param name="lst"></param>
        /// <param name="defaultValue"></param>
        public static void ResetItems<TItem, TValue>(this ComboBox inst, List<TItem> lst, TItem defaultValue) where TItem : BaseListItemModel<TValue>
        {
            var ary = lst.Select(m => m).ToArray();
            inst.Items.Clear();
            if (ary.Any())
            {
                inst.Items.AddRange(ary);
                inst.SelectedIndex = 0;
                if (defaultValue == null) { return; }
                var defaultItem = ary.Where(m => m.ToString().Equals(defaultValue.ToString())).FirstOrDefault();
                if (defaultItem != null)
                {
                    inst.SelectedItem = defaultValue;
                }
            }
        }
    }
}
