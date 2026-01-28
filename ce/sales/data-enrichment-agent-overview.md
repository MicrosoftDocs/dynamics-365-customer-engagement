---
title: AI-powered Data Enrichment for opportunities
description: Learn how the AI-powered Data Enrichment helps automate updating and enriching opportunity data based on recent email interactions.
ms.date: 01/19/2026
ms.update-cycle: 180-days
ms.topic: overview
ms.service: dynamics-365-sales
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

# AI-powered Data Enrichment for opportunities

The AI-powered Data Enrichment feature helps sellers and managers maintain accurate and complete opportunity data. Incomplete or outdated opportunity records can lead to missed sales, inaccurate forecasting, and inefficient deal reviews. The AI-powered Data Enrichment feature addresses this challenge by automatically analyzing recent email interactions and suggesting updates to opportunity records. This proactive approach reduces manual data entry, improves pipeline confidence, and supports more effective deal reviews and forecasting.

## How the AI-powered Data Enrichment feature works

The agent behind the AI-powered Data Enrichment feature follows these steps to analyze and enrich opportunity records:

1. **Filters opportunity records**: The agent applies the criteria defined by the admin to select relevant opportunity records for analysis.

1. **Analyze recent changes**: The agent scans emails exchanged between sellers and customers to gather context about selected opportunities. It can also leverage data from the Sales Close Agent - Research (if configured) to enhance its understanding of the opportunity.
1. **Identify missing or outdated fields**: It compares the information in the emails and Sales Close Agent - Research data with the existing opportunity records to identify any discrepancies or gaps.
1 . **Suggest updates**: The agent generates suggestions for updating opportunity fields, such as estimated close date and budget amount, and associating relevant emails. Alternatively, an admin can configure the agent to automatically update the records without any manual intervention. 
1. **Review and apply updates**: Sellers can review the suggested updates and choose to apply them to the opportunity records with a single click. In cases where automatic updates are enabled, the sellers can still review the changes made by the agent and revert them if necessary.

## How to set up and use Data Enrichment

Depending on your role, you can refer to the following articles to set up and use the AI-powered Data Enrichment feature:

| User role | Reference |
|-----------|-----------|
| Administrator | [Set up and configure AI-powered Data Enrichment](data-enrichment-agent-configure.md)<br>[Responsible AI FAQ about AI-powered Data Enrichment for opportunities](FAQs-data-enrichment-agent.md) |
| Seller | [Review and approve suggestions from Data Enrichment](use-data-enrichment-agent.md) |
| Supervisor | [Monitor leads handled by the Sales Qualification Agent](monitor-leads-by-sales-qualification-agent.md)|

## Capacity usage

The Data Enrichment feature uses the capacity allocated to your tenant to analyze your emails and opportunities and generate enrichment suggestions. You can configure either prepaid capacity or pay-as-you-go capacity for this feature. To learn more about setting up and monitoring capacity usage, see:

- [Manage consumption-based billing for agent capabilities](copilot-consumption-based-billing.md)
- [View the agent's usage consumption](/power-platform/admin/manage-copilot-studio-messages-capacity?tabs=new#use-the-summary-tab)

## Responsible AI

The AI-powered Data Enrichment feature is developed with responsible AI principles in mind. It has been thoroughly evaluated to meet quality and ethical standards, and is intended to enhance productivity. For more information about responsible AI practices for this agent, refer to [Responsible AI FAQ about AI-powered Data Enrichment for opportunities](FAQs-data-enrichment-agent.md)


