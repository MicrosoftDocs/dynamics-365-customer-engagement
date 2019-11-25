---
title: "Sample: Export ribbon definitions (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The sample shows how to export Ribbon definitions. It uses the RetrieveApplicationRibbonRequest and RetrieveEntityRibbonRequest messages. "
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: a657c8bb-dbeb-461f-8271-d07a97c3ea0e
caps.latest.revision: 16
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Export ribbon definitions

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)]. [Download the Export ribbon definitions sample](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/ExportRibbonXml).

## Prerequisites
[!INCLUDE[sdk-prerequisite](../../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to export Ribbon definitions. It uses the <xref:Microsoft.Crm.Sdk.Messages.RetrieveApplicationRibbonRequest> and <xref:Microsoft.Crm.Sdk.Messages.RetrieveEntityRibbonRequest> messages.  
  
## Example  
 [!code-csharp[ExportRibbonXml#ExportRibbonXml](../../snippets/csharp/CRMV8/exportribbonxml/cs/exportribbonxml.cs#exportribbonxml)]  
  
### See also  
 [Customize commands and the ribbon](customize-commands-ribbon.md)   
 [Pass Parameters to a URL By Using the Ribbon](pass-parameters-url-by-using-ribbon.md)   
 [Ribbon core schema](ribbon-core-schema.md)
 [Ribbon types schema](ribbon-types-schema.md)
 [Ribbon WSS schema](ribbon-wss-schema.md)
 <xref:Microsoft.Crm.Sdk.Messages.RetrieveApplicationRibbonRequest>   
 <xref:Microsoft.Crm.Sdk.Messages.RetrieveEntityRibbonRequest>
