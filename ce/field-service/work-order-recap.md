---
title: Work order recap with Copilot in Field Service (preview)
description: Learn how to use an AI-generated work order recap in Dynamics 365 Field Service to quickly understand the state of a work order and get appropriate next steps.
ms.date: 08/02/2023
ms.topic: how-to
author: jasonccohen
ms.author: jacoh
ms.reviewer: m-hartmann
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/30/2023
---

# Work order recap with Copilot in Field Service (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

The AI-generated work order recap in Dynamics 365 Field Service provides a summary of a work order and its related data. Designed to help service managers, dispatchers, and frontline workers quickly understand the state of a work order and the next steps to take, the recap summarizes the work order's history, future actions, arrival times, work criticality, required parts, and other contextual information.

The work order recap feature adheres to [responsible AI guidelines](faqs-work-order-recap.md) and avoids information that violates certain restrictions. The content of a recap isn't saved. It's only available to the user who generated it. Users must generate their own recaps, and the content is based on their permissions.

Watch this brief video to learn more about the new work order experience in Field Service, including work order recaps:

> [!VIDEO https://www.microsoft.com/en-us/videoplayer/embed/RW18MN2]

## Prerequisites

- Your environment must be in the United States or the United Kingdom.

- The feature is disabled by default for environments in the United Kingdom. An administrator must enable **Copilot recap** in Field Service settings.

- You must have a paid Field Service environment. The work order recap feature isn't available in trial environments.

- You must [update your environment](update-field-service.md) to the latest Early Access build for 2023 wave 2 to use work order recap and the new work order experience.

## Generate a work order recap

Open a [work order form (preview)](work-order-experience.md).

- To generate a recap, select **Generate recap** in the **Copilot recap** control.

- To refresh the recap, select **Regenerate recap** in the **Copilot recap** control.

Use the like/dislike buttons in the **Copilot recap** control to provide feedback and, optionally, more context about your preferences. Your feedback helps us understand if the recap is useful or not and why.

## How recaps are generated

When you generate a recap, the system uses the work order ID and your security profile to determine whether relevant data exists and that you have access to it. If so, the system pulls contextual information directly from the work order and related records to generate the recap content. The summary might include booking details, activities, notes, products, services, and service tasks involved in the work order, and related information like requirements, asset details, and invoice data.

The recap focuses on the most relevant information based on the work order's lifecycle stage.

- **Unscheduled**: Information that's relevant to scheduling the work order, like requirements.

- **Scheduled**: Information that's relevant to planning, arrival at the work order site, and understanding the issue, like asset information and the asset's work order history.

- **In Progress**: Information that's relevant to completing the work order and the current state of work, like asset information and the asset's work order history.

- **Completed**, **Posted**, and **Canceled**: The core information that's included in all recaps, including a summary of costs and prices and, for completed and posted work orders, invoice details.

## Work order recaps in the mobile app

Frontline workers can get valuable contextual information about their scheduled work using work order recaps in the Field Service mobile app. You can generate a recap on your mobile device and refresh it as you progress through the work order lifecycle. Your device must be connected to the Internet for the recap feature to work.

To enable work order recaps in the mobile app, an administrator must turn on **Copilot Recap for Mobile Preview** in the Field Service mobile app settings > **Preview features**.

When the feature is enabled, the Copilot control is added to the **Bookable Resource Booking** form. You can use the control only on the **Bookable Resource Booking** and **Work Order** forms.

### See also

- [FAQ about work order recap with Copilot (preview)](faqs-work-order-recap.md)
- [New work order experience (preview)](work-order-experience.md)
- [Responsible AI FAQ for Dynamics 365 Field Service](responsible-ai-overview.md)
