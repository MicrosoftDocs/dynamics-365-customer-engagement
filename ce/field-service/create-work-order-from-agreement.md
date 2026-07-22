---
title: Create work orders from an agreement
description: Learn how agreements automatically generate work orders in Dynamics 365 Field Service, how to verify generation, and how to manually trigger work order creation from a booking date.
ms.date: 03/24/2026
ms.topic: how-to
author: jasonccohen
ms.author: jacoh
ms.reviewer: puneetsingh
ms.custom: bap-template
---

# Create work orders from an agreement

In Dynamics 365 Field Service, agreements automatically generate work orders on a recurring schedule. This is useful for planned maintenance, inspections, or any recurring service work where the same tasks need to be performed regularly at one or more customer sites.

For a full overview of agreements, go to [Set up customer agreements](set-up-agreements-work-orders.md).

## How agreement work order generation works

When an agreement is active and an **Agreement Booking Setup** (ABS) is configured with a recurrence, the system generates **Agreement Booking Dates** (ABDs) for each scheduled service date. As each ABD approaches, the system creates a work order automatically based on the **Generate Work Orders Days in Advance** setting.

The generated work order inherits key values from the agreement and the ABS:

| Agreement / ABS field | Maps to work order field |
|---|---|
| **Service Account** | **Service Account** |
| **Price List** | **Price List** |
| **Work Order Type** | **Work Order Type** |
| **Priority** | **Priority** |
| **Work Order Summary** | **Instructions** |
| **Service Territory** | **Service Territory** |
| **Incident Types** | **Primary Incident Type** and additional incidents |
| **Products** | **Work Order Products** |
| **Services** | **Work Order Services** |
| **Service Tasks** | **Work Order Service Tasks** |
| **Pre/Post Booking Flexibility** | **Date Window Start / Date Window End** |
| **Time Window Start / End** | **Time Window Start / End** |

## Prerequisites

- An active agreement with at least one **Agreement Booking Setup** configured. For more information, go to [Set up customer agreements](set-up-agreements-work-orders.md).
- The **Auto Generate Work Order** field on the ABS set to **Yes**, or you plan to generate work orders manually.
- At least one of the following Field Service security roles:
  - Field Service - Dispatcher
  - Field Service - Administrator

## Verify that work orders are being generated

1. In Field Service, change to the **Service** area.

1. In the **Service Delivery** section, select **Agreements** and open an active agreement.

1. On the **General** tab, select a booking setup in the **Booking Setups** section.

1. In the **Booking Dates** section, review the list of generated booking dates.

   - A status of **Active** means the booking date is upcoming and a work order hasn't been generated yet.
   - A status of **Processed** means a work order was generated. A lookup to the work order appears on the booking date record.

1. To open the generated work order, select the work order link in the **Work Order** column.

> [!TIP]
> If no booking dates appear after activating the agreement, verify that the **Agreement Booking Setup** has a valid recurrence pattern and that the agreement **Start Date** is in the past or today.

## Manually generate a work order from a booking date

If **Auto Generate Work Order** is set to **No**, or if you need to generate a work order earlier than scheduled, you can trigger it manually.

1. Open the agreement and select the booking setup.

1. In the **Booking Dates** section, open the booking date you want to generate a work order for.

1. Select **Generate Work Order** in the command bar.

The work order is created immediately and the booking date status changes to **Processed**.

## Schedule a generated work order

Generated work orders appear in the **Work Orders** view with the status **Open-Unscheduled**. Schedule them using any of the following methods:

- **Manually**: Open the work order and select **Book** to use the schedule assistant.
- **Schedule assistant**: Go to the schedule board and use the filter panel to find the work order.
- **Resource Scheduling Optimization**: If RSO is configured, it schedules eligible work orders automatically.

If you configured **Auto Generate Booking** on the ABS, the work order is automatically booked to the **Preferred Resource** at the **Preferred Start Time** when it's generated.

## Common issues

**Work orders aren't being generated**

- Confirm the agreement **System Status** is **Active**.
- Confirm the ABS has **Auto Generate Work Order** set to **Yes**.
- Check the **Generate Work Orders Day in Advance** field. If it's blank, the system uses the environment-wide default from **Field Service Settings** > **Agreement** > **Generate Agreement Work Order X Days in Advance**. If that's also blank, work orders generate seven days in advance.
- Confirm the agreement owner has the permissions to create work orders, work order incidents, products, services, and service tasks. Agreement processes run with the permissions of the agreement owner.

**Booking dates exist but no work order link appears**

The booking date status shows **Active** until the date falls within the generation window. Check whether today's date is within the **Generate Work Orders Day in Advance** window relative to the booking date.

**Generated work orders are missing products, services, or service tasks**

- Check the **Incidents** section on the ABS to confirm incident types, products, services, and service tasks are configured.
- Review the **Copy Incident Items to Agreement** setting on each incident type. For more information, go to [Create an incident type](configure-incident-types.md).
- If the agreement has more than 500 work order child records, time-outs during generation can cause some records to be skipped. Reduce the volume or consult your system administrator about plugin performance.

## Next steps

- [Set up customer agreements](set-up-agreements-work-orders.md)
- [Schedule a work order](universal-resource-scheduling-for-field-service.md)
- [Work order life cycle and statuses](work-order-status-booking-status.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
