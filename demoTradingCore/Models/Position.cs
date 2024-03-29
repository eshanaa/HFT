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
    
    public partial class Position
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Position()
        {
            this.CloseExecutions = new HashSet<CloseExecution>();
            this.OpenExecutions = new HashSet<OpenExecution>();
        }
    
        public long ID { get; set; }
        public long PositionID { get; set; }
        public int AttemptsToClose { get; set; }
        public string CloseClOrdId { get; set; }
        public int CloseProviderId { get; set; }
        public Nullable<int> CloseQuoteId { get; set; }
        public Nullable<System.DateTime> CloseQuoteLocalTimeStamp { get; set; }
        public Nullable<System.DateTime> CloseQuoteServerTimeStamp { get; set; }
        public int CloseStatus { get; set; }
        public System.DateTime CloseTimeStamp { get; set; }
        public System.DateTime CreationTimeStamp { get; set; }
        public string Currency { get; set; }
        public string FreeText { get; set; }
        public Nullable<System.DateTime> FutSettDate { get; set; }
        public decimal GetCloseAvgPrice { get; set; }
        public decimal GetCloseQuantity { get; set; }
        public decimal GetOpenAvgPrice { get; set; }
        public decimal GetOpenQuantity { get; set; }
        public decimal GetPipsPnL { get; set; }
        public bool IsCloseMM { get; set; }
        public bool IsOpenMM { get; set; }
        public decimal MaxDrowdown { get; set; }
        public string OpenClOrdId { get; set; }
        public int OpenProviderId { get; set; }
        public Nullable<int> OpenQuoteId { get; set; }
        public Nullable<System.DateTime> OpenQuoteLocalTimeStamp { get; set; }
        public Nullable<System.DateTime> OpenQuoteServerTimeStamp { get; set; }
        public int OpenStatus { get; set; }
        public decimal OrderQuantity { get; set; }
        public decimal PipsTrail { get; set; }
        public int Side { get; set; }
        public decimal StopLoss { get; set; }
        public string StrategyCode { get; set; }
        public string Symbol { get; set; }
        public int SymbolDecimals { get; set; }
        public int SymbolMultiplier { get; set; }
        public decimal TakeProfit { get; set; }
        public decimal UnrealizedPnL { get; set; }
        public Nullable<decimal> OpenBestBid { get; set; }
        public Nullable<decimal> OpenBestAsk { get; set; }
        public Nullable<decimal> CloseBestBid { get; set; }
        public Nullable<decimal> CloseBestAsk { get; set; }
        public string OpenOriginPartyID { get; set; }
        public string CloseOriginPartyID { get; set; }
        public string LayerName { get; set; }
        public Nullable<System.DateTime> OpenFireSignalTimestamp { get; set; }
        public Nullable<System.DateTime> CloseFireSignalTimestamp { get; set; }
        public Nullable<decimal> PipsPnLInCurrency { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CloseExecution> CloseExecutions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OpenExecution> OpenExecutions { get; set; }
    }
}
