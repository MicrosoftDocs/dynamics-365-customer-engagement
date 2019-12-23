---
title: "Sample: Assign a record to a team (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "The sample shows how to assign a record to a team by using the AssignRequest message. "
keywords: 
ms.date: 12/15/2017
ms.service: crm-online
ms.custom: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 0537eac1-c997-4091-970f-e726109b1247
author: KumarVivek
ms.author: kvivek
manager: jdaly
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
helpviewer_keywords: 
  - assigning records sample, team entity
  - users and teams, assigning records sample
  - assigning records sample, system user entity
topic-status: Drafting
search.audienceType: 
  - developer
search.app: 
  - D365CE
---

# Sample: Assign a record to a team

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. Download the Sample: [Work with early bound entity classes in code](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/EarlyBound).

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to assign a record to a team by using the <xref:Microsoft.Crm.Sdk.Messages.AssignRequest> message.  
  
## Example  
 [!code-csharp[strongtypes#AssignRecordToTeam](../snippets/csharp/CRMV8/strongtypes/cs/assignrecordtoteam.cs#assignrecordtoteam)]  
  
### See also  
 <xref:Microsoft.Crm.Sdk.Messages.AssignRequest>   
 [Entity Ownership](introduction-entities.md#EntityOwnership)   
 [Assign](introduction-entities.md#Assign)   
 [User and Team Entities](user-team-entities.md)   
 [Introduction to Entities in Dynamics 365 Customer Engagement (on-premises)](introduction-entities.md)   
 [Sample: Share Records Using GrantAccess, ModifyAccess and RevokeAccess Messages](sample-share-records-using-grantaccess-modifyaccess-revokeaccess-messages.md)
