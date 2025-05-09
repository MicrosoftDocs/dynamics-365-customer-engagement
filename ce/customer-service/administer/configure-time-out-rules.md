---
title: Configure time-out rules
description: Learn how to configure time-out rules to initiate automatic actions and significantly improve agent productivity.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: how-to 
ms.collection: 
ms.date: 03/28/2025
ms.custom: bap-template
---

# Configure time-out rules

Time-out rules are useful settings that administrators can configure to enact certain automatic actions when conditions are met. The time-out rules can help businesses run their operations smoothly and meet the required service-level agreements (SLAs) when they connect with their customers through persistent chat and asynchronous messaging channels. Sometimes, AI agents are used as an equivalent to the customer service representative (service representative or representative) persona.

The following channels only are supported:

- Persistent chat
- SMS
- Microsoft Teams
- Social channels
    - WhatsApp
    - LINE
    - Messenger
    - WeChat
    - Apple Messages for Business 


## Prerequisite

The Omnichannel Administrator role.

## Configure the time-out rules

For the automatic actions to run, set up the time-out rules per workstream. You can configure rules to perform the following actions:

- **Send a message**: The system sends a message to the customer or agent based on the customer's idle time. You can send a reminder message to the customer to respond or a message to the agent to speed up their research to relay back to the customer.
- **Automatically close the conversation**: Automatically closes the conversation after the configured minutes of customer’s idle time is passed. This frees the agent's capacity to help other customers waiting in the queue and closes the conversation so that it's not in the Waiting state.

1. In your Dynamics 365 Customer Service instance, open Copilot Service admin center.

1. In the site map, select **Productivity** under **Agent experience**, and then select **Manage** for **Timeout rules**.
1. In **Timeout rules**, select **New**.
1. In **Add new timeout rule**, do the following steps in **Rule details**:
   - Enter a rule name.
   - Set the **Status** toggle to active.
   - **Trigger event**: The **Customer Non-Response Time** value is selected by default. The duration that the customer hasn't sent back a message, and the last message sent in the conversation is from the service representative. The duration is calculated by subtracting the current time from the time that representative sent the last message. The system calculates the duration only when the last message is from the service representative.
   - Select a workstream that corresponds to the channels where you want the rule to run.
1. In **Trigger conditions**, for the trigger event that you selected on the previous page, enter the following:
   - **Operator**: By default, **Greater than**.
   - **Value**: A numeric value that denotes the time-out period.
     > [!NOTE]
     > - A small difference of a few seconds between the exact time and the performance for the action might be there.
   - **Unit of time**: Time in days, hours, or minutes.
1. In **Actions**, select one of the following actions:
   - **Send a message**: The system sends the message automatically that you configure. The message sent to the customer appears as sent by the representative, while the message to the representative appears as a system message. Enter the following details:
      - **Message recipient**: Select **Customer Service Representative** or **Customer**.
      - **Custom automated message**: Select the language code in the **Select language** list, and enter a message text that you want to display to the agent or customer.
      - Repeat the steps to configure the message text in other languages.
      - In **Default / Fallback**, select a language to be the default language if the languages that you configure don't match the language set in the workstream.
           
        :::image type="content" source="../media/timeout-rule-action.png" alt-text="Screenshot of time-out rule action settings.":::

   - **Autoclose conversation**: Closes the conversation automatically based on the duration that's set for the channel. The conversation moves from open, active, or waiting to the closed state and the system frees the representative capacity.
1. Select **Done**. The rule that you created is listed on the **Timeout rules** page. 
1. You can then set a priority for the rules by entering a value. If two conditions are same, then priority determines the time-out rule to run. The workstream rules are independent of each other and follow the priority of their workstream order.

## Manage rules

Select a rule to enable the edit button that you can use to edit the rule.

You can change the priority per time-out rule so that if any condition is the same, the system runs the prioritized time-out rule first.

### Related information

[Understand conversation states](../use/oc-conversation-state.md)  