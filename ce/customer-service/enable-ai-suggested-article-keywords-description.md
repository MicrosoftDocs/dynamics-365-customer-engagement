---
title: Configure AI suggestions for article keywords and description | MicrosoftDocs
description: Configure AI suggestions for article keywords and description in Dynamics 365 Customer Service.
ms.date: 09/13/2021
ms.topic: article
author: sdas
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

# Configure AI suggestions for article keywords and description

## Introduction

With the use of AI-suggested article keywords and description when authoring or updating knowledge articles, you can help knowledge authors ensure better searchability and surfacing of the right articles. This makes them more productive and supports them in following authoring best practices by adding high quality and diverse keywords and descriptions.

The key highlights of the feature are as follows:

- Enable knowledge authors to get suggested keywords and description based on the article content stored in the built-in Knowledge Article entity.
- Select the source data fields (text fields only) for AI model that should suggest keywords and description, for example, **Title** and **Content**.
- Select the target data fields (text fields only) for authors to add/append selected suggested keywords and description, for example, **Keywords** and **Description**.

> [!NOTE]
> The AI suggestions feature is currently available in few geographical locations. More information, see: [Regional availability and Service limits for Customer Service](cs-region-availability-service-limits.md).


## How AI suggestions for article keywords and description work

The AI suggestions are displayed in the **View suggested keywords and description** field.

 The AI models work as follows:

- Knowledge article keywords and descriptions are suggested based on the knowledge article content.
- When an article is being created or updated, the model identifies keywords and its related keywords from the knowledge article content.
- A brief summary is auto-generated for each knowledge article, based on the article content.


## Language support for article keywords and description

Language support for an article is now provided in the following languages:

- Dutch
- English
- French
- German
- Italian
- Japanese
- Spanish

The language used in AI-generated suggestions relies on the article language that knowledge authors select in the article record. A knowledge author can specify the language for an article from the Summary tab of the knowledge form.

## Prerequisites

Make sure that the following requirements are met:

- The System Administrator role is granted.
- The AIB Roles and the AIB SML Roles are granted for the knowledge authors.
- The workflow processes used by the AI model and AI configuration entities are in the activated status. More information: [Workflow processes](#workflow-processes).
- If administration mode is enabled, make sure that background operations are also enabled. More information: [Administration Mode](/power-platform/admin/admin-mode).



## Enable AI suggestions for article keywords and description

Perform the following steps to enable the AI suggestions for article keywords and description:

1. Sign in to  Customer Service Hub. In the **Change area**, select **Service Management**, and then under **Insights**, select **Settings**.

or

Sign in to Omnichannel admin center. Select **Insights** and then select **Settings**.

2. In the **Suggestions for knowledge article authors** area, click **Manage**.
3. In the **Suggestions for knowledge article authors** > **Settings** > **Summary** area, turn on the **Enable keywords and description suggestions** toggle.
4. In the **Data mapping** > **Knowledge article data fields** area, select values for the **Article title** and **Article content** boxes respectively, if you don't want to use **Title** and **Content** that are set by default. The AI model uses the data corresponding to the selected values to provide suggestions for a summary as well. 

   > [!NOTE]
   > We recommend that you use text fields with plain text because suggestions might not be generated for text fields that are enabled for rich text format.

5. Select **Save**.

   > ![Enable AI-suggested similar cases.](media/csw-enable-ai-suggested-cases.png "Enable AI-suggested similar cases")


### See also

[View AI-suggested similar cases and knowledge articles for active cases](csw-view-ai-suggested-cases-knowledge-articles.md)  
[View smart assist suggestions for knowledge articles and similar cases using AI for ongoing conversations](./oc-view-ai-suggested-cases-articles.md)  
[FAQs on AI-suggested cases and knowledge articles](csw-faqs-ai-suggestions.md)  
[Create a new similarity rule to view similar cases](suggest-similar-cases-for-a-case.md#create-a-new-similarity-rule-to-view-similar-cases)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
