---
title: "Sample: Associate a security role to a team (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The sample shows how to assign a security role to a team by using the AssignRequest message."
ms.custom: 
ms.date: 12/15/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - assigning a role to a team, sample
  - assigning a security role, sample
  - team security sample, assigning roles
ms.assetid: 6097b89f-b3a6-472b-8fed-4f1aef62817f
caps.latest.revision: 21
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Associate a security role to a team

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. Download the Sample: [Work with early bound entity classes in code](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/EarlyBound). 

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to assign a security role to a team by using the <xref:Microsoft.Crm.Sdk.Messages.AssignRequest> message. Note that this example does not take into consideration that a team or user can only be assigned a role from its business unit. The role to be assigned is the first from the collection that is returned by the `RetrieveMultiple` method. If that record is from a business unit that is different from the requesting team, the assignment fails.  
  
## Example  
 [!code-csharp[StrongTypes#AssignSecurityRoleToTeam1](../snippets/csharp/CRMV8/strongtypes/cs/assignsecurityroletoteam1.cs#assignsecurityroletoteam1)]  
  
### See also  
 [Assign](introduction-entities.md#Assign)   
 [Privilege and Role Entities](privilege-role-entities.md)   
 [Sample: Associate a Security Role to a User](sample-associate-security-role-user.md)   
 [User and Team Entities](user-team-entities.md)   
 <xref:Microsoft.Crm.Sdk.Messages.AssignRequest>
