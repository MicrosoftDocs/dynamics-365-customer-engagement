---
title: Sales Copilot data and geographies
description: Learn why you need to opt in to allow Sales Copilot data to move outside of your default geography and how Azure OpenAI protects your data in transit.
ms.service: dynamics-365-sales
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: shujoshi
ms.topic: conceptual
ms.collection:
ms.date: 09/21/2023
search.app: salescopilot-docs
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/03/2023
---

# Sales Copilot data and geographies

Although Sales Copilot is available in all geographic regions, it requires the Microsoft Azure OpenAI Service, which is available only in North America and Europe. If your Dynamics 365 environment is located in any other region, your data, including personal data or data that's used in prompts or returned in completions, might be transmitted outside of the geographic locations that you've selected for your primary data residency.

You need to opt in to allow your data to move outside of your region to an Azure datacenter in North America or Europe. Data in environments that are located in Europe is processed in Europe only.

[Learn how Azure OpenAI protects your data](/legal/cognitive-services/openai/data-privacy#preventing-abuse-and-harmful-content-generation).

### See also

- [Enable and configure Sales Copilot](enable-setup-copilot.md)
