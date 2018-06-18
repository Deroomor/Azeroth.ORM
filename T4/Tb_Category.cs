// Code generated by a template
using System;
using Azeroth.Nalu;
namespace T4
{
    public class Tb_Category
    {
        /// <summary>
        ///类别ID
        /// </summary>
        public Guid CategoryID {set;get;}
        /// <summary>
        ///类型名称
        /// </summary>
        [XString(100,true)]
        public String ItemName {set;get;}
        /// <summary>
        ///类型(1股东类别1股东属性)
        /// </summary>
        public Nullable<Int32> ItemValue {set;get;}
        /// <summary>
        ///显示名称
        /// </summary>
        [XString(200,true)]
        public String Name {set;get;}
        /// <summary>
        ///颜色代码
        /// </summary>
        [XString(50,true)]
        public String BaseColor {set;get;}
        /// <summary>
        ///创建时间
        /// </summary>
        public Nullable<DateTime> CreateTime {set;get;}
        /// <summary>
        ///
        /// </summary>
        public Boolean IsDel {set;get;}
    }
}
// It's the end
