using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oco.Core.Extends.WinFormExtendMethods.Ctrls
{
    /// <summary>
    /// DataGridView 的擴充方法
    /// </summary>
    public static class DataGridViewExtends
    {
        /// <summary>
        /// 取得 DataGridView 內所有 DataGridViewRow 的迭代器  
        /// </summary>
        /// <param name="inst"></param>
        /// <returns></returns>
        public static IEnumerable<DataGridViewRow>  GetRowsAsEnumerable(this DataGridView inst)
        {
            var rtnV = inst.Rows.Cast<DataGridViewRow>();
            return rtnV;
        }

        /// <summary>
        /// 取得 DataGridView 內所有DataGridView 的List 集合
        /// </summary>
        /// <param name="inst"></param>
        /// <returns></returns>
        public static List<DataGridViewRow> GetRowsAsList(this DataGridView inst)
        {
            return inst.GetRowsAsEnumerable().ToList();
        }

        /// <summary>
        /// 取得 DataGridView 內所有DataGridView 的一維陣列
        /// </summary>
        /// <param name="inst"></param>
        /// <returns></returns>
        public static DataGridViewRow[] GetRowsAsArray(this DataGridView inst)
        {
            return inst.GetRowsAsEnumerable().ToArray(); ;
        }
    }
}
