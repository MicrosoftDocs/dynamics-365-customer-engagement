---
title: "Compose HTTP requests and handle errors (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Read about the HTTP methods and headers that form a part of HTTP requests that interact with the Web API and how to identify and handle errors returned in the response"
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 64a39182-25de-4d31-951c-852025a75811
caps.latest.revision: 13
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Compose HTTP requests and handle errors

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

You interact with the Web API by composing and sending HTTP requests. You need to know how to set the appropriate HTTP headers and handle any errors included in the response.  

<a name="bkmk_url_versions"></a>

## Web API URL and versions

To access the Web API you must compose a URL using the parts in the following table.

|Part|Description|
|--|--|
|Protocol|The appropriate protocol, either `https://` or `http://`.|
|Base URL|<div>This is the URL you normally use to open the web application.<ul><li>For Dynamics 365 (online): use <code class="x-hidden-focus">&lt;tenant name&gt;.crm.dynamics.com</code>.</li><li>For Internet-facing deployment (IFD): Use the appropriate URL for your instance. This will be: <code class="x-hidden-focus">&lt;organization name&gt;.&lt;domain name&gt;</code>.</li><li>For Dynamics 365 (on-premises): use <code class="x-hidden-focus">&lt;server name&gt;/&lt;organization name&gt;</code>.</li></ul></div>|
|Web API path|The path to the web API is `/api/data/`.|
|Version|   The version is expressed this way: `v[Major_version].[Minor_version][PatchVersion]/`. The valid version for this release is <code class="x-hidden-focus">v9.0</code>.|
|Resource|The name of the entity, function, or action you want to use.|


The URL you will use will be composed with these parts: Protocol + Base URL + Web API path + Version + Resource.

<a name="version_compatiblity"></a>

###   Version compatibility

This release introduces capabilities which are not available in previous versions. Subsequent minor versions may provide additional capabilities which will not be back ported to earlier minor versions. Your code written for v9.0 will continue to work in future versions when you reference v9.0 in the URL you use.

As new capabilities are introduced they may conflict with earlier versions. This is necessary to allow the service to become better. Most of the time, capabilities will remain the same between versions but you should not assume they will.

> [!NOTE]
> Unlike the v8.x minor releases, new capabilities or other changes added to future versions will not be applied to earlier versions.
> You will need to pay attention to the version of the service you use and test your code if you change the version used.

<a name="bkmk_methods"></a>

## HTTP methods

HTTP requests can apply a variety of different methods. When using the Web API you will only use the methods listed in the following table.  
  
|Method|Usage|  
|------------|-----------|  
|GET|Use when retrieving data, including calling functions. The expected Status Code for a successful retrieve is 200 OK.|  
|POST|Use when creating entities or calling actions.|  
|PATCH|Use when updating entities or performing upsert operations.|  
|DELETE|Use when deleting entities or individual properties of entities.|  
|PUT|Use in limited situations to update individual properties of entities. This method isn’t recommended when updating most entities. You’ll use this when updating model entities.|  

<a name="bkmk_headers"></a>

