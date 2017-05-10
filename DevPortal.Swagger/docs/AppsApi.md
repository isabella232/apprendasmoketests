# IO.Swagger.Api.AppsApi

All URIs are relative to *https://apps.apprenda.msterling/developer*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AppsDelete**](AppsApi.md#appsdelete) | **DELETE** /api/v1/Apps/{id} | 
[**AppsDeleteBySubAlias**](AppsApi.md#appsdeletebysubalias) | **DELETE** /api/v1/Apps/{alias}/{subAlias} | 
[**AppsGet**](AppsApi.md#appsget) | **GET** /api/v1/Apps/{id} | 
[**AppsGetBySubAlias**](AppsApi.md#appsgetbysubalias) | **GET** /api/v1/Apps/{alias}/{subAlias} | 
[**AppsPost**](AppsApi.md#appspost) | **POST** /api/v1/Apps/{alias}/{subAlias} | 
[**AppsPut**](AppsApi.md#appsput) | **PUT** /api/v1/Apps/{id} | 
[**AppsPutBySubAlias**](AppsApi.md#appsputbysubalias) | **PUT** /api/v1/Apps/{alias}/{subAlias} | 


<a name="appsdelete"></a>
# **AppsDelete**
> void AppsDelete (string id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AppsDeleteExample
    {
        public void main()
        {
            
            var apiInstance = new AppsApi();
            var id = id_example;  // string | 

            try
            {
                apiInstance.AppsDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.AppsDelete: " + e.Message );
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

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appsdeletebysubalias"></a>
# **AppsDeleteBySubAlias**
> void AppsDeleteBySubAlias (string id, string alias, string subAlias)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AppsDeleteBySubAliasExample
    {
        public void main()
        {
            
            var apiInstance = new AppsApi();
            var id = id_example;  // string | 
            var alias = alias_example;  // string | 
            var subAlias = subAlias_example;  // string | 

            try
            {
                apiInstance.AppsDeleteBySubAlias(id, alias, subAlias);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.AppsDeleteBySubAlias: " + e.Message );
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

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appsget"></a>
# **AppsGet**
> InlineResponse2002 AppsGet (string id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AppsGetExample
    {
        public void main()
        {
            
            var apiInstance = new AppsApi();
            var id = id_example;  // string | 

            try
            {
                InlineResponse2002 result = apiInstance.AppsGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.AppsGet: " + e.Message );
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

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appsgetbysubalias"></a>
# **AppsGetBySubAlias**
> InlineResponse2003 AppsGetBySubAlias (string alias, string subAlias)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AppsGetBySubAliasExample
    {
        public void main()
        {
            
            var apiInstance = new AppsApi();
            var alias = alias_example;  // string | 
            var subAlias = subAlias_example;  // string | 

            try
            {
                InlineResponse2003 result = apiInstance.AppsGetBySubAlias(alias, subAlias);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.AppsGetBySubAlias: " + e.Message );
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

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appspost"></a>
# **AppsPost**
> void AppsPost (App2 app, string alias, string subAlias)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AppsPostExample
    {
        public void main()
        {
            
            var apiInstance = new AppsApi();
            var app = new App2(); // App2 | 
            var alias = alias_example;  // string | 
            var subAlias = subAlias_example;  // string | 

            try
            {
                apiInstance.AppsPost(app, alias, subAlias);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.AppsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **app** | [**App2**](App2.md)|  | 
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

<a name="appsput"></a>
# **AppsPut**
> void AppsPut (string id, App app)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AppsPutExample
    {
        public void main()
        {
            
            var apiInstance = new AppsApi();
            var id = id_example;  // string | 
            var app = new App(); // App | 

            try
            {
                apiInstance.AppsPut(id, app);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.AppsPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **app** | [**App**](App.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appsputbysubalias"></a>
# **AppsPutBySubAlias**
> void AppsPutBySubAlias (string id, App1 app, string alias, string subAlias)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AppsPutBySubAliasExample
    {
        public void main()
        {
            
            var apiInstance = new AppsApi();
            var id = id_example;  // string | 
            var app = new App1(); // App1 | 
            var alias = alias_example;  // string | 
            var subAlias = subAlias_example;  // string | 

            try
            {
                apiInstance.AppsPutBySubAlias(id, app, alias, subAlias);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.AppsPutBySubAlias: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **app** | [**App1**](App1.md)|  | 
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

