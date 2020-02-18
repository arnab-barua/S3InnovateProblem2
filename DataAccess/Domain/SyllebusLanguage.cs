namespace DataAccess.Domain
{
    public class SyllebusLanguage
    {
        public int SyllebusId { get; set; }
        public int LanguageId { get; set; }

        public Syllebus Syllebus { get; set; }
        public Language Language { get; set; }
    }
}