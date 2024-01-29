---
title: Copilot data movement across geographies
description: Learn why you need to opt in to allow Copilot data to move outside of your default geography and how Azure OpenAI protects your data in transit.
ms.service: dynamics-365-sales
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: shujoshi
ms.topic: conceptual
ms.collection: bap-ai-copilot
ms.date: 01/04/2024
search.app: salescopilot-docs
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/03/2023
  - bap-template
---

# Copilot data movement across geographies

Although Copilot is available in all geographic regions, it requires the Microsoft Azure OpenAI Service, which is available only in North America and Europe. If your Dynamics 365 environment is located in any other region, your data, including personal data or data used in prompts or returned in completions, might be transmitted outside of the geographic locations that you've selected for your primary data residency.

You need to opt in to allow your data to move outside of your region to an Azure OpenAI endpoint in North America or Europe. For orgs in Europe, a consent is required because Azure OpenAI endpoints may not be available in your specific region and hence data may be moved to another region in Europe for processing. Note that all data originating from customers in Europe is always processed in Europe only.


The following table lists the geography of the Azure OpenAI service that Copilot uses for the different Dynamics 365 geographies, when you opt in.

|Copilot availability|Dynamics 365 geography|Azure OpenAI geography|
|----------|-------------|-----------------|
| Yes | Asia Pacific | United States |
| Yes | Australia | United States |
| Yes | Canada | United States |
| No | China | N/A|
| Yes | Europe | Europe |
| Yes | France | Europe |
| Yes | Germany | Europe |
| No | Government Community Cloud (GCC) | N/A |
| Yes | India | United States |
| Yes | Japan | United States |
| Yes | Korea | United States |
| Yes | Norway | Europe |
| Yes | Singapore | United States |
| Yes | South Africa | United States|
| Yes | South America | United States |
| Yes | Switzerland | Europe |
| Yes | United Arab Emirates | United States |
| Yes | United Kingdom | Europe |
| Yes | United States | United States |

### See also

- [Enable and configure Copilot in Dynamics 365 Sales](enable-setup-copilot.md)
