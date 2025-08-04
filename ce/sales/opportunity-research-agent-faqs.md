---
title: FAQs about Opportunity Research Agent (preview)
description: Get to know answers to frequently asked questions about the Opportunity Research Agent in Dynamics 365 Sales.
ms.date: 08/04/2025
ms.topic: overview
ms.service: dynamics-365-sales
content_well_notification:
  - AI-contribution
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-description
  - ai-seo-date:08/04/2025
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# FAQs about Opportunity Research Agent (preview)

This article provides answers to frequently asked questions about the Opportunity Research Agent in Dynamics 365 Sales. 

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## How does that agent assess opportunity importance and risk?

The agent uses fields like monetary value (for example, Est. revenue) and estimated close date to assess the importance and risk of opportunities. Your admin defines these fields in the Opportunity Research Agent settings page.

## How often does the Opportunity Research Agent refresh research data?

By default, the research data is refreshed once in three days. Your admin can change the frequency to High (daily) or Low (every seven days), depending on your business needs and Copilot Studio capacity. Learn more in [Configure the Opportunity Research Agent](configure-opportunity-research-agent.md).

## Why do knowledge sources from Sales Qualification Agent appear in Opportunity Research Agent?

The Sales Qualification Agent and Opportunity Research Agent share the same Copilot Studio agent for research. Hence, the knowledge sources are shared among both the sales agents for research insights. Any additions or deletions to the knowledge sources in one agent are reflected in the other.

## Why did the Opportunity Research Agent pause?

The agent pauses when the admin turns it off. You see the following message in the banner: "Opportunity Research Agent paused, data may be outdated and actions might be disabled." Contact your admin to turn on the agent. 
