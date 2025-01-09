---
title: Configure work classification rulesets
description: Learn how to configure work classification rulesets for unified routing.
ms.date: 11/25/2024
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.custom: bap-template
searchScope:
- D365-App-customerservicehub
- D365-Entity-queueitem
- D365-UI-*
- Customer Engagement
- Dynamics 365
- Customer Service
---
# Configure work classification rulesets for unified routing

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

In unified routing, work classification lets you define rules to add detailed information to incoming work items that can be used to route and assign the work items optimally.

Typically, rules are written in the format of "if defined condition satisfies, then set the output attributes to certain values," but can also be surfaced through machine learning models. They're optional and can be used to add additional information to the incoming work items that are then used for more precise routing and assignment.

Work classification rules can be written by using the logical declarative decision list or by using machine learning models.

> [!IMPORTANT]
> You can create 10 rulesets per workstream, and for each ruleset, you can create up to 100 rule items.

## Prerequisite

You need the CSR Manager or Omnichannel administrator role to configure the work classification rules for a workstream.

## How classification rulesets work

A classification ruleset is an ordered list of multiple work classification rulesets and route-to-queue ruleset. During evaluation, the work classification rulesets are run first, followed by route-to-queue ruleset.

The work classification rulesets are run in the order they're listed. Within a ruleset, rule items are run in the order they're listed. When one of the rule item conditions matches, the output section of the rule item is run. The system evaluates the rules in the next ruleset if it's configured.

After all the work classification rulesets are run, the system evaluates the route-to-queue ruleset. All the rule items in the route-to-queues are run in the order they're listed. This is unlike the classification rules, where control passes to the next ruleset when one of the rule items in a ruleset condition matches.

In work classification rulesets, the values set in one of the rule items of a ruleset can be used in the next rulesets' rule items. For example: If in output section of one of the rule items of ruleset 1, priority is set to High; then any next ruleset rule item can use the priority variable and corresponding value "High" to set value for another attribute, such as, "If Priority equals High, set severity to critical".

For a rule item, you can set the output values for up to five attributes.

## Create work classification rulesets

Logical classification rules are run to update work item attributes. They're written in the format of "if defined condition satisfies, then set the output attributes to certain values." You can create conditions to define rules based on multiple entity attributes. Routing rules are written as rulesets that consist of rule items.

To create a logical work classification ruleset, do the following steps:

1. In the Customer Service admin center app, select a workstream, and in the **Routing rules** area, for the **Work classification (optional)** option, select **Create Ruleset**.

2. On the **Work classification** page, select **Create new**, and in the **Create work classification ruleset** dialog, select **Logical rules** in **Rule type**, and enter a name and description. By default, the root record is selected and displayed at the top of the condition builder for ease of reference and visibility of the record for which you're creating the rule.

3. In the **Decision list** area, select **Create Rule**, and on the **Create work classification rule** dialog, enter a name.

4. In the **Conditions** area, define the conditions according to your business needs. If you're creating classification rules for records, then the top-level condition is automatically populated. You can define conditions for up to two levels of the related records and attributes. 

5. In the **Output** area, select the attribute for which value needs to be set if the conditions are met.

   :::image type="content" source="../media/create-work-classification-rule.png" alt-text="Create work classification rule with conditions.":::

6. Repeat steps 3 through 5 to create the demand rules.

   ![Decision list for logical ruleset.](../media/ur-decision-list-manual.png "Decision list for logical ruleset")

## Create logical skill classification rulesets

Skill attachment rules are a subtype of logical work classification rules and are defined to attach skills to the work item. They're written in the format of "if defined condition satisfies, then attach defined skills to the work item."

Follow these steps to create a logical skill classification ruleset:

1. For the selected workstream, in the **Routing rules** area, for the **Work classification (optional)** option, select **Create Ruleset**.

2. On the **Work classification** page, select **Create new**.

