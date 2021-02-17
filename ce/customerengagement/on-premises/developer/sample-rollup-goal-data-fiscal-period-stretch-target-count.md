---
title: "Sample: Rollup goal data for a fiscal period against the stretch target count (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "This sample shows how to roll up goal data for a fiscal period against stretch target count representing a number of completed telephone calls"
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
  - goal management entities samples, rolling up goal data in a fiscal period against stretch targets
  - sample for rolling up goal data in a fiscal period against stretch targets
ms.assetid: 2f1e1939-7dd3-4a12-92b2-13fb166c0dea
caps.latest.revision: 20
author: JimDaly
ms.author: nabuthuk
manager: kvivek
search.audienceType: 
  - developer

---
# Sample: Rollup goal data for a fiscal period against the stretch target count

This sample shows how to roll up goal data for a fiscal period against stretch target count, representing a number of completed phone calls. You can download the sample from [here](https://github.com/Microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/GoalDataForFiscalYear).

This sample requires additional users that are not in your system. Create the three required users **as is** shown below manually in **Office 365**. Replace `yourorg` with the organization name.

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

[!include[cc-sample-note](includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-PA-samples.md)]

## What this sample does

This sample shows how to roll up goal data for a fiscal period against stretch target count representing a number of completed telephone calls.

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

1. Checks for the version of the org.
2. Retrieves the sales manager and 2 sales representatives, created manually in **Office 365**.
3. Creates a `PhoneCall` record and supporting account record for the sample.
4. Creates ActivityPartys for the phone calls **From** field.
5. Creates an open phone call.
6. Closes the first phone call and creates a second one.
7. Closes the second phone call.

### Demonstrate

1. Creates Metric, and setting the Metric type to **count** and enabling stretch tracking.
2. Creates a rollup field which targets completed (received) phone calls.
3. The `GoalRollupQuery` creates the goal rollup queries, locating the incoming and outgoing closed phone calls. 
4. Creates three goals, one parent goal and two child goals.
5. The `RecalculateRequest` calculates the rollup for goals. 

### Clean up

Display an option to delete the sample data created in [Setup](#setup). The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the records to achieve the same result.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]