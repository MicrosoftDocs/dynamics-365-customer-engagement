---
title: "Sample: Send an email (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "This sample shows how to send an email SendEmailRequest message"
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
  - sample for sending email messages, activity entities
  - activity entities samples, sending email messages
ms.assetid: c95bec08-bdd2-420a-93aa-ee7c0f20fa16
caps.latest.revision: 18
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Send an email

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. Download the complete sample from [Sample: Work with Activity entities](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/Activities).

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
    
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to send an email <xref:Microsoft.Crm.Sdk.Messages.SendEmailRequest> message.  
  
## Example  
 [!code-csharp[Activities#SendEmail](../snippets/csharp/CRMV8/activities/cs/sendemail.cs#sendemail)]  
  
### See also  
 [Sample Code for Activity](sample-code-activity-entities.md)   
 [Sample: Create an Email Using a Template](sample-create-email-template.md)   
 [E-mail Activity Entities](email-activity-entities.md)   
 [Email Entity](entities/email.md)   
    
<xref:Microsoft.Xrm.Sdk.IOrganizationService>   
 <xref:Microsoft.Crm.Sdk.Messages.SendEmailRequest>
