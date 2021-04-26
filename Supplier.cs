namespace pp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Supplier")]
    public partial class Supplier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Supplier()
        {
            Exchanges = new HashSet<Exchange>();
            Store_supplier = new HashSet<Store_supplier>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Supplier_Id { get; set; }

        [StringLength(10)]
        public string Supplier_Name { get; set; }

        [StringLength(10)]
        public string Supplier_Phone { get; set; }

        [StringLength(10)]
        public string Supplier_Mob { get; set; }

        [StringLength(10)]
        public string Supplier_Website { get; set; }

        [StringLength(10)]
        public string Supplier_Mail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Exchange> Exchanges { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Store_supplier> Store_supplier { get; set; }
    }
}
