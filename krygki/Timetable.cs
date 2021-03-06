//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace krygki
{
    using System;
    using System.Collections.Generic;
    
    public partial class Timetable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Timetable()
        {
            this.History = new HashSet<History>();
            this.StudentTable = new HashSet<StudentTable>();
        }
    
        public int Id { get; set; }
        public int Week { get; set; }
        public System.TimeSpan Time_s { get; set; }
        public System.TimeSpan Time_e { get; set; }
        public int Id_club { get; set; }
        public int Id_user { get; set; }
        public string cabinet { get; set; }
        public int Status { get; set; }
    
        public virtual Club Club { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<History> History { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentTable> StudentTable { get; set; }
        public virtual User User { get; set; }
        public virtual Week Week1 { get; set; }
        public virtual Status Status1 { get; set; }
    }
}
