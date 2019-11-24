---
title: "Sample: Upload, retrieve, and download an attachment | MicrosoftDocs"
description: "The sample demonstrates how to upload, retrieve, and download an attachment for an annotation using the IOrganizationService.Entity) and IOrganizationService.ColumnSet) methods. "
ms.custom: 
ms.date: 11/24/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - uploading; retrieving; and downloading attachments sample, sample for the annotation (note) entity
  - sample for uploading; retrieving; and downloading attachments, annotation (note) entity sample
ms.assetid: a231c619-7130-43f0-b3da-fd1a87545672
caps.latest.revision: 19
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Upload, retrieve, and download an attachment

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. Download the complete sample from [Work with Annotations](https://code.msdn.microsoft.com/Annotation-Sample-9d797e21).  

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to upload, retrieve, and download an attachment for an annotation using the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*> and <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*> methods.  
  
## Example  
 [!code-csharp[Annotation#UploadAndDownloadAttachment](../snippets/csharp/CRMV8/annotation/cs/uploadanddownloadattachment.cs#uploadanddownloadattachment)]  
  
### See also  
    
 [Annotation (Note) Entity](annotation-note-entity.md)   
<xref:Microsoft.Xrm.Sdk.IOrganizationService>   
 <xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>   
 <xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>
