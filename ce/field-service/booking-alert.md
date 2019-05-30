---
title: "Booking Alerts | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 05/30/2019
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: FieldServiceDave 
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: alheinze 
manager: shellyha
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365FS
---

# Booking Alerts

## Prerequisites
> [!Note]
>




Booking alerts are a way to draw the dispatcher’s attention to an issue that needs attention. This could be that a technician is running late or that prerequisites for a job have not been met. One could alternatively use different color codes for the bookings, however they are based on the booking status and we do not necessarily want to change this just to alert the dispatcher.

There are three significant additional benefits: 

1)	A booking alert has a start time after which it will be shown.
2)	A booking alert can be assigned to one or many users.
3)	Using the “Snooze” button the alert will disappear and re-appear after the desired time. This helps the dispatcher handling multiple issues in parallel.

Booking alerts for any entity

One use case might be that the dispatcher wants to set herself a reminder. On the schedule board, click the Actions button and select New Booking Alert.


> [!div class="mx-imgBorder"]
> ![Screenshot of Manual creation of a booking alert](./media/manual-creation-of-a-booking-alert.png)

The New Booking Alert window pops up.


> [!div class="mx-imgBorder"]
> ![Screenshot of Booking alert](./media/booking-alert.png)
 
Subject and Description define the message that will appear on the alert. Priority will not trigger different behavior but could be used for additional logic. Regarding allows the user to link the alert to a specific record. For any entity, the booking alert will immediately show up on the record’s timeline. However, only upon reaching the Due Date, the alert will also show up on the schedule boards detail pane, alerts tab. An alert can be associated to one or multiple attendees, and each attendee can choose to snooze or dismiss the alert.

When setting the Regarding field, pay attention to the entity type that you select. By default, the work order, the associated resource requirement and the booking have the same name. On top of the regarding field, you can use a filter to limit results to the desired entity.

Here is how the alert will look like and how a dispatcher can put an alert on hold by clicking Snooze.


> [!div class="mx-imgBorder"]
> ![Screenshot of Alert - Snooze](./media/alert-snooze.png)
 
Booking alerts for bookings

In addition to what was explained in the previous section, alerts for Bookable Resource Bookings provide an additional feature. They will not only be shown in the booking’s timeline and the details panel, but also on the schedule board’s Gantt chart, specifically in the upper left-hand corner of the booking. The icon indicates the number of active alerts for that booking, clicking it expands or collapses the details. Snooze and Dismiss work the same way as in the panel.

 
> [!div class="mx-imgBorder"]
> ![Screenshot of Booking alert on the schedule board](./media/booking-alert-on-the-schedule-board.png)
 

## Configuration considerations

## Additional Notes

By creating the booking alert, the system automatically creates one Booking Alert Status record for every assignee. This allows the affected users to individually snooze (there is a field Next Time To Show) or dismiss alerts. When a user dismisses the alert, the Booking Alert Status records gets inactivated. When every assignee dismissed the alert, its Activity Status field is set to Completed.

In most situations, the user will not create the alert manually. Instead Flow or workflow can be used to automate the record creation upon certain events.

When deleting records, keep the relationship booking – booking alert – booking alert status in mind. By default, you cannot remove a booking that has booking alerts associated to it.




