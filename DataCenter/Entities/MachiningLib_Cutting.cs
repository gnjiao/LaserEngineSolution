//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataCenter.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class MachiningLib_Cutting
    {
        public string Id { get; set; }
        public short ENO { get; set; }
        public string MachiningType { get; set; }
        public string MaterialType { get; set; }
        public double MaterialThickness { get; set; }
        public double FocalDistance { get; set; }
        public double FocalPosition { get; set; }
        public string CutterType { get; set; }
        public double CutterDiameter { get; set; }
        public double Cutting_Feed { get; set; }
        public short Cutting_Power { get; set; }
        public short Cutting_Freq { get; set; }
        public short Cutting_Duty { get; set; }
        public double Cutting_G_Press { get; set; }
        public short Cutting_G_Kind { get; set; }
        public double Cutting_G_Ready_T { get; set; }
        public double Cutting_Displace { get; set; }
        public double Cutting_Supple { get; set; }
        public short Cutting_Edge_Slt { get; set; }
        public short Cutting_Appr_Slt { get; set; }
        public short Cutting_Pwr_Ctrl { get; set; }
        public double Cutting_Displace_2 { get; set; }
        public string Cutting_Gap_Axis { get; set; }
        public string Cutting_Feed_Dec { get; set; }
        public string Cutting_Supple_Dec { get; set; }
        public string Cutting_Dsp2_Dec { get; set; }
        public string Cutting_Reverse_Info_1 { get; set; }
        public string Cutting_Reserve_Info_2 { get; set; }
        public string Cutting_Reserve_Info_3 { get; set; }
        public Nullable<double> BEAMSPOT { get; set; }
        public Nullable<double> LIFTDIST { get; set; }
    }
}
