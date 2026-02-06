---
title: AI-powered Data Enrichment for opportunities (preview)
description: Learn how the AI-powered Data Enrichment helps automate updating and enriching opportunity data based on recent email interactions.
ms.date: 02/06/2026
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

# AI-powered Data Enrichment for opportunities (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

The AI-powered Data Enrichment feature helps sellers and managers maintain accurate and complete opportunity data. Incomplete or outdated opportunity records can lead to missed sales, inaccurate forecasting, and inefficient deal reviews. The AI-powered Data Enrichment feature addresses this challenge by automatically analyzing recent email interactions and suggesting or making updates to opportunity records. This proactive approach reduces manual data entry, improves pipeline confidence, and supports more effective deal reviews and forecasting.

> [!NOTE]
> Data Enrichment currently supports only emails stored in Dataverse. Ensure that your admin [enabled server-side synchronization](configure-email.md) for emails to leverage this feature.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## How the AI-powered Data Enrichment feature works

The agent behind the AI-powered Data Enrichment feature follows these steps to analyze and enrich opportunity records:

1. **Filters opportunity records**: The agent applies the criteria that the admin defines to select relevant opportunity records for analysis.

1. **Analyze recent changes**: The agent scans emails exchanged between sellers and customers to gather context about selected opportunities. It looks for context and deal-related information such as budget, authority, need, and timeline that can help enrich the opportunity records.
1. **Identify missing or outdated fields**: The agent compares the information in the emails with the existing opportunity records to identify any discrepancies or gaps.  
1. **Suggest updates**: The agent generates suggestions for updating opportunity fields, such as estimated close date and budget amount, and associating relevant emails. Alternatively, an admin can configure the agent to automatically update the records without any manual intervention. 
1. **Review and apply updates**: Sellers can review the suggested updates and choose to apply them to the opportunity records with a single click. In cases where automatic updates are enabled, the sellers can still review the changes made by the agent and revert them if necessary.

## How to set up and use Data Enrichment

Depending on your role, refer to the following articles to set up and use the AI-powered Data Enrichment feature:

| User role | Reference |
|-----------|-----------|
| Administrator | [Set up and configure AI-powered Data Enrichment](data-enrichment-agent-configure.md)<br>[Responsible AI FAQ about AI-powered Data Enrichment for opportunities](FAQs-data-enrichment-agent.md) |
| Seller | [Review and approve suggestions from Data Enrichment](use-data-enrichment-agent.md) |
| Supervisor | [Monitor leads handled by the Sales Qualification Agent](monitor-leads-by-sales-qualification-agent.md)|


## Capacity usage

The AI-powered Data Enrichment feature uses the capacity assigned to your tenant only to analyze unlinked emails and associate them with opportunity records. This feature uses the Sales Close Agent's capability for email analysis and suggestions, so the capacity usage is tracked under the Sales Close Agent in the Power Platform admin center.  

Use the following resources to learn more about setting up capacity and monitoring usage:  

- [Manage consumption-based billing for agent capabilities](copilot-consumption-based-billing.md)
- [View the agent's usage consumption](/power-platform/admin/manage-copilot-studio-messages-capacity?tabs=new#use-the-summary-tab)

## Responsible AI

The AI-powered Data Enrichment feature is developed with responsible AI principles in mind. It was thoroughly evaluated to meet quality and ethical standards, and it's intended to enhance productivity. For more information about responsible AI practices for this agent, refer to [Responsible AI FAQ about AI-powered Data Enrichment for opportunities](FAQs-data-enrichment-agent.md).


