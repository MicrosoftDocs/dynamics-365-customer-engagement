---
title: Rollup goal data for a custom period against the target revenue (Sample)
description: This sample shows how to roll up goal data for a custom period against the target revenue.
ms.date: 03/01/2023
ms.topic: sample
applies_to: 
  - Dynamics 365 Sales
author: udaykirang
ms.author: nabuthuk
search.audienceType: 
  - developer
---

# Sample: Rollup goal data for a custom period against the target revenue

This sample shows how to roll up goal data for a custom period against the target revenue. You can download the sample from [here](https://github.com/Microsoft/PowerApps-Samples/tree/master/dataverse/orgsvc/C%23/RollupGoalData).

This sample requires three additional users that aren't in your system. Create the three required users **as is** shown in the following section manually in **Office 365**. Replace `yourorg` with the organization name.

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

This sample shows how to roll up goal data for a custom period against the target revenue.

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

1. Checks for the version of the org.
1. Retrieves the sales manager and 2 sales representatives created manually in **Office 365**.
1. Creates a sample unit group and retrieve the default unit id. 
1. Creates few products and new discount list.
1. The `PriceLevel` creates the price list.
1. The `ProductPriceLevel` creates a price list item for the first product and apply volume discount.
1. Creates account row for the opportunity's potential customer id.
1. Creates a new opportunity with user specified estimated revenue.
1. Creates a catalog products and override the list price.
1. Creates a new write-in opportunity product with a manual discount applied.

### Demonstrate

1. Creates Metric, and setting the Amount Data type to `Money`.
1. Creates a Rollup fields which targets the estimated values and actual values.
1. The `GoalRollupQuery` creates the goal rollup queries, locating the opportunities in the sales representative's area. 
1. Creates three goals, one parent goal and two child goals.
1. The `RecalculateRequest` calculates the rollup for goals.  

### Clean up

Display an option to delete the sample data created in [Setup](#setup). The deletion is optional in case you want to examine the tables and data created by the sample. You can manually delete the records to achieve the same result.



[!INCLUDE[footer-include](../../includes/footer-banner.md)]
