---
title: Configure AI suggestions for article keywords and description
description: Configure AI suggestions for article keywords and description in Dynamics 365 Customer Service.
ms.date: 11/28/2024
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: how-to
search.audienceType: 
  - admin
ms.custom: 
  - dyn365-customerservice
ms.collection: bap-ai-copilot
feedback_product_url: https //experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
---

# Configure AI suggestions for article keywords and description

Correct metadata helps locate articles that users search for. When authors create or update knowledge articles, AI suggestions for article keywords and descriptions help them select the right metadata, which improves their productivity.

The key highlights of the AI suggestions feature are:

- Enable authors by suggesting keywords and description based on the article content stored in the built-in knowledge article entity.
- Enable admins to select the source data (text only) fields that the AI model will use; the default fields are **Title** and **Content**.

> [!NOTE]
> The AI suggestions feature is currently available in specific geographical locations only. Learn more in [Regional availability and service limits for Customer Service](cs-region-availability-service-limits.md).

## Prerequisites

- You have the System Administrator role.
- Authors have **Read** access to the **Keywords Description Suggestion Setting** custom entity.

## How AI suggestions for article keywords and descriptions work

The **View suggested keywords and description** link appears in the default knowledge article form for authors when the article content field is updated and the knowledge article is saved. When authors select the link, a dialog with suggested keywords and a description appears.

If you have a custom form, you can add the **View suggested keywords and description** link only to the knowledge article entity. Learn more in [Enable AI suggestions for article keywords and description in a custom form](#enable-ai-suggestions-for-article-keywords-and-description-in-a-custom-form).

The AI model works as follows:

- The text values from selected source data fields in **Settings** are sent to the AI model to generate suggestions. By default, the source data fields are **Title** and **Content**.
- The model takes the first 2,200 characters to generate suggestions. To get good suggestions, we recommend that authors describe the problem within the first 2,200 characters in their article.
- Knowledge article keywords and a description are then suggested based on the knowledge article title and content, and appear in the **View suggested keywords and description** dialog.

## Enable AI suggestions for article keywords and description

You can enable AI suggestions for article keywords and description in the Customer Service admin center app.

1. In the site map, select **Insights** in **Operations**. The **Insights** page appears.
  
1. On the **Insights** page, in the **Suggestions for knowledge article authors** section, select **Manage**. The **Suggestions for knowledge article authors** page appears.

1. On the **Settings** tab in the **Summary** area, set the **Enable keywords and description suggestions** toggle to **Yes**. By default, the model is based on the **Title** and **Content** values specified in the **Data mapping** area in **Knowledge article data fields**.

1. Optionally, change the values for **Article title** and **Article content** if you don't want the model to use the default values. The AI model uses the data that corresponds to the values you select.

1. Select **Save**.

   :::image type="content" source="../media/configure_suggest-article-keywords-description.png" alt-text="Configure AI-suggested article keywords and description.":::

### Enable AI suggestions for article keywords and description in a custom form

1. In Dynamics 365, go to **Customizations** in **Advanced Settings**.

1. Select **Customize the System** to open the default solution.

1. From the **Solution: Default Solution** navigation pane select **Components** > **Entities** > **Knowledge Article** > **Forms**.

1. Select the form that you want to customize.

1. From **Field Explorer**, select **Keywords and Description Suggestion control** and add it to the form.

1. Select **Keywords and Description Suggestion control** in the form and then select **Change Properties** on the ribbon.

1. On the **Field Properties** dialog, go to the **Controls** tab, and select **Add Control**.

1. On the **Add Control** dialog, select **Knowledge Suggestion Section Control** > **Add**.

1. On the **Field Properties** dialog, **Controls** tab, select **Web**, **Phone**, and **Tablet** for **Knowledge Suggestion Section Control**.

1. Select **OK**.

1. Select **Save** and **Publish**.

## Language support

AI suggestions for article keywords and description are supported in the following languages:

- Dutch
- English
- French
- German
- Italian
- Japanese
- Spanish

The language used in AI-generated suggestions is based on the language that the author selects in the article record. An author can specify the language for an article on the **Summary** tab of the knowledge article form.

### Related information

[Create and manage knowledge articles](../use/customer-service-hub-user-guide-knowledge-article.md)  
[Work with knowledge articles](work-knowledge-articles.md)  
[View AI-suggested similar cases and knowledge articles for active cases](../use/csw-view-ai-suggested-cases-knowledge-articles.md)  
[View smart assist suggestions for knowledge articles and similar cases using AI for ongoing conversations](../use/oc-view-ai-suggested-cases-articles.md)  
[FAQs on AI suggestions for cases and knowledge articles](csw-faqs-ai-suggestions.md)  
[Create a new similarity rule to view similar cases](suggest-similar-cases-for-a-case.md#create-a-new-similarity-rule-to-view-similar-cases)  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
