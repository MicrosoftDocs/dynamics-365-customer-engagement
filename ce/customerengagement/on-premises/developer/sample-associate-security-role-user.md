---
title: "Sample: Associate a Security Role to a User (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The sample shows how to associate a role with a user by using the IOrganizationService.EntityReferenceCollection) method."
keywords: 
ms.date: 10/31/2017
ms.service: crm-online
ms.custom: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: c962101c-65f0-4e49-8c23-99c2a9e7dcbf
author: JimDaly
ms.author: nabuthuk
manager: kvivek
ms.reviewer: pehecke
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 17
topic-status: Drafting
search.audienceType: 
  - developer

---

# Sample: Associate a Security Role to a User

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)].

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  

 This sample shows how to associate a role with a user by using the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Associate*> method. A snippet showing just the key portions of the sample is shown first, followed by the [Complete Sample Code](sample-create-on-premises-user.md#complete_sample). Note that this sample can only be run in an on-premises environment because it creates a user. However, the section of the sample that demonstrates associating a role with a user will work for all environments.  
  
[!INCLUDE[cc_sdk_onpremises_note](../includes/cc-sdk-onpremises-note.md)] 
## Example  
 [!code-csharp[UsersAndRoles#AddRoleToUser1](../snippets/csharp/CRMV8/usersandroles/cs/addroletouser1.cs#addroletouser1)]  
  
<a name="complete_sample"></a>   
### Complete Sample Code  
 [!code-csharp[UsersAndRoles#AddRoleToUser](../snippets/csharp/CRMV8/usersandroles/cs/addroletouser.cs#addroletouser)]  
  
### See also  
 [Privilege and Role Entities](privilege-role-entities.md)   
 [Sample: Determine Whether a User has a Role](sample-determine-user-role.md)   
 [User and Team Entities](user-team-entities.md)   
<xref:Microsoft.Xrm.Sdk.IOrganizationService>   
   


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]