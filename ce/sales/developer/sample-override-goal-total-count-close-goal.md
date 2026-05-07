---
title: Override goal total count and close the goal (Sample)
description: This sample demonstrates how to override the goal total count and close the goal.
ms.date: 04/30/2026
ms.topic: sample
applies_to: 
  - Dynamics 365 Sales
author: udaykirang
ms.author: udag
ms.reviewer: udag
search.audienceType: 
  - developer
---

# Sample: Override goal total count and close the goal

This sample shows how to override the goal total count and close the goal. You can download the sample from [here](https://github.com/Microsoft/PowerApps-Samples/tree/master/dataverse/orgsvc/C%23/OverrideGoalTotal).

This sample requires additional users that aren't in your system. Create the required user **as is** shown in the following section manually in **Office 365**. Replace `yourorg` with the `OrgName` of your organization.

**First Name**: Samantha<br/>
**Last Name**: Smith<br/>
**Security Role**: Marketing Manager<br/>
**UserName**: ssmith@yourorg.onmicrosoft.com<br/>

## How to run this sample

[!include[cc-how-to-run-samples](../../includes/cc-how-to-run-PA-samples.md)]

## What this sample does

This sample shows how to override the goal total count and close the goal.

## How this sample works

To simulate the scenario described in [What this sample does](#what-this-sample-does), the sample app performs the following steps:

### Setup

1. Checks for the version of the org.
1. Retrieves the sales manager user created manually in **Office 365**.
1. Creates a `PhoneCall` row and supporting account row for the sample.
1. Creates ActivityPartys for the phone calls "From" field.
1. Creates an open phone call.
1. Closes the first phone call and creates a second one.
1. Closes the second phone call.

### Demonstrate

1. Creates Metric, and sets the Metric type to `count` and also sets `IsAmount` to false.
1. The `RollupFields` creates a rollup field which targets completed (received) phone calls.
1. The `GoalRollupQuery` creates the goal rollup queries, locating the incoming and outgoing closed phone calls. 
1. Creates a goal to track the open incoming phone calls.
1. The `RecalculateRequest` calculates the rollup for goals. 
1. Overrides the actual and in-progress values of the goal.
1. Sets `goal.IsOverridden =true` to prevent the rollup values from being overwritten during the next recalculate operation.

### Clean up

Display an option to delete the sample data created in [Setup](#setup). The deletion is optional in case you want to examine the tables and data created by the sample. You can manually delete the rows to achieve the same result.


[!INCLUDE[footer-include](../../includes/footer-banner.md)]

