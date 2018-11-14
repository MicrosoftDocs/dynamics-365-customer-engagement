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

This article describes how Field Service utilizes Universal Resource Scheduling (URS). We'll also take a look at how to configure URS for onsite field service scenarios.

## Overview

[Universal Resource Scheduling](../common-scheduler/schedule-anything-with-universal-resource-scheduling.md) (URS) is a Dynamics 365 solution that allows organizations from different industries with different scenarios to assign resources to jobs and tasks. 

URS assigns the best resources to jobs and tasks based on:

- resource availability
- required skills
- promised time windows
- business unit
- geographic territory and more


**Field service organizations** most frequently use URS to schedule mobile resources to location-specific jobs and tasks (as work orders) as the resources travel to various customer locations. Because work orders are generally performed onsite, URS schedules the  resources with **closest proximity** to work orders, reducing travel time and costs. 

In this topic, we'll take a quick look at: 

- URS components
- how URS works with Field Service work orders
- how to schedule work orders with URS
- and basic configuration 

For more detailed information on URS, visit the [Universal Resource Scheduling documentation](../common-scheduler/schedule-anything-with-universal-resource-scheduling.md).

## Components 
When Dynamics 365 for Field Service is installed, URS will install automatically, and will appear in the menu as shown below.
 
> [!div class="mx-imgBorder"]
> ![Screenshot of Screenshot of URS and Field Service apps](media/scheduling-urs-apps.png) 

In general, work orders and related entities are a part of Field Service, while resource- and requirement-related entities are part of URS. All work seamlessly together.

In other words, field service work orders define **what** work needs to be done and **where**, while URS defines **who** can perform the work and **when**.

The following list shows which components correspond to Field Service and URS:

- Work orders (**Field Service**)
- Bookable resources (**Universal Resource Scheduling**) 
- Resource Requirements (**Universal Resource Scheduling**)
- Resource Bookings (**Universal Resource Scheduling**)
- Schedule tools - Schedule Board, Schedule Assistant (**Universal Resource Scheduling**)
- Resource Scheduling Optimization (installed separately) (**Universal Resource Scheduling**)

For more information, visit the [Universal Resource Scheduling documentation](../common-scheduler/schedule-anything-with-universal-resource-scheduling.md).


## How URS works with Field Service work orders 

Now that we've looked at how the various components correspond with Field Service and URS, let's look at what happens when URS interacts with Field Service work orders.

### Creating work orders creates requirements
When a work order is created and saved, a related requirement automatically generates in the background. This requirement (which is a separate entity) outlines the specific details for resources that can perform the work order. The requirement is what will be scheduled to resources, and it simply references the work order.

By default, one requirement is created but a single work order can have multiple requirements. Additionally, a requirement group with multiple requirements can also be added to a work order.

> [!div class="mx-imgBorder"]
> ![Screenshot of related requirement](media/scheduling-urs-work-order-related-requirement.png) 

### Fields passed from work order to requirements

When a requirement is created, it inherits attributes from the work order, including but not limited to:

- Name (work order number text)
- Work order (lookup reference to work order)
- Work location (typically set to onsite by default, meaning a latitude and longitude must be set. Location agnostic work orders are supported)
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

Updating work order attributes will update requirement attributes. Manual edits to requirements can be made before scheduling, too.

> ![Note]
> Many work order attributes are added to the work order when work order incident types are created, including duration and characteristics. 

## Scheduling work orders with URS

After a work order and related requirement are ready to be scheduled, URS scheduling tools can be used to **book** the requirement to the most appropriate resource.

After a work order requirement is booked, a bookable resource booking record is created documenting the resource, travel time, and start/end time. The booking relates to both the work order and requirement.

There are several ways to book with URS. You can book from: 

- work orders
- requirements
- the schedule board
- Resource Scheduling Optimization (RSO)

See below for details.  

### Book from the work order

Selecting **Book** from the work order will trigger the URS schedule assistant to match the related work order requirement with available resources.

> [!div class="mx-imgBorder"]
> ![Screenshot of booking from work order](media/scheduling-urs-work-order-book.png) 

### Book from the requirement

