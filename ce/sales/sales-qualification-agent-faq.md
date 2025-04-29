---
title: Sales Qualification Agent FAQ
description: Find answers to frequently asked questions about the Sales Qualification Agent in Dynamics 365 Sales, which helps sellers qualify leads and improve sales outcomes.
ms.date: 02/19/2025
ms.topic: faq
ms.service: dynamics-365-sales
content_well_notification:
  - AI-contribution
ms.custom:
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/04/2023
  - bap-template
  - ai-gen-description
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Sales Qualification Agent FAQ

This FAQ provides answers to common questions about the Sales Qualification Agent in Dynamics 365 Sales.

<a name="icp"></a>
## What is the ideal customer profile?

The *ideal customer profile* is a detailed description of a customer who would benefit the most from your company's products or services. Your ideal customer profile might include characteristics like product type, industry, company size, and location.

For instance, if your company sells advanced customer relationship management software, your ideal customer profile might include the following attributes:

- **Industry**: Technology, Financial Services, Healthcare

- **Company Size**: Mid- to large-sized enterprises with 500+ employees

- **Geographic Location**: North America, Europe

- **Pain Points**: Need for improved customer relationship management, desire to streamline sales processes, requirement for robust data analytics

- **Decision Makers**: Chief Information Officer, Chief Technology Officer, Head of Sales

By focusing on leads that match this profile, you can tailor your approach to address their specific needs and challenges and increase the likelihood of a successful sale.

## Why don't I see the insights banner in the lead form?

The insights banner appears only for leads that the agent researched. Learn more in [Selection criteria for research](use-sales-qualification-agent.md#selection-criteria-for-research).

## Why did the agent pause?

The agent might pause for the following reasons:

- An admin revoked one or more consents the agent needs to run.
- No capacity is available for the agent to process leads. Ask your admin to check the capacity and resolve the issue.

## Can I trigger the agent to process leads manually?

No. The agent processes leads automatically when any of the following events occur:

- The lead's account is linked or updated.
- The lead's company name is updated.
- The lead's contact information is linked or updated.
- A lead is created.

The agent refreshes the research data of existing leads on a schedule that your admin sets. Learn more in [Set up and activate the agent](configure-sales-qualification-agent.md#set-up-and-activate-the-agent). The timestamp on the **Lead insights** page shows the last refresh date.

## What activities consume Copilot Studio capacity?

The Sales Qualification Agent uses Copilot Studio capacity for research, matching the ideal customer profile, and generating the initial outreach email.

Viewing insights that have been generated doesn't consume capacity.

<a name="cant-see-email-options"></a>
## Why don't I see the **Review email** or **Draft email** option?

The **Review email** option appears in the banner, and the **Draft email** option appears on the **Lead insights** page, only if the following conditions are met:

- Your organization is using server-side synchronization. Ask your admin if you're not sure.
- The lead's email address is available.
