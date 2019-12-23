---
title: "Sample: Detect solution dependencies (Dynamics 365 Customer Engagement (on-premises) SDK)| MicrosoftDocs"
description: ""
keywords: 
ms.date: 10/31/2017
ms.service: crm-online
ms.custom: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: d347f96b-a137-42e1-a9bf-fac6d6133330
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.reviewer: "pehecke"
ms.suite: 
ms.tgt_pltfrm: 
helpviewer_keywords: 
  - detecting solution dependencies sample
  - sample for detecting solution dependencies
  - solution entities samples, detecting solution dependencies sample
topic-status: Drafting
search.audienceType: 
  - developer
search.app: 
  - D365CE
---

# Sample: Detect solution dependencies

This sample code is for Dynamics 365 Customer Engagement (on-premises). Download the sample: [Work with solutions](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/Solutions).

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to how to detect dependencies before you delete a solution component.  
  
## Example  
 [!code-csharp[solutions#GetSolutionDependencies](../snippets/csharp/CRMV8/solutions/cs/getsolutiondependencies.cs#getsolutiondependencies)]  
  
### See also  
 [Package and Distribute Extensions with Dynamics 365 Customer Engagement (on-premises) Solutions](package-distribute-extensions-use-solutions.md)   
 [Introduction to Solutions](introduction-solutions.md)   
 [Plan For Solution Development](plan-solution-development.md)   
 [Dependency Tracking for Solution Components](dependency-tracking-solution-components.md)   
 [Create, Export, or Import an Unmanaged Solution](create-export-import-unmanaged-solution.md)   
 [Create, Install, and Update a Managed Solution](create-install-update-managed-solution.md)   
 [Uninstall or Delete a solution](uninstall-delete-solution.md)   
 [Solution Entities](solution-entities.md)   
 [Work with Solutions](work-solutions.md)   
 [Sample: Work With Solutions](sample-work-solutions.md)
