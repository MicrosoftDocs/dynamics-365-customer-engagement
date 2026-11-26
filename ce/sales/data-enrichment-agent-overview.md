---
title: AI-powered Data Enrichment for Contact, Opportunity, Lead, and Account records
description: Learn how the AI-powered Data Enrichment helps automate updating and enriching Contact, Opportunity, Lead, and Account record data based on recent email interactions and Teams meeting conversations.
ms.date: 09/08/2026
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

# AI-powered data enrichment for contact, opportunity, lead, and account records

The AI-powered Data Enrichment feature helps sellers and managers maintain accurate and complete contact, opportunity, lead, and account records. Incomplete or outdated supported records can lead to missed sales, inaccurate forecasting, and inefficient deal reviews. The AI-powered Data Enrichment feature addresses this challenge by automatically analyzing recent email interactions and Teams meeting conversations, then suggesting or making updates to supported records. This proactive approach reduces manual data entry, improves pipeline confidence, and supports more effective deal reviews and forecasting.

## How the AI-powered Data Enrichment feature works

The agent behind the AI-powered Data Enrichment feature follows these steps to analyze and enrich supported records:

1. **Filter supported records**: The agent applies the user and record selection criteria that the admin defines to select relevant supported records for analysis.

1. **Analyze recent changes**: The agent scans emails exchanged between sellers and customers, as well as Teams meeting transcripts and AI-generated meeting summaries, to gather context about selected records. It looks for context and deal-related information such as budget, authority, need, and timeline that can help enrich the supported records.
1. **Identify missing or outdated fields**: The agent compares the information in the emails with the existing supported records to identify any discrepancies or gaps.  
1. **Suggest updates**: The agent generates suggestions for updating record fields, such as estimated close date and budget amount, and associating relevant emails. Alternatively, an admin can configure the agent to automatically update the records without any manual intervention. 
1. **Review and apply updates**: Sellers can review the suggested updates and choose to apply them to the supported records with a single click. In cases where automatic updates are enabled, the sellers can still review the changes made by the agent and revert them if necessary.

## Enrichment behavior by record type

The Data Enrichment agent enriches records differently depending on the record type:

| Record type | Enrichment behavior |
|-------------|---------------------|
| **Opportunity** | Full enrichment: The agent generates field update suggestions based on emails and Teams meeting interactions. |
| **Lead** | Full enrichment: The agent generates field update suggestions based on emails and Teams meeting interactions. |
| **Contact** | Partial enrichment: The agent enriches a fixed set of five out-of-the-box fields (such as phone number, job title, email address, and preferred contact method) only when the contact is identified as the sender of an email or the organizer of a meeting. |
| **Account** | No field enrichment: Relevant emails and meetings are automatically linked to the account's activity timeline, but no field update suggestions are generated. |

> [!NOTE]
> Stakeholder identification (suggesting contacts as stakeholders) is supported for Opportunity and Lead records only.

## How to set up and use Data Enrichment

Depending on your role, refer to the following articles to set up and use the AI-powered Data Enrichment feature:

| User role | Reference |
|-----------|-----------|
| Administrator | [Set up and configure AI-powered Data Enrichment](data-enrichment-agent-configure.md)<br>[Edit AI-powered Data Enrichment settings](data-enrichment-agent-edit-settings.md)<br>[Responsible AI FAQ about AI-powered Data Enrichment](FAQs-data-enrichment-agent.md) |
| Seller | [Review and approve Data Enrichment suggestions](use-data-enrichment-agent.md) |


## Capacity usage

AI-powered Data Enrichment runs as a background process that monitors seller emails and Teams meetings. It doesn't process all emails or meetings, but focuses on those relevant to supported records that the sellers own. 

**Example:** Assuming a scenario where a seller receives around 100 emails per day with the following distribution: 

- 35 are internal emails, which are skipped by the agent.
- 25 are from external contacts who aren't registered in the system, thus treated as personal and not processed by the agent.
- 15 are already linked to existing supported records, so the agent processes them for potential data enrichment.
- 25 are from external contacts registered in the system but aren't linked to any supported records. The agent processes these emails for potential record matching and enrichment.  

In addition to emails, the agent also processes Teams meetings where the primary contact linked to a supported record was an attendee.

The credit consumption depends on the number of emails and meeting transcripts the agent processes for matching and enriching supported records. To learn more about setting up capacity and monitoring usage, see:

- [Manage consumption-based billing for agent capabilities](copilot-consumption-based-billing.md)
- [View the agent's usage consumption](/power-platform/admin/manage-copilot-studio-messages-capacity?tabs=new#use-the-summary-tab)

## Responsible AI

The AI-powered Data Enrichment feature is developed with responsible AI principles in mind. The development team thoroughly evaluated the feature to ensure it meets quality and ethical standards, and it's designed to enhance productivity. For more information about responsible AI practices for this agent, see [Responsible AI FAQ about AI-powered Data Enrichment](FAQs-data-enrichment-agent.md).


