# IO.Swagger.Api.LogOverridesApi

All URIs are relative to *https://apps.apprenda.msterling/developer*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LogOverridesDelete**](LogOverridesApi.md#logoverridesdelete) | **DELETE** /api/v1/LogOverrides/{id} | 
[**LogOverridesDeleteById**](LogOverridesApi.md#logoverridesdeletebyid) | **DELETE** /api/v1/LogOverrides/{alias}/{subAlias} | 
[**LogOverridesGet**](LogOverridesApi.md#logoverridesget) | **GET** /api/v1/LogOverrides | 
[**LogOverridesGetById**](LogOverridesApi.md#logoverridesgetbyid) | **GET** /api/v1/LogOverrides/{id} | 
[**LogOverridesGetBySubAlias**](LogOverridesApi.md#logoverridesgetbysubalias) | **GET** /api/v1/LogOverrides/{alias}/{subAlias} | 
[**LogOverridesPost**](LogOverridesApi.md#logoverridespost) | **POST** /api/v1/LogOverrides | 
[**LogOverridesPostBySubAlias**](LogOverridesApi.md#logoverridespostbysubalias) | **POST** /api/v1/LogOverrides/{alias}/{subAlias} | 


<a name="logoverridesdelete"></a>
# **LogOverridesDelete**
> void LogOverridesDelete (string id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LogOverridesDeleteExample
    {
        public void main()
        {
            
            var apiInstance = new LogOverridesApi();
            var id = id_example;  // string | 

            try
            {
                apiInstance.LogOverridesDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LogOverridesApi.LogOverridesDelete: " + e.Message );
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

<a name="logoverridesdeletebyid"></a>
# **LogOverridesDeleteById**
> void LogOverridesDeleteById (string id, string alias, string subAlias)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LogOverridesDeleteByIdExample
    {
        public void main()
        {
            
            var apiInstance = new LogOverridesApi();
            var id = id_example;  // string | 
            var alias = alias_example;  // string | 
            var subAlias = subAlias_example;  // string | 

            try
            {
                apiInstance.LogOverridesDeleteById(id, alias, subAlias);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LogOverridesApi.LogOverridesDeleteById: " + e.Message );
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

<a name="logoverridesget"></a>
# **LogOverridesGet**
> List<InlineResponse20016> LogOverridesGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LogOverridesGetExample
    {
        public void main()
        {
            
            var apiInstance = new LogOverridesApi();

            try
            {
                List&lt;InlineResponse20016&gt; result = apiInstance.LogOverridesGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LogOverridesApi.LogOverridesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<InlineResponse20016>**](InlineResponse20016.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="logoverridesgetbyid"></a>
# **LogOverridesGetById**
> InlineResponse20017 LogOverridesGetById (string id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LogOverridesGetByIdExample
    {
        public void main()
        {
            
            var apiInstance = new LogOverridesApi();
            var id = id_example;  // string | 

            try
            {
                InlineResponse20017 result = apiInstance.LogOverridesGetById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LogOverridesApi.LogOverridesGetById: " + e.Message );
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

[**InlineResponse20017**](InlineResponse20017.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="logoverridesgetbysubalias"></a>
# **LogOverridesGetBySubAlias**
> List<InlineResponse20016> LogOverridesGetBySubAlias (string alias, string subAlias)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LogOverridesGetBySubAliasExample
    {
        public void main()
        {
            
            var apiInstance = new LogOverridesApi();
            var alias = alias_example;  // string | 
            var subAlias = subAlias_example;  // string | 

            try
            {
                List&lt;InlineResponse20016&gt; result = apiInstance.LogOverridesGetBySubAlias(alias, subAlias);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LogOverridesApi.LogOverridesGetBySubAlias: " + e.Message );
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

[**List<InlineResponse20016>**](InlineResponse20016.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="logoverridespost"></a>
# **LogOverridesPost**
> void LogOverridesPost (Ovr ovr)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LogOverridesPostExample
    {
        public void main()
        {
            
            var apiInstance = new LogOverridesApi();
            var ovr = new Ovr(); // Ovr | 

            try
            {
                apiInstance.LogOverridesPost(ovr);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LogOverridesApi.LogOverridesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ovr** | [**Ovr**](Ovr.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="logoverridespostbysubalias"></a>
# **LogOverridesPostBySubAlias**
> void LogOverridesPostBySubAlias (Ovr1 ovr, string alias, string subAlias)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LogOverridesPostBySubAliasExample
    {
        public void main()
        {
            
            var apiInstance = new LogOverridesApi();
            var ovr = new Ovr1(); // Ovr1 | 
            var alias = alias_example;  // string | 
            var subAlias = subAlias_example;  // string | 

            try
            {
                apiInstance.LogOverridesPostBySubAlias(ovr, alias, subAlias);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LogOverridesApi.LogOverridesPostBySubAlias: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ovr** | [**Ovr1**](Ovr1.md)|  | 
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

