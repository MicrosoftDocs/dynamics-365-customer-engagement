---
title: Configure time-out rules
description: Learn how to configure time-out rules to initiate automatic actions and significantly improve agent productivity.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: how-to 
ms.collection: 
ms.date: 01/09/2025
ms.custom: bap-template
---

# Configure time-out rules

Time-out rules are useful settings that administrators can configure to enact certain automatic actions when conditions are met. The time-out rules can help businesses run their operations smoothly and meet the required service-level agreements (SLAs) when they connect with their customers through the messaging channels. Sometimes, AI agents are used as an equivalent to the customer service representative (service representative or representative) persona.

> [!NOTE]
> Time-out rules support live chat and all messaging channels except the voice channel.

## Prerequisite

The Omnichannel Administrator role.

## Configure the time-out rules

For the automatic actions to run, set up the time-out rules per workstream.

1. In your Dynamics 365 Customer Service instance, open Copilot Service admin center.

1. In the site map, select **Productivity** under **Agent experience**, and then select **Manage** for **Timeout rules**.
1. In **Timeout rules**, select **New**.
1. In **Add new timeout rule**, do the following steps in **Rule details**:
   - Enter a rule name.
   - Set the **Status** toggle to active.
   - **Trigger event**: Select one of the following:
      - **Customer Non-Response Time**: The time a customer stays inactive after the representative’s last message. 
        The duration is calculated by subtracting the time of the representative’s last message from the current time. The system calculates the duration only when the most recent message is sent by the service representative.
      - **Representative Non-Response Time**: 
        - (Unresponsiveness to the first customer message): The duration between the first message by the customer and post-assignment of the representative to the conversation. The duration is calculated by subtracting the current time from the representative’s assignment time. The system calculates the duration only when the representative accepts the notification or autoassigns the notification timeout, or is force-assigned by the supervisor.
        - (Mid-conversation unresponsiveness to the customer message): The nonresponsive time of the representative since the customer’s last message. The duration is calculated by subtracting the customer’s last message time from the current time. The system calculates the duration only when the last message is from the customer.
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

   - **Close conversation**: Closes the [conversation automatically](auto-close-conversation-powerapps.md) based on the duration that's set for the channel. The conversation moves from open, active, or waiting to the closed state and the system frees the representative capacity.
   - **Move active conversation to waiting**: For asynchronous messaging or persistent chat channels, the system moves the active conversation to the waiting state. The representative receives a notification when the customer restarts the conversation. Representatives can restart the conversation from their inbox.
   - **Release conversation back to queue for reassignment**: Releases the conversation from the current representative and re-assigns the conversation to a different representative in the same queue.  
1. Select **Done**. The rule that you created is listed on the **Timeout rules** page. 
1. You can then set a priority for the rules by entering a value. If two conditions are same, then priority determines the time-out rule to run. The workstream rules are independent of each other and follow the priority of their workstream order.

## Manage rules

Select a rule to enable the edit button that you can use to edit the rule.

You can change the priority per time-out rule so that if any condition is the same, the system runs the prioritized time-out rule first.

## Enable override by representative

The ability to override ensures automation never disrupts active or sensitive conversations. It gives representatives the power to pause or resume time-out rules based on real customer needs. This flexibility prevents premature conversation closures and builds trust in automated workflows. For enterprise teams, representative override capability is essential, combining structured processes with the adaptability required for exceptional customer service.

To enable the representative override option, you need to:

1. **Enable time-out rules**

- In Copilot Service admin center, switch the **Customer Service Representative Override tool** to on. This ensures that the feature is available for the conversations with timeout rules enabled. 

2. **Turn On CSR Override Panel**:

   1. Go to **Workspace** > **Experience Profile** > **Productivity Pane.**
   1. Select the **Time-out Rules Override panel**. 
   
For default profiles, the representative override option is turned on for:

   - Customer Service Workspace and channels
   - Omnichannel for Customer Service
   
For custom profiles, you need to manually activate the panel for representatives.

> [!NOTE]
> If the panel isn't enabled, the representative override option doesn't appear on the user interface.

Once the representative override option is on, representatives get full control over time-out rules during live conversations.

### Related information

[Understand conversation states](../use/oc-conversation-state.md)  
[Use timeout rules](../use/use-timeout-rules.md#use-timeout-rules) 