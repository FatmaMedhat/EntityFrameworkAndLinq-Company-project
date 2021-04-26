namespace pp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Store_supplier
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Supplier_Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Store_Id { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Item_Id { get; set; }

        public int? quantity { get; set; }

        [Column(TypeName = "date")]
        public DateTime? License_supplier_date { get; set; }

        public int? License_supplier_Num { get; set; }

        public virtual Item Item { get; set; }

        public virtual Store Store { get; set; }

        public virtual Supplier Supplier { get; set; }
    }
}
