---
title: Use timeout rules
description: 
author: Soumyasd27
ms.author: sdas
ms.reviewer: Soumyasd27
ms.topic: concept-article
ms.collection:
ms.date: 12/12/2025
ms.custom: bap-template
---

# Use time-out rules

The time-out rules feature lets you view and control time-out rules that apply to conversations. When your adWhen representative Override is on, representatives gain full control over timeout rules enacting during live conversations. 

## Prerequsites

You administrator has enabled [Configure time-out rules](../administer/configure-time-out-rules.md#configure-time-out-rules).

## Use the representative override panel

Here’s what you can do:

**Access the Timeout Rules panel by selecting it in the productivity pane**: 

In Customer Service workspace, select the **Timeout Rules** icon on the **Productivity** pane. If no time-out rules apply to the conversation, the panel remains blank. 

The panel refreshes dynamically for the currently open conversations. For each conversation, all active time-out rules are displayed in the panel. If there are more rules than the panel can display, you can scroll the page to view the remaining rules.

To refresh and view the most accurate state of each time-out rule, select **Retry**.

**See all rules linked to the conversation, along with their status and remaining time through the hourglass tooltip**

The following rule states indicate the status based on conditions and time remaining until the action executes: 

- **Active**: Condition true; countdown running. 

- **Started**: Timer just began; <50% time elapsed. 

- **Halfway**: >50% time elapsed. 

- **Almost**: >75% time elapsed. 

- **Cannot Off**: Too close to triggering; representative can't disable. To ensure reliability, rules enter **Cannot Off** if the timeout is within <2 minutes. 

-**Inactive**: Condition false; countdown stopped and reset. 

-**Just Ran**: Rule executed; timer stopped. 

-**Turned Off**: CSR disabled rule entirely. 

Hovering over the hourglass icon displays the exact remaining time, improving accessibility and time management. 

**Toggle rules**: 

- Turn the rule off stops countdown and prevents rule execution, even if conditions are true. 

- Turn the rule on resumes countdown when conditions become true. 

Resuming a rule uses the existing timer for the rule.

## Related information

[Configure time-out rules](../administer/configure-time-out-rules.md#configure-time-out-rules)
