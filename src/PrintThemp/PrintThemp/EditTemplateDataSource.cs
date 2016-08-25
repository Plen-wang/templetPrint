/*
 * 作者:王清培
 * 时间:2010-7-4
 * 备注:该类用来存放全局模板的数据源
 *
 * 
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace PrintThemp
{
    /// <summary>
    /// 全局模板数据源|用户需要打印哪张页面时需给出数据源
    /// (注：该类是实例对象类，支持多份打印)
    /// </summary>
    public class EditTemplateDataSource
    {
        /// <summary>
        /// 模板全局数据源|存放所有模板
        /// </summary>
        private DataSet _EditGlobalDataSource;
        /// <summary>
        /// 模板全局数据源
        /// </summary>
        public DataSet EditGlobalDataSource
        {
            get { return _EditGlobalDataSource; }
        }
        /// <summary>
        /// 默认构造函数
        /// </summary>
        public EditTemplateDataSource()
        {

        }
        /// <summary>
        /// 重载构造函数|实例化模板数据源
        /// </summary>
        /// <param name="editds">数据源(DataSet)</param>
        public EditTemplateDataSource(DataSet editds)
        {
            _EditGlobalDataSource = editds;
        }
    }
}
