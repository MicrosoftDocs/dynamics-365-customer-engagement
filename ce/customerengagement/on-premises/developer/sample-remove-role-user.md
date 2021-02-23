---
title: "Sample: Remove a role for a user (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The sample shows how to disassociate a role from a user by using the IOrganizationService.EntityReferenceCollection) method."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 6f25132e-30d2-4a20-9395-3e42aafdd959
caps.latest.revision: 16
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Sample: Remove a role for a user

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. Download the complete sample from [Sample: Work with Users and Roles](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/UsersAndRoles).  

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to disassociate a role from a user by using the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Disassociate*> method. A snippet showing just the key sections of the sample is shown first, followed by the [complete sample code](sample-create-on-premises-user.md#complete_sample). Note that this sample can only be run in an on-premises environment because it creates a user. However, the section of the sample that demonstrates disassociating a role from a user will work for all environments.  
  
[!INCLUDE[cc_sdk_onpremises_note](../includes/cc-sdk-onpremises-note.md)]

## Example  
 [!code-csharp[UsersAndRoles#RemoveRoleFromUser1](../snippets/csharp/CRMV8/usersandroles/cs/removerolefromuser1.cs#removerolefromuser1)]  
  
<a name="complete_sample"></a>   
### Complete sample code  
 [!code-csharp[UsersAndRoles#RemoveRoleFromUser](../snippets/csharp/CRMV8/usersandroles/cs/removerolefromuser.cs#removerolefromuser)]  
  
### See also  
 [Privilege and Role Entities](privilege-role-entities.md)   
 [Sample: Retrieve the Roles for an Organization](sample-retrieve-roles-organization.md)   
 [User and Team Entities](user-team-entities.md)   
<xref:Microsoft.Xrm.Sdk.IOrganizationService>   
    
 


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]