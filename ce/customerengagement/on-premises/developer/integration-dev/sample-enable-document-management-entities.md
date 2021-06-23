---
title: "Sample: Enable document management for entities | MicrosoftDocs"
description: ""
keywords: 
ms.date: 10/31/2017
ms.service: crm-online
ms.custom: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 3272e732-908d-461f-be4d-81a94bfc9afb
author: KumarVivek
ms.author: kvivek
manager: jdaly
ms.reviewer: pehecke
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 28
topic-status: Drafting
search.audienceType: 
  - developer

---

# Sample: Enable document management for entities

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)]. Download the sample: [With SharePoint Integration](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/SharePointIntegration).

## Prerequisites
[!INCLUDE[sdk-prerequisite](../../includes/sdk-prerequisite.md)]
   
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 The following sample shows how to enable document management for entities in [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)]. In this sample code, document management is enabled for the `Contact` entity using the <xref:Microsoft.Xrm.Sdk.Messages.UpdateEntityRequest> message. By default, the setting for the `Contact` entity isn’t enabled in a new installation of [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)].  
  
## Example  
 [!code-csharp[SharePointIntegration#EnableDocumentManagement](../../snippets/csharp/CRMV8/sharepointintegration/cs/enabledocumentmanagement.cs#enabledocumentmanagement)]  
  
### See also  
 [Integrate SharePoint with Microsoft Dynamics 365 Customer Engagement (on-premises)](integrate-sharepoint.md)   
 [Enable SharePoint Integration](enable-document-management-entities.md)   
 [Sample: Create, Retrieve, Update, and Delete a SharePoint Location Record](sample-create-retrieve-update-delete-sharepoint-location-record.md)   
 [Sample: Create, Retrieve, Update, and Delete (CRUD) a SharePoint Location Record](sample-create-retrieve-update-delete-sharepoint-location-record.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]