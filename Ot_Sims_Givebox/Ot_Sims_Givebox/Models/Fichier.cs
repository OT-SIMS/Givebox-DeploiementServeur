//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ot_Sims_Givebox.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Fichier
    {
        public int Id { get; set; }
        public Nullable<int> OffreId { get; set; }
        public int FichierTypeId { get; set; }
        public string Chemin { get; set; }
        public string Titre { get; set; }
        public string url { get; set; }
        public string contentType { get; set; }
    
        public virtual FichierType FichierType { get; set; }
    }
}
