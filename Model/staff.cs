//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class staff
    {
        public int StaffId { get; set; }
        public System.DateTime EntryTime { get; set; }
        public string StaffName { get; set; }
        public bool StaffSex { get; set; }
        public int departmentType { get; set; }
    
        public virtual department department { get; set; }
    }
}
