---
title: "Sample: Clean up history for a queue (early bound)| MicrosoftDocs"
decription: The sample code demonstrates how to clean up the history for the queue using RemoveFromQueueRequest with inactive items.
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
  - cleaning up history in queues (early bound), sample
  - sample for deleting inactive items from queues (early bound)
  - sample for cleaning up history in queues (early bound)
  - deleting inactive items from queues (early bound), sample
ms.assetid: 81d686b0-7c5d-45e5-b2df-b74b0413bf6b
caps.latest.revision: 19
author: JimDaly
ms.author: nabuthuk
manager: kvivek
search.audienceType: 
  - developer

---
# Sample: Clean up history for a queue (early bound)

This sample shows how to clean up the history for the queue by using [RemoveFromQueueRequest](https://docs.microsoft.com/dotnet/api/microsoft.crm.sdk.messages.removefromqueuerequest?view=dynamics-general-ce-9) with inactive items. It finds completed phone calls in the queue and removes the associated queue items. You can download the sample from [here](https://github.com/Microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/CleanHistoryQueue).

[!include[cc-sample-note](includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-PA-samples.md)]

## What this sample does

The `RemoveFromQueueRequest` message is intended to be used in a scenario to clean up the queue history with inactive items.

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

1. Checks for the current version of the org.
2. Creates a queue instance and set its property values.
3. Creates a phone call activity instance and also queueitems instance and initializes its properties.
4. Marks the phone call as completed. 

### Demonstrate

Retrieves the queueitem with inactive phone calls from a queue using the [RemoveFromQueueRequest](https://docs.microsoft.com/dotnet/api/microsoft.crm.sdk.messages.removefromqueuerequest?view=dynamics-general-ce-9) message.

### Clean up

Display an option to delete the records created in [Setup](#setup). The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the records to achieve the same result.


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]