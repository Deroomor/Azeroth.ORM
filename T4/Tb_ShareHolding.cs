// Code generated by a template
using System;
using Azeroth.Nalu;
namespace T4
{
    /// <summary>
    /// 股权分配
    /// <summary>
    public class Tb_ShareHolding
    {
        /// <summary>
        ///Id
        /// </summary>
        public Guid Id {set;get;}
        /// <summary>
        ///公司Id
        /// </summary>
        public Guid EnterpriseID {set;get;}
        /// <summary>
        ///分配名称
        /// </summary>
        public String Name {set;get;}
        /// <summary>
        ///摘要
        /// </summary>
        public String Remark {set;get;}
        /// <summary>
        ///总股数,单位是1
        /// </summary>
        public Int64 HoldingValue {set;get;}
        /// <summary>
        ///计算方式（岗位+个人）\3p,p,pf
        /// </summary>
        public Int32 HoldingMethod {set;get;}
        /// <summary>
        ///岗位权重
        /// </summary>
        public Decimal PositonRate {set;get;}
        /// <summary>
        ///个人权重
        /// </summary>
        public Decimal PeopleRate {set;get;}
        /// <summary>
        ///评估方式(private,public)
        /// </summary>
        public Int32 EvaluatingMethod {set;get;}
        /// <summary>
        ///评估阶段（未开始，进行中，结束）(init,going,complete)
        /// </summary>
        public Int32 EvalutatingStep {set;get;}
        /// <summary>
        ///创建时间
        /// </summary>
        public DateTime CreateTime {set;get;}
        /// <summary>
        ///创建人ID
        /// </summary>
        public Guid Creator {set;get;}
        /// <summary>
        ///是否删除
        /// </summary>
        public Boolean IsDel {set;get;}
        /// <summary>
        ///修改人
        /// </summary>
        public Guid LastModifier {set;get;}
        /// <summary>
        ///修改时间
        /// </summary>
        public DateTime LastModiTime {set;get;}
        /// <summary>
        ///评估选项（只评估岗位，评估岗位+个人）
        /// </summary>
        public Int32 EvaluatingType {set;get;}
        /// <summary>
        ///评估开始时间
        /// </summary>
        public Nullable<DateTime> EvaluateDate {set;get;}
    }
}
// It's the end
