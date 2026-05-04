---
title: FAQs about AI-powered Data Enrichment for opportunities
description: Explore frequently asked questions about AI-powered Data Enrichment in Dynamics 365 Sales and how it transforms your CRM data into valuable insights.
ms.date: 04/22/2026
ms.update-cycle: 180-days
ms.topic: faq
ms.service: dynamics-365-sales
ms.custom:
    - bap-template
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# FAQs about AI-powered Data Enrichment for opportunities

This article provides answers to frequently asked questions about the AI-powered Data Enrichment feature in Dynamics 365 Sales.

## What data does AI-powered Data Enrichment use?

AI-powered Data Enrichment uses data from sources within your Dynamics 365 environment:

- **Dataverse data**: Information stored in your organization's Microsoft Dataverse environment, including configured CRM entities such as accounts, contacts, leads, and opportunities.
- **Email data**: Customer emails stored Microsoft 365, which the feature analyzes to extract context and relevant information.

AI-powered Data Enrichment only accesses fields and entities that have been approved by administrators through configuration settings. Data access is constrained by user roles and permissions configured in Dynamics 365. The feature does not have access to all data in your environment by default.

The quality and completeness of enrichment suggestions depend directly on the quality, completeness, and currency of the source data available, including the comprehensiveness of conversation history.

## What data is sent outside the organization?

AI-powered Data Enrichment processes data within your Dynamics 365 environment and does not send customer data, email content, or CRM records outside your organization's tenant for enrichment purposes.

All data processing occurs within Microsoft's cloud infrastructure in accordance with your organization's tenant configuration and Microsoft's data handling policies. Data residency and compliance settings configured for your Dynamics 365 environment apply to AI-powered Data Enrichment operations.

## How frequently does AI-powered Data Enrichment update opportunity records?

The agent analyzes emails and generates suggestions every 4 hours. For manual updates, sellers can review suggestions as soon as they're generated. For automatic updates, changes are applied based on the enrichment frequency, which is set to **Daily** by default. This frequency can't be changed.

## Why can't I see the AI-powered Data Enrichment suggestions?

If you don't see suggestions, it could be due to several reasons:

- **Configuration settings**: Your administrator might not have configured the feature. 
- **User permissions**: It's possible that you are not a part of the group that has access to view suggestions. 
- **Consent**: The opportunity owner might not have provided consent to analyze their emails.
    - If you are the owner of the opportunity, ensure that you have [provided consent](use-data-enrichment-agent.md#provide-consent-for-data-enrichment-to-read-your-emails) to analyze your emails. 
    - If you're looking at an opportunity that you don't own, it's possible that the owner of that opportunity has not provided consent to analyze their emails or they don't have access to the Data Enrichment feature.
- **Data availability**: There may not be sufficient data or relevant email interactions to generate suggestions for that opportunity.