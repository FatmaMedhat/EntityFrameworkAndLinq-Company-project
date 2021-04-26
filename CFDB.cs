using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace pp
{
    public partial class CFDB : DbContext
    {
        public CFDB()
            : base("name=CFDB")
        {
        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Exchange> Exchanges { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<Store_supplier> Store_supplier { get; set; }
        public virtual DbSet<stored_Item> stored_Item { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .Property(e => e.Client_Name)
                .IsFixedLength();

            modelBuilder.Entity<Client>()
                .Property(e => e.Client_Phone)
                .IsFixedLength();

            modelBuilder.Entity<Client>()
                .Property(e => e.Client_Fax)
                .IsFixedLength();

            modelBuilder.Entity<Client>()
                .Property(e => e.Client_Mob)
                .IsFixedLength();

            modelBuilder.Entity<Client>()
                .Property(e => e.Client_Website)
                .IsFixedLength();

            modelBuilder.Entity<Client>()
                .Property(e => e.Client_Mail)
                .IsFixedLength();

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Exchanges)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.Item_Name)
                .IsFixedLength();

            modelBuilder.Entity<Item>()
                .Property(e => e.Expiration)
                .IsFixedLength();

            modelBuilder.Entity<Item>()
                .Property(e => e.Production_Date)
                .IsFixedLength();

            modelBuilder.Entity<Item>()
                .HasMany(e => e.Exchanges)
                .WithRequired(e => e.Item)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.Store_supplier)
                .WithRequired(e => e.Item)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.stored_Item)
                .WithRequired(e => e.Item)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.Store_name)
                .IsFixedLength();

            modelBuilder.Entity<Store>()
                .Property(e => e.Store_Address)
                .IsFixedLength();

            modelBuilder.Entity<Store>()
                .Property(e => e.Store_Resposible)
                .IsFixedLength();

            modelBuilder.Entity<Store>()
                .HasMany(e => e.Exchanges)
                .WithRequired(e => e.Store)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Store>()
                .HasMany(e => e.Store_supplier)
                .WithRequired(e => e.Store)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Store>()
                .HasMany(e => e.stored_Item)
                .WithRequired(e => e.Store)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Supplier_Name)
                .IsFixedLength();

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Supplier_Phone)
                .IsFixedLength();

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Supplier_Mob)
                .IsFixedLength();

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Supplier_Website)
                .IsFixedLength();

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Supplier_Mail)
                .IsFixedLength();

            modelBuilder.Entity<Supplier>()
                .HasMany(e => e.Exchanges)
                .WithRequired(e => e.Supplier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Supplier>()
                .HasMany(e => e.Store_supplier)
                .WithRequired(e => e.Supplier)
                .WillCascadeOnDelete(false);
        }
    }
}
