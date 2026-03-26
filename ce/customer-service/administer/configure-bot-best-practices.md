---
title: Best practices for configuring AI agents
description: This article lists the best practices that you can follow when you configure Azure and Copilot agents in your contact center.
ms.date: 06/30/2025
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: best-practice
ms.custom: bap-template
ms.collection:
---

# Best practices for configuring AI agents

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

[!INCLUDE[cc-rebrand-bot-agent](../../includes/cc-rebrand-bot-agent.md)]

## Best practices

When you configure Azure and Copilot agents in Dynamics 365 Contact Center, use the following best practices:

- In a queue, if both AI agents (agents) and customer service representatives (service representatives or representatives) are available, set the agent’s capacity higher than all representatives. An agent’s capacity isn't reduced even after a work item is assigned to it. This ensures that any conversation routed to the queue is first picked up by the agent.

- When an agent escalates a conversation to a representative, make sure that the context variables are updated by the agent and the corresponding routing rules match correctly.

- When a conversation escalated by an AI agent comes back to the same queue due to incorrect routing or context variables not being updated at runtime, the conversation isn't assigned to the same agent who escalated the conversation. To prevent conversations from ending up in an infinite loop, you must configure a representative for the queue that has the AI agent only.

- Unlike representatives, agents aren't added to a "default" queue at the outset; you must add them from the Copilot Service admin center app.

- The message size must be less than or equal to 28 KB in all messaging channels. The size limit includes metadata like timestamps and tags. If you're an AI agent author (bot author) or developer and want to pass complex cards or message types across channels, make sure that your message size doesn't exceed the limit. If you're integrating a custom channel via Direct Line, then make sure that the activity payload doesn't exceed the message size limit.

- Make sure the AI agent that presents the greeting to the customer is [configured for the workstream](create-workstreams.md#add-an-agent-to-a-workstream) and not for the queue. This way, routing engine isn't required to be engaged and agent engagement is quicker.

- Configure the AI agent to play an initial greeting and then line up any other tasks, such as data lookup.

- To avoid prolonged latency if data lookup is delayed, use options such as Dataverse connectors, custom connectors, and prebuilt Power Automate connectors that Copilot Studio provides to access external data. [HTTP requests](/microsoft-copilot-studio/authoring-http-node) offer the best performance for data outside Customer Service or Dynamics 365 Contact Center. The built-in Dataverse connectors are most efficient for accessing data within Dynamics 365.

- You might experience latency when you use Power Automate to access data because the AI agent pauses until the flow completes. Use the [Power Automate dashboard](/power-platform/admin/analytics-flow?tabs=new) to monitor and optimize flow performance.


### Best practices to handle silence before a customer engages with the voice agent

- For voice agents to acknowledge a delay so that your caller doesn't go through silence, configure a [latency message](/microsoft-copilot-studio/voice-configuration#add-a-latency-message-for-long-running-operations) with the minimum playback time setting even if the background lookup operation completes while the message is playing. The default setting is 5000 ms.

- If you need to play a static message before the voice agent greets the customer with a more personalized prompt, then use [system greeting messages](configure-automated-message.md#preconfigured-automated-message-triggers). The voice agent is engaged after the uninterruptible system message plays. Make sure to avoid redundancy in voice agent greeting and system greeting.

### Best practices to handle silence during a conversation with the voice agent

- Configure a delay between messages using the [delay activity](/microsoft-copilot-studio/authoring-send-event-activities#sending-other-activity-types) option to introduce a pause between messages that makes interactions feel more natural. The default delay setting is 500 ms. You can modify the value to make the pause shorter or longer.

## Considerations for context variables

[!INCLUDE[cc-context-variable-considerations](../../includes/cc-context-variable-considerations.md)]

### Related information

[Best practices for setting up the voice channel](../implement/voice-channel-best-practices.md)  
[Integrate an Azure agent](configure-bot-azure.md)  
[Integrate a Copilot agent](configure-bot-virtual-agent.md)  
[Optimize agents to minimize latency](/microsoft-copilot-studio/guidance/optimize-minimize-latency)  
[Configure AI agents to escalate and end conversations](../develop/bot-escalate-end-conversation.md)  
[Manage context variables](manage-context-variables.md)  
[Context variables for an agent](context-variables-for-bot.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
