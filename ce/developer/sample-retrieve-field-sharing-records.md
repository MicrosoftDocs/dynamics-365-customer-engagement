---
title: "Sample: Retrieve field sharing records (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The sample shows how to retrieve the PrincipalObjectAttributeAccess (field sharing) records for an entity. "
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "samples"
applies_to: 
  - "Dynamics 365 (online)"
helpviewer_keywords: 
  - "secured field-access records sample, retrieving"
  - "PrincipalObjectAttributeAccess entity sample, using to enable field security"
  - "using the PrincipalObjectAttributeAccess entity to enable field security"
  - "retrieving secured field-access records, sample"
ms.assetid: 5b23d413-c69a-4568-a490-09454362417b
caps.latest.revision: 16
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Sample: Retrieve field sharing records

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. Download the complete sample here [Sample: Retrieve field sharing records](https://code.msdn.microsoft.com/Sample-Retrieve-field-e793c68f)  

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Example  
 This sample shows how to retrieve the `PrincipalObjectAttributeAccess` (field sharing) records for an entity.  
  
 [!code-csharp[FieldSecurity#RetrieveUserSharedAttributePermissions1](../snippets/csharp/CRMV8/fieldsecurity/cs/retrieveusersharedattributepermissions1.cs#retrieveusersharedattributepermissions1)]  
  
### See also  
 [How Field Security Can Be Used to Control Access to Field Values in Dynamics 365](security-dev/use-field-security-control-access-field-values.md)   
 [Field Security Entities](field-security-entities.md)   
<xref:Microsoft.Xrm.Sdk.IOrganizationService>