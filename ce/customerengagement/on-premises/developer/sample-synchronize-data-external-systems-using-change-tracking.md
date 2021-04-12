---
title: "Sample: Synchronize data with external systems using change tracking (Developer Guide for Dynamics 365 Customer Engagement (on-premises))| MicrosoftDocs"
description: "This sample code shows how to retrieve changes from an entity and synchronize data with external systems by using the RetrieveEntityChangesRequest message"
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 14464805-0405-4e19-9d95-6c031de8ae3f
caps.latest.revision: 21
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Sample: Synchronize data with external systems using change tracking

This sample code shows how to retrieve changes from an entity and synchronize data with external systems by using the `RetrieveEntityChanges` message with the [RetrieveEntityChangesRequest](/dotnet/api/microsoft.xrm.sdk.messages.retrieveentitychangesrequest) and [RetrieveEntityChangesResponse](/dotnet/api/microsoft.xrm.sdk.messages.retrieveentitychangesresponse) classes. You can download the sample from [here](https://github.com/Microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/Changetracking).

[!include[cc-sample-note](includes/cc-sample-note.md)]

For more information about the feature that this sample demonstrates, see [Use change tracking to synchronize data with external systems](/powerapps/developer/common-data-service/use-change-tracking-synchronize-data-external-systems).


## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-PA-samples.md)]

## What this sample does

The `RetrieveEntityChanges` message is intended to be used in a scenario where data from an external system is synchronized and the capability to use change tracking can be used to detect and reconcile data changes.

Without a separate system required to fully replicate this scenario, this sample simulates the scenario by performing two requests. In between the requests some data is changed so that the second request will return data about what was changed over time.

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

1. Import a managed solution (ChangeTrackingSample_1_0_0_0_managed.zip) that creates a `sample_book` entity that has an alternate key named `sample_bookcode`. Verify that the indexes to support the alternate key are active
1. 10 initial sample_book entity records are created so that changes to those entities can be tracked.

### Demonstrate

1. Perform initial request and cache the results, including the `DataToken`
1. Update the records created in [Setup](#setup)
1. Perform a second request, this time passing the `DataVersion` with the `DataToken` value retrieved from the initial request.
1. Show the entity changes returned by the second request

### Clean up

Display an option to delete the managed solution imported in [Setup](#setup), which removes the `sample_book` entity and all the data created in the sample. The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the `ChangeTrackingSample` to achieve the same result.


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]