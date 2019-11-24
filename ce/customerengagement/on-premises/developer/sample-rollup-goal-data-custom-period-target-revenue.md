---
title: "Sample: Rollup goal data for a custom period against the target revenue (Developer Guide for Dynamics 365 Customer Engagement (on-premises))| MicrosoftDocs"
description: "This sample shows how to roll up goal data for a custom period against the target revenue"
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - goal management entities samples, rolling up goal data in a custom period against revenue targets
  - sample for rolling up goal data in a custom period against revenue targets
ms.assetid: 87b5756c-b24c-4140-a3c3-3660d1cb3e01
caps.latest.revision: 22
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Rollup goal data for a custom period against the target revenue

This sample code is for Dynamics 365 Customer Engagement(on-premises). [Download the Goals samples](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/Goals).

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
   
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to roll up goal data for a custom period against the target revenue.  
  
## Example  
 [!code-csharp[Goals#RollupAllGoalsForCustomPeriodAgainstTargetRevenue](../snippets/csharp/CRMV8/goals/cs/rollupallgoalsforcustomperiodagainsttargetrevenue.cs#rollupallgoalsforcustomperiodagainsttargetrevenue)]  
  
### See also  
 [Goal Management Entities](goal-management-entities.md)   
 <xref:Microsoft.Crm.Sdk.Messages.RecalculateRequest>   
 [Sample: Rollup goal data for a fiscal period against the stretch target count](sample-rollup-goal-data-fiscal-period-stretch-target-count.md)
