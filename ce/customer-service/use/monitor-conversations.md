---
title: Monitor, assign, transfer, and end conversations as a supervisor
description: Learn how to monitor, assign, transfer, and end conversations that your customer service representatives handle using the Omnichannel Ongoing Conversations dashboard.
ms.date: 09/06/2024
ms.topic: article
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
---
# Monitor, assign, transfer, and forcibly end conversations

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]

> [!IMPORTANT]
> This feature is intended to help customer service managers or supervisors enhance their team's performance and improve customer satisfaction. This feature is not intended for use in making, and should not be used to make decisions that affect the employment of an employee or group of employees, including compensation, rewards, seniority, or other rights or entitlements. Customers are solely responsible for using Dynamics 365 Customer Service, this feature, and any associated feature or service in compliance with all applicable laws, including laws relating to accessing individual employee analytics and monitoring, recording, and storing communications with end users. This also includes adequately notifying end users that their communications with customer service representatives may be monitored, recorded, or stored and, as required by applicable laws, obtaining consent from end users before using the feature with them. Customers are also encouraged to have a mechanism in place to inform their customer service representatives that their communications with end users may be monitored, recorded, or stored.

As a supervisor, you can monitor, assign, transfer, or end conversations that your customer service representatives (service representatives or representatives) are handling by using the **Omnichannel Ongoing Conversations** dashboard. Learn more in [Omnichannel Ongoing Conversations dashboard](ongoing-conversations-dashboard.md). However, we recommend that you use the [Ongoing conversation report in Omnichannel real-time analytics dashboard](realtime-ongoing.md) to perform these tasks, for digital messaging, chat, and voice channels only.

When you monitor conversations, you can understand how your service representatives are handling the conversations and also check whether any conversation needs your immediate attention. You can also view customer sentiment and service representative responses.

To be able to monitor, assign, transfer, or close conversations, your administrator must enable the respective settings&ndash;**Supervisor Monitor**, **Supervisor Assign**, **Supervisor Transfer**, or **Force Close**&ndash;in the admin app. Learn more in [Enable your supervisors to monitor, assign, transfer, and forcibly end conversations](../administer/enable-monitor-assign-transfer-conv.md)

## Monitor and join conversations

As a supervisor, you can monitor or assign conversations that are configured for all channels, including records. You can monitor all conversations that are in the **Active** or **Wrap-up** states. By joining the conversation, you provide necessary details to both the service representative and customer in the communication panel.  

You can't monitor conversations that are assigned to you.

## Assign conversations

To manually assign a conversation, the conversation should be in an Open state and not assigned to any service representative. As a supervisor, you can override the service representative's presence and allocated capacity when assigning conversations to them. When you override representative capacity, the number of units by which their capacity is exceeded is displayed.

The conversation is now assigned to the service representative or queue that you selected.

> [!NOTE]
> If you're unable to assign conversations successfully, verify that the **Omnichannel API access** role isn't assigned to you.

## Transfer conversations

You can transfer ongoing conversations that are in the **Active** or **Waiting** states. You can transfer all conversations that take place on messaging channels such as Live Chat, SMS, or WhatsApp. However, if and when these conversations switch from the text mode to elevated voice or video modes, you can't transfer them across service representatives.

You can transfer conversations to and from service representatives only, not bots.

When you transfer an **Active** conversation from one service representative to another, the first representative is added as a consultant to the conversation that's now being managed by the second representative. The conversation is successfully transferred when the second service representative acknowledges the notification by selecting **Accept** or **Reject**. Refresh the dashboard if you don't get an updated status as a result of network issues or delays in acknowledgment.

## End conversations forcibly

End voice calls and conversations that take place on the voice and messaging channels. After the conversation ends, its status is set to **Closed**.

We recommend that you use this feature judiciously to end service representative conversations.

### Related information

[Enable sentiment analysis](../administer/enable-sentiment-analysis.md)  
[Enable Supervisor settings in Omnichannel for Customer Service](../administer/enable-monitor-assign-transfer-conv.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
