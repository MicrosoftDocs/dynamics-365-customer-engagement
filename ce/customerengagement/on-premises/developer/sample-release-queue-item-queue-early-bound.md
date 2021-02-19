---
title: "Sample: Release a queue item to the queue (early bound) (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
decription: The sample code demonstrates how to use ReleaseToQueueRequest to dissociate a user from a queue item release a queue item back to the queue.
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
  - dissociating users from queue items and returning items to queues, sample
  - releasing queue items back to queues (early bound), sample
  - sample for releasing queue items back to queues (early bound)
ms.assetid: 87c72e1e-3ea8-4c54-8eb2-e7fbc19ff629
caps.latest.revision: 17
author: JimDaly
ms.author: nabuthuk
manager: kvivek
search.audienceType: 
  - developer

---
# Sample: Release a queue item to the queue (early bound)

This sample shows how to use [ReleaseToQueueRequest](https://docs.microsoft.com/dotnet/api/microsoft.crm.sdk.messages.releasetoqueuerequest?view=dynamics-general-ce-9) to dissociate a user from a queue item that he or she worked on and release a queue item back to the queue. You can download the sample from [here](https://github.com/Microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/ReleaseQueueItems).

[!include[cc-sample-note](includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-PA-samples.md)]

## What this sample does

The `ReleaseToQueueRequest` message is intended to be used in a scenario where it contains data that is needed to assign a queue item back to the queue owner so others can pick it.

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

1. Checks for the current version of the org.
2. The `Queue` message creates a new queue and store its returned GUIDs in a variable.
3. The `QueueItem` message creates a new instance of a queueitem and initialize its properties.
4. The `WhoAMIRequest` retrieves the current user's information.

### Demonstrate

The `ReleaseToQueueRequest` message removes worker from queue item to release queued object from worker's queue.

### Clean up

Display an option to delete the sample data created in [Setup](#setup). The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the records to achieve the same result.


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]