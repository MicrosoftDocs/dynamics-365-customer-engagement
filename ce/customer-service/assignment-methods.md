---
title: Assignment methods for queues
description: Learn about the different assignment methods for queues in Customer Service and Omnichannel for Customer Service and how you can use them in unified routing.
ms.date: 04/05/2023
ms.topic: conceptual
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.custom: bap-template
searchScope:
- D365-App-customerservicehub
- D365-Entity-queueitem
- D365-UI-*
- Customer Engagement
- Dynamics 365
- Customer Service
---

# Assignment methods in unified routing

Use assignment methods to determine how to assign work items. You can use the out-of-the-box assignment methods or build custom assignment rules by configuring the prioritization rules and assignment rulesets.

## How auto assignment works

The auto-assignment process in unified routing matches incoming work items with the best-suited agents based on the configured assignment rules. This continuous process is made up of multiple assignment cycles.

Each cycle picks up the top unassigned work items in a default block of 100 items and attempts to match each work item with an appropriate agent. Work items that couldn't be assigned to agents because of unavailability of agents or right skill match not found is routed back to the queue. The next assignment cycle picks up another block of 100 top-priority items.

If no eligible agents are found for all the top 100 items in a queue, then each assignment cycle will keep retrying the top 100 items in that queue.

## Types of assignment methods

The following assignment methods are available out of the box:

- **Highest capacity**: Assigns work item to the agent with the highest capacity, among those who have the skills identified during the classification stage, and who have the presence as specified in the allowed presence option of the workstream. In this assignment method, the work items are prioritized in the first-in, first-out manner—that is, the work item that was created first is assigned first. If more than one agent is available with the same capacity, the work item is assigned based on the round-robin order of the agents whose highest capacity is the same.

  If you want to use skill-based routing and set the default skill-matching algorithm for the workstream as exact match and choose highest capacity as the assignment method, then the system will filter agents using exact skill match, workstream’s presence, and capacity requirements, and order the filtered agents by available capacity.

  If the default skill-matching algorithm for the workstream is set to closest match, then the system will filter agents based on the workstream's presence and capacity requirements and order the filtered agents by closest match and not available capacity. More information: [Closest match](set-up-skill-based-routing.md#closest-match)

  If you need to distribute work fairly among agents, then you should consider switching to a round robin assignment strategy.

- **Round robin**: Assigns a work item to the agent who matches the criteria for skills and presence. The initial order is based on when a user is added to the queue. Then, the order is updated based on assignments. Similar to how work items are assigned in the highest capacity method, in round robin assignment, the work items are prioritized in the first-in, first-out manner—that is, the work item that was created first is assigned first.

