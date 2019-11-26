---
title: "Sample: Retrieve the roles for an organization (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The sample shows how to retrieve the roles for an organization by using the IOrganizationService.QueryBase) method."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 8b0e6460-46cb-436b-b689-91f11085b8c7
caps.latest.revision: 13
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Retrieve the roles for an organization

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. Download the complete sample from [Sample: Work with Users and Roles](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/UsersAndRoles).   

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to retrieve the roles for an organization by using the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*> method. A snippet that shows just the key sections of the sample is shown first, followed by the [complete sample code](sample-create-on-premises-user.md#complete_sample).  
  
## Example  
 [!code-csharp[UsersAndRoles#RetrieveRolesForOrg1](../snippets/csharp/CRMV8/usersandroles/cs/retrieverolesfororg1.cs#retrieverolesfororg1)]  
  
<a name="complete_sample"></a>   
### Complete sample code  
 [!code-csharp[UsersAndRoles#RetrieveRolesForOrg](../snippets/csharp/CRMV8/usersandroles/cs/retrieverolesfororg.cs#retrieverolesfororg)]  
  
### See also  
 [Privilege and Role Entities](privilege-role-entities.md)   
<xref:Microsoft.Xrm.Sdk.IOrganizationService>   
 
