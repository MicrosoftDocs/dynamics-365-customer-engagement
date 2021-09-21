---
title: "Use sentiment prediction in unified routing | MicrosoftDocs"
description: "Learn how to enable and use sentiment prediction in unified routing in Customer Service."
ms.date: 10/04/2021
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
---

# Preview: Use sentiment prediction-based model in work classification

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

> [!IMPORTANT]
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]
>
> [!INCLUDE[cc-preview-features-send-us-feedback](../includes/cc-preview-features-send-us-feedback.md)]

## Introduction

Use the customer sentiment scores to predict customer sentiment and use the models in classifying work items to route to agents.

By using the sentiment model, you can write rules to classify work items and assign them to agents who are best equipped to handle them.

The sentiment is scored between 1 and 100 percent. A score lesser than 50 indicates negative sentiment. Scores greater than 50 are considered positive.

The model is configured to look for and use the keywords typed by the customer and doesn't consider agent chat strings.

## Enable sentiment prediction

You can enable sentiment prediction in Customer Service Hub or Omnichannel admin center.

**To enable sentiment prediction**

1. In Customer Service Hub, go to the **Service Management** site map, and select **User attributes** under **Unified Routing**. If you are using Omnichannel admin center, in the site map, select **User attributes** under **Advanced settings**.
2. For **Sentiment prediction for routing (preview)**, select **Manage**.
3. On the **Sentiment Prediction for routing (preview)** page, set the **Enable sentiment prediction for routing** toggle to **Yes**.

### Trial run of sentiment prediction

You can optionally test the sentiment model by using the dry run option.

**To test the sentiment model**

1. On the **Sentiment Prediction for routing (preview)** page, select **Dry run**.

2. On the **Dry run** panel, enter a word or phrase, such as "I am frustrated", and select **Test**. The model predicts the sentiment score, category, and the keyword that helped determine the score.


## Create classification rules

After you enable sentiment prediction, create a classification rule based on machine learning model, and select type as **Sentiment prediction**. You can use the rule with other rules to help categorize the work items to be routed to the right agents who will help with the issues.

**To create a rule based on sentiment prediction**

1. Create or edit a workstream. More information: [Create workstreams](create-workstreams.md)

2. In **Routing rules**, for **Work classification (optional)** select **Create ruleset** or **See more** and then select **Create new**.

3. In the **Create work classification ruleset** dialog, select the rule type as **Machine learning model**, and then select type as **Sentiment prediction**.

    :::image type="content" source="media/sentiment-prediction-based-ruleset.png" alt-text="Sentiment prediction as machine learning model.":::

4. Select the input attribute that typically can be used to gauge the sentiment. For example, for a case workstream, you can select the related entity **Routed record (Case)**, and the attribute as **Case Title** that might typically contain keywords indicating the sentiment.

    i:::image type="content" source="media/input-attributes-sentiment.png" alt-text="Input attributes for sentiment model.":::

    For a messaging channel, you'll typically set the related entity as **Context item value (Conversation)**, and then select the attribute. The pre-conversation survey must be set up to be able to use the input attribute.

    You can define up to 10 attributes, whose values can be used to build the prediction model. At least one attribute, the first one, is mandatory and can't be deleted.

5. Save and close.

While the application doesn't prevent you from creating more than one rule that's based on the sentiment prediction model, a warning message is displayed when you try to create another rule based on the same model.

## Create route-to-queue rules

Create the route-to-queue rules to route the work items based on the sentiment prediction.

**To create route-to-queue rules**

1. For the workstream in which you created the rule based on sentiment prediction, in **Routing rules**, select **Create ruleset** or **See more** for **Route to queues** to create a rule. More information: [Configure route-to-queues rulesets and rules](configure-work-classification.md#configure-route-to-queues-rulesets-and-rules)

2. Create a rule to define conditions and select the queue to which the work items need to be assigned when the conditions are met.

    :::image type="content" source="media/route-to-queue-sentiment.png" alt-text="Rules to categorize on sentiment and route to queue.":::

## Use diagnostics to analyze the efficacy of sentiment prediction





