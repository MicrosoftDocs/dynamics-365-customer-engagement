---
title: "Sample: Override goal total count and close the goal (Developer Guide for Dynamics 365 for Customer Engagement)| MicrosoftDocs"
description: "This sample demonstrates how to override the goal total count and close the goal"
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
helpviewer_keywords: 
  - Sample for overriding total counts and closing goals
  - goal management entities samples, overriding total counts and closing goals
ms.assetid: c454269e-9e58-47f4-abbc-7bbe9e8d636c
caps.latest.revision: 17
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Override goal total count and close the goal

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. [Download the Goals samples](https://code.msdn.microsoft.com/Goals-Samples-539b2a34). 

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
   
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to override the goal total count and close the goal.  
  
## Example  
 [!code-csharp[Goals#OverrideGoalTotalCount](../snippets/csharp/CRMV8/goals/cs/overridegoaltotalcount.cs#overridegoaltotalcount)]  
  
### See also  
 [Goal Management Entities](goal-management-entities.md)   
 <xref:Microsoft.Crm.Sdk.Messages.RecalculateRequest>
