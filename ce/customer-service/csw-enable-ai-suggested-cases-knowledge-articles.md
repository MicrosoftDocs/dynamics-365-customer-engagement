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

# Enable AI suggestions for cases and knowledge articles

[!include[cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

## Introduction

With the use of AI, suggestions about similar cases help agents find the right solutions quickly, increase agent productivity, and provide better and faster service to customers.

## How AI suggestions for similar cases and knowledge articles works

***To be provided by Xiaoying***

## Prerequisites



## Enable AI suggestions for similar cases

1. Sign in to the Customer Service Hub app.
2. In the **Change area**, select **Service Management** > **Settings (Preview)**. The **Analytics and insights settings** page appears.
3. Select **Manage** under **Suggestions**. The **Suggestions (preview)** page appears.
4. In the **Settings** > **Summary** area, set the toggle to **Yes** for **Enable similar case suggestions**.
5. In the **Data mapping** > **Case entity data fields** area, select **Case Title** and **Description** in **Case summary** and **Case details** boxes respectively. The AI model for similar cases is based on the information specified.
6. Select **Save**.

    ![Enable AI-suggested similar cases](media/csw-enable-ai-suggested-cases.png "Enable AI-suggested similar cases")

## Enable AI suggestions for knowledge articles

1. Sign in to the Customer Service Hub app.
2. In the **Change area**, select **Service Management** > **Settings (Preview)**. The **Analytics and insights settings** page appears.
3. Select **Manage** under **Suggestions**. The **Suggestions (preview)** page appears.
4. In the **Settings** > **Summary** area, set the toggle to **Yes** for **Enable knowledge article suggestions**.
5. In the **Data mapping** > **Knowledge article data fields** area, make sure that **Title** and **Content** are selected in **Article title** and **Article content** boxes respectively.
6. Select **Save**.

    ![Enable AI-suggested knowledge articles](media/csw-enable-ai-suggested-km.png "Enable AI-suggested knowledge articles")

## Model pre-processing status

The **Model pre-processing status** area displays the following metadata pertaining to the AI processing. The run frequency is set out of the box.

Last successful run: Displays the date and time the model was last run.
Case records: Displays the number of new or updated case records that were processed.
Knowledge articles: Displays the number of new or updated knowledge articles that were processed.
Run frequency: Display the frequency that is set for the model to run.