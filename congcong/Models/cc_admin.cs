//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace congcong.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class cc_admin
    {
        public System.DateTime date { get; set; }
        public bool isDeleted { get; set; }
        public bool isHandled { get; set; }
        public int banDuration { get; set; }
        public int id { get; set; }
        public Nullable<int> newsId { get; set; }
        public Nullable<int> userId { get; set; }
    
        public virtual cc_news cc_news { get; set; }
        public virtual cc_user cc_user { get; set; }
    }
}
