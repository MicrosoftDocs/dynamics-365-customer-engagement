---
title: Set up Field Service integration with Project Operations
description: Learn how to set up the integration between Field Service and Project Operations.
ms.date: 11/13/2026
ms.topic: how-to
author: vhorvathms
ms.author: vhorvath
ms.reviewer: v-wesmith
---

# Set up Field Service integration with Project Operations

Set up the Field Service integration with Project Operations environment-level settings to determine pricing and cost control, labor transactions, and default warehouse associations. Set up applies to both [deployment models](project-operations-integration-deployment-models.md).

## Prerequisites

- [An admin installed and configured the Project Operations integration.](project-operations-integration-install.md)
- You have a Field Service administrator role.

## Set pricing and cost control

Decide if your organization wants Field Service or Project Operations to define pricing and cost control. The default configuration is Field Service, which is automatically set and doesn't need to be changed.

- **Calculate Price in Field Service** = Yes (default) so that the price comes from the **Price List** associated with the work order products and services.

- **Calculate Cost in Field Service** = Yes (default) so that cost comes from the work order products and services.

:::image type="content" source="media/project-operations-integration-price-settings.png" alt-text="Screenshot of Field Service Settings screen, Work Order, and Bookings tab.":::

If you want Project Operations to define pricing and costing logic instead of Field Service, complete the following steps:

1. In Field Service, go to the **Settings** area.

1. On the **Field Service Settings** page, select the **Work Order / Booking** tab.

1. Change the settings to **No**.

   - **Calculate Price in Field Service** = So that the price comes from the project contract's **Sales Price List**.

   - **Calculate Cost in Field Service** = So that cost comes from the contracting unit **Cost Price List**.

1. Select **Save & Close**.

## Configure work order services

Choose how your organization handles work order services for projects. For project-based work, the **Work Order Service Conversion Type** setting controls how work order services contribute to project estimates and actuals. Learn more in [Work order services in Field Service and Project Operations](project-operations-integration-work-order-services.md).

For project tasks, use the project plan for estimated labor. Use work orders to schedule and execute the appropriate work in Field Service, but manage labor estimation from the project plan.

For project-based work, set the work order service conversion type.

### Set the work order service conversion type

In Field Service, the **Work Order Service Conversion Type** setting determines how your organization uses work order services.

1. In Field Service, go to the **Settings** area.

1. On the **Field Service Settings** page, select the **Time Entry** tab.

1. Select your option for **Work Order Service Conversion Type**.

   - **Material based Estimates and Actuals (default)**: Generate material-based estimates and, when marked *Used*, material usage logs that produce project actuals after approval.
   - **Time based Estimates and Actuals**: Generate time-based estimates and, when marked *Used*, time usage transactions that produce project actuals after approval.
   - **Time based Estimates Only**: Generate time-based estimates but doesn't automatically generate time entries or actuals.
   - **None**: Work order services doesn't automatically generate estimates, time entries, material usage logs, or actuals through the integration. You have your own process.

1. Select **Save & Close**.

1. If you use **Time based Estimates and Actuals** or **Time based Estimates Only**, ensure that [work order services are set up for time transactions](project-operations-integration-install.md#set-up-work-order-services-for-time-transactions).

## Configure the project assignment scheduling mode

Choose how your organization wants to handle project assignment scheduling. The **Project assignment scheduling mode** determines whether Field Service schedules an assignment’s total planned effort flexibly within an allowed window or uses the assignment’s planned work intervals to guide scheduling. Learn more in [Project assignment scheduling mode](project-operations-integration-resource-requirements.md#project-assignment-scheduling-mode).

1. In Field Service, switch to the **Settings** area.

1. Under **General**, select **Field Service Settings**.

1. Select the **Other** tab. Select your option for the **Project assignment scheduling mode**.

   - Select **Flexible Field Service scheduling (default)** to create a requirement using the total planned effort and an availability window, without creating project-managed detailed scheduling intervals.

   - Select **Project work pattern scheduling** to create detailed scheduling intervals based on the planned work pattern in Project Operations and checks capacity for bookings whose work falls entirely within a projected interval.

1. Select **Save & Close**.

## Set up warehouse associations

In the [**Project Operations integrated with ERP** deployment model](project-operations-integration-deployment-models.md), a bookable resource can have more than one warehouse. For each legal entity, mark one of those warehouses as the default warehouse.

When material is consumed, the system uses the work order's legal entity and the bookable resource to determine the default warehouse. The default warehouse helps ensure material consumption uses the correct legal entity and the correct warehouse.

1. In Field Service, go to the **Resources** area.

1. On the **Resources** page, open the resource you want to configure.

1. Select the **Field Service** tab.

1. In the **Warehouse Configurations** section, select **New Warehouse Configuration**.

1. Enter the following information:

   - **Warehouse**: Select the warehouse you want to associate with the resource.
   - **Default**: Select this checkbox if you want this warehouse to be the default for the resource.

1. Select **Save & Close**.

:::image type="content" source="media/project-operations-integration-warehouses.png" alt-text="Screenshot of multiple warehouses assigned to a resource." lightbox="media/project-operations-integration-warehouses.png":::

## Set up auto-complete project tasks

If your organization wants to automatically complete project tasks when the associated work order is completed in Field Service, set up work order types with auto-complete. This setting ensures that the project tasks in Project Operations are updated in sync with the work order status, reducing manual effort and improving data accuracy.

1. [Create a work order type](create-work-order-types.md) or open an existing work order type.

1. Set the **Close Project Task** field to *Yes*.

   :::image type="content" source="media/project-operations-integration-close-task.png" alt-text="Screenshot of the Work Order Type screen highlighting Close Project Task.":::

1. Select **Save & Close**.

The project task associated with the work order is automatically completed when the work order is marked as completed in Field Service and time entries are approved.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
