namespace DemoLibrary
{
    [AttributeUsage(AttributeTargets.All)]
    public class DeveloperInfoAttribute : Attribute
    {
        public string DeveloperName { get; set; }
        public string DeveloperEmail { get; set; }

        public DeveloperInfoAttribute(string developerName, string developerEmail)
        {
            DeveloperName = developerName;
            DeveloperEmail = developerEmail;
        }
    }
}