//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Libray
{
    using System;
    using System.Collections.Generic;
    
    public partial class Librarian
    {
        public int ID { get; set; }
        public string Login { get; set; }
        public System.DateTime Date_of_birth { get; set; }
        public int Phone_number { get; set; }
        public int Job { get; set; }
        public string Password { get; set; }
    
        public virtual Role Role { get; set; }
    }
}