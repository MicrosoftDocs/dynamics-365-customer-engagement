---
title: Use timeout rules
description: 
author: Soumyasd27
ms.author: sdas
ms.reviewer: Soumyasd27
ms.topic: concept-article
ms.collection:
ms.date: 12/18/2025
ms.custom: bap-template
---

# Use time-out rules

The time-out rules feature in the Customer Service workspace helps you manage and monitor time-sensitive actions during conversations. By using this feature, you can ensure timely responses, improve productivity, and maintain control over automated processes. This article explains how to access and use the time‑out rules panel, interpret rule statuses, and manage rules effectively. When you disable a rule with the toggle, it halts the countdown execution even if conditions are met, while re‑enabling the rule resumes the countdown using the previous timer state.

## Prerequisite

Your administrator enabled [Configure time-out rules](../administer/configure-time-out-rules.md#configure-time-out-rules).

## Use the representative override panel

Here’s what you can do:

#### Access the Timeout Rules panel on the productivity pane

- In Customer Service workspace, select the **Timeout Rules** icon on the **Productivity** pane. If no time-out rules apply to the conversation, the panel remains blank. 

The panel refreshes dynamically for the currently open conversations. For each conversation, all active time-out rules are displayed in the panel. If there are more rules than the panel can display, scroll to view the remaining rules.

- To refresh and view the most accurate state of each time-out rule, select **Retry**.

#### View rules linked to the conversation, rule status, and remaining time through the hourglass tooltip

The following states indicate the status of the rule based on the conditions and remaining time until the action is performed: 

- **Active**: Condition true; countdown running. 

- **Started**: Timer just began; <50% time elapsed. 

- **Halfway**: >50% time elapsed. 

- **Almost**: >75% time elapsed. 

- **Cannot Off**: Too close to triggering. 
    > [!NOTE]
    > You can't disable this rule. To ensure reliability, rules enter **Cannot Off** if the timeout is less than one minute. 

- **Inactive**: Condition false; countdown stopped and reset. 

- **Just Ran**: Rule executed; timer stopped. 

- **Turned Off**: Representative disabled the rule completely. 

Hovering over the hourglass icon displays the exact remaining time, improving accessibility and time management. 

:::image type="content" source="../media/representative-timeout-rules.png" alt-text="Screenshot of the Timeout Rules panel." lightbox="../media/representative-timeout-rules.png":::

#### Toggle rules 

- Turn the rule off to stop the countdown and prevent rule execution, even if conditions are true. 

- Turn the rule on to resume countdown when conditions become true. Resuming a rule uses the existing timer for the rule.

## Related information

[Configure time-out rules](../administer/configure-time-out-rules.md#configure-time-out-rules)
