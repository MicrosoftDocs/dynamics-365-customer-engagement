---
title: "Sample: Share a record using an access team (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "The sample shows how to allow access to a record using an access team. All members of the team receive the same access to the record as is granted to the team."
keywords: 
ms.date: 12/15/2017
ms.service: crm-online
ms.custom: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 9b841889-c396-4f6e-8588-e702e94c7073
author: KumarVivek
ms.author: kvivek
manager: jdaly
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 9
topic-status: Drafting
search.audienceType: 
  - developer
search.app: 
  - D365CE
---

# Sample: Share a record using an access team

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. Download the Sample: [Work with early bound entity classes in code](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/EarlyBound).  

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to allow access to a record using an access team. All members of the team receive the same access to the record as is granted to the team.  
  
## Example  
 [!code-csharp[strongtypes#CreateAndShareAccessTeam](../snippets/csharp/CRMV8/strongtypes/cs/createandshareaccessteam.cs#createandshareaccessteam)]  
  
### See also  
 [User and Team Entities](user-team-entities.md)   
 [Introduction to Entities in Dynamics 365 Customer Engagement (on-premises)](introduction-entities.md#Share)   
 <xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>   
 [Sample: Share Records Using GrantAccess, ModifyAccess and RevokeAccess Messages](sample-share-records-using-grantaccess-modifyaccess-revokeaccess-messages.md)
