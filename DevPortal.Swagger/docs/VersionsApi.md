# IO.Swagger.Api.VersionsApi

All URIs are relative to *https://apps.apprenda.msterling/developer*

Method | HTTP request | Description
------------- | ------------- | -------------
[**VersionsDelete**](VersionsApi.md#versionsdelete) | **DELETE** /api/v1/Versions | 
[**VersionsDeleteByAlias**](VersionsApi.md#versionsdeletebyalias) | **DELETE** /api/v1/Versions/{alias}/{subAlias} | 
[**VersionsGet**](VersionsApi.md#versionsget) | **GET** /api/v1/Versions/{id} | 
[**VersionsGetAll**](VersionsApi.md#versionsgetall) | **GET** /api/v1/Versions | 
[**VersionsGetByAlias**](VersionsApi.md#versionsgetbyalias) | **GET** /api/v1/Versions/{alias}/{subAlias} | 
[**VersionsGetByIdentifier**](VersionsApi.md#versionsgetbyidentifier) | **GET** /api/v1/Versions/{alias}/{subAlias}/{identifier} | 
[**VersionsPost**](VersionsApi.md#versionspost) | **POST** /api/v1/Versions/{id} | 
[**VersionsPostById**](VersionsApi.md#versionspostbyid) | **POST** /api/v1/Versions/{alias}/{subAlias} | 
[**VersionsPostBySubAlias**](VersionsApi.md#versionspostbysubalias) | **POST** /api/v1/Versions | 
[**VersionsPut**](VersionsApi.md#versionsput) | **PUT** /api/v1/Versions | 
[**VersionsPutIntoAlias**](VersionsApi.md#versionsputintoalias) | **PUT** /api/v1/Versions/{alias}/{subAlias} | 


<a name="versionsdelete"></a>
# **VersionsDelete**
> Object VersionsDelete (string alias, string subAlias)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class VersionsDeleteExample
    {
        public void main()
        {
            
            var apiInstance = new VersionsApi();
            var alias = alias_example;  // string | 
            var subAlias = subAlias_example;  // string | 

            try
            {
                Object result = apiInstance.VersionsDelete(alias, subAlias);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VersionsApi.VersionsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **alias** | **string**|  | 
 **subAlias** | **string**|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="versionsdeletebyalias"></a>
# **VersionsDeleteByAlias**
> Object VersionsDeleteByAlias (string alias, string subAlias)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class VersionsDeleteByAliasExample
    {
        public void main()
        {
            
            var apiInstance = new VersionsApi();
            var alias = alias_example;  // string | 
            var subAlias = subAlias_example;  // string | 

            try
            {
                Object result = apiInstance.VersionsDeleteByAlias(alias, subAlias);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VersionsApi.VersionsDeleteByAlias: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **alias** | **string**|  | 
 **subAlias** | **string**|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="versionsget"></a>
# **VersionsGet**
> List<InlineResponse2002CurrentVersion> VersionsGet (string id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class VersionsGetExample
    {
        public void main()
        {
            
            var apiInstance = new VersionsApi();
            var id = id_example;  // string | 

            try
            {
                List&lt;InlineResponse2002CurrentVersion&gt; result = apiInstance.VersionsGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VersionsApi.VersionsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 

### Return type

[**List<InlineResponse2002CurrentVersion>**](InlineResponse2002CurrentVersion.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="versionsgetall"></a>
# **VersionsGetAll**
> InlineResponse20030 VersionsGetAll (string alias, string subAlias)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class VersionsGetAllExample
    {
        public void main()
        {
            
            var apiInstance = new VersionsApi();
            var alias = alias_example;  // string | 
            var subAlias = subAlias_example;  // string | 

            try
            {
                InlineResponse20030 result = apiInstance.VersionsGetAll(alias, subAlias);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VersionsApi.VersionsGetAll: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **alias** | **string**|  | 
 **subAlias** | **string**|  | 

### Return type

[**InlineResponse20030**](InlineResponse20030.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="versionsgetbyalias"></a>
# **VersionsGetByAlias**
> List<InlineResponse2002CurrentVersion> VersionsGetByAlias (string id, string alias, string subAlias)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class VersionsGetByAliasExample
    {
        public void main()
        {
            
            var apiInstance = new VersionsApi();
            var id = id_example;  // string | 
            var alias = alias_example;  // string | 
            var subAlias = subAlias_example;  // string | 

            try
            {
                List&lt;InlineResponse2002CurrentVersion&gt; result = apiInstance.VersionsGetByAlias(id, alias, subAlias);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VersionsApi.VersionsGetByAlias: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **alias** | **string**|  | 
 **subAlias** | **string**|  | 

### Return type

[**List<InlineResponse2002CurrentVersion>**](InlineResponse2002CurrentVersion.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="versionsgetbyidentifier"></a>
# **VersionsGetByIdentifier**
> InlineResponse20031 VersionsGetByIdentifier (string alias, string subAlias, string identifier)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class VersionsGetByIdentifierExample
    {
        public void main()
        {
            
            var apiInstance = new VersionsApi();
            var alias = alias_example;  // string | 
            var subAlias = subAlias_example;  // string | 
            var identifier = identifier_example;  // string | 

            try
            {
                InlineResponse20031 result = apiInstance.VersionsGetByIdentifier(alias, subAlias, identifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VersionsApi.VersionsGetByIdentifier: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **alias** | **string**|  | 
 **subAlias** | **string**|  | 
 **identifier** | **string**|  | 

### Return type

[**InlineResponse20031**](InlineResponse20031.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="versionspost"></a>
# **VersionsPost**
> void VersionsPost (string id, Version version)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class VersionsPostExample
    {
        public void main()
        {
            
            var apiInstance = new VersionsApi();
            var id = id_example;  // string | 
            var version = new Version(); // Version | 

            try
            {
                apiInstance.VersionsPost(id, version);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VersionsApi.VersionsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **version** | [**Version**](Version.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="versionspostbyid"></a>
# **VersionsPostById**
> void VersionsPostById (string id, Version3 version, string alias, string subAlias)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class VersionsPostByIdExample
    {
        public void main()
        {
            
            var apiInstance = new VersionsApi();
            var id = id_example;  // string | 
            var version = new Version3(); // Version3 | 
            var alias = alias_example;  // string | 
            var subAlias = subAlias_example;  // string | 

            try
            {
                apiInstance.VersionsPostById(id, version, alias, subAlias);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VersionsApi.VersionsPostById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **version** | [**Version3**](Version3.md)|  | 
 **alias** | **string**|  | 
 **subAlias** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="versionspostbysubalias"></a>
# **VersionsPostBySubAlias**
> void VersionsPostBySubAlias (string alias, string subAlias, bool? setMaintenanceOff)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class VersionsPostBySubAliasExample
    {
        public void main()
        {
            
            var apiInstance = new VersionsApi();
            var alias = alias_example;  // string | 
            var subAlias = subAlias_example;  // string | 
            var setMaintenanceOff = true;  // bool? | 

            try
            {
                apiInstance.VersionsPostBySubAlias(alias, subAlias, setMaintenanceOff);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VersionsApi.VersionsPostBySubAlias: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **alias** | **string**|  | 
 **subAlias** | **string**|  | 
 **setMaintenanceOff** | **bool?**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="versionsput"></a>
# **VersionsPut**
> void VersionsPut (string alias, string subAlias, Version1 version)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class VersionsPutExample
    {
        public void main()
        {
            
            var apiInstance = new VersionsApi();
            var alias = alias_example;  // string | 
            var subAlias = subAlias_example;  // string | 
            var version = new Version1(); // Version1 | 

            try
            {
                apiInstance.VersionsPut(alias, subAlias, version);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VersionsApi.VersionsPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **alias** | **string**|  | 
 **subAlias** | **string**|  | 
 **version** | [**Version1**](Version1.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="versionsputintoalias"></a>
# **VersionsPutIntoAlias**
> void VersionsPutIntoAlias (string alias, string subAlias, Version2 version)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class VersionsPutIntoAliasExample
    {
        public void main()
        {
            
            var apiInstance = new VersionsApi();
            var alias = alias_example;  // string | 
            var subAlias = subAlias_example;  // string | 
            var version = new Version2(); // Version2 | 

            try
            {
                apiInstance.VersionsPutIntoAlias(alias, subAlias, version);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VersionsApi.VersionsPutIntoAlias: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **alias** | **string**|  | 
 **subAlias** | **string**|  | 
 **version** | [**Version2**](Version2.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

