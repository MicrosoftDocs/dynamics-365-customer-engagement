---
title: "Sample: Distribute a quick campaign (Dynamics 365 Sales)"
description: The sample code demonstrates how to create and distribute a quick campaign.
ms.date: 03/01/2023
ms.reviewer: lavanyakr
ms.topic: sample
applies_to: 
  - Dynamics 365 Sales
author: udaykirang
ms.author: udag
manager: shujoshi
search.audienceType: 
  - developer
---

# Sample: Distribute a quick campaign

This sample shows how to create and distribute a quick campaign. You can download the sample from [here](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/marketing/DistributeQuickCampaign).

## How to run this sample

[!include[cc-how-to-run-samples](../../includes/cc-how-to-run-samples.md)]

## What this sample does

This sample shows how to create and distribute a quick campaign.

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

1. Checks for the current version of the org. 
2. The `CreateRequiredRecords` method creates any table rows that this sample requires.
3. The `CreateAndRetrieveQuickCampaignForQueryExpression` method creates a quick campaign for a set of accounts selected by a query.
4. The `CreateAndRetrieveQuickCampaignForMarketingList` method creates quick campaign for a given marketing list and returns the Guid of the quick campaign.

### Demonstrate

1. The `List` method creates the marketing list that is required for the sample. 
2. The `QueryExpression` method constructs a query expression to specify which rows quick campaign should include. 

### Clean up

Display an option to delete the rows created in the [Setup](#setup). The deletion is optional in case you want to examine the tables and data created by the sample. You can manually delete the rows to achieve the same result.
  
### See also  
 [Campaign Tables](campaign-entities.md)   
 [BulkOperation Table](entities/bulkoperation.md)   
 [Sample: Distribute Campaign Activities to Dynamic and Static Lists](sample-distribute-campaign-activities-dynamic-static-lists.md)   
 [List (Marketing List) Table](list-marketing-list-entity.md)   
 [Marketing Tables (Campaign, List)](marketing-entities-campaign-list.md)   
 <xref:Microsoft.Crm.Sdk.Messages.AddMemberListRequest>   
 <xref:Microsoft.Crm.Sdk.Messages.PropagateByExpressionRequest>   
 <xref:Microsoft.Crm.Sdk.Messages.CreateActivitiesListRequest>


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
