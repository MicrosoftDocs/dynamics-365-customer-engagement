---
title: "Smart assist for agents | MicrosoftDocs"
description: "Learn about how to smartly assist agents with the next-best steps in the Omnichannel Administration app."
author: kabala123
ms.author: kabala
manager: shujoshi
ms.date: 02/06/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Smart assist for agents

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

## Overview of smart assist

The new-age customer service industry is moving toward the vision of being intelligent rather than process-driven while interacting with customers. Pivoting on intelligence capabilities helps unleash the productivity of agents to perform better on key performance indicators and&mdash;at the same time&mdash;deliver better customer experience.

As agents become more efficient and productive, the cost of operating the call center falls. Now, the smart assist feature helps organizations realize the vision of being more intelligent.

Smart assist is an intelligent assistant that provides real-time recommendations to agents, helping them to take actions while interacting with customers. It allows organizations to build a custom bot and plug-in to their environment. These custom bots interpret conversations in real time and provide relevant recommendations such as knowledge articles, similar cases, and next-best steps to the agent's user interface. The recommendations are shown to the agents by using Microsoft Adaptive cards.

The smart assist feature can be enabled across all channels like Chat for Dynamics 365 Customer Service, SMS, and Facebook (excluding Entity Records Channel), making it a consistent experience for agents.

## Value proposition

- Contextual recommendations are generated based on real-time conversations.

- Plug-in organization-specific recommendations are displayed to agents in real time.
 
- Action-oriented recommendations are given for agents to send responses or execute automated actions.

- Intelligence is powered by using Microsoft Azure or third-party capabilities.

- Agents can achieve improved average handling time and first call resolution.

## Prerequisites

- Install Dynamics 365 Productivity Tools solution.

- Develop a custom bot and integrate it with Omnichannel for Customer Service to use smart assist.

## Walk-through to enable smart assist

[Step 1: Develop a smart assist bot](#step-1-develop-a-custom-smart-assist-bot)

[Step 2: Create a bot user](#step-2-create-a-bot-user)

[Step 3: Add smart assist bot to a workstream](#step-3-add-smart-assist-bot-to-a-workstream)

[Step 4: Enable the productivity pane](#step-4-enable-the-productivity-pane)

## Step 1: Develop a custom smart-assist bot<a name="step-1-develop-a-custom-smart-assist-bot"></a>

Develop a custom bot and integrate it with Omnichannel for Customer Service to use the smart assist feature. 

### Purpose of the smart-assist bot

The smart-assist bot interprets the conversation context in real time and provides suggestions to agents. The smart-assist bot sends suggestions by using [Microsoft Adaptive Cards](https://docs.microsoft.com/adaptive-cards/). 

You can embed macros and custom actions within a suggestion by using web resources. For example:

*  **Custom action:** An agent is displayed with a knowledge article card that includes a **Send Link** button. You can implement a custom action to copy and paste the link in the communication panel when the agent selects the **Send Link** button.

*  **Macro:**: An agent is displayed with a Create Case card. You can implement a macro with the card to open a new form to create a case when the agent selects the **Create case** button on the card. While developing the Adaptive Cards, you need to specify the name of the macro.

To learn more, see [Smart assist bot](../developer/how-to/smart-assist-bot.md).

## Step 2: Create a bot user

After you create a bot, you must create a bot user to work as a smart assistant to the agent. A bot user is created as an application user and assigned the **Omnichannel agent** role. If your bot needs to search for knowledge base articles, then you need to provide either the **Customer Service Manager** or **Customer Service Representative** role.

Creating an application user is supported in the web client only. For information about creating a bot user, see [Create a bot user](configure-bot.md#step-1-create-a-bot-user).

## Step 3: Add a smart assist bot to a workstream<a name="step-3-add-smart-assist-bot-to-a-workstream"></a>

After you create a bot user, you need to add the bot to the workstream so that agents who are part of this workstream can see the suggestions.

1. Sign in to the Omnichannel Administration app.

2. Under **Work Distribution Management**, select **Work Streams**.

3. Select the workstream for which you want to add the smart-assist bot.

4. Select the **Smart Assist** tab.

5. In the **Smart Assist** section, select **+ Add Existing**. The **Lookup Records** pane appears.

6. Select the search icon to see the list of available smart-assist bots, select a bot from the list, and then select **Add**. 
You can add multiple bots to a workstream based on your business requirements.

7. Select **Save**.
 
<a name="step-4-enable-productivity-pane"></a>

## Step 4: Enable the productivity pane

After you've created the agent script, you need to enable the productivity pane to display the smart-assist card to agents in Omnichannel for Customer Service.

To enable the productivity pane, see [Enable the productivity pane to provide guidance to agents](productivity-pane.md).

After you've enabled the productivity pane, users can see the smart-assist cards on the productivity pane in Omnichannel for Customer Service.

> [!Note]
> - If you don't create smart-assist cards and enable the productivity pane, users won't see the pane in Omnichannel for Customer Service. 
>
> - We recommend that you remove the smart-assist control if you've customized a form to add smart-assist. If you don't remove the smart-assist control, agents won't be able to see the smart-assist control in the form and also in the productivity pane.

### See also

[Smart assist for agents](../agent/agent-oc/oc-smart-assist.md)<br>
[Macros](macros.md)<br>
[Agent scripts](agent-scripts.md)