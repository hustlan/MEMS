//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MEMSservice.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_saledetail
    {
        public int id { get; set; }
        public Nullable<int> product { get; set; }
        public Nullable<int> productnumber { get; set; }
        public Nullable<System.DateTime> plandeliverydate { get; set; }
        public Nullable<decimal> producttotalprice { get; set; }
        public Nullable<System.DateTime> actualdeliverydate { get; set; }
        public Nullable<System.DateTime> planreceivedate { get; set; }
        public Nullable<System.DateTime> actrualreceivedate { get; set; }
        public Nullable<int> receivestate { get; set; }
        public Nullable<decimal> receiveamount { get; set; }
    }
}
