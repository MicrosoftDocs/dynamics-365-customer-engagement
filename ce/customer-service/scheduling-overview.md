---
title: "Customer Service Scheduling - Overview | MicrosoftDocs"
description: "Overview of Service Scheduling migration options in Dynamics 365 Customer Service."
author: lalexms
ms.author: laalexan
manager: shujoshi
ms.date: 10/01/2020
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Upcoming changes to the Service Scheduling experience

As previously announced, the legacy Service Scheduling experience is currently being deprecated in alignment with the expected Unified Interface transition date of 12/01/2020. More information: [Legacy web client is deprecated](https://docs.microsoft.com/power-platform/important-changes-coming#legacy-web-client-is-deprecated). Because of this change, there are currently two approaches you can take to transition to a new scheduling experience. 

## Option #1: Migrate to the Core Service Scheduling experience

The established approach is to migrate to the core Service Scheduling experience built on Universal Resource Scheduling. More information: [Service Scheduling Guide](basics-service-service-scheduling.md). This option is best if you are a new Customer Service user, have already migrated, or are not otherwise blocked by the absence of the features listed in the [Cons of migrating to the Core Service Scheduling experience](#cons-of-migrating-to-the-core-service-scheduling-experience) section below.

Consider the following pros and cons before deciding to migrate.

### Pros of migrating to the core Service Scheduling experience

- It aligns with the long-term strategy of universal resource scheduling.
- Scheduling interoperability is available across Customer Service, Field Service, and Project Service Automation applications.

### Cons of migrating to the core Service Scheduling experience

- Appointment, Recurring Service Appointment, and Customer preferred selection are not supported.
- Schedule boards are not customizable.
- There isn't a public extended API for supporting Appointment and Recurring Service Appointment features.
- Service Restriction is not supported.
- Legacy customer administrators must run the migration tool and install the Core Service Scheduling package before using universal resource scheduling.
- You can't roll back once the migration tool starts.

## Option #2: Wait for the Unified Interface Service Scheduling experience in August 2020

If you are blocked by the absence of the features outlined above, we are offering an incremental option to wait for Unified Interface Service Scheduling experience. The product team will update the existing service scheduling experience for Unified Interface while continuing to use the legacy APIs. The timeline for the Unified Interface scheduling experience is 2020 Release Wave 2, with Early Access available in August. Before this date, you would use legacy service scheduling. More information: [(Legacy Service Scheduling](../customer-service/legacy-scheduling.md).

This option is recommended if you are a legacy service scheduling user who is blocked by absence of certain features in universal resource scheduling, or if you are facing COVID-19-related capacity constraints that hinder your ability to migrate to universal resource scheduling. 

### Pros of waiting for the Unified Interface scheduling experience

- No feature gaps between the legacy web client experience and Unified Interface.

- The same scheduling process is in place.

- A manual migration isn't needed to start using the Unified Interface experience.

- No action is required if you have or are currently building a custom UI that calls the legacy scheduling API.

### Cons of waiting for the Unified Interface scheduling experience

- The universal resource scheduling engine design is different from the legacy scheduling engine. The universal resource scheduling Schedule Board and Unified Interface Service Calendar are not interoperable.

- This option does not align with the long-term product direction, so you would still need to migrate to universal resource scheduling at a later date (this timeline will be determined in 2021). 

## Summary of migration options

The following table summarizes user scenarios, action items, and gaps or issues with for both migration options: 

| Customer | universal resource scheduling option | Unified Interface option | User action items | Gaps/issues |
| :---         |     :---:      |     :---:      | :---         | :---         |
| New Customer Service user | X | | None. Core Service Scheduling is auto-installed with Customer Service Hub | No support of Appointment, Recurring Service Appointment, or user preference-selection. |
| Legacy user who has already migrated to Unified Interface | X | |  Run the [migration tool](introduction-migration-entity-records.md). | No support of Appointment, Recurring Service Appointment, or user preference-selection. |
| Legacy user who hasn't migrated to Unified Interface and is **not blocked** by the absence of identified features | Recommended for alignment with product direction. | |  Run the [migration tool](introduction-migration-entity-records.md). | No support of Appointment, Recurring Service Appointment, or user preference-selection. |
| Legacy user who is **blocked** by the absence of identified features |  | X | Wait until Early Access release in August 2020 to switch to the Unified Interface experience via admin opt-in. | No interoperability between the Schedule Board and the Unified Interface Service calendar. |
| User who has a custom UI that calls the legacy API and doesn't have the time and/or resources to migrate to universal resource scheduling, or is **blocked** from migration by missing features | | X | None. | No gaps in the short term, but migration to universal resource scheduling will eventually be mandatory. |

OP2OL users who use legacy service scheduling will need to either migrate to universal resource scheduling or, if their timeline and circumstances require, wait for the Unified Interface experience.

Users who migrate to universal resource scheduling will have enabled the Appointment entity as bookable in universal resource scheduling, therefore making the appointment bookings visible on the schedule board and part of the resource availability. Although this is doable, be aware of the following (and this list may not be all-inclusive):

- This capability will eventually be deprecated, likely aligning with the long-term universal resource scheduling strategy for service scheduling (the timeline for which is currently TBD in 2021).

- When an appointment is created, a corresponding booking record is automatically created for the Required Attendees and the Owner as long as they are set up as bookable resources. 

- If you make a change to a booking on the schedule board, the booking record will update but not the Appointment entity. This can likely be handled programmatically or via Power Automate to update the Appointment record. 

- The potential exists that you might create endless loops if you also have universal resource scheduling configured to automatically create Appointment records for bookable resources after a booking record has been created.

 


[!INCLUDE[footer-include](../includes/footer-banner.md)]