namespace WCFServiceWebRole1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CarModel : DbContext
    {
        public CarModel()
            : base("name=CarModel")
        {
        }

        public virtual DbSet<Car> Cars { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
