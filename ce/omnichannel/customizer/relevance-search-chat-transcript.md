---
title: "Configure relevance search for transcripts  | MicrosoftDocs"
description: "Learn how to configure relevance search for chat transcript so agents can search in Omnichannel for Customer Service app."
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 10/25/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: C85FD1F9-A022-4215-9D48-685A32C8262F
---
# Configure relevance search for transcripts 

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

## Overview

In Omnichannel for Customer Service, agents need to search for details in the transcript. To search in transcript, as a system customizer, you need configure the relevance search for **Note** entity.

## Prerequisites

Ensure that relevance search is enabled in your environment. To learn more, see [Enable relevance search](https://docs.microsoft.com/power-platform/admin/configure-relevance-search-organization#enable-relevance-search).
 
## Walkthrough to enable configure relevance search

[Step 1: Configure relevance search for Note entity](#step-1-configure-relevance-search-for-note-entity)

[Step 2: Add Note entity to Omnichannel for Customer Service app](#step-2-add-note-entity-to-omnichannel-for-customer-service-app)

## Step 1: Configure relevance search for Note entity

1. Sign in to the Common Data Service platform.

2. Select **Settings** > **Customize the System**.

3. Select **Entities** under **Comonents** in the **Solution** pane.

4. Select **Configure Relevance Search**. The **Select Entities** dialog appears.

5. Select the **Note** entity under the **Available Entities** column, and select **Add >** to add it to the **Selected Entities** in the column, and then select **OK**.

    > [!div class=mx-imgBorder]
    > ![Add Note entity](../media/add-note-entity.png "Add Note entity")  

6. Select **Save** to save the changes.

7. Select **Publish All Customizations** to publish the changes.

## Step 2: Add Note entity to Omnichannel for Customer Service app

1. Sign in to `https://<org>.dynamics.com/apps`.

2. Select the **More Options** ellipsis (...) in the **Omnichannel for Customer Service** app tile, and select **OPEN IN APP DESIGNER**. The **App Designer** opens in a new browser tab.

3. Select **Entities** under **ARTIFACTS** in the **Components** tab.

    > [!div class=mx-imgBorder]
    > ![Select Entities](../media/app-designer-entities.png "Select Entities") 

4. Type **Note** in the search box. Select the check box.

5. Select **Save** to save the changes. After you save the **Publish** button appears.

    > [!div class=mx-imgBorder]
    > ![Select Note](../media/select-note.png "Select Note") 

6. Select **Publish** to publish the changes.

## See also

[Search for transcripts](../agent/agent-oc/oc-search-transcipts.md)