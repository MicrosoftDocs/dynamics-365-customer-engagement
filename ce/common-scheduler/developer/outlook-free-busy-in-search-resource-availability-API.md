---
title: Include Outlook free/busy schedules in search resource availability API
description: Learn how to include Outlook free/busy schedules when calling Universal Resource Scheduling's search resource availability API.
ms.date: 07/28/2025
ms.reviewer: puneet-singh1
ms.subservice: common-scheduler
ms.topic: how-to
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: mkelleher-msft
ms.author: mkelleher
---

# Include Outlook free/busy schedules in search resource availability API 

Universal Resource Scheduling's search resource availability API considers Outlook appointments in Exchange and availability defined in Dynamics (through Bookings and Dataverse Appointments). Resources don't need to manually sync their Outlook appointments to Dataverse. A complete view of availability from both Exchange and Dynamics 365 increases scheduler productivity and reduces scheduling errors.

Some key points:

- This feature only works when directly calling the search resource availability API with **ConsiderOutlookSchedules** as _true_. It doesn't apply to availability searches from the Schedule Board or the **Book** button on any schedulable entity.
- Reading schedules from Exchange increases the time the search resource availability API takes to retrieve results, depending on the number of resources and period of time period considered. We recommend this functionality be used judiciously from custom interfaces designed to work around the retrieval time.
- The feature is available for search resource availability APIs for both requirements ([msdyn_SearchResourceAvailability](/dynamics365/field-service/search-resource-availability-api)) and requirement groups ([msdyn_SearchResourceAvailabilityForRequirementGroup](/dynamics365/field-service/search-resource-availability-api)).
- To protect privacy, the API reads only the start and end times of resources' schedule items and their free/busy status.
- The Outlook "Busy" status is treated as unavailable for scheduling.
- Outlook appointments are considered  location agnostic.

## Prerequisites

- Universal Resource Scheduling 3.12.64.x+, available in Field Service 8.8.52.x+ (2021 October Wave 2)

## Enable setting to include Outlook free/busy in search resource availability API  

You can enable the setting across the organization or by individual resource.

### Enable setting at the organization level

1. Go to **Resource Scheduling** and select the **Settings** area.

1. Select **Administration** > **Scheduling Parameters** and open **Resource Scheduing**

1. Set **Include Outlook Free/Busy in Search Resource Availability API** to *Yes*.

   :::image type="content" source="../media/OutlookFreeBusyInSAAPI-Dialog.png" alt-text="Screenshot of Include Outlook Free/Busy setting in Resource Scheduling.":::

1. In the information dialog box, select **Got it. Let’s enable.** Then **Save and close**.

All resources are automatically opted-in the first time you enable the feature. You can opt out resources using the resource level setting, which is visible only if the organization level setting is set to *Yes*.

Resources automatically receive an email notification each time they're opted in by the user opting them in, if that user has a mailbox with server-side synchronization.

### Enable setting at the resource level

The resource level setting is only available if the [organization level setting is enabled](#enable-setting-at-the-organization-level).

1. Go to **Resource Scheduling** and select the **Settings** area.

1. Select **Resources** and select the resource.

1. Select the **Scheduling** tab and change the **Include Outlook Free/Busy in Search Resource Availability API** field. Then **Save and close**.

## Call the search resource availability API

Call the search resource availability API with **ConsiderOutlookSchedules** as *true*. The feature is available for search resource availability APIs for both requirements ([msdyn_SearchResourceAvailability](/dynamics365/field-service/search-resource-availability-api)) and requirement groups ([msdyn_SearchResourceAvailabilityForRequirementGroup](/dynamics365/field-service/search-resource-availability-api)).

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
