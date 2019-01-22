---
title: "Sample: Close an incident (Developer Guide for Dynamics 365 for Customer Engagement) | MicrosoftDocs"
description: "The sample code demonstrates how to process and close an incident (case) with a case resolution."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
helpviewer_keywords: 
  - processing and closing incidents (cases), service entities sample
  - sample for closing incidents (cases)
ms.assetid: 748ac902-3ba5-456c-ab91-aece8947131a
caps.latest.revision: 14
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Close an incident

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. [Download the Service samples](https://code.msdn.microsoft.com/Service-Samples-f42adf82).   

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to process and close an incident (case) with a case resolution.  
  
## Example  
 [!code-csharp[Service#CloseAnIncident](../snippets/csharp/CRMV8/service/cs/closeanincident.cs#closeanincident)]  
  
### See also  
 [Incident (Case) Entities](incident-case-entities.md)   
 <xref:Microsoft.Crm.Sdk.Messages.CloseIncidentRequest>   
 <xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>
