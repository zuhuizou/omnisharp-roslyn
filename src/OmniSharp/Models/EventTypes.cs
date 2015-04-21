namespace OmniSharp.Models
{
    public static class EventTypes
    {
        public static readonly string ProjectAdded = "ProjectAdded";
        public static readonly string ProjectChanged = "ProjectChanged";
        public static readonly string ProjectRemoved = "ProjectRemoved";
        public static readonly string Error = "Error";
        public static readonly string MsBuildProjectDiagnostics = "MsBuildProjectDiagnostics";
    }
}