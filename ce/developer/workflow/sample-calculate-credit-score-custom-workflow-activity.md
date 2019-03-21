---
title: "Sample: Calculate a credit score with a custom workflow activity (Developer Guide for Dynamics 365 for Customer Engagement) | MicrosoftDocs"
description: "The sample demonstrates workflow activity calculates the credit score based on the Social Security Number (SSN) and name."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: 9cb7eb41-1a73-44a8-ae58-14120e84243f
caps.latest.revision: 19
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Calculate a credit score with a custom workflow activity

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] Customer Engagement. Download the complete sample here [Custom workflow activities samples](https://code.msdn.microsoft.com/Custom-Workflow-Activities-eee57285).

## Prerequisites
[!INCLUDE[sdk-prerequisite](../../includes/sdk-prerequisite.md)]
  
## Requirements  
 The following customizations must exist for this custom workflow activity to work:  
  
- Entity Schema Name: new_loanapplication  
  
- Attribute: new_loanapplicationid as the primary key  
  
- Attribute: new_creditscore of type `int` with min of 0 and max of 1000 (if it is to be updated)  
  
- Attribute: new_loanamount of type money with default min/max  
  
- Customize the form to include the attribute new_loanapplicantid  
  
  The contact entity must have the following customizations:  
  
- Attribute: new_ssn as **Single Line of Text** with max length of 15  
  
- One-To-Many Relationship with these properties:  
  
  -   Relationship Definition Schema Name: new_loanapplicant  
  
  -   Relationship Definition Related Entity Display Name: Loan Application  
  
  -   Relationship Attribute Schema Name: new_loanapplicantid  
  
  -   Relationship Behavior Type: Referential  
  
## Demonstrates  
 The following sample workflow activity calculates the credit score based on the Social Security Number (SSN) and name.  
  
## Example  
 [!code-csharp[customworkflowactivities#ReleaseISVActivities4](../../snippets/csharp/CRMV8/customworkflowactivities/cs/releaseisvactivities4.cs#releaseisvactivities4)]  
  
### See also  
 [Custom Workflow Activities (Workflow Assemblies)](../custom-workflow-activities-workflow-assemblies.md)   
 [Add Metadata to a Custom Workflow Activity](add-metadata-custom-workflow-activity.md)
