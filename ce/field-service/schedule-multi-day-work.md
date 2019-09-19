---
title: "Schedule work for multiple days | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 09/12/2019
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

# Schedule work over multiple days 

Work orders for on site service and requirements for other business needs can be scheduled across multiple days and weeks. A common example is scheduling a 40 hour requirement across an entire work week where the field technician is expected to perform more detailed work at the same location each day. 

Dispatchers can schedule multi-day work in between existing bookings, by double booking existing schedules, or as a continuous block of time. 

When scheduling multi-day work orders or requirements, dispatchers can choose an allocation method that dictates how the duration is split up throughout the days and weeks.

### Allocation methods 
- Full capacity
- Percentage capacity
- Distribute evenly
- Front load

For more details see the topic on [Allocation methods](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/project-service/faq-allocation-methods).

Let's explore multi-day scheduling and allocation methods by configuring three scenarios:

**Scenario 1:** Schedule a 30-hour installation work order manually from the schedule board.

**Scenario 2:** Schedule a 30 hour requirement with the schedule assistant.

**Scenario 3:** Schedule and divide a 30 hour requirement among two resources with the schedule assistant.


## Prerequisites
If the work you wish to schedule spans multiple weeks or has dependencies on previous steps and milestones, you should consider using Dynamics 365 Project Service which has [Gantt chart functionality](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/project-service/schedule-project-work-breakdown-structure). 


## Scenario 1: Schedule a multi-day work order manually on the schedule board

First create a work order with a duration longer than one day. 

This is done by 

1) adding a primary incident type with a long duration (in the image below 1.25 days = 30 hours)
2) adding multiple incident types where the sum of each incident duration adds up to more than 1 day, or
3) not adding any incident types but entering a duration on the related resource requirement after the work order is created and saved.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-multi-day-work-order-30.png)

After the work order is saved, a resource requirement is automatically created and you can access it by going to **Related > Requirement** from the work order section menu. 

If you have not done so, enter a multi-day duration in the **Duration** field, as well as **From Date** and **To Date** that describes the date range the multi-day work should be spread across. 

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-multi-day-requirement-30.png)

**Pro Tip:** The requirement From Date and To Date will populate with the **Date Window Start** and **Date Window End** work order field values.


Next, go to the Hours view of the schedule board and select the multi-day work order requirement in the lower pane.

Then select a Resource on the board you would like to schedule the multi-day work order requirement to. DO NOT drag and drop.

> [!Note]
> Dragging and dropping a multi-day requirement onto the Hours view will create a long continuous booking through non-working hours.

A "Create Resource Booking" pane will display on the right where you can confirm or edit:

> **Start Date and End Date:** populated from Requirement From Date and To Date fields.

> **Booking Status:** Work order requirements are typically given a Booking Status of "Scheduled" by default but you can choose from your organization's statuses here.

> **Booking Method:** Select the Allocation Method to define the pattern of how the requirement should be spread across the Start and End Dates. 


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-multi-day-work-order-30-schedule-board.png)

After selecting Book, the system will create multiple bookings across multiple days.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-multi-day-work-order-30-schedule-board-booked.png)

On the Days view of the schedule board, you can see the booking pattern more easily. In our example we chose a Booking Method (allocation method) of Front Load Hours so the bookings filled the Resource's available time with the left over duration on the last day. 

**Pro Tip:** Using Front Load Hours as the booking method (allocation method), creates multiple bookings **around** the resource's existing schedule in instances where other bookings exist for the scheduled resource.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-multi-day-work-order-30-schedule-board-booked-wrapped.png)


Unlike dragging and dropping a multi-day requirement on the Hours view, doing so on the Days view will trigger the "Create Resource Booking" side panel to schedule multi-day bookings like above.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-multi-drag-schedule-board.png)

## Scenario 2: Schedule a multi-day requirement with the schedule assistant

Unlike the previous scenario, rather than starting by creating a work order, we will start by creating a resource requirement.

Go to **Resource Scheduling > Resource Requirements > +New**

Enter a **Name**

**From Date** and **To Date**: represents the date range the multi-day requirement should be spread across.

**Allocation Method**: Select one of the following:

- Full capacity
- Percentage capacity
- Distribute evenly
- Front load

For more details see the topic on [Allocation methods](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/project-service/faq-allocation-methods).

> [!Note]
> You need to set an allocation method before saving

**Duration:** Enter a multi-day duration i.e. 30 hours

**Save**

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-multi-day-requirement-allocation-method.png)

Next, enter other requirement details such as skills, roles, resource preferences, service territory, etc that define the eligible resources.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-multi-day-requirement-30-no-work-order.png)

From the newly created requirement go to **Related > Requirement Details**

Requirement details are automatically created based on the duration and the allocation method to split up the requirement into time segments. In our example in the image below, a 30 hour requirement split up between 5 days, is 6 hours or 360 minutes each day.  

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-multi-day-requirement-30-requirement-details.png)

The requirement details are based on the requirement's calendar, which you can edit by selecting **Modify Calendar** in the top ribbon of the requirement.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-multi-day-requirement-30-modify-calendar.png)

Then select **Book** to trigger the schedule assistant for this multi-day requirement.

Resources with availability and that meet the other attributes will show as results. Simply select a resource, the dates, and then book.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-multi-day-requirement-30-schedule-assistant.png)

Once booked, you'll see the resource's availability decrease and the fulfilled duration increase. In our example, 30 hours of duration were fulfilled, 6 of 6 hours booked each day; and the resources 8 hours of availability was reduced to 2 hours each day.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-multi-day-requirement-30-schedule-assistant-booked.png)


> [!Note]
> This scenario scheduled a requirement without a related work order. To schedule a multi-day work order with the schedule assistant you'll need to manually add a related requirement to a work order and delete or disregard the automatically created one. This is because you need to set an allocation method before saving and the requirements work orders automatically create do not allow you to do this.


## Scenario 3: Schedule a multi-day requirement to multiple resources

As in the last scenario, manually create a multi-day requirement. The requirement can exist on its own or be related to a work order.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-multi-2-person-requirement.png)

From the newly created requirement go to **Related > Requirement Details** then choose **Specify Pattern** from the top ribbon. 

THis allows you to edit and override the pattern created by the allocation method.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-multi-day-requirement-2-resource-specify-pattern2.png)

Choose **Book**.

Select a Resource and specific days of just that resource, then choose Book (not Book & Exit because that will close the schedule assistant.)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-multi-2-person-requirement-book-1.png)

Then choose another resource and specific days for only that resource. Then choose **Book**.
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-multi-2-person-requirement-book-2.png)

Bookings are created for each resource on the days selected. Availability for each scheduled resource are updated as well.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-multi-2-person-requirement-book-final.png)

## Configuration considerations

- full capacity uses calendar
- when scheduling 4 hours each day, they need 4 total hours, not 4 continuous hours
- manual create details when allocation method is none
- cannot schedule greater than calendar
- front load vs full capacity

## Additional Notes
- remaining duration
- work order auto creates requirements
- cannot schedule requirement groups for multiple days, meaning you cannot break it up
- travel time? does not include travel time, books as location agnostic

### See also
[Allocation methods](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/project-service/faq-allocation-methods)