---
title: Copilot data movement across geographies
description: Learn why you need to opt in to allow Copilot data to move outside of your default geography and how Azure OpenAI protects your data in transit.
ms.service: dynamics-365-sales
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: shujoshi
ms.topic: conceptual
ms.collection:
ms.date: 10/26/2023
search.app: salescopilot-docs
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/03/2023
  - bap-template
---

# Copilot data movement across geographies

Although Copilot is available in all geographic regions, it requires the Microsoft Azure OpenAI Service, which is available only in North America and Europe. If your Dynamics 365 environment is located in any other region, your data, including personal data or data that's used in prompts or returned in completions, might be transmitted outside of the geographic locations that you've selected for your primary data residency.

You need to opt in to allow your data to move outside of your region to an Azure OpenAI endpoint in North America or Europe. Though the opt-in terms are shown for Europe, data from Europe region is processed in Europe only.

> [!NOTE]
> - If your environment is hosted in North America, Copilot will use an Azure OpenAI endpoint in North America to process your data.
> - If your environment is hosted in Europe, Copilot will use an Azure OpenAI endpoint in Europe to process your data.
> - If your environment is hosted anywhere else, Copilot will use an Azure OpenAI endpoint outside of the region in which the environment is hosted.

To learn more about how Azure OpenAI protects your data, read [Data, privacy, and security for Azure OpenAI Service](/legal/cognitive-services/openai/data-privacy#preventing-abuse-and-harmful-content-generation).

### See also

- [Enable and configure Copilot in Dynamics 365 Sales](enable-setup-copilot.md)
