---
title: Set up assignment methods in Customer Service | MicrosoftDocs
description: "Set up assignment methods in Customer Service"
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 04/09/2021
ms.topic: article
ms.service: "dynamics-365-customerservice"
---

# Assignment methods for queues

Assignment methods determine how a work item is assigned. You can use the out-of-the-box assignment methods or build custom assignment rules by configuring the prioritization rules and assignment rulesets. You can set up assignment methods only through the **Customer Service Hub** or **Omnichannel admin center app**.

## Types of assignment methods

The following assignment methods are available out of the box:

- **Highest capacity:** Assigns work item to the agent with the highest capacity, amongst those who has the skills identified during the classification stage, and has the presence as specified in the allowed presence option of the work stream.
- **Round robin:** Assigns work item to the agent in the list order who matches the criteria for skills and presence.

The custom assignment method lets you use your own rulesets and rule items to configure priority, severity, and capacity for choosing the queues to which work items need to be routed. You can create the following rulesets:

- **Prioritization rulesets:** Lets you define the order in which the work items will be assigned to agents when they are available to take more work.
- **Assignment rulesets:** Represent a set of conditions that are used to select agents and use an order by option to sort the matching agents.

## How prioritization ruleset works

A prioritization ruleset is an ordered list of prioritization rules. Every prioritization rule represents a priority bucket in the queue.  In a prioritization rule you can specify a set of conditions and order by attributes. During evaluation, the prioritization rules will be run in the order they are listed. For the first prioritization rule, the work items in the queue that match its conditions will be put in the same priority bucket. In the priority bucket, the items will be further sorted by the order specified in the prioritization rule. The second rule will run on the rest of the items in the queue, to identify the next priority bucket, and sort that bucket by the order by attribute till all rules are evaluated.

As an example, let us look at the prioritization rule as seen in the following screenshot. This rule will match all the work items where the routed record (case) contains data and priority equals high. The matched items will be further sorted based on first in and first out attribute. 

> ![Prioritization scenario](media/ur-prioritization-scenario.png "Prioritization scenario")


1. Create a prioritization ruleset
2. Create a decision list of rules

## How assignment rulesets work

The assignment ruleset is an order list of assignment rules. Each assignment rule represents a set of conditions that is used to determine the agents to select and an order by field to sort the matching agents. At runtime, the assignment rule with the top order is evaluated first. The agents are matched as per the conditions specified in the rule. If more than one matching agents exist, then they are sorted by the ordered by field, and the top agent is assigned the work. If no agents are matched, then the next assignment rule in the rule set is evaluated. This can be thought of as gradual relaxation of constraints in the assignment such that first the strictest criteria is applied, and then the conditions are slowly reduced so that the best agent is found.

## Create an assignment method

Perform the following steps to create a custom assignment method:

1. On the **Assignment method** page of a queue, select **Create New**.
2. On the **Create work assignment** dialog box, enter a name and description for the ruleset, and select **Create**.
3. Select the ruleset, and select **Edit**. The options to configure prioritization rulesets and assignment rulesets are displayed.
   1. Do the following to set up prioritization rulesets:
   2. On the **Create Prioritization Ruleset** dialog box, enter a name and description for the ruleset, and select **Create**.
   3. On the **Decision list** page, select **Create rule**, and on the **Create prioritization rule** dialog box, enter a rule name and define the conditions when the rule should be run.
   4. Select the attribute on which you want to define the order by to route the work item to agents.


