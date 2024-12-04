---
title: Enable knowledge sources from Microsoft Copilot Studio 
description: Learn how to enable knowledge sources from Microsoft Copilot Studio.
author: Soumyasd27
ms.author: sdas
ms.reviewer: Soumyasd27
ms.topic: how-to 
ms.collection: 
ms.date: 12/04/2024
ms.custom: bap-template
---

# Enable knowledge sources from Microsoft Copilot Studio

The performance of Copilot is highly correlated to the quality of knowledge it can access. You can enable customers to integrate with various knowledge management platforms without having to ingest the content into the Dynamics 365 knowledge base. The expanded knowledge coverage beyond the Dynamics 365 knowledge base improves Copilot response quality, thereby the agents' experience and productivity.

## Prerequisites

Make sure you have met the following prerequisites.

- You have the System Administrator role. 
- A license for Copilot Studio is available. 
- [Copilot in Customer Service is enabled](configure-copilot-features.md#manage-copilot-features-in-customer-service). 

## Enable knowledge sources configured in Copilot Studio
 
1. In the Customer Service admin center, go to **Productivity** > **Copilot for questions and emails** > **Manage**. 
1. In the **Knowledge sources** section, select the **Use knowledge sources configured in Copilot Studio (preview)** option. This takes you to Microsoft Copilot Studio. 
1. In Microsoft Copilot Studio, go to **Copilot in Dynamics 365 Customer Service**.
1. On the **Knowledge** page, select **Add knowledge**.
1. Select from the following knowledge sources:
    1. [Public website](/microsoft-copilot-studio/knowledge-add-public-website)
    1. [File upload](/microsoft-copilot-studio/knowledge-add-file-upload)
    1. [Dataverse](/microsoft-copilot-studio/knowledge-add-dataverse)
    1. [Graph connectors](/microsoft-copilot-studio/knowledge-graph-connections)
1. Publish the changes. This will also publish any unpublished plugin changes you might have made.

> [!NOTE]
> Federated knowledge source isn't supported currently but customers can optionally select the Graph connectors to connect to their preferred sources.

## Next steps

