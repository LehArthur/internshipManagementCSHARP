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
    
    public partial class school
    {
        public school()
        {
            this.@event = new HashSet<@event>();
            this.person = new HashSet<person>();
        }
    
        public long id { get; set; }
        public long id_category { get; set; }
        public string name { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string zipCode { get; set; }
        public string town { get; set; }
        public string telephone { get; set; }
        public string mail { get; set; }
    
        public virtual category category { get; set; }
        public virtual ICollection<@event> @event { get; set; }
        public virtual ICollection<person> person { get; set; }
    }
}
