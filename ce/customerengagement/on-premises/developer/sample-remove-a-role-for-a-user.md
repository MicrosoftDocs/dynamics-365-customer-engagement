---
title: "Sample: How to remove a role for a user (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: Learn how to disassociate a role from a user using this code sample for Dynamics 365 Customer Engagement (on-premises).
ms.custom:
ms.date: 10/31/2017
ms.reviewer: pehecke

ms.suite:
ms.tgt_pltfrm:
ms.topic: sample
applies_to:
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 6f25132e-30d2-4a20-9395-3e42aafdd959
caps.latest.revision: 16
author: JimDaly
ms.author: nabuthuk
search.audienceType:
  - developer
---

# Sample: How to remove a role for a user

This sample shows how to disassociate a role from a user by using the [IOrganizationService.Disassociate](/dotnet/api/microsoft.xrm.sdk.iorganizationservice.disassociate?view=dynamics-general-ce-9&preserve-view=true) method. You can download the sample from [here](https://github.com/microsoft/PowerApps-Samples/tree/master/dataverse/orgsvc/C%23/RemoveRoleFromUser).

This sample requires an additional user that isn't available in your system. Create the required user manually in **Office 365** in order to run the sample without any errors. For this sample create a user profile **as is** shown below.

**First Name**: Dan<br/>
**Last Name**: Park<br/>
**Security Role**: No security role<br/>
**UserName**: dpark@yourorg.onmicrosoft.com<br/>

[!include[cc-sample-note](includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-PA-samples.md)]

## What this sample does

The [IOrganizationService.Disassociate](/dotnet/api/microsoft.xrm.sdk.iorganizationservice.disassociate?view=dynamics-general-ce-9&preserve-view=true) message is intended to be used in a scenario where it deletes a link between records.

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

1. Checks for the current version of the org.
2. The `CreateRequiredRecords` method creates the records required by the sample.

### Demonstrate

1. The `query` method retrieves a role from Dataverse.
2. The `Disassociate` message removes the role to a team.

### Clean up

This sample creates no records. No cleanup is required.

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
