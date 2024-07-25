---
title: Build a service history for assets
description: Learn how to build a service history for customer assets from work orders and service agreements in Dynamics 365 Field Service.
ms.date: 06/13/2024
author: jshotts
ms.author: jasonshotts
ms.topic: how-to
ms.custom: bap-template
---

# Build a service history for assets

If your field service organization records [customer assets](assets.md), you can track repairs, inspections, tests, remote sensor data, and issues to build a service history for them. An understanding of an asset's service history is important. It helps you make repair decisions, demonstrate compliance with service agreements, and ultimately keep your customers happy.

You can build a service history from work order incidents and service agreement incidents.

## Build a service history from work order incidents

One way to build a service history is to associate the customer asset in [work order incidents](configure-incident-types.md). For example, if the primary incident type is an inspection of a specific asset, associate the asset with that incident type.

1. Open a work order that is related to the customer asset.
1. Select the incident type and the primary asset.
1. Select **Save**.

    :::image type="content" source="media/customer-asset-primary-incident.svg" alt-text="Screenshot of a work order, with the Incident type and Primary asset fields highlighted.":::

1. You can [add multiple incidents to the work order](configure-incident-types.md#add-multiple-incident-types-to-a-work-order). Each incident can be related to the same or different customer assets. However, all the assets must belong to the same service account.

When you add a customer asset to a work order incident, the asset is also noted on all work order products, services, and service tasks that result from the incident.

Managers can easily view all work orders that involve the customer asset. Reports can concretely relate asset details such as the name, category, and product to work order details such as the service account, work order type, and incident type.

## Build a service history from service agreement incidents

You can note customer assets in [service agreement incidents](set-up-customer-agreements.md#step-3-add-agreement-work-details), just as you can note them in work order incidents. For example, you can note the asset that recurring maintenance is intended for and ensure that the maintenance tasks are reflected in the asset's service history.

:::image type="content" source="media/customer-asset-agreement-incident.svg" alt-text="Screenshot of an agreement booking incident, with the Incident Type and Customer Asset fields highlighted.":::

In addition, you can add multiple incidents to a service agreement, just as you can add them to a work order. When work orders are generated, they include the agreement incidents together with their associated customer assets.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
