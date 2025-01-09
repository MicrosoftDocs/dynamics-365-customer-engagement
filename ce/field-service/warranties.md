---
title: Create warranties and define coverage)
description: Create warranties to define coverage for assets, locations, and accounts.
ms.date: 11/01/2024
author: jshotts
ms.author: jasonshotts
ms.topic: how-to
ms.custom: bap-template
---

# Create warranties and define coverage

A warranty is a guarantee to repair or replace a product if it develops a failure within a specified period of time, or to do some work again if the service is not satisfactory. Dynamics 365 Field Service lets you define warranties and map them to assets, locations, or accounts to cover multiple warranty scenarios of your organization or your customers. For example, a temperature sensor at a customer site can have a two-year warranty period in which the manufacturer replaces for free in case it fails. Or, your organization installed equipment at a customer location and offers a warranty for the installation work.

Warranties aren't tied to work orders so pricing or discounts aren't automatically applied on a work order. The warranty feature is intended to provide a place to create and track items with a warranty.

## Prerequisites

An administrator must enable [**Warranties**](configure-default-settings.md#features-settings).

## Create a warranty

1. In Field Service, change to the **Service** area.
1. Under **Service Delivery**, select **Warranties**.
1. Select **New** to create a warranty record and enter the information for the warranty.
1. Save the record.

## Define coverage of the warranty

1. Open a warranty record.
1. Under **Covered assets**, **Covered locations**, and **Covered accounts**, map the records that are part of this warranty.

:::image type="content" source="media/warranty.svg" alt-text="Screenshot of a warranty with a covered asset.":::

You can also open an asset, location, or account and select **Related** > **Warranties** to specify coverage.

## Next steps

- [Create a work order](create-work-order.md)
- [Create work order templates with incident types](configure-incident-types.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
