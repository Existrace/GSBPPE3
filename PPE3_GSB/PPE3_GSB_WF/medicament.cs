//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PPE3_GSB_WF
{
    using System;
    using System.Collections.Generic;
    
    public partial class medicament
    {
        public medicament()
        {
            this.constituers = new HashSet<constituer>();
            this.offrirs = new HashSet<offrir>();
            this.prescrires = new HashSet<prescrire>();
            this.presentations = new HashSet<presentation>();
            this.medicament1 = new HashSet<medicament>();
            this.medicaments = new HashSet<medicament>();
            this.rapport_visite = new HashSet<rapport_visite>();
        }
    
        public string MED_DEPOTLEGAL { get; set; }
        public string MED_NOMCOMMERCIAL { get; set; }
        public string FAM_CODE { get; set; }
        public string MED_COMPOSITION { get; set; }
        public string MED_EFFETS { get; set; }
        public string MED_CONTREINDIC { get; set; }
    
        public virtual ICollection<constituer> constituers { get; set; }
        public virtual famille famille { get; set; }
        public virtual ICollection<offrir> offrirs { get; set; }
        public virtual ICollection<prescrire> prescrires { get; set; }
        public virtual ICollection<presentation> presentations { get; set; }
        public virtual ICollection<medicament> medicament1 { get; set; }
        public virtual ICollection<medicament> medicaments { get; set; }
        public virtual ICollection<rapport_visite> rapport_visite { get; set; }
    }
}
