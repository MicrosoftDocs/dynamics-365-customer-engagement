---
title: "Sample: Export and import a data map (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Sample demonstrates how to create an import map, export it as XML-formatted data, import modified mappings, and create a new import map based on the imported mappings."
keywords: 
ms.date: 10/31/2017
ms.service: crm-online
ms.custom: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 66255050-1a19-4bd2-a839-3cc45e7947d8
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
helpviewer_keywords: 
  - sample for exporting and importing data maps
  - exporting and importing data maps sample
  - importing data in Microsoft Dynamics CRM, sample for exporting and importing data maps
topic-status: Drafting
search.audienceType: 
  - developer
search.app: 
  - D365CE
---

# Sample: Export and import a data map

This sample code is for Dynamics 365 Customer Engagement. Download the sample: [Work with importing data](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/DataImport).  

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to create an import map (data map) in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] for Customer Engagement, export it as an XML formatted data, import modified mappings, and create a new import map in Dynamics 365 Customer Engagement (on-premises) for Customer Engagement based on the imported mappings.  
  
## Example  
 [!code-csharp[DataImport#UsingExportAndImportMappings](../snippets/csharp/CRMV8/dataimport/cs/usingexportandimportmappings.cs#usingexportandimportmappings)]  
  
### See also  
 [Import Data in Dynamics 365 Customer Engagement (on-premises)](import-data.md)   
 <xref:Microsoft.Crm.Sdk.Messages.ExportMappingsImportMapRequest>   
 <xref:Microsoft.Crm.Sdk.Messages.ImportMappingsImportMapRequest>   
 [Sample: Import Data Using Complex Data Map](sample-import-data-complex-data-map.md)
