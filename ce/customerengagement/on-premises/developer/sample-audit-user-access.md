---
title: "Sample: Audit user access (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Sample demonstrating the auditing of user access to records."
keywords: 
ms.date: 03/29/2019
ms.service: crm-online
ms.custom: audit
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: db508858-7386-44f3-9f91-29493e6fe2c4
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.reviewer: pehecke
ms.suite: 
ms.tgt_pltfrm: 
helpviewer_keywords: 
  - auditing entity data changes in Microsoft Dynamics CRM, sample for auditing user access
  - sample for auditing user access
  - auditing user access sample
topic-status: Drafting
search.audienceType: 
  - developer
search.app: 
  - D365CE
---

# Sample: Audit user access

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. [Download the code samples of audit entity data changes and audit user access](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/Auditing).  

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
 [!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)] This sample requires the logged on user to have the System Administrator role for enabling auditing on an organization.  
  
## Demonstrates  
 This sample demonstrates how to audit user access to [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].  
  
## Example  
 The sample first enables user access auditing with the logged on user’s organization. Next, it creates and modifies an account entity so that audit records are generated. Finally, the sample displays the audited information.  
  
 [!code-csharp[auditing#useraccessauditing](../snippets/csharp/CRMV8/auditing/cs/useraccessauditing.cs#useraccessauditing)]  
  
### See also  
 [Audit Entity Data Changes in Dynamics 365 Customer Engagement (on-premises)](audit-entity-data-changes.md)   
 [Audit Entity](entities/audit.md)<!-- Bug 696490 -->
