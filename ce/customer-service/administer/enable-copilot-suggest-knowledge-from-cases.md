---
title: Enable Copilot to suggest knowledge from cases (preview)
description: Enable the use of Copilot to suggest knowledge drafts from cases.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: how-to
ms.collection: bap-ai-copilot
ms.date: 11/28/2024
ms.custom: bap-template
---

# Enable Copilot to suggest knowledge from cases (preview)

[This article is prerelease documentation and is subject to change.]

Copilot can generate knowledge articles from resolved cases. By using Copilot, you can streamline the process of creating and updating knowledge base content based on real-world customer interactions. You can review and edit these suggestions before publishing them as knowledge articles.

[!INCLUDE [preview-note](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Prerequisites

- The System Administrator role.
- You have enabled and configured knowledge management.

## Enable Copilot to generate knowledge

Do the following steps in Customer Service admin center:

1. In the site map, under Agent experience, select **Knowledge**, and on the Knowledge page, select **Manage** for **Knowledge creation**.
1. On the **Knowledge creation (preview)** page, in **Case-based knowledge creation**, select the following checkboxes to let agents use Copilot:
    - **Let agents use Copilot to propose new knowledge based on case information during or after case resolution**
       - **In the case resolution step, keep the option to propose a knowledge article selected by default** 
1. In **User experience data**, select the checkbox for the system to record user interactions with AI and their feedback on AI suggestions. The information can then be used to analyze knowledge sources and build usage reports.

    :::image type="content" source="../media/screenshot-of-set-up-knowledge-from-case.png" alt-text="Screenshot of settings to enable Copilot to create knowledge proposals from case.":::

1. Save and close.

## Region availability and data movement

See [Region availability of analytics and insights](cs-region-availability-service-limits.md) for information on supported regions.

## Supported languages

To learn about supported languages for Copilot, see [Language support for AI-based analytics and insights in Customer Service](cs-region-availability-service-limits.md#language-support-for-ai-based-analytics-and-insights-in-customer-service).

### Related information

[Use Copilot to generate knowledge drafts from cases](../use/use-copilot-knowledge-from-cases.md)  
[Manage Copilot features in Customer Service](configure-copilot-features.md)  
[Responsible AI FAQ for copilot features](../implement/faq-responsible-ai-copilot.md)  
[FAQ for Copilot in Customer Service](faq-copilot-features.md)  



