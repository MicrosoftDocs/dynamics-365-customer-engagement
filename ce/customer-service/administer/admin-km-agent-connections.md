---
title: Configure Microsoft Copilot Studio and Dataverse connections
description: Learn how to configure Microsoft Copilot Studio and Dataverse connections for the knowledge harvest flow.
author: Soumyasd27
ms.author: sdas
ms.reviewer: Soumyasd27
ms.topic: how-to
ms.collection:
ms.date: 11/07/2024
ms.custom: bap-template
---

# Configure Microsoft Copilot Studio and Dataverse Connections

This article provides instructions to configure Microsoft Copilot Studio and Dataverse connections for the knowledge harvest flow. 

## Set connection references for knowledge harvest flow

1. Sign in to [make.powerapps.com](https://make.powerapps.com) and select your environment.
1. Go to **Solutions** > **Default Solution** > **Objetcs** > **Connection References**.
1. Search for the following connection references:
    - **Microsoft Dataverse CSKnowledgeHarvestV2**
    - **Microsoft Copilot Studio CSKnowledgeHarvestV2**
 
     You can either select an existing connection if present or create a new one by selecting **New connection**. This takes you to Power Automate.

1. To create a new Dataverse connection, select **Connections**, search for **Dataverse**, and then select **Microsoft Dataverse**.
 
1. To create a Microsoft Coilot Studio connection, search for **Microsoft Copilot Studio** and then select **Microsoft Copilot Studio (preview)**.

## Turn on the Power Automate flow

1. Go back to [make.powerapps.com](https://make.powerapps.com), and then select **Flows**.
1. From the **Cloud flows** tab, select **Knowledge Harvest Trigger Flow V2** flow.
 

## Publish the Microsoft Copilot Studio bot

1. Go to [Microsoft Copilot Studio](https://copilotstudio.microsoft.com), and select your environment.
1. Select **Copilots** and search for **CSKnowledgeHarvestV2**.
1. Select the **CSKnowledgeHarvestV2** bot and then select **Publish**.
 
## Next steps

[Enable Customer Knowledge Management Agent](admin-km-agent.md#enable-customer-knowledge-management-agent)

