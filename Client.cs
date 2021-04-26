namespace pp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Client")]
    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            Exchanges = new HashSet<Exchange>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Client_Id { get; set; }

        [StringLength(10)]
        public string Client_Name { get; set; }

        [StringLength(10)]
        public string Client_Phone { get; set; }

        [StringLength(10)]
        public string Client_Fax { get; set; }

        [StringLength(10)]
        public string Client_Mob { get; set; }

        [StringLength(10)]
        public string Client_Website { get; set; }

        [StringLength(10)]
        public string Client_Mail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Exchange> Exchanges { get; set; }
    }
}
