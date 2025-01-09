---
title: "Sample: Assign a chart to another user | MicrosoftDocs"
description: Learn how to assign a user-owned visualization, such as a chart, to another using the AssignRequest message with this sample.
keywords: 
ms.custom: 
ms.topic: sample
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 0225d979-0e34-44b5-814c-a5dcb14d6fd9
author: JimDaly
ms.author: nabuthuk
ms.reviewer: pehecke
search.audienceType: 
  - developer

---

# Sample: Assign a chart to another user

This sample shows how to assign a user-owned visualization to another using the [AssignRequest](/dotnet/api/microsoft.crm.sdk.messages.assignrequest?view=dynamics-general-ce-9&preserve-view=true) message. You can download the sample from [here](https://github.com/microsoft/PowerApps-Samples/tree/master/dataverse/orgsvc/CSharp/AssignChartToAnotherUser).

This sample requires an additional user that isn't available in your system. Create the required user manually in **Office 365** in order to run the sample without any errors. For this sample create a user profile **as is** shown below.

**First Name**: Kevin<br/>
**Last Name**: Cook<br/>
**Security Role**: Sales Manager<br/>
**UserName**: kcook@yourorg.onmicrosoft.com<br/>

[!include[cc-sample-note](../includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](../includes/cc-how-to-run-PA-samples.md)]

## What this sample does

The [AssignRequest](/dotnet/api/microsoft.crm.sdk.messages.assignrequest?view=dynamics-general-ce-9&preserve-view=true) message is intended to be used in a scenario where it contains the data that is needed to assign the specified record to a new owner (user or team) by changing the OwnerId attribute of the record.

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

1. Checks for the current version of the org.
2. The `CreateRequiredRecords` method creates a sample account and some opportunity records for the visualization.
3. The `newUserOwnedVisualization` method creates the visualization entity instance.

### Demonstrate

The `AssignRequest` method assigns the visualization or chart to the newly created user.

### Clean up

Display an option to delete the sample data in [Setup](#setup). The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the records to achieve the same result.

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
