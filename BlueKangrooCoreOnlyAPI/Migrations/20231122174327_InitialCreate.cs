using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlueKangrooCoreOnlyAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppActivity",
                columns: table => new
                {
                    AppActivityID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppActivityName = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    AppActivityStartDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    AppProjectID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppActivityEndDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppActivity", x => x.AppActivityID);
                });

            migrationBuilder.CreateTable(
                name: "AppBuyer",
                columns: table => new
                {
                    AppBuyerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppBuyerName = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    AppBuyerLicenseHashedID = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    AppBuyerHashedSSC = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppBuyer", x => x.AppBuyerID);
                });

            migrationBuilder.CreateTable(
                name: "AppBuyerActivity",
                columns: table => new
                {
                    AppBuyerActivityID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppBuyerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppActivityID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppBuyerActivityDesc = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppBuyerActivity", x => x.AppBuyerActivityID);
                });

            migrationBuilder.CreateTable(
                name: "AppBuyerCostSheet",
                columns: table => new
                {
                    AppBuyerCostID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppBuyerID = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    AppProductID = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    AppItemCost = table.Column<decimal>(type: "decimal(8,4)", nullable: true),
                    AppDutyIDApplied = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppShipmentCost = table.Column<decimal>(type: "decimal(8,4)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppBuyerCostID", x => x.AppBuyerCostID);
                });

            migrationBuilder.CreateTable(
                name: "AppBuyerSellerTrade",
                columns: table => new
                {
                    AppTradeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppBuyerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppUserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppSellerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppTransactionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppTradeID", x => x.AppTradeID);
                });

            migrationBuilder.CreateTable(
                name: "AppCategory",
                columns: table => new
                {
                    AppCategoryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppCategoryName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppCategory", x => x.AppCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "AppClass",
                columns: table => new
                {
                    AppClassID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppClassName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppClass", x => x.AppClassID);
                });

            migrationBuilder.CreateTable(
                name: "AppCombinationPackage",
                columns: table => new
                {
                    AppCombinationPackageID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppCombinationPackageDescription = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppCombinationPackage", x => x.AppCombinationPackageID);
                });

            migrationBuilder.CreateTable(
                name: "AppCompany",
                columns: table => new
                {
                    AppCompanyID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppCompanyOrganizationName = table.Column<string>(type: "nvarchar(600)", maxLength: 600, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppCompany", x => x.AppCompanyID);
                });

            migrationBuilder.CreateTable(
                name: "AppCrossRefPRocess",
                columns: table => new
                {
                    AppCrossRefProcessID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProcessSourceID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NextSubProcessID = table.Column<Guid>(name: "NextSubProcessID ", type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppCrossRefPRocess", x => x.AppCrossRefProcessID);
                });

            migrationBuilder.CreateTable(
                name: "AppDataType",
                columns: table => new
                {
                    AppDataTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppDataTypeName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppDataType", x => x.AppDataTypeID);
                });

            migrationBuilder.CreateTable(
                name: "AppDemand",
                columns: table => new
                {
                    AppDemandID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppDemandName = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    AppDemandPercentage = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    AppDemandFromPopulationCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    AppDemandDeprivalRate = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    AppDemandIncreaseRate = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    AppProductID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppDemand", x => x.AppDemandID);
                });

            migrationBuilder.CreateTable(
                name: "AppDispatch",
                columns: table => new
                {
                    AppDispatchID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppSenderID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppDispatchNameDecs = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AppRecipientID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemCombinationJSONNVARCHARMAXNOTNULLCreatedBy = table.Column<Guid>(name: "ItemCombinationJSON  NVARCHAR(MAX) NOT NULL,\r\n	[CreatedBy", type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppDispatch", x => x.AppDispatchID);
                });

            migrationBuilder.CreateTable(
                name: "AppDispatchAssigned",
                columns: table => new
                {
                    AppDispatchAssignedID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppDispatchRefID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppProductID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppSenderID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppRecipientID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppDispatchAssigned", x => x.AppDispatchAssignedID);
                });

            migrationBuilder.CreateTable(
                name: "AppDocumentAssigned",
                columns: table => new
                {
                    BusineesDocAssignedID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BusinessDocUserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ActivityAssignedID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessDocAssignedID", x => x.BusineesDocAssignedID);
                });

            migrationBuilder.CreateTable(
                name: "AppDocumentTransaction",
                columns: table => new
                {
                    AppDocumentTransactionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppDocumentTemplatePath = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    AppDocumentText = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: false),
                    AppDocumentAmount = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    AppDocumentSignature = table.Column<byte[]>(type: "binary(1)", fixedLength: true, maxLength: 1, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AppDoor",
                columns: table => new
                {
                    AppDoorID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppDoorName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppDoor", x => x.AppDoorID);
                });

            migrationBuilder.CreateTable(
                name: "AppDoorKey",
                columns: table => new
                {
                    AppDoorKeyID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppKeyName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AppKeyCode = table.Column<string>(type: "nvarchar(17)", maxLength: 17, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppDoorKey", x => x.AppDoorKeyID);
                });

            migrationBuilder.CreateTable(
                name: "AppDriver",
                columns: table => new
                {
                    AppDriverID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppDriverName = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    AppDriverAddress = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    AppDriverLicenseNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    AppDriverImageURLPhoto = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppDriver", x => x.AppDriverID);
                });

            migrationBuilder.CreateTable(
                name: "AppError",
                columns: table => new
                {
                    AppErrorCodeId = table.Column<int>(type: "int", nullable: false),
                    AppErrorType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AppErrorDescription = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppErrorCodeID", x => x.AppErrorCodeId);
                });

            migrationBuilder.CreateTable(
                name: "AppExport",
                columns: table => new
                {
                    AppExportID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppSellerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppBuyerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppTradeFinanceCompanyID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppDutyID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExportDescriptionNotes = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    LetterOfCreditApproved = table.Column<bool>(type: "bit", nullable: false),
                    ExportLifeCycleCostTotal = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppExport", x => x.AppExportID);
                });

            migrationBuilder.CreateTable(
                name: "AppFactor",
                columns: table => new
                {
                    AppFactorID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppFactorName = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    AppFactorValue = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    AppFactorRelatedtoID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppFactor", x => x.AppFactorID);
                });

            migrationBuilder.CreateTable(
                name: "AppFinancialInstituition",
                columns: table => new
                {
                    AppFinancialInstituitionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppFinancialInstituitionName = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    AppFHIDApproved = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AppCountryCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AppDocumentTransactionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppStateCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AppFreight",
                columns: table => new
                {
                    AppFreightID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppFreightName = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    AppFreightCarrierTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppFreightDesc = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    AppFreightWeight = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppFreight", x => x.AppFreightID);
                });

            migrationBuilder.CreateTable(
                name: "AppFreightType",
                columns: table => new
                {
                    AppFreightTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppFreightTypeName = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    AppFreightTypeDesc = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppFreightType", x => x.AppFreightTypeID);
                });

            migrationBuilder.CreateTable(
                name: "AppGroundActivity",
                columns: table => new
                {
                    AppGroundActivityID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppGroundLogisticsID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceLocation = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    DestinationLocation = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppGroundActivity", x => x.AppGroundActivityID);
                });

            migrationBuilder.CreateTable(
                name: "AppGroundLifter",
                columns: table => new
                {
                    AppForkLifterID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppForkLifterName = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    AppForkLifterColor = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    VINNumber = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    AppForkLifterMaxWeightCapacity = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppForkLifterID", x => x.AppForkLifterID);
                });

            migrationBuilder.CreateTable(
                name: "AppGroundLogistics",
                columns: table => new
                {
                    AppGroundLogisticID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppGroundLogisticsName = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    AppGroundSourceAddress = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    AppGroundLogisticsInternalOrExternal = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AppGroundLogisticsDesc = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppGroundLogistics", x => x.AppGroundLogisticID);
                });

            migrationBuilder.CreateTable(
                name: "AppGroundPlacementParkNumber",
                columns: table => new
                {
                    PlacementParkID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlacementNumberID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlacementNumberTag = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PlacementNumberHeight = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    PlacementParkSquareWidth = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    PlacementParkStatus = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppGroundPlacementParkID", x => x.PlacementParkID);
                });

            migrationBuilder.CreateTable(
                name: "AppImport",
                columns: table => new
                {
                    AppImportID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppSellerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppBuyerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppTradeFinanceCompanyID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppDutyID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImportDescriptionNotes = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    LetterOfCreditApproved = table.Column<bool>(type: "bit", nullable: false),
                    ImportLifeCycleCostTotal = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    ImportDeprecatedCostCycle = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    ImportDamagedInsuranceCost = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    ContractNonArrivalExpirationDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppImport", x => x.AppImportID);
                });

            migrationBuilder.CreateTable(
                name: "AppIndustrialRegion",
                columns: table => new
                {
                    AppIndustrialRegionD = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppIndustrialRegionName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AppIndustrialRegionState = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    AppIndustrialRegionZipCode = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: true),
                    AppIndustrialRegionCountryCode = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppIndustrialRegionD", x => x.AppIndustrialRegionD);
                });

            migrationBuilder.CreateTable(
                name: "AppIndustrialZone",
                columns: table => new
                {
                    AppIndustrialZoneID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppIndustrialZoneName = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    AppIndustrialRegionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppZonePopulation = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    AppZoneEmployeePopulation = table.Column<int>(type: "int", nullable: false),
                    AppZoneEmployerPopulation = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppIndustrialZone", x => x.AppIndustrialZoneID);
                });

            migrationBuilder.CreateTable(
                name: "AppInstruementation",
                columns: table => new
                {
                    AppInstruementationID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppInstrumentName = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppInstrumentMetalCombinationsID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppErrorPrecesionRate = table.Column<decimal>(type: "decimal(8,2)", nullable: true),
                    AppAcuracyPrecesionRate = table.Column<decimal>(type: "decimal(8,2)", nullable: true),
                    AppInstrumentTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppInstrumentDimensionsCalcAFactor = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    AppInstrumentDimensionsCalcBFactor = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    AppInstrumentDimensionsCalcCFactor = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    AppInstrumentDimensionsCalcDFactor = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    AppInstrumentDimensionsCalcEFactor = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    AppInsruementFactorVal = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    AppInstrumentMetalCorrosionRate = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    AppInstrumentChemicalResistanceRate = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppInstruementation", x => x.AppInstruementationID);
                });

            migrationBuilder.CreateTable(
                name: "AppItemCombination",
                columns: table => new
                {
                    AppItemCombinationID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppItemCombinationPackageID = table.Column<int>(type: "int", nullable: false),
                    AppProductID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppItemCombination", x => x.AppItemCombinationID);
                });

            migrationBuilder.CreateTable(
                name: "AppJSONFile",
                columns: table => new
                {
                    AppJSONFileID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppJSONFileName = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    AppJSONFileURL = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppJSONFile", x => x.AppJSONFileID);
                });

            migrationBuilder.CreateTable(
                name: "AppKey",
                columns: table => new
                {
                    AppKeyID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppKeyDesc = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    AppClientEmailID = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AppClientIPAdressAllowed = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    AppClientPhone = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AppClientCompany = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppKey", x => x.AppKeyID);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationContext",
                columns: table => new
                {
                    ApplicationContextID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicationContextName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AppClientID = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    AppClientSecretKey = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationContext", x => x.ApplicationContextID);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationModel",
                columns: table => new
                {
                    AppID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppModelName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AppServerIPHashed = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppID", x => x.AppID);
                });

            migrationBuilder.CreateTable(
                name: "AppMetalCombinationAlloy",
                columns: table => new
                {
                    AppMetalCombinationAlloyID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppMetalCombinationAlloyName = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppAtSeparatedMetalPeriodicTableID = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    MaximumHeatingAppliedTemp = table.Column<decimal>(type: "decimal(4,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppMetalCombinationAlloy", x => x.AppMetalCombinationAlloyID);
                });

            migrationBuilder.CreateTable(
                name: "AppNotification",
                columns: table => new
                {
                    AppNotificationID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppNotificationName = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    AppNotificationSendNodeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppNotificationMessageJSON = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppNotification", x => x.AppNotificationID);
                });

            migrationBuilder.CreateTable(
                name: "AppPackage",
                columns: table => new
                {
                    AppPackageID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppPakagerName = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    AppPackageWidth = table.Column<decimal>(type: "decimal(4,2)", nullable: false),
                    AppPackaheHeight = table.Column<decimal>(type: "decimal(4,2)", nullable: false),
                    AppPackageDepth = table.Column<decimal>(type: "decimal(4,2)", nullable: false),
                    IsSensativeMaterialInside = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppPackage", x => x.AppPackageID);
                });

            migrationBuilder.CreateTable(
                name: "AppPackageHandler",
                columns: table => new
                {
                    PackageID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PackageName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PackageDescription = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    PackageTrackerUpdateInfo = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    BoxWidth = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    BoxHeight = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    depthZIndex = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    MaxPoundsOccupancy = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackageHandlerID", x => x.PackageID);
                });

            migrationBuilder.CreateTable(
                name: "AppPackageHanlder",
                columns: table => new
                {
                    PackageID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PackageName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PackageDescription = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    BoxWidth = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    BoxHeight = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    depthZIndex = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    MaxPoundsOccupancy = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AppPallete",
                columns: table => new
                {
                    AppPallateID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppPallateName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AppPallateSizeHeight = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    AppPallateSizeWidth = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    AppAvailablePallets = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppPalletID", x => x.AppPallateID);
                });

            migrationBuilder.CreateTable(
                name: "AppPriceParityCheck",
                columns: table => new
                {
                    AppPriceParityCheckID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppPriceParityCheckReason = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    DeductionApplied = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    AppProductID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppSellerOne = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppSellerTwo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AppProcess",
                columns: table => new
                {
                    AppProcessID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppProcessName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AppProcessMode = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    AppProcessDesc = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppProcess", x => x.AppProcessID);
                });

            migrationBuilder.CreateTable(
                name: "AppProcessLanguageTokens",
                columns: table => new
                {
                    LanguageTokenID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LanguageTokenSymbol = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ReadFunctionalityOfTokenJSON = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageTokenID", x => x.LanguageTokenID);
                });

            migrationBuilder.CreateTable(
                name: "AppProcessLog",
                columns: table => new
                {
                    AppProcessLogID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppProcessID = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AppProcessLogInformation = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: false),
                    AppProcessLogDumpings = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastModifiedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppProcessLog", x => x.AppProcessLogID);
                });

            migrationBuilder.CreateTable(
                name: "AppProcessPipeLine",
                columns: table => new
                {
                    AppProcessPipleLineID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppProcessPipeLineName = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    AppProcessPipeLinkActivityID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppProcessPipeLinkedEndID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppProcessPipleLineID", x => x.AppProcessPipleLineID);
                });

            migrationBuilder.CreateTable(
                name: "AppProcessRunningOnServer",
                columns: table => new
                {
                    AppProcessRunningOnServerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppProcessID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppProcessRunningOnServerName = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    AppProcessRunningServerFileSystem = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastModifiedDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppProcessRunningOnServer", x => x.AppProcessRunningOnServerID);
                });

            migrationBuilder.CreateTable(
                name: "AppProduct",
                columns: table => new
                {
                    AppProductID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppProductName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AppProductPerUnitPrice = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    AppInsuredByCompany = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppProductAvailableInStocks = table.Column<int>(type: "int", nullable: false),
                    AppProductBarCode = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppProduct", x => x.AppProductID);
                });

            migrationBuilder.CreateTable(
                name: "AppProperty",
                columns: table => new
                {
                    AppPropertyID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppPropertyName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AppDataTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppProperty", x => x.AppPropertyID);
                });

            migrationBuilder.CreateTable(
                name: "AppRecipient",
                columns: table => new
                {
                    AppRecipientID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppRecipientName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AppRecipientAddress = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    AppRecipientCity = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AppRecipientStateProvinceCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AppRecipientCountryCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRecipient", x => x.AppRecipientID);
                });

            migrationBuilder.CreateTable(
                name: "AppRouteAlert",
                columns: table => new
                {
                    AppRouteAlertID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppRouteAlertDesc = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    AppRouteID = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    AppRouteAlertEvent = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    AppRouteChangeNotification = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRouteAlert", x => x.AppRouteAlertID);
                });

            migrationBuilder.CreateTable(
                name: "AppSaleActivity",
                columns: table => new
                {
                    AppSaleActivityID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppSaleDesc = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AppActivityID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SalePersonID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppSaleActivity", x => x.AppSaleActivityID);
                });

            migrationBuilder.CreateTable(
                name: "AppSeller",
                columns: table => new
                {
                    AppSellerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppSellerName = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    AppSellerLicenseHashedID = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    AppSellerHashedSSC = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppSeller", x => x.AppSellerID);
                });

            migrationBuilder.CreateTable(
                name: "AppSellerActivity",
                columns: table => new
                {
                    AppSellerActivityID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppSellerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppActivityID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppSellerActivityDesc = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppSellerActivity", x => x.AppSellerActivityID);
                });

            migrationBuilder.CreateTable(
                name: "AppSender",
                columns: table => new
                {
                    AppSenderID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppSenderName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AppSenderStreetAddress = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    AppSenderZipCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    AppSenderContactPhone = table.Column<string>(type: "nvarchar(17)", maxLength: 17, nullable: false),
                    AppSenderCity = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    AppSenderCountry = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsSenderIsCompany = table.Column<bool>(type: "bit", nullable: false),
                    SenderInstructionsNotes = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppSender", x => x.AppSenderID);
                });

            migrationBuilder.CreateTable(
                name: "AppSensitiveMaterial",
                columns: table => new
                {
                    AppSensitiveMateriaID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppSensativeMaterialName = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    AppSensativeMaterialNotesEncrypted = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    AppBuyerHashedSSC = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SensativeMaterialID", x => x.AppSensitiveMateriaID);
                });

            migrationBuilder.CreateTable(
                name: "AppShelve",
                columns: table => new
                {
                    AppShelveID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppShelveIndex = table.Column<int>(type: "int", nullable: false),
                    AppCategoryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppShelveHeight = table.Column<decimal>(type: "decimal(4,2)", nullable: false),
                    AppShelveWidth = table.Column<decimal>(type: "decimal(4,2)", nullable: false),
                    AppIsleNumber = table.Column<int>(type: "int", nullable: false),
                    AppFreightWeight = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppShelve", x => x.AppShelveID);
                });

            migrationBuilder.CreateTable(
                name: "AppSupply",
                columns: table => new
                {
                    AppSupplyID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppSupplyName = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    AppSupplyPercentage = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    AppSupplyFromIndustryCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    AppSupplyDeprivalRate = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    AppSupplyAddOnRate = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    AppProductID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppSupply", x => x.AppSupplyID);
                });

            migrationBuilder.CreateTable(
                name: "AppSupplyDemandChart",
                columns: table => new
                {
                    AppSupplyDemandID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    AppPriceExchanged = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    AppGoodsExchanged = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    AppSupplyDeprivalRate = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    AppSupplyAddOnRate = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    AppCureencyCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    AppProductID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppSupplyDemandID", x => x.AppSupplyDemandID);
                });

            migrationBuilder.CreateTable(
                name: "AppToken",
                columns: table => new
                {
                    AppTokenID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppClientName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AppNameDesc = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    AppTokenUserID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AppUserPwd = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TokenExpiredDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppToken", x => x.AppTokenID);
                });

            migrationBuilder.CreateTable(
                name: "AppTokenDetails",
                columns: table => new
                {
                    AppTokenDetailID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppTokenID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppCompanyID = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AppSecurePhoneNumber = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TokenExpiredDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppTokenDetails", x => x.AppTokenDetailID);
                });

            migrationBuilder.CreateTable(
                name: "AppTokenGeneration",
                columns: table => new
                {
                    AppTokenID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppTokenGenID = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    AppTokenGenOID = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    AppUserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClientNameDesc = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppTokenGenID", x => x.AppTokenID);
                });

            migrationBuilder.CreateTable(
                name: "AppTray",
                columns: table => new
                {
                    AppTrayID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppTrayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AppTraySizeHeight = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    AppTraySizeWidth = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    AppTrayIsleNumber = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppTray", x => x.AppTrayID);
                });

            migrationBuilder.CreateTable(
                name: "AppTruck",
                columns: table => new
                {
                    AppTruckID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppTruckVehicleIDN_VIN = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AppTruckColorModelDecs = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppTruck", x => x.AppTruckID);
                });

            migrationBuilder.CreateTable(
                name: "AppTruckRoute",
                columns: table => new
                {
                    AppTruckRouteID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppTRouteDestinationNode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    AppTRouteManualIntersectionPointA = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    AppTRouteManualIntersectionPointB = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    AppTRouteManualIntersectionPointC = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    AppTRouteManualIntersectionPointD = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    AppTRouteSourceNode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppTruckRoute", x => x.AppTruckRouteID);
                });

            migrationBuilder.CreateTable(
                name: "AppTruckRouteAssigned",
                columns: table => new
                {
                    AppTruckRouteAssignedID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppTruckID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppTruckRouteID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppTRouteDestinationNode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    AppTRouteSourceNode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppTruckRouteAssigned", x => x.AppTruckRouteAssignedID);
                });

            migrationBuilder.CreateTable(
                name: "AppUIDataDependencyInjection",
                columns: table => new
                {
                    AppUIDataInjectionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppUITemplateID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataDependencyFileJSON = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUIDataInjectionID", x => x.AppUIDataInjectionID);
                });

            migrationBuilder.CreateTable(
                name: "AppUITemplate",
                columns: table => new
                {
                    AppUITemplateID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppUITemplateName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AppUITemplateDesc = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUITemplate", x => x.AppUITemplateID);
                });

            migrationBuilder.CreateTable(
                name: "AppUITemplateData",
                columns: table => new
                {
                    AppUITemplateDataID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppUITemplateData = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: false),
                    AppUITemplateMetaData = table.Column<string>(type: "xml", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUITemplateDataID", x => x.AppUITemplateDataID);
                });

            migrationBuilder.CreateTable(
                name: "AppUser",
                columns: table => new
                {
                    AppUserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppUserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AppNameDesc = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    AppRoleID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AppUserPwd = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUser", x => x.AppUserID);
                });

            migrationBuilder.CreateTable(
                name: "AppUserActivityDetails",
                columns: table => new
                {
                    AppUserActivityDetailsID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppUserActivityID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppUserActivityInputID = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserActivityDetailsID", x => x.AppUserActivityDetailsID);
                });

            migrationBuilder.CreateTable(
                name: "AppUserActivityErrors",
                columns: table => new
                {
                    AppUserActivityErrorID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppUserActivityID = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AppUserActivityErrorDesc = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserActivityErrors", x => x.AppUserActivityErrorID);
                });

            migrationBuilder.CreateTable(
                name: "AppUserActivityExecutedTime",
                columns: table => new
                {
                    AppUserActivityExecutedTimeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppUserActivityID = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AppUserActivityStartDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    AppUserActivityEndDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ActivityStoppedOrInterrupted = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserActivityExecutedTime", x => x.AppUserActivityExecutedTimeID);
                });

            migrationBuilder.CreateTable(
                name: "AppUserActivityFrame",
                columns: table => new
                {
                    AppUserActivityFrameID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppUserActivityID = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AppUserActivityFrameStartDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    AppUserActivityFrameEndDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    AppUserActivityFrameSpeedDefined = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserActivityFrame", x => x.AppUserActivityFrameID);
                });

            migrationBuilder.CreateTable(
                name: "AppUserActivityInput",
                columns: table => new
                {
                    AppUserActivityInputID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppUserActivityInputName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AppUserActivityInputValue = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    AppUserActivityInputType = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AppUserActivityFrameSpeedDefined = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserActivityInput", x => x.AppUserActivityInputID);
                });

            migrationBuilder.CreateTable(
                name: "AppUserRole",
                columns: table => new
                {
                    AppUserRoleID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppUserRoleName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AppRoleNameDesc = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    AppRoleAssociateDesc = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CanCreate = table.Column<bool>(type: "bit", nullable: false),
                    CanView = table.Column<bool>(type: "bit", nullable: false),
                    CanEdit = table.Column<bool>(type: "bit", nullable: false),
                    CanDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserRole", x => x.AppUserRoleID);
                });

            migrationBuilder.CreateTable(
                name: "AppUserSesion",
                columns: table => new
                {
                    AppSessionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppSessionName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AppClientUserIP = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppSessionID", x => x.AppSessionID);
                });

            migrationBuilder.CreateTable(
                name: "AppUserSessionCrossRefVar",
                columns: table => new
                {
                    AppSessionRefVarID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppSessionVarName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AppSessionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppSessionVarType = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AppSessionValueUpdate = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppSessionRefVarID", x => x.AppSessionRefVarID);
                });

            migrationBuilder.CreateTable(
                name: "AppWareHouse",
                columns: table => new
                {
                    AppWareHouseID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppWareHouseName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AppWareHouseNetItemCost = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    AppWareHouseLoctaionCity = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    AppWareHosueLocationCountryCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    AppWareHouseStreetAddress = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppWareHouse", x => x.AppWareHouseID);
                });

            migrationBuilder.CreateTable(
                name: "AppWareHouseNode",
                columns: table => new
                {
                    AppWareHouseNodeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppWareHouseNodeName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AppWareHouseVendorAttached = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppWareHouseNodeCompleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppWareHouseNode", x => x.AppWareHouseNodeID);
                });

            migrationBuilder.CreateTable(
                name: "AppWareHouseVendor",
                columns: table => new
                {
                    AppWareHouseVendorID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppWareHouseVendorName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AppWareHouseVendorDesc = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppWareHouseMaterialExpert = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppWareHouseVendor", x => x.AppWareHouseVendorID);
                });

            migrationBuilder.CreateTable(
                name: "DispatherLink",
                columns: table => new
                {
                    edge_id_F85C8B902BD64E63B0C0B332D18142FC = table.Column<string>(name: "$edge_id_F85C8B902BD64E63B0C0B332D18142FC", type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    from_id_D846D9D2C5A24180BC115110FA4B35A8 = table.Column<string>(name: "$from_id_D846D9D2C5A24180BC115110FA4B35A8", type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    to_id_5E57849CB134449382604812B9C111C6 = table.Column<string>(name: "$to_id_5E57849CB134449382604812B9C111C6", type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    networkTipCalMicrosecs = table.Column<decimal>(type: "decimal(5,2)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "NotificationMessageNode",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    node_id_CEE2728ACB144E4AA5E20067929A8A1F = table.Column<string>(name: "$node_id_CEE2728ACB144E4AA5E20067929A8A1F", type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    NotificationNodeName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    NotificationNodeActive = table.Column<bool>(type: "bit", nullable: true),
                    NotificationUserID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(33)", maxLength: 33, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationMessageNode", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "UQ__AppActiv__56AE0C02010472EB",
                table: "AppActivity",
                columns: new[] { "AppProjectID", "AppActivityName" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__AppBuyer__AD5E7D9CDB59963D",
                table: "AppBuyer",
                column: "AppBuyerHashedSSC",
                unique: true,
                filter: "[AppBuyerHashedSSC] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UQ__AppKey__43F371AA1B31A097",
                table: "AppKey",
                column: "AppClientPhone",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__AppKey__6FC0E5D4A5161E93",
                table: "AppKey",
                column: "AppClientEmailID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__AppNotif__901354EA28AA02EC",
                table: "AppNotification",
                column: "AppNotificationSendNodeID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__AppSelle__4F1170A95B52C94C",
                table: "AppSeller",
                column: "AppSellerHashedSSC",
                unique: true,
                filter: "[AppSellerHashedSSC] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UQ__AppToken__7DA0ED6397930F51",
                table: "AppTokenGeneration",
                column: "AppTokenGenID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppActivity");

            migrationBuilder.DropTable(
                name: "AppBuyer");

            migrationBuilder.DropTable(
                name: "AppBuyerActivity");

            migrationBuilder.DropTable(
                name: "AppBuyerCostSheet");

            migrationBuilder.DropTable(
                name: "AppBuyerSellerTrade");

            migrationBuilder.DropTable(
                name: "AppCategory");

            migrationBuilder.DropTable(
                name: "AppClass");

            migrationBuilder.DropTable(
                name: "AppCombinationPackage");

            migrationBuilder.DropTable(
                name: "AppCompany");

            migrationBuilder.DropTable(
                name: "AppCrossRefPRocess");

            migrationBuilder.DropTable(
                name: "AppDataType");

            migrationBuilder.DropTable(
                name: "AppDemand");

            migrationBuilder.DropTable(
                name: "AppDispatch");

            migrationBuilder.DropTable(
                name: "AppDispatchAssigned");

            migrationBuilder.DropTable(
                name: "AppDocumentAssigned");

            migrationBuilder.DropTable(
                name: "AppDocumentTransaction");

            migrationBuilder.DropTable(
                name: "AppDoor");

            migrationBuilder.DropTable(
                name: "AppDoorKey");

            migrationBuilder.DropTable(
                name: "AppDriver");

            migrationBuilder.DropTable(
                name: "AppError");

            migrationBuilder.DropTable(
                name: "AppExport");

            migrationBuilder.DropTable(
                name: "AppFactor");

            migrationBuilder.DropTable(
                name: "AppFinancialInstituition");

            migrationBuilder.DropTable(
                name: "AppFreight");

            migrationBuilder.DropTable(
                name: "AppFreightType");

            migrationBuilder.DropTable(
                name: "AppGroundActivity");

            migrationBuilder.DropTable(
                name: "AppGroundLifter");

            migrationBuilder.DropTable(
                name: "AppGroundLogistics");

            migrationBuilder.DropTable(
                name: "AppGroundPlacementParkNumber");

            migrationBuilder.DropTable(
                name: "AppImport");

            migrationBuilder.DropTable(
                name: "AppIndustrialRegion");

            migrationBuilder.DropTable(
                name: "AppIndustrialZone");

            migrationBuilder.DropTable(
                name: "AppInstruementation");

            migrationBuilder.DropTable(
                name: "AppItemCombination");

            migrationBuilder.DropTable(
                name: "AppJSONFile");

            migrationBuilder.DropTable(
                name: "AppKey");

            migrationBuilder.DropTable(
                name: "ApplicationContext");

            migrationBuilder.DropTable(
                name: "ApplicationModel");

            migrationBuilder.DropTable(
                name: "AppMetalCombinationAlloy");

            migrationBuilder.DropTable(
                name: "AppNotification");

            migrationBuilder.DropTable(
                name: "AppPackage");

            migrationBuilder.DropTable(
                name: "AppPackageHandler");

            migrationBuilder.DropTable(
                name: "AppPackageHanlder");

            migrationBuilder.DropTable(
                name: "AppPallete");

            migrationBuilder.DropTable(
                name: "AppPriceParityCheck");

            migrationBuilder.DropTable(
                name: "AppProcess");

            migrationBuilder.DropTable(
                name: "AppProcessLanguageTokens");

            migrationBuilder.DropTable(
                name: "AppProcessLog");

            migrationBuilder.DropTable(
                name: "AppProcessPipeLine");

            migrationBuilder.DropTable(
                name: "AppProcessRunningOnServer");

            migrationBuilder.DropTable(
                name: "AppProduct");

            migrationBuilder.DropTable(
                name: "AppProperty");

            migrationBuilder.DropTable(
                name: "AppRecipient");

            migrationBuilder.DropTable(
                name: "AppRouteAlert");

            migrationBuilder.DropTable(
                name: "AppSaleActivity");

            migrationBuilder.DropTable(
                name: "AppSeller");

            migrationBuilder.DropTable(
                name: "AppSellerActivity");

            migrationBuilder.DropTable(
                name: "AppSender");

            migrationBuilder.DropTable(
                name: "AppSensitiveMaterial");

            migrationBuilder.DropTable(
                name: "AppShelve");

            migrationBuilder.DropTable(
                name: "AppSupply");

            migrationBuilder.DropTable(
                name: "AppSupplyDemandChart");

            migrationBuilder.DropTable(
                name: "AppToken");

            migrationBuilder.DropTable(
                name: "AppTokenDetails");

            migrationBuilder.DropTable(
                name: "AppTokenGeneration");

            migrationBuilder.DropTable(
                name: "AppTray");

            migrationBuilder.DropTable(
                name: "AppTruck");

            migrationBuilder.DropTable(
                name: "AppTruckRoute");

            migrationBuilder.DropTable(
                name: "AppTruckRouteAssigned");

            migrationBuilder.DropTable(
                name: "AppUIDataDependencyInjection");

            migrationBuilder.DropTable(
                name: "AppUITemplate");

            migrationBuilder.DropTable(
                name: "AppUITemplateData");

            migrationBuilder.DropTable(
                name: "AppUser");

            migrationBuilder.DropTable(
                name: "AppUserActivityDetails");

            migrationBuilder.DropTable(
                name: "AppUserActivityErrors");

            migrationBuilder.DropTable(
                name: "AppUserActivityExecutedTime");

            migrationBuilder.DropTable(
                name: "AppUserActivityFrame");

            migrationBuilder.DropTable(
                name: "AppUserActivityInput");

            migrationBuilder.DropTable(
                name: "AppUserRole");

            migrationBuilder.DropTable(
                name: "AppUserSesion");

            migrationBuilder.DropTable(
                name: "AppUserSessionCrossRefVar");

            migrationBuilder.DropTable(
                name: "AppWareHouse");

            migrationBuilder.DropTable(
                name: "AppWareHouseNode");

            migrationBuilder.DropTable(
                name: "AppWareHouseVendor");

            migrationBuilder.DropTable(
                name: "DispatherLink");

            migrationBuilder.DropTable(
                name: "NotificationMessageNode");
        }
    }
}
