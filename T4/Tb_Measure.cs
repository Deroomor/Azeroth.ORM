// Code generated by a template
using System;
using Azeroth.Nalu;
namespace T4
{
    /// <summary>
    /// Tb_Measure(测算表)
    /// <summary>
    public class Tb_Measure
    {
        /// <summary>
        ///测算ID
        /// </summary>
        public Guid MeasureID {set;get;}
        /// <summary>
        ///方案ID
        /// </summary>
        public Nullable<Guid> ProgramID {set;get;}
        /// <summary>
        ///测算标题
        /// </summary>
        [XString(200,true)]
        public String MeasureTitle {set;get;}
        /// <summary>
        ///测算时间
        /// </summary>
        public Nullable<DateTime> MeasureTime {set;get;}
        /// <summary>
        ///估值
        /// </summary>
        public Nullable<Decimal> Valuation {set;get;}
        /// <summary>
        ///单股价格
        /// </summary>
        public Nullable<Decimal> UnitPrice {set;get;}
        /// <summary>
        ///创建时间
        /// </summary>
        public DateTime CreateTime {set;get;}
        /// <summary>
        ///创建人ID
        /// </summary>
        public Guid Creator {set;get;}
        /// <summary>
        ///修改时间
        /// </summary>
        public Nullable<DateTime> LastModiTime {set;get;}
        /// <summary>
        ///修改人
        /// </summary>
        public Nullable<Guid> LastModifier {set;get;}
        /// <summary>
        ///是否删除
        /// </summary>
        public Boolean IsDel {set;get;}
        /// <summary>
        ///股份数量
        /// </summary>
        public Int32 SharesNum {set;get;}
    }
}
// It's the end
