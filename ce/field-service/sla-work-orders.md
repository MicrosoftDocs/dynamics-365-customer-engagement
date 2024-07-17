---
title: Service level agreements (SLAs) for work orders
description: Learn how to set up service Level Agreements (SLAs) for work orders in Dynamics 365 Field Service.
ms.date: 07/17/2024
ms.topic: how-to
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: lmasieri
ms.author: lmasieri
---

# Service level agreements (SLA) for work orders

Dynamics 365 Field Service builds on the [Service Level Agreement (SLA) functionality](/training/paths/work-with-entitlements-and-slas-in-microsoft-dynamics-365-for-customer-service/) of Dynamics 365 Customer Service.

SLAs help organizations ensure work orders get the right level of attention in a timely manner.

For example, a field service organization offers an SLA to their customers. They promise that field technicians arrive within 3 hours from the time a work order is created. The organization wants a warning status displayed after 90 minutes and to use the SLA timer during the scheduling process.

To use SLAs for work orders, you enable the SLA setting, set up key performance indicators (KPIs), and then associate the SLAs to the work orders.

## Prerequisites

- Field Service v8.3+
- Knowledge of [Dynamics 365 Service Level Agreements](../customer-service/administer/define-service-level-agreements.md)

## Enable SLA functionality for Field Service

1. Sign in to [Power Apps](https://make.powerapps.com/) and select your environment.

1. Select **Tables** > **All**.

1. Search for and select **Work Order**. Then select **Properties**.

   :::image type="content" source="media/sla-power-apps-table.svg" alt-text="Screenshot of the Work Order table in Power Apps.":::

1. Select **Advanced options** and select **Setting up service level agreements**.

   :::image type="content" source="media/sla-power-apps-enable-work-order.png" alt-text="Screenshot of editing the Work Order table in Power Apps highlighting the SLA setting.":::

1. Select **Save** and **Publish**.

## Create SLA KPIs

1. In Power Apps, select **Tables** > **All**.

1. Search for and open **SLA KPI Instance**. Then select **Relationshps**.

1. Select **New relationship** > **One-to-many**.

1. Create your KPIs, and then **Save** and **Publish**.

   :::image type="content" source="media/sla-power-apps-sla-kpi-instance.svg" alt-text="Screenshot of Field Service SLA Configuration.":::

## Add SLA KPIs to Field Service

1. In Field Service change, to the **Settings** area. In the **General** section, select **Field Service Settings**.

1. Go to the **Field Service SLA Configuration** tab to select the **SLA KPI Instance** for Field Service. By default, there's an SLA related to work order arrival times.

   SLA KPI instances help track how often your organization meets SLAs by establishing a relationship between the SLA and work order tables. An SLA can have multiple SLA KPI Instances. If more than one SLA KPI matches for a work order, the one that was first created applies with priority.

## Create SLA

Now we're going to create a new SLA.

<!--- Need to figure out where this is --->

1. Go to **Advanced Settings**.

   :::image type="content" source="media/advanced-settings-dynamics365.png" alt-text="Screenshot of the Advanced Settings option in Dynamics 365.":::

1. Go to **Service Management** > **Service Level Agreements**

1. Select **New**.

1. Enter a **Name** and choose **Work Order**  from the **Entity** list.

   :::image type="content" source="media/work-order-sla-create-sla-add-work-order-4.png" alt-text="Screenshot of creating a new SLA for Work Order entity.":::

1. If applicable, assign a business hours calendar and select **Save**.

   :::image type="content" source="media/work-order-sla-add-sla-details-5.png" alt-text="Screenshot of assigning a Business Hours calendar.":::

   > [!NOTE]
   > You can create multiple SLAs and business hour calendars. However, a work order can only have one SLA assigned.

1. In the SLA Details section, select **New** to add details to the SLA:

    - **Name**: Name of the SLA detail.
    - **SLA KPI**: Choose the SLA KPI this SLA item relates to.
    - **Applicable When**: Define the clauses that this SLA applies to. For example, if a work order priority is high.
    - **Success Criteria**: Define the clauses that are considered a successful completion of a work order within an SLA. For example, if a field technician arrives on site and the work order system status changes to **Open-In Progress**.
    - **SLA Item Failure**: Choose the time frame in which the work order must meet the success criteria. This setting respects the business hours of the SLA. Example: An SLA has a success parameter of 3 hours. Business hours are Monday through Friday from 9 AM to 5 PM. A work order created at 4 PM on Friday is within the SLA if success criteria are met by Monday at 11 AM.
    - **SLA Item Warning**: Choose the time frame after which a warning shows on the work order.

    :::image type="content" source="media/work-order-sla-add-actions-6.png" alt-text="Screenshot of creating SLA Details on the KPI that was identified as Arrival Time related. Information screen.":::

1. **Save & Close** the SLA item and select **Activate** on the SLA.

## Add the SLA to a work order

1. Go to **Advanced Settings** > **Customizations** > **Customize the System**.

1. Expand **Components** > **Entities** > **Work Order** > **Forms**. Select the **Work Order** form.

1. Add the SLA field to the form. The SLA field is created when SLA functionality is enabled for the work order entity.

   :::image type="content" source="media/work-order-add-sla-field-8.png" alt-text="Screenshot of adding the SLA field to the Work Order form.":::

1. **Save** the form and select **Publish All Customizations**.

Moving forward, you can associate an SLA on a work order record.

## Schedule a work order to meet an SLA  

Once a work order is associated with an SLA, the **Time From Promised** and **Time To Promised** fields appear on the work order according to the SLA, appropriate SLA Item, and business hours of the SLA.

Scheduling capabilities like the schedule assistant consider these fields and therefore respect the SLA.

Pausing an SLA timer on the work order updates **Time From Promised** and **Time To Promised** fields when resumed.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
