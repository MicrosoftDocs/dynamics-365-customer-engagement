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

When you generate a recap, the system passes the work order ID and its current system status to an API. The system then pulls relevant data based on the status of the work order to create the recap. The recap includes a summary of the work order, booking details, activities, notes, products, services, and service tasks involved in the work order. Additional information, such as requirement characteristics, asset details, and invoice information, may be included based on the work order's current system status.

The recap is tailored to the work order's lifecycle stage, focusing on the most relevant information for each. 

|       Work order system status           |                Included information             |
|-------------------------------|------------------------|
|      **Unscheduled**:</br>  Recap focuses on information relevant to scheduling the work order.                                                                                    |     - Work order details  </br> - Booking information  </br> - Activity details  </br> - Notes from the work order and bookings  </br> - Work order product details  </br> - Work order service details  </br> - Work order service tasks  </br> - Requirement characteristics  </br> - List of Cancelled bookings (if any)                  |
|      **Scheduled**: </br>Recap emphasizes details relevant to planning and arrival at the work order site.                                                                        |    - Work order Direct Contextual Summary  </br> - Booking information  </br> - Activity details  </br> - Notes from the work order and bookings  </br> - Work order product details  </br> - Work order service details  </br> - Work order service tasks  </br> - Requirement characteristics   </br> - Asset information and work order History  |
|      **In Progress**: </br> Recap provides information relevant to completing the work order and shares the current state of work.                                                 |    - Work order Direct Contextual Summary  </br> - Booking information  </br> - Activity details  </br> - Notes from the work order and bookings  </br> - Work order product details  </br> - Work order service details  </br> - Work order service tasks  </br> - Asset information and work order History                                |
|      **Completed**: </br> Recap summarizes the work done, how it was completed, and includes a summary of costs and prices.                                                        |     - Work order Direct Contextual Summary </br>  - Booking information </br> -  Activity details </br> - Notes from the work order and bookings </br> - Work order product details  </br> - Work order service details  </br> - Work order service tasks                                                                          |
|      **Posted**: </br> Recap repeats the *Completed* state information and includes relevant invoice details.                                                                        |   - Work order Direct Contextual Summary </br> - Booking information  </br> - Activity details  </br> - Notes from the work order and bookings  </br> - Work order product details   </br> - Work order service details  </br> - Work order service tasks  </br> - Invoice information (including total amount)                           |
|      **Cancelled**: </br> Recap summarizes the proposed scope of work, scheduling details, and includes any information that might help understand the history of the work order.  |    - Work order Direct Contextual Summary </br> -  Booking information  </br> - Activity details  </br> - Notes from the work order and bookings  </br> - Work order product details   </br> - Work order service details  </br> - Work order service tasks      

## Feature availability and usage limitations

The AI-powered recap feature is currently available in preview for environments deployed in the United States Azure geography. The feature also adheres to [responsible AI guidelines](transparency-note-work-order-recap.md) and avoids summarizing information that violates certain restrictions. An admin can enable or disable this feature from the Field Service Settings. When disabled, the Copilot Recap control is hidden from the work order form.

In the event of errors or service limitations, the system returns an error message instead of a recap summary.
