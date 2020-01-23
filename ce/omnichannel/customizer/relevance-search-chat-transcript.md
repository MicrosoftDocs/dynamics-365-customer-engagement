---
title: "Configure relevance search for transcripts  | MicrosoftDocs"
description: "Learn how to configure relevance search for chat transcript so agents can search in Omnichannel for Customer Service app."
author: kabala123
ms.author: kabala
manager: shujoshi
ms.date: 31/01/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---
# Configure relevance search for transcripts 

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

## Overview

In Omnichannel for Customer Service, agents may search for details in transcripts. For agents to be able to search in transcripts, as a system customizer, you need to configure relevance search for the **Note** entity.

## Prerequisites

Ensure that relevance search is enabled in your environment. To learn more, see [Enable relevance search](https://docs.microsoft.com/power-platform/admin/configure-relevance-search-organization#enable-relevance-search).
 
## Walkthrough to configure relevance search

[Step 1: Configure relevance search for the Note entity](#step-1-configure-relevance-search-for-note-entity)

[Step 2: Add Note entity to Omnichannel for Customer Service app](#step-2-add-note-entity-to-omnichannel-for-customer-service-app)

## Step 1: Configure relevance search for the Note entity

1. Sign in to the Common Data Service platform.

2. Select **Settings** > **Customizations** > **Design customization the System**. The Solution: Default Solution - Microsoft Dynamics 365 window appears.

3. Select **Entities** under **Components** in the **Solution: Default Solution** pane.

4. Select **Configure Relevance Search**. The **Select Entities** dialog box appears.

5. Select the **Note** entity under the **Available Entities** box, and select **Add >**, and then select **OK**. The **Note** entity is added in the **Selected Entities** box.

    > [!div class=mx-imgBorder]
    > ![Add Note entity](../media/add-note-entity.png "Add Note entity")  

6. Select **Save**.

7. Select **Publish All Customizations**. The changes are published.

## Step 2: Add the Note entity to Omnichannel for Customer Service app

1. Sign in to `https://<org>.dynamics.com/apps`.

2. Select the **More Options** ellipsis (...) in the **Omnichannel for Customer Service** app tile, and select **OPEN IN APP DESIGNER**. The **App Designer** opens in a new browser tab.

3. Select **Entities** under **ARTIFACTS** on the **Components** tab in the right pane.

    > [!div class=mx-imgBorder]
    > ![Select Entities](../media/app-designer-entities.png "Select Entities") 

4. Type **Note** in the search box, and select the check box against **Note** in the search results.

5. Select **Save**. The **Publish** option is enabled.

    > [!div class=mx-imgBorder]
    > ![Select Note](../media/select-note.png "Select Note") 

6. Select **Publish**. The changes are published.

## See also

[Search for transcripts](../agent/agent-oc/oc-search-transcipts.md)
