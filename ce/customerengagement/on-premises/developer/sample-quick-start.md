---
title: "Sample: Quick start for Dynamics 365 Customer Engagement (on-premises) (Developer Guide for Dynamics 365 Customer Engagement (on-premises))| MicrosoftDocs"
description: "Dynamics 365 Customer Engagement (on-premises) web services by using the ServerConnection helper class and perform basic create, update, retrieve, and delete operations on an entity. "
ms.custom: 
ms.date: 03/29/2019
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
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
# Sample: Quick start for Dynamics 365 Customer Engagement

The QuickStart sample is a [!INCLUDE[pn_Microsoft_.Net_Framework](../includes/pn-microsoft-net-framework.md)] managed code sample that shows how to connect to the Dynamics 365 Customer Engagement web services by using the `ServerConnection` helper class and perform basic create, update, retrieve, and delete operations on an entity.

> [!CAUTION]
> The helper classes are deprecated and no longer maintained. The recommendation is to use the new [CrmServiceClient](https://docs.microsoft.com/dotnet/api/microsoft.xrm.tooling.connector.crmserviceclient?view=dynamics-xrmtooling-ce-9) class for connecting to the web service endpoints. For more information see [Build Windows client applications using the XRM tools](build-windows-client-applications-xrm-tools.md).

If you would like to review a shorter version of the ServerConnection class without all the console I/O, see [Authentication deep dive](authenticate-office-365-users-customer-engagement-web-services.md#authentication-deep-dive).

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]

## Requirements

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. Download the complete sample from [Sample: Quick start for Microsoft Dynamics 365 Customer Engagement](https://code.msdn.microsoft.com/Sample-Quick-start-for-650dbcaa).

## Demonstrates

This sample authenticates the user with the Dynamics 365 Customer Engagement (on-premises) web services by using the `ServerConnection` helper class and methods. After obtaining a reference to the Organization web service, the sample performs basic create, update, retrieve, and delete operations on an account entity. The sample also handles common exceptions that can be thrown.

## Example
[!code-csharp[QuickStartCS#CRUDOperations](../snippets/csharp/CRMV8/quickstartcs/cs/crudoperations.cs#crudoperations)]

### See also

[Tutorials for Learning About Dynamics 365 Customer Engagement Development apps](tutorials-resources-sdk.md)<br />
[Sample: Simplified Connection Quick Start using Dynamics 365 Customer Engagement (on-premises)](xrm-tooling/sample-simplified-connection-quick-start.md)<br />
[Helper Code: ServerConnection Class](https://github.com/microsoft/Dynamics365-Apps-Samples/blob/master/samples-from-msdn/HelperCode/CrmServiceHelpers.cs)<br />
