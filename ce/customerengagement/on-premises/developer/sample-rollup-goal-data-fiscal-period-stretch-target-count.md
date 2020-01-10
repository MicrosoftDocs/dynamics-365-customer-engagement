---
title: "Sample: Rollup goal data for a fiscal period against the stretch target count (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "This sample shows how to roll up goal data for a fiscal period against stretch target count representing a number of completed telephone calls"
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
  - goal management entities samples, rolling up goal data in a fiscal period against stretch targets
  - sample for rolling up goal data in a fiscal period against stretch targets
ms.assetid: 2f1e1939-7dd3-4a12-92b2-13fb166c0dea
caps.latest.revision: 20
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Rollup goal data for a fiscal period against the stretch target count

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. [Download the Goals samples](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/Goals). 

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
   
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to roll up goal data for a fiscal period against stretch target count representing a number of completed telephone calls.  
  
## Example  
 [!code-csharp[Goals#RollupAllGoalsForFiscalPeriodAndStretchedTargetRevenue](../snippets/csharp/CRMV8/goals/cs/rollupallgoalsforfiscalperiodandstretchedtargetrevenue.cs#rollupallgoalsforfiscalperiodandstretchedtargetrevenue)]  
  
### See also  
 [Goal Management Entities](goal-management-entities.md)   
 <xref:Microsoft.Crm.Sdk.Messages.RecalculateRequest>   
 [Sample: Use Rollup Queries to Track Goals](sample-use-rollup-queries-track-goals.md)
