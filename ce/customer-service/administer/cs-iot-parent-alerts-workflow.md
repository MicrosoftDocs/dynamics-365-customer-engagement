---
title: IoT - Parent IoT Alerts workflow
description: Learn how to link potential redundant IoT alerts to an existing parent alert in Customer Service to reduce duplicate processing.
ms.date: 03/30/2026
ms.topic: concept-article
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
---

# IoT – Parent IoT Alerts workflow

The **IoT – Parent IoT Alerts** workflow links potentially redundant IoT alerts to an existing parent alert.

This workflow helps prevent duplicate processing, such as sending multiple reset commands or creating multiple repair orders for the same device issue. Unfiltered alerts can also negatively affect performance in Customer Service.

> [!NOTE]
> The Web API types and operations referenced in this article are available in your environment.  
> You can explore them using the service document or tools such as Insomnia.  
>
> Learn more:
> - [Web API service documents](/power-apps/developer/data-platform/webapi/web-api-service-documents)
> - [Use Insomnia with Microsoft Dataverse Web API](/power-apps/developer/data-platform/webapi/insomnia)

## How the workflow works

The workflow calls the `Microsoft.Dynamics.CRM.msdyn_ParentIoTAlerts` action and passes a value of `60` for the `TimespanSeconds` parameter.  

- **Primary entity:** `msdyn_iotalert`  
- **Default behavior:** Enabled  

The workflow is included with the thermostat sample solution and demonstrates a recommended approach for handling duplicate or redundant IoT alerts that can occur when a device malfunctions.

By consolidating related alerts within a defined time window, the workflow ensures that only one parent alert is processed in Customer Service.

You can deactivate or edit this workflow if needed. For example, you can adjust the time span used to evaluate duplicate alerts.

## Parameters

Data passes to the workflow using the following parameter.

| Name             | Type       | Nullable | Description |
|------------------|------------|----------|-------------|
| TimespanSeconds  | Edm.Int32  | false    | Defines the time window, in seconds, used to group or suppress related IoT alerts. Valid values range from 60 to 180 seconds. |

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
