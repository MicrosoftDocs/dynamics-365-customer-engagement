---
title: Transparency note for work order recap with copilot
description: This transparency note provides information about the AI technology used in the work order recap feature.
ms.date: 07/03/2023
ms.custom: 
  - transparency-note
ms.topic: article
author: m-hartmann
ms.author: mhart
ms.reviewer: jacohen
---

# Transparency note for work order recap with copilot

This transparency note describes the AI impact of the Dynamics 365 Field Service work order recap feature.

## What is work order recap?

[Describe the system in plain English. What type of system is this? What does it do? At a high level, what does the system take as input? What kind of outputs does the system produce?]

## What are the system’s capabilities?

The work order recap suggests a summary for a work order, depending on the work order system status. The following table lists the information it uses to generate the recap.

|       Work order system status           |                Included information             |
|-------------------------------|:------------------------:|
|      **Unscheduled**:  Recap focuses on information relevant to scheduling the work order.                                                                                    |     - Work order details  </br> - Booking information  </br> - Activity details  </br> - Notes from the work order and bookings  </br> - Work order product details  </br> - Work order service details  </br> - Work order service tasks  </br> - Requirement characteristics  </br> - List of Cancelled bookings (if any)                  |
|      **Scheduled**: Recap emphasizes details relevant to planning and arrival at the work order site.                                                                        |    - Work order Direct Contextual Summary  </br> - Booking information  </br> - Activity details  </br> - Notes from the work order and bookings  </br> - Work order product details  </br> - Work order service details  </br> - Work order service tasks  </br> - Requirement characteristics   </br> - Asset information and work order History  |
|      **In Progress**:  Recap provides information relevant to completing the work order and shares the current state of work.                                                 |    - Work order Direct Contextual Summary  </br> - Booking information  </br> - Activity details  </br> - Notes from the work order and bookings  </br> - Work order product details  </br> - Work order service details  </br> - Work order service tasks  </br> - Asset information and work order History                                |
|      **Completed**:  Recap summarizes the work done, how it was completed, and includes a summary of costs and prices.                                                        |     - Work order Direct Contextual Summary </br>  - Booking information </br> -  Activity details </br> - Notes from the work order and bookings </br> - Work order product details  </br> - Work order service details  </br> - Work order service tasks                                                                          |
|      **Posted**:  Recap repeats the *Completed* state information and includes relevant invoice details.                                                                        |   - Work order Direct Contextual Summary </br> - Booking information  </br> - Activity details  </br> - Notes from the work order and bookings  </br> - Work order product details   </br> - Work order service details  </br> - Work order service tasks  </br> - Invoice information (including total amount)                           |
|      **Cancelled**:  Recap summarizes the proposed scope of work, scheduling details, and includes any information that might help understand the history of the work order.  |    - Work order Direct Contextual Summary </br> -  Booking information  </br> - Activity details  </br> - Notes from the work order and bookings  </br> - Work order product details   </br> - Work order service details  </br> - Work order service tasks                                                                         |

## What is the system’s intended use?

[Explain intended use(s), as identified in your Impact Assessment.]

## How was [Feature] evaluated? What metrics are used to measure performance?

[Provide evidence of system accuracy and performance as well as a description of the extent to which these results are generalizable across use cases that were not part of the evaluation.]

## What are the limitations of [Feature]? How can users minimize the impact of the [Feature] limitations when using the system?

[See Impact Assessment. Describe the known limitations of the system including uses for which the system was not designed or evaluated. Discuss steps that the user can take to minimize errors and the impact of trade-offs for the user.]

## What operational factors and settings allow for effective and responsible use of the system?

[Describe the operational factors and ranges within which the system is expected to perform reliably and safely. List the choices that end users can make (e.g., customization, settings, etc.), with a description of how those choices may impact system behavior in the real world.](tbd.md)

## See also

- [Work order recap with copilot](work-order-recap.md)
- [Transparency notes for Dynamics 365 Field Service](transparency-note.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]