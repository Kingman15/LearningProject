using System;

namespace LearningProject.DAL.Entity
{
    public partial class StockEntryDetail
    {
        public DateTime EntryDate => this.StockEntry.entryDate;
        public decimal? CurrentTotalPrice => this.unitPrice * this.currentQuantity;
    }
}
