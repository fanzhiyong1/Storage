//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sequence
    {
        public int ID { get; set; }
        public string SN { get; set; }
        public string TabName { get; set; }
        public int FirstType { get; set; }
        public string FirstRule { get; set; }
        public Nullable<int> FirstLength { get; set; }
        public Nullable<int> SecondType { get; set; }
        public string SecondRule { get; set; }
        public Nullable<int> SecondLength { get; set; }
        public Nullable<int> ThirdType { get; set; }
        public string ThirdRule { get; set; }
        public Nullable<int> ThirdLength { get; set; }
        public Nullable<int> FourType { get; set; }
        public string FourRule { get; set; }
        public Nullable<int> FourLength { get; set; }
        public string JoinChar { get; set; }
        public string Sample { get; set; }
        public string CurrentValue { get; set; }
        public string Remark { get; set; }
    }
}
