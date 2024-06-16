namespace CountryLibrary.Models.Response
{
    public class CountryCallBackReponse
    {
        public Name name { get; set; }
        public List<string> capital { get; set; }
        public List<string> timezones { get; set; }
        public string region { get; set; }
        public Flags flags { get; set; }
        public string cca2 { get; set; }
        public IDD idd { get; set; }
    }

    public class Name
    {
        public string common { get; set; }
        public string official { get; set; }
        public Dictionary<string, Dictionary<string, string>> nativeName { get; set; }
    }

    public class IDD
    {
        public string root { get; set; }
        public List<string> suffixes { get; set; }
    }
    public class Flags
    {
        public string png { get; set; }
        public string svg { get; set; }
        public string alt { get; set; }
    }
}
