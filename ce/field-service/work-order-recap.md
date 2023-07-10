---
title:
description: 
ms.date: 07/03/2023
ms.topic: how-to
ms.custom: bap-template
author: 
ms.author: 
---

# Work order recap with Copilot in Field Service (preview)

The AI-Powered work order recap feature provides a succinct summary of a work order and its related contextual data. This feature is designed to help service managers, dispatchers, and frontline workers quickly understand the current state of a work order, including its past developments, future actions, arrival times, work criticality, and parts used or to be used.

## Generate a work order recap

Users can interact with the recap feature from the work order form, which includes a new **Copilot Recap** control. On a saved work order, select **Generate** in the **Copilot Recap** control to to generate a recap summary. To refresh a summary, select **Regenerate**. Use the control to provide feedback on the recap, and help us understand if it's useful or not, and optionally provide additional context about your preferences.

## Recap Generation and Content

When you generate a recap, the system passes the work order ID and its current system status to an API. The system then uses the requesting user's security context to pull relevant data based on the status of the work order to create the recap. Assuming the user has access to the data and the data exists for the given work order, the recap uses contextual information directly from the work order and related records to generate the recap content. The feature may use the summary of the work order, booking details, activities, notes, products, services, and service tasks involved in the work order, as well as related information like requirement characteristics, asset details, and invoice information.

The recap is tailored to the work order's lifecycle stage, focusing on the most relevant information for each.

- **Unscheduled**: Recap focuses on information relevant to scheduling the work order.
- **Scheduled**: Recap emphasizes details relevant to planning and arrival at the work order site.
- **In Progress**: Recap provides information relevant to completing the work order and shares the current state of work.
- **Completed**: Recap summarizes the work done, how it was completed, and includes a summary of costs and prices.
- **Posted**: Recap repeats the *Completed* state information and includes relevant invoice details.
- **Cancelled**: Recap summarizes the proposed scope of work, scheduling details, and includes any information that might help understand the history of the work order.

|       Work order system status           |                Included information             |
|-------------------------------|------------------------|
|      **Unscheduled**  |     - Work order details  </br> - Booking information  </br> - Activity details  </br> - Notes from the work order and bookings  </br> - Work order product details  </br> - Work order service details  </br> - Work order service tasks  </br> - Requirement characteristics  </br> - List of Cancelled bookings (if any)                  |
|      **Scheduled**  |    - Work order Direct Contextual Summary  </br> - Booking information  </br> - Activity details  </br> - Notes from the work order and bookings  </br> - Work order product details  </br> - Work order service details  </br> - Work order service tasks  </br> - Requirement characteristics   </br> - Asset information and work order History  |
|      **In Progress**  |    - Work order Direct Contextual Summary  </br> - Booking information  </br> - Activity details  </br> - Notes from the work order and bookings  </br> - Work order product details  </br> - Work order service details  </br> - Work order service tasks  </br> - Asset information and work order History                                |
|      **Completed**  |     - Work order Direct Contextual Summary </br>  - Booking information </br> -  Activity details </br> - Notes from the work order and bookings </br> - Work order product details  </br> - Work order service details  </br> - Work order service tasks                                                                          |
|      **Posted**  |   - Work order Direct Contextual Summary </br> - Booking information  </br> - Activity details  </br> - Notes from the work order and bookings  </br> - Work order product details   </br> - Work order service details  </br> - Work order service tasks  </br> - Invoice information (including total amount)                           |
|      **Cancelled**  |    - Work order Direct Contextual Summary </br> -  Booking information  </br> - Activity details  </br> - Notes from the work order and bookings  </br> - Work order product details   </br> - Work order service details  </br> - Work order service tasks |

## Feature availability and usage limitations

The AI-powered recap feature is currently available in preview for environments deployed in the United States and United Kingdom geography from the new work order form. Environments within the United Kingdom will need to go to Field Service Settings to enable to feature before it is available in their environment. At this time, FS Copilot requests will be processed using resources within the United States. 

The feature also adheres to [responsible AI guidelines](transparency-note-work-order-recap.md) and avoids summarizing information that violates certain restrictions. An admin can enable or disable this feature from the Field Service Settings. When disabled, the Copilot Recap control is hidden from the work order form. This feature is only available, out of the box, on the new work order form.

In the event of errors or service limitations, the system returns an error message instead of a recap summary.

Currently, the recap feature does not allow customization of the prompt or the contextual information passed in the prompt. The feature aims to respect user date/time formatting preferences, timezone settings, and environment specific table and field labels in an attempt to return recap content that is tailored to user expectations as defined by user settings and the settings of the specific environment and Field Service implementation. Further, the intial preview of this feature has been tested for release using English. At this time, use in other languages is not supported.
