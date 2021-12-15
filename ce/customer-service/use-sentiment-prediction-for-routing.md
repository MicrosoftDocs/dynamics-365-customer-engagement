---
title: "Use sentiment prediction in unified routing | MicrosoftDocs"
description: "Learn how to enable and use sentiment prediction in unified routing in Customer Service."
ms.date: 12/15/2021
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
---

# Use sentiment prediction-based model in work classification (preview)

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

> [!IMPORTANT]
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]


## Introduction

Sentiment prediction for routing enables organizations to use the end customer sentiment scores as a factor in classifying work items to route to agents.

By using sentiment prediction for routing, you can write rules to classify work items and assign them to agents who are best equipped to handle them.

The sentiment prediction uses the following seven-point scale that allows organizations flexibility to build nuanced rules while maintaining simplicity.

- Very positive
- Positive
- Slightly positive
- Neutral
- Slightly negative
- Negative
- Very negative

The sentiment model is configured to look for and use the messages provided by the customer and doesn't consider agent chat strings.

## Enable sentiment prediction

You can enable sentiment prediction in Customer Service Hub or Omnichannel admin center.

**To enable sentiment prediction**

1. In Customer Service Hub, go to the **Service Management** site map, and select **User attributes** under **Unified Routing**. If you are using Omnichannel admin center, in the site map, select **User attributes** under **Advanced settings**.
2. For **Sentiment prediction for routing (preview)**, select **Manage**.
3. On the **Sentiment Prediction for routing (preview)** page, set the **Enable sentiment prediction for routing** toggle to **Yes**.

### Dry run of sentiment prediction

You can optionally test the sentiment model by using the dry run option. You can test using real phrases that you expect to see when customers contact support. It helps you understand what the sentiment prediction on those might look like. You can see key information, such as the sentiment category on the seven-point scale, the sentiment score that is scaled from zero to 100, and keywords from the phrase that influenced the sentiment score.

**To test the sentiment model**

1. On the **Sentiment Prediction for routing (preview)** page, select **Dry run**.

2. On the **Dry run** panel, enter a word or phrase, such as "I am frustrated", and select **Test**. The model predicts the sentiment score, category, and the keyword that helped determine the score.


## Create classification rules based on sentiment prediction model

After you enable sentiment prediction, you can create a classification rule based on the machine learning model, and select the type as **Sentiment prediction**. You can use the rule with other rules to help categorize the work items to be routed to the right agents who will help with the customer issue.

**To create a rule based on sentiment prediction**

1. Create or edit a workstream. More information: [Create workstreams](create-workstreams.md)

2. Go to the **Work classification (optional)** section to create a classification rule. More information: [Configure work classification rulesets](configure-work-classification.md)

3. In the **Create work classification ruleset** dialog, select the rule type as **Machine learning model**, and then select type as **Sentiment prediction**.

    :::image type="content" source="media/sentiment-prediction-based-ruleset.png" alt-text="Sentiment prediction as machine learning model.":::

4. Select the input attribute in which the customer sentiment is most likely to be found. For example, for a case workstream, you can select the related entity **Routed record (Case)**, and the attribute as **Description** that might typically contain keywords indicating the sentiment.

    i:::image type="content" source="media/input-attributes-sentiment.png" alt-text="Input attributes for sentiment model.":::

    For a messaging channel, you'll typically set the related entity as **Context item value (Conversation)**, and then select the attribute. The bot context variables should be set or pre-conversation survey must be set up to be able to use the input attribute. Frame the pre-conversation survey questions such that they elicit the customer sentiment. For example, you could use a question such as "How has been your experience with the product?" or "How can we help you?".

    You can define up to 10 attributes, whose values can be used to build the prediction model. At least one attribute, the first one, is mandatory and can't be deleted.

5. Save and close.

While the application doesn't prevent you from creating more than one rule that's based on the sentiment prediction model, a warning message is displayed when you try to create another rule based on the same model.

Additional work classification rules can then be created using the output from the sentiment prediction rule. The output is stored in the **Sentiment Category** attribute. You can use any of the values on the seven-point sentiment output to build the rule.

## Create route-to-queue rules

Create route-to-queue rules to route the work items based on the sentiment prediction.

**To create route-to-queue rules**

1. For the workstream in which you created the rule based on sentiment prediction, in **Routing rules**, select **Create ruleset** or **See more** for **Route to queues** to create a rule. More information: [Configure route-to-queues rulesets and rules](configure-work-classification.md#configure-route-to-queues-rulesets-and-rules)

2. Create a rule to define conditions. The **Sentiment Category** output attribute contains the sentiment prediction for the work item, and should be used in the rule builder to define the rule.
   
   > [NOTE]
   > For a record, make sure that you use the **Add row** option independent of the **Routed record** group, if you've defined a condition on the routed record.
   > :::image type="content" source="media/choose-add-row-sentiment-category.png" alt-text="Choose add row option for sentiment category.":::

3. Select the queue to which the work items need to be assigned when the conditions are met.

    :::image type="content" source="media/route-to-queue-sentiment.png" alt-text="Rules to categorize on sentiment and route to queue.":::

## Use diagnostics to analyze the efficacy of sentiment prediction

Routing diagnostics help you see how the work items have been classified and routed after you've configured the rules.

You can view how the sentiment prediction model was used to route a work item.

:::image type="content" source="media/diagnostics-sentiment-prediction.png" alt-text="Diagnostics for sentiment prediction model.":::

### Language support for sentiment prediction models

All Azure Cognitive Services supported languages are supported in sentiment prediction-based routing. More information: [Language support - Translator - Azure Cognitive Services](/azure/cognitive-services/translator/language-support)

### See also

[Overview of unified routing](overview-unified-routing.md)  
[How to set up unified routing](set-up-routing-process.md)  



