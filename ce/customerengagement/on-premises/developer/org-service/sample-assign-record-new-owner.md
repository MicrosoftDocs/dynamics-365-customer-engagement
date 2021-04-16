---
title: "Sample: Assign a record to a new owner (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "This sample shows how to assign an account to another user by using the AssignRequest message"
keywords: 
ms.date: 07/22/2020
ms.service: crm-online
ms.custom: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: b8a256a4-e858-44bc-aff7-26b4d670fc61
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.reviewer: pehecke
ms.suite: 
ms.tgt_pltfrm: 
helpviewer_keywords: 
  - samples for early-bound classes, assigning records to new owners sample
  - assigning records to new owners sample, early-bound class samples
  - early-bound class samples, assigning records to new owners sample
  - sample for assigning records to new owners
topic-status: Drafting
search.audienceType: 
  - developer

---

# Sample: Assign a record to a new owner

This sample shows how to assign an account to another user by using the [IOrganizationService.Update](https://docs.microsoft.com/dotnet/api/microsoft.xrm.sdk.iorganizationservice.update?view=dynamics-general-ce-9) message.

This sample uses the `IOrganization.Update` method rather than the [AssignRequest](https://docs.microsoft.com/dotnet/api/microsoft.crm.sdk.messages.assignrequest?view=dynamics-general-ce-9) because there is an effort to remove specialized messages. More information: [Perform specialized operations using update](https://docs.microsoft.com/powerapps/developer/common-data-service/special-update-operation-behavior)

You can download the sample from [here](https://github.com/microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/AssignRecordToNewOwner).

[!include[cc-sample-note](../includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](../includes/cc-how-to-run-PA-samples.md)]

## What this sample does

The [IOrganizationService.Update](https://docs.microsoft.com/dotnet/api/microsoft.xrm.sdk.iorganizationservice.update?view=dynamics-general-ce-9) message is intended to be used in a scenario where it contains the data that is needed to update existing record.

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

1. Checks for the current version of the org. 
1. Creates required data that this sample requires.

#### Privileges and access rights
To run this sample, the caller must have the privileges on the specified entity and the access rights on the specified record. For example, if the caller only has Write or Assign privileges on the entity and tries to assign the record to another user, the request would fail.  The caller needs to have both the Write and Assign privileges on the entity in order to assign the record to another user.

### Demonstrate

1. The `Retrieve` method retrieves the account records created in the setup(#setup).
1. The `Update` message updates the `ownerid` attribute to the user who you want to own the record. 

### Clean up

Displays an option to delete all the data created in the sample. The deletion is optional in case you want to examine the data created by the sample. You can manually delete the data to achieve same results.


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]