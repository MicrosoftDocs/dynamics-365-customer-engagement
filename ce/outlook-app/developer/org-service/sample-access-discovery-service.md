---
title: "Sample: Access the Discovery service (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "The sample demonstrates how to obtain organization information, including the organization’s URL, from the DiscoveryService Web service."
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "samples"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 34249eb1-378e-4dd2-9c02-f14bcd470b64
caps.latest.revision: 20
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# Sample: Access the Discovery service
This sample code is for [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] Customer Engagement. Download the complete sample of [Access the discovery service](https://code.msdn.microsoft.com/Sample-Access-the-6dea28f1). 

## Prerequisites
[!INCLUDE[sdk-prerequisite](../../includes/sdk-prerequisite.md)]
  
## Demonstrates  
 How to obtain organization information, including the organization’s URL, from the DiscoveryService Web service.  
  
## Example  
 [!code-csharp[DiscoveryService#DiscoveryService](../../snippets/csharp/CRMV8/discoveryservice/cs/discoveryservice.cs#discoveryservice)]  
  
### See also  
 [Use IDiscoveryService to Discover the URL for Your Organization](discover-url-organization-organization-service.md)   
 <xref:Microsoft.Xrm.Sdk.Client.DiscoveryServiceProxy>   
 <xref:Microsoft.Xrm.Sdk.Discovery.RetrieveOrganizationsRequest>   
 <xref:Microsoft.Xrm.Sdk.Discovery.OrganizationDetail>