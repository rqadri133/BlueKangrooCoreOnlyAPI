using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class blueKangrooContext : DbContext
    {
        public blueKangrooContext()
        {
        }

        public blueKangrooContext(DbContextOptions<blueKangrooContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AppActivity> AppActivity { get; set; }
        public virtual DbSet<AppBuyer> AppBuyer { get; set; }
        public virtual DbSet<AppBuyerActivity> AppBuyerActivity { get; set; }
        public virtual DbSet<AppBuyerCostSheet> AppBuyerCostSheet { get; set; }
        public virtual DbSet<AppBuyerSellerTrade> AppBuyerSellerTrade { get; set; }
        public virtual DbSet<AppCategory> AppCategory { get; set; }
        public virtual DbSet<AppClass> AppClass { get; set; }
        public virtual DbSet<AppCompany> AppCompany { get; set; }
        public virtual DbSet<AppCrossRefProcess> AppCrossRefProcess { get; set; }
        public virtual DbSet<AppDataType> AppDataType { get; set; }
        public virtual DbSet<AppDemand> AppDemand { get; set; }
        public virtual DbSet<AppDocumentAssigned> AppDocumentAssigned { get; set; }
        public virtual DbSet<AppDocumentTransaction> AppDocumentTransaction { get; set; }
        public virtual DbSet<AppDoor> AppDoor { get; set; }
        public virtual DbSet<AppDoorKey> AppDoorKey { get; set; }
        public virtual DbSet<AppDriver> AppDriver { get; set; }
        public virtual DbSet<AppError> AppError { get; set; }
        public virtual DbSet<AppExport> AppExport { get; set; }
        public virtual DbSet<AppFactor> AppFactor { get; set; }
        public virtual DbSet<AppFinancialInstituition> AppFinancialInstituition { get; set; }
        public virtual DbSet<AppFreight> AppFreight { get; set; }
        public virtual DbSet<AppFreightType> AppFreightType { get; set; }
        public virtual DbSet<AppGroundActivity> AppGroundActivity { get; set; }
        public virtual DbSet<AppGroundLifter> AppGroundLifter { get; set; }
        public virtual DbSet<AppGroundLogistics> AppGroundLogistics { get; set; }
        public virtual DbSet<AppGroundPlacementParkNumber> AppGroundPlacementParkNumber { get; set; }
        public virtual DbSet<AppImport> AppImport { get; set; }
        public virtual DbSet<AppIndustrialRegion> AppIndustrialRegion { get; set; }
        public virtual DbSet<AppIndustrialZone> AppIndustrialZone { get; set; }
        public virtual DbSet<AppInstruementation> AppInstruementation { get; set; }
        public virtual DbSet<AppJsonfile> AppJsonfile { get; set; }
        public virtual DbSet<AppKey> AppKey { get; set; }
        public virtual DbSet<AppMetalCombinationAlloy> AppMetalCombinationAlloy { get; set; }
        public virtual DbSet<AppPackage> AppPackage { get; set; }
        public virtual DbSet<AppPackageHandler> AppPackageHandler { get; set; }
        public virtual DbSet<AppPallete> AppPallete { get; set; }
        public virtual DbSet<AppPriceParityCheck> AppPriceParityCheck { get; set; }
        public virtual DbSet<AppProcess> AppProcess { get; set; }
        public virtual DbSet<AppProcessLanguageTokens> AppProcessLanguageTokens { get; set; }
        public virtual DbSet<AppProcessLog> AppProcessLog { get; set; }
        public virtual DbSet<AppProcessPipeLine> AppProcessPipeLine { get; set; }
        public virtual DbSet<AppProcessRunningOnServer> AppProcessRunningOnServer { get; set; }
        public virtual DbSet<AppProduct> AppProduct { get; set; }
        public virtual DbSet<AppProperty> AppProperty { get; set; }
        public virtual DbSet<AppRouteAlert> AppRouteAlert { get; set; }
        public virtual DbSet<AppSaleActivity> AppSaleActivity { get; set; }
        public virtual DbSet<AppSeller> AppSeller { get; set; }
        public virtual DbSet<AppSellerActivity> AppSellerActivity { get; set; }
        public virtual DbSet<AppSensitiveMaterial> AppSensitiveMaterial { get; set; }
        public virtual DbSet<AppShelve> AppShelve { get; set; }
        public virtual DbSet<AppSupply> AppSupply { get; set; }
        public virtual DbSet<AppSupplyDemandChart> AppSupplyDemandChart { get; set; }
        public virtual DbSet<AppToken> AppToken { get; set; }
        public virtual DbSet<AppTokenDetails> AppTokenDetails { get; set; }
        public virtual DbSet<AppTokenGeneration> AppTokenGeneration { get; set; }
        public virtual DbSet<AppTray> AppTray { get; set; }
        public virtual DbSet<AppTruck> AppTruck { get; set; }
        public virtual DbSet<AppTruckRoute> AppTruckRoute { get; set; }
        public virtual DbSet<AppTruckRouteAssigned> AppTruckRouteAssigned { get; set; }
        public virtual DbSet<AppUidataDependencyInjection> AppUidataDependencyInjection { get; set; }
        public virtual DbSet<AppUitemplate> AppUitemplate { get; set; }
        public virtual DbSet<AppUitemplateData> AppUitemplateData { get; set; }
        public virtual DbSet<AppUser> AppUser { get; set; }
        public virtual DbSet<AppUserActivityDetails> AppUserActivityDetails { get; set; }
        public virtual DbSet<AppUserActivityErrors> AppUserActivityErrors { get; set; }
        public virtual DbSet<AppUserActivityExecutedTime> AppUserActivityExecutedTime { get; set; }
        public virtual DbSet<AppUserActivityFrame> AppUserActivityFrame { get; set; }
        public virtual DbSet<AppUserActivityInput> AppUserActivityInput { get; set; }
        public virtual DbSet<AppUserRole> AppUserRole { get; set; }
        public virtual DbSet<AppUserRoleDetail> AppUserRoleDetail { get; set; }
        public virtual DbSet<AppUserSesion> AppUserSesion { get; set; }
        public virtual DbSet<AppUserSessionCrossRefVar> AppUserSessionCrossRefVar { get; set; }
        public virtual DbSet<AppWareHouse> AppWareHouse { get; set; }
        public virtual DbSet<AppWareHouseNode> AppWareHouseNode { get; set; }
        public virtual DbSet<AppWareHouseVendor> AppWareHouseVendor { get; set; }
        public virtual DbSet<ApplicationContext> ApplicationContext { get; set; }
        public virtual DbSet<ApplicationModel> ApplicationModel { get; set; }
        public virtual DbSet<Sysdiagrams> Sysdiagrams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=bluekangrooone.crtpqidbbpvh.us-east-2.rds.amazonaws.com;Database=bluekangroo;user id=admin;PWD=Astaghees199;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppActivity>(entity =>
            {
                entity.HasIndex(e => new { e.AppProjectId, e.AppActivityName })
                    .HasName("UQ__AppActiv__56AE0C02DDE7F298")
                    .IsUnique();

                entity.Property(e => e.AppActivityId)
                    .HasColumnName("AppActivityID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppActivityEndDate).HasColumnType("datetime");

                entity.Property(e => e.AppActivityName)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.AppActivityStartDate).HasColumnType("datetime");

                entity.Property(e => e.AppProjectId).HasColumnName("AppProjectID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppBuyer>(entity =>
            {
                entity.HasIndex(e => e.AppBuyerHashedSsc)
                    .HasName("UQ__AppBuyer__AD5E7D9C4DFF1D0E")
                    .IsUnique();

                entity.Property(e => e.AppBuyerId)
                    .HasColumnName("AppBuyerID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppBuyerHashedSsc)
                    .HasColumnName("AppBuyerHashedSSC")
                    .HasMaxLength(2000);

                entity.Property(e => e.AppBuyerLicenseHashedId)
                    .IsRequired()
                    .HasColumnName("AppBuyerLicenseHashedID")
                    .HasMaxLength(2000);

                entity.Property(e => e.AppBuyerName)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppBuyerActivity>(entity =>
            {
                entity.Property(e => e.AppBuyerActivityId)
                    .HasColumnName("AppBuyerActivityID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppActivityId).HasColumnName("AppActivityID");

                entity.Property(e => e.AppBuyerActivityDesc).HasMaxLength(200);

                entity.Property(e => e.AppBuyerId).HasColumnName("AppBuyerID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppBuyerCostSheet>(entity =>
            {
                entity.HasKey(e => e.AppBuyerCostId)
                    .HasName("PK_AppBuyerCostID");

                entity.Property(e => e.AppBuyerCostId)
                    .HasColumnName("AppBuyerCostID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppBuyerId)
                    .IsRequired()
                    .HasColumnName("AppBuyerID")
                    .HasMaxLength(2000);

                entity.Property(e => e.AppDutyIdapplied).HasColumnName("AppDutyIDApplied");

                entity.Property(e => e.AppItemCost).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.AppProductId)
                    .IsRequired()
                    .HasColumnName("AppProductID")
                    .HasMaxLength(2000);

                entity.Property(e => e.AppShipmentCost).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppBuyerSellerTrade>(entity =>
            {
                entity.HasKey(e => e.AppTradeId)
                    .HasName("PK_AppTradeID");

                entity.Property(e => e.AppTradeId)
                    .HasColumnName("AppTradeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppBuyerId).HasColumnName("AppBuyerID");

                entity.Property(e => e.AppSellerId).HasColumnName("AppSellerID");

                entity.Property(e => e.AppTransactionId).HasColumnName("AppTransactionID");

                entity.Property(e => e.AppUserId).HasColumnName("AppUserID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppCategory>(entity =>
            {
                entity.Property(e => e.AppCategoryId)
                    .HasColumnName("AppCategoryID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppCategoryName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppClass>(entity =>
            {
                entity.Property(e => e.AppClassId)
                    .HasColumnName("AppClassID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppClassName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppCompany>(entity =>
            {
                entity.Property(e => e.AppCompanyId)
                    .HasColumnName("AppCompanyID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppCompanyOrganizationName)
                    .IsRequired()
                    .HasMaxLength(600);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppCrossRefProcess>(entity =>
            {
                entity.ToTable("AppCrossRefPRocess");

                entity.Property(e => e.AppCrossRefProcessId)
                    .HasColumnName("AppCrossRefProcessID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.NextSubProcessId).HasColumnName("NextSubProcessID ");

                entity.Property(e => e.ProcessSourceId).HasColumnName("ProcessSourceID");
            });

            modelBuilder.Entity<AppDataType>(entity =>
            {
                entity.Property(e => e.AppDataTypeId)
                    .HasColumnName("AppDataTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppDataTypeName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppDemand>(entity =>
            {
                entity.Property(e => e.AppDemandId)
                    .HasColumnName("AppDemandID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppDemandDeprivalRate).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.AppDemandFromPopulationCode).HasMaxLength(10);

                entity.Property(e => e.AppDemandIncreaseRate).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.AppDemandName)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.AppDemandPercentage)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.AppProductId).HasColumnName("AppProductID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppDocumentAssigned>(entity =>
            {
                entity.HasKey(e => e.BusineesDocAssignedId)
                    .HasName("PK_BusinessDocAssignedID");

                entity.Property(e => e.BusineesDocAssignedId)
                    .HasColumnName("BusineesDocAssignedID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActivityAssignedId).HasColumnName("ActivityAssignedID");

                entity.Property(e => e.BusinessDocUserId).HasColumnName("BusinessDocUserID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppDocumentTransaction>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AppDocumentAmount).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.AppDocumentSignature)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.AppDocumentTemplatePath)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.AppDocumentText)
                    .IsRequired()
                    .HasMaxLength(3000);

                entity.Property(e => e.AppDocumentTransactionId).HasColumnName("AppDocumentTransactionID");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<AppDoor>(entity =>
            {
                entity.Property(e => e.AppDoorId)
                    .HasColumnName("AppDoorID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppDoorName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppDoorKey>(entity =>
            {
                entity.Property(e => e.AppDoorKeyId)
                    .HasColumnName("AppDoorKeyID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppKeyCode)
                    .IsRequired()
                    .HasMaxLength(17);

                entity.Property(e => e.AppKeyName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppDriver>(entity =>
            {
                entity.Property(e => e.AppDriverId)
                    .HasColumnName("AppDriverID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppDriverAddress)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.AppDriverImageUrlphoto)
                    .IsRequired()
                    .HasColumnName("AppDriverImageURLPhoto")
                    .HasMaxLength(2000);

                entity.Property(e => e.AppDriverLicenseNumber)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.AppDriverName)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppError>(entity =>
            {
                entity.HasKey(e => e.AppErrorCodeId);

                entity.Property(e => e.AppErrorCodeId)
                    .HasColumnName("AppErrorCodeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppErrorDescription)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.AppErrorType)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppExport>(entity =>
            {
                entity.Property(e => e.AppExportId)
                    .HasColumnName("AppExportID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppBuyerId).HasColumnName("AppBuyerID");

                entity.Property(e => e.AppDutyId).HasColumnName("AppDutyID");

                entity.Property(e => e.AppSellerId).HasColumnName("AppSellerID");

                entity.Property(e => e.AppTradeFinanceCompanyId).HasColumnName("AppTradeFinanceCompanyID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ExportDescriptionNotes)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.ExportLifeCycleCostTotal).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");
            });

            modelBuilder.Entity<AppFactor>(entity =>
            {
                entity.Property(e => e.AppFactorId)
                    .HasColumnName("AppFactorID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppFactorName)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.AppFactorRelatedtoId).HasColumnName("AppFactorRelatedtoID");

                entity.Property(e => e.AppFactorValue).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppFinancialInstituition>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AppCountryCode).HasMaxLength(20);

                entity.Property(e => e.AppDocumentTransactionId).HasColumnName("AppDocumentTransactionID");

                entity.Property(e => e.AppFhidapproved)
                    .IsRequired()
                    .HasColumnName("AppFHIDApproved")
                    .HasMaxLength(200);

                entity.Property(e => e.AppFinancialInstituitionId).HasColumnName("AppFinancialInstituitionID");

                entity.Property(e => e.AppFinancialInstituitionName)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.AppStateCode).HasMaxLength(20);

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<AppFreight>(entity =>
            {
                entity.Property(e => e.AppFreightId)
                    .HasColumnName("AppFreightID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppFreightCarrierTypeId).HasColumnName("AppFreightCarrierTypeID");

                entity.Property(e => e.AppFreightDesc)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.AppFreightName)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.AppFreightWeight).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppFreightType>(entity =>
            {
                entity.Property(e => e.AppFreightTypeId)
                    .HasColumnName("AppFreightTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppFreightTypeDesc)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.AppFreightTypeName)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppGroundActivity>(entity =>
            {
                entity.Property(e => e.AppGroundActivityId)
                    .HasColumnName("AppGroundActivityID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppGroundLogisticsId).HasColumnName("AppGroundLogisticsID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DestinationLocation)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.SourceLocation)
                    .IsRequired()
                    .HasMaxLength(2000);
            });

            modelBuilder.Entity<AppGroundLifter>(entity =>
            {
                entity.HasKey(e => e.AppForkLifterId)
                    .HasName("PK_AppForkLifterID");

                entity.Property(e => e.AppForkLifterId)
                    .HasColumnName("AppForkLifterID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppForkLifterColor)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.AppForkLifterMaxWeightCapacity).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AppForkLifterName)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Vinnumber)
                    .IsRequired()
                    .HasColumnName("VINNumber")
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<AppGroundLogistics>(entity =>
            {
                entity.HasKey(e => e.AppGroundLogisticId)
                    .HasName("PK_AppGroundLogisticID");

                entity.Property(e => e.AppGroundLogisticId)
                    .HasColumnName("AppGroundLogisticID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppGroundLogisticsDesc)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.AppGroundLogisticsInternalOrExternal)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.AppGroundLogisticsName)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.AppGroundSourceAddress)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.AppGroundSourceZipCode).HasMaxLength(12);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppGroundPlacementParkNumber>(entity =>
            {
                entity.HasKey(e => e.PlacementParkId)
                    .HasName("PK_AppGroundPlacementParkID");

                entity.Property(e => e.PlacementParkId)
                    .HasColumnName("PlacementParkID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.PlacementNumberHeight).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PlacementNumberId).HasColumnName("PlacementNumberID");

                entity.Property(e => e.PlacementNumberTag)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.PlacementParkSquareWidth).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PlacementParkStatus)
                    .IsRequired()
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<AppImport>(entity =>
            {
                entity.Property(e => e.AppImportId)
                    .HasColumnName("AppImportID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppBuyerId).HasColumnName("AppBuyerID");

                entity.Property(e => e.AppDutyId).HasColumnName("AppDutyID");

                entity.Property(e => e.AppSellerId).HasColumnName("AppSellerID");

                entity.Property(e => e.AppTradeFinanceCompanyId).HasColumnName("AppTradeFinanceCompanyID");

                entity.Property(e => e.ContractNonArrivalExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ImportDamagedInsuranceCost).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ImportDeprecatedCostCycle).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ImportDescriptionNotes)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.ImportLifeCycleCostTotal).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");
            });

            modelBuilder.Entity<AppIndustrialRegion>(entity =>
            {
                entity.HasKey(e => e.AppIndustrialRegionD)
                    .HasName("PK_AppIndustrialRegionD");

                entity.Property(e => e.AppIndustrialRegionD).ValueGeneratedNever();

                entity.Property(e => e.AppIndustrialRegionName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.AppIndustrialRegionState)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.AppIndustrialRegionZipCode).HasMaxLength(24);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppIndustrialZone>(entity =>
            {
                entity.Property(e => e.AppIndustrialZoneId)
                    .HasColumnName("AppIndustrialZoneID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppIndustrialRegionId).HasColumnName("AppIndustrialRegionID");

                entity.Property(e => e.AppIndustrialZoneName)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.AppZonePopulation).HasMaxLength(2000);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppInstruementation>(entity =>
            {
                entity.Property(e => e.AppInstruementationId)
                    .HasColumnName("AppInstruementationID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppAcuracyPrecesionRate).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.AppErrorPrecesionRate).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.AppInsruementFactorVal).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.AppInstrumentChemicalResistanceRate).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.AppInstrumentDimensionsCalcAfactor)
                    .HasColumnName("AppInstrumentDimensionsCalcAFactor")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.AppInstrumentDimensionsCalcBfactor)
                    .HasColumnName("AppInstrumentDimensionsCalcBFactor")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.AppInstrumentDimensionsCalcCfactor)
                    .HasColumnName("AppInstrumentDimensionsCalcCFactor")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.AppInstrumentDimensionsCalcDfactor)
                    .HasColumnName("AppInstrumentDimensionsCalcDFactor")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.AppInstrumentDimensionsCalcEfactor)
                    .HasColumnName("AppInstrumentDimensionsCalcEFactor")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.AppInstrumentMetalCombinationsId).HasColumnName("AppInstrumentMetalCombinationsID");

                entity.Property(e => e.AppInstrumentMetalCorrosionRate).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.AppInstrumentTypeId).HasColumnName("AppInstrumentTypeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppJsonfile>(entity =>
            {
                entity.ToTable("AppJSONFile");

                entity.Property(e => e.AppJsonfileId)
                    .HasColumnName("AppJSONFileID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppJsonfileName)
                    .IsRequired()
                    .HasColumnName("AppJSONFileName")
                    .HasMaxLength(2000);

                entity.Property(e => e.AppJsonfileUrl)
                    .HasColumnName("AppJSONFileURL")
                    .HasMaxLength(2000);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppKey>(entity =>
            {
                entity.HasIndex(e => e.AppClientEmailId)
                    .HasName("UQ__AppKey__6FC0E5D43E0A1B84")
                    .IsUnique();

                entity.HasIndex(e => e.AppClientPhone)
                    .HasName("UQ__AppKey__43F371AA95EE9E70")
                    .IsUnique();

                entity.Property(e => e.AppKeyId)
                    .HasColumnName("AppKeyID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppClientCompany).HasMaxLength(200);

                entity.Property(e => e.AppClientEmailId)
                    .IsRequired()
                    .HasColumnName("AppClientEmailID")
                    .HasMaxLength(200);

                entity.Property(e => e.AppClientIpadressAllowed)
                    .IsRequired()
                    .HasColumnName("AppClientIPAdressAllowed")
                    .HasMaxLength(32);

                entity.Property(e => e.AppClientPhone)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.AppKeyDesc)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppMetalCombinationAlloy>(entity =>
            {
                entity.Property(e => e.AppMetalCombinationAlloyId)
                    .HasColumnName("AppMetalCombinationAlloyID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppAtSeparatedMetalPeriodicTableId)
                    .IsRequired()
                    .HasColumnName("AppAtSeparatedMetalPeriodicTableID")
                    .HasMaxLength(2000);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MaximumHeatingAppliedTemp).HasColumnType("decimal(4, 2)");
            });

            modelBuilder.Entity<AppPackage>(entity =>
            {
                entity.Property(e => e.AppPackageId)
                    .HasColumnName("AppPackageID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppPackageDepth).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.AppPackageWidth).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.AppPackaheHeight).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.AppPakagerName)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppPackageHandler>(entity =>
            {
                entity.Property(e => e.AppPackageHandlerId)
                    .HasColumnName("AppPackageHandlerID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppPackageHandlerFitnessNotes)
                    .HasColumnName("AppPAckageHandlerFitnessNotes")
                    .HasMaxLength(3000);

                entity.Property(e => e.AppPackageHandlerStateId)
                    .HasColumnName("AppPackageHandlerStateID")
                    .HasMaxLength(14);

                entity.Property(e => e.AppPakageHandlerName)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.LastHandledFreightIdref).HasColumnName("LastHandledFreightIDRef");

                entity.Property(e => e.LastPackageHandledDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppPallete>(entity =>
            {
                entity.HasKey(e => e.AppPallateId)
                    .HasName("PK_AppPalletID");

                entity.Property(e => e.AppPallateId)
                    .HasColumnName("AppPallateID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppPallateName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.AppPallateSizeHeight).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AppPallateSizeWidth).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppPriceParityCheck>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AppPriceParityCheckId).HasColumnName("AppPriceParityCheckID");

                entity.Property(e => e.AppPriceParityCheckReason)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.AppProductId).HasColumnName("AppProductID");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DeductionApplied).HasColumnType("decimal(8, 2)");
            });

            modelBuilder.Entity<AppProcess>(entity =>
            {
                entity.Property(e => e.AppProcessId)
                    .HasColumnName("AppProcessID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppProcessDesc)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.AppProcessMode)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.AppProcessName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppProcessLanguageTokens>(entity =>
            {
                entity.HasKey(e => e.LanguageTokenId)
                    .HasName("PK_LanguageTokenID");

                entity.Property(e => e.LanguageTokenId)
                    .HasColumnName("LanguageTokenID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.LanguageTokenSymbol)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ReadFunctionalityOfTokenJson)
                    .IsRequired()
                    .HasColumnName("ReadFunctionalityOfTokenJSON")
                    .HasMaxLength(2000);
            });

            modelBuilder.Entity<AppProcessLog>(entity =>
            {
                entity.Property(e => e.AppProcessLogId)
                    .HasColumnName("AppProcessLogID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppProcessId)
                    .IsRequired()
                    .HasColumnName("AppProcessID")
                    .HasMaxLength(200);

                entity.Property(e => e.AppProcessLogDumpings)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.AppProcessLogInformation)
                    .IsRequired()
                    .HasMaxLength(3000);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppProcessPipeLine>(entity =>
            {
                entity.HasKey(e => e.AppProcessPipleLineId)
                    .HasName("PK_AppProcessPipleLineID");

                entity.Property(e => e.AppProcessPipleLineId)
                    .HasColumnName("AppProcessPipleLineID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppProcessPipeLineName)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.AppProcessPipeLinkActivityId).HasColumnName("AppProcessPipeLinkActivityID");

                entity.Property(e => e.AppProcessPipeLinkedEndId).HasColumnName("AppProcessPipeLinkedEndID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppProcessRunningOnServer>(entity =>
            {
                entity.Property(e => e.AppProcessRunningOnServerId)
                    .HasColumnName("AppProcessRunningOnServerID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppProcessId).HasColumnName("AppProcessID");

                entity.Property(e => e.AppProcessRunningOnServerName)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.AppProcessRunningServerFileSystem)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppProduct>(entity =>
            {
                entity.Property(e => e.AppProductId)
                    .HasColumnName("AppProductID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppProductBarCode).HasMaxLength(3000);

                entity.Property(e => e.AppProductName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.AppProductPerUnitPrice).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppProperty>(entity =>
            {
                entity.Property(e => e.AppPropertyId)
                    .HasColumnName("AppPropertyID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppDataTypeId).HasColumnName("AppDataTypeID");

                entity.Property(e => e.AppPropertyName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppRouteAlert>(entity =>
            {
                entity.Property(e => e.AppRouteAlertId)
                    .HasColumnName("AppRouteAlertID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppRouteAlertDesc)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.AppRouteAlertEvent)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.AppRouteChangeNotification).HasMaxLength(2000);

                entity.Property(e => e.AppRouteId)
                    .IsRequired()
                    .HasColumnName("AppRouteID")
                    .HasMaxLength(1);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppSaleActivity>(entity =>
            {
                entity.Property(e => e.AppSaleActivityId)
                    .HasColumnName("AppSaleActivityID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppActivityId).HasColumnName("AppActivityID");

                entity.Property(e => e.AppSaleDesc)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.SalePersonId).HasColumnName("SalePersonID");
            });

            modelBuilder.Entity<AppSeller>(entity =>
            {
                entity.HasIndex(e => e.AppSellerHashedSsc)
                    .HasName("UQ__AppSelle__4F1170A9A13DC066")
                    .IsUnique();

                entity.Property(e => e.AppSellerId)
                    .HasColumnName("AppSellerID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppSellerHashedSsc)
                    .HasColumnName("AppSellerHashedSSC")
                    .HasMaxLength(200);

                entity.Property(e => e.AppSellerLicenseHashedId)
                    .HasColumnName("AppSellerLicenseHashedID")
                    .HasMaxLength(200);

                entity.Property(e => e.AppSellerName)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppSellerActivity>(entity =>
            {
                entity.Property(e => e.AppSellerActivityId)
                    .HasColumnName("AppSellerActivityID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppActivityId).HasColumnName("AppActivityID");

                entity.Property(e => e.AppSellerActivityDesc).HasMaxLength(200);

                entity.Property(e => e.AppSellerId).HasColumnName("AppSellerID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppSensitiveMaterial>(entity =>
            {
                entity.HasKey(e => e.AppSensitiveMateriaId)
                    .HasName("PK_SensativeMaterialID");

                entity.Property(e => e.AppSensitiveMateriaId)
                    .HasColumnName("AppSensitiveMateriaID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppBuyerHashedSsc)
                    .HasColumnName("AppBuyerHashedSSC")
                    .HasMaxLength(2000);

                entity.Property(e => e.AppSensativeMaterialName)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.AppSensativeMaterialNotesEncrypted)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppShelve>(entity =>
            {
                entity.Property(e => e.AppShelveId)
                    .HasColumnName("AppShelveID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppCategoryId).HasColumnName("AppCategoryID");

                entity.Property(e => e.AppFreightWeight).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AppShelveHeight).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.AppShelveWidth).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppSupply>(entity =>
            {
                entity.Property(e => e.AppSupplyId)
                    .HasColumnName("AppSupplyID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppProductId).HasColumnName("AppProductID");

                entity.Property(e => e.AppSupplyAddOnRate).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.AppSupplyDeprivalRate).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.AppSupplyFromIndustryCode).HasMaxLength(10);

                entity.Property(e => e.AppSupplyName)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.AppSupplyPercentage)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppSupplyDemandChart>(entity =>
            {
                entity.HasKey(e => e.AppSupplyDemandId)
                    .HasName("PK_AppSupplyDemandID");

                entity.Property(e => e.AppSupplyDemandId)
                    .HasColumnName("AppSupplyDemandID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppCureencyCode)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.AppGoodsExchanged).HasMaxLength(10);

                entity.Property(e => e.AppPriceExchanged).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.AppProductId).HasColumnName("AppProductID");

                entity.Property(e => e.AppSupplyAddOnRate).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.AppSupplyDeprivalRate).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Quantity)
                    .IsRequired()
                    .HasMaxLength(2000);
            });

            modelBuilder.Entity<AppToken>(entity =>
            {
                entity.Property(e => e.AppTokenId)
                    .HasColumnName("AppTokenID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppClientName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.AppNameDesc)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.AppTokenUserId).HasColumnName("AppTokenUserID");

                entity.Property(e => e.AppUserPwd)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.TokenExpiredDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppTokenDetails>(entity =>
            {
                entity.HasKey(e => e.AppTokenDetailId)
                    .HasName("PK_AppTokenDetailID");

                entity.Property(e => e.AppTokenDetailId)
                    .HasColumnName("AppTokenDetailID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppCompanyId)
                    .IsRequired()
                    .HasColumnName("AppCompanyID")
                    .HasMaxLength(200);

                entity.Property(e => e.AppSecurePhoneNumber)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.AppTokenId).HasColumnName("AppTokenID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.TokenExpiredDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppTokenGeneration>(entity =>
            {
                entity.HasKey(e => e.AppTokenId)
                    .HasName("PK_AppTokenGenID");

                entity.HasIndex(e => e.AppTokenGenId)
                    .HasName("UQ__AppToken__7DA0ED63114C6535")
                    .IsUnique();

                entity.Property(e => e.AppTokenId)
                    .HasColumnName("AppTokenID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppTokenGenId)
                    .IsRequired()
                    .HasColumnName("AppTokenGenID")
                    .HasMaxLength(2000);

                entity.Property(e => e.AppTokenGenOid)
                    .IsRequired()
                    .HasColumnName("AppTokenGenOID")
                    .HasMaxLength(2000);

                entity.Property(e => e.AppUserId).HasColumnName("AppUserID");

                entity.Property(e => e.ClientNameDesc)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppTray>(entity =>
            {
                entity.Property(e => e.AppTrayId)
                    .HasColumnName("AppTrayID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppTrayName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.AppTraySizeHeight).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AppTraySizeWidth).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppTruck>(entity =>
            {
                entity.Property(e => e.AppTruckId)
                    .HasColumnName("AppTruckID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppTruckColorModelDecs)
                    .IsRequired()
                    .HasMaxLength(3000);

                entity.Property(e => e.AppTruckVehicleIdnVin)
                    .IsRequired()
                    .HasColumnName("AppTruckVehicleIDN_VIN")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppTruckRoute>(entity =>
            {
                entity.Property(e => e.AppTruckRouteId)
                    .HasColumnName("AppTruckRouteID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppTrouteDestinationNode)
                    .IsRequired()
                    .HasColumnName("AppTRouteDestinationNode")
                    .HasMaxLength(20);

                entity.Property(e => e.AppTrouteManualIntersectionPointA)
                    .IsRequired()
                    .HasColumnName("AppTRouteManualIntersectionPointA")
                    .HasMaxLength(300);

                entity.Property(e => e.AppTrouteManualIntersectionPointB)
                    .IsRequired()
                    .HasColumnName("AppTRouteManualIntersectionPointB")
                    .HasMaxLength(300);

                entity.Property(e => e.AppTrouteManualIntersectionPointC)
                    .IsRequired()
                    .HasColumnName("AppTRouteManualIntersectionPointC")
                    .HasMaxLength(300);

                entity.Property(e => e.AppTrouteManualIntersectionPointD)
                    .IsRequired()
                    .HasColumnName("AppTRouteManualIntersectionPointD")
                    .HasMaxLength(300);

                entity.Property(e => e.AppTrouteSourceNode)
                    .IsRequired()
                    .HasColumnName("AppTRouteSourceNode")
                    .HasMaxLength(20);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppTruckRouteAssigned>(entity =>
            {
                entity.Property(e => e.AppTruckRouteAssignedId)
                    .HasColumnName("AppTruckRouteAssignedID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppTrouteDestinationNode)
                    .IsRequired()
                    .HasColumnName("AppTRouteDestinationNode")
                    .HasMaxLength(20);

                entity.Property(e => e.AppTrouteSourceNode)
                    .IsRequired()
                    .HasColumnName("AppTRouteSourceNode")
                    .HasMaxLength(20);

                entity.Property(e => e.AppTruckId).HasColumnName("AppTruckID");

                entity.Property(e => e.AppTruckRouteId).HasColumnName("AppTruckRouteID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppUidataDependencyInjection>(entity =>
            {
                entity.HasKey(e => e.AppUidataInjectionId)
                    .HasName("PK_AppUIDataInjectionID");

                entity.ToTable("AppUIDataDependencyInjection");

                entity.Property(e => e.AppUidataInjectionId)
                    .HasColumnName("AppUIDataInjectionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppUitemplateId).HasColumnName("AppUITemplateID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DataDependencyFileJson)
                    .IsRequired()
                    .HasColumnName("DataDependencyFileJSON")
                    .HasMaxLength(2000);
            });

            modelBuilder.Entity<AppUitemplate>(entity =>
            {
                entity.ToTable("AppUITemplate");

                entity.Property(e => e.AppUitemplateId)
                    .HasColumnName("AppUITemplateID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppUitemplateDesc)
                    .IsRequired()
                    .HasColumnName("AppUITemplateDesc")
                    .HasMaxLength(2000);

                entity.Property(e => e.AppUitemplateName)
                    .IsRequired()
                    .HasColumnName("AppUITemplateName")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppUitemplateData>(entity =>
            {
                entity.ToTable("AppUITemplateData");

                entity.Property(e => e.AppUitemplateDataId)
                    .HasColumnName("AppUITemplateDataID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppUitemplateData1)
                    .IsRequired()
                    .HasColumnName("AppUITemplateData")
                    .HasMaxLength(3000);

                entity.Property(e => e.AppUitemplateMetaData)
                    .IsRequired()
                    .HasColumnName("AppUITemplateMetaData")
                    .HasColumnType("xml");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppUser>(entity =>
            {
                entity.Property(e => e.AppUserId)
                    .HasColumnName("AppUserID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppNameDesc)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.AppRoleId).HasColumnName("AppRoleID");

                entity.Property(e => e.AppUserName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.AppUserPwd)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppUserActivityDetails>(entity =>
            {
                entity.Property(e => e.AppUserActivityDetailsId)
                    .HasColumnName("AppUserActivityDetailsID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppUserActivityId).HasColumnName("AppUserActivityID");

                entity.Property(e => e.AppUserActivityInputId)
                    .IsRequired()
                    .HasColumnName("AppUserActivityInputID")
                    .HasMaxLength(2000);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppUserActivityErrors>(entity =>
            {
                entity.HasKey(e => e.AppUserActivityErrorId)
                    .HasName("PK_AppUserActivityErrorID");

                entity.Property(e => e.AppUserActivityErrorId)
                    .HasColumnName("AppUserActivityErrorID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppUserActivityErrorDesc)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.AppUserActivityId)
                    .IsRequired()
                    .HasColumnName("AppUserActivityID")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppUserActivityExecutedTime>(entity =>
            {
                entity.Property(e => e.AppUserActivityExecutedTimeId)
                    .HasColumnName("AppUserActivityExecutedTimeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActivityStoppedOrInterrupted).HasColumnType("datetime");

                entity.Property(e => e.AppUserActivityEndDate).HasColumnType("datetime");

                entity.Property(e => e.AppUserActivityId)
                    .IsRequired()
                    .HasColumnName("AppUserActivityID")
                    .HasMaxLength(200);

                entity.Property(e => e.AppUserActivityStartDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppUserActivityFrame>(entity =>
            {
                entity.Property(e => e.AppUserActivityFrameId)
                    .HasColumnName("AppUserActivityFrameID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppUserActivityFrameEndDate).HasColumnType("datetime");

                entity.Property(e => e.AppUserActivityFrameStartDate).HasColumnType("datetime");

                entity.Property(e => e.AppUserActivityId)
                    .IsRequired()
                    .HasColumnName("AppUserActivityID")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppUserActivityInput>(entity =>
            {
                entity.Property(e => e.AppUserActivityInputId)
                    .HasColumnName("AppUserActivityInputID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppUserActivityInputName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.AppUserActivityInputType)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.AppUserActivityInputValue)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppUserRole>(entity =>
            {
                entity.Property(e => e.AppUserRoleId)
                    .HasColumnName("AppUserRoleID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppRoleAssociateDesc)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.AppRoleNameDesc)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.AppUserRoleName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppUserRoleDetail>(entity =>
            {
                entity.Property(e => e.AppUserRoleDetailId)
                    .HasColumnName("AppUserRoleDetailID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppUitemplateId).HasColumnName("AppUITemplateID");

                entity.Property(e => e.AppUserRoleDetailDesc)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.AppUserRoleId).HasColumnName("AppUserRoleID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppUserSesion>(entity =>
            {
                entity.HasKey(e => e.AppSessionId)
                    .HasName("PK_AppSessionID");

                entity.Property(e => e.AppSessionId)
                    .HasColumnName("AppSessionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppClientUserIp)
                    .IsRequired()
                    .HasColumnName("AppClientUserIP")
                    .HasMaxLength(200);

                entity.Property(e => e.AppSessionName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppUserSessionCrossRefVar>(entity =>
            {
                entity.HasKey(e => e.AppSessionRefVarId)
                    .HasName("PK_AppSessionRefVarID");

                entity.Property(e => e.AppSessionRefVarId)
                    .HasColumnName("AppSessionRefVarID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppSessionId).HasColumnName("AppSessionID");

                entity.Property(e => e.AppSessionValueUpdate)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.AppSessionVarName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.AppSessionVarType)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppWareHouse>(entity =>
            {
                entity.Property(e => e.AppWareHouseId)
                    .HasColumnName("AppWareHouseID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppWareHosueLocationCountryCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.AppWareHouseLoctaionCity)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.AppWareHouseName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.AppWareHouseNetItemCost).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AppWareHouseStreetAddress)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppWareHouseNode>(entity =>
            {
                entity.Property(e => e.AppWareHouseNodeId)
                    .HasColumnName("AppWareHouseNodeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppWareHouseNodeName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppWareHouseVendor>(entity =>
            {
                entity.Property(e => e.AppWareHouseVendorId)
                    .HasColumnName("AppWareHouseVendorID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppWareHouseMaterialExpert)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.AppWareHouseVendorName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ApplicationContext>(entity =>
            {
                entity.Property(e => e.ApplicationContextId)
                    .HasColumnName("ApplicationContextID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppClientId)
                    .HasColumnName("AppClientID")
                    .HasMaxLength(2000);

                entity.Property(e => e.AppClientSecretKey).HasMaxLength(13);

                entity.Property(e => e.ApplicationContextName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ApplicationModel>(entity =>
            {
                entity.HasKey(e => e.AppId)
                    .HasName("PK_AppID");

                entity.Property(e => e.AppId)
                    .HasColumnName("AppID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppModelName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.AppServerIphashed)
                    .IsRequired()
                    .HasColumnName("AppServerIPHashed")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Sysdiagrams>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sysdiagrams");

                entity.Property(e => e.Definition).HasColumnName("definition");

                entity.Property(e => e.DiagramId).HasColumnName("diagram_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(128);

                entity.Property(e => e.PrincipalId).HasColumnName("principal_id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
