---
title: Build a service history for assets
description: Learn how to build a service history for customer assets from work orders and service agreements in Dynamics 365 Field Service.
ms.date: 01/23/2023
author: jshotts
ms.author: jasonshotts
ms.topic: how-to
ms.custom: bap-template
---
 
# Build a service history for assets

If your field service organization records [customer assets](assets.md), you can track repairs, inspections, tests, remote sensor data, and issues to build a service history for them. Understanding an asset's service history is important for making repair decisions, demonstrating compliance with service agreements, and ultimately keeping your customers happy.

You can build a service history from work order and service agreement incidents.

## Work order incidents

A standard and organized way to build a service history is to note the customer asset in [work order incidents](configure-incident-types.md). For example, if the **Primary Incident Type** is an inspection of a specific asset, then associate the asset in **Primary Incident Customer Asset**.

:::image type="content" source="media/customer-asset-primary-incident.png" alt-text="Screenshot of a work order, with the primary incident customer asset highlighted.":::

You can [add multiple incidents to a work order](configure-incident-types.md#add-multiple-incident-types-to-a-work-order). Each incident can be related to the same or different customer assets, as long as the assets all belong to the same service account.

When you add a customer asset to a work order incident, the asset is also noted on all work order products, services, and service tasks that result from the incident.

Managers can easily view all work orders that involve the customer asset. Reports can concretely relate asset details like name, category, and product with work order details like service account, work order type, and incident type.

## Service agreement incidents

Similarly to work order incidents, you can note customer assets in [service agreement incidents](set-up-customer-agreements.md). For example, you can note which asset recurring maintenance is intended for and make sure the maintenance tasks are reflected in the asset's service history.

:::image type="content" source="media/customer-asset-agreement-incident.png" alt-text="Screenshot of an agreement booking incident, with the customer asset highlighted.":::

Just like work order incidents, you can add multiple incidents to a service agreement. When work orders are generated, they include the agreement incidents with their associated customer assets.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
