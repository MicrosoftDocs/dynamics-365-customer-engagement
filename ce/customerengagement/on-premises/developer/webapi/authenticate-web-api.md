---
title: "Authenticate to Dynamics 365 Customer Engagement with the Web API (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Learn about the different ways to manage authentication when using the Web API"
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 767f39d4-6a8e-48f0-bf7d-69ea1191acef
caps.latest.revision: 8
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Authenticate to Dynamics 365 Customer Engagement with the Web API

> [!NOTE]
> [!INCLUDE[](../includes/cc-cdsnote-2-topic.md)]
> 
> The authentication documentation that is applicable to Dynamics 365 Customer Engagement app (online) users is now available in the Power Apps documentation at: [Authenticate to Dataverse with the Web API](/powerapps/developer/common-data-service/webapi/authenticate-web-api).

The code you write to manage authentication when using the Web API depends on the type of deployment and where your code is.  

## Authenticate with JavaScript in web resources

For information on how to authenticate with JavaScript in web resources, see this Power Apps Dataverse topic: [Authenticate to Dataverse with the Web API](/powerapps/developer/common-data-service/webapi/authenticate-web-api).
  
## Web API authentication with On-premise deployments
  
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
 When you use the Web API for [!INCLUDE[pn_crm_online_shortest](../../includes/pn-crm-online-shortest.md)]  or an on-premises Internet-facing deployment (IFD) you must use OAuth as described in [Use OAuth with Dataverse](/powerapps/developer/common-data-service/authenticate-oauth).  
  
 If you’re creating a single page application (SPA) using [!INCLUDE[pn_JavaScript](../../includes/pn-javascript.md)] you can use the adal.js library as described in [Use OAuth with Cross-Origin Resource Sharing  to connect a Single Page Application](/powerapps/developer/common-data-service/oauth-cross-origin-resource-sharing-connect-single-page-application).  
  
### See also  

[Use Dynamics 365 Customer Engagement Web API](../use-microsoft-dynamics-365-web-api.md)

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]