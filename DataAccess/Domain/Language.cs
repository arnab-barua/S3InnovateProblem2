using System.Collections.Generic;

namespace DataAccess.Domain
{
    public class Language
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }



        public ICollection<SyllebusLanguage> Syllebuses { get; set; }


        public Language()
        {
            Syllebuses = new List<SyllebusLanguage>();
        }
    }
}
