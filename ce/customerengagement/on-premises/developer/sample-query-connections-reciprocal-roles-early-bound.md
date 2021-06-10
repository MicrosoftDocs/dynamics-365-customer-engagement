---
title: "Sample: Query connections by reciprocal roles (early bound) | MicrosoftDocs"
description: "The sample demonstrates how to create matching roles and find a matching for a particular role."
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
  - sample for querying connections by reciprocal roles
  - querying connections by reciprocal roles, sample
ms.assetid: 166e852a-b6d6-4b80-b4b3-6b5934829a4b
caps.latest.revision: 17
author: JimDaly
ms.author: nabuthuk
manager: kvivek
search.audienceType: 
  - developer

---
# Sample: Query connections by reciprocal roles (early bound)

This sample shows how to create matching roles and then find a matching role for a particular role. You can download the sample from [here](https://github.com/Microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/QueryByReciprocalRole).

[!include[cc-sample-note](includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-PA-samples.md)]

## What this sample does

This sample shows how to create matching roles and then find a matching role for a particular role.

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

1. Checks for the current version of the org.
2. Defines some anonymous types to define the range of possible connection property values.
3. The `ConnectionRole`creates the primary connection role instance.
4. The `ConnectionRoleObjectTypeCode` creates a connection role object type code record for account and contact entity.
5. The `AssociateRequest` associates the connection roles.

### Demonstrate

The `QueryExpression` retrieves all connection roles that have this role listed as reciprocal role.

### Clean up

Display an option to delete the records in [Setup](#setup). The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the records to achieve the same result.

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]