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

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> - [!INCLUDE[cc_preview_features_definition](../includes/cc-preview-features-definition.md)]  
> - [!INCLUDE[cc_preview_features_expect_changes](../includes/cc-preview-features-expect-changes.md)]
> - Microsoft doesn't provide support for this preview feature. Microsoft Technical Support won’t be able to help you with issues or questions. Preview features aren't meant for production use and are subject to a separate [supplemental terms of use](https://go.microsoft.com/fwlink/p/?linkid=870960).

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

The system, by default, the system assigns new conversations based on the routing rules. The system, by default, assigns new conversations based on routing rules. When the capacity of agents is full, conversations remain in the queue in the open state until an agent capacity is available. As a supervisor, you can manually assign these conversations in open state, to an agent or another queue.  

> [!NOTE]
> Contact you administrator to enable the option to assign conversation in settings. To learn more, see [Enable supervisors to monitor and assign conversations](../administrator/configure-ongoing-conversations-settings.md)

## Assign conversation

You can assign a conversation to an agent or to another queue that is in the **Open** state. To assign, follow these steps: 

1. Sign in to **Omnichannel for Customer Service** app. 

2. In the **Omnichannel Ongoing Conversations** dashboard, choose the conversation that you want to manually assign.

    > [!NOTE]
    > You can assign conversations that are in **Open** state only.

    The **Assign** action at the top of the grid is active.

3. Select **Assign**. 

    In this example, we are selecting a live chat workstream that is not assigned to an agent or added to a queue.

    > [!div class=mx-imgBorder]
    > ![Select a work item to assign](../media/oc-select-conversations-assign.png "Select a work item to assign")


4. In the **Assign** dialog box, you can see the list of agents and their available capacity in **Agents** tab. 

    To add to a queue, select **Queue** tab.

    In this example, we are assigning the conversation to **Alan Steiner**.

    > [!div class=mx-imgBorder]
    > ![Assign work item to an agent](../media/oc-conversations-assign-agent.png "Assign work item to an agent")

5. Select **Assign**.

    The assignment of conversation is initiated and you will receive a notification.


### See also

[Configure intraday insights dashboard for Unified Service Desk](../administrator/configure-intraday-dashboard-supervisor.md)

[Enable supervisors to monitor and assign conversations](../administrator/configure-ongoing-conversations-settings.md)

[Enable sentiment analysis](../administrator/enable-sentiment-analysis.md)