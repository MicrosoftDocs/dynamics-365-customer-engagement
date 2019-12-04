---
title: "Sample: Retrieve time zone information (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The sample demonstrates how to retrieve time zone information."
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
  - retrieving time zone information, time zone entities
  - time zone entities, retrieving time zone information
ms.assetid: 3df3e8c5-ff20-40c7-8ea8-e91001daebd1
caps.latest.revision: 14
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Retrieve time zone information

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. Download the complete sample here [Business management samples](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/BusinessManagement). 

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to retrieve time zone information.  
  
## Example  
 [!code-csharp[BusinessManagement#WorkingWithTimeZones](../snippets/csharp/CRMV8/businessmanagement/cs/workingwithtimezones.cs#workingwithtimezones)]  
  
### See also  
 [Time Zone Entities](time-zone-entities.md)   
 <xref:Microsoft.Crm.Sdk.Messages.GetAllTimeZonesWithDisplayNameRequest>   
 <xref:Microsoft.Crm.Sdk.Messages.GetTimeZoneCodeByLocalizedNameRequest>   
 <xref:Microsoft.Crm.Sdk.Messages.UtcTimeFromLocalTimeRequest>   
 <xref:Microsoft.Crm.Sdk.Messages.LocalTimeFromUtcTimeRequest>
