using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

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

        public virtual DbSet<AppActivity> AppActivities { get; set; }
        public virtual DbSet<AppBuyer> AppBuyers { get; set; }
        public virtual DbSet<AppBuyerActivity> AppBuyerActivities { get; set; }
        public virtual DbSet<AppBuyerCostSheet> AppBuyerCostSheets { get; set; }
        public virtual DbSet<AppBuyerSellerTrade> AppBuyerSellerTrades { get; set; }
        public virtual DbSet<AppCategory> AppCategories { get; set; }
        public virtual DbSet<AppClass> AppClasses { get; set; }
        public virtual DbSet<AppCompany> AppCompanies { get; set; }
        public virtual DbSet<AppCrossRefProcess> AppCrossRefProcesses { get; set; }
        public virtual DbSet<AppDataType> AppDataTypes { get; set; }
        public virtual DbSet<AppDemand> AppDemands { get; set; }
        public virtual DbSet<AppDispatch> AppDispatches { get; set; }
        public virtual DbSet<AppDocumentAssigned> AppDocumentAssigneds { get; set; }
        public virtual DbSet<AppDocumentTransaction> AppDocumentTransactions { get; set; }
        public virtual DbSet<AppDoor> AppDoors { get; set; }
        public virtual DbSet<AppDoorKey> AppDoorKeys { get; set; }
        public virtual DbSet<AppDriver> AppDrivers { get; set; }
        public virtual DbSet<AppError> AppErrors { get; set; }
        public virtual DbSet<AppExport> AppExports { get; set; }
        public virtual DbSet<AppFactor> AppFactors { get; set; }
        public virtual DbSet<AppFinancialInstituition> AppFinancialInstituitions { get; set; }
        public virtual DbSet<AppFreight> AppFreights { get; set; }
        public virtual DbSet<AppFreightType> AppFreightTypes { get; set; }
        public virtual DbSet<AppGroundActivity> AppGroundActivities { get; set; }
        public virtual DbSet<AppGroundLifter> AppGroundLifters { get; set; }
        public virtual DbSet<AppGroundLogistic> AppGroundLogistics { get; set; }
        public virtual DbSet<AppGroundPlacementParkNumber> AppGroundPlacementParkNumbers { get; set; }
        public virtual DbSet<AppImport> AppImports { get; set; }
        public virtual DbSet<AppIndustrialRegion> AppIndustrialRegions { get; set; }
        public virtual DbSet<AppIndustrialZone> AppIndustrialZones { get; set; }
        public virtual DbSet<AppInstruementation> AppInstruementations { get; set; }
        public virtual DbSet<AppJsonfile> AppJsonfiles { get; set; }
        public virtual DbSet<AppKey> AppKeys { get; set; }
        public virtual DbSet<AppMetalCombinationAlloy> AppMetalCombinationAlloys { get; set; }
        public virtual DbSet<AppOrder> AppOrders { get; set; }
        public virtual DbSet<AppPackage> AppPackages { get; set; }
        public virtual DbSet<AppPackageHandler> AppPackageHandlers { get; set; }
        public virtual DbSet<AppPallete> AppPalletes { get; set; }
        public virtual DbSet<AppPriceParityCheck> AppPriceParityChecks { get; set; }
        public virtual DbSet<AppProcess> AppProcesses { get; set; }
        public virtual DbSet<AppProcessLanguageToken> AppProcessLanguageTokens { get; set; }
        public virtual DbSet<AppProcessLog> AppProcessLogs { get; set; }
        public virtual DbSet<AppProcessPipeLine> AppProcessPipeLines { get; set; }
        public virtual DbSet<AppProcessRunningOnServer> AppProcessRunningOnServers { get; set; }
        public virtual DbSet<AppProduct> AppProducts { get; set; }
        public virtual DbSet<AppProperty> AppProperties { get; set; }
        public virtual DbSet<AppRouteAlert> AppRouteAlerts { get; set; }
        public virtual DbSet<AppSaleActivity> AppSaleActivities { get; set; }
        public virtual DbSet<AppSeller> AppSellers { get; set; }
        public virtual DbSet<AppSellerActivity> AppSellerActivities { get; set; }
        public virtual DbSet<AppSensitiveMaterial> AppSensitiveMaterials { get; set; }
        public virtual DbSet<AppShelve> AppShelves { get; set; }
        public virtual DbSet<AppSupply> AppSupplies { get; set; }
        public virtual DbSet<AppSupplyDemandChart> AppSupplyDemandCharts { get; set; }
        public virtual DbSet<AppToken> AppTokens { get; set; }
        public virtual DbSet<AppTokenDetail> AppTokenDetails { get; set; }
        public virtual DbSet<AppTokenGeneration> AppTokenGenerations { get; set; }
        public virtual DbSet<AppTray> AppTrays { get; set; }
        public virtual DbSet<AppTruck> AppTrucks { get; set; }
        public virtual DbSet<AppTruckRoute> AppTruckRoutes { get; set; }
        public virtual DbSet<AppTruckRouteAssigned> AppTruckRouteAssigneds { get; set; }
        public virtual DbSet<AppUidataDependencyInjection> AppUidataDependencyInjections { get; set; }
        public virtual DbSet<AppUitemplate> AppUitemplates { get; set; }
        public virtual DbSet<AppUitemplateDatum> AppUitemplateData { get; set; }
        public virtual DbSet<AppUser> AppUsers { get; set; }
        public virtual DbSet<AppUserActivityDetail> AppUserActivityDetails { get; set; }
        public virtual DbSet<AppUserActivityError> AppUserActivityErrors { get; set; }
        public virtual DbSet<AppUserActivityExecutedTime> AppUserActivityExecutedTimes { get; set; }
        public virtual DbSet<AppUserActivityFrame> AppUserActivityFrames { get; set; }
        public virtual DbSet<AppUserActivityInput> AppUserActivityInputs { get; set; }
        public virtual DbSet<AppUserRole> AppUserRoles { get; set; }
        public virtual DbSet<AppUserSesion> AppUserSesions { get; set; }
        public virtual DbSet<AppUserSessionCrossRefVar> AppUserSessionCrossRefVars { get; set; }
        public virtual DbSet<AppWareHouse> AppWareHouses { get; set; }
        public virtual DbSet<AppWareHouseNode> AppWareHouseNodes { get; set; }
        public virtual DbSet<AppWareHouseVendor> AppWareHouseVendors { get; set; }
        public virtual DbSet<Appcart> Appcarts { get; set; }
        public virtual DbSet<ApplicationContext> ApplicationContexts { get; set; }
        public virtual DbSet<ApplicationModel> ApplicationModels { get; set; }
        public virtual DbSet<Applocation> Applocations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=tcp:blueserverdb.database.windows.net,1433;user id=sqlserveradmin;Password=Tango@#^*199;Initial Catalog=blueKangroo;Trusted_Connection=True; Integrated Security=false;Connection Timeout=1800");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AppActivity>(entity =>
            {
                entity.ToTable("AppActivity");

                entity.HasIndex(e => new { e.AppProjectId, e.AppActivityName }, "UQ__AppActiv__56AE0C02A6A26594")
                    .IsUnique();

                entity.Property(e => e.AppActivityId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppActivityID");

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
                entity.ToTable("AppBuyer");

                entity.HasIndex(e => e.AppBuyerHashedSsc, "UQ__AppBuyer__AD5E7D9CF0129169")
                    .IsUnique();

                entity.Property(e => e.AppBuyerId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppBuyerID");

                entity.Property(e => e.AppBuyerHashedSsc)
                    .HasMaxLength(2000)
                    .HasColumnName("AppBuyerHashedSSC");

                entity.Property(e => e.AppBuyerLicenseHashedId)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .HasColumnName("AppBuyerLicenseHashedID");

                entity.Property(e => e.AppBuyerName)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppBuyerActivity>(entity =>
            {
                entity.ToTable("AppBuyerActivity");

                entity.Property(e => e.AppBuyerActivityId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppBuyerActivityID");

                entity.Property(e => e.AppActivityId).HasColumnName("AppActivityID");

                entity.Property(e => e.AppBuyerActivityDesc).HasMaxLength(200);

                entity.Property(e => e.AppBuyerId).HasColumnName("AppBuyerID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppBuyerCostSheet>(entity =>
            {
                entity.HasKey(e => e.AppBuyerCostId)
                    .HasName("PK_AppBuyerCostID");

                entity.ToTable("AppBuyerCostSheet");

                entity.Property(e => e.AppBuyerCostId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppBuyerCostID");

                entity.Property(e => e.AppBuyerId)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .HasColumnName("AppBuyerID");

                entity.Property(e => e.AppDutyIdapplied).HasColumnName("AppDutyIDApplied");

                entity.Property(e => e.AppItemCost).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.AppProductId)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .HasColumnName("AppProductID");

                entity.Property(e => e.AppShipmentCost).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppBuyerSellerTrade>(entity =>
            {
                entity.HasKey(e => e.AppTradeId)
                    .HasName("PK_AppTradeID");

                entity.ToTable("AppBuyerSellerTrade");

                entity.Property(e => e.AppTradeId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppTradeID");

                entity.Property(e => e.AppBuyerId).HasColumnName("AppBuyerID");

                entity.Property(e => e.AppSellerId).HasColumnName("AppSellerID");

                entity.Property(e => e.AppTransactionId).HasColumnName("AppTransactionID");

                entity.Property(e => e.AppUserId).HasColumnName("AppUserID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppCategory>(entity =>
            {
                entity.ToTable("AppCategory");

                entity.Property(e => e.AppCategoryId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppCategoryID");

                entity.Property(e => e.AppCategoryName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppClass>(entity =>
            {
                entity.ToTable("AppClass");

                entity.Property(e => e.AppClassId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppClassID");

                entity.Property(e => e.AppClassName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppCompany>(entity =>
            {
                entity.ToTable("AppCompany");

                entity.Property(e => e.AppCompanyId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppCompanyID");

                entity.Property(e => e.AppCompanyOrganizationName)
                    .IsRequired()
                    .HasMaxLength(600);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppCrossRefProcess>(entity =>
            {
                entity.ToTable("AppCrossRefPRocess");

                entity.Property(e => e.AppCrossRefProcessId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppCrossRefProcessID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.NextSubProcessId).HasColumnName("NextSubProcessID ");

                entity.Property(e => e.ProcessSourceId).HasColumnName("ProcessSourceID");
            });

            modelBuilder.Entity<AppDataType>(entity =>
            {
                entity.ToTable("AppDataType");

                entity.Property(e => e.AppDataTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppDataTypeID");

                entity.Property(e => e.AppDataTypeName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppDemand>(entity =>
            {
                entity.ToTable("AppDemand");

                entity.Property(e => e.AppDemandId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppDemandID");

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

            modelBuilder.Entity<AppDispatch>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AppDispatch");

                entity.Property(e => e.AppActualDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.AppActualDipatchDate).HasColumnType("datetime");

                entity.Property(e => e.AppCartId).HasColumnName("AppCartID");

                entity.Property(e => e.AppDipatchDetailsDesc)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.AppDispatchId).HasColumnName("AppDispatchID");

                entity.Property(e => e.AppEstimatedDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.AppLocationId).HasColumnName("AppLocationID");

                entity.Property(e => e.AppPackageHandlerId).HasColumnName("AppPackageHandlerID");

                entity.Property(e => e.AppPackageId).HasColumnName("AppPackageID");

                entity.Property(e => e.AppScheduledDispatchDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RecallCancelDispatchedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppDocumentAssigned>(entity =>
            {
                entity.HasKey(e => e.BusineesDocAssignedId)
                    .HasName("PK_BusinessDocAssignedID");

                entity.ToTable("AppDocumentAssigned");

                entity.Property(e => e.BusineesDocAssignedId)
                    .ValueGeneratedNever()
                    .HasColumnName("BusineesDocAssignedID");

                entity.Property(e => e.ActivityAssignedId).HasColumnName("ActivityAssignedID");

                entity.Property(e => e.BusinessDocUserId).HasColumnName("BusinessDocUserID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppDocumentTransaction>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AppDocumentTransaction");

                entity.Property(e => e.AppDocumentAmount).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.AppDocumentSignature)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength(true);

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
                entity.ToTable("AppDoor");

                entity.Property(e => e.AppDoorId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppDoorID");

                entity.Property(e => e.AppDoorName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppDoorKey>(entity =>
            {
                entity.ToTable("AppDoorKey");

                entity.Property(e => e.AppDoorKeyId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppDoorKeyID");

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
                entity.ToTable("AppDriver");

                entity.Property(e => e.AppDriverId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppDriverID");

                entity.Property(e => e.AppDriverAddress)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.AppDriverImageUrlphoto)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .HasColumnName("AppDriverImageURLPhoto");

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
                entity.HasKey(e => e.AppErrorCodeId)
                    .HasName("PK__AppError__63EE91F77153D529");

                entity.ToTable("AppError");

                entity.Property(e => e.AppErrorCodeId).ValueGeneratedNever();

                entity.Property(e => e.AppErrorDescription)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.AppErrorType)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppExport>(entity =>
            {
                entity.ToTable("AppExport");

                entity.Property(e => e.AppExportId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppExportID");

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
                entity.ToTable("AppFactor");

                entity.Property(e => e.AppFactorId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppFactorID");

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

                entity.ToTable("AppFinancialInstituition");

                entity.Property(e => e.AppCountryCode).HasMaxLength(20);

                entity.Property(e => e.AppDocumentTransactionId).HasColumnName("AppDocumentTransactionID");

                entity.Property(e => e.AppFhidapproved)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("AppFHIDApproved");

                entity.Property(e => e.AppFinancialInstituitionId).HasColumnName("AppFinancialInstituitionID");

                entity.Property(e => e.AppFinancialInstituitionName)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.AppStateCode).HasMaxLength(20);

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<AppFreight>(entity =>
            {
                entity.ToTable("AppFreight");

                entity.Property(e => e.AppFreightId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppFreightID");

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
                entity.ToTable("AppFreightType");

                entity.Property(e => e.AppFreightTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppFreightTypeID");

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
                entity.ToTable("AppGroundActivity");

                entity.Property(e => e.AppGroundActivityId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppGroundActivityID");

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

                entity.ToTable("AppGroundLifter");

                entity.Property(e => e.AppForkLifterId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppForkLifterID");

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
                    .HasMaxLength(45)
                    .HasColumnName("VINNumber");
            });

            modelBuilder.Entity<AppGroundLogistic>(entity =>
            {
                entity.Property(e => e.AppGroundLogisticId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppGroundLogisticID");

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

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppGroundPlacementParkNumber>(entity =>
            {
                entity.HasKey(e => e.PlacementParkId)
                    .HasName("PK_AppGroundPlacementParkID");

                entity.ToTable("AppGroundPlacementParkNumber");

                entity.Property(e => e.PlacementParkId)
                    .ValueGeneratedNever()
                    .HasColumnName("PlacementParkID");

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
                entity.ToTable("AppImport");

                entity.Property(e => e.AppImportId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppImportID");

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

                entity.ToTable("AppIndustrialRegion");

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
                entity.ToTable("AppIndustrialZone");

                entity.Property(e => e.AppIndustrialZoneId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppIndustrialZoneID");

                entity.Property(e => e.AppIndustrialRegionId).HasColumnName("AppIndustrialRegionID");

                entity.Property(e => e.AppIndustrialZoneName)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.AppZonePopulation).HasMaxLength(2000);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppInstruementation>(entity =>
            {
                entity.ToTable("AppInstruementation");

                entity.Property(e => e.AppInstruementationId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppInstruementationID");

                entity.Property(e => e.AppAcuracyPrecesionRate).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.AppErrorPrecesionRate).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.AppInsruementFactorVal).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.AppInstrumentChemicalResistanceRate).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.AppInstrumentDimensionsCalcAfactor)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("AppInstrumentDimensionsCalcAFactor");

                entity.Property(e => e.AppInstrumentDimensionsCalcBfactor)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("AppInstrumentDimensionsCalcBFactor");

                entity.Property(e => e.AppInstrumentDimensionsCalcCfactor)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("AppInstrumentDimensionsCalcCFactor");

                entity.Property(e => e.AppInstrumentDimensionsCalcDfactor)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("AppInstrumentDimensionsCalcDFactor");

                entity.Property(e => e.AppInstrumentDimensionsCalcEfactor)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("AppInstrumentDimensionsCalcEFactor");

                entity.Property(e => e.AppInstrumentMetalCombinationsId).HasColumnName("AppInstrumentMetalCombinationsID");

                entity.Property(e => e.AppInstrumentMetalCorrosionRate).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.AppInstrumentTypeId).HasColumnName("AppInstrumentTypeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppJsonfile>(entity =>
            {
                entity.ToTable("AppJSONFile");

                entity.Property(e => e.AppJsonfileId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppJSONFileID");

                entity.Property(e => e.AppJsonfileName)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .HasColumnName("AppJSONFileName");

                entity.Property(e => e.AppJsonfileUrl)
                    .HasMaxLength(2000)
                    .HasColumnName("AppJSONFileURL");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppKey>(entity =>
            {
                entity.ToTable("AppKey");

                entity.HasIndex(e => e.AppClientPhone, "UQ__AppKey__43F371AA09D3B6D0")
                    .IsUnique();

                entity.HasIndex(e => e.AppClientEmailId, "UQ__AppKey__6FC0E5D4D42DDE5E")
                    .IsUnique();

                entity.Property(e => e.AppKeyId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppKeyID");

                entity.Property(e => e.AppClientCompany).HasMaxLength(200);

                entity.Property(e => e.AppClientEmailId)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("AppClientEmailID");

                entity.Property(e => e.AppClientIpadressAllowed)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("AppClientIPAdressAllowed");

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
                entity.ToTable("AppMetalCombinationAlloy");

                entity.Property(e => e.AppMetalCombinationAlloyId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppMetalCombinationAlloyID");

                entity.Property(e => e.AppAtSeparatedMetalPeriodicTableId)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .HasColumnName("AppAtSeparatedMetalPeriodicTableID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MaximumHeatingAppliedTemp).HasColumnType("decimal(4, 2)");
            });

            modelBuilder.Entity<AppOrder>(entity =>
            {
                entity.ToTable("AppOrder");

                entity.Property(e => e.AppOrderId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppOrderID");

                entity.Property(e => e.AppOrderAmountTotal).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.AppOrderCountryCode)
                    .IsRequired()
                    .HasMaxLength(35);

                entity.Property(e => e.AppOrderDate).HasColumnType("datetime");

                entity.Property(e => e.AppOrderDesc)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.AppOrderPersonName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.AppOrderRefundTotal).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.AppOrderShippingStreetAddress)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.AppOrderStateCode)
                    .IsRequired()
                    .HasMaxLength(35);

                entity.Property(e => e.AppOrderZipCode)
                    .IsRequired()
                    .HasMaxLength(21);

                entity.Property(e => e.AppProductId).HasColumnName("AppProductID");
            });

            modelBuilder.Entity<AppPackage>(entity =>
            {
                entity.ToTable("AppPackage");

                entity.Property(e => e.AppPackageId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppPackageID");

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
                entity.ToTable("AppPackageHandler");

                entity.Property(e => e.AppPackageHandlerId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppPackageHandlerID");

                entity.Property(e => e.AppPackageHandlerFitnessNotes)
                    .HasMaxLength(3000)
                    .HasColumnName("AppPAckageHandlerFitnessNotes");

                entity.Property(e => e.AppPackageHandlerStateId)
                    .HasMaxLength(14)
                    .HasColumnName("AppPackageHandlerStateID");

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

                entity.ToTable("AppPallete");

                entity.Property(e => e.AppPallateId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppPallateID");

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

                entity.ToTable("AppPriceParityCheck");

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
                entity.ToTable("AppProcess");

                entity.Property(e => e.AppProcessId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppProcessID");

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

            modelBuilder.Entity<AppProcessLanguageToken>(entity =>
            {
                entity.HasKey(e => e.LanguageTokenId)
                    .HasName("PK_LanguageTokenID");

                entity.Property(e => e.LanguageTokenId)
                    .ValueGeneratedNever()
                    .HasColumnName("LanguageTokenID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.LanguageTokenSymbol)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ReadFunctionalityOfTokenJson)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .HasColumnName("ReadFunctionalityOfTokenJSON");
            });

            modelBuilder.Entity<AppProcessLog>(entity =>
            {
                entity.ToTable("AppProcessLog");

                entity.Property(e => e.AppProcessLogId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppProcessLogID");

                entity.Property(e => e.AppProcessId)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("AppProcessID");

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

                entity.ToTable("AppProcessPipeLine");

                entity.Property(e => e.AppProcessPipleLineId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppProcessPipleLineID");

                entity.Property(e => e.AppProcessPipeLineName)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.AppProcessPipeLinkActivityId).HasColumnName("AppProcessPipeLinkActivityID");

                entity.Property(e => e.AppProcessPipeLinkedEndId).HasColumnName("AppProcessPipeLinkedEndID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppProcessRunningOnServer>(entity =>
            {
                entity.ToTable("AppProcessRunningOnServer");

                entity.Property(e => e.AppProcessRunningOnServerId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppProcessRunningOnServerID");

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
                entity.ToTable("AppProduct");

                entity.Property(e => e.AppProductId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppProductID");

                entity.Property(e => e.AppProductBarCode).HasMaxLength(3000);

                entity.Property(e => e.AppProductName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.AppProductPerUnitPrice).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppProperty>(entity =>
            {
                entity.ToTable("AppProperty");

                entity.Property(e => e.AppPropertyId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppPropertyID");

                entity.Property(e => e.AppDataTypeId).HasColumnName("AppDataTypeID");

                entity.Property(e => e.AppPropertyName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppRouteAlert>(entity =>
            {
                entity.ToTable("AppRouteAlert");

                entity.Property(e => e.AppRouteAlertId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppRouteAlertID");

                entity.Property(e => e.AppRouteAlertDesc)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.AppRouteAlertEvent)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.AppRouteChangeNotification).HasMaxLength(2000);

                entity.Property(e => e.AppRouteId)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("AppRouteID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppSaleActivity>(entity =>
            {
                entity.ToTable("AppSaleActivity");

                entity.Property(e => e.AppSaleActivityId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppSaleActivityID");

                entity.Property(e => e.AppActivityId).HasColumnName("AppActivityID");

                entity.Property(e => e.AppSaleDesc)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.SalePersonId).HasColumnName("SalePersonID");
            });

            modelBuilder.Entity<AppSeller>(entity =>
            {
                entity.ToTable("AppSeller");

                entity.HasIndex(e => e.AppSellerHashedSsc, "UQ__AppSelle__4F1170A917BDE38A")
                    .IsUnique();

                entity.Property(e => e.AppSellerId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppSellerID");

                entity.Property(e => e.AppSellerHashedSsc)
                    .HasMaxLength(200)
                    .HasColumnName("AppSellerHashedSSC");

                entity.Property(e => e.AppSellerLicenseHashedId)
                    .HasMaxLength(200)
                    .HasColumnName("AppSellerLicenseHashedID");

                entity.Property(e => e.AppSellerName)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppSellerActivity>(entity =>
            {
                entity.ToTable("AppSellerActivity");

                entity.Property(e => e.AppSellerActivityId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppSellerActivityID");

                entity.Property(e => e.AppActivityId).HasColumnName("AppActivityID");

                entity.Property(e => e.AppSellerActivityDesc).HasMaxLength(200);

                entity.Property(e => e.AppSellerId).HasColumnName("AppSellerID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppSensitiveMaterial>(entity =>
            {
                entity.HasKey(e => e.AppSensitiveMateriaId)
                    .HasName("PK_SensativeMaterialID");

                entity.ToTable("AppSensitiveMaterial");

                entity.Property(e => e.AppSensitiveMateriaId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppSensitiveMateriaID");

                entity.Property(e => e.AppBuyerHashedSsc)
                    .HasMaxLength(2000)
                    .HasColumnName("AppBuyerHashedSSC");

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
                entity.ToTable("AppShelve");

                entity.Property(e => e.AppShelveId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppShelveID");

                entity.Property(e => e.AppCategoryId).HasColumnName("AppCategoryID");

                entity.Property(e => e.AppFreightWeight).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AppShelveHeight).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.AppShelveWidth).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppSupply>(entity =>
            {
                entity.ToTable("AppSupply");

                entity.Property(e => e.AppSupplyId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppSupplyID");

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

                entity.ToTable("AppSupplyDemandChart");

                entity.Property(e => e.AppSupplyDemandId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppSupplyDemandID");

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
                entity.ToTable("AppToken");

                entity.Property(e => e.AppTokenId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppTokenID");

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

            modelBuilder.Entity<AppTokenDetail>(entity =>
            {
                entity.Property(e => e.AppTokenDetailId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppTokenDetailID");

                entity.Property(e => e.AppCompanyId)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("AppCompanyID");

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

                entity.ToTable("AppTokenGeneration");

                entity.HasIndex(e => e.AppTokenGenId, "UQ__AppToken__7DA0ED636349C82B")
                    .IsUnique();

                entity.Property(e => e.AppTokenId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppTokenID");

                entity.Property(e => e.AppTokenGenId)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .HasColumnName("AppTokenGenID");

                entity.Property(e => e.AppTokenGenOid)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .HasColumnName("AppTokenGenOID");

                entity.Property(e => e.AppUserId).HasColumnName("AppUserID");

                entity.Property(e => e.ClientNameDesc)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppTray>(entity =>
            {
                entity.ToTable("AppTray");

                entity.Property(e => e.AppTrayId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppTrayID");

                entity.Property(e => e.AppTrayName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.AppTraySizeHeight).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AppTraySizeWidth).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppTruck>(entity =>
            {
                entity.ToTable("AppTruck");

                entity.Property(e => e.AppTruckId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppTruckID");

                entity.Property(e => e.AppTruckColorModelDecs)
                    .IsRequired()
                    .HasMaxLength(3000);

                entity.Property(e => e.AppTruckVehicleIdnVin)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("AppTruckVehicleIDN_VIN");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppTruckRoute>(entity =>
            {
                entity.ToTable("AppTruckRoute");

                entity.Property(e => e.AppTruckRouteId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppTruckRouteID");

                entity.Property(e => e.AppTrouteDestinationNode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("AppTRouteDestinationNode");

                entity.Property(e => e.AppTrouteManualIntersectionPointA)
                    .IsRequired()
                    .HasMaxLength(300)
                    .HasColumnName("AppTRouteManualIntersectionPointA");

                entity.Property(e => e.AppTrouteManualIntersectionPointB)
                    .IsRequired()
                    .HasMaxLength(300)
                    .HasColumnName("AppTRouteManualIntersectionPointB");

                entity.Property(e => e.AppTrouteManualIntersectionPointC)
                    .IsRequired()
                    .HasMaxLength(300)
                    .HasColumnName("AppTRouteManualIntersectionPointC");

                entity.Property(e => e.AppTrouteManualIntersectionPointD)
                    .IsRequired()
                    .HasMaxLength(300)
                    .HasColumnName("AppTRouteManualIntersectionPointD");

                entity.Property(e => e.AppTrouteSourceNode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("AppTRouteSourceNode");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppTruckRouteAssigned>(entity =>
            {
                entity.ToTable("AppTruckRouteAssigned");

                entity.Property(e => e.AppTruckRouteAssignedId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppTruckRouteAssignedID");

                entity.Property(e => e.AppTrouteDestinationNode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("AppTRouteDestinationNode");

                entity.Property(e => e.AppTrouteSourceNode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("AppTRouteSourceNode");

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
                    .ValueGeneratedNever()
                    .HasColumnName("AppUIDataInjectionID");

                entity.Property(e => e.AppUitemplateId).HasColumnName("AppUITemplateID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DataDependencyFileJson)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .HasColumnName("DataDependencyFileJSON");
            });

            modelBuilder.Entity<AppUitemplate>(entity =>
            {
                entity.ToTable("AppUITemplate");

                entity.Property(e => e.AppUitemplateId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppUITemplateID");

                entity.Property(e => e.AppUitemplateDesc)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .HasColumnName("AppUITemplateDesc");

                entity.Property(e => e.AppUitemplateName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("AppUITemplateName");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppUitemplateDatum>(entity =>
            {
                entity.HasKey(e => e.AppUitemplateDataId)
                    .HasName("PK_AppUITemplateDataID");

                entity.ToTable("AppUITemplateData");

                entity.Property(e => e.AppUitemplateDataId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppUITemplateDataID");

                entity.Property(e => e.AppUitemplateData)
                    .IsRequired()
                    .HasMaxLength(3000)
                    .HasColumnName("AppUITemplateData");

                entity.Property(e => e.AppUitemplateMetaData)
                    .IsRequired()
                    .HasColumnType("xml")
                    .HasColumnName("AppUITemplateMetaData");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppUser>(entity =>
            {
                entity.ToTable("AppUser");

                entity.Property(e => e.AppUserId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppUserID");

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

            modelBuilder.Entity<AppUserActivityDetail>(entity =>
            {
                entity.HasKey(e => e.AppUserActivityDetailsId)
                    .HasName("PK_AppUserActivityDetailsID");

                entity.Property(e => e.AppUserActivityDetailsId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppUserActivityDetailsID");

                entity.Property(e => e.AppUserActivityId).HasColumnName("AppUserActivityID");

                entity.Property(e => e.AppUserActivityInputId)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .HasColumnName("AppUserActivityInputID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppUserActivityError>(entity =>
            {
                entity.Property(e => e.AppUserActivityErrorId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppUserActivityErrorID");

                entity.Property(e => e.AppUserActivityErrorDesc)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.AppUserActivityId)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("AppUserActivityID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppUserActivityExecutedTime>(entity =>
            {
                entity.ToTable("AppUserActivityExecutedTime");

                entity.Property(e => e.AppUserActivityExecutedTimeId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppUserActivityExecutedTimeID");

                entity.Property(e => e.ActivityStoppedOrInterrupted).HasColumnType("datetime");

                entity.Property(e => e.AppUserActivityEndDate).HasColumnType("datetime");

                entity.Property(e => e.AppUserActivityId)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("AppUserActivityID");

                entity.Property(e => e.AppUserActivityStartDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppUserActivityFrame>(entity =>
            {
                entity.ToTable("AppUserActivityFrame");

                entity.Property(e => e.AppUserActivityFrameId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppUserActivityFrameID");

                entity.Property(e => e.AppUserActivityFrameEndDate).HasColumnType("datetime");

                entity.Property(e => e.AppUserActivityFrameStartDate).HasColumnType("datetime");

                entity.Property(e => e.AppUserActivityId)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("AppUserActivityID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppUserActivityInput>(entity =>
            {
                entity.ToTable("AppUserActivityInput");

                entity.Property(e => e.AppUserActivityInputId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppUserActivityInputID");

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
                entity.ToTable("AppUserRole");

                entity.Property(e => e.AppUserRoleId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppUserRoleID");

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

            modelBuilder.Entity<AppUserSesion>(entity =>
            {
                entity.HasKey(e => e.AppSessionId)
                    .HasName("PK_AppSessionID");

                entity.ToTable("AppUserSesion");

                entity.Property(e => e.AppSessionId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppSessionID");

                entity.Property(e => e.AppClientUserIp)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("AppClientUserIP");

                entity.Property(e => e.AppSessionName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppUserSessionCrossRefVar>(entity =>
            {
                entity.HasKey(e => e.AppSessionRefVarId)
                    .HasName("PK_AppSessionRefVarID");

                entity.ToTable("AppUserSessionCrossRefVar");

                entity.Property(e => e.AppSessionRefVarId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppSessionRefVarID");

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
                entity.ToTable("AppWareHouse");

                entity.Property(e => e.AppWareHouseId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppWareHouseID");

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
                entity.ToTable("AppWareHouseNode");

                entity.Property(e => e.AppWareHouseNodeId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppWareHouseNodeID");

                entity.Property(e => e.AppWareHouseNodeName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppWareHouseVendor>(entity =>
            {
                entity.ToTable("AppWareHouseVendor");

                entity.Property(e => e.AppWareHouseVendorId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppWareHouseVendorID");

                entity.Property(e => e.AppWareHouseMaterialExpert)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.AppWareHouseVendorName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Appcart>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("APPCART");

                entity.Property(e => e.AppOrderdetailsId).HasColumnName("APP_ORDERDETAILS_ID");

                entity.Property(e => e.Appcartdesc)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("APPCARTDESC");

                entity.Property(e => e.Appcartid).HasColumnName("APPCARTID");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDDATE");

                entity.Property(e => e.PaymentHistoryId).HasColumnName("PaymentHistory_ID");
            });

            modelBuilder.Entity<ApplicationContext>(entity =>
            {
                entity.ToTable("ApplicationContext");

                entity.Property(e => e.ApplicationContextId)
                    .ValueGeneratedNever()
                    .HasColumnName("ApplicationContextID");

                entity.Property(e => e.AppClientId)
                    .HasMaxLength(2000)
                    .HasColumnName("AppClientID");

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

                entity.ToTable("ApplicationModel");

                entity.Property(e => e.AppId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppID");

                entity.Property(e => e.AppModelName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.AppServerIphashed)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("AppServerIPHashed");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Applocation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("APPLOCATION");

                entity.Property(e => e.Appgeolocation)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("APPGEOLOCATION");

                entity.Property(e => e.Applocationaddress)
                    .IsRequired()
                    .HasMaxLength(400)
                    .HasColumnName("APPLOCATIONADDRESS");

                entity.Property(e => e.Applocationcity)
                    .IsRequired()
                    .HasMaxLength(400)
                    .HasColumnName("APPLOCATIONCITY");

                entity.Property(e => e.Applocationcountrycode)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("APPLOCATIONCOUNTRYCODE");

                entity.Property(e => e.Applocationid).HasColumnName("APPLOCATIONID");

                entity.Property(e => e.Applocationstatecode)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("APPLOCATIONSTATECODE");

                entity.Property(e => e.Createdby)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDDATE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
