---
title: "Sample: Rollup goal data for a fiscal period against the stretch target count (Dynamics 365 Sales)"
description: Learn how to roll up goal data for a fiscal period against stretch target count for completed phone calls, and run this sample to validate results.
ms.custom: 
ms.date: 03/01/2023 
ms.topic: sample
applies_to: 
  - Dynamics 365 Sales
author: udaykirang
ms.author: udag
ms.reviewer: udag
search.audienceType: 
  - developer
---

# Sample: rollup goal data for a fiscal period against the stretch target count

This sample shows how to roll up goal data for a fiscal period against the stretch target count, representing a number of completed phone calls. You can download the sample from [GoalDataForFiscalYear](https://github.com/Microsoft/PowerApps-Samples/tree/master/dataverse/orgsvc/C%23/GoalDataForFiscalYear).

This sample requires additional users that aren't in your system. Create the three required users **as is** shown in the following table manually in **Office 365**. Replace `yourorg` with the organization name.

**First Name**: Nancy<br/>
**Last Name**: Anderson<br/>
**Security Role**: Salesperson<br/>
**UserName**: nanderson@yourorg.onmicrosoft.com<br/>

**First Name**: David<br/>
**Last Name**: Bristol<br/>
**Security Role**: Salesperson<br/>
**UserName**: dbristol@yourorg.onmicrosoft.com<br/>

**First Name**: Kevin<br/>
**Last Name**: Cook<br/>
**Security Role**: SalesManager<br/>
**UserName**: kcook@yourorg.onmicrosoft.com<br/>

## How to run this sample

[!include[cc-how-to-run-samples](../../includes/cc-how-to-run-PA-samples.md)]

## What this sample does

This sample shows how to roll up goal data for a fiscal period against the stretch target count representing a number of completed telephone calls.

## How this sample works

To simulate the scenario described in [What this sample does](#what-this-sample-does), the sample app performs the following steps:

### Setup

1. Checks the version of the org.
1. Retrieves the sales manager and two sales representatives, created manually in **Office 365**.
1. Creates a `PhoneCall` row and supporting account row for the sample.
1. Creates ActivityPartys for the phone calls **From** field.
1. Creates an open phone call.
1. Closes the first phone call and creates a second one.
1. Closes the second phone call.

### Demonstrate

1. Creates Metric, sets the Metric type to **count**, and enables stretch tracking.
1. Creates a rollup field that targets completed (received) phone calls.
1. The `GoalRollupQuery` creates the goal rollup queries, locating the incoming and outgoing closed phone calls. 
1. Creates three goals: one parent goal and two child goals.
1. The `RecalculateRequest` calculates the rollup for goals. 

### Clean up

The sample displays an option to delete the sample data created in [Setup](#setup). The deletion is optional in case you want to examine the tables and data created by the sample. You can manually delete the records to achieve the same result.



[!INCLUDE[footer-include](../../includes/footer-banner.md)]
