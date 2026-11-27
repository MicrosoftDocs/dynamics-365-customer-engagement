---
title: Configure intent-driven routing (preview)
description: Learn how to configure and manage intent-driven routing within your organization to optimize your customer service operations and improve overall customer satisfaction.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: how-to
ms.collection: bap-ai-copilot
ms.date: 11/27/2026
ms.update-cycle: 180-days
ms.custom: bap-template
---

# Configure intent-driven routing (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Intent-driven routing makes intent a native part of unified routing. Administrators configure intent routing through the same rule authoring interface they use for every other routing attribute&mdash;classification rules and route-to-queue rules&mdash;and combine intent with skill-based routing in a single flow.

This article describes how intent-driven routing works, and how to author routing rules that use intent, intent group, and line of business as live work item attributes.

In preview, intent-driven routing is supported for the **case** channel only.

> [!NOTE]
> - Intent-based routing consumes Copilot Credits because it uses [Customer Intent Agent](/dynamics365/contact-center/administer/overview-customer-intent-agent) to determine intents for the cases being routed.
> - Intent-driven routing replaces the intent-based routing experience. Existing customers don't need to maintain intent group to user group mappings because they aren’t applicable anymore.

[!INCLUDE [preview-note](~/../shared-content/shared/preview-includes/production-ready-preview-dynamics365.md)]

## Prerequisites

- [Customer Intent Agent is enabled](/dynamics365/contact-center/administer/manage-customer-intent-agent#enable-customer-intent-agent).
- Administrator enabled **Intent** > **Intent-driven routing**. Contact Microsoft Support if toggle isn't available.
- [Intent discovery is set up](/dynamics365/contact-center/administer/manage-customer-intent-agent#manage-intent-discovery-setup).
- [Set up intents](/dynamics365/contact-center/administer/manage-customer-intent-agent#manage-intents).

## How intent-driven routing works

1. An administrator sets up intents, intent groups, or lines of business and makes them available for routing. Intent fields should be in Approved state.

1. The administrator enables intent-driven routing by turning on **Intent** > **Intent-driven routing**.
1. When a case is routed, the applicable intent fields are available on the live work item associated with the case.
1. During routing, if intent-driven rules are configured in classification or route-to-queue setup, unified routing honors the intent fields to take routing decisions as follows:
   - **Classification**: Classification rules read intent fields and enrich the case. For example, the system attaches skills, priority, or other attributes.
   - **Route-to-queue**: Route-to-queue rules use intent fields with other case attributes to select the right queue.
   - **Assignment**: The skill-based routing engine evaluates the queue’s eligible pool against attached skills and assignment strategy, and assigns the case to the most qualified available representative.

## Configure classification rules using intent

Follow the steps in [Configure work classification rulesets](configure-work-classification.md) to set up classification rules that enrich cases based on intent fields.

- In the rule, set the condition using one or more intent fields: Intent, Intent group, or Line of business.
- Set the action to attach the relevant skill or other attribute to the work item.
- Save the rule and make sure that it's active.

For example, if intent equals **cancel-order**, attach the **cancellations** skill to the case.

## Configure route-to-queue rules using intent

Use route-to-queue rules to send cases to the appropriate queue based on intent.

Perform the steps in [configure route-to-queue](configure-route-to-queue-rules.md#configure-rules-in-route-to-queue-ruleset) rules. Make sure to set the condition using one or more intent fields, optionally in combination with other case attributes.

For example, if Line of business equals **Billing** and intent group equals **Refund requests**, route to the **Billing Tier 2** queue.

## Use skill-based routing with intent

The typical pattern for intent and skill-based routing is as follows:

1. A classification rule attaches one or more skills to the case based on the intent.

1. A route-to-queue rule selects the queue based on intent fields and any other case attributes.
1. The skill-based routing engine evaluates representatives in the queue's eligible pool against the attached skills and the queue's assignment strategy.
1. The case is assigned to the most qualified available representative.

This means a single ruleset can route based on intent and agent skill, language, region, or any other case attribute without maintaining a separate intent-to-user-group mapping.

### Considerations

- Intent discovery is optional if intents are set up manually.
- Existing queues, routing rules, skills, capacity profiles, and assignment strategies continue to function unchanged.

## Related information

[Overview of Customer Intent Agent](/dynamics365/contact-center/administer/overview-customer-intent-agent)  
