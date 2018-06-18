// Code generated by a template
using System;
using Azeroth.Nalu;
namespace T4
{
    public class Tb_FileInfo
    {
        /// <summary>
        ///
        /// </summary>
        public Guid Id {set;get;}
        /// <summary>
        ///文件名称
        /// </summary>
        public String FileName {set;get;}
        /// <summary>
        ///文件类型(doc,pdf,xlsx)
        /// </summary>
        public String FileType {set;get;}
        /// <summary>
        ///文件地址
        /// </summary>
        public String FileUrl {set;get;}
        /// <summary>
        ///作者
        /// </summary>
        [XString(100,true)]
        public String FileAuthor {set;get;}
        /// <summary>
        ///上传时间
        /// </summary>
        public Nullable<DateTime> CreateTime {set;get;}
        /// <summary>
        ///
        /// </summary>
        [XString(500,true)]
        public String Remark {set;get;}
    }
}
// It's the end
