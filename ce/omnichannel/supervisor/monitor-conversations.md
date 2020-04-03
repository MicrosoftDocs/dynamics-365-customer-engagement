---
title: "Monitor conversations as a supervisor | MicrosoftDocs"
description: "Learn how to monitor conversations as a supervisor"
author: platkat
ms.author: ktaylor
manager: shujoshi
ms.date: 04/03/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Monitor conversations

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

> [!IMPORTANT]
> This feature is intended to help customer service managers or supervisors enhance their team’s performance and improve customer satisfaction. This feature is not intended for use in making, and should not be used to make, decisions that affect the employment of an employee or group of employees, including compensation, rewards, seniority, or other rights or entitlements. Customers are solely responsible for using Dynamics 365 Customer Service, this feature, and any associated feature or service in compliance with all applicable laws, including laws relating to accessing individual employee analytics and monitoring, recording, and storing communications with end users. This also includes adequately notifying end users that their communications with agents may be monitored, recorded, or stored and, as required by applicable laws, obtaining consent from end users before using the feature with them. Customers are also encouraged to have a mechanism in place to inform their agents that their communications with end users may be monitored, recorded, or stored.

As a supervisor, you can monitor the conversations that are being handled by agents. Monitoring the conversations helps you in identifying the conversations that need your attention to provide your expertise or suggestions to close. You can select a conversation from the dashboard and choose the **Monitor** action from the grid command bar. You can also join a conversation. When you join, notifications about your presence are sent to the agent and customer who are in the conversation. You join the conversation in consult mode, which enables you to provide your expertise to the agent who is interacting with the customer.

Use the **Omnichannel Ongoing Conversations** dashboard to monitor conversations between customers and agents. To learn more, see [Omnichannel Ongoing Conversations dashboard](ongoing-conversations-dashboard.md).

The following screenshot is an example of Omnichannel Ongoing Conversations:

> [!div class=mx-imgBorder]
> ![Omnichannel Ongoing Conversations dashboard example](../media/supervisor-ongoing-conversations-dashboard.png "Omnichannel Ongoing Conversations dashboard example")

## Things you must know

Before you start using the **Omnichannel Ongoing Conversations** dashboard, here are a few things you must be aware of:

-	You can monitor only the conversations that are in the workstream with mode as **Chat**.

-	You can monitor only conversations that are in the **Active** and **Wrap-up** states.

-	You cannot monitor conversations that are assigned to you.

## Monitor and join a conversation

By monitoring the conversations, you will get an overview of how each conversation is tending (such as sentiments and agent responses) and can choose to join a conversation that may need your attention. 
  
By joining the conversation, you provide necessary inputs to both agent and customer based on the selected message mode (public or internal) in the communication panel.

1.	Sign in to the **Omnichannel for Customer Service** app.

2.  From the dashboard view selector, select the **Omnichannel Ongoing Conversations** dashboard.

    The list of conversations currently being handled by your agents is displayed. 

3.	Choose a conversation to monitor and select **Monitor**.

    > [!div class=mx-imgBorder]
    > ![Select Monitor option](../media/supervisor-select-monitor-conversation.png "Select Monitor option")

    The conversation page opens.

4.	You can choose to join a conversation as required. Select **Join chat** in the communication panel.

    > [!div class=mx-imgBorder]
    > ![Select Join chat](../media/supervisor-select-join-chat.png "Select Join chat")

    When you join the conversation, a notification will be sent to both agent and customer stating that you have joined as a consultant. Depending on your requirement, you can start a consultation with the agent and customer by using a messaging mode (public or internal). By default, the messaging mode is internal.
    
    To learn more, see [View communication panel](../agent/agent-oc/oc-conversation-control.md).



## See also

[Configure Intraday insights dashboard for Unified Service Desk](../administrator/configure-intraday-dashboard-supervisor.md)

[Enable sentiment analysis](../administrator/enable-sentiment-analysis.md)

[Enable supervisors to monitor and assign conversations](../administrator/configure-ongoing-conversations-settings.md)
