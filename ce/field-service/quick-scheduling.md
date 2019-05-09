---
title: "Quick scheduling | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 05/09/2019
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

# Quick scheduling

Quick scheduling simplifies the schedule assistant experience to make scheduling easier and quicker.

Within the same window of a work order, a new panel displays available time slots for booking with a single click.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-quick-book.png)

This is great for several scenarios:

1. Organizations with a high volume of bookings they need to quickly schedule. 
2. Organizations with homogeneous resources who are more concerned with quickly understanding availability and do not need the extra information and filter abilities of the schedule assistant.
3. For users who scheduling is a smaller proportion of their job. As an example, a customer service rep spends most of his or her time handling customer issues, and the few times he or she needs to schedule it should be quick and easy.

When quick scheduling is not enabled, the book button defaults to the full schedule assistant experience that displays additional information and filter options for more comprehensive resource assigning.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-quick-book-schedule-assistant.png)

## Prerequisites

- Field Service v8.7+
> [!Note]
> In Field Service v8.7 quick book capabilities need to be enabled, but in v8.8+ quick book is enabled by default. Quick booking onsite requirements is only available in v8.8+

Enable quick scheduling by going to Resource Scheduling > Settings > Administration > Enable Resource Scheduling for Entities

Then double click an entity to display the entities Booking Setup Metadata.

Set **Enable Quick Book** to **Yes**.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-enable-quick-book.png)

create a work order

select book

notice date range, can edit

select a time slot

if location based - choose the closest resource
if location agnostic - choose 

select a resource
if location based it shows distance

filters

open schedule assistant

requirement group

## Configuration considerations

successfully booked message is not configurable 

quick book again adds on a booking

org level setting, not for certain users or security roles

combine with fulfillment preference

## Additional Notes
- quick scheduling as long as there is a book button and the related entity has it enabled
- We discovered a bug with scheduling onsite requirements, so with this update of URS 3.7.*, the scope of the feature would only be non-onsite requirements (location agnostic, and Facilities). The bug with the onsite requirements scheduling is being fixed and will be pushed in the next update of URS 3.8.*. In this update 3.7.*, this feature will be disabled by default, however, with 3.8.*, we will flip it on all newer orgs

