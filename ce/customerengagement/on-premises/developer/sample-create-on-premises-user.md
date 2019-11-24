---
title: "Sample: Create an on-premises user (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
ms.custom: 
description: "The sample shows how to create a user in an Active Directory environment using the IOrganizationService.Entity) method. A snippet showing just the key sections of the sample is shown first, followed by the Complete Sample Code."
ms.date: 10/31/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: d3ea30ab-e55e-4aa7-8406-3441c71903a2
caps.latest.revision: 16
author: KumarVivek
ms.author: kvivek
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Create an on-premises user

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. Download the complete sample from [Sample: Work with Users and Roles](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/UsersAndRoles). 
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Demonstrates  
 This sample shows how to create a user in an [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] environment using the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*> method. A snippet showing just the key sections of the sample is shown first, followed by the [Complete Sample Code](sample-create-on-premises-user.md#complete_sample).  
  
## Example  
 [!code-csharp[UsersAndRoles#CreateAUser1](../snippets/csharp/CRMV8/usersandroles/cs/createauser1.cs#createauser1)]  
  
<a name="complete_sample"></a>   
### Complete Sample Code  
 [!code-csharp[UsersAndRoles#CreateAUser](../snippets/csharp/CRMV8/usersandroles/cs/createauser.cs#createauser)]  
  
### See also  
 [User and Team Entities](user-team-entities.md)   
    
 [Sample: Disable a User](sample-disable-user.md)
