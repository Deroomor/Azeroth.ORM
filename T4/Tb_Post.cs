// Code generated by a template
using System;
using Azeroth.Nalu;
namespace T4
{
    public class Tb_Post
    {
        /// <summary>
        ///岗位ID
        /// </summary>
        public Guid PostID {set;get;}
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
        ///岗位名称
        /// </summary>
        [XString(200,true)]
        public String PostName {set;get;}
        /// <summary>
        ///企业ID
        /// </summary>
        public Nullable<Guid> EnterpriseID {set;get;}
        /// <summary>
        ///岗位描述
        /// </summary>
        [XString(500,true)]
        public String Description {set;get;}
    }
}
// It's the end
