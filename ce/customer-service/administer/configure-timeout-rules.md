---
title: Configure timeout rules
description: Learn how to configure timeout rules to initiate automatic actions and significantly improve agent productivity.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: how-to 
ms.collection: 
ms.date: 10/30/2024
ms.custom: bap-template
---

# Configure timeout rules

Timeout rules are useful settings that administrators can configure to enact certain automatic actions when conditions are met. The timeout rules can help businesses run their operations smoothly and meet the required service-level agreements (SLAs) when they connect with their customers through persistent chat and asynchronous messaging channels. 

The following channels only are supported:

- Persistent chat
- SMS
- Microsoft Teams
- Social channels

## Prerequisite

System Administrator role.

## Configure the rules per workstream

You can configure rules to perform the following actions:

- **Send a message**: The system sends a message to the customer or agent based on the customer’s idle time. You can send a reminder message to the customer to respond or a message to the agent to speed up their research to relay back to the customer.
- **Automatically close the conversation**: Automatically closes the conversation after the configured minutes of customer’s idle time is passed. This frees the agent’s capacity to help other customers waiting in the queue and closes the conversation so that it's not in Waiting state.

1. In your Dynamics 365 Customer Service instance, go to Customer Service admin center.
1. In the sitemap, select **Productivity** under **Agent experience**, and then select **Manage** for **Timeout rules**.
1. On the **Timeout rules** page, select **New**.
1. On the **Add new timeout rule**, do the following steps in **Rule details**:
   - Enter a rule name.
   - Set the **Status** toggle to active.
   - Select a workstream corresponding to the channel where you want the rule to run.
1. Select **Next**, and in **Trigger conditions**, enter a numeric value that denotes the timeout period, and select a unit of time in days, hours, or minutes. By default the trigger event is **Customer Non Response Time** and the operator is **Greater than** that you can't edit.
1. Select **Next**, and in **Actions**, select one of the following actions:
   - **Send a message**: Do the following steps:
       1. Select agent or customer as the message recipient.
       1. In **Custom automated message**, select the language code in the **Select language** list.
       1. Enter a message text that you want to display to the agent or customer.
       1- Repeat the steps 2 and 3 to configure the message text in other languages.
       1. In **Default / Fallback**, select a language to be the default language if the languages that you configure don't match the language set in the workstream.
           
        :::image type="content" source="../media/timeout-rule-action.png" alt-text="Screenshot of timeout rule action settings.":::

   - **Autoclose conversation**: Closes the conversation automatically based on the duration that's set for the channel.   
1. Select **Done**. The rule that you created is listed on the **Timeout rules** page.1. 
1. You can then set a priority for the rules by entering a value. If two conditions are same, then priority determines the timeout rule to run. The workstream rules are independent of each other and follow the priority of their workstream order.

## Manage rules

Select a rule to enable the edit button that you can use to edit the rule.

### Related information

[Understand conversation states](../use/oc-conversation-state.md)  


