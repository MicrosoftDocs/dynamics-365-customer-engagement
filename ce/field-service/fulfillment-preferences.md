---
title: "Fulfillment preferences in Dynamics 365 for Field Service | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 10/31/2018
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
author: krbjoran
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: FieldServiceDave
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365FS
---

# Fulfillment preferences

Fulfillment preferences (formerly known as time groups) enable organizations to display resource availability search results in the way that best fits their business, such as neat hourly appointments or morning and afternoon time ranges. 

**Without fulfillment preferences**, the schedule assistant will display results based entirely on resources' schedules and the absolute earliest time the resource is available such as **10:39am**. However, **with fulfillment preferences** set to hourly, the same resource's availability would show as **11:00am**. This makes it simpler for the scheduler to view and understand availability and communicate it to the customer.

**Industry example 1:** a hair salon may want to offer appointments every hour because 1 hour time slots is a good time estimate for their work that is mostly consistent and predictable. In addition, when describing available appointments over the phone with customers, it is simpler to communicate 1 hour time slots rather than a variable list of start times.

**Industry example 2** a heating and cooling company would like to group air conditioning installations into morning (8am-12pm) and afternoon (1pm-5pm) time ranges with a 1 hour break for lunch in between. Without fulfillment preferences, the schedule assistant would identify an exact time installation resources are available. However, because installations are dependent on many variables and outside vendors, schedulers do not feel comfortable committing to an exact time but would rather communicate to customers a time range of morning or afternoon when installation resources will arrive to begin working.

The fulfillment preferences feature breaks down into two features: **intervals** and **time groups**. Both are designed for intraday booking and are not designed for multi-day work. 

### Intervals

Intervals display schedule assistant results in neat time slots such as every 15min, 30min, 1 hour, 2 hours, etc **that dictate start time of subsequent bookings**. When intervals are configured in 30 minutes intervals, the schedule assistant will display a 9:27am available resource as 9:30am and will book the start time (arrival time) for 9:30am. This includes travel time for onsite requirements and work orders, meaning travel time will begin before 9:30am and a field resource will arrive and start work at 9:30am. Intervals relate to **industry example 1** above.

### Time groups

Time groups enable schedulers to search and view results in buckets, or blocks of time, when using the Schedule Assistant. Typical examples include morning, afternoon, night, 2 hour blocks, etc. The main difference compared to intervals is time groups **do not dictate the start time of subsequent bookings**. Time groups are a facade that organize results but leave the start time/arrival time as is, based on the particular resource's schedule. For example, when a time group is created for morning (8am-12pm) the schedule assistant will display resource's absolute and earliest times within the morning bucket. For instance, results will show a list of possible resources to start at 8:32am 9:07am, 11:23am and all results will appear within the "morning" time group because the start times fall within the 8am-12pm time group. Time groups relate to **industry example 2** above.


### Intervals and time groups

Intervals and time groups can be combined to offer predefined time slots within a predefined time block. An example is grouping 1 hour appointment time slots within morning and afternoon groups. This would allow a scheduler to first identify if morning or afternoon works better for the customer, and then offer an appointment. This further simplifies the scheduler experience and communication to the customer.

## Prerequisites

Field Service v8.0+
Universal Resource Scheduling v3.1+

## Instructions 

Below find instructions to set up intervals, time groups, and intervals + time groups

### Intervals

1) create fulfillment preference
2) add interval
3) specify fulfillment preference on the requirement
4) Book the requirement via Resource Availabilty Search (Schedule Assistant)

#### 1) create fulfillment preference

Navigate to **Universal Resource Scheduling > Fulfillment preferences > +New**

Enter a **name**

#### 2) add interval

Navigate to the **Intervals** tab

**Interval** - enter a duration. This is the duration between available time slots. Typical examples include 30 min, 1 hour, 2 hours.

**Interval Begins** - enter a time to begin counting the interval. Typical example is 12:00 AM making options 12:00am, 12:30am, 1:00am, etc; however results will also depend on resource availability and working hours. If left blank, the interval will begin at the time of booking. As an example, if my interval is 30 min and Interval Begins is blank, and I attempt to book at 11:13am, possible time slots will be 11:13am, 11:43am, 12:13pm, etc. 

**results per interval** - Enter a number, typical example is 5. This dictates how many options a scheduler will be given for each interval. If left blank, system defaults to 1 and this is editable in Resource Availability Search interface.

**Save**

1) specify fulfillment preference on the requirement

Navigate to the requirement you would like to schedule and specify the fulfillment preference.

This can also be done from the requirement group control

> [!Note]
> Each requirement can be linked to a single fulfillment preference record, and when scheduling that requirement, the fulfillment preferences are respected. Either manually or with workflows, fulfillment preferences can be added to requirements based on type of requirement, the location of the branch fulfilling the requirement, or any other variable the business may have.

4) Book the requirement via Resource Availabilty Search (Schedule Assistant)

Select **Book** from the requirement ribbon

Note the start times appearing in 30 minute intervals.

> [!Note]
> The “estimated arrival time” is the attribute that dictated by the interval. When scheduling requirements where the “work location” is “location agnostic” or “facility”, the travel start time and the estimated arrival time are identical, since there is no travel. When work location is “onsite”, the travel can begin anytime, but the estimated arrival time, being the time when resources are expected to arrive at the customers site, is the time that needs to coincide with the interval.


