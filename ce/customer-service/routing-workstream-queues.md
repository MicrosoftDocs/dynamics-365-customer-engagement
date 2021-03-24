---
title: "Routing rules in unified routing | MicrosoftDocs"
description: "Routing rules in unified routing"
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 04/01/2021
ms.topic: article
ms.service: "dynamics-365-customerservice"
---

# Routing rules for a workstream

A workstream is a container for work items to be enriched, routed, and assigned. A work stream is associated with a channel, such as live chat. Routing rules are written as rulesets, which comprises  rule items. Routing rules for a workstream comprises of work classification rules and route-to-queue rules.

## Work classification rules

Work classification rules are rules to update work item attributes. Typically, rules are written in the format of if defined condition satisfies, then set the output attributes to certain values, but can also be generated through machine learning models. They are optional and can be used to add additional information to the incoming work items which are then further used for more precise routing and assignment.

Work classification rules can be written using manual declarative decision list way or using machine learning models.

### Manual classification rules

Manual classification rules are run to update work item attributes. They are written in the format of if defined condition satisfies then set the output attributes to certain values. You can create conditions to define rules based on multiple entity attributes. To create manual work classification rulesets, see [Manual work classification rulesets](configure-work-classification.md#manual-work-classification-ruleset).

#### Skill attachment rules

They are sub type of manual work classification rules and are rules defined to attach skills to the work item. They are written in format of if defined condition satisfied then attach defined skills to the work item.

### Machine learning model-based rules

They are sub type of work classification rules and are rules defined to attach skills to the work item using the AI Builder text classification machine learning model created as part of Intelligent skill finder bootstrapping experience. They are written in format of – send work item selected attributes to the published model and attach the returned tags from the model as skills on the work item.

## Route-to-queues rules

Queue routing rules are rules to send the work item to the right queue. They are written in the format of if defined condition satisfies then route the work item to the defined queue. They are optional and if no rules are defined or no rules match, then the incoming work item will be routed to the default queue of the respective channel type. For a workstream, route to queue ruleset is run after all the work classification rulesets are run. A workstream can have only one route to queues ruleset.

### How prioritization rule set works

Prioritization rule set is an ordered list of prioritization rules. Every prioritization rule represents a priority bucket in the queue.  In a prioritization rule you can specify a set of 'conditions' and 'order by' attributes. During evaluation, the prioritization rules will be run in the order they are listed. For the first prioritization rule, the work items in the queue that match its conditions will be put in the same 'priority bucket'. In that bucket the items will be further sorted by the order specified in the prioritization rule. The second rule will run on the rest of the items in the queue, to identify the next priority bucket, and sort that bucket by the 'order by' attribute. And so on.

### Author the assignment rule set

After prioritization rule set, you can author the assignment rule set for the queue. The assignment rule set is an order list of assignment rules. Each assignment rule represents a set of conditions using which agents are selected and an order by field using which the matching agents are then sorted. During runtime, the assignment rule with the top order is evaluated first. The agents are matched as per the conditions specified in the rule. If there are more than one matching agents, then they are sorted by the ordered by field, and the top agent is assigned the work. If no agents are matched, then the next assignment rule in the rule set is evaluated and so on This can be thought as gradual relaxation of constraints in the assignment such that first the strictest criteria is applied, and then the conditions are slowly reduced so that the best agent is found.

### See also

