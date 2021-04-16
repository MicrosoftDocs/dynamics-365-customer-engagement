---
title: "Sample: Retrieve absolute URL and site collection URL of a location record | MicrosoftDocs"
description: ""
keywords: 
ms.date: 10/31/2017
ms.service: crm-online
ms.custom: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: f40b22d9-89fc-4b9f-a158-c7944c768d1b
author: KumarVivek
ms.author: kvivek
manager: jdaly
ms.reviewer: pehecke
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 19
topic-status: Drafting
search.audienceType: 
  - developer

---

# Sample: Retrieve absolute URL and site collection URL of a location record

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)]. Download the sample: [Work with SharePoint Integration](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/SharePointIntegration).

## Prerequisites
[!INCLUDE[sdk-prerequisite](../../includes/sdk-prerequisite.md)]
   
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to retrieve the absolute URL and the site collection URL of a [!INCLUDE[pn_SharePoint_Server_short](../../includes/pn-sharepoint-server-short.md)] location record in [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] using the <xref:Microsoft.Crm.Sdk.Messages.RetrieveAbsoluteAndSiteCollectionUrlRequest> message.  
  
## Example  
 [!code-csharp[SharePointIntegration#RetrieveAbsoluteAndSiteCollectionURLs](../../snippets/csharp/CRMV8/sharepointintegration/cs/retrieveabsoluteandsitecollectionurls.cs#retrieveabsoluteandsitecollectionurls)]  
  
### See also  
 [Integrate SharePoint with Microsoft Dynamics 365 Customer Engagement (on-premises)](integrate-sharepoint.md)   
 [Retrieve Absolute and Site Collection URLs for a Location Record](actions-on-sharepoint-location-records.md#RetrieveUrls)   
 [Sample: Create, Retrieve, Update, and Delete (CRUD) a SharePoint Location Record](sample-create-retrieve-update-delete-sharepoint-location-record.md)   
 <xref:Microsoft.Crm.Sdk.Messages.RetrieveAbsoluteAndSiteCollectionUrlRequest>


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]