3. In the **Create work classification ruleset** dialog, select **Logical rule** in **Rule type**, and enter a name and description.

4. Select **Create Rule**, and on the **Create work classification rule** dialog, enter a name.

5. In the **Conditions** area, define the conditions as per your business needs:

   1. Select **Add row**, and select **Skills** from the list box.
   2. Select the required operator, and then select the skills for the condition.
   3. Repeat the steps to define any other conditions.

6. In the **Output** area, select the attribute whose value is set if the conditions are met.

7. If you want to set up the skill attribute, in the **Conditions** area, define the conditions, and select the required value in the **Output** area for the skill that needs to be set.

   > [!Note]
   > - Ensure that the rating model that you choose for a skill in the work classification rule is same as the rating model that's defined for the skill attached to the agent. Also, ensure that you don't attach the same skill with two different rating models. For one skill, if you use different rating models in the conversation and for the agent, or in the same conversation, assignment won't work as expected.
   > - When you reroute a work item, new skills are appended to the existing ones if any.

## Create classification rulesets based on capacity profiles

Create work classification rulesets that are based on capacity profiles to route work items to agents based on capacity.

1. Perform the steps 1 through 5 in [Create logical skill classification rulesets](#create-logical-skill-classification-rulesets).
2. In the **Output** area, select **Capacity profile**, and choose a capacity profile whose value should be set if the conditions are met.
   :::image type="content" source="../media/capacity-profile-based-rule.png" alt-text="Capacity profile-based work classification rule.":::

## Create machine learning-based skill classification rulesets

Machine learning model-based rules are a subtype of work classification rules, and are rules defined to attach skills to the work item using the AI Builder text classification machine learning model created as part of the intelligent skill finder bootstrapping experience. They're written in the format of "send work item selected attributes to the published model and attach the returned tags from the model as skills on the work item."

To configure a skill classification ruleset by using the machine learning option, you must have configured the intelligent skill finder models. More information: [Set up intelligent skill finder model](set-up-isf-model.md#set-up-intelligent-skill-finder-model)

Do the following to configure a machine learning-based ruleset:

1. In Customer Service admin center, select a workstream, and in the **Routing rules** area, for the **Work classification (optional)** option, select **Create Ruleset** or **See more**.

2. On the **Work classification** page, select **Create new**.

3. In the **Create work classification ruleset** dialog, select **Rule Type** as **Machine learning model**, and enter a name and description.

4. Select a model in the **Select skill identification model** list, and select **Create**.

5. On the page that appears, in the **Input attributes** area, select **Add attribute**, and select the attributes from the **Attributes** or **Related Entities** category. For an incoming work item, these attribute values are concatenated to the machine learning model for skill prediction.

    > [!NOTE]
    > Skill is the default selection for output attributes and can't be edited or deleted.

    ![Machine learning rule type.](../media/ur-ml-rule-type.png "Machine learning rule type")

## Create rulesets based on sentiment prediction model (preview)

> [!IMPORTANT]
> This section is pre-release documentation and is subject to change.

You can create rules that are based on the sentiment prediction model to classify work items. More information: [Use sentiment prediction](use-sentiment-prediction-for-routing.md).

## Create rulesets based on effort estimation model (preview)

> [!IMPORTANT]
> This section is pre-release documentation and is subject to change.

You can create rules that are based on the effort estimation model to classify work items. More information: [Use effort estimation](use-effort-estimation-for-routing.md).

## Options available for rulesets

After you create the rules, you can change the order in which the rules should be evaluated, search for rules, and view the condition that's been used for each rule by hovering the mouse over the condition. You can also create copies of the rules and update only the necessary information to avoid writing the conditions from scratch. You can hover the mouse over a condition to view it without having to navigate to each condition.

:::image type="content" source="../media/work-classification-rules-list.png" alt-text=" Work classification rules list":::

### Related information

[Create a workstream for unified routing](create-workstreams.md)  
[Set up record routing](set-up-record-routing.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
