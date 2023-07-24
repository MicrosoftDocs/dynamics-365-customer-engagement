---
title: Assignment methods for queues
description: Learn about the different assignment methods for queues in Customer Service and Omnichannel for Customer Service and how you can use them in unified routing.
ms.date: 07/24/2023
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

The auto-assignment process in unified routing matches incoming work items with the best-suited agents based on the configured assignment rules. This continuous process consists of multiple assignment cycles and a default block size of work items.

Each cycle picks up the top unassigned work items in the applicable default block size and attempts to match each work item with an appropriate agent. Work items that aren't assigned to agents because of unavailability of agents or right skill match wasn't found are routed back to the queue.

The next assignment cycle picks up the next block of the top-priority items that includes new work items.

When eligible agents aren't found for the work items, the assignment cycle keeps retrying to assign the top number of default sized block items as applicable for the channel.

For digital messaging and voice, the default block size is 100 work items of top priority.

For records channel, each assignment cycle prioritizes up to 2000 work items and processes them in a block size of 500.

## Types of assignment methods

The following assignment methods are available out of the box:

- **Highest capacity**: Assigns work item to the agent with the highest available capacity. This agent is from among those agents who have the skills that are identified during the classification stage and presence that matches one of the allowed presences in the workstream. The work items are prioritized in the first-in, first-out manner—that is, the work item that was created first is assigned first. If more than one agent is available with the same capacity, the work item is assigned based on the round-robin order of the agents whose highest capacity is the same.

  If you want to use skill-based routing and set the default skill-matching algorithm for the workstream as exact match and choose highest capacity as the assignment method, then the system filters agents using exact skill match, workstream’s presence, and capacity requirements, and order the filtered agents by available capacity.

  If **Default skill matching algorithm** in the workstream is **Closest Match**, then the system filters agents based on the workstream's presence and capacity requirements and orders the filtered agents by closest match and not available capacity. More information: [Closest match](set-up-skill-based-routing.md#closest-match)

  If you need to distribute work fairly among agents, then you should consider switching to a round robin assignment strategy.

- **Round robin**: Assigns a work item to the agent who matches the criteria for skills, presence, and capacity. The initial order is based on when a user is added to the queue. Then, the order is updated based on assignments. Similar to how work items are assigned in the highest capacity method, in round robin assignment, the work items are prioritized in the first-in, first-out manner—that is, the work item that was created first is assigned first.

- **Most idle (preview)**: Assigns a work item to the agent who has been idle the most among all the agents who match skills and capacity.

  The assignment method uses the time since last capacity is released for a voice call to determine the agent to whom the next incoming call should be routed. For example, if two agents are configured in a queue, and both receive calls one after the other, the agent who finishes their current call first and is available is assigned the next call. The wrap-up settings that are configured for the workstream are accounted for in determining the most-idle agent. The agent presence statuses aren't used in determining the most-idle agent.

  Routing to the most-idle agent assignment strategy helps in better use of agents with a more fair distribution of work items across agents. This strategy provides higher agent satisfaction and improved customer satisfaction.

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

  - **Prioritization rulesets**: Lets you define the order in which the work items are assigned to agents when they're available to take more work.
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

A prioritization ruleset is an ordered list of prioritization rules. Every prioritization rule represents a priority bucket in the queue. In a prioritization rule, you can specify a set of conditions and order by attributes. During evaluation, the prioritization rules are run in the order they're listed. For the first prioritization rule, the work items in the queue that match its conditions is put in the same priority bucket. In the priority bucket, the items are further sorted by the order specified in the prioritization rule. The second rule runs on the rest of the items in the queue, to identify the next priority bucket, and sort that bucket by the order by attribute until all rules are evaluated.

You can create only one prioritization ruleset per queue.

As an example, consider the prioritization ruleset as seen in the following screenshot with four rules.

:::image type="content" source="media/ur-prioritization-scenario.png" alt-text="Prioritization scenario.":::

- During any assignment cycle, this prioritization ruleset runs, and the rules within the ruleset run in the order they're listed.

- The first rule, "High priority and premium," finds all work items in the queue where the associated case priority is "High" and the case category is "Premium". The system creates the top priority bucket with those work items and sorts them in the "First in and first out" manner as specified in the **Order by** attribute. The first work item to be assigned from the queue is the oldest item in this bucket.

- The next priority bucket is the work items where case category is "Premium". The work items with "Premium" case category and "High" priority have already been put in top bucket as per the preceding rule, so this rule only considers other work items with "Premium" case priority. The **Order by** attribute in this case also is "First in and first out".

- The next priority bucket consists of work items where case priority is high and they haven't been bucketed already. Here the work items are ordered by their "First Response By" field in the ascending order—that is, the work items that require the first response at the earliest are prioritized first.

Some important points about prioritization rules are as follows:

