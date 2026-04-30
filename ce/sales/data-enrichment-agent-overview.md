---
title: AI-powered Data Enrichment for opportunities
description: Learn how the AI-powered Data Enrichment helps automate updating and enriching opportunity data based on recent email interactions.
ms.date: 04/22/2026
ms.update-cycle: 180-days
ms.topic: overview
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

# AI-powered Data Enrichment for opportunities

The AI-powered Data Enrichment feature helps sellers and managers maintain accurate and complete opportunity data. Incomplete or outdated opportunity records can lead to missed sales, inaccurate forecasting, and inefficient deal reviews. The AI-powered Data Enrichment feature addresses this challenge by automatically analyzing recent email interactions and suggesting or making updates to opportunity records. This proactive approach reduces manual data entry, improves pipeline confidence, and supports more effective deal reviews and forecasting.

## How the AI-powered Data Enrichment feature works

The agent behind the AI-powered Data Enrichment feature follows these steps to analyze and enrich opportunity records:

1. **Filters opportunity records**: The agent applies the user and record selection criteria that the admin defines to select relevant opportunity records for analysis.

1. **Analyze recent changes**: The agent scans emails exchanged between sellers and customers to gather context about selected opportunities. It looks for context and deal-related information such as budget, authority, need, and timeline that can help enrich the opportunity records.
1. **Identify missing or outdated fields**: The agent compares the information in the emails with the existing opportunity records to identify any discrepancies or gaps.  
1. **Suggest updates**: The agent generates suggestions for updating opportunity fields, such as estimated close date and budget amount, and associating relevant emails. Alternatively, an admin can configure the agent to automatically update the records without any manual intervention. 
1. **Review and apply updates**: Sellers can review the suggested updates and choose to apply them to the opportunity records with a single click. In cases where automatic updates are enabled, the sellers can still review the changes made by the agent and revert them if necessary.

## How to set up and use Data Enrichment

Depending on your role, refer to the following articles to set up and use the AI-powered Data Enrichment feature:

| User role | Reference |
|-----------|-----------|
| Administrator | [Set up and configure AI-powered Data Enrichment](data-enrichment-agent-configure.md)<br>[Edit AI-powered Data Enrichment settings](data-enrichment-agent-edit-settings.md)<br>[Responsible AI FAQ about AI-powered Data Enrichment for opportunities](FAQs-data-enrichment-agent.md) |
| Seller | [Review and approve Data Enrichment suggestions](use-data-enrichment-agent.md) |


## Capacity usage

AI-powered Data Enrichment runs as a background process that monitors seller emails. It doesn't process all emails but focuses on those relevant to opportunities owned by the sellers. 

**Example:** Assuming a scenario where a seller receives around 100 emails per day with the following distribution: 

- 35 are internal emails, which are skipped by the agent.
- 25 are from external contacts who aren't registered in the system, thus treated as personal and not processed by the agent.
- 15 are already linked to existing opportunity records and are processed by the agent for potential data enrichment.
- 25 are from external contacts registered in the system but aren't linked to any opportunity records. These emails are processed by the agent for potential opportunity matching and enrichment.  

The credit consumption depends on the number of emails processed by the agent for matching and enriching opportunity records. Use the following resources to learn more about setting up capacity and monitoring usage:

- [Manage consumption-based billing for agent capabilities](copilot-consumption-based-billing.md)
- [View the agent's usage consumption](/power-platform/admin/manage-copilot-studio-messages-capacity?tabs=new#use-the-summary-tab)

## Responsible AI

The AI-powered Data Enrichment feature is developed with responsible AI principles in mind. It was thoroughly evaluated to meet quality and ethical standards, and it's intended to enhance productivity. For more information about responsible AI practices for this agent, refer to [Responsible AI FAQ about AI-powered Data Enrichment for opportunities](FAQs-data-enrichment-agent.md).


