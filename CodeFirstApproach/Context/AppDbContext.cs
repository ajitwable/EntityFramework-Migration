using DairyDirect.Model;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstApproach.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<UserRoleModel> UserRole { get; set; }
        public DbSet<MilkTypeModel> MilkType { get; set; }
        public DbSet<RateModel> MilkRate { get; set; }
        public DbSet<TenantModel> Tenant { get; set; }
        public DbSet<InvoiceSettingModel> InvoiceSetting { get; set; }
        public DbSet<ManagerTenantModel> MangerTenant { get; set; }
        public DbSet<DeliveryDetailsModel> DeliveryDetails { get; set; }
        public DbSet<ManagerPinCodeModel> ManagerPinCode { get; set; }
        public DbSet<MilkFluctuationModel> MilkFluctuation { get; set; }
        public DbSet<UserModel> User { get; set; }
        public DbSet<PaymentsModel> Payment { get; set; }
        public DbSet<UserWalletModel> Walet { get; set; }
        public DbSet<InvoiceModel> Invoice { get; set; }
    }
}
