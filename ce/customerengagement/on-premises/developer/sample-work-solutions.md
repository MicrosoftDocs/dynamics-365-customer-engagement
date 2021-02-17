---
title: "Sample: Work with solutions (Dynamics 365 Customer Engagement (on-premises) SDK)| MicrosoftDocs"
description: ""
keywords: 
ms.date: 04/02/2020
ms.service: crm-online
ms.custom: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: a3008ed8-a934-4790-9979-43be7b5e7aaf
author: JimDaly
ms.author: nabuthuk
manager: kvivek
ms.reviewer: pehecke
ms.suite: 
ms.tgt_pltfrm: 
helpviewer_keywords: 
  - solution entities samples
  - samples for working with solutions, deleting solutions
  - samples for working with solutions, exporting or packaging solutions
  - samples for working with solutions, retrieving default publishers
  - samples for working with solutions, adding existing solution components
  - samples for working with solutions, creating publishers
  - sample for working with solutions
  - samples for working with solutions, creating solutions
  - samples for working with solutions, retrieving solutions
  - sample for solutions, see samples for working with solutions
  - samples for working with solutions, removing solution components
  - samples for working with solutions, installing or upgrading solutions
  - working with solutions samples
topic-status: Drafting
search.audienceType: 
  - developer

---

# Sample: Work with solutions

[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Sample: Work with solutions](/powerapps/developer/common-data-service/org-service/samples/work-solutions).

This sample shows how to perform the following actions with solutions:

- Create a publisher.
- Retrieve the default publisher.
- Create a solution.
- Retrieve a solution.
- Add an existing solution component.
- Remove a solution component.
- Export or package a solution.
- Install or upgrade a solution.
- Delete a solution.

You can download the sample from [here](https://github.com/Microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/WorkwithSolutions).

[!include[cc-sample-note](includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-PA-samples.md)]

## What this sample does

This sample shows how to work with solutions. This sample covers how to create a publisher, create a solution, export, and import solution and also how to delete the solution.

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

1. Checks for the current version of the org.
1. The `Publisher` method defines a new publisher. 
1. The `Solution` method creates a new solution.
1. The `OptionSetMetadata` method adds a solution component.
1. The `ExportSolutionRequest` method exports the created solution in the [Setup](#setup).
1. The `DeleteSolutionRequest` method deletes the solution and the components.


### Demonstrate

1. The `querySDKSamplePublisher` method checks whether the publisher is already in the system.
1. The `querySampleSolutionResults` method checks whether the solution is already in the system.
1. The `ExportSolutionRequest` method exports the solution. 
1. The `ImportSolutionRequest` method imports the solution.

### Clean up

Displays an option to delete all the data created in the sample. The deletion is optional in case you want to examine the data created by the sample. You can manually delete the data to achieve same results.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]