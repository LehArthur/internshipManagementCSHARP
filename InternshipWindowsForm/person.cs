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
    
    public partial class person
    {
        public person()
        {
            this.admin = new HashSet<admin>();
            this.journal = new HashSet<journal>();
            this.user = new HashSet<user>();
        }
    
        public long id { get; set; }
        public long id_school { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string mail { get; set; }
        public string telephone { get; set; }
    
        public virtual ICollection<admin> admin { get; set; }
        public virtual ICollection<journal> journal { get; set; }
        public virtual school school { get; set; }
        public virtual ICollection<user> user { get; set; }

        public string maNamePerson
        {
            get { return firstName + " " + lastName; }
        }
    }
}
