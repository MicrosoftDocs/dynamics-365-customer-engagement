---
title: Work order summary report
description: Learn about how to use work order summary reports in Dynamics 365 Field Service.
ms.date: 01/16/2023
ms.reviewer: mhart
ms.topic: conceptual
ms.custom: bap-template
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: jshotts
ms.author: jasonshotts
search.app: 
  - D365CE
  - D365FS
---

# Work order summary report

Operations managers are responsible for managing work orders in order to provide timely support for their customers. To better understand what actions may be needed for better field service performance, reports provide help to monitor key operational metrics.

## Before you start

- A Field Service administrators must enable the report in **Settings** > **Analytic and Insight** > **Settings** > **Field Service historical analytics** > **Manage**.

## Filters and slicers

- **Date range**: A [relative date range](/power-bi/visuals/desktop-slicer-filter-date-range).
- **Customer**: [Customer accounts](work-order-customer-account.md) configured in Field Service.
- **System status**: [Booking status of a work order](work-order-status-booking-status.md).
- **Work order type**: [Work order types](create-work-order-types.md) in Field Service
- **Substatus**: Custom substatuses related the booking status of a work order.
- **Service territory**: [Territory](set-up-territories.md) defined in Field Service.
- **Technician**: [Active bookable resources](set-up-bookable-resources.md) in Field Service.

## Reports metrics

To access the work order summary report, open the **Field Service** app, change to the **Resources** area, and go to ***Analytics and Insights** > **Field Service historic analysis**.

![Screenshot showing a sample work order summary report.](./media/report-overview-example.png)

### Work orders

Total number of work orders created for the selected filters.

### Open work orders

Total number of currently open work orders.

### Broken promise (%)

Percentage of work orders that were not completed within the promise window.

### Mean time to schedule (mins)

Average time to schedule from the time the work order was created to the time of the first booking.

### Mean time to travel (hrs)

Average time taken by an agent to travel to the customer. Calculated for all non-agreement work orders. 

### Mean time to complete (hrs)

Average time taken to complete all the bookings for a specific work order from the date the work order was created.

### Number of incidents types

Distinct count of the incident types that have been mapped to the work orders.

### Work orders by system status

Represents the number of work orders by   status.

### Work order trends by system status

Represents the trend of work orders created and their associated statuses.

### Work orders by substatus

Represents the number of work orders created and their current substatuses.

### Work order trends by work order type

Represents the trend of work orders created by types.

### Mean time to complete by work order type (mins)

Represents average time to complete the work   order.

### Work orders by primary incident type

Represents  work orders by primary incident type. 

### Broken promise (%) by work order type

Represents the correlation between broken promise percentage and work order type.

### Broken promise (%) vs mean time to schedule (mins)

Represents the correlation between broken promise percentage and mean time to schedule in minutes.

### Broken promise (%) vs mean time to travel (hrs)

Represents the correlation between broken promise percentage and mean time to travel  in hours.

### Territory analysis

Shows a filled map for each territory. Upon hover on a specific territory, you'll see the number of bookings. Note: The territory is based on the territory entity. For this report to properly render, the territory needs to be a physical geolocation rather a logical geolocation.

<!--
|    Visuals                                               |    Description                                                                                                                                                                                                                                                                                              |
|----------------------------------------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|    Work orders                                           |    Total number of work orders created for the selected filters.                                                                                                                                                                                                                                          |
|    Open work orders                                      |    Total number of currently open work orders.                                                                                                                                                                                                                          |
|    Broken promise (%)                               |    Percentage of work orders that were not completed within the promise window.                                                                                                                                                                                                                                        |
|    Mean time to schedule (mins)                          |    Average time to schedule from the time the work order was created to the time of the first booking.                                                                                                                                                                                                        |
|    Mean time to travel (hrs)                             |    Average time taken by an agent to travel to the customer. Calculated for all non-agreement work orders.                                                                                                                                                                                        |
|    Mean time to complete (hrs)                           |    Average time taken to complete all the bookings for a specific work order from the date the work order was created.                                                                                                                                                                                  |
|    Number of incidents types                             |    Distinct count of the incident types that have been mapped to the work orders.                                                                                                                                                                                                                        |
|    Work orders by system status                          |    Represents the number of work orders by   status.                                                                                                                                                                                                                                           |
|    Work order trends by system status                    |   Represents the trend of work orders created and their associated statuses.                                                                                                                                                                                                                      |
|    Work orders by substatus                              |   Represents the number of work orders created and their current substatuses.                                                                                                                                                                                                                     |
|    Work order trends by work order type                  |    Represents the trend of work orders created by types.                                                                                                                                                                                                                               |
|    Mean time to complete by work order type (mins)     |    Represents average time to complete the work   order.                                                                                                                                                                                                                                           |
|    Work orders by primary incident type                  |    Represents  work orders by primary incident type.                                                                                                                                                                                                                  |
|    Broken promise (%) by work order type                 |    Represents the correlation between broken promise percentage and work order type.                                                                                                                                                                                                                    |
|    Broken promise (%) vs mean time to schedule (mins)    |    Represents the correlation between broken promise percentage and mean time to schedule in minutes.                                                                                                                                                                                                       |
|    Broken promise (%) vs mean time to travel (hrs)       |    Represents the correlation between broken promise percentage and mean time to travel  in hours.                                                                                                                                                                                                          |
|    Territory analysis                                    |    Shows a filled map for each territory. Upon hover on a specific territory, you'll see the number of bookings. Note: The territory is based on the territory entity. For this report to properly render, the territory needs to be a physical geolocation rather a logical geolocation.       | -->

[!INCLUDE[footer-include](../includes/footer-banner.md)]
