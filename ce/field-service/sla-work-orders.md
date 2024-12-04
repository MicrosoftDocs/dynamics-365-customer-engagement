---
title: Service level agreements (SLAs) for work orders
description: Learn how to set up service Level Agreements (SLAs) for work orders in Dynamics 365 Field Service.
ms.date: 09/20/2024
ms.topic: how-to
author: jasonccohen
ms.author: jacoh
---

# Service level agreements (SLA) for work orders

Dynamics 365 Field Service builds on the [Service Level Agreement (SLA) functionality](/training/paths/work-with-entitlements-and-slas-in-microsoft-dynamics-365-for-customer-service/) of Dynamics 365 Customer Service.

SLAs help organizations ensure work orders get the right level of attention in a timely manner.

For example, a field service organization offers an SLA to their customers. They promise that field technicians arrive within 3 hours from the time a work order is created. The organization wants a warning status displayed after 90 minutes.

To use SLAs for work orders, you enable the SLA setting, set up key performance indicators (KPIs), and then associate the SLAs to the work orders.

## Prerequisites

- Knowledge of [Dynamics 365 Service Level Agreements](../customer-service/administer/define-service-level-agreements.md)

## Enable SLA functionality for Field Service

1. Sign in to [Power Apps](https://make.powerapps.com/) and select your environment.
1. Select **Tables** > **All**.
1. Search for and select **Work Order**. Then, select **Properties**.
   :::image type="content" source="media/sla-power-apps-table.svg" alt-text="Screenshot of the Work Order table in Power Apps.":::
1. Select **Advanced options** and select **Setting up service level agreements**.
   :::image type="content" source="media/sla-power-apps-enable-work-order.png" alt-text="Screenshot of editing the Work Order table in Power Apps highlighting the SLA setting.":::
1. Select **Save**. Then, select **Publish**.

## Create SLA KPIs

SLA KPIs are performance indicators, such as First Response or Resolve by, that you'd like to track.

1. Go to the Customer Service admin center. Under **Operations**, select **Service terms**.
1. In the SLA KPIs section, select **Manage**. Then select **New**.
1. Enter the following details:
   - **Name**: The name of the SLA KPI.
   - **Owner**: The user creating the SLA is populated by default. You can specify a different owner.
   - **Entity Name**: Select **Work Order**.
   - **KPI Field**: Select the respective KPI field. For example, if you're creating an SLA KPI to define the time within which a technician must arrive, select **Work Order Arrival Time KPI**.
   - **Applicable From**: Select a value based on which the warning and failure time are measured. For example, if you select **Created On**, the warning and failure start time for an SLA are calculated from the date and time when the work order was created.

   :::image type="content" source="media/sla-kpi-instance.png" alt-text="Screenshot of Customer Service admin center new SLA KPI configuration.":::
1. Select **Save**. Then, select **Activate**.

## Create an SLA

1. [Create an SLA](../customer-service/administer/define-service-level-agreements.md#create-an-sla) selecting **Work Order** for the **Primary entity**.
1. [Create an SLA item](../customer-service/administer/define-service-level-agreements.md#create-an-sla-item).

    :::image type="content" source="media/work-order-sla-items.png" alt-text="Screenshot of SLA Item showing a warning after 1.5 hours and failure after 3 hours.":::
1. Select **Save & Close**. Then, select **Activate**.

## Add the SLA to the work order form

1. In Power Apps, select **Tables** > **All**.

1. Search for and select **Work Order**.

1. Select **Forms**. Select the work order form.

1. Add the SLA field to the form. The SLA field is created when SLA functionality is enabled for the work order table.

   :::image type="content" source="media/work-order-add-sla-field-8.png" alt-text="Screenshot of adding the SLA field to the Work Order form.":::

1. **Save** the form and select **Publish All Customizations**.

## Schedule a work order to meet an SLA  

[Create a work order](create-work-order.md) in Field Service and select the SLA. Once a work order is associated with an SLA, the **Time From Promised** and **Time To Promised** fields appear on the work order according to the SLA, appropriate SLA Item, and business hours of the SLA. Scheduling capabilities like the schedule assistant consider these fields.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
