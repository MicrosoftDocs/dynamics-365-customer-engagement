---
title: Configure email settings for the Sales Qualification Agent
description: 
ms.date: 07/31/2025
ms.topic: how-to
ms.service: dynamics-365-sales
ms.custom: bap-template
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Configure email settings for the Sales Qualification Agent

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Define the instructions that the agent should use to personalize and draft emails to leads, and validate their email IDs.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Configure personalization settings

1. [Open the Sales Qualification Agent settings](open-sales-qualification-agent-settings.md) page.

1. (Optional) In the **Email instructions** section, under **Compliance**, add a compliance profile from Customer Insights – Journeys. The profiles are listed only if you have the Customer Insights – Journeys license and have set up compliance profiles. If you don't have the license, you'll see the instructions to get license. Learn more about compliance profiles in [Stay compliant with privacy regulations](/dynamics365/customer-insights/journeys/real-time-marketing-compliance-settings).

1. Turn on **Account news** to personalize the email with the latest news about the account to keep the lead engaged. 
1. Under **Personalize email based on key fields from Lead**, select the fields from the Lead table that you want the agent to use to personalize the email. Think of the information you typically include in your emails to get the lead's attention and indicate urgency. For example, you can select fields that capture the need, source, and timeline. 

## Configure email validation settings

By default, the agent uses the Email (emailaddress1) field in the Lead table to validate email addresses. If you're a using a different field to capture email addresses, you can select that field in the **Email validation** section. The drop-down lists all the email fields (including custom fields) in the Lead table.