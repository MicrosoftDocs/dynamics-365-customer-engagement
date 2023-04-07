---
title: "Monitor, assign, transfer, and end conversations as a supervisor | MicrosoftDocs"
description: "Learn how to monitor, assign, and transfer conversations being handled by your agents using the Omnichannel Ongoing Conversations dashboard."
ms.date: 11/16/2022
ms.topic: article
author: "neeranelli"
ms.author: nenellim
---
# Monitor, assign, transfer, and forcibly end conversations

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

> [!IMPORTANT]
> This feature is intended to help customer service managers or supervisors enhance their team's performance and improve customer satisfaction. This feature is not intended for use in making, and should not be used to make decisions that affect the employment of an employee or group of employees, including compensation, rewards, seniority, or other rights or entitlements. Customers are solely responsible for using Dynamics 365 Customer Service, this feature, and any associated feature or service in compliance with all applicable laws, including laws relating to accessing individual employee analytics and monitoring, recording, and storing communications with end users. This also includes adequately notifying end users that their communications with agents may be monitored, recorded, or stored and, as required by applicable laws, obtaining consent from end users before using the feature with them. Customers are also encouraged to have a mechanism in place to inform their agents that their communications with end users may be monitored, recorded, or stored.


As a supervisor, you can monitor, assign, transfer, or end conversations that are being handled by your agents by using the **Omnichannel Ongoing Conversations** dashboard. More information: [Omnichannel Ongoing Conversations dashboard](ongoing-conversations-dashboard.md)

When you monitor conversations, you can understand how they're being handled by your agents and also check whether any conversation needs your immediate attention. You can also view customer sentiment and agent responses.

To be able to monitor, assign, transfer, or close conversations, your administrator must enable the respective settings&ndash;**Supervisor Monitor**, **Supervisor Assign**, **Supervisor Transfer**, or **Force Close**&ndash;in the admin app. More information: [Enable your supervisors to monitor, assign, transfer, and forcibly end conversations](enable-monitor-assign-transfer-conv.md)

## Monitor and join conversations

As a supervisor, you can monitor or assign conversations that are configured for all channels except records. You can monitor all conversations that are in the **Active** or **Wrap-up** states. By joining the conversation, you provide necessary details to both the agent and customer in the communication panel.  

You can't monitor conversations that are assigned to you.

1. Sign in to Dynamics 365 and go to the Customer Service workspace or Omnichannel for Customer Service app.

2. From the dashboard view selector, select the **Omnichannel Ongoing Conversations** dashboard.
    The list of conversations currently being handled by your agents is displayed.

3. Select a conversation that you want to monitor, and select **Monitor**.
    The conversation page opens.

4. Optionally, to join a conversation, select **Join chat** in the communication panel.

    When you join the conversation, both the agent and the customer receive notifications that you've joined. Depending on your requirements, you can consult with the agent and customer. For more information, go to [View communication panel](oc-conversation-control.md).

## Assign conversations

To manually assign a conversation, the conversation should be in an open state and not assigned to any agent. As a supervisor, you can override the agent's presence and allocated capacity when assigning conversations to them. When you override agent capacity, the number of units by which their capacity is exceeded is displayed.

1. From the dashboard view selector in Omnichannel for Customer Service, select the **Omnichannel Ongoing Conversations** dashboard.

2. Select a conversation in an **Open** state, and then select **Assign**.

3. In the **Assign conversations** dialog box, select **Agent** or **Queue**.

    > If you select **Agent**, only those agents whose presence matches with one of the allowed presence values in the workstream configuration are displayed.
    > If you select **Queue**, all other queues&mdash;except the one to which the conversation is currently assigned&mdash;are displayed.

4. Select **Assign**.

The conversation is now assigned to the agent or queue that you selected.

> [!NOTE]
> If you're unable to assign conversations successfully, verify that the **Omnichannel API access** role isn't assigned to you.

## Transfer conversations

You can transfer ongoing conversations that are in the **Active** or **Waiting** states. You can transfer all conversations that take place on messaging channels such as Live Chat, SMS, or WhatsApp. However, if and when these conversations switch from the text mode to elevated voice or video modes, you can't transfer them across agents.

You can transfer conversations to and from agents only, not bots.

1. From the dashboard view selector in Omnichannel for Customer Service, select the **Omnichannel Ongoing Conversations** dashboard.

2. Select a conversation in the **Active** or **Waiting** state, and then select **Transfer**.

3. In the **Transfer conversations** dialog box, select an agent from the list of agents that appears.

      A list of agents belonging to the same queue and whose presence matches with one of the allowed presence values in the workstream configuration is displayed.

4. Select **Transfer**. The selected conversation is transferred to the agent.

When you transfer an **Active** conversation from one agent to another, the first agent is added as a consultant to the conversation that's now being managed by the second agent. The conversation is successfully transferred when the second agent acknowledges the notification by selecting **Accept** or **Reject**. Refresh the dashboard if you don't get an updated status as a result of network issues or delays in acknowledgment.

## End conversations forcibly

> [!CAUTION]
> We recommend that you use this feature judiciously to end agent conversations.

End voice calls and conversations that take place on the voice and messaging channels. After the conversation ends, its status is set to **Closed**.

1. From the dashboard view selector in Omnichannel for Customer Service, select the **Omnichannel Ongoing Conversations** dashboard.

2. Select a conversation and then select **Force Close**.

The participants receive a notification that their conversation was ended by a supervisor.

### See also

[Configure Intraday insights dashboard for Unified Service Desk](configure-intraday-dashboard-supervisor.md)  
[Enable sentiment analysis](enable-sentiment-analysis.md)  
[Enable Supervisor settings in Omnichannel for Customer Service](enable-monitor-assign-transfer-conv.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
