---
title: Enable AI suggestions for article keywords and description | MicrosoftDocs
description: Enable AI suggestions for article keywords and description in Dynamics 365 Customer Service.
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

# Enable AI suggestions for article keywords and description

## Introduction

With the use of AI-suggested article keywords and description when authoring or updating knowledge articles, knowledge authors can ensure better searchability and surfacing of the right articles. This makes them more productive and supports them in following authoring best practices can add high quality and diverse keywords and description. 

The key highlights of the feature are as follows:

- Knowledge authors get suggested keywords and description based on the article content stored in the built-in Knowledge Article entity.
- The suggested keywords and description are only generated and displayed for an active article in it's latest version, including articles which are in Draft, Approved, Scheduled, and Published state. Articles in Expired, Archived and Discarded states don't get suggestions. 
- Knowledge authors see a list of non-duplicated suggested keywords that AI identifies from an article, which includes:
- - keywords and phrases that are extracted directly from the article. 
- - Category/entity level object that the extracted/existing keywords belong to

> [!NOTE]
> The AI suggestions feature is currently available in few geographical locations. More information, see: [Regional availability and Service limits for Customer Service](cs-region-availability-service-limits.md).


## How AI suggestions for article keywords and description works

The AI suggestions are displayed in the **View suggested keywords and description** field.

 The AI models work as follows:

- Knowledge article keywords and descriptions are suggested based on the knowledge article content.
-- When an article is being created or updated, the model identifies keywords and its related keywords from the knowledge article content.
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

A knowledge author can specify the language for an article from the Summary tab of the knowledge form.

## Prerequisites

Make sure that the following requirements are met:

- Customer Service workspace is installed and accessible. More information: [Customer Service workspace](csw-overview.md)
- The System Administrator role is granted.
- The AIB Roles and the AIB SML Roles are granted for the knowledge authors.
- The workflow processes used by the AI model and AI configuration entities are in the activated status. More information: [Workflow processes](#workflow-processes).
- If administration mode is enabled, make sure that background operations are also enabled. More information: [Administration Mode](/power-platform/admin/admin-mode).



## Enable AI suggestions for similar cases

Perform the following steps to enable the AI suggestions for similar cases:

1. Sign in to  Customer Service Hub. In the **Change area**, select **Service Management**, and then under **Analytics and Insights**, select **Settings**.

or

Sign in to Omnichannel admin center. Select **Insights** and then select **Settings**.

2. Select **Manage** > **Suggestions**. The **Suggestions** page appears.
3. In the **Settings** > **Summary** area, turn on the **Enable similar case suggestions** toggle.
4. In the **Data mapping** > **Case entity data fields** area, select values for the **Case summary** and **Case details** boxes respectively if you don't want to use **Case Title** and **Description** that are set by default. The AI model uses the data corresponding to the selected boxes to understand the case context to provide similar case suggestions. By default, Case Title and Description fields are selected.

   > [!NOTE]
   > We recommend that you use text fields with plain text because suggestions might not be generated for text fields that are enabled for rich text format.

5. Select **Save**.

   > ![Enable AI-suggested similar cases.](media/csw-enable-ai-suggested-cases.png "Enable AI-suggested similar cases")

## Enable AI suggestions for knowledge articles

Perform the following steps to enable the AI suggestions for related knowledge articles:

1. Sign in to Customer Service Hub.  In the **Change area**, select **Service Management**, and then under **Analytics and Insights**, select **Settings**.

 or

 Sign in to Omnichannel admin center. Select **Insights** and then select **Settings**.

2. Select **Manage** and then **Suggestions**. The **Suggestions** page appears.
3. In the **Settings** > **Summary** area, turn on the **Enable knowledge article suggestions** toggle.
4. In the **Data mapping** > **Knowledge article data fields** area, make sure that **Title** and **Content** are selected in the **Article title** and **Article content** boxes, respectively. The selected options are used by the AI model to understand and find a good match for a case or conversation. Article content is used by the AI model to generate a brief article summary that's displayed to the agent at runtime.

5. Select **Save**.


### Workflow processes

The AI model and AI configuration entities use the following workflow processes. Make sure these processes are in the activated status. By default, these processes are activated:

- IsPaiEnabled
- Predict
- PredictionSchema
- Train
- QuickTest
- BatchPrediction
- ScheduleTraining
- SchedulePrediction
- ScheduleRetrain
- UnschedulePrediction
- UnscheduleTraining
- CancelTraining
- PublishAIConfiguration
- UnpublishAIConfiguration

## Service protection limits for AI suggestions

AI suggestions for Case and Knowledge became available as of October 2020. We're introducing service protection limits on these capabilities to maintain a consistent quality of service for all our customers, but there's no penalty if customers exceed predefined limits. Over time, Microsoft might adjust these limits in keeping with customer usage patterns and provide options for customers with high usage scenarios and patterns to purchase additional capacity in a manner minimally disruptive to those customers.

The service protection limits for AI suggestions are defined in the following table. The total limits are pooled at the tenant level based on the number of Customer Service Enterprise user licenses that are available in the tenant.

| Area    | Limits     | Notes     |
|----------|------------|-----------|
| AI suggestions for active cases | 30 cases/month per user license | Each user license adds 30 active cases, where agents can get AI-suggested knowledge articles and similar cases in real time. |
| AI suggestions for conversations | 150 conversations/month per user license | Each user license adds 150 omnichannel conversations where agents can get AI suggested knowledge articles and similar cases in real time.|
||||

### See also

[View AI-suggested similar cases and knowledge articles for active cases](csw-view-ai-suggested-cases-knowledge-articles.md)  
[View smart assist suggestions for knowledge articles and similar cases using AI for ongoing conversations](./oc-view-ai-suggested-cases-articles.md)  
[FAQs on AI-suggested cases and knowledge articles](csw-faqs-ai-suggestions.md)  
[Create a new similarity rule to view similar cases](suggest-similar-cases-for-a-case.md#create-a-new-similarity-rule-to-view-similar-cases)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
