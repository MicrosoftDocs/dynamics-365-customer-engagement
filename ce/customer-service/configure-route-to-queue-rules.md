---
title: "Configure route-to-queue ruleset"
description: "Learn about how to configure a route-to-queue ruleset for a workstream in unified routing."
ms.date: 10/01/2022
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
searchScope:
- D365-App-customerservicehub
- D365-Entity-queueitem
- D365-UI-*
- Customer Engagement
- Dynamics 365
- Customer Service
---
# Configure a route-to-queues ruleset for a workstream

Use the CSR Manager or Omnichannel administrator role to configure the route-to-queue rules for a workstream.

You'll do the tasks listed in this article in the Customer Service admin center.

Queue routing rules send the work item to the right queue. The rules are written in the format of, "If defined condition satisfies, then route the work item to the defined queue." If no rules are defined or no rules match, then the incoming work item will be routed to the fallback queue of the respective workstream.

The route-to-queue ruleset is run after all the work classification rulesets are run.

A workstream can have only one route-to-queues ruleset.

After you configure the rules, the system matches the rule conditions, and operating hours of the corresponding queue to assign a work item to a queue. If more than one rule matches the required condition and the corresponding queues also match the operating hours, then the queue corresponding to the first rule in the list is selected for assignment. If none of the queues corresponding to the rules meet the operating hours, the work item is assigned to the queue that will be operational at the earliest.

## Percent-based allocation of work to queues

To load balance the workload optimally and distribute the load across multiple contact center vendors, organizations can configure percent-based routing to distribute work items to queues. In this way, the routing of work items to queues can be controlled using percentages. Percent-based allocation of work items is an optional setting that can be configured in the route-to-queue rules as discussed in the following section.

When you configure this feature, the system will pick a queue from the available list of queues in the route-to-queue rule, as per the configured percentages. However, the final queue that's selected is also dependent on the ruleset evaluation logic, such as queue overflow and override overflow settings.

## Configure rules in route-to-queue ruleset

1. In Customer Service admin center, select a workstream, and in the **Routing rules** section, select **Create ruleset** next to **Route to queues**, and then select **Create Rule** in **Decision list**.

1. In the **Create route to queue rule** dialog, enter a name in **Rule Name**. By default, the root record is selected and displayed at the top of the condition builder.

1. In **Conditions**, define the set of conditions. If you're creating rules for records, then the top-level condition is automatically populated. You can define conditions for up to two levels of the related records and attributes.

1. In **Route to queues**, select the queue to which the work items will be routed if the conditions are met.

1. To configure percent allocation, select **Add queue** and do the following:

    1. **Queue**: Select a queue in the dropdown list.

    1. **Work allocation percentage**: Enter a value that denotes the work allocation percent for the queue.

1. You can repeat the step to define the percent allocation for up to five queues. The total percent allocation for all the queues should sum up to 100.

:::image type="content" source="media/percent-based-routing.png" alt-text="Configure percent-based route-to-queue rules.":::

1. You can use the **Remove allocations** option that's available in the **More commands** ellipses to remove the percent-based routing. When you update the percent-based settings, you must ensure that the allocation totals to 100.

1. Repeat steps 2 through 5 to define the rules to cater to your business needs.

1. Optionally, after you create the required rules, you can reorder them in the ruleset by selecting the arrows in the **Order** column on the **Decision list** page.


## Options available for rules

The following options are available for the rules:

- Change the order in which the rules should be evaluated
- Search the rules
- View the condition that's been used for each rule by hovering the mouse over the condition.
- Create copies of the rules and update only the necessary information to avoid writing the conditions from scratch.

### Diagnostics for percent-based allocation

The route-to-queue stage of the diagnostics displays the following information about the queues:

- The queues that are considered
- The queues that are matched
- The final queue that's applied and the work item is routed to.

If a percent-based queue is considered by the routing system, on the page, the considered queue will be visually highlighted in the list of matched rules to differentiate it from the other queues configured in the rule. Similarly, if the work item is routed to one of the percent-based queues, it will be visually highlighted and the status will be displayed as "Applied". The information icon for the applied rule displays the queue details of the applied queue.

### See also

[Create a workstream for unified routing](create-workstreams.md)  
[Set up record routing](set-up-record-routing.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