## HTTP headers

 Although the OData protocol allows for both JSON and ATOM format, the web API only supports JSON. Therefore the following headers can be applied.  

 Every request should include the Accept header value of `application/json`, even when no response body is expected. Any error returned in the response will be returned as JSON. While your code should work even if this header isn’t included, we recommend including it as a best practice  

 The current OData version is 4.0, but future versions may allow for new capabilities. To ensure that there is no ambiguity about the OData version that will be applied to your code at that point in the future, you should always include an explicit statement of the current OData version and the Maximum version to apply in your code. Use both OData-Version and OData-MaxVersion headers set to a value of 4.0.  

 Queries which expand collection-valued navigation properties may return cached data for those properties that doesn’t reflect recent changes. Include `If-None-Match: null` header in the request body to override browser caching of Web API request. For more information see [Hypertext Transfer Protocol (HTTP/1.1): Conditional Requests 3.2 : If-None-Match](https://tools.ietf.org/html/rfc7232#section-3.2).

 All HTTP headers should include at least the following headers.  

```
Accept: application/json  
OData-MaxVersion: 4.0  
OData-Version: 4.0
If-None-Match: null
```  

 Every request that includes JSON data in the request body must include a Content-Type header with a value of `application/json`.  

```  
Content-Type: application/json  
```  

 You can use additional headers to enable specific capabilities.  

- To return data on create (POST) or update (PATCH) operations for entities, include the `return=representation` preference. When this preference is applied to a POST request, a successful response will have status 201 (Created) . For a PATCH request, a successful response will have a status 200 (OK). Without this preference applied, both operations will return status 204 (No Content) to reflect that no data is returned in the body of the response by default.  

  > [!NOTE]
  >  This capability was added with [!INCLUDE[pn_crm_8_2_0_both](../../includes/pn-crm-8-2-0-both.md)].  

- To return formatted values with a query, include the odata.include-annotations preference set to Microsoft.Dynamics.CRM.formattedvalue using the [Prefer](https://tools.ietf.org/html/rfc7240) header. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Include formatted values](query-data-web-api.md#bkmk_includeFormattedValues)  

- You also use the Prefer header with the odata.maxpagesize option to specify how many pages you want to return. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Specify the number of entities to return in a page](query-data-web-api.md#bkmk_specifyNumber)  

- To impersonate another user when the caller has the privileges to do so, add the MSCRMCallerID header with the systemuserid value of the user to impersonate. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Impersonate another user using the Web API](impersonate-another-user-web-api.md).  

- To apply optimistic concurrency, you can apply the [If-Match](https://tools.ietf.org/html/rfc7232#section-3.1) header with an Etag value. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Apply optimistic concurrency](perform-conditional-operations-using-web-api.md#bkmk_Applyoptimisticconcurrency).  

- To control whether an upsert operation should actually create or update an entity, you can also use the If-Match and [If-None-Match](https://tools.ietf.org/html/rfc7232#section-3.2) headers. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Upsert an entity](update-delete-entities-using-web-api.md#bkmk_upsert).  

- When you execute batch operations, you must apply a number of different headers in the request and with each part sent in the body. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Execute batch operations using the Web API](execute-batch-operations-using-web-api.md).  

<a name="bkmk_statusCodes"></a>

## Identify status codes

 Whether an http request succeeds or fails, the response will include a status code. Status codes returned by the [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] Customer Engagement Web API include the following.  


|          Code           |                                                                                                                                                                                                                                                                             Description                                                                                                                                                                                                                                                                              |     Type     |
|-------------------------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|--------------|
|         200 OK          |                                                                                                                                                                                                                                                Expect this when your operation will return data in the response body.                                                                                                                                                                                                                                                |   Success    |
|       201 Created       |                                                                                                                                                       Expect this when your entity POST operation succeeds and you have specified the `return=representation` preference in your request. <br />**Note:**  This capability was added with [!INCLUDE[pn_crm_8_2_0_both](../../includes/pn-crm-8-2-0-both.md)].                                                                                                                                                        |   Success    |
|     204 No Content      |                                                                                                                                                                                                                                       Expect this when your operation succeeds but does not return data in the response body.                                                                                                                                                                                                                                        |   Success    |
|    304 Not Modified     |                                                                                                                                                 Expect this when testing whether an entity has been modified since it was last retrieved. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Conditional retrievals](perform-conditional-operations-using-web-api.md#bkmk_DetectIfChanged)                                                                                                                                                  | Redirection  |
|      403 Forbidden      | Expect this for the following types of errors:<br /><br /> -   AccessDenied<br />-   AttributePermissionReadIsMissing<br />-   AttributePermissionUpdateIsMissingDuringUpdate<br />-   AttributePrivilegeCreateIsMissing<br />-   CannotActOnBehalfOfAnotherUser<br />-   CannotAddOrActonBehalfAnotherUserPrivilege<br />-   CrmSecurityError<br />-   InvalidAccessRights<br />-   PrincipalPrivilegeDenied<br />-   PrivilegeCreateIsDisabledForOrganization<br />-   PrivilegeDenied<br />-   unManagedinvalidprincipal<br />-   unManagedinvalidprivilegeedepth | Client Error |
|    401 Unauthorized     |                                                                   Expect this for the following types of errors:<br /><br /> -   BadAuthTicket<br />-   ExpiredAuthTicket<br />-   InsufficientAuthTicket<br />-   InvalidAuthTicket<br />-   InvalidUserAuth<br />-   MissingCrmAuthenticationToken<br />-   MissingCrmAuthenticationTokenOrganizationName<br />-   RequestIsNotAuthenticated<br />-   TamperedAuthTicket<br />-   UnauthorizedAccess<br />-   UnManagedInvalidSecurityPrincipal                                                                    | Client Error |
|  413 Payload Too Large  |                                                                                                                                                                                                                                                          Expect this when the request length is too large.                                                                                                                                                                                                                                                           | Client Error |
|     400 BadRequest      |                                                                                                                                                                                                                                                               Expect this when an argument is invalid.                                                                                                                                                                                                                                                               | Client Error |
|      404 Not Found      |                                                                                                                                                                                                                                                             Expect this when the resource doesn’t exist.                                                                                                                                                                                                                                                             | Client Error |
| 405 Method Not Allowed  |                                                                                                                                  This error occurs for incorrect method and resource combinations. For example, you can’t use DELETE or PATCH on a collection of entities.<br /><br /> Expect this for the following types of errors:<br /><br /> -   CannotDeleteDueToAssociation<br />-   InvalidOperation<br />-   NotSupported                                                                                                                                   | Client Error |
| 412 Precondition Failed |                                                                                                                                                                                                                          Expect this for the following types of errors:<br /><br /> -   ConcurrencyVersionMismatch<br />-   DuplicateRecord                                                                                                                                                                                                                          | Client Error |
|  429 Too Many Requests  |                                                                                                                                                                                                         Expect this when API limits are exceeded. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [API Limits](../api-limits.md)                                                                                                                                                                                                          | Client Error |
|   501 Not Implemented   |                                                                                                                                                                                                                                                     Expect this when some requested operation isnt implemented.                                                                                                                                                                                                                                                      | Server Error |
| 503 Service Unavailable |                                                                                                                                                                                                                                                        Expect this when the web API service isn’t available.                                                                                                                                                                                                                                                         | Server Error |

<a name="bkmk_parseErrors"></a>

## Parse errors from the response

 Details about errors are included as JSON in the response. Errors will be in this format.  

```json  
{  
 "error":{  
  "code": "<This code is not related to the http status code and is frequently empty>",  
  "message": "<A message describing the error>",  
  "innererror": {  
   "message": "<A message describing the error, this is frequently the same as the outer message>",  
   "type": "Microsoft.Crm.CrmHttpException",  
   "stacktrace": "<Details from the server about where the error occurred>"  
  }  
 }  
}  
```  

### See also  
 [Perform operations using the Web API](perform-operations-web-api.md)   
 [Query Data using the Web API](query-data-web-api.md)   
 [Create an entity using the Web API](create-entity-web-api.md)   
 [Retrieve an entity using the Web API](retrieve-entity-using-web-api.md)   
 [Update and delete entities using the Web API](update-delete-entities-using-web-api.md)   
 [Associate and disassociate entities using the Web API](associate-disassociate-entities-using-web-api.md)   
 [Use Web API functions](use-web-api-functions.md)   
 [Use Web API actions](use-web-api-actions.md)   
 [Execute batch operations using the Web API](execute-batch-operations-using-web-api.md)   
 [Impersonate another user using the Web API](impersonate-another-user-web-api.md)   
 [Perform conditional operations using the Web API](perform-conditional-operations-using-web-api.md)
