---
title: Service level agreements (SLAs) for work orders
description: Learn how to set up service Level Agreements (SLAs) for work orders in Dynamics 365 Field Service.
ms.date: 03/12/2025
ms.topic: how-to
author: jasonccohen
ms.author: jacoh
---

# Service level agreements (SLAs) for work orders

Service level agreements (SLAs) define service expectations such as response and resolution times. SLAs can be tracked using key performance indicators (KPIs), such as First Response or Resolve by. In Field Service, SLAs help organizations ensure work orders get the right level of attention in a timely manner.

For example, a field service organization offers an SLA to their customers. They promise that field technicians arrive within 3 hours from the time a high priority work order is created. The organization wants a warning status displayed after 90 minutes.

To use SLAs for work orders, you enable the SLA setting, define the SLA and key performance indicators (KPIs), and then associate the SLAs to the work orders.

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

## Create an SLA

1. Go to the Power Platform Environment Settings app.
1. Under **Business**, select **Service Management** > **Service level agreements**.
1. Select **New** and enter the following information:
   - **Name**: A descriptive name for the SLA.
   - **Primary entity**: Work Order
   - **Description**: The specific requirements for the SLA.
1. Select **Save**.

### Create SLA items

1. In the **SLA Items** section, select **New SLA Item**.
1. Enter the following information:
   - **Name**: Unique name of this SLA item.
   - **KPI**: Select an existing SLA KPI or select **New SLA KPI**. For a new SLA KPI, enter the following information and then save:
     - **Name**: The name of the SLA KPI.
     - **Owner**: The user creating the SLA is populated by default. You can specify a different owner.
     - **Entity Name**: Select **Work Order**.
     - **KPI Field**: Select the respective KPI field. For example, if you're creating an SLA KPI to define the time within which a technician must arrive, select **Work Order Arrival Time KPI**.
     - **Applicable From**: Select a value based on which the warning and failure time are measured. For example, if you select **Created On**, the warning and failure start time for an SLA are calculated from the date and time when the work order was created.

     :::image type="content" source="media/sla-kpi-instance.png" alt-text="Screenshot of the SLA KPI configuration.":::

   - **Allow Pause and Resume** (optional): Enable this option if you want the SLA to be paused during the time the record is on hold.
   - **Allow Custom Time Calculation** (optional):
   - **Business Hours** (optional): To assign business hours, select a value. The SLA is calculated based on the business hours and business closure that you define.

1. In the **Applicable When** section, define the conditions for when the SLA can be applied for the entity.

    The SLA is triggered when the applicable when condition is met throughout. If the applicable when condition isn't met after an SLA is triggered, the SLA KPI instance gets canceled. We recommend that you don't use case fields that are updated frequently because any change to the field value might lead to cancelation of the SLA item.

1. In the **Success Conditions** section, define the conditions that specify the success criteria of the SLA.

  > [!IMPORTANT]
  > If you specify the success condition on the same entity on which applicable when is defined, a recommendation message is displayed with the suggestion that you don't use the same entity. You can choose to select **OK** if your organization needs the conditions to be configured on the same entity.

1. In the **Pause Configurations** section that appears only when **Allow Pause and Resume** is enabled, do the following:
   1. Set the toggle to **Yes** for **Override Criteria** to pause the SLA item. This setting overrides the pause settings defined at the entity level, if any, in Service Configuration or at the SLA KPI level.
   2. Select **Add** to define the conditions for pausing the SLA item.
    > ![Pause settings at SLA item level.](../media/csh-sla-item-pause.png "Pause settings at SLA item level")

1. In the **Warn and Fail Duration** section, specify the values to trigger notifications when an SLA is missed. If you don't need **Warning Duration**, you can set it to null so that SLAs don't reach the **Nearing noncompliance** status.

  > [!NOTE]
  > The failure and warning time is calculated after considering the business hours selected in the SLA record. If you don't set the business hours record (customer service schedule), the work hours are considered to be all day, every day.

1. Select **Save**.

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
