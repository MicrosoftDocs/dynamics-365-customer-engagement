---
title: Configure time-out rules
description: Learn how to configure time-out rules to initiate automatic actions and significantly improve agent productivity.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: how-to 
ms.collection: 
ms.date: 12/11/2025
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
        The duration is calculated by subtracting the time of the representative’s last message from the current time. The system calculates the duration only when the most recent message was sent by the service representative.
      - **Representative Non-Response Time**: 
        - (Unresponsiveness to the first customer message): The duration between the first message by the customer and post-assignment of the representative to the conversation. The duration is calculated by subtracting the current time from the representative’s assignment time. The system calculates the duration only when the representative accepts the notification or auto-assigns the notification timeout, or is force-assigned by the supervisor.
        - (Mid-conversation unresponsiveness to the customer message): The non-responsive time of the representative since the customer’s last message. The duration is calculated by subtracting the customer’s last message time from the current time. The system calculates the duration only when the last message is from the customer.
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

## Enable representative override

The override feature ensures automation never disrupts active or sensitive conversations. It gives representatives the power to pause or resume timeout rules based on real customer needs. This flexibility prevents premature conversation closures and builds trust in automated workflows. For enterprise teams, representativeOverride is essential—combining structured processes with the adaptability required for exceptional customer service.

To enable representative Override, admins must configure two key areas in the Customer Service admin center: 

1. Enable Timeout Rules 

Navigate to Customer Service Admin Center → Representative Experiences → Productivity Area → Timeout Rules 

Turn on the representativeOverride tool to make sure that the feature will be available for the conversations with timeout rules enacted. 

 

 

2. Turn On representative Override Panel 

Go to Workspace → Experience Profile → Productivity Pane 

Enable the Timeout Rules Override panel:  

Default Profiles we provide the representative override turned on. 

Customer Service Workspace + Channels 

Omnichannel for Customer Service 

Custom Profiles:  

Manually activate the panel so CSRs can access it. 

Validate visibility:  

If the pane is not enabled, representative Override will not appear in the UI. 

Customer Service Representative Experience (Once Enabled) 

When representative Override is on, representatives gain full control over timeout rules enacting during live conversations. 

 

Accessing the representative Override Panel: 

representative clicks the Timeout Rules icon in the productivity pane. 

Empty State:  

If no timeout rules apply to the conversation, the panel remains blank. 

representative Override Panel Behavior: 

The panel refreshes dynamically for the currently open conversation. 

For each conversation, all active timeout rules are displayed in the panel. 

If there are more rules than the panel can display, scrolling is supported for easy navigation. 

A Retry button at the top of the panel allows representatives to refresh and view the most accurate state of each timeout rule. 

For each timeout rule, the panel shows: 

Rule States – Indicates the status based on conditions and time remaining until the action executes: 

Active: Condition true; countdown running. 

Started: Timer just began; <50% time elapsed. 

Halfway: >50% time elapsed. 

Almost: >75% time elapsed. 

Cannot Off: Too close to triggering; representativecannot disable.  

To ensure reliability, rules enter Cannot Off if the timeout is within <2 minutes. 

### Related information

[Understand conversation states](../use/oc-conversation-state.md)  