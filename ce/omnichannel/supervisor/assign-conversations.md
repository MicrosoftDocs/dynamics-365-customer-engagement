---
title: "Assign conversations for supervisor | MicrosoftDocs"
description: "Learn about how to assign conversations to queues and agents"
keywords: ""
author: udaykirang
ms.author: udag
manager: shujoshi
applies_to: 
ms.date: 06/22/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 8cd6045e-7df0-419b-b8a9-12f753b81fff
ms.custom: 
---

# Assign conversations

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

As a supervisor, you can assign conversations (work item) that customer initiates to a queue or an agent. By default, the system assigns new conversations based on the routing rules. When the capacity of agents is full, the work distribution system does not assign the conversations to any agents. However, as a supervisor, you can assign these conversations to an agent or add to a queue.

> [!NOTE]
> Contact you administrator to enable the option to assign conversation in settings. To learn more, see [Enable supervisors to monitor and assign conversations](../administrator/configure-ongoing-conversations-settings.md)

## Assign conversation

You can assign conversation to an agent or add to a queue that are in the **Open** state. To assign, follow these steps: 

1. Sign in to **Omnichannel for Customer Service** app. 

2. From the dashboard view selector, select **Omnichannel Ongoing Conversations** dashboard.

    The list of conversations that currently handled by your agents are displayed.

3. Choose a conversation that is in **Open** state and then select Assign and then select **Assign**. 

    In this example, we are selecting a live chat workstream that is not assigned to an agent or added to a queue.

    > [!div class=mx-imgBorder]
    > ![Select a work item to assign](../media/oc-select-conversations-assign.png "Select a work item to assign")

4. In the **Assign** dialog box, you can see the list of agents and their available capacity in **Agents** tab. Depending on the capacity, you can choose to assign the conversation to an agent. If the capacity of all agents is full, you can add the conversation to their respective queue to be assigned when gets free capacity.

    To add to a queue, select **Queue** tab.

    In this example, we are assigning the conversation to **Alan Steiner** as his capacity is 50 percent free.

    > [!div class=mx-imgBorder]
    > ![Assign work item to an agent](../media/oc-conversations-assign-agent.png "Assign work item to an agent")

5. Select **Assign**.

    The conversation is assigned to the agent.


### See also

[Configure intraday insights dashboard for Unified Service Desk](../administrator/configure-intraday-dashboard-supervisor.md)

[Enable supervisors to monitor and assign conversations](../administrator/configure-ongoing-conversations-settings.md)

[Enable sentiment analysis](../administrator/enable-sentiment-analysis.md)