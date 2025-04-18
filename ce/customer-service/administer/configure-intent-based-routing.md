---
title: Configure intent-based routing
description:
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: how-to
ms.collection: bap-ai-copilot
ms.date: 04/17/2025
ms.custom: bap-template
---

# Configure intent-based routing

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

To be written.

[!INCLUDE [preview-note](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Prerequisites

- Customer Intent Agent is enabled.

- Intent discovery is set up.
- intents are created and in approved state.
- Intent groups are created.

## How intent-based routing works


1. The intent is generated in runtime and matched against one of the intents in intent library (as part of the discovery process). 
   - For cases, the system uses the case title, description, and case notes to determine the intent.
   - For conversations, the agent in Microsoft Copilot Studio generates customer intent based on its interaction with the customer. The same intent is used for routing.

1.	An intent group is identified corresponding to the identified intent.
1.	The conversation is routed through the workstream and queue, and a user group is identified based on the manually curated intent group to user group mapping.
1.	From the identified user group, a matching user is found based on the queue’s assignment strategy.

## Enable intent-based routing

By using generative AI, capture customer intents for incoming conversations and map them to solutions tailored to fulfill requests. The intent groups are manually mapped to one or more user groups.
After you enable intent-based routing, you can control at the line of business-level to route some conversations using intent, and some through the conventional unified routing method. 

## Manage lines of business

A line of business can be a service, product, product category, or the way your company organizes and supports its business activities. You need to add lines of business if you want to enable intent-based routing for a selective set of workstreams and queues. Otherwise, intent-based routing is enabled for the whole organization.
The following entities are associated with a line of business:   

- Intents and intent groups

- User groups (A representative can be a part of many user groups that belong to different lines of business)
- Workstreams
- Queues

### Add a line of business

1.	In the site map of Copilot Service admin center, go to **Intent**, and select **Manage** for **Add Line of business (Optional)**.
1.	On the **Manage Lines of business **page, select **Add Line of business**.
1.	Enter the name and description that indicates the line of business.
1.	Select **Add**. The line of business is listed in the Lines of business table.

### Create rules for cases and converstaions


