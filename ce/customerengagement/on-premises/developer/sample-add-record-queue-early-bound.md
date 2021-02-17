---
title: "Sample: Add a record to a queue (early bound) | MicrosoftDocs"
description: The sample code demonstrates how to add a record to a queue, and creates source and destination queues.
ms.custom: 
ms.date: 01/08/2020
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - adding records to queues (early bound), sample
  - sample for adding records to queues (early bound)
ms.assetid: 250690a7-854d-4a69-adb9-d621834344fa
caps.latest.revision: 17
author: JimDaly
ms.author: nabuthuk
manager: kvivek
search.audienceType: 
  - developer

---
# Sample: Add a record to a queue (early bound)

This sample shows how to add a record to a queue. It creates source and destination queues. It adds a letter activity to the source queue and then moves it to the destination queue. You can download the sample from [here](https://github.com/Microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/RecordToQueue).

This sample requires additional users that are not in your system. Create the users manually in **Office 365** in order to run the sample without any errors. For this sample create a user profile **as is** shown below. 

**First Name**: Kevin<br/>
**Last Name**: Cook<br/>
**Security Role**: Sales Manager<br/>
**UserName**: kcook@yourorg.onmicrosoft.com<br/>

[!include[cc-sample-note](includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-PA-samples.md)]

## What this sample does

The `AddToQueueRequest` message is intended to be used in a scenario where it contains data that is needed to move an entity record from a source queue to destination queue.

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

1. Checks for the current version of the org.
2. The `Queue` method creates source and destination queues and store their returned GUIDs in variable.
3. Creates a Letter entity.
4. The `AddToQueueRequest` method adds an entity record into a queue, in this sample it associates the letter with first queue.
5. Retrieves the user created manually in **Office 365** for assigning the queue items to the user's queue.

### Demonstrate

1. The `RetrieveUserQueueRequest` message retrieves the known private queues for the user.
2. The `AddToQueueRequest` message adds the record from a source queue to destination queue.

### Clean up

Display an option to delete the sample data that is created in [Setup](#setup). The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the records to achieve the same result.


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]