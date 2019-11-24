---
title: "Sample: Create an email using a template (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "This sample shows how to instantiate an email record by using the InstantiateTemplateRequest message"
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 4a17a1b0-c111-4575-ae70-802b79a2c6ae
caps.latest.revision: 17
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Create an email using a template

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. Download the complete sample from [Sample: Work with Templates](https://code.msdn.microsoft.com/Templates-Samples-1759ff39).  
  
## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to instantiate an email record by using the <xref:Microsoft.Crm.Sdk.Messages.InstantiateTemplateRequest> message.  
  
## Example  
 [!code-csharp[Templates#CreateEmailUsingTemplate](../snippets/csharp/CRMV8/templates/cs/createemailusingtemplate.cs#createemailusingtemplate)]  
  
### See also  
 [Sample Code for Activity](sample-code-activity-entities.md)   
 [EMail Activity Entities](email-activity-entities.md)   
 [Email Entity](entities/email.md)   
 [Template Entity](entities/template.md)   
 [Sample: Work with Activity Party Records](sample-work-activity-party-records.md)   
    
<xref:Microsoft.Xrm.Sdk.IOrganizationService>   
 <xref:Microsoft.Crm.Sdk.Messages.InstantiateTemplateRequest>
