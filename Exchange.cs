namespace pp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Exchange")]
    public partial class Exchange
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Client_Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Store_Id { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Supplier_Id { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Item_Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? License_date { get; set; }

        public int? License_Number { get; set; }

        public int? quantity { get; set; }

        public virtual Client Client { get; set; }

        public virtual Item Item { get; set; }

        public virtual Store Store { get; set; }

        public virtual Supplier Supplier { get; set; }
    }
}
