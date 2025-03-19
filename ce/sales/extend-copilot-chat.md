---
title: Customize Copilot in Dynamics 365 Sales (preview)
description: Learn how to extend Copilot in Dynamics 365 Sales to customize the welcome message, add prompts, and the prompt guide.
ms.date: 03/18/2025
ms.topic: how-to
ms.service: dynamics-365-sales
content_well_notification:
  - AI-contribution
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/02/2023
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ai-usage: ai-assisted
---

# Customize Copilot in Dynamics 365 Sales (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Customize Copilot chat to make it more intelligent and relevant for your organization. 

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

You can customize the following aspects of the Copilot chat experience in Dynamics 365 Sales:

- Add additional topics to help Copilot learn from your organization's data, content, and processes.
- Customize the prompt guide to include the most relevant prompts for your organization.

> [!NOTE]
>- This article applies only to Copilot in Dynamics 365 Sales. You can also customize Copilot in other model-driven apps. Learn more at [Customize Copilot chat using Copilot Studio(preview)](/power-apps/maker/model-driven-apps/customize-copilot-chat).
>- Knowledge source is not yet supported for Copilot in Dynamics 365 Sales.

## Customize Copilot using Copilot Studio

Use a solution to manage your customizations so that you can easily deploy them across different environments. Learn more in [Create a solution in Copilot Studio](/microsoft-copilot-studio/authoring-solutions-overview)

1. Sign in to [Copilot Studio](https://copilotstudio.microsoft.com/).
1. Select your Dynamics 365 environment and then select **Agents**.
1. Select **Copilot in Dynamics 365 Sales** to customize Copilot in Dynamics 365 Sales.
1. Customize the following aspects of Copilot chat experience:

    - [Add a new topic to Copilot chat](/power-apps/maker/model-driven-apps/customize-copilot-chat#add-new-topic-to-copilot-chat).
    - Edit the **SalesSparks** topic to [customize the prompt guide](/power-apps/maker/model-driven-apps/customize-copilot-chat#prompt-guide-customizations).
    
  > [!NOTE]
  > The [Image](/microsoft-copilot-studio/authoring-send-message#add-an-image) and [Video](/microsoft-copilot-studio/authoring-send-message#add-an-image) message types from agent to user aren't supported. As a workaround, you can use Adaptive Cards.

## Related information

[FAQ for Copilot chat in model-driven apps](/power-apps/maker/common/faqs-copilot-model-driven-app)  
[Responsible AI FAQs for Power Apps](/power-apps/maker/common/responsible-ai-overview)  
