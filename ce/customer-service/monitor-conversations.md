---
title: "Monitor, assign, and transfer conversations as a supervisor | MicrosoftDocs"
description: "Learn how to monitor, assign, and transfer conversations as a supervisor."
author: "mh-jaya"
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
> This feature is intended to help customer service managers or supervisors enhance their team's performance and improve customer satisfaction. This feature is not intended for use in making, and should not be used to make decisions that affect the employment of an employee or group of employees, including compensation, rewards, seniority, or other rights or entitlements. Customers are solely responsible for using Dynamics 365 Customer Service, this feature, and any associated feature or service in compliance with all applicable laws, including laws relating to accessing individual employee analytics and monitoring, recording, and storing communications with end users. This also includes adequately notifying end users that their communications with agents may be monitored, recorded, or stored and, as required by applicable laws, obtaining consent from end users before using the feature with them. Customers are also encouraged to have a mechanism in place to inform their agents that their communications with end users may be monitored, recorded, or stored.

As a supervisor, you can monitor, assign, or transfer conversations that are being handled by your agents using the **Omnichannel Ongoing Conversations** dashboard. For more information, go to [Omnichannel Ongoing Conversations dashboard](ongoing-conversations-dashboard.md).

When you monitor conversations, you can see and understand how they are proceeding, and also check if any conversation needs your immediate attention. You can also view customer sentiments and agent responses.

> [!NOTE]
> To be able to monitor, assign, or transfer conversations, your administrator should enable the respective settings&mdash;**Supervisor Monitor**, **Supervisor Assign**, or **Supervisor Transfer**&mdash;in **Omnichannel Administration**.

## Monitor and join conversations

As a supervisor, you can monitor or assign conversations or work items that are configured for all channels except records. You can monitor all conversations that are in the **Active** or **Wrap-up** states. By joining the conversation, you provide necessary details to both the agent and customer based on the selected message mode (public or internal) in the communication panel.  

> [!NOTE]
> You can't monitor conversations that are assigned to you.

1. Sign in to **Omnichannel for Customer Service**.

2. From the dashboard view selector, select the **Omnichannel Ongoing         Conversations** dashboard.
    The list of conversations currently being handled by your agents is displayed.

3. Select a conversation that you want to monitor and select **Monitor**.
    The conversation page opens.

4. Optionally, to join a conversation, select **Join chat** in the communication panel.

    When you join the conversation, both the agent and the customer receive notifications that you have joined the conversation. Depending on your requirement, you can consult with the agent and customer via public or internal modes. For more information, go to [View communication panel](oc-conversation-control.md).

## Assign conversations

To manually assign a conversation, the conversation should be in an open state and not assigned to any agent. As a supervisor, you can override the agent's presence and allocated capacity when assigning conversations to them. When you override agent capacity, the number of units by which their capacity is exceeded is displayed.

1. From the dashboard view selector in **Omnichannel for Customer Service**, select the **Omnichannel Ongoing Conversations** dashboard.

2. Select a conversation in an **Open** state, and then select **Assign**.

3. On the **Assign conversations** dialog box, select **Agent** or **Queue**.

    > If you select **Agent**, only those agents whose presence matches with one of the allowed presence values in the workstream configuration are displayed.
    > If you select **Queue**, then all other queues except the one to which the conversation is currently assigned, are displayed.

4. After selecting the agent or queue, select **Assign**.
   The conversation is now assigned to the agent or queue you selected.

## Transfer conversations

You can transfer ongoing conversations that are in the **Active** or **Waiting** states. You can transfer all conversations that take place on messaging channels such as Live Chat, SMS, or WhatsApp. However, if and when these conversations switch from the text mode to elevated voice or video modes, you can't transfer them across agents.

> [!NOTE]
> You can transfer conversations to and from agents only, and not bots.

1. From the dashboard view selector in **Omnichannel for Customer Service**, select the **Omnichannel Ongoing Conversations** dashboard.

    The list of available agents, their capacities, and queues is displayed.

2. Select a conversation in an **Active** or **Waiting** state and select **Transfer**.

3. On the **Transfer conversations** dialog, select the agent that you want to transfer the conversation to, from the list of agents that appears.

      Only those agents whose presence matches with one of the allowed presence values in the workstream configuration will be listed.

4. Select **Transfer**. The selected conversation is transferred to the agent.

> [!NOTE]
> When you transfer an **Active** conversation from one agent to another, the first agent is added as consultant to the conversation that is now being managed by the second agent.

> When you transfer a conversation from one agent to another, the conversation is successfully transferred when the latter acknowledges the notification by selecting **Accept** or **Reject**. Be sure to refresh the dashboard to get an updated status, just in case there are some network issues or delays in acknowledgment.

### See also

[Configure Intraday insights dashboard for Unified Service Desk](configure-intraday-dashboard-supervisor.md)  
[Enable sentiment analysis](enable-sentiment-analysis.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
