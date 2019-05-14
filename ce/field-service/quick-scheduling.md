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

When quick scheduling, also known as the Quick Book feature, is not enabled, the book button defaults to the full schedule assistant experience that displays additional information and filter options for more comprehensive resource assigning.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-quick-book-schedule-assistant.png)

## Prerequisites

Field Service v8.7+, see the additional notes section at the bottom of this article for more details.

Enable quick scheduling by going to **Resource Scheduling > Settings > Administration > Enable Resource Scheduling for Entities**

Then double click an entity to display the entities Booking Setup Metadata.

Set **Enable Quick Book** to **Yes**.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-enable-quick-book.png)

In the example above we enabled quick book for the work order entity meaning quick book will trigger from the work order form and requirements created with work orders.

Some organizations use requirements on their own for scheduling, unrelated to entities like work orders. Organizations like this should enable quick book for the **Default Metadata Settings (none)** option.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-quick-book-default-metadata-setting.png)

## Quick book a single resource

### Create a work order

First create a work order or another entity that is enabled for scheduling and quick booking.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-quick-book-create-work-order.png)

Then go to the related requirement and add additional attributes. This is to add more details for the desired resource to schedule this requirement to.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-quick-book-requirement.png)

In our example above, we are looking for a resource within the specified date range with the "Assembly Repair" skill and part of the "Seattle" Organizational Unit.

### Select book

From the requirement or the work order select **Book** in the top ribbon. This opens the quick book side panel interface. When quick book is not enabled, the Book button triggers the Schedule Assistant interface.

Next, all you need to do is select a time slot and then **Book** at the bottom.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-quick-book.png)

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-quick-book-confirmation.png)


In the background, the system chooses an available resource that also meets the requirement criteria such as skills, organizational unit, etc.

- If the requirement is location based, as in the case of on site work orders or facilities, the system chooses the closest resource. The closest resource is determined based on the resource's starting location or previous work order location. 
- For location agnostic requirements, the system chooses the first available resource based on alphabetical order of the resource's first name. 

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-quick-book-schedule-board.png)

### Filter options 
Though quick scheduling is designed for quick and easy scheduling, the scheduler is still given a few simple filters in the quick book pane.

The date range is taken from the requirement date range and can be edited.

> [!Note]
> Time parameters on the work order such as Date Window Start and End are passed down to requirements and are factored into quick booking.

The **Filters** option on the top allows you to search through All Resources (meaning all resources that meet the requirement criteria) or select a specific resource to quick book to that resource's schedule (again if the selected resource meets the criteria).

Additionally, select the resource icon next to a time slot to see a simple list of applicable resources for that time slot. 

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-quick-book-select-resources.png)

This displays more details such as travel time and distance but still a simpler interface with less details than the full schedule assistant, which can be triggered by selecting the **Open Schedule Assistant** link at the bottom of the Quick Book panel.
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-quick-book-select-resources2.png)

## Quick book multiple resources

Quick scheduling also works with requirement groups, which allow organizations to schedule multiple resources at one time. 

### Create a requirement group

Go to **Resource Scheduling > Requirement Groups > +New**. 

Use the requirement group control to define multiple resources needed. Each row represents a resource requirement.

In the example below, we need two resources each with different skills but part of the same Seattle organizational unit for two hours.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-quick-book-rg.png)

For more details see the topic on [requirement groups](../field-service/multi-resource-scheduling-requirement-groups).

Additionally, select a row and open the form to edit more fields.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-quick-book-rg-open-form.png)

These requirements call for resource types **contact, user, and account,** and have a work location of **onsite** with a location (latitude and longitude)/ This indicates we are sending resource's to the customer's location.
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-quick-book-rg-open-form2and3.png)

Next, from the requirement group control, select Book at the top to trigger Quick Book.

Again, you can select a time slot then book to assign the requirement group to multiple resources, or you can select the resource icon to see the different combinations of resources to fulfill the requirement group.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-quick-book-rg-results-onsite.png)

The results are displayed in order of travel time and distance, and because each resource can be traveling from a different location, travel time and distance is calculated as the average. 

Lastly, as discussed in the [requirement groups](../field-service/multi-resource-scheduling-requirement-groups) topic, requirement groups can include different option sets and quick book will respect these. In the example below, we want to schedule a single resource with both required skills **OR** two resources, each with one skill as denoted by the two options.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-quick-book-rg-option.png)

To utilize requirement groups as part of the work order process, associate a requirement group template to an incident type. See more details in the [requirement groups for work orders](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/field-service/multi-resource-scheduling-requirement-groups#requirement-groups-for-work-orders) section.



## Configuration considerations

- After quick booking a requirement, selecting book again for the same requirement will create an additional booking, and will not re-book the previous one.
- Enabling quick book for a scheduleable entity (work order in this article) is an org wide setting and cannot be applied to specific users or security roles. 

### Consider using fulfillment preferences with quick scheduling

The purpose of quick scheduling is to simplify the scheduling process. [Fulfillment preferences](../field-service/set-up-time-groups) further simplify scheduling by organizing quick book (or schedule assistant) results in neat time blocks.
1. Create a fulfillment preference. In this example we created a fulfillment preference with 1 hour intervals.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-quick-book-fulfillment-preference.png)

2. Add the fulfillment preference to a requirement and quick book. The quick book results will appear in hourly intervals.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduling-quick-book-fulfillment-preference-results.png)


## Additional Notes
- The confirmation message displayed after a quick book is currently not configurable. 
- When quick book is enabled and applicable to the scheduleable entity, it will trigger where ever the Book button is displayed.
- With Field Service v8.7 (Universal Resource Scheduling v3.7) Quick book is disabled by default, but is enabled by default in v8.8+ and 3.8+.
- With Field Service v8.7 (Universal Resource Scheduling v3.7) Quick book is not applicable to onsite requirements, but with 8.8+ and 3.8+ is applicable to onsite, facility, and loction agnostic requirements.


