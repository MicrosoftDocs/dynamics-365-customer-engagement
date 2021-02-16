---
title: "Sample: Determine whether a user has a role (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The sample shows how to determine whether a user in Dynamics 365 Customer Engagement has been associated with a specific role."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 8976b75c-197d-4d80-b9fe-d4d7a4dfc0f5
caps.latest.revision: 18
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Sample: Determine whether a user has a role

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. Download the complete sample from [Work with Users and Roles](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/UsersAndRoles).  

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to determine whether a user in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] has been associated with a specific role. This is performed by using a query with the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*> method. A snippet that shows the key sections of the sample is shown first, followed by the [complete sample code](sample-create-on-premises-user.md#complete_sample). Note that this sample can only be run in an on-premises environment because it creates a user. However, the section of the sample that demonstrates retrieving the roles for a user will work for all environments.  

[!INCLUDE[cc_sdk_onpremises_note](../includes/cc-sdk-onpremises-note.md)]

## Example  
 [!code-csharp[UsersAndRoles#DoesUserBelongToRole1](../snippets/csharp/CRMV8/usersandroles/cs/doesuserbelongtorole1.cs#doesuserbelongtorole1)]  
  
<a name="complete_sample"></a>   
### Complete Sample Code  
 [!code-csharp[UsersAndRoles#DoesUserBelongToRole](../snippets/csharp/CRMV8/usersandroles/cs/doesuserbelongtorole.cs#doesuserbelongtorole)]  
  
### See also  
 [Privilege and Role Entities](privilege-role-entities.md)   
 [Sample: Remove a Role for a User](sample-remove-role-user.md)   
 [User and Team Entities](user-team-entities.md)   
    


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]