---
title: "Sample: Specify a queue item to work on (early bound) (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
decription: The sample code demonstrates how to use PickFromQueueRequest to specify a user who will work on a queue item.
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
  - sample for specifying queue items for users to work on (early bound)
  - specifying queue items for users to work on (early bound), sample
ms.assetid: be171519-f8d0-43e6-b5a7-770802da47db
caps.latest.revision: 18
author: JimDaly
ms.author: nabuthuk
manager: kvivek
search.audienceType: 
  - developer

---

# Sample: Specify a queue item to work on (early bound)

This sample shows how to use [PickFromQueueRequest](https://docs.microsoft.com/dotnet/api/microsoft.crm.sdk.messages.pickfromqueuerequest?view=dynamics-general-ce-9) to specify a user who will work on a queue item. You can download the sample from [here](https://github.com/Microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/SpecifyQueueItem).

[!include[cc-sample-note](includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-PA-samples.md)]

## What this sample does

The `PickFromQueueRequest` message is intended to be used in a scenario where it contains data that is needed to assign a queue item to a user and optionally remove the queue item from the queue.

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

1. Checks for the current version of the org.
2. The `Queue` method creates a private queue instance and set its property values.
3. The `QueueItem` method creates a new instance of queueitem and initialize its properties.

### Demonstrate

1. The `WhoAmIRequest` method retrieves the current user information.
1. The `PickFromQueueRequest` method creates an instance of an existing queueitem in order to specify the user that will be working on it.


### Clean up

Display an option to delete the sample data that is created in [Setup](#setup). The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the records to achieve the same result.


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]