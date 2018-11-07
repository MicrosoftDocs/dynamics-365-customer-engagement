---
title: "Universal Resource Scheduling for Field Service | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 11/06/2018
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


# Universal Resource Scheduling for Field Service

The purpose of this article is to understand how Field Service utilizes Universal Resource Scheduling (URS) and configure URS for onsite field service scenarios.

## Overview

[Universal Resource Scheduling](../common-scheduler/schedule-anything-with-universal-resource-scheduling.md) (URS) is a Dynamics 365 solution that allows organizations from different industries with different scenarios to assign resources to jobs/tasks. 

URS assigns the best resources to jobs/tasks based on:
- resource availability
- required skills
- promised time windows
- business unit
- geographic territory and more

For more information go to the [Universal Resource Scheduling docs site](../common-scheduler/schedule-anything-with-universal-resource-scheduling.md)

**For field service organizations**, the main application of URS is scheduling location specific jobs/tasks (work orders) to mobile resources as they travel to various customer locations each day. Because work orders are generally performed onsite at customers' locations, URS helps schedule the **closest proximity** resources to work orders; reducing travel time/costs and saving organizations money. 

 

## Components 
When Dynamics 365 for Field Service is installed, URS is automatically installed as an additional app.
 

> [!div class="mx-imgBorder"]
> ![Screenshot of Screenshot of URS and Field Service apps](media/scheduling-urs-apps.png) 

In general, Work Orders and related entities are part of Field Service, and Resource and Requirement related entities are part of URS, but all work seamlessly together.

More specifically, field service work orders define **what** work needs to be done and **where**, and URS defines **who** can perform the work and **when**.

- Work orders (**Field Service**)
- Bookable resources (**Universal Resource Scheduling**) 
- Resource Requirements (**Universal Resource Scheduling**)
- Resource Bookings (**Universal Resource Scheduling**)
- Schedule tools - Schedule Board, Schedule Assistant (**Universal Resource Scheduling**)
- Resource Scheduling Optimization (installed separately) (**Universal Resource Scheduling**)


For more information go to the [Universal Resource Scheduling docs site](../common-scheduler/schedule-anything-with-universal-resource-scheduling.md)


## How work orders are compatible with URS 

### Creating work orders creates requirements
When a work order is created and saved, a related requirement is automatically created in the background. The requirement outlines the specific details of resources that can perform the work order and is a separate entity. The requirement is what will be scheduled to resources and it simply references the work order.


By default, one requirement is created but a single work order can have multiple requirements. Additionally, a requirement group with multiple requirements can be added to a work order as well.

> [!div class="mx-imgBorder"]
> ![Screenshot of related requirement](media/scheduling-urs-work-order-related-requirement.png) 

### Fields passed from Work Order to Requirements

When the requirement is created, it inherits attributes from the work order including but not limited to:

- Name - work order number text
- Work order - lookup reference to work order
- Work location - typically set to onsite by default meaning a latitude and longitude must be set. Location agnostic work orders are supported.
- Latitude
- Longitude
- Service Territory
- Duration 
- Start / End date
- Priority
- Characteristics
- Preferred/restricted resources
- Fulfillment preference


> [!div class="mx-imgBorder"]
> ![Screenshot of Requirement data1](media/scheduling-urs-work-order-related-requirement-number.png) 

> [!div class="mx-imgBorder"]
> ![Screenshot of Requirement data](media/scheduling-urs-work-order-related-requirement-fields.png) 

Updating work order attributes will update requirement attributes. Manual edits to requirements can be made before scheduling as well.

> ![Note]
> Many work order attributes are added to the work order when work order incident types are created including duration and characteristics 

## Scheduling Work Orders with URS

After a work order and related requirement are ready to be scheduled, URS schedule tools can be used to **book** the requirement to the most appropriate resource.

After a work order requirement is booked, a Bookable Resource Booking record is created documenting the resource, travel time, and start/end time among other things. The booking relates to both the work order and requirement.

### - Book from the work order

Selecting **Book** from the work order will trigger the URS schedule assistant to match the related work order requirement with available resources.

> [!div class="mx-imgBorder"]
> ![Screenshot of booking from work order](media/scheduling-urs-work-order-book.png) 