- **Most idle (preview)**: Assigns a work item to the agent who has been idle the most among all the agents who match skills and capacity.

   The assignment method uses the time since last capacity is released to determine the agent to whom the next incoming call should be routed. For example, if two agents are configured in a queue, and both receive calls one after the other, the agent who finishes their current call first and is available will be assigned the next call. The wrap-up settings that are configured for the workstream are accounted for in determining the most-idle agent. The agent presence statuses aren't used in determining the most-idle agent.

   Routing to the most-idle agent assignment strategy helps in better use of agents with a more fair distribution of work items across agents. This provides higher agent satisfaction and improved customer satisfaction.

    > [!IMPORTANT]
    >
    > The route to the most-idle agent feature is in preview and is available for the voice channel only.
    >
    > [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
    >
    > [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
    >
    > [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
    >
    > [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]
    >
    > This feature is intended to help customer service managers or supervisors enhance their team’s performance and improve customer satisfaction. This feature is not intended for use in making—and should not be used to make—decisions that affect the employment of an employee or group of employees, including compensation, rewards, seniority, or other rights or entitlements. Customers are solely responsible for using Dynamics 365, this feature, and any associated feature or service in compliance with all applicable laws, including laws relating to accessing individual employee analytics and monitoring, recording, and storing communications with end users. This also includes adequately notifying end users that their communications with agents may be monitored, recorded, or stored and, as required by applicable laws, obtaining consent from end users before using the feature with them. Customers are also encouraged to have a mechanism in place to inform their agents that their communications with end users may be monitored, recorded, or stored.

You can also create a custom assignment method to suit your business needs.

- **Create new**: Lets you create and use your own rulesets and rules to configure priority, severity, and capacity for choosing the queues to which work items need to be routed. You can create the following rulesets:

  - **Prioritization rulesets**: Let you define the order in which the work items will be assigned to agents when they're available to take more work.
  - **Assignment rulesets**: Represent a set of conditions that are used to select agents and use an order by option to sort the matching agents.
  
  > [!IMPORTANT]
  >
  > - You must configure presence, capacity, and skill-matching rules in the custom assignment method because the default settings defined for the workstream won't be used in custom assignment method.
  > - The out-of-the-box assignment strategies don't consider the agent operating hours. You must write a custom assignment method by using the "is_working" operator in the rule definition.

### Assignment cycle

Assignment cycle is prioritization of work items, their selection, and their assignment to the best-suited agent based on the assignment rules. Unified routing optimizes the assignment cycles across the multiple queues in the organization for best performance.

The assignment cycle starts with one of the following triggers:

- Arrival of a new work item in the queue.
- Change to agent presence.
- Updates to agent capacity.
- Addition of an agent to the queue.
- Periodic trigger every five minutes for record type of work item.

## How prioritization rulesets work

A prioritization ruleset is an ordered list of prioritization rules. Every prioritization rule represents a priority bucket in the queue. In a prioritization rule you can specify a set of conditions and order by attributes. During evaluation, the prioritization rules will be run in the order they're listed. For the first prioritization rule, the work items in the queue that match its conditions will be put in the same priority bucket. In the priority bucket, the items will be further sorted by the order specified in the prioritization rule. The second rule will run on the rest of the items in the queue, to identify the next priority bucket, and sort that bucket by the order by attribute until all rules are evaluated.

You can create only one prioritization ruleset per queue.

As an example, consider the prioritization ruleset as seen in the following screenshot with four rules.

![Prioritization scenario.](media/ur-prioritization-scenario.png "Prioritization scenario")

- During any assignment cycle, this prioritization ruleset will be run, and the rules within the ruleset will be run in the order they're listed.

- The first rule, "High priority and premium," will find all work items in the queue where the associated case priority is "High" and the case category is "Premium". It will create the top priority bucket with those work items and sort them in the "First in and first out" manner as specified in the **Order by** attribute. The first work item to be assigned from the queue will be the oldest item in this bucket.

- The next priority bucket will be of the work items where case category is "Premium". The work items with "Premium" case category and "High" priority have already been put in top bucket as per the preceding rule, so this rule will only consider other work items with "Premium" case priority. The **Order by** attribute in this case also is "First in and first out".

- The next priority bucket consists of work items where case priority is high and they haven't been bucketed already. Here the work items are ordered by their "First Response By" field in the ascending order—that is, the work items that require the first response at the earliest will be prioritized first.

Some important points about prioritization rules are as follows:

- You can create only one prioritization ruleset per queue.
- Prioritization rules are run during every assignment cycle. If you change any attributes of the work item, such as the priority of the case, that change will be considered during the next assignment cycle.
- By default, the queue is sorted on a "first in and first out" manner. If you don't create a prioritization rule, then the oldest work item will be assigned first.
- In normal scenarios, when a sufficient number of agents are available to take up the work items, the queue processing period is only a couple of seconds, and the agents are assigned work items in the priority order. However, if work items pile up because of fewer eligible agents and then an agent becomes available during the processing period, the agent will be offered the next work item according to the priority order. This might create a perception that the highest priority item wasn't assigned, especially after some top-priority items are attempted for assignment and yet remain in the queue.
- The work items that don't match the criteria of any of the prioritization rulesets are kept in the last priority bucket, and are ordered by "first in first out".
- Prioritization rules are skipped for affinity work items and such work items will be assigned before other work items in the queue. For information about affinity, go to [Agent affinity](create-workstreams.md#agent-affinity).

## How assignment rulesets work

The assignment ruleset is an ordered list of assignment rules. Each assignment rule represents a set of conditions that is used to determine the agents to select and an order-by field to sort the matching agents. At runtime, the assignment rule with the top order is evaluated first. The agents are matched as per the conditions specified in the rule. If more than one matching agent exists, they're sorted by the order by field, and the top agent is assigned the work. If no agents are matched, then the next assignment rule in the ruleset is evaluated. This can be thought of as a gradual relaxation of constraints in the assignment, such that first, the strictest criteria are applied, and then the conditions are slowly reduced so that the best agent is found. If no matching agents are found, then the work item remains in the queue.

In the assignment rule, the system user attributes are matched with the requirement of the work item. When you select static match, the condition is formed on the System User entity attribute and static values. When you select dynamic match, the conditions on the left are based on the system user root entity and the conditions on the right are based on the conversation root entity. You can drill down to two levels on the conversation root entity to form the rule conditions. An assignment rule with the dynamic match and static match is as follows.

:::image type="content" source="media/assignment-rule-root-entity.png" alt-text="Assignment rule with dynamic match and static match conditions.":::

In scenarios when more than one agent matches the requirement of the work item, the system resolves the assignment in a round robin manner, based on the earliest time of the last assignment—in other words, the agent who has been idle for the longest time since their last assignment. For example, three agents Lesa, Alicia, and Alan are available with the coffee refund skill and 100 units capacity, and their last assignment time stamps are 10:30 AM, 10:35 AM, and 10:37 AM respectively. A work item on coffee refund arrives in the queue. The system assigns the work item to Lesa because her last assignment was the earliest at 10:30 AM. Meanwhile, if another coffee refund work item comes in, the system will assign it to Alicia and not to Lesa or Alan.

However, if there's a tie between the availability of agents, the agent who has been idle for the longest time will be assigned the work item if all other conditions remain the same.

### Components of an assignment rule

The assignment rules are composed of the following items:

- **Order**: Specifies the order in which the assignment rule will be evaluated in a ruleset. The lower-order rules are run first. If any rule results in matching a user, then the next set of rules isn't evaluated.
- **Name**: The unique rule name.
- **Condition**: The expressions that are evaluated to match the users with the attributes of incoming work. The conditions have three parts:
  - **User attribute**: Properties of the users that can be used for comparing the user with the incoming work. The user attributes can be one of the following:
    - **Select attributes on the System User table.**
    - **Presence Status**: Maintained by the unified routing service based on user workloads and manual selection.
    - **Capacity**: Maintained by the unified routing service based on user workloads and manual selection.
    - **User skills**: Represents the skills associated with the user that can be used for doing skill-based assignment.
    - **Calendar Schedule**: Schedule of the user as represented in the user service scheduling calendars.
    - **Bot attributes**: Can be used only when you have configured bots as users and want to do some comparisons on them.
  - **Operators**: Define the comparison relationship between the User attribute and incoming work item attributes. 

      Unified routing filters the attribute-specific operators for you to choose from. Some special operators that are available for the attribute types are as follows.
    
      |Attribute type|Operator|Definition|
      |--------------|--------|----------|
      |Presence Status| Equals, Does not equal, Contains data, Does not contain data| Use an operator to find agents who have matching presence status as specified in the work item.|
      |Capacity|Equals, Does not equal, Contains data, Does not contain data|Use an operator to compare if the agent has enough capacity to work on the specified items.|
      |User skills|Exact match|Use an operator to find agents who have all the skills which the incoming work item requires.|
      |User skills|Custom match|Use the operator to find agents whose skills will match at runtime based on the selected lookup attribute on the work item.|
      |Calendar schedule|Is working|Use this operator to find agents who are working as per their service scheduling calendars.|
      ||||
  
  - **Value**: The user attributes are compared against this value to find the right agent. The value can be static, such as Address 1: County equals "USA". The value can also be dynamic, so that you can compare the user attribute dynamically with the values on the work item. In dynamic values, you can select any attribute on the work item or related records. For example, the following condition finds users whose country is the same as that of the customer associated with the case.
  
     ![Sample dynamic match](media/dynamic-value-match.png "Sample dynamic match")

    For some operators, values aren't required. They can be conditions, such as "Contains data," "Does not contain data," and "Calendar schedule: is working."

    For user skills, the values are predefined for the operators. More information: [Set up skill-based routing](set-up-skill-based-routing.md)

- **Order by**: If multiple agents match the conditions in a rule, you can use the "Order by" clause to find the best-suited one. You can specify the following order by clauses:

  - **Ordering Attributes**:

    - **Most idle (preview)**: In preview release, this option is available for voice channel queues only. The work item is routed to the agent who is idle the most among all the agents who match skills and capacity. For more information, see the [Types of assignment methods](#types-of-assignment-methods) section.
    - Round robin
    - Unit-based available capacity
    - Profile-based available capacity
    - Proficiency
    - Skill count

  - **User Attributes**: These attributes are defined on the system user entity.

A sample assignment rule is explained in the following scenario with a screenshot.

![Sample assignment method](media/ur-sample-assign-scenaro.png "Sample assignment method")

The first condition specifies the "user skills" on which the operator is an exact match. Then the user attributes are evaluated. The different user attributes are specified with operators, and values for each attribute, such as the **Presence status** attribute, should be equal to "Available" or "Busy". On the right of the operator, you can specify the value that you want the attribute to be matched against. The values can be "static," such as "presence status equals Available or Busy". If you specify "dynamic," the condition will be matched at runtime based on the expression you specify. For example, if you specify "Preferred Customer Type Equals Conversation.Contact.Membership Level," the "preferred customer type" of every agent will be matched against the dynamically calculated membership level of the customer associated with the chat.

Dynamic match reduces the effort of having to write and maintain multiple static rules for each permutation and combination of the possible value.

### Limits on offering a work item repeatedly to an agent

When agents are offered a work item through automatic assignment, they typically can accept or decline. Both [rejection](enable-agent-reject-notifications.md) and [time out](manage-missed-notifications.md) of the notification is considered as a decline. If an agent declines an offer three times for the same work item, that agent will not be considered as eligible for auto assignment in future assignment attempts for the specific work item.

For example, if agent Serena Davis rejects a chat from customer Ana Bowman twice and the notification times out in the third attempt, it would be counted as three declines and the auto assignment won't offer the chat from Ana Bowman to Serena Davis again. But the chat from Ana Bowman will be offered to other eligible agents. Also Serena Davis will be considered for other incoming conversations except the chat from Ana Bowman.

> [!NOTE]
> If all matching agents decline the work because agent availability is low, or the work requires a very specific skill and proficiency, the work remains in the queue and can be picked by agents including those who rejected it or be manually assigned by supervisors. The system will try to offer the declined work to other agents in the queue, if they are eligible based on assignment configuration.

If 100 agents have already declined a particular work item, auto assignment won't consider the work item in further assignment cycles. The work item remains open in the queue and can be picked by agents or assigned by supervisors.

You can update the default limit of three declines per agent per work to a value between one and five based on your organization's requirement. The limit is applicable to all channels in the org.

You can make an OData call as follows to check the limit for your organization.

`<org-url>/api/data/v9.0/msdyn_omnichannelconfigurations?$select=msdyn_number_of_declines_allowed`

If this OData returns the null value, it means that the decline limit is set to a default value of 3.

You can update the OData call as follows to modify the limit.

`var data = { "msdyn_number_of_declines_allowed": 3 } // update the record Xrm.WebApi.updateRecord("msdyn_omnichannelconfiguration", "d4d91600-6f21-467b-81fe-6757a2791fa1", data).then( function success(result) { console.log("Omnichannel Configuration updated"); // perform operations on record update }, function (error) { console.log(error.message); // handle error conditions } );`

### See also

[Configure assignment methods and rules](configure-assignment-rules.md)  
[FAQ about unified routing in Customer Service, Omnichannel for Customer Service](unified-routing-faqs.md)  
[Diagnostics for unified routing](unified-routing-diagnostics.md)  
[Create workstreams](create-workstreams.md)  
[Create queues](queues-omnichannel.md)  
[Set up unified routing for records](set-up-record-routing.md)  
[Set up skill-based routing for unified routing](set-up-skill-based-routing.md)  
