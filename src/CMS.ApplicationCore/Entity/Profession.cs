using System.Collections.Generic;

namespace CMS.ApplicationCore.Entity
{
    public class Profession
    {
        public int ProfessionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public ICollection<ProfessionClient> ProfessionsClients { get; set; }
    }
}