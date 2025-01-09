---
title: "Configure relevance search for transcripts | MicrosoftDocs"
description: "Learn how to configure relevance search for chat transcripts so agents can search in Dynamics 365 Contact Center."
ms.date: 11/12/2024
ms.topic: article
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
---
# Configure relevance search for transcripts 



[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]


Agents can search for details in transcripts. To enable agents to search in transcripts, you as a system customizer need to configure relevance search for the Note entity and then add the entity to Dynamics 365 Contact Center.

## Prerequisites

Ensure that relevance search is enabled in your environment. To learn more, see [Enable relevance search](/power-platform/admin/configure-relevance-search-organization#enable-relevance-search).

 
## Configure relevance search for the Note entity

1. Sign in to Dynamics 365.

2. Select **Settings** > **Customizations** > **Customize the System**. The **Solution: Default Solution - Microsoft Dynamics 365** window appears.

3. Under **Components**, select **Entities**.

4. Select **Configure Relevance Search**. The **Select Entities** dialog appears.

5. In the **Available Entities** box, select **Note**, select **Add**, and then select **OK**.

    > [!div class=mx-imgBorder]
    > ![Add the Note entity.](../media/add-note-entity.png "Add the Note entity")  

6. Select **Save**.

7. Select **Publish All Customizations**.

## Add the Note entity 

1. In your Dynamics 365 instance, go to the **Published Apps** page.

2. Select an app, select the ellipsis (...) in the application tile, and then select **OPEN IN APP DESIGNER**. The **App Designer** page opens in a new browser tab.

3. On the **Components** tab, under **ARTIFACTS**, select **Entities**.

    > [!div class=mx-imgBorder]
    > ![Select entities.](../media/app-designer-entities.png "Select entities") 

4. Type **Note** in the search box, and then select the check box next to **Note** in the search results.

    > [!div class=mx-imgBorder]
    > ![Select Note.](../media/select-note.png "Select Note") 

5. Select **Save**, and then select **Publish**.

### Related information

[Search for transcripts](../use/oc-search-transcipts.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
