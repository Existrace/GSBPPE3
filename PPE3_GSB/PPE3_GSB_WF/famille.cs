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
    
    public partial class famille
    {
        public famille()
        {
            this.medicaments = new HashSet<medicament>();
        }
    
        public string FAM_CODE { get; set; }
        public string FAM_LIBELLE { get; set; }
    
        public virtual ICollection<medicament> medicaments { get; set; }
    }
}
