//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InternshipWindowsForm
{
    using System;
    using System.Collections.Generic;
    
    public partial class category
    {
        public category()
        {
            this.category_of_company = new HashSet<category_of_company>();
            this.school = new HashSet<school>();
        }
    
        public long id { get; set; }
        public string name { get; set; }
    
        public virtual ICollection<category_of_company> category_of_company { get; set; }
        public virtual ICollection<school> school { get; set; }
    }
}
