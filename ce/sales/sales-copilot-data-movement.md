---
title: Copilot data movement across geographies
description: Learn why you need to opt in to allow Copilot data to move outside of your default geography and how Azure OpenAI protects your data in transit.
ms.service: dynamics-365-sales
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: shujoshi
ms.topic: conceptual
ms.collection: bap-ai-copilot
ms.date: 04/02/2024
search.app: salescopilot-docs
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/03/2023
  - bap-template
---

# Copilot data movement across geographies

Copilot in Dynamics 365 Sales is only available in specific regions and requires a Microsoft Azure OpenAI Service endpoint. For a list of regions where Copilot in Dynamics 365 Sales isn't supported, see [this FAQ](sales-copilot-faq.md#is-copilot-in-dynamics-365-sales-available-in-all-regions).

If your Dynamics 365 environment is in a region where Copilot is supported but an Azure Open AI Service endpoint isn't available, your data, including personal data or data used in prompts or returned in completions, might be transmitted outside of the geographic locations that you've selected for your primary data residency. [Learn more about how data movement across regions works](/power-platform/admin/geographical-availability-copilot#how-data-movement-across-regions-works).

You need to opt in to allow your data to move outside of your region to an Azure OpenAI endpoint in a different region. You can opt in by providing consent in the Power Platform admin center. Learn more about [how data movement across region works](/power-platform/admin/geographical-availability-copilot#how-data-movement-across-regions-works) and [how to provide consent](/power-platform/admin/geographical-availability-copilot#enable-data-movement-across-regions).


### See also

- [Enable and configure Copilot in Dynamics 365 Sales](enable-setup-copilot.md)
