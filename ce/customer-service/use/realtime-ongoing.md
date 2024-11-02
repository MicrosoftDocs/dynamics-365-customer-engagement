---
title: View and understand the Ongoing conversation report in Omnichannel real-time analytics
description: Understand the Ongoing conversation report in Omnichannel real-time analytics to view conversations, active agents, and customer sentiment.
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.topic: conceptual
ms.collection:
ms.date: 11/02/2024
feedback_product_url: https://experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/05/2023
---

# View and understand the Ongoing conversation report in Omnichannel real-time analytics

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

The **Ongoing conversation** report shows ongoing conversations from the last 24 hours that are currently being handled by agents in your organization and that aren't yet closed. The report displays those conversations that have the open, active, wrap-up, or waiting status. Learn more in [Understand conversation states](oc-conversation-state.md).

This report provides a holistic view of the conversations in real time. It includes details about subject, status, active agent details, queue, channel, wait time, handle time, and customer sentiment. Learn more in [Overview of Omnichannel real-time analytics dashboards](intro-realtime-analytics-dashboard.md).

Digital messaging, chat, and voice channels only are supported. Record routing isn't supported.

[Learn more about the metrics that are shown on the Ongoing conversation report.](oc-metrics-dimensions.md#use-omnichannel-for-customer-service-metrics)

:::image type="content" source="../media/realtime_ongoing conversations.png" alt-text="The image shows real-time ongoing conversations report.":::

You can perform different actions, such as assign or transfer a conversation, as described in the following sections.

## Assign conversations

Assign an incoming or unassigned conversation filtered by either a queue or an agent, after reviewing the skill set and capacity profile of agents.

1. In the Contact Center workspace or Customer Service workspace app, go to the dashboard view selector, and then select the **Ongoing Conversations** report.

1. Select a conversation in an **Open** state, and then select **Assign**.

1. In the **Assign conversations** dialog, select **Agent**, or **Queue**. If you select **Agent**, only those agents whose presence matches with one of the allowed presence values in the workstream configuration are displayed.
If you select **Queue**, all other queues&mdash;except the one to which the conversation is currently assigned&mdash;are displayed.

1. Select **Assign**.

## Transfer conversations

Transfer an ongoing conversation from one agent to another after reviewing the skill set and capacity profile of an agent.

1. From the dashboard view selector, select the **Ongoing Conversations** report.

1. Select a conversation in the **Active** or **Waiting** state, and then select **Transfer**.

1. In the **Transfer conversations** dialog, select an agent from the list of agents that appears.

      A list of agents belonging to the same queue and whose presence matches with one of the allowed presence values in the workstream configuration is displayed.

1. Select **Transfer**. The selected conversation is transferred to the agent.

## Monitor conversations

Listen to an ongoing conversation. When you select **Monitor**, you receive a message indicating that monitoring has begun. This action is applicable to active conversations that were accepted by the agent, conversations that are in a wrap-up state, and conversations that are in a waiting state only. If you have the agent app open in multiple tabs or browsers, the monitored conversation opens in the one where you select **Monitor**. Other browsers remain as-is.


1. From the dashboard view selector, select the **Ongoing Conversations** report. The list of conversations that your agents are currently handling appears.

1. Select a conversation that you want to monitor, and select **Monitor**. The conversation page opens.

1. Optionally, to join a conversation, select **Join chat** in the communication panel.

    Both the agent and the customer receive notifications when you join a conversation. Depending on your requirements, you can consult with the agent and customer. Learn more in [View communication panel](oc-conversation-control.md).

## Force close conversations

> [!CAUTION]
> We recommend that you use the Force close option cautiously.

Forcibly close a conversation by closing the work item. When you select **Force close**, a confirmation message appears. You must select **Proceed** to close the work item. When you forcibly close a conversation, the conversation immediately ends for the customer too. 

1. From the dashboard view selector, select the **Ongoing Conversations** report.

2. Select a conversation and then select **Force Close**.

The participants receive a notification that a supervisor ended their conversation.

## Assign, transfer, monitor, or force close converations in customized reports

To be able to perform the actions on your customized reports, you must complete the following prerequisites:

- Enable all of the customizations in [data model customization](../administer/model-customize-reports.md#customize-data-models-of-historical-and-real-time-analytics-reports), including step 4 [Step 4: Embed customized reports back to Dynamics 365](../administer/model-customize-reports.md#step-4-embed-customized-reports-back-to-dynamics-365).
- Create reports using [the out-of-the-box data model in your custom reports](use-datamodel.md#use-the-out-of-the-box-data-model-in-your-custom-reports).
- Make sure appropriate roles exist for viewing and embedding reports. Learn more in [Configure analytics and insights dashboards](../administer/configure-customer-service-analytics-insights-csh.md#configure-analytics-and-insights-dashboards).


1. In Customer Service workspace, go to **Customized reports**, and then go to the Ongoing conversations report.
1. Select the conversation that needs to be updated.
 
    When the **Agent Name** doesn't exist, the following options are enabled.
    1. **Assign**: You can assign an agent by queue for the conversation.
    1. **Force close**: You can force close the conversation if required.
    
    When the **Agent Name** exists, the following options are enabled.
    1. **Transfer**: You can transfer the conversation from one agent to another in the same queue.
    1. **Monitor**: You can open the conversation dialog to monitor the chat.
    1. **Force close**: You can force close the conversation if required.
  
After you assign or transfer conversations, manually refresh the report to view the latest status.

### Related information

[Use Omnichannel for Customer Service metrics](oc-metrics-dimensions.md#use-omnichannel-for-customer-service-metrics)<br>
[Manage real-time analytics reports in Omnichannel for Customer Service](../administer/enable-realtime-analytics-dashboard-administrator.md)<br>
[Overview of Omnichannel real-time analytics dashboard](intro-realtime-analytics-dashboard.md#overview-of-omnichannel-real-time-analytics-dashboard)<br>
[View and understand the Voice report in Omnichannel real-time analytics](realtime-voice-dashboard.md)<br>
[View and understand the Agents report in Omnichannel real-time analytics](realtime-agents-analytics.md#view-and-understand-the-agents-report-in-omnichannel-real-time-analytics)<br>
[View and understand the Summary report in Omnichannel real-time analytics](realtime-summary-dashboard.md#view-and-understand-the-summary-report-in-omnichannel-real-time-analytics)

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
