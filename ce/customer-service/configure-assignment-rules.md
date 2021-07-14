---
title: "Configure assignment methods for queues | MicrosoftDocs"
description: "Contains steps on how to configure the different assignment methods for queues in Customer Service and Omnichannel for Customer Service"
ms.date: 07/14/2021
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
---

# Configure assignment methods and rules for queues

After creating queues, if you want to use custom assignment methods, you'll create assignment rulesets comprising rules.

You can create the custom assignment methods in the Omnichannel admin center and Customer Service Hub apps.

In unified routing, the process of creating assignment rulesets involves the following steps:

1. **Create assignment rulesets**: For each assignment ruleset, you'll configure the conditions and order by option.
2. **Create selection criteria**: If you create more than one assignment ruleset, you'll need to define the rules for the selection criteria. The selection criteria determines which ruleset out of the many should be run. More information: [Configure selection criteria](#configure-selection-criteria).

## Create an assignment method and configure rules

Perform the following steps to create a custom assignment method:

1. In Omnichannel admin center, in the site map, select **Queues**. In Customer Service Hub, in **Service Management**, in the site map, select **Advanced queues** under **Unified Routing**.
2. On the **Assignment method** page of a queue, select **Create New**.
3. In the **Create work assignment** dialog box, enter a name and description for the ruleset, and select **Create**.
4. Select the ruleset, and select **Edit**. The options to configure prioritization rulesets and assignment rulesets are displayed.
5. Do the following to set up prioritization rulesets:
   1. On the **Create Prioritization Ruleset** dialog box, enter a name and description for the ruleset, and select **Create**.
   2. On the **Decision list** page, select **Create rule**, and on the **Create prioritization rule** dialog box, enter a rule name and define the conditions when the rule should be run.
   3. Select the attribute on which you want to define the order-by to route the work item to agents.
   4. Create as many rules as are needed.
5. To create an assignment ruleset, on the **Assignment method** page, select **Create ruleset**.
6. Enter a name and description for the ruleset, and select **Create**. The ruleset is created.
7. On the **Assignment ruleset** page that appears, select **Create rule**.
8. In the **Create assignment rule** dialog box, do the following to add conditions and ordering attributes:
   1. **Rule Name**: Enter a rule name.
   2. **Conditions**: Select **Add** to select an attribute or related entity and define condition.
   3. **Order by**: Select an attribute to define the order of work assignment if multiple agents match the condition.
   4. Select **Create**.
   5. Repeat the steps 1 through 4 to configure multiple rules.
   
   > [!NOTE]
   > We recommend that you reduce the granularity of the conditions for the assignment roles in a descending order.

9. You can sort the order in which the rules should be evaluated during work assignment.
10. If you create more than one assignment ruleset, a warning message is displayed that alerts you to define the selection criteria to run the rulesets.

You can create a sample assignment rule with the following conditions.

| Attribute | Operator | Match type | Attribute value|
|----|----------|-----|-----|
| User skills | Exact match | |All skills |
| Presence status | Equals | Dynamic match | Conversation.Workstream.Allowed Presences|
| Capacity | Is greater than or equal to | Dynamic match | Conversation.Workstream.Capacity |
| Available capacity | Is greater than | Static value | 50 |
||||

![Sample assignment rule.](media/ur-sample-assign-rule.png "Sample assignment rule")

### Configure selection criteria

When you configure more than one assignment ruleset in the custom assignment method, you must define selection criteria. The selection criteria lets you define a set of conditions to determine the ruleset to be run when the condition is met. After the ruleset is picked up by the work assignment engine, if no rule matches in the selection criteria or if no selection criteria is met, the default ruleset will be run by the system.

Follow these steps to configure the selection criteria for the assignment rulesets:

1. For the assignment method, in the **Assignment** section, select **Create rule**, and in the **Decision list** area, select **Create rule**.
2. In the **Create selection criteria rule** dialog box, enter a rule name, and define the conditions.
3. In **Execute ruleset**, select the assignment ruleset that must be run when the conditions are met, and then select **Create**. The rule is listed in the **Decision list** area.
4. Define as many rules as the number of assignment rulesets.

### See also

[Create workstreams](create-workstreams.md)  
[Create queues](queues-omnichannel.md)  
[Set up records for unified routing](set-up-record-routing.md)  
[Set up skill-based routing for unified routing](set-up-skill-based-routing.md)  