**ProTip:** For field service examples where resources perform multiple appointments each day, a shorter interval of 15 minutes is recommended. This balances keeping utilization high with simplified start times.


### Time groups

1) create fulfillment preference
2) add time group detail(s)
3) specify fulfillment preference on the requirement
4) Book the requirement via Resource Availabilty Search (Schedule Assistant)


Time Group Details Setup
In order to setup time group details, first you create a Fulfillment Preference record and save. Then, you add new Time Group Details. 


### Intervals + Time groups

Schedule Assistant results must fall on an expressed interval, and within a Time Group Detail. However, the “Intervals Begin” feature becomes irrelevant once there are Time Group Details. If there are TGD’s, you can no longer arbitrarily decide when to start counting your intervals from. Rather, the intervals are automatically counted from the beginning of the first Time Group Detail. For example, if there are two TGD’s, 8 AM to 12 PM and 12 PM to 4 PM, the intervals will begin counting at 8 AM.


## Intervals


## Time Group Detail

offer time ranges to customers

group by time group

can block out time- prevents start time but not overtime

its when appointment starts

## Instructions

## Configuration

### Results per Interval
results per interval: default is 1
Sometimes, less is more, and it may not make sense to provide your schedulers with ALL the booking options at 9:30 AM. Therefore, we added a feature that allows you to control how many different resources, or resource combinations (when scheduling a requirement group), will be provided to the scheduler to choose from, for each interval, per day. The option is called “Results per Interval”. By way of example, if this attribute is set to 3, and Interval is set to 30 minutes, then you will see three results at 9 am, three results at 9:30 am, for each day within in the search range.

### Intervals Begin

intervals Begin: without itll be on hour from booking time

When displaying results by interval, when you begin counting the intervals from can have implications on the times your schedulers are presented. If the interval is a factor of 60 (minutes), such as 5 minutes, 10, 15, 20, 30, or 60 minutes, as long as the interval is counted from the top of the hour, (e.g. 8 AM, 9 AM, 10 AM, etc), it doesn’t matter which top of the hour it begins counting from, as the intervals will be the same. However, if the interval is not a factor of 60, such as 45 minutes, the time when we start calculating intervals is very important. Therefore, you can use the “Intervals Begin” attribute on the fulfillment preference to determine when the intervals are counted from. 

### Reset Intervals per Time Group Detail
There is an attribute on the fulfillment preference entity called “Reset Intervals per Time Group Detail”. This determines if we start counting the intervals over again at the beginning of each Time Group Detail, or if we count straight through the day from the first TGD. Consider the following scenario: 
A traditional brick and mortar business offers appointments every 45 minutes, and the requirements are all 45 minutes long. They open at 10 AM and close at 6 PM but are closed for lunch from 12 to 12:30. This means they will have one TGD from 10 to 12 and another TGD from 12:30 to 5. 
If they do not reset the intervals per TGD, the appointments available through the day would be:
10, 10:45, 11:30, 1, 1:45, 2 etc. However, with resetting results per Time Group Detail, the results are: 10, 10:45, 11:30, 12:30, 1:15….You can see the impact through this example as fewer appointments would be offered without resetting the results which may, or may not be what is intended.
Another example could be a traditional field service organization that gives their customers 2-hour windows, but internally schedules appointment on 45-minute intervals. This setup would have TGD’s 10 to 12, 12 to 2, and 2 to 4 with 45-minute intervals. If they chose to reset intervals, the appointments being offered would be 10, 10:45, 11:30, 12:00, 12:45, etc. This shrinks the gap between appointments to only 30 minutes as the TGD changes, which may make things too tight on the scheduling side, and resources may never actually be available to be scheduled for the 12 PM appointment.
As a result, customers have the option whether to reset the interval at the beginning of each Time Group Detail based on the scenario and the business needs.



reset intervals per time group detail: example, if you close for lunch

### Hide booking time

## Additional notes
In case of scheduling a requirement group, which has many requirements within it, you can still set the fulfillment preference option on the requirement, and all requirements in that requirement group will inherit the same fulfillment preferences. The Fulfillment Preferences entity was originally named time groups, and therefore, the actual schema name for this entity is “msdyn_timegroup”, although the display name is “Fulfillment Preferences”.

location agnostic and onsite

interval feature - individual requirements + groups

time group details - only work for individual requirements

time zone agnostic - intervals begin doesnt depend on user, it counts from time of requirement being scheduled, when booking from requirement the time zone fo schedule board load in is based on requirement calendar, depends on time zone of requirement unless triggering from schedule board



### Supported vs Not Supported Functionality
In v3.1 of Universal Resource Scheduling (URS), some features will work when scheduling both individual requirements and groups of requirements and some features will not work for both. Please use the table below for guidance.


| Fulfillment Preference Feature  |  Compatible with scheduling a single requirement  |  Compatible with scheduling a requirement group | 
|---|---|---|---|---|
| View Results By Interval  |  Yes |  Yes |
| Change interval on Schedule Board  |  No |  Yes |
| Change Results per Interval on Schedule Board |  No |  Yes |  
|  Results Per Interval |  Yes |  Yes |  
| Intervals Begin |  Yes | No  |   
| Show results by Time Group Detail  | Yes  | No  |  
| Reset Intervals per Time Group Detail  | Yes |  N/A | 
| Display top X results per Time Group Detail  | Yes  |  N/A |
| Hide Booking Time  | Yes (with TGD Only?) |  ?? |
