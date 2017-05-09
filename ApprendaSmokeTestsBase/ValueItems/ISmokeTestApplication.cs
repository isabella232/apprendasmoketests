using System;

namespace ApprendaSmokeTestsBase.ValueItems
{
    public interface ISmokeTestApplication
    {
        /// <summary>
        /// The name the ApplicationRepository will use to retrieve the archive for this app
        /// </summary>
        string SmokeTestApplicationName { get; set; }

        /// <summary>
        /// The Alias of this application on the platform
        /// </summary>
        string AppAlias { get; set; }

        /// <summary>
        /// The ID of the application on the platform
        /// </summary>
        Guid? ApplicationId { get; set; }
    }
}