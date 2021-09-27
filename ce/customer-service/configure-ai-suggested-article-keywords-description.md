---
title: Configure AI suggestions for article keywords and description | MicrosoftDocs
description: Configure AI suggestions for article keywords and description in Dynamics 365 Customer Service.
ms.date: 09/13/2021
ms.topic: article
author: Soumyasd27
ms.author: sdas
manager: shujoshi
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - D365CS
ms.custom: 
  - dyn365-customerservice
  - intro-internal
feedback_product_url: https //experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
---

# Configure AI suggestions for article keywords and description (preview)


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

By configuring the use of AI-suggested article keywords and descriptions when knowledge articles are authored or updated, you can help knowledge authors ensure better searchability and surfacing of the right articles. This makes them more productive and supports them in following authoring best practices by adding high-quality and diverse keywords and descriptions.

The key highlights of the feature are as follows:

- Enable knowledge authors to get suggested keywords and description based on the article content stored in the built-in knowledge article entity.
- Enable admins to select the source data (text only) fields for the AI model to use to suggest keywords and descriptions; the default fields are **Title** and **Content**.

> [!NOTE]
> The AI suggestions feature is currently available only in specific geographical locations. More information: [Regional availability and service limits for Customer Service](cs-region-availability-service-limits.md)


## How AI suggestions for article keywords and descriptions work

When the feature is turned on, the **View suggested keywords and description** link appears in the default knowledge article form for knowledge authors when the article content field is updated and the knowledge article is saved. On selecting the link, authors see a dialog that shows suggested keywords and a suggested description.


The AI model works as follows:

- The text values from selected source data fields in **Settings** are sent to the AI model to generate suggestions. By default, the source data fields are **Title** and **Content**.
- The model takes the first 2,200 characters to generate suggestions. To get good suggestions, we recommend that authors describe the problem to be solved within the first 2,200 characters in their articles.
- Knowledge article keywords and a description are then suggested based on the knowledge article title and content, and are displayed in the **View suggested keywords and description** dialog.

## Language support for article keywords and description suggestions

AI suggestions for article keywords and description are supported in the following languages:

- Dutch
- English
- French
- German
- Italian
- Japanese
- Spanish

The language used in AI-generated suggestions is based on the language that the knowledge author has selected in the article record. A knowledge author can specify the language for an article on the **Summary** tab of the knowledge article form.

## Prerequisites

Make sure that the following requirements are met:

- You have the System Administrator role.
- Knowledge authors have the AIB roles and the AIB SML roles.

Note that in public preview, the AI-suggested keywords and description are available only in the default knowledge article form.

## Enable AI suggestions for article keywords and description

1. Sign in to Customer Service Hub. In the **change area**, select **Service Management**, and then on the left pane under **Insights**, select **Settings**.

2. In the **Suggestions for knowledge article authors** area, select **Manage**.

3. On the **Settings** tab in the **Summary** area, turn on the **Enable keywords and description suggestions** toggle.

4. Optional: If you don't want the model to use the default **Title** and **Content** values, in the **Data mapping** area under **Knowledge article data fields**, select values for **Article title** and **Article content**. The AI model will use the data that corresponds to the values you select.

5. Select **Save**.

![Configure AI-suggested article keywords and description.](media/configure_suggest-article-keywords-description.png "Enable AI-suggested article keywords and description")


### See also

[Create and manage knowledge articles](customer-service-hub-user-guide-knowledge-article.md)  
[Work with knowledge articles](work-knowledge-articles.md)  
[View AI-suggested similar cases and knowledge articles for active cases](csw-view-ai-suggested-cases-knowledge-articles.md)  
[View smart assist suggestions for knowledge articles and similar cases using AI for ongoing conversations](./oc-view-ai-suggested-cases-articles.md)  
[FAQs on AI-suggested cases and knowledge articles](csw-faqs-ai-suggestions.md)  
[Create a new similarity rule to view similar cases](suggest-similar-cases-for-a-case.md#create-a-new-similarity-rule-to-view-similar-cases)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