### - Book from the requirement

Alternateivly, the same booking experience can be triggered from the requirement entity

> [!div class="mx-imgBorder"]
> ![Screenshot of booking requirement](media/scheduling-urs-work-order-related-requirement-book.png) 

### - Book from the schedule board

The lower schedule board pane displays requirement records and can be configured to show only requirements related to work orders with a simple view filter.


> [!div class="mx-imgBorder"]
> ![Screenshot of schedule board](media/scheduling-urs-schedule-board-schedule-assistant.png) 

The requirement can be manually dragged and dropped or clicked to "search availability" with the schedule assistant. 

### - Book via Resource Scheduling Optimization

Resource Scheduling Optimization can automatically schedule requirements related to work orders based on a predefined schedule, triggers, or manually.

 > [!div class="mx-imgBorder"]
> ![Screenshot of Resource scheduling Optimization schedule](media/scheduling-urs-rso-schedule.png)

## Configure URS for Field Service 
### Enable work orders for scheduling

Navigate to **Resource Scheduling > Administration > Enable Resource Scheduling for Entities**.

> [!div class="mx-imgBorder"]
> ![Screenshot of Enabling entities for scheduling](media/Perform-Initial-Configurations-image8.png)


This is where administrators decide which entities can be scheduled to Resources. When Field Service is installed, work orders are enabled for resource scheduling by default. 

Double click on Work Orders to define default behavior when scheduling work order requirements.

### Connect to maps
Connecting to a mapping service is important for using URS for Field Service to display work orders and route field technicians.

Navigate to **Resource Scheduling > Administration > Scheduling Parameters**.

> [!div class="mx-imgBorder"]
> ![Screenshot of Resource Scheduling Administration in Dynamics 365 dropdown menu](media/Perform-Initial-Configurations-image6.png)  

Set **Connect to Maps** to **Yes**.

The API key will populate automatically and use the Bing Maps API.

> [!div class="mx-imgBorder"]
> ![Screenshot of setting Connect to Maps to yes](media/Perform-Initial-Configurations-image7.png)  

**Save and close.**

### Configure booking statuses 
Navigate to **Resource Scheduling > Booking Statuses**

Resources (field technicians) interact with booking statuses to communicate to stakeholders the progress of their work. For field service, booking statuses can update work order system statuses. This is done by noting a Field Service Status on the Booking Status. Recommended out of the box values can be seen in the image below.

> [!div class="mx-imgBorder"]
> ![Screenshot of Booking Statuses](media/scheduling-booking-status-fs.png)

### Geo-locate resources

Work orders have a location defined by the latitude and longitude of the work order form or the related service account latitude and longitude. It is important to also geo-locate resources.

Navigate to **Resource Scheduling > Resources**

To ensure Resources can appear on the schedule board map, they must have a geocoded starting and ending location. 

This is done 2 ways:

1. Set resource start/end location to **Resource address** and ensure the related resource record (User, Account, Contact) as defined by the resource type has a latitude and longitude value.

> [!div class="mx-imgBorder"]
> ![Screenshot of resource address](media/scheduling-resource-address.png)

> [!div class="mx-imgBorder"]
> ![Screenshot of resource address](media/scheduling-urs-resource-type.png)


As an example, in the image above, the bookable resource has resource type = Contact so the related Contact record must be geo coded meaning latitude and longitude fields must have values. 

> ![Note]
> For routing purposes, the location of a resource is defined as the current work order location, current location of the mobile device, or the start/end location defined here when the other options are not applicable.

2. Set resource start/end location to **Organizational Unit Address** and ensure the related Organizational Unit record is geo coded meaning latitude and longitude fields must have values.


> [!div class="mx-imgBorder"]
> ![Screenshot of resource address](media/scheduling-urs-resource-organizational-unit.png)

**Pro Tip:** You may have to add the latitude/longitude fields to the organizational unit entity form.

### See also
- [Frequently asked questions about the mobile solution](http://www.resco.net/mobilecrm/support.aspx) 
- [Woodford guide](https://www.resco.net/downloads/Woodford_Guide.pdf) 





