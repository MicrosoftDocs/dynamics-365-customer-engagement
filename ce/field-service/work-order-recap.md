---
title: Work order recap with Copilot in Field Service (preview)
description: Learn how to use AI to generate a work order recap in Dynamics 365 Field Service.
ms.date: 08/02/2023
ms.topic: how-to
ms.custom: bap-template
author: jasonccohen
ms.author: jacoh
ms.reviewer: m-hartmann
---

# Work order recap with Copilot in Field Service (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

The AI-Powered work order recap feature provides a succinct summary of a work order and its related contextual data. This feature is designed to help service managers, dispatchers, and frontline workers quickly understand the current state of a work order and suggest appropriate next steps to help get issues resolved quickly. The recap includes the work order's past developments, future actions, arrival times, work criticality, and a summary of required parts.

> [!VIDEO https://www.microsoft.com/en-us/videoplayer/embed/RW18MN2]

The feature also adheres to [responsible AI guidelines](faqs-work-order-recap.md) and avoids information that violates certain restrictions.

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## Prerequisites

The AI-powered recap feature is currently available in preview for environments deployed in the United States and United Kingdom. Currently, copilot requests for the work order recap are processed within the United States. For United Kingdom environments, the feature is disabled by default. To enable it, ask an admin to go to Field Service **Settings** and turn on **Copilot recap**.

Update your environment to the latest Early Access build for 2023 wave 2 to use work order recap and the improved work order forms.

## Generate a work order recap

Go to the [work order form (preview)](work-order-experience.md).

- On a saved work order, select **Generate** in the **Copilot recap** control to generate a recap summary.
- To refresh a summary, select **Regenerate** in the **Copilot recap** control.
- Use the **Copilot recap** control to provide feedback on the recap and help us understand if it's useful or not, and optionally provide more context about your preferences.

> [!NOTE]
> When a recap is generated, the content is not saved and is only available to the user who generated it. Each user must generate their own recap, which is generated based on the user's permissions.

## Recap generation and content

When you generate a recap, the system passes the work order ID and its current system status to an API. The system then uses the requesting user's security context to pull relevant data based on the status of the work order to create the recap. If the user has access to the data and the data exists for the given work order, the recap uses contextual information directly from the work order and related records to generate the recap content. The system may use the summary of the work order, booking details, activities, notes, products, services, and service tasks involved in the work order. It also uses related information like requirement characteristics, asset details, and invoice information.

The recap is tailored to the work order's lifecycle stage, focusing on the most relevant information for each.

The prompt includes core work order information, including products, services, and tasks. It also includes critical context like booking information, activity details, and notes from the work order and bookings.

For each lifecycle stage of the work order, we also include additional information that may be relevant to that step.

- **Unscheduled**: Information relevant to scheduling the work order like requirement characteristics.
- **Scheduled**: Details relevant to planning, arrival at the work order site, and understanding the issue like asset information and work order history for the asset.
- **In Progress**: Information relevant to completing the work order and the current state of work, which again includes asset information and work order history for the asset.
- **Completed**: The core information included in all prompts including relevant summary of costs and prices.
- **Posted**: The same core information shared in all prompts and relevant invoice details.
- **Canceled**: The core information included in all prompts.

If there are errors or service limitations, the system returns an error message instead of a recap summary.

## Next steps

- [FAQs for work order recap with copilot (preview)](faqs-work-order-recap.md)
- [Responsible AI FAQs for Dynamics 365 Field Service](responsible-ai-overview.md)
- [Work order form and component experience (preview)](work-order-experience.md)
