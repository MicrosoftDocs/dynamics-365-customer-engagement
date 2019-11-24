---
title: "Sample: Retrieve email attachments for an email template (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "This sample shows how to retrieve email attachments associated with an email template by using the IOrganizationService.QueryBase) method"
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
  - sample for retrieving email attachments associated with email templates, activity entities
  - activity entities samples, retrieving email attachments associated with email templates
ms.assetid: 4efd5301-9f7b-426d-b2f8-54c71ed04585
caps.latest.revision: 26
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Retrieve email attachments for an email template

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. Download the complete sample from [Sample: Templates](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/Templates).    
 
## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
   
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to retrieve email attachments associated with an email template by using the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*> method.  
  
## Example  
 [!code-csharp[Templates#GetEmailTemplateAttachments](../snippets/csharp/CRMV8/templates/cs/getemailtemplateattachments.cs#getemailtemplateattachments)]  
  
### See also  
 [E-Mail Attachments](email-activity-entities.md#E-MailAttachments)   
 [Template Entity](entities/template.md)   
    
 [Sample Code for Recurring Appointments](sample-code-schedule-appointment-entities.md)   
 [Sample: Convert a Fax to a Task](sample-convert-fax-task.md)   
<xref:Microsoft.Xrm.Sdk.IOrganizationService>
