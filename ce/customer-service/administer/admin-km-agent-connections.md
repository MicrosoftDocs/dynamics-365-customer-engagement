---
title: Configure connection references for customer knowledge management agent flow (preview)
description: Learn how to configure connection references for customer knowledge management agent flow.
author: Soumyasd27
ms.author: sdas
ms.reviewer: Soumyasd27
ms.topic: how-to
ms.collection:
ms.date: 11/15/2024
ms.custom: bap-template
---

# Configure connection references for customer knowledge management agent flow (preview)

[This article is prerelease documentation and is subject to change.]

This article provides instructions to configure connection references for the customer knowledge management agent flow. 

> [!IMPORTANT]
>
> - This is a preview feature.
> - Preview features aren’t meant for production use and might have restricted functionality. These features are available before an official release so that customers can get early access and provide feedback.

## Set connection references for customer knowledge management agent flow

1. Sign in to [make.powerapps.com](https://make.powerapps.com) and select your environment.
1. Go to **Solutions** > **Default Solution** > **Objects** > **Connection References**.
1. Search for the following connection references:
    - **Microsoft Dataverse CustomerServiceKnowledgeHarvest**
    - **Microsoft Copilot Studio CustomerServiceKnowledgeHarvest**
    1. To create a connection for **Microsoft Dataverse CustomerServiceKnowledgeHarvest**, in the **Edit** dialog, select **Connection** > **New connection**. 
    1. Search for **Microsoft Dataverse** and select **Add**.
    1. For **Microsoft Copilot Studio CustomerServiceKnowledgeHarvest**, search for **Microsoft Copilot Studio (Preview)** and select **Add*8.
 
## Turn on the Power Automate flow

1. Go to **Flows**.
1. From the **Cloud flows** tab, select **Knowledge Harvest Trigger Flow V2** flow.
1. Select **Turn on**.
 
## Publish the Microsoft Copilot Studio bot

1. Go to [Microsoft Copilot Studio](https://copilotstudio.microsoft.com), and select your environment.
1. Select **Agents**.
1. Search for and select **CustomerServiceKnowledgeHarvest**.
1. Select **Publish**.

Once done, go to the Customer Service admin center and enable customer knowledge management agent. Learn more in [Manage customer knowledge management agent (Preview)](admin-km-agent.md#manage-knowledge-harvesting-preview)
 
## Related information

[Overview of cloud flows](/power-automate/overview-cloud)

