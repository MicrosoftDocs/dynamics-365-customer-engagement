---
title: Set up customer agreements to generate work orders in Dynamics 365 Field Service
description: Learn how to set up customer agreements to automatically generate work orders in Dynamics 365 Field Service.
ms.date: 03/02/2026
ms.topic: how-to
author: jasonccohen
ms.author: jacoh
---
# Set up agreements to automatically generate work orders

Customer agreements contain predefined details to generate work orders. For more information, go to [agreements overview](agreements-overview.md). As agreement work increases, consider whether to add [multiple incidents or multiple recurrences](agreements-overview.md#multiple-incidents-vs-multiple-recurrences).

The following table shows the overall agreement setup flow for generating work orders before you start the detailed steps.

| Step | What you configure | Purpose |
|----------|----------|----------|
| 1. [Create Agreement](#step-1-create-an-agreement)  | Customer, date range, price list, general details  | Establish the high‑level contract  |
| 2. [Add Agreement Booking Setup (ABS)](#step-2-set-up-booking-recurrence) | Booking recurrence, work order defaults | Generate work orders on a schedule |
| 3. [Add details](#step-3-add-agreement-work-details)  | Incidents, products, services, tasks | Specify what work is performed or billed each time  |
| 4. [Activate agreement](#step-4-activate-agreement-and-view-work-orders)  | Change status to Active  | Start automated generation. Agreement Booking Dates (Active → Processed → Work Orders)  |

This article covers a scenario that shows how agreements can generate work orders.

## Prerequisites

Before you set up a customer agreement, confirm that the following are already in place:

- Work order-related data is configured in your system, including accounts, incident types, products, services, and service tasks .

- [Agreement settings](configure-default-settings.md#agreement-settings) are configured. Consider specifying an agreement prefix and start number.

- Designated owners of agreements, agreement booking setups, and agreement invoice setups can create invoices, invoice details, work orders, work order incidents, work order products, work order services, work order service tasks, resource requirements, and bookings.

> [!NOTE]
> Before you create an agreement, set up a system user or team owner for the agreements. Agreement processes run with the permissions of their owners. If the owner leaves the organization, agreement processes fail and the agreement breaks. Learn more in [Change the owner of an agreement](manage-agreements.md#change-the-owner-of-an-agreement).

## Automatically generate work orders for asset maintenance

An organization must perform monthly maintenance on a piece of equipment they installed at a customer's location for the next year. They want to use Dynamics 365 Field Service to automatically generate the maintenance jobs in the middle of each month, with *some* flexibility. They want dispatchers to schedule the monthly maintenance jobs to the best and most appropriate field technicians and bill the customer for completed work at an agreed price.

This scenario is independent of [Set up agreements to automatically generate invoices](set-up-agreements-invoices.md). You can generate work orders without generating invoices.

To configure this scenario, use agreements, customer assets, incident types, and price lists.

### Step 1: Create an agreement

1. In the **Service** area, select **Agreements** > **New**.  

1. Fill in your information. Use the tooltips as a guide.  

   - **Service Account & Billing Account**: Defines where the agreement work orders take place, while the billing account defines who the invoice should be sent to. For more information, go to [Create and manage accounts](accounts.md).

   - **System Status**: Defines if the agreement is currently being executed. Set to **Estimate** while building a new agreement and adding details.
  
   - **Price list**: Specifies the price of all products and services related to an agreement and controls the price list populated on work orders generated from this agreement. Add all products and services used during the agreement to the agreement price list. Agreements usually contain a negotiated price for goods and services that are reflected in an entirely new price list. The price list on resulting work orders and invoices can be manually updated as needed.

   - **Start & End dates**: Defines the duration of the agreement.

   :::image type="content" source="media/agreement-create.svg" alt-text="Screenshot of an agreement showing all the fields.":::

1. In the **Other** tab, enter more details such as the **Service Territory** for the resulting work orders, and **Record Generation Time**, which determines the time of day work orders, invoices, and other records related to this agreement are generated. This definition is important because some organizations don't want agreements to create work orders in the middle of the working day. If no value is set, it defaults to the value in **Field Service Settings**.

1. Select **Save**.  

### Step 2: Set up booking recurrence

Once the agreement is created, specify how often work orders should be generated.  

1. On the **General** tab in the **Booking Setups** section, select **New Agreement Booking Setup**.

   > [!TIP]
   > You might need to select the vertical ellipsis &vellip; before selecting **New Agreement Booking Setup**.

   :::image type="content" source="media/agreement-create-booking-setup.svg" alt-text="Screenshot of an agreement highlighting New Agreement Booking Setup.":::

1. Fill in the name of the agreement schedule. For example, it could be "Monthly Maintenance." Naming is important because an agreement can have multiple booking recurrences. For instance, the service organization might perform weekly and monthly maintenance as part of the same agreement.

1. Fill in the **Work order settings**.

   - **Auto Generate Work Order**: Select **Yes** to automatically generate work orders on a rolling basis. Generated work orders appear in the active work order view with the status **Open-Unscheduled**. Select **No** to manually generate the work order for each scheduled date.

   - **Work Order Type**: Select the type of work order such as Diagnose and Repair or Inspection.

   - **Generate Work Orders Day in Advance**: Dictates how many days before the expected service date the work order is generated. If you choose several days in advance, your backlog of work orders might become larger than desired; however, if you choose too few days in advance, you might not have time to prepare. If no value is entered at the agreement level, there's an environment-wide setting in **Field Service Settings** > **Agreement** tab > **Generate Agreement Work Order X Days in Advance**. If this field also has no value, the work orders are generated seven days in advance of the booking date at the time recorded on the agreement.

   - **Work Order Type**, **Priority**, **Work Order Summary**, and **Location** entered here are passed down to resulting work orders.

1. Fill in the **Booking Settings**.

   - **Auto Generate Booking**: Select **Yes** to have the system book generated work orders (regardless of auto generated or manually generated). Specify a **Preferred Resource** and **Preferred Start Time** for the booking. Select **No** so that the generated work orders are scheduled through the normal scheduling process: manually, with the schedule assistant, or with Resource Scheduling Optimization.

     > [!Note]
     > Agreements create bookings according to recurrence without considering any other factors, including if the resource is active or their working hours.

   - **Estimated Duration**: Select the time estimated for this type of work order.

   - **Pre Booking Flexibility** and **Post Booking Flexibility** fields specify how many days before and after the anticipated schedule date the work order can be scheduled. These fields populate the **Date Window Start** and **Date Window End** fields on the generated work orders to aid the schedule assistant. For example, if you plan to perform monthly maintenance on the eighth of each month, and set pre and post-booking flexibility to seven days, then the work orders can be scheduled between the first and the 15th of each month.

   - **Time Window Start** and **Time Window End** can be specified to create a time window for generated work orders, which the schedule assistant includes. (Example: Work order should be scheduled between 8:00 AM and 12:00 PM).  

   :::image type="content" source="media/agreement-create-booking-setup2.svg" alt-text="Screenshot of an agreements booking setup, highlighting Booking Recurrence.":::

1. Select **Booking Recurrence** in the command bar at the top. If you're deciding between multiple incidents and multiple recurrences, learn more in [Customer agreements overview](./agreements-overview.md#multiple-incidents-vs-multiple-recurrences).  

1. Fill in the information.  

   - **Recurrence Pattern**: For example, every week, every first Monday of the month, or every other Friday.

   - **Range of Recurrence**: Define the **Start Date** and choose the **End Date Behavior**.
     - **No End Date**: Work orders are generated at the agreement end date.
     - **End by**: Stop generating work orders after the recurrence end date.
     - **End after # recurrences**: Work orders are generated after the specified number of recurrences is reached.

   - **Custom Dates**: Define dates to generate work orders that should be performed in addition to a recurrence if a pattern doesn't reflect your business needs. For example, to perform service on various holidays throughout the year. Custom date work orders aren't generated unless a recurrence is provided.

1. Select **Ok** and then select **Save**.

> [!NOTE]
> A single agreement can have various booking setups. For example, you might create a booking setup for weekly visits that creates work orders every week and a booking setup for monthly visits with different bookings.

Learn more in [Import booking recurrences](manage-agreements.md#import-booking-recurrences).

### Step 3: Add agreement work details

After setting up the **Agreement** and the **Agreement Booking Setup**, define the work that should be performed. To define the work, add incident types, products, services, and service tasks to the agreement.

If you want to use agreements for customer asset maintenance, use agreement booking incidents and specify the asset. By specifying a customer asset on the incident, you can define recurring work that should be performed on specific equipment and build service history. You can also add multiple incident types to an agreement booking setup each with a customer asset. This scenario uses an agreement booking incident.

If you don't want to use agreement booking incident types, you can add products, services, and service tasks directly to the agreement.

1. On the **General** tab in the **Incidents** section, select **New Agreement Booking Incident**. Use the tooltips as a guide to specify the incident details.

   > [!TIP]
   > You might need to select the vertical ellipsis &vellip; before selecting **New Agreement Booking Setup**.

   :::image type="content" source="media/agreement-incident.svg" alt-text="Screenshot of an agreement booking incident.":::

1. Select **Save & Close**.

As you add incidents to the agreement, the related products, services, service tasks, and characteristics are added to the agreement. These items are then added to work orders as they're generated. When adding incident types, consider the [**Copy Incident Items to Agreement** setting](configure-incident-types.md#create-an-incident-type-from-scratch).

### Step 4: Activate agreement and view work orders

After your organization's process for manager review and customer acceptance, the last step is to **Activate** the agreement. Once activated, the system generates related records such as maintenance dates and work orders. To add more details to the agreement status, consider using the [**Agreement Substatus**](set-up-agreement-sub-statuses.md) values. [Custom agreement substatuses](./developer/reference/entities/msdyn_agreementsubstatus.md) can also be created.

1. From the **Agreement** page, set the **System Status** to **Active**.

1. Select **Save**. Booking dates that represent the dates service should be performed are created.

1. To view the booking dates, open the **Booking Setup** and scroll to the **Booking Dates** section.

   :::image type="content" source="media/agreement-active-booking-dates.svg" alt-text="Screenshot of the agreement booking setup, showing the booking dates.":::

Initially, each generated **Booking Date** has a status of *Active*. As time approaches the booking dates, work orders are generated based on the **Generate Work Orders Days in Advance** field. The booking date status changes to *Processed* and a lookup to the generated work order appears.

If you set **Auto Generate Work Orders** to **No**, you can manually generate work orders for each booking date. For unique business cases where you must generate a work order earlier than defined, you can generate one manually. Open a booking date and select **Generate Work Order**.

:::image type="content" source="media/agreement-active-booking-dates-details.svg" alt-text="Screenshot of an agreement booking date, highlighting Generate Work Order.":::

If you decide to have the agreement **Auto Generate Bookings**, the work orders are scheduled to the preferred resource when the work orders are generated.

### Step 5: Perform agreement work orders

When work orders are generated, they appear among other work orders in the **Work Orders** view.

The generated work orders contain all the details specified in the agreement, such as price list, work order type, incident types, and customer assets. The details can still be edited at the work order level. For example, though a work order might be generated from an agreement, more products and services can be added to the work order as needed. Other details, such as price list and work order type, can be changed if you have the right permissions.

The work order contains a link to the agreement.

If not already scheduled, select **Book** and trigger the schedule assistant.

After a field technician performs an agreement work order and a manager closes it, an invoice for completed work is created. Learn more in [work order life cycle and statuses](work-order-status-booking-status.md).

> [!TIP]
> When setting up agreements to automatically generate work orders, limit the number of work order child records, such as work order products, services, service tasks, and incident types, to no more than 500. Larger volumes of records, synchronous custom plugins, or custom processes might cause a time-out, resulting in the remaining child records not being generated.

### Next steps

- [Set up agreements to automatically generate invoices](set-up-agreements-invoices.md)
- [Manage customer agreements](manage-agreements.md)
- [Set up agreement sub-statuses](set-up-agreement-sub-statuses.md)
- [Create work order templates with incident types](configure-incident-types.md)
- [Create and manage customer accounts](accounts.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
