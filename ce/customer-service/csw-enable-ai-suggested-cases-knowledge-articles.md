---
title: Enable AI suggestions for cases, knowledge articles | MicrosoftDocs
description: Enable AI suggestions for cases and knowledge articles in Dynamics 365 Customer Service.
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 08/01/2020
ms.topic: article
ms.service: 
  - dynamics-365-customerservice
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - D365CS
---

# Enable AI suggestions for similar cases and knowledge articles

[!include[cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

## Introduction

With the use of AI, suggestions about similar cases help agents find the right solutions quickly, increase agent productivity, and provide better and faster service to customers. The AI model has the capability to process up to one million most recent cases for listing them at run time.

<!-- Xiaoying's comment: we can leverage what's in the release note to cover more about the business value and problem to solve in the introduction section. For example: 
"Agents typically use several resources to efficiently resolve customer cases and provide consistent responses. These include knowledge articles, collaborating with other agents or experts, and reviewing active or successfully resolved similar cases. Without artificial intelligence, agents spend time searching for and scanning knowledge articles to determine if they are relevant to the active case they are working on. This delays customer service and resolution time. Using AI helps proactively surface the best knowledge articles and similar cases by parsing through thousands of published articles and resolved cases, taking case context and previous history into account. It helps to quickly increase agent productivity, and provide better and faster service to customers."
-->

> [!NOTE]
> The feature is available only in organizations that have the base language as English and supports only English content.

## How AI suggestions for similar cases and knowledge articles works

<!-- Xiaoying's comments: proposed content:
AI suggestions are powered by a set of pre-trained natural language understanding models that help agents to quickly find relevant knowledge articles or similar cases based on the active case context. The AI models enable the following capabilities:
- Knowledge articles and similar cases can be suggested based on the sementic meaning in case context and knowledge article content. The model pre-processes published knowledge articles and resolved cases every day to prepare suggestion candidates. After a case is created or updated, the model quickly finds out matching knowledge articles and similar cases from suggestion candidates. 
- A brief summary is auto-generated for each pre-processed knowledge article based on its content. When a knowledge article is suggested, both article title and the auto-generated summary are surfaced to agents, which helps them to get a better idea about the article before agent clicks through it. 
- In addition to the suggestions, agents can also tell why an article or similar case is suggested through a list of key phrases that are auto-extracted from knowledge articles and cases. These key phrases highlights the relevance between a suggestion and an active case, in addition to the confidence score (which is a percentage number that indicates the degree to which an article or similar case matches with the active case).  
-->

## Prerequisites

- *We shouldn't list Customer Service Workspace as a prerequisite to the tasks that need to be performed in this section because these tasks are not dependent on the availability of CSW.*
<!-- Xiaoying's comment: it is a prerequisite that we should list here. otherwise, the entry to the settings page will be disabled and admins can't configure it. With listing Customer Service Workspace as a prereqiste here, it's also good to provide a link to the relevant doc how admins can install the app. -->

- *Any roles that are required?*
<!-- Xiaoying's comment: it requires the admin role-->
<!-- Xiaoying's comment: in addition, the feature is only available to organizations with base language as English. Maybe add a note here or seperately that the feature only supports English content in this release. -->
<!-- Xiaoying's comment: also add a note about the geo availability, i.e. the feature is available to the organizations created in the following geolocations: NAM, SAM, CAN, GBR, EUR, JPN, IND, OCE, APJ -->

## Enable AI suggestions for similar cases

Perform the following steps to enable the AI suggestions for similar cases:

1. Sign in to the Customer Service Hub app.
2. In the **Change area**, select **Service Management** > **Settings (Preview)**. The **Analytics and insights settings** page appears.
3. Select **Manage** under **Suggestions**. The **Suggestions (preview)** page appears.
4. In the **Settings** > **Summary** area, set the toggle to **Yes** for **Enable similar case suggestions**.
5. In the **Data mapping** > **Case entity data fields** area, select values for the **Case summary** and **Case details** boxes respectively. The AI model uses the data corresponding to the selected boxes to understand the case context to provide similar case suggestions. By default, **Case Title** and **Description** are selected.
6. Select **Save**.
<!-- Xiaoying's comment: please add a note that it may take up to 24 hours for the model to process data and complete the first time setup. Once completed, the status will show in "Model pre-processing status". -->
<!-- Xiaoying's comment: please add another note that enabling or disabling this feature will take effect to agents only after they refresh/reopen the browser and not in their current active sessions nor on session switch. -->

    ![Enable AI-suggested similar cases](media/csw-enable-ai-suggested-cases.png "Enable AI-suggested similar cases")

## Enable AI suggestions for knowledge articles

Perform the following steps to enable the AI suggestions for related knowledge articles:

1. Sign in to the Customer Service Hub app.
2. In the **Change area**, select **Service Management** > **Settings (Preview)**. The **Analytics and insights settings** page appears.
3. Select **Manage** under **Suggestions**. The **Suggestions (preview)** page appears.
4. In the **Settings** > **Summary** area, set the toggle to **Yes** for **Enable knowledge article suggestions**.
5. In the **Data mapping** > **Knowledge article data fields** area, make sure that **Title** and **Content** are selected in **Article title** and **Article content** boxes respectively.
<!-- Xiaoying's comment: similar to the previous section, step 5 is optional. By default, Title and Content fields from Knowldge Article entity are selected. Admins can change these two fields to any other text fields in the Knowldge Article entity. In addition, when KB suggestion is enabled, admins are also asked to map text fields from Case entity (by default is Case Title and Description). The selected fields in Case entity will be used for the model to understand the context of an active case when finding KB suggestions. The selected fields in Knowledge Article entity are used for the AI model to understand the articles when finding a good match for a case. The article content field is also used for the AI model to generate a brief article summary, which will be surfaced to agents with suggestions. -->
6. Select **Save**.
<!-- Xiaoying's comment: please add a note that it may take up to 24 hours for the model to process data and complete the first time setup. Once completed, the status will show in "Model pre-processing status". -->
<!-- Xiaoying's comment: please add another note that enabling or disabling this feature will take effect to agents only after they refresh/reopen the browser and not in their current active sessions nor on session switch. -->

    ![Enable AI-suggested knowledge articles](media/csw-enable-ai-suggested-km.png "Enable AI-suggested knowledge articles")

## Model pre-processing status

The **Model pre-processing status** area displays the following metadata pertaining to the AI processing. The run frequency is set out of the box. Every 24 hours, the model pre-processes newly published or updated knowledge articles and resolved or updated cases to prepare the candidates data for suggestions.

- **Last successful run:** Displays the date and time the model was last run.
- **Case records:** Displays the number of new or updated resolved case records that were processed.
- **Knowledge articles:** Displays the number of new or updated published knowledge articles that were processed.
- **Run frequency:** Display the frequency that is set for the model to run.

### See also

[Create a new similarity rule to view similar cases](suggest-similar-cases-for-a-case.md#create-a-new-similarity-rule-to-view-similar-cases)  
