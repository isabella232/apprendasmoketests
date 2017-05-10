# IO.Swagger.Api.CustomUrlCertificateApi

All URIs are relative to *https://apps.apprenda.msterling/developer*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CustomUrlCertificateDelete**](CustomUrlCertificateApi.md#customurlcertificatedelete) | **DELETE** /api/v1/apps/{appAlias}/customUrlCertificate | 
[**CustomUrlCertificateGet**](CustomUrlCertificateApi.md#customurlcertificateget) | **GET** /api/v1/apps/{appAlias}/customUrlCertificate | 
[**CustomUrlCertificatePost**](CustomUrlCertificateApi.md#customurlcertificatepost) | **POST** /api/v1/apps/{appAlias}/customUrlCertificate | 
[**CustomUrlCertificatePut**](CustomUrlCertificateApi.md#customurlcertificateput) | **PUT** /api/v1/apps/{appAlias}/customUrlCertificate | 


<a name="customurlcertificatedelete"></a>
# **CustomUrlCertificateDelete**
> void CustomUrlCertificateDelete (string appAlias)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomUrlCertificateDeleteExample
    {
        public void main()
        {
            
            var apiInstance = new CustomUrlCertificateApi();
            var appAlias = appAlias_example;  // string | 

            try
            {
                apiInstance.CustomUrlCertificateDelete(appAlias);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomUrlCertificateApi.CustomUrlCertificateDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appAlias** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customurlcertificateget"></a>
# **CustomUrlCertificateGet**
> InlineResponse20013 CustomUrlCertificateGet (string appAlias)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomUrlCertificateGetExample
    {
        public void main()
        {
            
            var apiInstance = new CustomUrlCertificateApi();
            var appAlias = appAlias_example;  // string | 

            try
            {
                InlineResponse20013 result = apiInstance.CustomUrlCertificateGet(appAlias);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomUrlCertificateApi.CustomUrlCertificateGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appAlias** | **string**|  | 

### Return type

[**InlineResponse20013**](InlineResponse20013.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customurlcertificatepost"></a>
# **CustomUrlCertificatePost**
> InlineResponse20013 CustomUrlCertificatePost (string appAlias)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomUrlCertificatePostExample
    {
        public void main()
        {
            
            var apiInstance = new CustomUrlCertificateApi();
            var appAlias = appAlias_example;  // string | 

            try
            {
                InlineResponse20013 result = apiInstance.CustomUrlCertificatePost(appAlias);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomUrlCertificateApi.CustomUrlCertificatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appAlias** | **string**|  | 

### Return type

[**InlineResponse20013**](InlineResponse20013.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="customurlcertificateput"></a>
# **CustomUrlCertificatePut**
> InlineResponse20013 CustomUrlCertificatePut (string appAlias)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CustomUrlCertificatePutExample
    {
        public void main()
        {
            
            var apiInstance = new CustomUrlCertificateApi();
            var appAlias = appAlias_example;  // string | 

            try
            {
                InlineResponse20013 result = apiInstance.CustomUrlCertificatePut(appAlias);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomUrlCertificateApi.CustomUrlCertificatePut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appAlias** | **string**|  | 

### Return type

[**InlineResponse20013**](InlineResponse20013.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

