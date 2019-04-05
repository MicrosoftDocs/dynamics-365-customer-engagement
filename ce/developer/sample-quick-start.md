---
title: "Sample: Quick start for Dynamics 365 for Customer Engagement apps(Developer Guide for Dynamics 365 for Customer Engagement apps)| MicrosoftDocs"
description: "Dynamics 365 for Customer Engagement Custommer Engagement web services by using the ServerConnection helper class and perform basic create, update, retrieve, and delete operations on an entity. "
ms.custom: 
ms.date: 03/29/2019
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: 0f1b28e3-0db0-4150-9c3b-d65daf0fabc5
caps.latest.revision: 19
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Quick start for Dynamics 365 for Customer Engagement

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

The QuickStart sample is a [!INCLUDE[pn_Microsoft_.Net_Framework](../includes/pn-microsoft-net-framework.md)] managed code sample that shows how to connect to the Dynamics 365 for Customer Engagement web services by using the `ServerConnection` helper class and perform basic create, update, retrieve, and delete operations on an entity.

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]

## Requirements

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] Customer Engagement. Download the complete sample from [Sample: Quick start for Microsoft Dynamics 365 for Customer Engagement](https://code.msdn.microsoft.com/Sample-Quick-start-for-650dbcaa).

## Demonstrates

This sample authenticates the user with the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] web services by using the `ServerConnection` helper class and methods. After obtaining a reference to the Organization web service, the sample performs basic create, update, retrieve, and delete operations on an account entity. The sample also handles common exceptions that can be thrown.

## Example
[!code-csharp[QuickStartCS#CRUDOperations](../snippets/csharp/CRMV8/quickstartcs/cs/crudoperations.cs#crudoperations)]

### See also

[Tutorials for Learning About Dynamics 365 for Customer Engagement Development apps](tutorials-resources-sdk.md)<br />
[Sample: Simplified Connection Quick Start using Dynamics 365 for Customer Engagement apps](xrm-tooling/sample-simplified-connection-quick-start.md)<br />
[Helper Code: ServerConnection Class](org-service/helper-code-serverconnection-class.md)<br />
