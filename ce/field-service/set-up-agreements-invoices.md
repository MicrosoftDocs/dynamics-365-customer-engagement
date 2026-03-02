---
title: Set up customer agreements to generate invoices in Dynamics 365 Field Service
description: Learn how to set up customer agreements to automatically generate invoices in Dynamics 365 Field Service.
ms.date: 03/02/2026
ms.topic: how-to
author: jasonccohen
ms.author: jacoh
---
# Set up agreements to automatically generate invoices

Customer agreements contain predefined details to generate invoices. For more information, go to [agreements overview](agreements-overview.md). As agreement work increases, consider whether to add [multiple incidents or multiple recurrences](agreements-overview.md#multiple-incidents-vs-multiple-recurrences).

The following table shows the overall agreement setup flow to generate invoices before you start the detailed steps.

| Step | What you configure | Purpose |
|----------|----------|----------|
| 1. [Create or open an Agreement](#step-1-create-an-agreement-or-select-an-existing-one)  | Customer, date range, price list, general details  | Establish the high‑level contract  |
| 2. [Add Agreement Invoice Setup (AIS)](#step-2-set-up-invoice-recurrence-and-products) | Invoice recurrence, billing defaults | Generate invoices on a schedule |
| 3. [Activate](#step-3-activate-invoice-recurrence-and-view-invoices) | Change status to Active  | Start automated generation. Agreement Invoice Dates (Scheduled → Processed → Invoices)  |

This article covers scenario to show how agreements can generate invoices.

## Prerequisites

Before you set up a customer agreement, confirm that the following are already in place:

- Invoice-related data is configured in your system, including accounts, products, services, and service tasks.

- [Agreement settings](configure-default-settings.md#agreement-settings) are configured. Consider specifying an agreement prefix and start number.

- Designated owners of agreements, agreement booking setups, and agreement invoice setups can create invoices, invoice details, work orders, work order incidents, work order products, work order services, work order service tasks, resource requirements, and bookings.

> [!NOTE]
> Before you create an agreement, set up a system user or team owner for the agreements. Agreement processes run with the permissions of their owners. If the owner leaves the organization, agreement processes fail and the agreement breaks. Learn more in [Change the owner of an agreement](manage-agreements.md#change-the-owner-of-an-agreement).

## Automatically generate invoices

Agreement invoices are used to automatically generate invoices for products and services. The invoices are generated at a defined recurrence and contain the same products at the same price each time. The invoices are generated and billed regardless of whether any work orders are performed or not. It's similar to how you might pay a monthly cell phone bill regardless of the number of phone calls or texts you send.

This scenario is independent of [Set up agreements to automatically generate work orders](set-up-agreements-work-orders.md). You can generate invoices without generating work orders.

In this scenario, a customer pays a field service organization a quarterly amount for a service plan.

### Step 1: Create an agreement or select an existing one

You can add an agreement invoice to an existing agreement or add it to a new one. You can have an agreement with only an agreement invoice and no maintenance plan and even have multiple invoices for a single agreement.

In this example, quarterly invoices are added to the existing agreement.

1. From the agreement, select **Invoice Setup** > **Add New Agreement Invoice Setup**.

   > [!TIP]
   > You might need to select the vertical ellipsis &vellip; before selecting **New Agreement Invoice Setup**.

   :::image type="content" source="media/agreement-invoice-create-recurrence.png" alt-text="Screenshot of an agreement showing the Add new agreement invoice option under Invoice setup.":::

1. Enter a name for the service agreement and select **Save**.

### Step 2: Set up invoice recurrence and products

1. Select **Invoice Products** and **New Agreement Invoice Product**.

1. Add the products you would like to bill the customer for regularly and select **Save**. The price of the invoice products is derived from the price list on the agreement.

   > [!NOTE]
   > Invoice products can only be products where **Field Service Product Type** is set to **Inventory** or **Non-inventory**. Service type products can't be added.

   :::image type="content" source="media/agreement-invoice-add-products.svg" alt-text="Screenshot of an agreement invoice setup on the invoice products tab.":::

1. Select **Invoice Recurrence** in the command bar at the top.

1. Enter the recurrence information. To set up quarterly, select:

   - **Repeat**: Monthly
   - **Repeat by**: Day of the month
   - **Every specified month(s)**: 3

1. Select **OK**, then **Save**.

### Step 3: Activate invoice recurrence and view invoices

Because this agreement is already active, the invoice dates generate after a short time but not immediately. If you added an agreement invoice setup to a new agreement or an existing one that has an **Estimate** status, then activate the agreement.

To view the invoice dates, select **Related** > **Invoice Dates**. Initially, all generated invoice dates have an **Invoice status** of *Scheduled*. Once they each generate the invoice, their status changes to *Processed*.

:::image type="content" source="media/agreement-invoice-dates-generated.svg" alt-text="Screenshot of the agreement invoice setup, showing a list of invoice dates.":::

You can't manually generate agreement invoices like you can with agreement work orders.

> [!NOTE]
> Invoices generate in advance based on the value you set for the **Generate Agreement Invoices X Days in Advance** field in [**Field Service Settings** under the **Agreement** section](configure-default-settings.md#agreement-settings). The invoice due date is set based on your recurring invoice setup but the system creates it X days in advance. If **Generate Agreement Invoices X Days in Advance** has no value, the system creates the invoice on the invoice date set in the **Record Generation Timing** field of the agreement and in the Field Service settings.

### Next steps

- [Set up agreements to automatically generate work orders](set-up-agreements-work-orders.md)
- [Manage customer agreements](manage-agreements.md)
- [Set up agreement sub-statuses](set-up-agreement-sub-statuses.md)
- [Create work order templates with incident types](configure-incident-types.md)
- [Create and manage customer accounts](accounts.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
