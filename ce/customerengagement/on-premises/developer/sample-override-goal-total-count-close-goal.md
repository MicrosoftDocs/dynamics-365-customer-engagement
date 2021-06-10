---
title: "Sample: Override goal total count and close the goal| MicrosoftDocs"
description: "This sample demonstrates how to override the goal total count and close the goal"
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
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
caps.latest.revision: 17
author: JimDaly
ms.author: nabuthuk
manager: kvivek
search.audienceType: 
  - developer

---
# Sample: Override goal total count and close the goal

This sample shows how to override the goal total count and close the goal. You can download the sample from [here](https://github.com/Microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/OverrideGoalTotal).

This sample requires additional users that are not in your system. Create the required user **as is** shown below manually in **Office 365**. Replace `yourorg` with the `OrgName` of your organization.

**First Name**: Samantha<br/>
**Last Name**: Smith<br/>
**Security Role**: Marketing Manager<br/>
**UserName**: ssmith@yourorg.onmicrosoft.com<br/>

[!include[cc-sample-note](includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-PA-samples.md)]

## What this sample does

This sample shows how to override the goal total count and close the goal.

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

1. Checks for the version of the org.
2. Retrieves the sales manager user created manually in **Office 365**.
3. Creates a `PhoneCall` record and supporting account record for the sample.
4. Creates ActivityPartys for the phone calls "From" field.
5. Creates an open phone call.
6. Closes the first phone call and creates a second one.
7. Closes the second phone call.

### Demonstrate

1. Creates Metric, and setting the Metric type to `count` and also setting `IsAmount` to false.
2. The `RollupFields` creates a rollup field which targets completed (received) phone calls.
3. The `GoalRollupQuery` creates the goal rollup queries, locating the incoming and outgoing closed phone calls. 
4. Creates a goal to track the open incoming phone calls.
5. The `RecalculateRequest` calculates the rollup for goals. 
6. Overrides the actual and in-progress values of the goal.
7. Set `goal.IsOverridden =true` prevents the rollup values to be overwritten during the next recalculate operation.

### Clean up

Display an option to delete the sample data created in [Setup](#setup). The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the records to achieve the same result.

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]