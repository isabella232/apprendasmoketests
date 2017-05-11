using System;

namespace ApprendaSmokeTestsBase.ValueItems.Implementation
{
    public class SmokeTestApplication : ISmokeTestApplication
    {
        /// <summary>
        /// The name the ApplicationRepository will use to retrieve the archive for this app
        /// </summary>
        public string SmokeTestApplicationName { get; set; }

        /// <summary>
        /// The Alias of this application on the platform
        /// </summary>
        public string AppAlias { get; set; }

        /// <summary>
        /// The ID of the application on the platform
        /// </summary>
        public Guid? ApplicationId { get; set; }

        public byte[] ArchiveContents { get; set; }
    }
}
