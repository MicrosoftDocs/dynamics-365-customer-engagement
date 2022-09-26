---
title: Service level agreements (SLAs) for work orders
description: Learn about service Level Agreements (SLAs) for work orders in Dynamics 365 Field Service.
ms.date: 09/26/2022
ms.reviewer: mhart
ms.service: dynamics-365-field-service
ms.topic: article
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: m-hartmann
ms.author: mhart
manager: shellyha
search.app: 
  - D365CE
  - D365FS
---

# Service level agreements (SLAs) for work orders

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

   SLA KPI instances help track how often your organization meets SLAs by establishing a relationship between the SLA and work order entities. An SLA can have many SLA KPI Instances. The SLA KPI instances entered in our example tell the system to update the **Time from Promised** and **Time to Promised** work order fields for scheduling, which we'll discuss further on in this article.

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

1. In the SLA Details section, select **New** to add details to the SLA:

    - **Name:** enter a title for your SLA detail.
    - **SLA KPI:** select the SLA KPI this SLA relates to. You can choose the arrival time KPI that is automatically available with Field Service v8.3+, or select one you've created.
    - **Applicable When**: in our example, the SLA is applicable when the **Priority** field on the work order is set to **High**.
    - **Success Criteria**: we want the SLA to be considered a success when a field technician begins traveling to or arrives on site. Therefore, a work order system status of **Open-In Progress** would indicate this success because when a field technician changes the booking status on one of their scheduled work orders to **Traveling** or **In Progress**, the related work order system status changes to **Open-In Progress**, thus making the SLA a success.  
      - Additionally, work orders with a system status of **Open-Completed**, **Closed-Posted**, and **Closed-Canceled** should be considered a success in terms of this SLA.
    - **SLA Item Failure**: in our example, we set it to 3 hours, which means the work order must reach a successful status (Open-In Progress, Open-Completed, Closed-Posted, Closed-Canceled) within three business hours. For more information, see the configuration considerations section in this article.
    - **SLA Item Warning**: set to 1.5 hours, which means the SLA status will be set to *Warning* after 1.5 hours.

    > [!div class="mx-imgBorder"]
    > ![Screenshot of creating SLA Details on the KPI that was identified as Arrival Time related. Information screen.](./media/work-order-sla-add-actions-6.png)

    The following screenshot shows the Field Service Mobile app that field technicians use to view and record on-site work. When a work order is scheduled to a field technician, a booking record is created. They can edit the booking status, which will update the related work order system status, which then updates the related SLA success status. 
    > [!div class="mx-imgBorder"]
    > ![Screenshot of creating SLA Details on the KPI that was identified as Arrival Time related.](./media/work-order-sla-mobile-app-booking-status.png)

1. Select **Activate** on the SLA. The following screenshot shows an activated SLA.

    > [!div class="mx-imgBorder"]
    > ![Screenshot of activating the SLA.](./media/work-order-sla-add-more-details-7.png)

## Add the SLA to a work order

1. Go to **Field Service > Work Orders > select a work order record** and then select **Form Editor**.

1. Add the SLA field to the work order form. The SLA field is created when SLA functionality is enabled for the work order entity.

    > [!div class="mx-imgBorder"]
    > ![Screenshot of adding the SLA field to the WO form.](./media/work-order-add-sla-field-8.png)

1. Save and publish form changes.

1. Create a work order and associated to your SLA, or associate a current work order to your SLA.

    > [!div class="mx-imgBorder"]
    > ![Screenshot of creating a Work Order associated to your SLA.](./media/work-order-add-to-work-order-9.png)

## Schedule a work order to meet SLA  

Once a work order is associated with an SLA, the **Time From Promised** and **Time To Promised** fields will be populated on the work order according to the SLA, appropriate SLA Item, and business hours of the SLA. These fields will populate along with other system jobs, which may typically take up to 5 minutes.

> [!div class="mx-imgBorder"]
> ![Screenshot of Time From Promised and Time To Promised fields on the work order being updated according to the SLA.](./media/work-order-sla-time-window-10.png)

Additionally, scheduling tools like the schedule assistant and Resource Schedule Optimization consider **Time From Promised** and **Time To Promised** fields and therefore will respect the SLA.

> [!div class="mx-imgBorder"]
> ![Screenshot of Schedule Assistant parameters using Time From Promised and Time To Promised field values.](./media/work-order-sla-schedule-11.png)

## Configuration considerations

- The SLA timer and populated values for **Time From Promised** and **Time To Promised** will respect the business hours of the SLA. For example, an SLA has a success parameter of 3 hours. Business hours are Monday through Friday from 9 AM to 5 PM. A work order is created at 4pm on Friday.
  The SLA timer and **Time From Promised** and **Time To Promised** will be set to a start of Friday at 4 PM and an end of Monday at 11 AM to compensate for business closure on the weekend up until 9 AM the following Monday.

## Additional notes

- Multiple SLAs and multiple business hours or calendars can be created and utilized for different customers; however, a work order can only have one SLA assigned to it.
- SLAs on work orders will overwrite existing values for **Time From Promised** and **Time To Promised**.
- Pausing an SLA timer on the work order will update **Time From Promised** and **Time To Promised** fields when resumed.


[!INCLUDE[footer-include](../includes/footer-banner.md)]
