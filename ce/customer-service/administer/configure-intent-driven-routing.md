---
title: Configure intent-driven routing (preview)
description: Learn how to configure and manage intent-driven routing within your organization to optimize your customer service operations and improve overall customer satisfaction.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: how-to
ms.collection: bap-ai-copilot
ms.date: 05/21/2026
ms.update-cycle: 180-days
ms.custom: bap-template
---

# Configure intent-driven routing (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Intent-driven routing makes intent a native part of unified routing. Administrators configure intent routing through the same rule authoring interface they use for every other routing attribute&mdash;classification rules and route-to-queue rules&mdash;and combine intent with skill-based routing in a single flow.

This article describes how intent-driven routing works, and how to author routing rules that use intent, intent group, and line of business as live work item attributes.

In preview, live chat, voice, and case are supported. The intent for case is determined when it's routed.

> [!NOTE]
> Intent-driven routing replaces the intent-based routing experience. Existing customers don't need to maintain intent group to user group mappings because they aren’t applicable anymore.

[!INCLUDE [preview-note](~/../shared-content/shared/preview-includes/production-ready-preview-dynamics365.md)]

## Prerequisites

- [Customer Intent Agent is enabled](/dynamics365/contact-center/administer/manage-customer-intent-agent#enable-customer-intent-agent).
- [Intent discovery is set up](/dynamics365/contact-center/administer/manage-customer-intent-agent#manage-intent-discovery-setup).
- For live chat, the prerequisites and steps in [Configure intent-based suggestions for Copilot agents](/dynamics365/contact-center/administer/set-up-intent-agent) are applicable. Make sure that the Copilot agent is configured in the messaging workstream, which is critical for runtime invocation.
- For the voice channel, the prerequisites and steps in [Set up voice agents to use intents](/dynamics365/contact-center/administer/set-up-voice-agents-to-use-intents) are applicable. Make sure that the voice agent is configured in the voice workstream, which is critical for runtime invocation.

## How intent-driven routing works

1. An administrator sets up intent, uses historical data to build the intent library, and enables the library for Copilot agents and representatives.

1. The Copilot agent, configured for the workstream, detects intent from the customer and asks follow-up questions related to the intent. It then provides a solution based on customer-provided information from the connected Copilot agent knowledge source.
1. If the issue is escalated, the Copilot agent persists the intent fields to the work item and routing is triggered.
1. During routing, if intent-driven rules are configured in classification or route-to-queue setup, unified routing honors the intent fields to take routing decisions as follows:
   - **Classification**: Classification rules read these fields and enrich the live work item, for example, by attaching skills, priority, or other attributes based on the identified intent fields.
   - **Route-to-queue**: Route-to-queue rules use the intent fields with any other live work item attributes to select the right queue.
   - **Assignment**: The skill-based routing engine evaluates the queue's eligible pool against the attached skills and the queue's assignment strategy, and assigns the work to the most qualified available representative.

## Configure classification rules using intent

Follow the steps in [Configure work classification rulesets](configure-work-classification.md) to set up classification rules to identify the work item requirements and enrich it, typically by attaching skills or other attributes based on intent fields.

- In the rule, set the condition using one or more intent fields: Intent, Intent group, or Line of business.
- Set the action to attach the relevant skill or other attribute to the work item.
- Save the rule and make sure that it's active.

For example, if intent equals **cancel-order**, attach the **cancellations** skill to the work item.

## Configure route-to-queue rules using intent

Use route-to-queue rules to send the work item to the appropriate queue based on intent.

Perform the steps in [configure route-to-queue](configure-route-to-queue-rules.md#configure-rules-in-route-to-queue-ruleset) rules. Make sure to set the condition using one or more intent fields, optionally in combination with other live work item attributes.

For example, if Line of business equals **Billing** and intent group equals **Refund requests**, route to the **Billing Tier 2** queue.

## Use skill-based routing with intent

The typical pattern for intent and skill-based routing is as follows:

1. A classification rule attaches one or more skills to the work item based on the intent identified by the upstream intent agent.

1. A route-to-queue rule selects the queue based on intent fields and any other live work item attributes.
1. The skill-based routing engine evaluates representatives in the queue's eligible pool against the attached skills and the queue's assignment strategy.
1. The work item is assigned to the most qualified available representative.

This means a single ruleset can route based on intent and agent skill, language, region, or any other live work item attribute without maintaining a separate intent-to-user-group mapping.

### Considerations

- Intent discovery is required to populate the intent library.
- Unified routing doesn't perform intent determination for live chat or voice work items.
- Existing queues, routing rules, skills, capacity profiles, and assignment strategies continue to function unchanged.

### Related information

[Overview of Customer Intent Agent](/dynamics365/contact-center/administer/overview-customer-intent-agent)  
