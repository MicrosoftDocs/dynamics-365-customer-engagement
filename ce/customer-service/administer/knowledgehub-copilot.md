---
title: Enable knowledge sources from Microsoft Copilot Studio 
description: Learn how to enable knowledge sources from Microsoft Copilot Studio.
author: Soumyasd27
ms.author: sdas
ms.reviewer: Soumyasd27
ms.topic: how-to 
ms.collection: 
ms.date: 12/13/2024
ms.custom: bap-template
---

# Enable knowledge sources from Microsoft Copilot Studio

The performance of your Copilot is highly correlated to the quality of the knowledge sources it can access. You can enable customers to integrate various knowledge platforms without having to add the content directly into the Dynamics 365 knowledge base. The expanded Dynamics 365 knowledge base improves your Copilot's response quality, along with its experience and productivity.

## Prerequisites

- You have the System Administrator role. 
- A license for  Microsoft Copilot Studio is available. 
- [Copilot in Customer Service is enabled](configure-copilot-features.md#manage-copilot-features-in-customer-service). 

## Enable knowledge sources configured in Copilot Studio
 
1. In the Customer Service admin center, go to **Productivity** > **Copilot for questions and emails** > **Manage**. 
1. In the **Knowledge sources** section, select the **Use knowledge sources configured in Copilot Studio (preview)** option, which opens Copilot Studio. 
1. In Copilot Studio, select **Copilot in Dynamics 365 Customer Service**.
1. On the **Knowledge** page, select **Add knowledge**.
1. Select from the following knowledge sources:
    - [Public website](/microsoft-copilot-studio/knowledge-add-public-website)
    - [SharePoint](/microsoft-copilot-studio/knowledge-add-sharepoint)
    - [File upload](/microsoft-copilot-studio/knowledge-add-file-upload)
    - [Dataverse](/microsoft-copilot-studio/knowledge-add-dataverse)
    - [Enterprise data](/microsoft-copilot-studio/knowledge-graph-connections)
1. In Customer Service admin center, select **Save** or **Save and close**.
1. On the **Publish knowledge sources** dialog that appears, select **Publish**.

If you made any unpublished modifications to the plugins, you see a **Detected unpublished plugin** dialog. Select **Publish.**

> [!NOTE]
> Enterprise data that uses Copilot connectors as knowledge sources currently isn't supported. Instead, customers can optionally use Microsoft Graph connectors for their preferred sources.

## Related information

[Knowledge sources overview](/microsoft-copilot-studio/knowledge-copilot-studio)
