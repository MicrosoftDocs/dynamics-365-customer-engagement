---
title: "Sample: Share records using GrantAccess, ModifyAccess and RevokeAccess messages (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "The sample shows how to share a record using the following messages:GrantAccessRequest, ModifyAccessRequest, and RevokeAccessRequest."
keywords: 
ms.date: 01/08/2020
ms.service: crm-online
ms.custom: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 791aa59d-b217-4e8d-93d3-edd4ecfc8403
author: JimDaly
ms.author: nabuthuk
manager: kvivek
ms.reviewer: pehecke
ms.suite: 
ms.tgt_pltfrm: 
helpviewer_keywords: 
  - sharing records sample
topic-status: Drafting
search.audienceType: 
  - developer

---

# Sample: Share records using GrantAccess, ModifyAccess and RevokeAccess messages

This sample shows how to share a record using the following messages:

[GrantAccessRequest](https://docs.microsoft.com/dotnet/api/microsoft.crm.sdk.messages.grantaccessrequest?view=dynamics-general-ce-9)

[ModifyAccessRequest](https://docs.microsoft.com/dotnet/api/microsoft.crm.sdk.messages.modifyaccessrequest?view=dynamics-general-ce-9)

[RevokeAccessRequest](https://docs.microsoft.com/dotnet/api/microsoft.crm.sdk.messages.revokeaccessrequest?view=dynamics-general-ce-9)

You can download the sample from [here](https://github.com/Microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/GrantModifyRevokeAccess).

This sample requires additional users that are not in your system. Create the required users manually in **Office 365** in order to run the sample without any errors. For this sample create 2 user profiles **as is** shown below. Replace `yourorg` with the organization name.

**First Name**: Dan<br/>
**Last Name**: Wilson<br/>
**Security Role**: Delegate<br/>
**UserName**: dwilson@yourorg.onmicrosoft.com<br/>

**First Name**: Christen<br/>
**Last Name**: Anderson<br/>
**Security Role**: Delegate<br/>
**UserName**: canderson@yourorg.onmicrosoft.com<br/>

[!include[cc-sample-note](includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-PA-samples.md)]

## What this sample does

The `GrantAccessRequest`, `ModifyAccessRequest`, `RevokeAccessRequest` messages are intended to be used in a scenario where it contains data that is needed to grant, modigy and revoke access.

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

1. Checks for the current version of the org.
2. Creates a unique identifier for preventing name conflicts.
3. Retrieves the user created manually in **Office 365** for this sample.
4. Retrieves the root business unit for creating the team for the sample.
5. The `WhoAMIRequest` gets the current user information.
6. Creates the team and adds the users to the team. 
7. Creates an account record and also creates a task, letter to associate to the account.

### Demonstrate

1. Retrieves and displays the access that the calling user has to the created account.
2. Retrieves and displays the access that the first user has to the created account. 
3. The `GrantAccessRequest` method grants the first user `read` access to the created account.
4. The `ModifyAccessRequest` method grants the first user `delete` access to the created account.
5. The `RevokeAccessRequest` method grants the first user `revoke` access to the created account.

### Clean up

Display an option to delete the sample data that is created in [Setup](#setup). The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the records to achieve the same result.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]