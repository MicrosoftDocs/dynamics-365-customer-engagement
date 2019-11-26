---
title: "Sample: Retrieve valid status transitions (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The sample demonstrates how to retrieve valid state transitions regardless of whether custom state transitions have been defined for the entity."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: d367aa6d-36dc-4084-8625-50f515602504
caps.latest.revision: 8
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Retrieve valid status transitions

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. Download the complete sample of [work with attribute metadata](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/Attributes). 

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to retrieve valid state transitions regardless of whether custom state transitions have been defined for the entity.  
  
 The sample does the following tasks:  
  
1. Retrieves status options for the Incident entity  
  
2. Uses a `GetValidStatusOptions` method in the sample to get valid status transitions for each status option  
  
3. Displays the valid transition options in the console  
  
   When status reason transitions for the incident entity are configured in the following way:  
  
   ![Example of status reason transitions for case](media/status-reason-transitions-example.PNG "Example of status reason transitions for case")  
  
   The valid state transitions are filtered and you will see the following representing all the valid transitions for each status option.  
  
```ms-dos
[In Progress] incident records can transition to:  
2  Canceled  1    Canceled  
2  Canceled  1    Merged  
0  Active    1    On Hold  
  
[On Hold] incident records can transition to:  
2  Canceled  2    Canceled  
2  Canceled  2    Merged  
0  Active    2    Waiting for Details  
  
[Waiting for Details] incident records can transition to:  
2  Canceled  3    Canceled  
2  Canceled  3    Merged  
0  Active    3    Researching  
  
[Researching] incident records can transition to:  
2  Canceled  4    Canceled  
1  Resolved  4    Information Provided  
1  Resolved  4    Problem Solved  
2  Canceled  4    Merged  
  
[Problem Solved] incident records can transition to:  
2  Canceled  5    Merged  
  
[Information Provided] incident records can transition to:  
2  Canceled  1000 Merged  
  
[Canceled] incident records can transition to:  
2  Canceled  6    Merged  
  
[Merged] incident records can transition to:  
```  
  
 When this sample is run without status reason transitions applied on the incident entity you will see the following representing all the possible transitions for each status.  
  
```ms-dos
[Problem Solved] incident records can transition to:  
1  Resolved  1000 Information Provided  
2  Canceled  6    Canceled  
2  Canceled  2000 Merged  
0  Active    1    In Progress  
0  Active    2    On Hold  
0  Active    3    Waiting for Details  
0  Active    4    Researching  
  
[Information Provided] incident records can transition to:  
1  Resolved  5    Problem Solved  
2  Canceled  6    Canceled  
2  Canceled  2000 Merged  
0  Active    1    In Progress  
0  Active    2    On Hold  
0  Active    3    Waiting for Details  
0  Active    4    Researching  
  
[Canceled] incident records can transition to:  
1  Resolved  5    Problem Solved  
1  Resolved  1000 Information Provided  
2  Canceled  2000 Merged  
0  Active    1    In Progress  
0  Active    2    On Hold  
0  Active    3    Waiting for Details  
0  Active    4    Researching  
  
[Merged] incident records can transition to:  
1  Resolved  5    Problem Solved  
1  Resolved  1000 Information Provided  
2  Canceled  6    Canceled  
0  Active    1    In Progress  
0  Active    2    On Hold  
0  Active    3    Waiting for Details  
0  Active    4    Researching  
  
[In Progress] incident records can transition to:  
1  Resolved  5    Problem Solved  
1  Resolved  1000 Information Provided  
2  Canceled  6    Canceled  
2  Canceled  2000 Merged  
0  Active    2    On Hold  
0  Active    3    Waiting for Details  
0  Active    4    Researching  
  
[On Hold] incident records can transition to:  
1  Resolved  5    Problem Solved  
1  Resolved  1000 Information Provided  
2  Canceled  6    Canceled  
2  Canceled  2000 Merged  
0  Active    1    In Progress  
0  Active    3    Waiting for Details  
0  Active    4    Researching  
  
[Waiting for Details] incident records can transition to:  
1  Resolved  5    Problem Solved  
1  Resolved  1000 Information Provided  
2  Canceled  6    Canceled  
2  Canceled  2000 Merged  
0  Active    1    In Progress  
0  Active    2    On Hold  
0  Active    4    Researching  
  
[Researching] incident records can transition to:  
1  Resolved  5    Problem Solved  
1  Resolved  1000 Information Provided  
2  Canceled  6    Canceled  
2  Canceled  2000 Merged  
0  Active    1    In Progress  
0  Active    2    On Hold  
0  Active    3    Waiting for Details  
```  
  
## Example  
 The following is the `GetValidStatusOptions` method used in the sample:  
  
 [!code-csharp[Attributes#StateModelTransitions.GetValidStatusOptions](../snippets/csharp/CRMV8/attributes/cs/statemodeltransitions.getvalidstatusoptions.cs#statemodeltransitions.getvalidstatusoptions)]  
  
## Example  
 The following is the full code for the sample.  
  
 [!code-csharp[Attributes#StateModelTransitions](../snippets/csharp/CRMV8/attributes/cs/statemodeltransitions.cs#statemodeltransitions)]  
  
### See also  
 [Define custom state model transitions](define-custom-state-model-transitions.md)
