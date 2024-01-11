---
title: Configure routing based on third-party calendars (preview)
description: Learn about how to configure routing of work items to agents based on third-party calendars.
author: neeranelli
ms.author: nenellim
ms.reviewer: 
ms.topic: how-to
ms.collection: 
ms.date: 01/11/2024
ms.custom: bap-template
---

# Configure routing based on third-party calendars (preview)

[This article is prerelease documentation and is subject to change.]

[!INCLUDE [preview-banner](../../../shared-content/shared/preview-includes/preview-note.md)]

Configure assignment rules to route and assign cases and conversations based on agent's shift schedules.

## Prerequisites

- Workforce Management for Customer Service is enabled in your environment.
- [Unified routing](provision-unified-routing.md) is provisioned and set up.
- [Workstreams](create-workstreams.md) and [advanced queues](queues-omnichannel.md) are set up.
- [Custom assignment method](configure-assignment-rules.md) is configured for the queue.

## Enable shift-based routing setting

1. In the Customer Service admin center site map, select **Workforce management** under **Operations**.
1. In the **Shift based routing (preview)** section, select **Manage**.
1. On the **Shift based routing (preview)** page, turn on the **Enable routing based on shift bookings** toggle, and then select **Save**.

## Configure assignment rule

1. In the Customer Service admin center site map, select **Queues**, and then select Manage in the **Advanced queues** area.
1. Select the queue that you want to configure the assignment rule, select the custom assignment method, and select **Edit**.
1. Create a rule or modify an existing rule and do the following:
    1. In **Conditions**, select **Add row**, and then select **Calendar schedule**. The **Is working** value is automatically selected.
    1. Save and close.
       :::image type="content" source="../media/screenshot-of-agent-diagnostics.png" alt-text=""::::::image type="content" source="../media/screenshot-of-calendar-schedule-condition.png" alt-text="Screenshot of assignment rule configured on calendar schedule.":::

## View routing diagnostics records

View the [routing diagnostics record](unified-routing-diagnostics.md) to understand how a work item is routed when routing is configured based on agent calendar attribute.

## Next steps

[Use Customer Service workspace](../implement/csw-overview.md)  
[View the agent calendar](use/use-agent-calendar.md)  
