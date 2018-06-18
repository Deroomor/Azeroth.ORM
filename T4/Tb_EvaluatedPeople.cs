// Code generated by a template
using System;
using Azeroth.Nalu;
namespace T4
{
    public class Tb_EvaluatedPeople
    {
        /// <summary>
        ///Id
        /// </summary>
        public Guid Id {set;get;}
        /// <summary>
        ///股权分配Id
        /// </summary>
        public Guid ShareHoldingId {set;get;}
        /// <summary>
        ///基础信息人员Id
        /// </summary>
        public Guid EmployeeID {set;get;}
        /// <summary>
        ///实际分配股数（在计算方式是非岗位的情况下）
        /// </summary>
        public Int32 FinalShareValue {set;get;}
        /// <summary>
        ///分数
        /// </summary>
        public Int32 Score {set;get;}
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
    }
}
// It's the end