- You can create only one prioritization ruleset per queue.
- Prioritization rules are run during every assignment cycle. If you change any attributes of the work item, such as the priority of the case, that change is considered during the next assignment cycle.
- By default, the queue is sorted on a "first in and first out" manner. If you don't create a prioritization rule, then the oldest work item is assigned first.
- In normal scenarios, when a sufficient number of agents are available to take up the work items, the processing period is a couple of seconds only. The agents are assigned work items in the priority order. However, if work items pile up because of fewer eligible agents, and then an agent becomes available during the processing period, the agent is offered the next work item according to the priority order. This strategy might create a perception that the highest priority item wasn't assigned; especially after some top-priority items are attempted for assignment and yet remain in the queue.
- The work items that don't match the criteria of any of the prioritization rulesets are kept in the last priority bucket, and are ordered by "first in first out".
- Prioritization rules are skipped for affinity work items and such work items is assigned before other work items in the queue. For information about affinity, go to [Agent affinity](create-workstreams.md#agent-affinity).

## How assignment rulesets work

The assignment ruleset is an ordered list of assignment rules. Each assignment rule represents a set of conditions that is used to determine the agents to select and an order-by field to sort the matching agents. At runtime, the assignment rule with the top order is evaluated first. The agents are matched as per the conditions specified in the rule. If more than one matching agent exists, they're sorted by the order by field, and the top agent is assigned the work. If no agents are matched, then the next assignment rule in the ruleset is evaluated. This method can be thought of as a gradual relaxation of constraints in the assignment, such that first, the strictest criteria are applied, and then the conditions are reduced so that the best agent is found. If no matching agents are found, then the work item remains in the queue.

In the assignment rule, the system user attributes are matched with the requirement of the work item. When you select static match, the condition is formed on the System User entity attribute and static values. When you select dynamic match, the conditions on the left are based on the system user root entity and the conditions on the right are based on the conversation root entity. You can drill down to two levels on the conversation root entity to form the rule conditions. An assignment rule with the dynamic match and static match is as follows.

:::image type="content" source="media/assignment-rule-root-entity.png" alt-text="Assignment rule with dynamic match and static match conditions.":::

In scenarios when more than one agent matches the requirement of the work item, and there's a tie in the order by also, like, more than one matching agent has the same available capacity, the system resolves the assignment using round robin that's based on the earliest time of the last assignment.

For example, three agents, Lesa, Alicia, and Alan, are available with the coffee refund skill and can handle up to three chats at a time. Their last assignment time stamps are 10:30 AM, 10:35 AM, and 10:37 AM, respectively. A work item about a coffee refund arrives in the queue at 10:40 AM. With the order by set to "profile-based available capacity", all the agents at 10:40 AM have the same available capacity of 2 each. To break the tie between the agents, the system uses round robin. Therefore, the incoming chat is assigned to Lesa because her last assignment was the earliest at 10:30 AM. Later at 10:45 AM, if another coffee refund work item comes in, the system assigns it to Alicia. This is also based on the round robin order of assignment between Alicia and Alan, because their available capacities were the same and Alicia had an earlier assignment than Alan at 10:35 AM.

### Components of an assignment rule

The assignment rules are composed of the following items:

- **Order**: Specifies the order in which the assignment rule is evaluated in a ruleset. The lower-order rules are run first. If any rule results in matching a user, then the next set of rules isn't evaluated.
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
      |User skills|Custom match|Use the operator to find agents whose skills match at runtime based on the selected lookup attribute on the work item.|
      |Calendar schedule|Is working|Use this operator to find agents who are working as per their service scheduling calendars.|
      ||||
  
  - **Value**: The user attributes are compared against this value to find the right agent. The value can be static, such as Address 1: County equals "USA". The value can also be dynamic, so that you can compare the user attribute dynamically with the values on the work item. In dynamic values, you can select any attribute on the work item or related records. For example, the following condition finds users whose country is the same as that of the customer associated with the case.
  
     :::image type="content" source="media/dynamic-value-match.png" alt-text="Sample dynamic match.":::

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

:::image type="content" source="media/ur-sample-assign-scenario.png" alt-text="Sample assignment method.":::

The first condition specifies the "user skills" on which the operator is an exact match. Then the user attributes are evaluated. The different user attributes are specified with operators, and values for each attribute, such as the **Presence status** attribute, should be equal to "Available" or "Busy". On the right of the operator, you can specify the value that you want the attribute to be matched against. The values can be "static," such as "presence status equals Available or Busy". If you specify "dynamic," the condition is matched at runtime based on the expression you specify. For example, if you specify "Preferred Customer Type Equals Conversation.Contact.Membership Level," the "preferred customer type" of every agent is matched against the dynamically calculated membership level of the customer associated with the chat.

Dynamic match reduces the effort of having to write and maintain multiple static rules for each permutation and combination of the possible value.

### Limits on offering a work item repeatedly to an agent

When agents are offered a work item through automatic assignment, they typically can accept or decline. Both [rejection](enable-agent-reject-notifications.md) and [time out](manage-missed-notifications.md) of the notification is considered as a decline. An agent who declines the same work item thrice won't be considered for further auto assignment for the specific work item. The system tries to offer the declined work item to other agents in the queue if they're eligible.

For example, agent Serena Davis rejects a chat from customer Ana Bowman twice and the assignment notification times out in the third attempt. The system considers it as three declines and auto assignment won't offer the same chat to Serena Davis again. But the system offers the chat from Ana Bowman to other eligible agents. Also, Serena Davis is considered for other incoming conversations except the declined chat from Ana Bowman.

> [!NOTE]
> If all matching agents decline the work item because agent availability is low or the work requires a very specific skill and proficiency, the work remains in the queue. Similarly, if 100 agents decline a particular work item, auto assignment won't consider the work item in further assignment cycles. It can be manually assigned by supervisors or can be picked up by agents including those who rejected it.

You can update the default limit of three declines to a value between one and five based on your org requirement. The limit is applicable to all channels in the org.

You can make an OData call as follows to check the limit for your organization.

`<org-url>/api/data/v9.0/msdyn_omnichannelconfigurations?$select=msdyn_number_of_declines_allowed`

If this OData call returns the null value, it means that the decline limit is set to a default value of 3.

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