Like with work orders, the same booking experience can be triggered from the requirement entity, by selecting **Book** while on the requirement.

> [!div class="mx-imgBorder"]
> ![Screenshot of booking requirement](media/scheduling-urs-work-order-related-requirement-book.png) 

### Book from the schedule board

The lower schedule board pane displays requirement records and can be configured to show only requirements related to work orders with a simple view filter.


> [!div class="mx-imgBorder"]
> ![Screenshot of schedule board](media/scheduling-urs-schedule-board-schedule-assistant.png) 

The requirement can be manually dragged and dropped or clicked to "search availability" with the schedule assistant. 

### Book via Resource Scheduling Optimization

[Resource Scheduling Optimization](rso-overview.md) can automatically schedule requirements related to work orders based on a predefined schedule or triggers, or can be done manually.

> [!div class="mx-imgBorder"]
> ![Screenshot of Resource scheduling Optimization schedule](media/scheduling-urs-rso-schedule.png)

## Configure URS for Field Service 

Here are a few things you'll need to configure before getting started with URS for Field Service.

### Enable work orders for scheduling

Navigate to **Resource Scheduling > Administration > Enable Resource Scheduling for Entities**.

> [!div class="mx-imgBorder"]
> ![Screenshot of Enabling entities for scheduling](media/Perform-Initial-Configurations-image8.png)

This is where administrators decide which entities can be scheduled to resources. When Field Service is installed, work orders are enabled for resource scheduling by default. 

Double click on work orders to define default behavior when scheduling work order requirements.

### Connect to maps
Connecting to a mapping service is critical if you want to geographically display work orders and route field technicians.

To connect a mapping service, navigate to **Resource Scheduling > Administration > Scheduling Parameters**.

> [!div class="mx-imgBorder"]
> ![Screenshot of Resource Scheduling Administration in Dynamics 365 dropdown menu](media/Perform-Initial-Configurations-image6.png)  

Set **Connect to Maps** to **Yes**.

The API key will populate automatically and use the Bing Maps API.

> [!div class="mx-imgBorder"]
> ![Screenshot of setting Connect to Maps to yes](media/Perform-Initial-Configurations-image7.png)  

**Save and close.**

### Configure booking statuses 
Resources (field technicians) interact with booking statuses to communicate to stakeholders the progress of their work. For field service, booking statuses can update work order system statuses. This is done by noting a Field Service Status on the Booking Status.

Navigate to **Resource Scheduling > Booking Statuses**

See the image below for the recommended out-of-the-box values.

> [!div class="mx-imgBorder"]
> ![Screenshot of Booking Statuses](media/scheduling-booking-status-fs.png)

### Geo-locate resources

Work order locations are defined by the latitude / longitude of either the work order form, or the related service account. It's important to also geo-locate resources.

Navigate to **Resource Scheduling > Resources**.

To ensure resources can appear on the schedule board map, they must have a geocoded starting and ending location. 

This is done one of two ways:

1. Set resource start/end location to **Resource address** and ensure the related resource record (User, Account, Contact) as defined by the resource type has latitude and longitude values.

> [!div class="mx-imgBorder"]
> ![Screenshot of resource address](media/scheduling-resource-address.png)

> [!div class="mx-imgBorder"]
> ![Screenshot of resource address](media/scheduling-urs-resource-type.png)


For example, in the image above, the bookable resource has resource type = Contact; this means the related contact record must be geo-coded, meaning latitude and longitude fields must have values. 

> ![Note]
> For routing purposes, the location of a resource is defined as the current work order location, current location of the mobile device, or the start/end location defined here when the other options are not applicable.

2. Set resource start/end location to **Organizational Unit Address** and ensure the related organizational unit record is geo-coded, meaning latitude and longitude fields must have values.


> [!div class="mx-imgBorder"]
> ![Screenshot of resource address](media/scheduling-urs-resource-organizational-unit.png)

**Pro Tip:** You may have to add the latitude/longitude fields to the organizational unit entity form.

### See also
- [Frequently asked questions about the mobile solution](http://www.resco.net/mobilecrm/support.aspx) 
- [Woodford guide (PDF)](https://www.resco.net/downloads/Woodford_Guide.pdf) 
