---
title: "Configure route-to-queue rules"
description: "Learn about how to configure a route-to-queue ruleset for a workstream in unified routing."
ms.date: 02/24/2023
ms.topic: article
author: neeranelli
ms.author: nenellim
searchScope:
- D365-App-customerservicehub
- D365-Entity-queueitem
- D365-UI-*
- Customer Engagement
- Dynamics 365
- Customer Service
---
# Configure route-to-queues rules for a workstream

Queue routing rules send the work item to the right queue. The rules are written in the format of, "If defined condition satisfies, then route the work item to the defined queue." If no rules are defined or no rules match, then the incoming work item will be routed to the fallback queue of the respective workstream.

The route-to-queue ruleset is run after all the work classification rulesets are run.

A workstream can have only one route-to-queues ruleset.

After you configure the rules, the system matches the rule conditions, and overflow handling of the corresponding queue to assign a work item to a queue. If more than one rule matches the required condition and the corresponding queues aren't overflowing, then the queue corresponding to the first rule in the list is selected for assignment. If all the queues corresponding to the rules are overflowing, the work item is assigned to the queue that will be available first.

The routing diagnostics gives a detailed view of the matched and applied rules in the route-to-queue stage. More information: [Diagnostics for unified routing](unified-routing-diagnostics.md#route-to-queue)

## Percentage-based allocation of work to queues

To balance the workload optimally and distribute it across multiple contact center vendors, organizations can configure percentage-based routing. The routing of work items to queues is controlled using percentage allocation. Percentage-based allocation of work items is an optional setting that can be configured in the route-to-queue rules as discussed in the following section.

When you configure this feature, the system picks a queue from the available list of queues in the route-to-queue rule, as per the configured percentages. The final queue that's selected, however, is also dependent on the ruleset evaluation logic, such as queue overflow and override overflow settings.

## Configure rules in route-to-queue ruleset

1. In Customer Service admin center, select a workstream.

1. In the **Routing rules** section, select **Create ruleset** next to **Route to queues**, and then select **Create Rule** in **Decision list**.

1. In the **Create route to queue rule** dialog, enter a name in **Rule Name**. By default, the root record is selected and displayed at the top of the condition builder.

1. In **Conditions**, define the set of conditions. If you're creating rules for records, then the top-level condition is automatically populated. You can define conditions for up to two levels of the related records and attributes.

1. In **Route to queues**, select the queue to which the work items will be routed if the conditions are met.

1. To configure percent allocation, select **Add queue** and do the following:

    1. **Queue**: Select a queue in the dropdown list.

    1. **Work allocation percentage**: Enter a value that denotes the percentage of work allocation for the queue.

1. Repeat **Step 6** to define the percentage allocation for up to five queues. The total percentage allocation for all the queues should sum up to 100.

   :::image type="content" source="media/percent-based-routing.png" alt-text="Configure percent-based route-to-queue rules.":::

1. Use the **Remove allocations** option that's available in the **More commands** ellipses to remove the percentage-based routing. When you update the percentage-based settings, you must ensure that the allocation totals to 100.

1. Repeat **Steps 2 through 6** to define the rules to cater to your business needs.

1. Optionally, after you create the required rules, reorder them in the ruleset by selecting the arrows in the **Order** column on the **Decision list** page.

## Options available for rules

The following options are available for the rules:

- Change the order in which the rules should be evaluated
- Search the rules
- View the condition that's been used for each rule by hovering the mouse over the condition.
- Create copies of the rules and update only the necessary information to avoid writing the conditions from scratch.

### Diagnostics for percentage-based allocation

The route-to-queue stage of the diagnostics displays the following information about the rules:

- The rules that are matched.
- The final rule that's applied and the queue to which the work item is routed.

For each of the matched or applied rules, the corresponding queue is also displayed. For the percentage-based rule, the queue that's picked up from the set is highlighted.

:::image type="content" source="media/diagnostics-percentage-based-routing.png" alt-text="Routing diagnostics of percentage-based routing.":::

The runtime allocation percentages might deviate slightly from the allocation that you've configured in the rules. The margins tend to be negligible as the number of work items increases.

### Engagement context for asynchronous channels

You can configure routing rule conditions for the social channels, such as Facebook and WhatsApp based on the attribute values. The attributes are listed channel wise as follows:

- **Microsoft Teams**: Use the **Teams Engagement Context** entity to set a condition on the **Customer name** attribute.

- **Facebook**: Use the **Facebook Engagement Context (Conversation)** entity to set conditions on the following attributes:

  - **Customer name**: The customer name is shown in the format "first name, last name".
  - **Locale**: For a list of locales, go to Facebook developer documentation.
  - **Timezone**: Timezone is shown as a number relative to GMT, for example, “5.5”.
  - **User Page Scoped Id**: This is shown as a number string.

- **Google's Business Messages**: Use the **Google's Business Messages** entity to set conditions on the following attributes:

  - Entry point
  - Place id
  - Resolved locale
  - User device locale

- **Apple Messages for Business**: Use the **Apple messages for business** entity to set conditions on the following attributes:

  - Group id
  - Intent id
  - Locale

- **LINE**: Use the **LINE Engagement Context** entity to set conditions on the **Customer name** attribute.

- **WeChat**: Use the **WeChat Engagement Context** entity to set conditions on the following attributes:

  - Customer name
  - Gender
  - City
  - Province
  - Country

- **WhatsApp**: Use the **WhatsApp Engagement Context (Conversation)** entity to set conditions on the **Customer Phone Number** and **Customer First Message** attributes. The **Customer First Message** attribute lets you create a pre-filled message that will automatically appear in the text field of a customer chat.

- **Twitter**: Use the **Twitter Engagement Context (Conversation)** entity to set conditions on the following attributes:  

  - Customer name
  - Customer screen name
  - Followers count
  - Friends count

- **SMS**: Use the **SMS Engagement Context** entity to set conditions on the following attributes:  

  - Customer phone number
  - Org phone number
  - Locale
  - Provider
  - Provider display name

### See also

[Manage overflow conditions](manage-overflow.md)  
[Create and manage queues](queues-omnichannel.md)  
[Create a workstream for unified routing](create-workstreams.md)  
[Configure work classification rules](configure-work-classification.md)  
[Set up record routing](set-up-record-routing.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
