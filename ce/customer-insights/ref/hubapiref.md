---
title: Hub API Reference
description: These APIs are exposed by the Customer Insights Hub endpoint.
keywords: Customer Insights; Hub API
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 05/17/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 2c6ac018-9738-43e8-b5f7-b8c27bad3077
---
Hub API Reference
=================

[!include[pre release disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

After you create a Customer Insights Hub using the Azure Portal or through a [Create Hub](./arm/hubcreateupdate.md) (ARM) operation, a new set of Hub APIs is available for use. (The base endpoint for the hub is available in the response from the [Get Hub](./arm/hubget.md) (ARM) operation.)  These APIs fall into the following two general groups:
* [Hub Management APIs](./hub/hubmngnt.md) support type modeling, security, application, widget,and connector management.  There is a high degree of commonality between this API set and the [Hub Management APIs via ARM](./arm/hubmngnt.md).  The APIs in this first group are accessed through endpoints of the form:
&emsp; `https://<hubName>.api.azurecustomerinsights.com/manage/<resourceName>`
* [Hub Data APIs](./hubdataapiref.md) support working with actual instance data of the various customized entity types (also referred to as _entity sets_). These APIs conform to the [OData](http://www.odata.org) specification, and are accessed through endpoints of the form:
&emsp; `https://<hubName>.api.azurecustomerinsights.com/manage/<resourceName>`


<!--TODO - add list of functionality groups like are in ArmApiRef.md? -->

## Authorization to Hub APIs 
Hub APIs support access through Shared Access Signature ([SAS](https://msdn.microsoft.com/en-us/library/azure/ee395415.aspx)) tokens as well as Azure Active 
Directory ([AAD](https://azure.microsoft.com/en-us/services/active-directory/)).  

As token-based authorization (authz) is enabled by SAS policies that we store in the system. Each SAS policy has two symmetric keys used to sign the SAS 
tokens. Each policy also holds the information about the access rights it grants to a HTTP call (Read, Write, Manage). When a hub is provisioned, it gets 
assigned a default SAS policy named as `RootManageSharedAccessKey`. This is an 'all access' SAS policy for the hub. The SAS token is specified in the Authorization 
header of the HTTP request sent to the Hub API endpoint. The format of the token is as follows:

&nbsp;&nbsp;&nbsp;&nbsp; `SharedAccessSignature-sig=<signature>&se=<expiry>&skn=<policyName>&sr=<resourceUri>`  

Where the parameters have the following meaning:

|**Token Parameter**|**Required**|**Description**|  
| --------------- | ---------- | ------------- |   
|expiry|Yes|The URL-encoded [epoch time](https://en.wikipedia.org/wiki/Unix_time) till which the token is supposed to be valid.|  
|policyName|Yes|The URL-encoded name of the SAS policy (associated with the hub being called) using one of whose keys the token has been signed.|  
|resourceUri|Yes|the URL encoded URI that is signed. The actual http request URI should be under this URI for authz to succeed.|  
|signature|Yes|The [HMAC SHA256](https://msdn.microsoft.com/en-us/library/system.security.cryptography.hmacsha256.aspx) hash of the string `"<resourceUri>\n<expiry>"` computed using either of the two keys of the SAS policy specified by `<policyName>`|  
| | | |

For AAD-based authz, the calling user/application needs to get a token for resource “https://azurecustomerinsights.com” from their AAD tenant endpoint. The token is validated for the 
following in the Customer Insights service:
*  Signature validation
*  Audience validation
*  Issuer validation: The token should be from the parent tenant for the Azure subscription in which the Customer Insights Hub was created.

The Customer Insights [RBAC APIs](./hub/rbacmngnt.md) configure access (authorization) to principals. Depending upon the API being invoked, the calls are authorized accordingly.
