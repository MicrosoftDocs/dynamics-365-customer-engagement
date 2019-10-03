---
title: "Overnight scheduling with Resource Scheduling Optimization (RSO) | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 10/02/2019
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

# Automated Overnight Scheduling

How and when Resource Scheduling Optimization (RSO) runs is flexible based on your organization's scheduling needs. RSO can be run manually, based on a schedule, or triggered from a workflow; and every run can optimize a specific set of resources, requirements, and bookings that are defined with system views.

Common scenarios include:

- Manual Run  
- Overnight scheduling
- Single resource optimization
- Intraday scheduling
- Condition based workflow action (CreateScheduledOptimizationRequest)
- Simulation 

When it comes to adopting Resource Scheduling tools there is a recommended progression from manual to fully automatic, see the topic on [The 5 stages of scheduling adoption](./5-stages-scheduling-adoption.md).

In this article let's explore overnight scheduling and understand why an organization may choose to optimize work orders this way and how to configure it.

Overnight scheduling means RSO runs each night at a defined time and schedules jobs (e.g. work orders) for the next day. The next morning, a dispatcher arrives to work to find a fully optimized schedule board for that day where jobs are scheduled to the appropriate resources based on skills, promised time windows, preferred resources, roles, and more. For the rest of the day, RSO will not run and the dispatcher will make changes as needed with manual scheduling or the schedule assistant to deal with delays, cancellations, and special customer requests. Overnight scheduling allows RSO to handle the bulk of scheduling to save time while still relying on the expertise of dispatchers who know the work to be done and the resources. 

Setting up this RSO scenario as well as other scenarios involves creating a scope, goal, and schedule. To learn more about these three components of RSO, see the topic on [RSO configuration](./rso-configuration.md).

## Scope
Scopes define the resources, requirements, and booking to optimize.

Go to **Resource Scheduling Optimization app > Optimization Scopes > +New**

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/rso-overnight-scope.png)

Assign a **Name** that describes the scope.

**Range Reference**: set to Job Current Time

**Range Offset**: Set to 1 minute or similar time. Because this RSO will run at night when no one is working, this value does not affect a technician's ability to respond to schedule changes quickly.

**Range Duration**: set to 1 day. This indicates jobs will be booked within a 24 hour period from when RSO runs. Later on we will set RSO to run at midnight.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/rso-overnight-scope-resources.png)

Create and select a Bookable Resource system view or personal view that defines the resources jobs can be scheduled to. In this example we're filtering for Active resources in a specific territory, Washington state (WA). Not shown in this example, but it is common to filter for specific resource types if all these jobs should be scheduled to people (resource type = User, Account, Contact) or machines (resource type = equipment).


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/rso-overnight-scope-requirements.png)

Create and select a Resource Requirement view that defines the unscheduled jobs to book. In this example we're filtering for requirements in the same territory as our resource list (Washington state - WA) that are active, and requirements that are related to unscheduled work orders.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/rso-overnight-scope-bookings.png)

In addition to booking unscheduled jobs, RSO can also shuffle and re-optimize **bookings**. In other words, RSO will update, move, and improve existing schedules. When a requirement is scheduled, a Bookable Resource Booking record is created. So create and select a Bookable Resource Booking. 

In this example, we're filtering for bookings that 
1. are **Active**
2. were previously scheduled by RSO, where **Booking Method = Resource Scheduling Optimization**. This is because we do not want RSO to move bookings that were created manually or with the schedule assistant indicating they were booked by a dispatcher because our scenario assumes dispatchers have priority
3. have booking statuses that indicate it's okay to reschedule them (**Scheduling, Hard, Committed**)
4. relate to resource requirements in the same territory as our resources and requirements (**Washington state - WA**). 

**Save**

## Goal

Goals define what RSO should consider and prioritize.

Go to **Resource Scheduling Optimization app > Optimization Goals > +New**

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/rso-overnight-goal.png)

Set engine effort level to **Moderate**, **Intense**, or **Very Intense**. This means the optimization will take longer to execute but will find a more optimal solution. Because overnight scheduling is intended to run during the night when no one is working and dispatchers and technicians are not waiting for results, you can allow the optimization to take longer. 

Add the constraints RSO should consider based on your business needs. As an example, if your work orders require different characteristics (skills) add the "Meets Required Characteristics" constraint. For more details on constraints, see the topic on [RSO configurations](https://docs.microsoft.com/en-us/dynamics365/field-service/rso-configuration#define-the-optimization-goal).

**Save**

## Schedule

Schedules combine scopes and goals and tell RSO when to run.

Go to **Resource Scheduling Optimization app > Optimization Schedules > +New**

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/rso-overnight-schedule.png)

**Timer**: Set to 1 hour. This means every hour RSO will check the filter panel to see if it should run.

**Timer Mode**: Set to Fixed.

**Valid From and To**: Enter the date range overnight scheduling is valid for. Outside of this date range, RSO will not be triggered, but can always be triggered manually with the **Run Now** button in the top ribbon.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/rso-overnight-schedule-filter.png)

Then head to Filter panel and enter the following values to define when you want RSO to run:
1. Time Zone: enter the time zone of your resources in the scope
2. Hours: enter **12AM** or similar time during the night. 
3. Days of the week: enter days of business operations. Example: Monday - Friday. 

**How Does it work?** Based on the timer, RSO will check the filter panel and run if there is a matching value. In this example, every 1 hour RSO will check to see if the hour of the day is 12am and the day of the week is Monday through Friday. 

**Pro Tip:** If no values are entered in the Filter section, RSO will run according to the timer, in this example every 1 hour.

**Save & Publish**

At this point we are ready to run overnight scheduling with RSO. One option is to wait for the trigger at midnight. Another option is for testing and development purposes to select the Run Now button in the top ribbon.


## Results

Your scope creates a new schedule board tab or you can simply choose Schedule Board from the top ribbon of your Optimization Schedule to see the resources, requirements, and bookings specific to this schedule.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/rso-overnight-results.png)

Here you can see jobs were only scheduled for one working day to our Washington-WA resources.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/rso-overnight-lock.png)

A defining characteristic of overnight scheduling is that dispatchers have priority and changes they make should not be moved by RSO. For this reason, if a dispatcher moves a booking, or schedules a new one from the schedule board or with schedule assistant, it is automatically locked based on the booking method value. A lock icon will appear when viewing the booking on the schedule bard tab related to the optimization scope.

### See also

- [RSO Quickstart](./rso-quickstart.md)
- [Booking lock options](./booking-lock-options.md)
- [RSO configuration](./rso-configuration.md)

