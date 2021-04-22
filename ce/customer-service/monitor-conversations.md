---
title: "Monitor, assign, and transfer conversations as a supervisor | MicrosoftDocs"
description: "Learn how to monitor, assign, and transfer conversations as a supervisor."
author: mh-jaya
feedback_product_url: https://experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
ms.author: v-jmh
manager: shujoshi
ms.date: 04/21/2021
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Monitor, assign, and transfer conversations

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

> [!IMPORTANT]
> This feature is intended to help customer service managers or supervisors enhance their team's performance and improve customer satisfaction. This feature is not intended for use in making, and should not be used to make, decisions that affect the employment of an employee or group of employees, including compensation, rewards, seniority, or other rights or entitlements. Customers are solely responsible for using Dynamics 365 Customer Service, this feature, and any associated feature or service in compliance with all applicable laws, including laws relating to accessing individual employee analytics and monitoring, recording, and storing communications with end users. This also includes adequately notifying end users that their communications with agents may be monitored, recorded, or stored and, as required by applicable laws, obtaining consent from end users before using the feature with them. Customers are also encouraged to have a mechanism in place to inform their agents that their communications with end users may be monitored, recorded, or stored.

As a supervisor, you can monitor the conversations that are being handled by agents. Monitoring the conversations helps you identify the conversations that need your attention to provide your expertise or suggestions to close. You can select a conversation from the dashboard and choose the **Monitor** action from the grid command bar. You can also join a conversation. When you join, notifications about your presence are sent to the agent and customer who are in the conversation. You join the conversation in consult mode, which enables you to provide your expertise to the agent who is interacting with the customer.

As a supervisor, if your administrator has enabled the **Assign** feature, you can also manually assign conversations to agents in cases where a conversation is not assigned. Only conversations that are in an open state can be assigned by supervisors.

Also, you can transfer ongoing conversations that are in the active or waiting status from one agent to another.

Use the **Omnichannel Ongoing Conversations** dashboard to access the monitor and assign features. To learn more, see [Omnichannel Ongoing Conversations dashboard](ongoing-conversations-dashboard.md).

The following screenshot is an example of Omnichannel Ongoing Conversations:

> [!div class=mx-imgBorder]
> ![Omnichannel Ongoing Conversations dashboard example](media/supervisor-ongoing-conversations-dashboard.png "Omnichannel Ongoing Conversations dashboard example")

## Things you must know

Before you start using the **Omnichannel Ongoing Conversations** dashboard, here are a few things you must be aware of:

- The monitor feature is supported for workstreams configured for all channels except Entity Records.

- You can monitor only conversations that are in the **Active** and **Wrap-up** states.

- You can't monitor conversations that are assigned to you.

- You can transfer conversations only on messaging channels such as Live Chat, SMS, or WhatsApp. 

-  

- You can transfer conversations to and from agents only, and not bots.

- You can only transfer **Active** or **Waiting** state conversations. 

## Monitor and join conversations

By monitoring the conversations, you get an overview of how each conversation is trending, such as sentiments and agent responses, and can choose to join a conversation that might need your attention.
  
By joining the conversation, you provide necessary details to both the agent and customer based on the selected message mode (public or internal) in the communication panel.

1. Sign in to the **Omnichannel for Customer Service** app.

2. From the dashboard view selector, select the **Omnichannel Ongoing Conversations** dashboard.

    The list of conversations currently being handled by your agents is displayed.

3. Choose a conversation to monitor and select **Monitor** on the top-right corner.

    > [!div class=mx-imgBorder]
    > ![Select Monitor option](media/supervisor-select-monitor-conversation.png "Select Monitor option")

    The conversation page opens.

4. You can choose to join a conversation as required. Select **Join chat** in the communication panel.

    > [!div class=mx-imgBorder]
    > ![Select Join chat](media/supervisor-select-join-chat.png "Select Join chat")

    When you join the conversation, a notification is sent to both agent and customer stating that you have joined as a consultant. Depending on your requirement, you can start a consultation with the agent and customer by using a messaging mode (public or internal). By default, the messaging mode is internal.

    To learn more, see [View communication panel](oc-conversation-control.md).

## Assign conversations

At times, you may need to manually assign a conversation. In such cases, the conversation should be in an open status or not assigned to any agent. You can override the agent's presence and allocated capacity when assigning conversations to them. When you override agent capacity, the number of units by which their capacity is exceeded is displayed.

1. Sign in to the **Omnichannel for Customer Service** app.

2. From the dashboard view selector, select the **Omnichannel Ongoing Conversations** dashboard.

    The list of available agents, their capacities, and queues, is displayed.
    > [!div class=mx-imgBorder]
    > ![Select Assign option](media/assign-agents-conversations.png "Select Assign option")

3. Choose a conversation in an **Open** state, and select **Assign** on the top-right corner.
    > [!div class=mx-imgBorder]
    > ![Select agent or queue option](media/assign-agent-queue.png "Select either agent or queue option")

4. On the **Assign conversations** dialog box, choose one of the following options:

  - **Agent:** Select to assign the conversation to an agent, and choose an agent name from the list. Agents whose presence match with one of the allowed presence values in the workstream configuration only will be listed.
  - **Queue:** Select a queue from the queues list. All queues are listed except the queue to which the conversation is currently assigned.

5. Depending on the option you chose in Step 4, choose the agent or queue, and then select **Assign**.

## Transfer conversations

At times, you may need to transfer an ongoing conversation from an agent to another agent. In such cases, the conversation should be in an active or waiting status.

1. Sign in to the **Omnichannel for Customer Service** app.

2. From the dashboard view selector, select the **Omnichannel Ongoing Conversations** dashboard.

    The list of available agents, their capacities, and queues is displayed.

3. Choose a conversation in an **Active** or **Waiting** state, and select **Transfer** on the top-right corner.
    > [!div class=mx-imgBorder]
    > ![Select Transfer option](media/transfer-agents-conversations.png "Select Transfer option")

4. On the **Transfer conversations** dialog box, select **Agent**.

      Select to transfer the conversation to an agent by choosing an agent name from the list. Only those agents whose presence match with one of the allowed presence values in the workstream configuration will be listed.

5. Select **Transfer**. The selected conversation is transferred to the agent.

> [!NOTE]
> When you transfer an **Active** or **Waiting** state conversation from one agent to another, the first agent becomes a consultee to the conversation that is now being managed by the second agent.

### See also

[Configure Intraday insights dashboard for Unified Service Desk](configure-intraday-dashboard-supervisor.md)  
[Enable sentiment analysis](enable-sentiment-analysis.md)  



[!INCLUDE[footer-include](../includes/footer-banner.md)]