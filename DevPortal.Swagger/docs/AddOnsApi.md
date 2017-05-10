# IO.Swagger.Api.AddOnsApi

All URIs are relative to *https://apps.apprenda.msterling/developer*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddOnsDelete**](AddOnsApi.md#addonsdelete) | **DELETE** /api/v1/AddOns | 
[**AddOnsDeleteByAlias**](AddOnsApi.md#addonsdeletebyalias) | **DELETE** /api/v1/AddOns/{alias}/{subAlias} | 
[**AddOnsGet**](AddOnsApi.md#addonsget) | **GET** /api/v1/AddOns | 
[**AddOnsGetByAlias**](AddOnsApi.md#addonsgetbyalias) | **GET** /api/v1/AddOns/{id} | 
[**AddOnsGetBySubAlias**](AddOnsApi.md#addonsgetbysubalias) | **GET** /api/v1/AddOns/{alias}/{subAlias} | 
[**AddOnsPost**](AddOnsApi.md#addonspost) | **POST** /api/v1/AddOns/{id} | 
[**AddOnsPostToSubAlias**](AddOnsApi.md#addonsposttosubalias) | **POST** /api/v1/AddOns/{alias}/{subAlias} | 


<a name="addonsdelete"></a>
# **AddOnsDelete**
> void AddOnsDelete (string alias, string subAlias)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddOnsDeleteExample
    {
        public void main()
        {
            
            var apiInstance = new AddOnsApi();
            var alias = alias_example;  // string | 
            var subAlias = subAlias_example;  // string | 

            try
            {
                apiInstance.AddOnsDelete(alias, subAlias);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddOnsApi.AddOnsDelete: " + e.Message );
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

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addonsdeletebyalias"></a>
# **AddOnsDeleteByAlias**
> void AddOnsDeleteByAlias (string alias, string subAlias)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddOnsDeleteByAliasExample
    {
        public void main()
        {
            
            var apiInstance = new AddOnsApi();
            var alias = alias_example;  // string | 
            var subAlias = subAlias_example;  // string | 

            try
            {
                apiInstance.AddOnsDeleteByAlias(alias, subAlias);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddOnsApi.AddOnsDeleteByAlias: " + e.Message );
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

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addonsget"></a>
# **AddOnsGet**
> InlineResponse200 AddOnsGet (string include = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddOnsGetExample
    {
        public void main()
        {
            
            var apiInstance = new AddOnsApi();
            var include = include_example;  // string |  (optional) 

            try
            {
                InlineResponse200 result = apiInstance.AddOnsGet(include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddOnsApi.AddOnsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **include** | **string**|  | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addonsgetbyalias"></a>
# **AddOnsGetByAlias**
> InlineResponse2001 AddOnsGetByAlias (string id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddOnsGetByAliasExample
    {
        public void main()
        {
            
            var apiInstance = new AddOnsApi();
            var id = id_example;  // string | 

            try
            {
                InlineResponse2001 result = apiInstance.AddOnsGetByAlias(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddOnsApi.AddOnsGetByAlias: " + e.Message );
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

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addonsgetbysubalias"></a>
# **AddOnsGetBySubAlias**
> InlineResponse200 AddOnsGetBySubAlias (string alias, string subAlias, string include = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddOnsGetBySubAliasExample
    {
        public void main()
        {
            
            var apiInstance = new AddOnsApi();
            var alias = alias_example;  // string | 
            var subAlias = subAlias_example;  // string | 
            var include = include_example;  // string |  (optional) 

            try
            {
                InlineResponse200 result = apiInstance.AddOnsGetBySubAlias(alias, subAlias, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddOnsApi.AddOnsGetBySubAlias: " + e.Message );
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
 **include** | **string**|  | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addonspost"></a>
# **AddOnsPost**
> InlineResponse200DeployedAddOns AddOnsPost (string id, Options options)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddOnsPostExample
    {
        public void main()
        {
            
            var apiInstance = new AddOnsApi();
            var id = id_example;  // string | 
            var options = new Options(); // Options | 

            try
            {
                InlineResponse200DeployedAddOns result = apiInstance.AddOnsPost(id, options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddOnsApi.AddOnsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **options** | [**Options**](Options.md)|  | 

### Return type

[**InlineResponse200DeployedAddOns**](InlineResponse200DeployedAddOns.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addonsposttosubalias"></a>
# **AddOnsPostToSubAlias**
> InlineResponse200DeployedAddOns AddOnsPostToSubAlias (string id, Options1 options, string alias, string subAlias)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddOnsPostToSubAliasExample
    {
        public void main()
        {
            
            var apiInstance = new AddOnsApi();
            var id = id_example;  // string | 
            var options = new Options1(); // Options1 | 
            var alias = alias_example;  // string | 
            var subAlias = subAlias_example;  // string | 

            try
            {
                InlineResponse200DeployedAddOns result = apiInstance.AddOnsPostToSubAlias(id, options, alias, subAlias);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddOnsApi.AddOnsPostToSubAlias: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **options** | [**Options1**](Options1.md)|  | 
 **alias** | **string**|  | 
 **subAlias** | **string**|  | 

### Return type

[**InlineResponse200DeployedAddOns**](InlineResponse200DeployedAddOns.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

