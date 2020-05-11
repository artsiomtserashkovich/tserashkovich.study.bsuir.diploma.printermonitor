﻿namespace PrintingMonitor.Printer.Models.Information
{
    public class FirmwareInformation
    {
        public double? FilamentDiameter { get; set; }

        public StepsPerUnitSettings StepsPerUnit { get; set; }

        public HomeOffsetSettings HomeOffset { get; set; }

        public PIDSettings PID { get; set; }
    }
}