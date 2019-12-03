---
title: "Sample: Create, retrieve, update, and delete an email attachment (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "This sample shows how to create, retrieve, update, and delete email attachments using methods such as IOrganizationService.Entity, IOrganizationService.ColumnSet, IOrganizationService.Entity, IOrganizationService.Guid"
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - sample for creating; retrieving; updating; and deleting email attachments, activity entities
  - activity entities samples, creating; retrieving; updating; and deleting email attachments
ms.assetid: 918c0b7e-2850-40c5-8333-5dad6d83b850
caps.latest.revision: 22
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Create, retrieve, update, and delete an email attachment

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. Download the complete sample from [Sample: Work with Activity entities](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/Activities).   

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to create, retrieve, update, and delete email attachments using the following methods:  
  
-   <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>  
  
-   <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>  
  
-   <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>  
  
-   <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>  
  
## Example  
 [!code-csharp[Activities#CRUDEmailAttachments](../snippets/csharp/CRMV8/activities/cs/crudemailattachments.cs#crudemailattachments)]  
  
### See also  
 [Sample Code for Activity Entities](sample-code-activity-entities.md)   
 [EMail Activity Entities](email-activity-entities.md)   
 [Sample: Retrieve Email Attachments for an Email Template](sample-retrieve-email-attachments-email-template.md)   
 [ActivityMimeAttachment Entity](entities/activitymimeattachment.md)   
<xref:Microsoft.Xrm.Sdk.IOrganizationService>
