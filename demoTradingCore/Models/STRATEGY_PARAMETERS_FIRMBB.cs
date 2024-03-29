//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace demoTradingCore.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class STRATEGY_PARAMETERS_FIRMBB
    {
        public int StrategyParamID { get; set; }
        public string Symbol { get; set; }
        public string LayerName { get; set; }
        public decimal PositionSize { get; set; }
        public decimal MaximumExposure { get; set; }
        public decimal LookUpBookForSize { get; set; }
        public decimal PipsMarkupBid { get; set; }
        public decimal PipsMarkupAsk { get; set; }
        public decimal MinPipsDiffToUpdatePrice { get; set; }
        public decimal MinSpread { get; set; }
        public decimal PipsSlippage { get; set; }
        public bool AggressingToHedge { get; set; }
        public decimal PipsSlippageToHedge { get; set; }
        public decimal PipsHedgeTakeProf { get; set; }
        public decimal PipsHedgeStopLoss { get; set; }
        public decimal PipsHedgeTrailing { get; set; }
        public int TickSample { get; set; }
        public int BollingerPeriod { get; set; }
        public decimal BollingerStdDev { get; set; }
    }
}
