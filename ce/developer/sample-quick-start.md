---
title: "Sample: Quick start for Dynamics 365 (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Dynamics 365 Custommer Engagement web services by using the ServerConnection helper class and perform basic create, update, retrieve, and delete operations on an entity. "
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "samples"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 0f1b28e3-0db0-4150-9c3b-d65daf0fabc5
caps.latest.revision: 19
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# Sample: Quick start for Dynamics 365 Customer Engagement

The QuickStart sample is a [!INCLUDE[pn_Microsoft_.Net_Framework](../includes/pn-microsoft-net-framework.md)] managed code sample that shows how to connect to the Dynamics 365 Customer Engagement web services by using the `ServerConnection` helper class and perform basic create, update, retrieve, and delete operations on an entity.

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]

## Requirements

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] Customer Engagement. Download the complete sample from [Sample: Quick start for Microsoft Dynamics 365](https://code.msdn.microsoft.com/Sample-Quick-start-for-650dbcaa).

## Demonstrates

This sample authenticates the user with the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] web services by using the `ServerConnection` helper class and methods. After obtaining a reference to the Organization web service, the sample performs basic create, update, retrieve, and delete operations on an account entity. The sample also handles common exceptions that can be thrown.

## Example
[!code-csharp[QuickStartCS#CRUDOperations](../snippets/csharp/CRMV8/quickstartcs/cs/crudoperations.cs#crudoperations)]

### See also

[Tutorials for Learning About Dynamics 365 Development](tutorials-resources-sdk.md)<br />
[Sample: Simplified Connection Quick Start using Dynamics 365](xrm-tooling/sample-simplified-connection-quick-start.md)<br />
[Helper Code: ServerConnection Class](org-service/helper-code-serverconnection-class.md)<br />
