---
title: "Sample: Associate a security role to a team | MicrosoftDocs"
description: "The sample shows how to assign a security role to a team by using the AssignRequest message."
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
  - assigning a role to a team, sample
  - assigning a security role, sample
  - team security sample, assigning roles
ms.assetid: 6097b89f-b3a6-472b-8fed-4f1aef62817f
caps.latest.revision: 21
author: JimDaly
ms.author: nabuthuk
manager: kvivek
search.audienceType: 
  - developer

---
# Sample: Associate a security role to a team

This sample shows how to assign a security role to a team by using the [AssignRequest](/dotnet/api/microsoft.crm.sdk.messages.assignrequest?view=dynamics-general-ce-9) message. Note that this example does not take into consideration that a team or user can only be assigned a role from its business unit. The role to be assigned is the first from the collection that is returned by the RetrieveMultiple method. If that record is from a business unit that is different from the requesting team, the assignment fails.

You can download the sample from [here](https://github.com/microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/AssociateSecurityRoleToTeam).

[!include[cc-sample-note](includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-PA-samples.md)]

## What this sample does

The [AssignRequest](/dotnet/api/microsoft.crm.sdk.messages.assignrequest?view=dynamics-general-ce-9) message is intended to be used in a scenario where it contains data that is needed to assign the specified record to a new owner (user or team) by changing the OwnerId attribute of the record.

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

1. Checks for the current version of the org.
2. The `CreateRequiredRecords` method creates the records required by the sample.

### Demonstrate

1. The `query` method retrieves a role from Dataverse.
2. The `Associate` message assigns the role to a team.

### Clean up

Display an option to delete the sample data in [Setup](#setup). The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the records to achieve the same result.


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]