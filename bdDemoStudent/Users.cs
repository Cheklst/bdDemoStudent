//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace bdDemoStudent
{
    using System;
    using System.Collections.Generic;
    
    public partial class Users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Users()
        {
            this.Activites = new HashSet<Activites>();
        }
    
        public int Id { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string Name3 { get; set; }
        public Nullable<System.DateTime> YearOfBirth { get; set; }
        public string Address { get; set; }
        public string HomePhone { get; set; }
        public string MobilPhone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Nullable<int> IdCountry { get; set; }
        public Nullable<int> IdGroup { get; set; }
        public Nullable<int> IdGender { get; set; }
        public Nullable<int> IdRol { get; set; }
        public Nullable<System.DateTime> DateOfReceipt { get; set; }
        public string NameFiles { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Activites> Activites { get; set; }
        public virtual Country Country { get; set; }
        public virtual Genders Genders { get; set; }
        public virtual Groups Groups { get; set; }
        public virtual Roles Roles { get; set; }
    }
}
