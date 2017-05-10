# IO.Swagger.Api.PoliciesApi

All URIs are relative to *https://apps.apprenda.msterling/developer*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PoliciesGet**](PoliciesApi.md#policiesget) | **GET** /api/v1/Policies | 
[**PoliciesGetById**](PoliciesApi.md#policiesgetbyid) | **GET** /api/v1/Policies/{id} | 
[**PoliciesGetBySubAlias**](PoliciesApi.md#policiesgetbysubalias) | **GET** /api/v1/Policies/{alias}/{subAlias} | 


<a name="policiesget"></a>
# **PoliciesGet**
> List<InlineResponse20021> PoliciesGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PoliciesGetExample
    {
        public void main()
        {
            
            var apiInstance = new PoliciesApi();

            try
            {
                List&lt;InlineResponse20021&gt; result = apiInstance.PoliciesGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PoliciesApi.PoliciesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<InlineResponse20021>**](InlineResponse20021.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="policiesgetbyid"></a>
# **PoliciesGetById**
> InlineResponse20022 PoliciesGetById (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PoliciesGetByIdExample
    {
        public void main()
        {
            
            var apiInstance = new PoliciesApi();
            var id = id_example;  // Guid? | 

            try
            {
                InlineResponse20022 result = apiInstance.PoliciesGetById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PoliciesApi.PoliciesGetById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **Guid?**|  | 

### Return type

[**InlineResponse20022**](InlineResponse20022.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="policiesgetbysubalias"></a>
# **PoliciesGetBySubAlias**
> List<InlineResponse20021> PoliciesGetBySubAlias (string alias, string subAlias)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PoliciesGetBySubAliasExample
    {
        public void main()
        {
            
            var apiInstance = new PoliciesApi();
            var alias = alias_example;  // string | 
            var subAlias = subAlias_example;  // string | 

            try
            {
                List&lt;InlineResponse20021&gt; result = apiInstance.PoliciesGetBySubAlias(alias, subAlias);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PoliciesApi.PoliciesGetBySubAlias: " + e.Message );
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

[**List<InlineResponse20021>**](InlineResponse20021.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

