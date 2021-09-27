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
<!--note from editor: Our team has settled on the convention of "Feature name (preview)" for the titles of topics about preview features. If this were a preview product (rather than feature) name, it would be "Product Name (Preview)". -->
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

By configuring the use of AI-suggested article keywords and descriptions when knowledge articles are authored or updated, you can help<!--note from editor: Edits assume that "you" in this article is the admin who enables the feature, not necessarily the person writing an article.--> knowledge authors ensure better searchability and surfacing of the right articles. This makes them more productive and supports them in following authoring best practices by adding high-quality and diverse keywords and descriptions.

The key highlights of the feature are as follows:

- Enable knowledge authors to get suggested keywords and description based on the article content stored in the built-in knowledge article entity.
- Enable admins to select the source data (text only) fields for the AI model to use to suggest keywords and descriptions&mdash;the default fields are **Title** and **Content**.<!--note from editor: Edits suggested.-->

> [!NOTE]
> The AI suggestions feature is currently available only in specific<!--note from editor: Suggested. If you don't like it, it should be "available only in a few geographical locations."--> geographical locations. More information: [Regional availability and service limits for Customer Service](cs-region-availability-service-limits.md)


## How AI suggestions for article keywords and descriptions work

When the feature is turned on, the **View suggested keywords and description** link appears in the default knowledge article form for knowledge authors. On selecting the link, authors see a dialog that shows suggested keywords and a suggested description.

The AI model works as follows:

- The text values from selected source data fields in **Settings** are sent to the AI model to generate suggestions. By default, the source data fields are **Title** and **Content**.
- The model takes the first 2,200 characters to generate suggestions. To get good suggestions, we recommend that authors describe the problem to be solved within the first 2,200 characters in their articles.<!--note from editor: Suggested, to make it clear who "you" is in this article. Also, note that Microsoft Writing Style Guide doesn't like "it's recommended."-->
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

The language used in AI-generated suggestions is based on<!--note from editor: Suggested.--> the language that the knowledge author selected in the article record. A knowledge author can specify the language for an article on the **Summary** tab of the knowledge article form.

## Prerequisites

Make sure that the following requirements are met:

- You have the System Administrator role.
- Knowledge authors have the AIB roles and the AIB SML roles.<!--note from editor: Please specify what these are. I'm guessing "AIB" is "AI Builder"? but I can't even guess what "AIB SML" might be. -->

Note that in public preview, the AI-suggested keywords and description are available only in the default knowledge article form.<!--note from editor: Edits okay? I wasn't sure what this was saying. It didn't seem like a requirement to be met so much as a description of where this feature is available.-->

## Enable AI suggestions for article keywords and description
<!--note from editor: Because the only thing in this section is one procedure (with no introductory text), you don't need an additional procedure heading. -->
1. Sign in to Customer Service Hub. In the **change area**, select **Service Management**, and then on the left pane under **Insights**, select **Settings**.

2. In the **Suggestions for knowledge article authors** area, select **Manage**.

3. On the **Settings** tab in the **Summary** area, turn on the **Enable keywords and description suggestions** toggle.<!--note from editor: The angle bracket is meant to indicate a sequence of user actions, not the location of a control. If you've pointed the user to the area of the UI (as you did in the previous step), you can assume they're there already. My edit assumes that **Settings** is a tab? which it looks like from the screenshot.-->

4. Optional: If you don't want the model to use the default **Title** and **Content** values, in the **Data mapping** area under **Knowledge article data fields**, select values for **Article title** and **Article content**. The AI model will use the data that corresponds to the values you select.<!--note from editor: Edits suggested.-->

5. Select **Save**.

<!--note from editor: When an image summarizes, and applies to, the entire procedure, you don't have to indent it under the last step.-->
![Configure AI-suggested article keywords and description.](media/configure_suggest-article-keywords-description.png "Enable AI-suggested article keywords and description")


### See also

[Create and manage knowledge articles](customer-service-hub-user-guide-knowledge-article.md)  
[Work with knowledge articles](work-knowledge-articles.md)  
[View AI-suggested similar cases and knowledge articles for active cases](csw-view-ai-suggested-cases-knowledge-articles.md)  
[View smart assist suggestions for knowledge articles and similar cases using AI for ongoing conversations](./oc-view-ai-suggested-cases-articles.md)  
[FAQs on AI-suggested cases and knowledge articles](csw-faqs-ai-suggestions.md)  
[Create a new similarity rule to view similar cases](suggest-similar-cases-for-a-case.md#create-a-new-similarity-rule-to-view-similar-cases)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
