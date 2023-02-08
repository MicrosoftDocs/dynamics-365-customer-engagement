---
title: Service level agreements (SLAs) for work orders
description: Learn about service Level Agreements (SLAs) for work orders in Dynamics 365 Field Service.
ms.date: 10/10/2022
ms.topic: article
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: lmasieri
ms.author: lmasieri
search.app: 
  - D365CE
  - D365FS
---

# Service level agreements (SLA) for work orders

Dynamics 365 Field Service builds on the [Service Level Agreement (SLA) functionality](/training/paths/work-with-entitlements-and-slas-in-microsoft-dynamics-365-for-customer-service/) of Dynamics 365 Customer Service.

SLAs help organizations ensure work orders get the right level of attention in a timely manner.

For example, a field service organization offers an SLA to their customers. They promise that field technicians arrive within 3 hours from the time a work order is created. The organization wants a warning status displayed after 90 minutes and to use the SLA timer during the scheduling process.

For more information on SLAs, go to [Define SLAs](../customer-service/define-service-level-agreements.md).

In this article, you'll learn how to associate SLAs to Field Service work orders.

## Prerequisites

- Field Service v8.3+
- Knowledge of [Dynamics 365 Service Level Agreements](../customer-service/define-service-level-agreements.md)

## Enable SLA functionality for Field Service

1. Go to **Advanced Settings**.

   :::image type="content" source="media/advanced-settings-dynamics365.png" alt-text="Screenshot of the Advanced Settings option in Dynamics 365.":::

1. Go to **Customizations** > **Customize the System**.

1. Expand **Entities** and select **Work Order**.

1. In the **Communication & Collaboration** section, select **Enable for SLA**.

   :::image type="content" source="media/work-order-sla-enable-work-order-1.png" alt-text="Screenshot of Enable SLA on Work Order.":::

1. Select **Save** and **Publish Customizations**.

## Create SLA KPIs

You can create new SLA KPI instances by going to **Advanced Settings** > **Customizations** > **Customize the System** > **Entities** > **SLA KPI Instance** > **1:N Relationships** > **New 1-to-Many Relationship**.

:::image type="content" source="media/work-order-sla-kpi-instance.png" alt-text="Screenshot of Field Service SLA Configuration.":::

## Add SLA KPIs to Field Service

1. In Field Service change to the **Settings** area. In the **General** section, select **Field Service Settings**.

1. Go to the **Field Service SLA Configuration** tab to select the **SLA KPI Instances** for Field Service. By default, there's an SLA related to work order arrival times.

   SLA KPI instances help track how often your organization meets SLAs by establishing a relationship between the SLA and work order entities. An SLA can have multiple SLA KPI Instances. If more than one SLA KPI matches for a work order, the one that was first created applies with priority.

## Create SLA

Now we're going to create a new SLA.

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

## Schedule a work order to meet SLA  

Once a work order is associated with an SLA, the **Time From Promised** and **Time To Promised** fields will be populated on the work order according to the SLA, appropriate SLA Item, and business hours of the SLA. These fields will populate along with other system jobs, which may typically take up to 5 minutes.

Scheduling capabilities like the schedule assistant consider these fields and therefore will respect the SLA.

Pausing an SLA timer on the work order will update **Time From Promised** and **Time To Promised** fields when resumed.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
