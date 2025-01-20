---
title: Customize Copilot in Dynamics 365 Sales
description: Learn how to extend Copilot in Dynamics 365 Sales to customize the welcome message, add prompts, and the prompt guide. 
ms.date: 01/16/2025
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

# Customize Copilot in Dynamics 365 Sales

Customize Copilot chat to make it even more intelligent and relevant for your organization. You can customize the following aspects of Copilot chat experience:

- Add additional topics and knowledge sources
- Customize the prompt guide to include the most relevant prompts for your organization.

You can customize Copilot in Dynamics 365 Sales using [Copilot Studio](#customize-copilot-using-copilot-studio) directly or through [Power Apps](#customize-copilot-through-power-apps-preview).

Use a solution to manage your customizations if you don't want to make changes directly in the default solution. Solutions also help you move your customizations across environments.

## Customize Copilot through Power Apps (preview)

If you've opted in to the preview feature, you can customize Copilot in Dynamics 365 Sales using Power Apps. 

1. Follow the instructions to [customize Copilot in Copilot Studio](/power-apps/maker/model-driven-apps/customize-copilot-chat).
1. Make sure to select **Sales Copilot Power Virtual Agent Bot** in Copilot Studio.
1. Add topics and knowledge sources and make the necessary changes to the prompts and prompt guide.


## Customize Copilot using Copilot Studio

If you haven't opted in to the preview feature but still want to customize Copilot in Dynamics 365 Sales, you can do so using Copilot Studio.

1. Sign in to [Copilot Studio](https://copilotstudio.microsoft.com/).

1. Select your Dynamics 365 environment and then select **Agents**.
1. Select **Sales Copilot Power Virtual Agent Bot** to customize Copilot in Dynamics 365 Sales.
1. Customize the following aspects of Copilot chat experience:
    - [Add new topic to Copilot chat](/power-apps/maker/model-driven-apps/customize-copilot-chat#add-new-topic-to-copilot-chat).
    - [Add knowledge to Copilot chat](/power-apps/maker/model-driven-apps/customize-copilot-chat#add-knowledge-to-copilot-chat).
    - [Customize prompt guide](/power-apps/maker/model-driven-apps/customize-copilot-chat#prompt-guide-customizations)


## Related information

- [Create and manage solutions in Copilot Studio](/microsoft-copilot-studio/authoring-solutions-overview)  
- [Create a solution in Power Apps](/power-apps/maker/data-platform/create-solution)