---
title: Work order recap with Copilot in Field Service (preview)
description: Learn how to use AI to generate a work order recap in Dynamics 365 Field Service.
ms.date: 07/10/2023
ms.topic: how-to
ms.custom: bap-template
author: jasonccohen
ms.author: jacoh
ms.reviewer: m-hartmann
---

# Work order recap with Copilot in Field Service (preview)

[!INCLUDE[public-preview-banner](../includes/public-preview-banner.md)]

The AI-Powered work order recap feature provides a succinct summary of a work order and its related contextual data. This feature is designed to help service managers, dispatchers, and frontline workers quickly understand the current state of a work order and suggest appropriate next steps to help get issues resolved in a timeline manner. The recap includes the work order's past developments, future actions, arrival times, work criticality, and a summary of required parts.

The feature also adheres to [responsible AI guidelines](faqs-work-order-recap.md) and avoids summarizing information that violates certain restrictions.

[!INCLUDE[public-preview-note](../includes/public-preview-note.md)]

## Prerequisites

The AI-powered recap feature is currently available in preview for environments deployed in the United States and United Kingdom. Currently, Field Service Copilot requests are processed using resources within the United States. For United Kingdom environments, the feature is disabled by default. To enable it, ask an admin to go to Field Service **Settings** and turn on **Copilot recap**.

## Generate a work order recap

Go to the Work order form (preview).

- On a saved work order, select **Generate** in the **Copilot recap** control to generate a recap summary.
- To refresh a summary, select **Regenerate** in the **Copilot recap** control.
- Use the **Copilot recap** control to provide feedback on the recap and help us understand if it's useful or not, and optionally provide more context about your preferences.

> [!NOTE]
> When a recap is generated, the content is not saved and is only available to the user who generated it. Each user must generate their own recap, which is generated based on the user's permissions.

## Recap generation and content

When you generate a recap, the system passes the work order ID and its current system status to an API. The system then uses the requesting user's security context to pull relevant data based on the status of the work order to create the recap. If the user has access to the data and the data exists for the given work order, the recap uses contextual information directly from the work order and related records to generate the recap content. The system may use the summary of the work order, booking details, activities, notes, products, services, and service tasks involved in the work order. It also uses related information like requirement characteristics, asset details, and invoice information.

The recap is tailored to the work order's lifecycle stage, focusing on the most relevant information for each.

- **Unscheduled**: Information relevant to scheduling the work order.
- **Scheduled**: Details relevant to planning and arrival at the work order site.
- **In Progress**: Information relevant to completing the work order and the current state of work.
- **Completed**: Summary of the work done, how it was completed, and a summary of costs and prices.
- **Posted**: Repeat of the *Completed* state information and relevant invoice details.
- **Cancelled**: Summary of the proposed scope of work, scheduling details, and any information that might help understand the history of the work order.

|       Work order system status           |                Included information             |
|-------------------------------|------------------------|
|      **Unscheduled**  |     - Work order details  </br> - Booking information  </br> - Activity details  </br> - Notes from the work order and bookings  </br> - Work order product details  </br> - Work order service details  </br> - Work order service tasks  </br> - Requirement characteristics  </br> - List of Cancelled bookings (if any)                  |
|      **Scheduled**  |    - Work order Direct Contextual Summary  </br> - Booking information  </br> - Activity details  </br> - Notes from the work order and bookings  </br> - Work order product details  </br> - Work order service details  </br> - Work order service tasks  </br> - Requirement characteristics   </br> - Asset information and work order History  |
|      **In Progress**  |    - Work order Direct Contextual Summary  </br> - Booking information  </br> - Activity details  </br> - Notes from the work order and bookings  </br> - Work order product details  </br> - Work order service details  </br> - Work order service tasks  </br> - Asset information and work order History                                |
|      **Completed**  |     - Work order Direct Contextual Summary </br>  - Booking information </br> -  Activity details </br> - Notes from the work order and bookings </br> - Work order product details  </br> - Work order service details  </br> - Work order service tasks                                                                          |
|      **Posted**  |   - Work order Direct Contextual Summary </br> - Booking information  </br> - Activity details  </br> - Notes from the work order and bookings  </br> - Work order product details   </br> - Work order service details  </br> - Work order service tasks  </br> - Invoice information (including total amount)                           |
|      **Cancelled**  |    - Work order Direct Contextual Summary </br> -  Booking information  </br> - Activity details  </br> - Notes from the work order and bookings  </br> - Work order product details   </br> - Work order service details  </br> - Work order service tasks |

If there are errors or service limitations, the system returns an error message instead of a recap summary.

## See also

- [FAQs for work order recap with copilot (preview)](faqs-work-order-recap.md)
- [Responsible AI FAQs for Dynamics 365 Field Service](responsible-ai-overview.md)
