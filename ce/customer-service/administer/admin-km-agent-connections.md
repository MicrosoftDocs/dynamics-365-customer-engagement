---
title: Configure Microsoft Copilot Studio and Dataverse connections (Preview)
description: Learn how to configure Microsoft Copilot Studio and Dataverse connections for the customer knowledge management agent flow.
author: Soumyasd27
ms.author: sdas
ms.reviewer: Soumyasd27
ms.topic: how-to
ms.collection:
ms.date: 11/13/2024
ms.custom: bap-template
---

# Configure Microsoft Copilot Studio and Dataverse Connections (Preview)

[This article is prerelease documentation and is subject to change.]

This article provides instructions to configure Microsoft Copilot Studio and Dataverse connections for the customer knowledge management agent flow. 

> [!IMPORTANT]
>
> - This is a preview feature.
> - Preview features aren’t meant for production use and might have restricted functionality. These features are available before an official release so that customers can get early access and provide feedback.

## Set connection references for customer knowledge management agent flow

1. Sign in to [make.powerapps.com](https://make.powerapps.com) and select your environment.
1. Go to **Solutions** > **Default Solution** > **Objetcs** > **Connection References**.
1. Search for the following connection references:
    - **Microsoft Dataverse CSKnowledgeHarvestV2**
    - **Microsoft Copilot Studio CSKnowledgeHarvestV2**
 
You can either select an existing connection if present or create a new one by selecting **New connection**.

To create a new Dataverse connection:
1. Select **Connections**, and search for **Dataverse**. 
1. Select **Add** besides **Microsoft Dataverse**, and then select **Create**.
 
To create a Microsoft Coilot Studio connection:
1. Search for **Microsoft Copilot Studio** and then select **Microsoft Copilot Studio (preview)**.

### Turn on the Power Automate flow

1. Go to [make.powerapps.com](https://make.powerapps.com), and then select **Flows**.
1. From the **Cloud flows** tab, select **Knowledge Harvest Trigger Flow V2** flow.
 

## Publish the Microsoft Copilot Studio bot

1. Go to [Microsoft Copilot Studio](https://copilotstudio.microsoft.com), and select your environment.
1. Select **Agents**.
1. Search for and select **CSKnowledgeHarvestV2**.
1. Select **Publish**.

Once done, go to the Customer Service admin center and enable customer knowledge management agent. Learn more in [Manage customer knowledge management agent (Preview)](admin-km-agent.md#manage-knowledge-harvesting-preview)
 
## Related information

[Overview of cloud flows](/power-automate/overview-cloud)

