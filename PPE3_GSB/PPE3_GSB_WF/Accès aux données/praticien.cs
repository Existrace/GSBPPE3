//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PPE3_GSB_WF.Accès_aux_données
{
    using System;
    using System.Collections.Generic;
    
    public partial class praticien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public praticien()
        {
            this.inviters = new HashSet<inviter>();
            this.posseders = new HashSet<posseder>();
            this.rapport_visite = new HashSet<rapport_visite>();
            this.rapport_visite1 = new HashSet<rapport_visite>();
        }
    
        public int PRA_NUM { get; set; }
        public string PRA_NOM { get; set; }
        public string PRA_PRENOM { get; set; }
        public string PRA_ADRESSE { get; set; }
        public string PRA_CP { get; set; }
        public string PRA_VILLE { get; set; }
        public Nullable<double> PRA_COEFNOTORIETE { get; set; }
        public Nullable<double> PRA_COEFCONFIANCE { get; set; }
        public string TYP_CODE { get; set; }
        public string REG_CODE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<inviter> inviters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<posseder> posseders { get; set; }
        public virtual type_praticien type_praticien { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rapport_visite> rapport_visite { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rapport_visite> rapport_visite1 { get; set; }
        public virtual region region { get; set; }
    }
}
