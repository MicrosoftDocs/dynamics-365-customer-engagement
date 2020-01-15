---
title: "Install and setup Dynamics 365 for Field Service | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 01/15/2020
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: krbjoran
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: FieldServiceDave
manager: shellyha
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365FS
---

# Integrated technician time tracking



However, organizations that only use one of these products will not be required to install Project Service Automation simply to capture time entries within Field Service. Field Service will support:

- manual time capture 
- automatic time capture for work orders based on booking timestamps
- custom time capture mechanisms unique to specific business processes or needs

Further, this feature makes it simple to configure a solution to create time actuals that capture costs from approved time entries, enabling organizations to drive more accurate accounting practices and profit-loss calculations."


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/booking-timestamps.md.png)

charging scenarios
reporting 
utilization


 Field Service time entry aligns with Dynamics 365 Project Service Automation to capture time entries into the same entity that Project Service Automation has always used for consistent capture, regardless of whether your organization uses Field Service, Project Service Automation, or both.

## Prerequisites
> [!Note]
>

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)

## Manual time entry

### mobile app

## Work orders


## Time off

Time off requests are automatically recorded as time entries as well.

First submit a time off request. This can be done in the web browser or from Field Service Mobile.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/time-entry-new-time-off.png)

A time entry record will automatically be created. The type will be Vacation by default and the entry status will be submitted.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/time-entry-time-off-submitted.png)

Next approve the time off request. This is only required if the resource on the time off request requires approval as defined on the bookable resource record.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/time-entry-time-off-approve.png)

The time entry Entry Status will be updated as approved.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/time-entry-time-off-approve-time-entry.png)

Furthermore, making changes to the date or duration of the time entry will udpate the time off request and vice versa.

> [!Note]
> You can create time off requests from Field Service Mobile in online and offline modes and the time entries will be created upon sync. 



## Configuration considerations

Actuals

## Additional Notes

### See also

[Time and expense in Project Service Automation](https://docs.microsoft.com/en-us/dynamics365/project-service/time-expense-collaboration-guide)

[Bookimg timestamps](booking-timestamps.md)

[Time off requests](submit-approve-time-off-requests.md)