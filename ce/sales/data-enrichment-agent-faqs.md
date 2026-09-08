---
title: FAQs about AI-powered Data Enrichment 
description: Explore frequently asked questions about AI-powered Data Enrichment in Dynamics 365 Sales and how it transforms your CRM data into valuable insights.
ms.date: 09/08/2026
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

# FAQs about AI-powered Data Enrichment 

This article provides answers to frequently asked questions about the AI-powered Data Enrichment feature in Dynamics 365 Sales.

## How does enrichment work for different record types?

AI-powered Data Enrichment supports the following record types, with varying levels of enrichment:

- **Opportunity**: The agent generates field update suggestions based on email and Teams meeting interactions.
- **Lead**: The agent generates field update suggestions based on email and Teams meeting interactions.
- **Contact**: The agent enriches a fixed set of five default fields (such as phone number, job title, email address, and preferred contact method) only when the contact is identified as the sender of an email or the organizer of a meeting.
- **Account**: No field enrichment. The agent automatically links relevant emails and meetings to the account's activity timeline.

For Opportunity and Lead records, admins can configure which fields the agent enriches. For Contact records, the enriched fields are fixed and can't be configured. 

## What are eligible records for enrichment?

Eligible records for enrichment are those that meet the following criteria as defined by the admin in the [Data Enrichment settings](data-enrichment-agent-edit-settings.md):

- The record is of a supported type (Opportunity, Lead, Contact, or Account).
- The record is owned by a seller who has access to the Data Enrichment agent. 
- The record meets the selection criteria defined by the admin in the Data Enrichment settings.
- The record has relevant email or Teams meeting interactions that the agent can analyze to generate suggestions.

## What data does AI-powered Data Enrichment use?

AI-powered Data Enrichment uses data from the following sources:

- **Dataverse data**: Information stored in your organization's Microsoft Dataverse environment, including configured CRM entities such as accounts, contacts, leads, and opportunities.
- **Email data**: Customer emails stored in Microsoft 365, which the feature analyzes to extract context and relevant information.
- **Teams meeting data**: Teams meeting transcripts and AI-generated meeting summaries stored in Microsoft 365. AI-generated summaries are used when the seller has access to Microsoft 365 Copilot; otherwise, meeting transcripts are used.

AI-powered Data Enrichment only accesses fields and entities that have been approved by administrators through configuration settings. Data access is constrained by user roles and permissions configured in Dynamics 365. The feature does not have access to all data in your environment by default.

The quality and completeness of enrichment suggestions depend directly on the quality, completeness, and currency of the source data available, including the comprehensiveness of conversation history.

## What data is sent outside the organization?

AI-powered Data Enrichment processes data within your Dynamics 365 environment and does not send customer data, email content, or CRM records outside your organization's tenant for enrichment purposes.

All data processing occurs within Microsoft's cloud infrastructure in accordance with your organization's tenant configuration and Microsoft's data handling policies. Data residency and compliance settings configured for your Dynamics 365 environment apply to AI-powered Data Enrichment operations.

## How frequently does AI-powered Data Enrichment update supported records?

The agent analyzes emails and generates suggestions every 4 hours. For manual updates, sellers can review suggestions as soon as they're generated. For automatic updates, changes are applied based on the enrichment frequency, which is set to **Daily** by default. This frequency can't be changed.

## How do I know if my administrator has enabled manual updates or automatic updates?

## How do I know if my administrator enabled manual updates or automatic updates?
Check the update mode in the [Data Enrichment pane](use-data-enrichment-agent.md) when you review suggestions for a supported record:
- If you see options to accept or reject suggestions, then manual updates are enabled.
- If you see options to keep or undo changes, then automatic updates are enabled.

## Why can't I see the AI-powered Data Enrichment suggestions?

If you don't see suggestions, it could be due to several reasons:

- **Configuration settings**: Your administrator might not have configured the feature. 
- **User permissions**: It's possible that you are not a part of the group that has access to view suggestions. 
- **Data Enrichment disabled**: The record owner might have disabled Data Enrichment for their account.
    - If you're the owner of the record, ensure that you [enable Data Enrichment suggestions](use-data-enrichment-agent.md#disable-data-enrichment-suggestions) to allow the agent to analyze your emails and access your Teams meeting data.
    - If you're looking at a record that you don't own, it's possible that the owner of that record disabled the Data Enrichment agent or doesn't have access to the Data Enrichment feature.
- **Data availability**: There might not be sufficient data or relevant email or Teams meeting interactions to generate suggestions for that record.

## Which Teams meetings does Data Enrichment analyze?

Data Enrichment analyzes Teams meetings where the primary contact associated with the supported record attended the meeting. The agent matches attendees by email address to contacts linked to the record. Only meetings where the primary contact's email corresponds to a meeting attendee are mapped to the record and analyzed.

The type of meeting data used depends on the seller's license:

- **With Microsoft 365 Copilot license**: The agent uses AI-generated meeting summaries.
- **Without Microsoft 365 Copilot license**: The agent uses meeting transcripts.

## Can all users see the calendar event citation in Data Enrichment suggestions?

No. When a suggestion is generated from an actual Teams meeting, the Data Enrichment pane shows a citation that links to the calendar event. Only users who attended the meeting can see this citation. Users who weren't part of the meeting can't see or access the calendar event citation.

## How do I disable Data Enrichment suggestions for my account?

You can [disable Data Enrichment](use-data-enrichment-agent.md#disable-data-enrichment-suggestions) at any time. After disabling it, the agent stops reading your emails and meeting data, and it doesn't generate new suggestions for your supported records.

## Why did my data enrichment suggestions disappear?

If you previously saw suggestions from AI-powered Data Enrichment but no longer see them, it could be due to the following reasons:

- **Suggestions were applied:** If you or another user applied the suggestions to the supported records, they no longer appear.
- **Suggestions were dismissed:** If suggestions were dismissed by users, they will not be shown again.
- **Suggestions are more than 180 days old:** Suggestions are retained for only 180 days. Suggestions generated more than 180 days ago are automatically deleted and no longer appear in the Data Enrichment pane.
