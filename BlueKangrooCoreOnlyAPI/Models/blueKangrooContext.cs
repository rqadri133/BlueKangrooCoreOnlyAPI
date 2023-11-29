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
        public virtual DbSet<AppCombinationPackage> AppCombinationPackages { get; set; }
        public virtual DbSet<AppCompany> AppCompanies { get; set; }
        public virtual DbSet<AppCrossRefProcess> AppCrossRefProcesses { get; set; }
        public virtual DbSet<AppDataType> AppDataTypes { get; set; }
        public virtual DbSet<AppDemand> AppDemands { get; set; }
        public virtual DbSet<AppDispatch> AppDispatches { get; set; }
        public virtual DbSet<AppDispatchAssigned> AppDispatchAssigneds { get; set; }
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
        public virtual DbSet<AppItemCombination> AppItemCombinations { get; set; }
        public virtual DbSet<AppJsonfile> AppJsonfiles { get; set; }
        public virtual DbSet<AppKey> AppKeys { get; set; }
        public virtual DbSet<AppMetalCombinationAlloy> AppMetalCombinationAlloys { get; set; }
        public virtual DbSet<AppNotification> AppNotifications { get; set; }
        public virtual DbSet<AppPackage> AppPackages { get; set; }
        public virtual DbSet<AppPackageHandler> AppPackageHandlers { get; set; }
        public virtual DbSet<AppPackageHanlder> AppPackageHanlders { get; set; }
        public virtual DbSet<AppPallete> AppPalletes { get; set; }
        public virtual DbSet<AppPriceParityCheck> AppPriceParityChecks { get; set; }
        public virtual DbSet<AppProcess> AppProcesses { get; set; }
        public virtual DbSet<AppProcessLanguageToken> AppProcessLanguageTokens { get; set; }
        public virtual DbSet<AppProcessLog> AppProcessLogs { get; set; }
        public virtual DbSet<AppProcessPipeLine> AppProcessPipeLines { get; set; }
        public virtual DbSet<AppProcessRunningOnServer> AppProcessRunningOnServers { get; set; }
        public virtual DbSet<AppProduct> AppProducts { get; set; }
        public virtual DbSet<AppProperty> AppProperties { get; set; }
        public virtual DbSet<AppRecipient> AppRecipients { get; set; }
        public virtual DbSet<AppRouteAlert> AppRouteAlerts { get; set; }
        public virtual DbSet<AppSaleActivity> AppSaleActivities { get; set; }
        public virtual DbSet<AppSeller> AppSellers { get; set; }
        public virtual DbSet<AppSellerActivity> AppSellerActivities { get; set; }
        public virtual DbSet<AppSender> AppSenders { get; set; }
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
        public virtual DbSet<ApplicationContext> ApplicationContexts { get; set; }
        public virtual DbSet<ApplicationModel> ApplicationModels { get; set; }
        public virtual DbSet<DispatherLink> DispatherLinks { get; set; }
        public virtual DbSet<NotificationMessageNode> NotificationMessageNodes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=tcp:blueserver.database.windows.net;Database=blueKangroo;user id=sqadri166;PWD=Astaghees@#^*166;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AppActivity>(entity =>
            {
                entity.ToTable("AppActivity");

                entity.HasIndex(e => new { e.AppProjectId, e.AppActivityName }, "UQ__AppActiv__56AE0C02010472EB")
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

                entity.HasIndex(e => e.AppBuyerHashedSsc, "UQ__AppBuyer__AD5E7D9CDB59963D")
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

            modelBuilder.Entity<AppCombinationPackage>(entity =>
            {
                entity.ToTable("AppCombinationPackage");

                entity.Property(e => e.AppCombinationPackageId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppCombinationPackageID");

                entity.Property(e => e.AppCombinationPackageDescription)
                    .IsRequired()
                    .HasMaxLength(1000);

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
                entity.ToTable("AppDispatch");

                entity.Property(e => e.AppDispatchId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppDispatchID");

                entity.Property(e => e.AppDispatchNameDecs)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.AppRecipientId).HasColumnName("AppRecipientID");

                entity.Property(e => e.AppSenderId).HasColumnName("AppSenderID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ItemCombinationJsonNvarcharMaxNotNullCreatedBy).HasColumnName("ItemCombinationJSON  NVARCHAR(MAX) NOT NULL,\r\n	[CreatedBy");
            });

            modelBuilder.Entity<AppDispatchAssigned>(entity =>
            {
                entity.ToTable("AppDispatchAssigned");

                entity.Property(e => e.AppDispatchAssignedId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppDispatchAssignedID");

                entity.Property(e => e.AppDispatchRefId).HasColumnName("AppDispatchRefID");

                entity.Property(e => e.AppProductId).HasColumnName("AppProductID");

                entity.Property(e => e.AppRecipientId).HasColumnName("AppRecipientID");

                entity.Property(e => e.AppSenderId).HasColumnName("AppSenderID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
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
                    .HasName("PK_AppErrorCodeID");

                entity.ToTable("AppError");

                entity.Property(e => e.AppErrorCodeId).ValueGeneratedNever();

                entity.Property(e => e.AppErrorDescription)
                    .IsRequired()
                    .HasMaxLength(100);

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

            modelBuilder.Entity<AppItemCombination>(entity =>
            {
                entity.ToTable("AppItemCombination");

                entity.Property(e => e.AppItemCombinationId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppItemCombinationID");

                entity.Property(e => e.AppItemCombinationPackageId).HasColumnName("AppItemCombinationPackageID");

                entity.Property(e => e.AppProductId).HasColumnName("AppProductID");

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

                entity.HasIndex(e => e.AppClientPhone, "UQ__AppKey__43F371AA1B31A097")
                    .IsUnique();

                entity.HasIndex(e => e.AppClientEmailId, "UQ__AppKey__6FC0E5D4A5161E93")
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

            modelBuilder.Entity<AppNotification>(entity =>
            {
                entity.ToTable("AppNotification");

                entity.HasIndex(e => e.AppNotificationSendNodeId, "UQ__AppNotif__901354EA28AA02EC")
                    .IsUnique();

                entity.Property(e => e.AppNotificationId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppNotificationID");

                entity.Property(e => e.AppNotificationMessageJson)
                    .HasMaxLength(2000)
                    .HasColumnName("AppNotificationMessageJSON");

                entity.Property(e => e.AppNotificationName)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.AppNotificationSendNodeId).HasColumnName("AppNotificationSendNodeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
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
                entity.HasKey(e => e.PackageId)
                    .HasName("PK_PackageHandlerID");

                entity.ToTable("AppPackageHandler");

                entity.Property(e => e.PackageId)
                    .ValueGeneratedNever()
                    .HasColumnName("PackageID");

                entity.Property(e => e.BoxHeight)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.BoxWidth)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DepthZindex)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("depthZIndex");

                entity.Property(e => e.MaxPoundsOccupancy).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PackageDescription)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.PackageName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.PackageTrackerUpdateInfo)
                    .IsRequired()
                    .HasMaxLength(2000);
            });

            modelBuilder.Entity<AppPackageHanlder>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AppPackageHanlder");

                entity.Property(e => e.BoxHeight)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.BoxWidth)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DepthZindex)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("depthZIndex");

                entity.Property(e => e.MaxPoundsOccupancy).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PackageDescription)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.PackageId).HasColumnName("PackageID");

                entity.Property(e => e.PackageName)
                    .IsRequired()
                    .HasMaxLength(200);
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

            modelBuilder.Entity<AppRecipient>(entity =>
            {
                entity.ToTable("AppRecipient");

                entity.Property(e => e.AppRecipientId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppRecipientID");

                entity.Property(e => e.AppRecipientAddress)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.AppRecipientCity)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.AppRecipientCountryCode)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.AppRecipientName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.AppRecipientStateProvinceCode)
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

                entity.HasIndex(e => e.AppSellerHashedSsc, "UQ__AppSelle__4F1170A95B52C94C")
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

            modelBuilder.Entity<AppSender>(entity =>
            {
                entity.ToTable("AppSender");

                entity.Property(e => e.AppSenderId)
                    .ValueGeneratedNever()
                    .HasColumnName("AppSenderID");

                entity.Property(e => e.AppSenderCity)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.AppSenderContactPhone)
                    .IsRequired()
                    .HasMaxLength(17);

                entity.Property(e => e.AppSenderCountry)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.AppSenderName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.AppSenderStreetAddress)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.AppSenderZipCode)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.SenderInstructionsNotes)
                    .IsRequired()
                    .HasMaxLength(2000);
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

                entity.HasIndex(e => e.AppTokenGenId, "UQ__AppToken__7DA0ED6397930F51")
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

            modelBuilder.Entity<DispatherLink>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DispatherLink");

                entity.Property(e => e.EdgeIdF85c8b902bd64e63b0c0b332d18142fc)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("$edge_id_F85C8B902BD64E63B0C0B332D18142FC");

                entity.Property(e => e.FromIdD846d9d2c5a24180bc115110fa4b35a8)
                    .HasMaxLength(1000)
                    .HasColumnName("$from_id_D846D9D2C5A24180BC115110FA4B35A8");

                entity.Property(e => e.NetworkTipCalMicrosecs)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("networkTipCalMicrosecs");

                entity.Property(e => e.ToId5e57849cb134449382604812b9c111c6)
                    .HasMaxLength(1000)
                    .HasColumnName("$to_id_5E57849CB134449382604812B9C111C6");
            });

            modelBuilder.Entity<NotificationMessageNode>(entity =>
            {
                entity.ToTable("NotificationMessageNode");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.EmailAddress).HasMaxLength(200);

                entity.Property(e => e.NodeIdCee2728acb144e4aa5e20067929a8a1f)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("$node_id_CEE2728ACB144E4AA5E20067929A8A1F");

                entity.Property(e => e.NotificationNodeName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NotificationUserId).HasColumnName("NotificationUserID");

                entity.Property(e => e.PhoneNumber).HasMaxLength(33);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
