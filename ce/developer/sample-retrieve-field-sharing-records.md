---
title: "Sample: Retrieve field sharing records (Developer Guide for Dynamics 365 for Customer Engagement apps) | MicrosoftDocs"
description: "The sample shows how to retrieve the PrincipalObjectAttributeAccess (field sharing) records for an entity. "
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
  - secured field-access records sample, retrieving
  - PrincipalObjectAttributeAccess entity sample, using to enable field security
  - using the PrincipalObjectAttributeAccess entity to enable field security
  - retrieving secured field-access records, sample
ms.assetid: 5b23d413-c69a-4568-a490-09454362417b
caps.latest.revision: 16
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Retrieve field sharing records

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. Download the complete sample here [Work with Field security entities](https://code.msdn.microsoft.com/Work-with-Field-Security-a18489bf)  

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Example  
 This sample shows how to retrieve the `PrincipalObjectAttributeAccess` (field sharing) records for an entity.  
  
 [!code-csharp[FieldSecurity#RetrieveUserSharedAttributePermissions1](../snippets/csharp/CRMV8/fieldsecurity/cs/retrieveusersharedattributepermissions1.cs#retrieveusersharedattributepermissions1)]  
  
### See also  
 [How Field Security Can Be Used to Control Access to Field Values in Dynamics 365 for Customer Engagement apps](security-dev/use-field-security-control-access-field-values.md)   
 [Field Security Entities](field-security-entities.md)   
<xref:Microsoft.Xrm.Sdk.IOrganizationService>
