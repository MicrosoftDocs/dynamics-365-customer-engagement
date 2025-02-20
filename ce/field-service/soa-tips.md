---
title: Tips and troubleshooting for the Scheduling Operations Agent (preview)
description: Learn how to troubleshoot and improve suggested results of the Scheduling Operations Agent for Dynamics 365 Field Service.
ms.date: 03/03/2025
ms.topic: how-to
ms.author: anilmur
author: anilmur
---

# Tips and troubleshooting for the Scheduling Operations Agent (preview)

## Define Resource and Requirement properties

The agent evaluates various properties of resources and requirements. Consistent use of these properties improves the suggested schedule.
Relevant properties include:

- Resources:
  -Work Hours and break times
  -Start Location and End Location
  -Territories
  -Characteristics
- Resource Requirements:
  -From/To Date
  -Duration
  -Priority
  -Time From/To Promised
  -Territories
  -Time Window Start/End
  -Characteristics
  -Resource Preferences

## Manage existing bookings

The agent treats existing bookings the same as unfulfilled requirements, which might result in unexpected results. For example, if a dispatcher asks the agent for a suggested schedule at 10:00 am, the agent might suggest replacing the 10:20 AM booking with higher priority work. That’s a short notice for a technician. You can avoid such cases:

1. Use a custom time range and set it to start an hour or two from the current time.
1. Set bookings that you want to persist to a booking status with an Optimization Method of Do Not Move.
1. Create a requirement view that contains no requirements and choose that view in the agent settings. That way, the agent suggests a schedule that only optimizes the order of existing bookings. It’s especially helpful if you simply want to optimize the travel route for the day. However, keep in mind that the agent can still remove bookings that don’t match other selected settings or where the promised time window has expired.

## Limitation and known issues

While this is a preview capability, there are certain limitations.

- Resource of type Account, Equipment, Pool and Facility are not supported. The agent currently supports User, Contact, or Crew.
- The resource must not be part of a crew during the entire optimization range selected.
- The agent doesn’t consider fulfillment preferences of a requirement.
- The agent will not consider partially fulfilled resource requirements
- The agent needs to run when the resource is available for work. They can’t be on break, off work, traveling to or working on an existing booking.
- The agent works best with Field Service environments that don’t have the Resource Scheduling Optimization add-on installed. Customers with this add-on should use the single resource optimization instead.

Troubleshooting tips
The agent needs to be have eligible bookable resource bookings and unfulfilled resource requirements in order to suggest a schedule. You can get an error message “No bookings or requirements were found (confirm text)” if you run the agent where there are no existing bookings (or bookings are ineligible per constraints [see section above] AND there are no eligible resource requirements (view is empty or returning items that cannot be added to the resource’s schedule). This can also happen if the locations are too far apart – say the resource is based in New York City but bookings/requirements are in Miami.

Existing bookings which have an Optimization Method of Do Not Move are ineligible to be included in a valid suggested schedule, meaning:

- One or more such bookings occur during off hours (breaks, or outside of working hours), or require travel during off hours. This can be difficult to detect in the case of the last booking of the day. Suppose the resource works from 9AM to 5PM and there is a booking on the current schedule from 4PM to 4:30PM that is set to Do Not Move. If the resource cannot travel from the location of that booking back to the End Location of the resource (based on average or predictive travel) then the agent will return an error
- One or more such bookings overlap with each other

> [!NOTE]
> If the bookings above were set to Optimize then the agent would suggest a schedule that rectifies the issues.
