using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;

namespace ContactBookApp.Data_Layer
{
    public partial class ContactsDBContext : DbContext
    {
        public ContactsDBContext() : base("name=ContactsDBContext")
        {

        }

        public virtual DbSet<Contacts> Contacts { get; set; }
    }
}