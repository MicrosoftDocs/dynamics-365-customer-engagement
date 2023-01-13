---
title: Apply filters to reports
description: Use this article to learn how to apply and change filters on reports.
author: FeifeiQiu
ms.author: feiqiu
ms.reviewer: mhart
ms.service: dynamics-365-field-service
ms.topic: how-to 
ms.date: 01/11/2023
ms.custom: bap-template 
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
search.app: 
  - D365CE
  - D365FS
---

# Apply filters to reports

You can apply filters to a report to focus on the information in your data set that matters to you.

## Add and update filters on a report

Apply the filters to reports in Dynamics 365 Field Service and the Resource Scheduling Optimization add-in.

1. Open a [report](reports.md).

1. Under the report title, set the value for one or more filter from the following list. Depending on the type of report, only a subset of the filters is available.

   - For reports based on work orders:

        ![Screenshot showing the work order summary report filter options.](./media/report-filter-example.png)
        - **Date range**: A [relative date range](/power-bi/visuals/desktop-slicer-filter-date-range).
        - **Customer**: [Customer accounts](work-order-customer-account.md) configured in Field Service.
        - **System status**: [Booking status of a work order](work-order-status-booking-status.md).
        - **Work order type**: [Work order types](create-work-order-types.md) in Field Service
        - **Substatus**: Custom substatuses related the booking status of a work order.
        - **Service territory**: [Territory](set-up-territories.md) defined in Field Service.
        - **Technician**: [Active bookable resources](set-up-bookable-resources.md) in Field Service.

   - For reports based on resources:

        - **Date range**: A [relative date range](/power-bi/visuals/desktop-slicer-filter-date-range).
        - **Resource type**: <!--add-->
        - **Resource**: [Active bookable resources](set-up-bookable-resources.md) in Field Service.
        - **Booking status**: [Booking statuses](set-up-booking-statuses.md) in Field Service.

<!-- change screenshot to show a report with more filters added--> 

[!INCLUDE[footer-include](../includes/footer-banner.md)]
