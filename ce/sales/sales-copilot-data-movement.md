---
title: Copilot data movement across geographies
description: Learn why you need to opt in to allow Copilot data to move outside of your default geography and how Azure OpenAI protects your data in transit.
ms.service: dynamics-365-sales
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.topic: conceptual
ms.collection: bap-ai-copilot
ms.date: 09/03/2024
search.app: salescopilot-docs
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/03/2023
  - bap-template
---

# Copilot data movement across geographies

Copilot in Dynamics 365 Sales is available in several regions and requires a Microsoft Azure OpenAI Service endpoint. For a list of regions where Copilot in Dynamics 365 Sales is available see the [Copilot international availability report](https://releaseplans.microsoft.com/en-US/availability-reports/?report=copilotproductreport). For a list of regions where Azure OpenAI Service is available, see [Regions involved with copilots and generative AI features](/power-platform/admin/geographical-availability-copilot?WT.mc_id=ppac_inproduct_settings#regions-involved-with-copilots-and-generative-ai-features).

If your Dynamics 365 environment is in a region where Copilot is available but an Azure OpenAI Service endpoint isn't available, your data, including personal data or data used in prompts or returned in completions, might be transmitted outside of the geographic locations that you've selected for your primary data residency.

You need to opt in to allow your data to move outside of your region to an Azure OpenAI endpoint in a different region. You can opt in by providing consent in the Power Platform admin center. Learn more about [how to provide consent](/power-platform/admin/geographical-availability-copilot#turn-on-copilots-and-generative-ai-features-1).


## Related information

- [Enable and configure Copilot in Dynamics 365 Sales](enable-setup-copilot.md)
