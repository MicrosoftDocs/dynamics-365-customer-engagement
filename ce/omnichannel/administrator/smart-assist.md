---
title: "Smart assist for agents | MicrosoftDocs"
description: "Learn about how to smartly assist agents with the next-best steps in the Omnichannel Administration app."
author: kabala123
ms.author: kabala
manager: shujoshi
ms.date: 01/31/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Smart assist for agents

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

## Overview of smart assist

The new-age customer service industry is moving towards the vision of being an intelligent versus process-driven while interacting with customers. Pivoting on intelligence capabilities, helps unleash the productivity of agents to perform better on Key Performance Indicators and at the same time, deliver better customer experience.

As the agents are more efficient and productive, there is a reduction in the cost of operation of the call center. Now, the smart assist feature helps organizations realize the vision of being more intelligent.

Smart assist is an intelligent assistant that provides real-time recommendations to the agents, helping them to take actions while interacting with the customers. It allows organizations to build a custom bot and plug-in to their environment. These custom bot interprets the conversations in real-time and provides relevant recommendations such as knowledge articles, similar cases, and next-best steps to the agent's user interface. The recommendations are shown to the agents using Microsoft Adaptive cards.

The smart assist feature can be enabled across all channels like Chat for Dynamics 365 Customer Service, SMS, and Facebook except entity records making it a consistent experience for agents.

## Value proposition

- Contextual recommendations are generated based on the real-time conversations.

- Plug-in organization-specific recommendations and display it to agents in real-time.
 
- Action-oriented recommendations for agents to send responses or execute the automated actions.

- Intelligence powered using Microsoft Azure or third-party capabilities.

- Improved Average Handling Time (AHT) and First Call Resolution (FCR).

## Pre-requisites

- Install Dynamics 365 Productivity Tools solution.

- Develop a custom bot and integrate with Omnichannel for Customer Service app to use the Smart Assist feature.

## Walkthrough to enable smart assist

[Step 1: Develop a smart assist bot](#step-1-develop-a-custom-smart-assist-bot)

[Step 2: Create a bot user](#step-2-create-a-bot-user)

[Step 3: Add smart assist bot to workstream](#step-3-add-smart-assist-bot-to-a-workstream)

[Step 4: Enable productivity pane](#step-4-enable-productivity-pane)

## Step 1: Develop a custom smart assist bot

Develop a custom bot and integrate with Omnichannel for Customer Service app to use the Smart Assist feature. 

### Purpose of smart assist bot

The smart assist bot interprets the conversation context in real-time and provides suggestions to the agents. The smart assist bot sends the suggestions using the [Microsoft Adaptive cards](https://docs.microsoft.com/adaptive-cards/). 

You can embed macros and custom actions within a suggestion with the of use web resources.

For example:

**Custom action:** An agent is displayed with a Knowledge article card with a **Send Link** button. You can implement a custom action to copy and paste the link in the communication panel when agent selects the **Send Link** button.

**Macro:**: An agent is displayed with a Create Case card. You can implement a macro with the card to open a new form to create a case when an agent selects the **Create case** button on the card. While developing the Adaptive cards, you need to specify the name of the macro.

To learn more, see [Smart assist bot](../developer/how-to/smart-assist-bot.md).

## Step 2: Create a bot user

After you create a bot, you must create a bot user to work as a smart assistant to the agent. A bot user is created as an application user and assigned with the **Omnichannel agent** role. Creating an application user is supported in the Web Client only. For information on creating a bot user, see [Create a bot user](configure-bot.md#step-1-create-a-bot-user).

## Step 3: Add smart assist bot to a workstream

After you create a bot user, you need to add the bot to the workstream so that the agents who are part of this workstream can see the suggestions.

1. Sign in to Omnichannel Administration app

2. Select **Work Streams** under **Work Distribution Management**.

3. Select a workstream for which you want to add the smart assist bot.

4. Select the **Smart Assist** tab.

5. Select **+ Add Existing** in the **Smart Assist** section. The **Lookup Records** pane appears.

6. Select the search icon to see the list of available smart assist bots, and select a bot from the list, and then select **Add**. <br> You can multiple bots to a workstream based on your business requirement.

7. Select **Save** the workstream changes.
 
## Step 4: Enable productivity pane

After you've created the agent script, you need to enable the productivity pane to display the smart assist card to the agents in the Omnichannel for Customer app.

To enable productivity pane, see [Enable productivity pane to provide guidance to agents](productivity-pane.md).

After you've enabled the productivity pane, users can see the smart assist cards on the productivity pane in the Omnichannel for Customer Service app.

> [!Note]
> - If you don't create smart assist card and enable the productivity pane, then users wouldn't see the pane in the Omnichannel for Customer Service app. 
>
> - It is recommended to remove the smart assist control If you've customized a form to add the smart assist field so agents can see it.
>
> - If you don't remove the smart assist control, then agents will see the smart assist control in the form and also in the productivity pane.

## See also

[Smart assist for agents](../agent/agent-oc/oc-smart-assist.md)
 
[Macros](macros.md)

[Agent scripts](agent-scripts.md)