---
title: Conversation intelligence data movement across geographies
description: Learn why you need to opt in to allow Conversation intelligence data to move outside of your default geography and how Azure OpenAI protects your data in transit.
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

# Conversation intelligence data movement across geographies

Starting June 2024, Conversation intelligence will only be available in specific regions and requires a Microsoft Azure OpenAI Service endpoint. For a list of regions where Azure OpenAI Service is available, see [Azure OpenAI Service models](/azure/ai-services/openai/concepts/models). 

If your Dynamics 365 Sales organization is in a region where Azure OpenAI Service isn't available, your call data and transcripts will be processed in the nearest region where Azure OpenAI Service is available.