---
title: Work order summary report
description: Learn how to use work order summary reports in Dynamics 365 Field Service.
ms.date: 02/09/2023
ms.reviewer: mhart
ms.topic: conceptual
ms.custom: bap-template
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: jshotts
ms.author: jasonshotts
---

# Work order summary report

Operations managers are responsible for managing work orders in order to provide timely support for their customers. To better understand what actions may be needed for better field service performance, reports provide help to monitor key operational metrics.

## Before you start


A Field Service administrator must enable the report in **Settings** > **Analytics and Insight** > **Settings** > **Field Service historical analytics** > **Manage**.

## Filters and slicers

- **Date range**: A [relative date range](/power-bi/visuals/desktop-slicer-filter-date-range).
- **Customer**: [Customer accounts](work-order-customer-account.md) configured in Field Service.
- **System status**: [Booking status of a work order](work-order-status-booking-status.md).
- **Work order type**: [Work order types](create-work-order-types.md) in Field Service.
- **Substatus**: Custom substatuses related the booking status of a work order.
- **Service territory**: [Territory](set-up-territories.md) defined in Field Service.
- **Technician**: [Active bookable resources](set-up-bookable-resources.md) in Field Service.

## Reports metrics

To access the work order summary report, open the **Field Service** app, change to the **Resources** area, and go to **Analytics and Insights** > **Field Service historical analysis**.

:::image type="content" source="media/work-order-summary-report.png" alt-text="Screenshot showing a sample work order summary report.":::

### Work orders

Total number of work orders created for the selected filters.

### Open work orders

Total number of currently open work orders.

### Broken promise (%)

Percentage of work orders that weren't completed within the promise window.

### Mean time to schedule (mins)

Average time to schedule from the time the work order was created to the time of the first booking.

### Mean time to travel (hrs)

Average time taken by an agent to travel to the customer. Calculated for all non-agreement work orders.

### Mean time to complete (hrs)

Average time taken to complete all the bookings for a specific work order from the date the work order was created.

### Avg. CSAT

Average customer satisfaction rate.

### Work orders by system status

Number of work orders by status.

### Work order trends by system status

Work order status over time.

### Work orders by substatus

Number of work orders by substatus.

### Work order trends by work order type

Work order type over time.

### Mean time to complete by work order type (mins)

Average time to complete work order over time.

### Work orders by primary incident type

Number of work orders by primary incident type.

### Broken promise (%) by work order type

Represents the correlation between broken promise percentage and work order type.

### Broken promise (%) vs mean time to schedule (mins)

Correlation between broken promise percentage and average time to schedule in minutes.

### Broken promise (%) vs mean time to travel (hrs)

Correlation between broken promise percentage and average travel time in hours.

### CSAT Trend

Average CSAT value per month over time.

### CSAT by substatus

Number of work orders with CSAT rating by substatus.

### Territory analysis

Number of bookings by [territory](set-up-territories.md) on a map. The territory needs to be a physical geolocation to show on the map.

## Next steps

- [Reports overview](reports.md)
- [Resource and utilization report](resource-utilization-report.md)
- [Optimization summary report](rso-optimization-summary-report.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
