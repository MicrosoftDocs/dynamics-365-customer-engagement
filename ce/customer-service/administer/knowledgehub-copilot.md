---
title: Enhance Copilot responses with knowledge from additional sources 
description: 
author: Soumyasd27
ms.author: sdas
ms.reviewer: Soumyasd27
ms.topic: how-to 
ms.collection: 
ms.date: 11/18/2024
ms.custom: bap-template
---

# Enhance Knowledge in Copilot Studio

The performance of Copilot is highly correlated to the quality of knowledge it can access. This feature enables customers to integrate with various knowledge management platforms without having to ingest the content into the Dynamics 365 knowledge base. The expanded knowledge coverage improves Copilot response quality, thereby the agents' experience and productivity.

This will enable agents to get enhanced Copilot results powered by content from knowledge sources beyond the Dynamics 365 knowledge base. 

## Prerequisites

Make sure you have met the following prerequisites.

- You have the System Administrator role. 

- A license for Copilot Studio is available. 

- Copilot in Customer Service is enabled. 

## Enable Knowledge Hub in the Customer Service admin center
 
1. In the Customer Service admin center, go to **Productivity** > **Copilot for questions and emails** > **Manage**. 
1. In the **Knowledge sources** section, select the **Use knowledge sources configured in Copilot Studio (preview)** option. This takes you to Microsoft Copilot Studio. 
1. In Microsoft Copilot Studio, go to **Copilot in Dynamics 365 Customer Service**.
1. On the **Knowledge** page, select **Add knowledge**.
1. Select from the following knowledge sources:
    1. [Public website](/microsoft-copilot-studio/knowledge-add-public-website)
    1. [File upload](/microsoft-copilot-studio/knowledge-add-file-upload)
    1. [SharePoint](/microsoft-copilot-studio/knowledge-add-sharepoint) 
    1. [Dataverse](/microsoft-copilot-studio/knowledge-add-dataverse)
    1. [Graph connectors](/microsoft-copilot-studio/knowledge-graph-connections)
1. Publish (Need info)

> [!NOTE]
> - You must enable the SharePoint (preview) to be able to see it. 
> - Federated knowledge source doesn't work.

## Next steps

