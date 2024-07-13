using System;
using System.Collections.Generic;

#nullable disable

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppInstruementation
    {
        public Guid AppInstruementationId { get; set; }
        public Guid AppInstrumentName { get; set; }
        public Guid AppInstrumentMetalCombinationsId { get; set; }
        public decimal? AppErrorPrecesionRate { get; set; }
        public decimal? AppAcuracyPrecesionRate { get; set; }
        public Guid AppInstrumentTypeId { get; set; }
        public decimal AppInstrumentDimensionsCalcAfactor { get; set; }
        public decimal AppInstrumentDimensionsCalcBfactor { get; set; }
        public decimal AppInstrumentDimensionsCalcCfactor { get; set; }
        public decimal AppInstrumentDimensionsCalcDfactor { get; set; }
        public decimal AppInstrumentDimensionsCalcEfactor { get; set; }
        public decimal AppInsruementFactorVal { get; set; }
        public decimal AppInstrumentMetalCorrosionRate { get; set; }
        public decimal AppInstrumentChemicalResistanceRate { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
