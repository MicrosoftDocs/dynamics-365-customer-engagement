---
title: "Sample: Add a security principal (user or team) to a queue (early bound) | MicrosoftDocs"
description: The sample code demonstrates how to give a user or team access to a queue. The AddPrincipalToQueueRequest adds the specified principal to the list of queue members.
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
  - sample for sharing queues (early bound)
  - giving teams limited access to queues (early bound), sample
  - sharing queues (early bound), sample
  - sample for limiting team access to queues (early bound)
ms.assetid: cd7c39d3-14cb-484a-a1e1-795d9d3d81ff
caps.latest.revision: 25
author: JimDaly
ms.author: nabuthuk
manager: kvivek
search.audienceType: 
  - developer

---

# Sample: Add a security principal (user or team) to a queue (early bound)

This sample showcases how to give a user or a team access to a queue. The [AddPrincipalToQueueRequest](/dotnet/api/microsoft.crm.sdk.messages.addprincipaltoqueuerequest?view=dynamics-general-ce-9) adds the specified principal to the list of queue members. If the passed-in security principal is a team each member of the team is added to the queue. You can download the sample from [here](https://github.com/Microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/AddSecurityPrincipalToQueue).

## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-PA-samples.md)]

## What this sample does

The `AddPrincipalToQueueRequest` message is intended to be used in a scenario where it contains data that is needed to add the specified principal to the list of queue members. If the principal is a team, add each team member to the queue.

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

1. Checks for the current version of the org.
2. The `Queue` method creates a queue instance and set its property values. The returned GUIDs are stored in a variable.
3. The `QueryExpression` retrieves the default business unit for the creation of the team and role.
4. Creates a new example team and role required for the sample.
5. Retrieves the `prvReadQueue` and `prvAppendToQueue` privileges.
6. The `AddPrivilegeRoleRequest` method adds the `prvReadQueue` abd `prvAppendToQueue` privileges to the example role.

### Demonstrate

The `AddPrincipalToQueueRequest` method adds the team to the queue.

### Clean up

Display an option to delete the sample data in [Setup](#setup). The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the records to achieve the same result.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]