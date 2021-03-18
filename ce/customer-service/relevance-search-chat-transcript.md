---
title: "Configure relevance search for transcripts  | MicrosoftDocs"
description: "Learn how to configure relevance search for chat transcript so agents can search in Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 02/03/2020
ms.topic: article
ms.service: dynamics-365-customerservice
---
# Configure relevance search for transcripts 

[!INCLUDE[cc-data-platform-banner](../includes/cc-data-platform-banner.md)]

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Overview

In Omnichannel for Customer Service, agents can search for details in transcripts. To enable agents to search in transcripts, you as a system customizer need to configure relevance search for the Note entity.

## Prerequisites

Ensure that relevance search is enabled in your environment. To learn more, see [Enable relevance search](https://docs.microsoft.com/power-platform/admin/configure-relevance-search-organization#enable-relevance-search).
 
## Walk-through to configure relevance search

[Step 1: Configure relevance search for the Note entity](#step1)

[Step 2: Add a Note entity to Omnichannel for Customer Service](#step2)

## Step 1: Configure relevance search for the Note entity<a name="step1"></a>

1. Sign in to Dynamics 365.

2. Select **Settings** > **Customizations** > **Customize the System**. The **Solution: Default Solution - Microsoft Dynamics 365** window appears.

3. Under **Components**, select **Entities**.

4. Select **Configure Relevance Search**. The **Select Entities** dialog box appears.

5. In the **Available Entities** box, select **Note**, select **Add >**, and then select **OK**.

    > [!div class=mx-imgBorder]
    > ![Add the Note entity](media/add-note-entity.png "Add the Note entity")  

6. Select **Save**.

7. Select **Publish All Customizations**. 

<a name="step2"></a>

## Step 2: Add the Note entity to Omnichannel for Customer Service

1. Sign in to `https://<org>.dynamics.com/apps`.

2. Select **More Options** (...) in the **Omnichannel for Customer Service** app tile, and then select **OPEN IN APP DESIGNER**. The **App Designer** opens in a new browser tab.

3. On the **Components** tab, under **ARTIFACTS**, select **Entities**.

    > [!div class=mx-imgBorder]
    > ![Select entities](media/app-designer-entities.png "Select entities") 

4. Type **Note** in the search box, and then select the check box next to **Note** in the search results.

    > [!div class=mx-imgBorder]
    > ![Select Note](media/select-note.png "Select Note") 

5. Select **Save**, and then select **Publish**.

### See also

[Search for transcripts](oc-search-transcipts.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]