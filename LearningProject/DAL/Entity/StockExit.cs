//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LearningProject.DAL.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class StockExit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StockExit()
        {
            this.StockExitDetails = new HashSet<StockExitDetail>();
        }
    
        public long id { get; set; }
        public System.DateTime exitDate { get; set; }
        public decimal totalAmount { get; set; }
        public string destination { get; set; }
        public Nullable<long> userSignId { get; set; }
        public string notes { get; set; }
        public Nullable<System.DateTime> createdAt { get; set; }
        public Nullable<System.DateTime> updatedAt { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockExitDetail> StockExitDetails { get; set; }
        public virtual User User { get; set; }
    }
}