---
title: Create a work order from an opportunity
description: Learn how to convert a service-maintenance opportunity into a work order in Dynamics 365 Field Service.
ms.date: 03/24/2026
ms.topic: how-to
author: vhorvathms
ms.author: vhorvath
ms.reviewer: puneetsingh
ms.custom: bap-template
---

# Create a work order from an opportunity

A work order in Dynamics 365 Field Service can be created from a service-maintenance opportunity. Converting an opportunity to a work order links the two records and carries over key information such as the customer account, work order type, and products.

## Prerequisites

- A Dynamics 365 Field Service environment.
- A **Field Service - Dispatcher** or **Field Service - Administrator** security role.

## Set up the opportunity for Field Service

Follow these steps to set up opportunity for Field Service:

1. In the **Sales** area of Field Service, go to **Opportunities** and open an existing opportunity or create a new one.

1. On the **Field Service** tab, select a **Work Order Type** for the opportunity. This value carries over to the work order during conversion.

1. Optionally, add **Opportunity Products** to the opportunity. These products map to **Work Order Products** on the resulting work order. The product **Sequence Number** is preserved as the **Line Order** on the work order product.

## Convert the opportunity to a work order

Follow these steps to convert opportunity to a work order:

1. On the opportunity form, select **Convert to Work Order**.

1. On the new work order form, verify or fill in the required fields:

   - **Service Account**: Populated from the opportunity's customer account.
   - **Work Order Type**: Carried over from the opportunity.
   - **Price List**: Select a price list from the list or [create a new price list](create-price-list.md).
   - **System Status**: Set to **Unscheduled**.
   - **Taxable**: Choose whether the work order is taxable. The sales tax code configuration from the opportunity carries over to the work order.

1. Select **Save** or **Save and Close**.

## Next steps

- [Schedule a work order](universal-resource-scheduling-for-field-service.md)
- [Create work order types](create-work-order-types.md)
- [Set up booking statuses](set-up-booking-statuses.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
