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

While managing resources' availability and scheduling work orders, dispatchers must be aware of important updates and status changes to ensure accurate schedules and timely job completion. As an example, a dispatcher may need to be aware if a field technician is running late or prerequisites for a job have not been met to take appropriate actions. Beyond scheduling, dispatchers may also need to ensure billing and customer satisfaction concerns are taken care of.

To bring important notifications to the dispatchers' attention, Dynamics 365 for Field Service offers a feature called Booking Alerts that display notes and reminders on the schedule board where dispatchers spend most of their time. These alerts can relate to bookings, work orders, users, and other entities and can be triggered based on timers, set alarms, or workflows.


> [!div class="mx-imgBorder"]
> ![Screenshot of Manual creation of a booking alert](./media/scheduling-booking-alert-schedule-board.png)

There are three significant additional benefits: 

1)	A booking alert has a start time after which it will be shown.
2)	A booking alert can be assigned to one or many users.
3)	Using the “Snooze” button the alert will disappear and re-appear after the desired time. This helps the dispatcher handle multiple issues in parallel.

Though the goal of a modern business application is to introduce automation for routine tasks, booking alerts can help remind dispatchers to perform the remaining manual processes; or notify them of automated process that have taken place.

In this article let's talk about creating and viewing Booking Alerts.

## Prerequisites

- Field Service v6.1+
- Field Service - Dispatcher security privileges. 


## Create a booking alert
Let's say the dispatcher wants to set herself a reminder. On the schedule board, click the Actions button and select **New Booking Alert**.


> [!div class="mx-imgBorder"]
> ![Screenshot of Manual creation of a booking alert](./media/manual-creation-of-a-booking-alert.png)

The New Booking Alert window pops up.

> [!div class="mx-imgBorder"]
> ![Screenshot of Booking alert](./media/booking-alert.png)
 
**Subject** and **Description** define the message that will appear on the alert. 

**Priority** will not trigger different behavior but could be used for additional logic. 

**Regarding** allows the user to link the alert to a specific record. For any entity, the booking alert will immediately show up on the record’s timeline. However, only upon reaching the **Due Date**, the alert will also show up on the schedule boards detail pane, alerts tab. 

An alert can be associated to one or multiple assignees, and each assignee can choose to snooze or dismiss the alert.

> [!Note]
> When setting the **Regarding** field, pay attention to the entity type that you select. By default, the work order, the associated resource requirement and the booking have the same name. On top of the regarding field, you can use a filter to limit results to the desired entity.

## View the booking alert

Once the due date is reached and the alert appears on the schedule board side pane, here is how the alert will look like and how a dispatcher can put an alert on hold by clicking Snooze.


> [!div class="mx-imgBorder"]
> ![Screenshot of Alert - Snooze](./media/alert-snooze.png)
 
### Booking alerts for bookings

In addition, alerts for Bookable Resource Bookings provide an additional feature. They will not only be shown in the booking’s timeline and the details panel, but also in the schedule board alongside a booking time slot, specifically in the upper left-hand corner of the booking. 

 
> [!div class="mx-imgBorder"]
> ![Screenshot of Booking alert on the schedule board](./media/booking-alert-on-the-schedule-board.png)

The icon indicates the number of active alerts for that booking, clicking it expands or collapses the details. Snooze and Dismiss work the same way as in the panel.
 

## Additional Notes

- By creating the booking alert, the system automatically creates one Booking Alert Status record for every assignee. This allows the affected users to individually snooze (there is a field Next Time To Show) or dismiss alerts. When a user dismisses the alert, the Booking Alert Status records gets inactivated. When every assignee dismisses the alert, its Activity Status field is set to Completed.

- In most situations, the user will not create the alert manually. Instead Flow or workflow can be used to automate the record creation upon certain events.

- When deleting records, keep the relationship booking – booking alert – booking alert status in mind. By default, you cannot remove a booking that has booking alerts associated to it.




