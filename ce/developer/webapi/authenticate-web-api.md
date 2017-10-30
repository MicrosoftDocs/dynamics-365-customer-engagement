---
title: "Authenticate to Dynamics 365 Customer Engagement with the Web API (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Learn about the different ways to manage authentication when using the Web API"
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 767f39d4-6a8e-48f0-bf7d-69ea1191acef
caps.latest.revision: 8
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# Authenticate to Dynamics 365 Customer Engagement with the Web API
The code you write to manage authentication when using the Web API depends on the type of deployment and where your code is.  
  
## Web API authentication patterns  
 There are three different ways to manage authentication when using the Web API.  
  
### With JavaScript in web resources  
 When you use the Web API with [!INCLUDE[pn_JavaScript](../../includes/pn-javascript.md)] within HTML web resources, form scripts, or ribbon commands you don’t need to include any code for authentication. In each of these cases the user is already authenticated by the application and authentication is managed by the application.  
  
### With on-premises deployments  

[!INCLUDE[cc_sdk_onpremises_note](../../includes/cc-sdk-onpremises-note.md)] 

When you use the Web API for on-premises deployments you must include the user’s network credentials. The following example is a C# function that will return an [HttpClient](https://msdn.microsoft.com/library/system.net.http.httpclient\(v=vs.110\).aspx) configured for a given user’s network credentials:  
  
```csharp  
private HttpClient getNewHttpClient(string userName,string password,string domainName, string webAPIBaseAddress)  
{  
    HttpClient client = new HttpClient(new HttpClientHandler() { Credentials = new NetworkCredential(userName, password, domainName) });  
    client.BaseAddress = new Uri(webAPIBaseAddress);  
    client.Timeout = new TimeSpan(0, 2, 0);  
    return client;  
}  
```  
  
### With [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] or Internet-facing deployments  
 When you use the Web API for [!INCLUDE[pn_crm_online_shortest](../../includes/pn-crm-online-shortest.md)] Customer Engagement or an on-premises Internet-facing deployment (IFD) you must use OAuth as described in [Use OAuth to connect to Dynamics 365 web Services](../connect-customer-engagement-web-services-using-oauth.md).  
  
 If you’re creating a single page application (SPA) using [!INCLUDE[pn_JavaScript](../../includes/pn-javascript.md)] you can use the adal.js library as described in [Use OAuth with Cross-Origin Resource Sharing  to connect a Single Page Application  to Dynamics 365](../oauth-cross-origin-resource-sharing-connect-single-page-application.md).  
  
### See also  
 [Use the Dynamics 365 Web API](../use-microsoft-dynamics-365-web-api.md)   
 [Web API types and operations](web-api-types-operations.md)   
 [Perform operations using the Web API](perform-operations-web-api.md)   
 [Use OAuth to connect to Dynamics 365 web Services](../connect-customer-engagement-web-services-using-oauth.md)   
 [Use OAuth with Cross-Origin Resource Sharing  to connect a Single Page Application  to Dynamics 365](../oauth-cross-origin-resource-sharing-connect-single-page-application.md)
