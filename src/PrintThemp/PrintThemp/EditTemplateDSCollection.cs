/*
 * 作者:王清培
 * 时间:2010-7-4
 * 备注:该实例用来存放所有模板数据源的集合|DataSet的集合|实现多份打印
 * */
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace PrintThemp
{
    /// <summary>
    /// 存放全局数据源集合
    /// </summary>
    public class EditTemplateDSCollection : IEnumerator, IEnumerable
    {
        private int index = -1;
        /// <summary>
        /// 模板数据源集合
        /// </summary>
        private List<EditTemplateDataSource> _EditDSColl = new List<EditTemplateDataSource>();
        /// <summary>
        /// 获取模板数据
        /// </summary>
        public List<EditTemplateDataSource> EidtDSColl
        {
            get { return _EditDSColl; }
        }
        /// <summary>
        /// 添加模板数据源
        /// </summary>
        public EditTemplateDataSource SetEditDSColl
        {
            set { _EditDSColl.Add(value); }
        }
        /// <summary>
        /// 默认构造函数
        /// </summary>
        public EditTemplateDSCollection()
        {

        }
        /// <summary>
        /// 重载构造函数|
        /// </summary>
        /// <param name="editds">模板数据源</param>
        public EditTemplateDSCollection(EditTemplateDataSource editds)
        {
            _EditDSColl.Add(editds);
        }
        /// <summary>
        /// 根据索引返回数据源集合中的项
        /// </summary>
        /// <param name="index">索引</param>
        /// <returns>单套数据源</returns>
        public EditTemplateDataSource this[int index]
        {
            get { return _EditDSColl[index]; }
        }
        /// <summary>
        /// foreacth集合方法
        /// </summary>
        /// <returns>IEnumerator对象</returns>
        public IEnumerator GetEnumerator()
        {
            return this;
        }
        /// <summary>
        /// 移动到下一个
        /// </summary>
        /// <returns>bool</returns>
        public bool MoveNext()
        {
            return index++ < _EditDSColl.Count ? true : false;
        }
        /// <summary>
        /// 返回集合中的当前元素
        /// </summary>
        public object Current
        {
            get { return _EditDSColl[index]; }
        }
        /// <summary>
        /// 返回到集合的开始
        /// </summary>
        public void Reset()
        {
            index = -1;
        }
    }
}
