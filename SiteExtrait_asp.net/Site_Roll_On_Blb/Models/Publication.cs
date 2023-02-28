//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Site_Roll_On_Blb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Publication
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Publication()
        {
            this.PublicationImage = new HashSet<PublicationImage>();
        }
    
        public int idPublication { get; set; }
        public int idTypePublication { get; set; }
        public System.DateTime datePostPublication { get; set; }
        public Nullable<System.DateTime> datePrevisionPublication { get; set; }
        public string titrePublication { get; set; }
        public string sousTitrePublication { get; set; }
        public string souscontenuPublication { get; set; }
        public string contenuPublication { get; set; }
        public string urlPublication { get; set; }
        public string url1Publication { get; set; }
        public string url2Publication { get; set; }
        public string url3Publication { get; set; }
        public string url4Publication { get; set; }
        public string url5Publication { get; set; }
        public int idStatut { get; set; }
        public byte visiblePublication { get; set; }
        public Nullable<int> idUtilisateur { get; set; }
        public Nullable<int> idParticipation { get; set; }
    
        public virtual Participation Participation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PublicationImage> PublicationImage { get; set; }
        public virtual Statut Statut { get; set; }
        public virtual TypePublication TypePublication { get; set; }
        public virtual Utilisateur Utilisateur { get; set; }
    }
}