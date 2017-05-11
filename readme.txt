ApprendaSmokeTests and ApprendaAPIClient

This project allows users to easily and cleanly write full integration tests against a running Apprenda platform, and handles the plumbing
of constructing REST calls, deserializing returns, authentication, and other mundane tasks.

It's designed with XUnit in mind, but will also work with NUnit if desired.


Projects - 
ApprendaAPIClient:
   This is a full C# client for accessing the Apprenda platform, asyncronously.  It uses pregenerated Swagger projects to 
   get object definitions, or in cases where they don't exist it provides them.  

   In addition it also provides the ability for very detailed logging about test behavior, by injectiong a ITelemetryReportingService 
   to the client factory.  This allows a consumer to do things like sending timestamped proxy calls and tests to Splunk or Elk,
   for example.

ApprendaSmokeTestBase - 
   This provides base classes for easily construction integration/smoke tests.  Consuming assemblies should extend the 
   SmokeTestBase class, and implement the services it consumes if desired.  Otherwise simple services to run off of hardcoded
   values are provided.

DefaultApprendaSmokeTests - this test project includes integration tests to run against a platform and determine health.

    Current areas covered include:
    - App and version creation and promotion, as well as retrieval and population of sub objects (Dev Portal)
    - Health Reports remaining successful for an arbitrary amount of time (SOC)
    - Clouds in the account portal (SOC)

    Additional tests will be added to this project as time goes on to provide full coverage of the platform.


To write a new test:
   If doing so in the DefaultApprendaSmokeTests, create a new class under Tests that extends EasySmokeTest.
   In your test method, start a connection to Apprenda by calling
   using(var session = GetSession())
     This will ensure that your session is properly closed at the end of the test.

     within here, you can get a client by simply calling await session.GetClient().  This will provide many methods to interact
     with the platform.
   
  

