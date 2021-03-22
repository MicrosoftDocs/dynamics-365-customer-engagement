---
title: "Create work classification rulesets | MicrosoftDocs"
description: "How to create work classification rulesets"
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 04/09/2021
ms.topic: article
ms.service: "dynamics-365-customerservice"
---
# Configure work classification rules

Work classification lets you define classification rules to add detailed information to incoming work items that can be used to route and assign the work items optimally.

Perform the tasks listed in this section to configure the work classification rules for the work stream that you created. You will perform these tasks in the Omnichannel admin center or Customer Service Hub app.

## Create manual work classification rulesets

You can create as many numbers of rulesets as your business workflow requires. For each ruleset, you will create rule items for a decision list that will be evaluated when a work item enters the queue.

To create a manual work classification ruleset, do the following steps:

1. Select a work stream, and in the **Routing rules** area, for the **Work classification (optional)** option, select **Create Ruleset**.
2. On the **Work classification** page, select **Create new**, and in the **Create work classification ruleset** dialog box, select  **Rule Type** as **Manual**, and enter a name and description.
3. In the **Decision list** area, select **Create Rule**, and on the **Create demand rule** dialog box, enter a name.
4. In the **Conditions** area, define the conditions according to your business needs.
5. In the **Output** area, select the attribute for which value needs to be set if the conditions are met.
   
   > ![Define rule conditions for demand rule](media/ur-demand-rule.png "Define rule conditions for demand rule")
6. Repeat steps 3 through 5 to create the demand rules.
    > ![Decision list for manual ruleset](media/ur-decision-list-manual.png "Decision list for manual ruleset")

## Create manual skill classification rulesets

Do the following steps to create manual skill classification ruleset:

1. Select a work stream, and in the **Routing rules** area, for the **Work classification (optional)** option, select **Create Ruleset**.
2. On the **Work classification** page, select **Create new**.
3. In the **Create work classification ruleset** dialog box, select  **Rule Type** as **Manual**, and enter a name and description.
4. Select **Create Rule**, and on the **Create demand rule** dialog box, enter a name.
5. In the **Conditions** area, define the conditions according to your business needs.
6. In the **Output** area, select the attribute whose value will be set if the conditions are met.
7. If you want to manually set up the skill attribute, then in the **Conditions** area, define the conditions, and select the required value in the **Output** area for the skill that needs to be set.

## Create machine learning-based skill classification ruleset

To configure skill classification ruleset by using the machine learning option, you must have configured the intelligent skill finder models. More information: [Set up intelligent skill finder model](intelligent-skill-model.md)

Do the following steps to configure machine learning-based ruleset:

1. For a work stream, in the **Routing rules** area, for the **Work classification (optional)** option, select **Create Ruleset** or **See more**.
2. On the **Work classification** page, select **Create new**.
3. In the **Create work classification ruleset** dialog box, select  **Rule Type** as **Machine learning model**, and enter a name and description.
4. Select a model in the **Select skill identification model** list, and select **Create**.
    >![Machine learning skill ruleset](media/ur-ml-skill-ruleset.png "Machine learning skill ruleset")

5. On the page that appears, in the **Input attributes** area, select **Add attribute**, and select the attributes from the **Attributes** or **Related Entities** category. For an incoming work item, these attribute values will be concatenated and sent to the machine learning model for skill prediction.

    > [!NOTE]
    > Skill is the default selection for output attributes and can't be edited or deleted.

    >![Machine learning rule type](media/ur-ml-rule-type.png "Machine learning rule type")

## Configure route to queues ruleset and rules

1. For a work stream, in the **Routing rules** section, select **Create ruleset** beside **Route to queues**, and then select **Create Rule** in **Decision list**.
2. In the **Create route to queue rule** dialog box, enter a name in **Rule Name**.
3. In **Conditions**, define the set of conditions.
4. In **Route to queues**, select the queue to which the work items will be routed if the conditions are met.
    >![Configure route to queue decision rules](media/ur-route-to-queue-decision.png "Configure route to queue decision rules")
