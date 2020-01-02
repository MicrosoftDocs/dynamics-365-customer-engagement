---
title: "Sample: Override goal total count and close the goal (Developer Guide for Dynamics 365 Customer Engagement (on-premises))| MicrosoftDocs"
description: "This sample demonstrates how to override the goal total count and close the goal"
ms.custom: 
ms.date: 01/02/2020
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - Sample for overriding total counts and closing goals
  - goal management entities samples, overriding total counts and closing goals
ms.assetid: c454269e-9e58-47f4-abbc-7bbe9e8d636c
author: KumarVivek
ms.author: kvivek
manager: annbe
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Override goal total count and close the goal

This sample code is for Dynamics 365 Customer Engagement(on-premises). [Download the Goals samples](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/sales/OverrideGoalCountClose).

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
