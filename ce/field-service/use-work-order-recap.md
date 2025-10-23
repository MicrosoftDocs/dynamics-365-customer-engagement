---
title: Summarize work orders with Copilot in Field Service
description: Generate a work order summary with Copilot in Dynamics 365 Field Service to quickly understand work order status and next steps.
ms.date: 06/09/2025
ms.update-cycle: 180-days
ms.topic: how-to
author: jasonccohen
ms.author: jacoh
ms.reviewer: puneetsingh
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date: 10/30/2023
ms.collection: bap-ai-copilot 
---

# Summarize work orders with Copilot

The work order summary with Copilot in Field Service helps you understand the state of a work order and get next steps. This AI-generated summary includes status, priority, and related activities, making it easier to manage work orders efficiently.

The content of a summary isn't saved. It's only available to the user who generated it. The summary focuses on the most relevant information based on the work order's lifecycle stage.

- **Unscheduled**: Information that's relevant to scheduling the work order, like requirements.

- **Scheduled**: Information that's relevant to planning, arrival at the work order site, and understanding the issue. For example, asset information and the asset's work order history.

- **In Progress**: Information that's relevant to completing the work order and the current state of work, like asset information and the asset's work order history.

- **Completed**, **Posted**, and **Canceled**: The core information in all summaries includes a recap of costs and prices and, for completed and posted work orders, invoice details.

Watch this brief video to learn more about the new work order experience in Field Service, including work order summaries:

> [!VIDEO https://learn-video.azurefd.net/vod/player?id=bfce9329-2bdc-461c-bd57-1458e237524a]

## Generate a summary in the web app

> [!NOTE]
> Admin must enable the work order summary feature in Field Service before you can use it. Learn more in [Enable work order summary with Copilot in Field Service](enable-work-order-recap.md).

Open a [work order form](work-order-experience.md) or a booking record.

- To generate a summary, select **Generate** in the **Copilot** control.

- To refresh the summary, select **Regenerate** in the **Copilot** control.

## Send feedback

Use the like/dislike buttons in the Copilot control to provide feedback and, optionally, more context about your preferences. Your feedback helps us understand if the summary is useful or not and why.

## See also

- [FAQ about work order summary with Copilot](faqs-work-order-recap.md)
- [New work order experience](work-order-experience.md)
- [Responsible AI FAQ for Dynamics 365 Field Service](responsible-ai-overview.md)
- [Enable work order summary with Copilot in Field Service](enable-work-order-recap.md)