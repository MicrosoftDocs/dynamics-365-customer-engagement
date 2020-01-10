---
title: "Sample: Import data using complex data map (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Sample demonstrates how to create new records with data import by using a complex data map."
keywords: 
ms.date: 10/31/2017
ms.service: crm-online
ms.custom: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 1ed89b35-a84d-488e-b58c-4ed6eb26018c
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
helpviewer_keywords: 
  - importing data in Microsoft Dynamics CRM, sample for importing data by using complex data maps
  - sample for importing data by using complex data maps
  - sample for creating new records in Microsoft Dynamics CRM by using data import
  - importing data in Microsoft Dynamics CRM, sample for creating new records in Microsoft Dynamics CRM by using data import
  - creating new records in Microsoft Dynamics CRM by using data import sample
  - importing data by using complex data maps sample
topic-status: Drafting
search.audienceType: 
  - developer
search.app: 
  - D365CE
---

# Sample: Import data using complex data map

This sample code is for Dynamics 365 Customer Engagement. Download the sample: [Work with importing data](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/DataImport).
  
> [!NOTE]
>  The source data for this sample is contained in the following file:   
> `Import data\C#\import accounts.csv`

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to create new records in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] for Customer Engagement by using data import. The sample uses a complex data map.  
  
## Example  
 [!code-csharp[DataImport#ImportWithCreate](../snippets/csharp/CRMV8/dataimport/cs/importwithcreate.cs#importwithcreate)]  
  
### See also  
 [Import Data in Dynamics 365 Customer Engagement (on-premises)](import-data.md)   
 <xref:Microsoft.Crm.Sdk.Messages.GetHeaderColumnsImportFileRequest>   
 <xref:Microsoft.Crm.Sdk.Messages.ParseImportRequest>   
 <xref:Microsoft.Crm.Sdk.Messages.GetDistinctValuesImportFileRequest>   
 <xref:Microsoft.Crm.Sdk.Messages.RetrieveParsedDataImportFileRequest>   
 <xref:Microsoft.Crm.Sdk.Messages.TransformImportRequest>   
 <xref:Microsoft.Crm.Sdk.Messages.ImportRecordsImportRequest>
