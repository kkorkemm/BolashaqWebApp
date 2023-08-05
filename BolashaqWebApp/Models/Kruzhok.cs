//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BolashaqWebApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kruzhok
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kruzhok()
        {
            this.Poseshenie = new HashSet<Poseshenie>();
            this.Zayavka = new HashSet<Zayavka>();
            this.KruzhokPictures = new HashSet<KruzhokPictures>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public System.DateTime StudyPeriodStart { get; set; }
        public System.DateTime StudyPeriodEnd { get; set; }
        public int AgeClassID { get; set; }
        public byte PlaceCount { get; set; }
        public int OtdelID { get; set; }
        public int TeacherID { get; set; }
    
        public virtual AgeClasses AgeClasses { get; set; }
        public virtual Otdels Otdels { get; set; }
        public virtual Users Users { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Poseshenie> Poseshenie { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zayavka> Zayavka { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KruzhokPictures> KruzhokPictures { get; set; }
    }
}
