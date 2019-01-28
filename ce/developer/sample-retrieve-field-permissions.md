---
title: "Sample: Retrieve field permissions (Developer Guide for Dynamics 365 for Customer Engagement) | MicrosoftDocs"
description: "The sample shows how to retrieve secured fields for a user according to the steps outlined in Field security entities."
ms.custom: 
ms.date: 12/15/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
helpviewer_keywords: 
  - field security entities sample, enabling
  - enabling field security, sample
ms.assetid: acb20fc8-4b62-4e92-b105-7d832c56d007
caps.latest.revision: 20
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Retrieve field permissions

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. Download the complete sample here [Work with Field security entities](https://code.msdn.microsoft.com/Work-with-Field-Security-a18489bf). 

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to retrieve secured fields for a user according to the steps outlined in [Field security entities](field-security-entities.md).  
  
## Example  
 [!code-csharp[FieldSecurity#RetrieveSecuredFieldsForAUser1](../snippets/csharp/CRMV8/fieldsecurity/cs/retrievesecuredfieldsforauser1.cs#retrievesecuredfieldsforauser1)]  
  
### See also  
 [How Field Security Can Be Used to Control Access to Field Values In Dynamics 365 for Customer Engagement apps](security-dev/use-field-security-control-access-field-values.md)   
 [Field Security Entities](field-security-entities.md)   
<xref:Microsoft.Xrm.Sdk.IOrganizationService>
