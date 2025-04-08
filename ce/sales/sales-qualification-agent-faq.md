---
title: Sales qualification agent FAQ
description: Find answers to frequently asked questions about the sales qualification agent in Dynamics 365 Sales, which helps sellers qualify leads and improve sales outcomes.
ms.date: 02/19/2025
ms.topic: conceptual
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

# Sales qualification agent FAQ

This FAQ provides answers to common questions about the sales qualification agent in Dynamics 365 Sales.

<a name="icp"></a>
## What is ideal customer profile?

An ideal customer profile (ICP) is a detailed description of a target customer who would benefit the most from your company's products or services. Your ideal customer profile (ICP) might include characteristics like product type, industry, company size, and location. For instance, if your company sells advanced CRM software, your ICP might include:

- **Industry**: Technology, Financial Services, Healthcare

- **Company Size**: Mid to large-sized enterprises with 500+ employees

- **Geographic Location**: North America, Europe

- **Pain Points**: Need for improved customer relationship management, desire to streamline sales processes, requirement for robust data analytics

- **Decision Makers**: Chief Information Officer (CIO), Chief Technology Officer (CTO), Head of Sales

By focusing on leads that match this profile, you can tailor your approach to address specific needs and challenges, and increase the likelihood of a successful sale.


## Why don't I see the insights banner in the lead form?

The insights banner appears only for leads that are researched by the agent. Learn more about the [Selection criteria for research](use-sales-qualification-agent.md#selectioncriteria).


## Why did the agent pause?

The agent might pause for the following reasons:

- One or more consents required for the agent are revoked by your admin.
- There's no capacity available for the agent to process leads. Contact your admin to check the capacity and resolve the issue.

## Can I trigger the agent to process leads manually?

No, the agent processes leads automatically when any of the following events occur:

  - Lead's account is linked/updated
  - Lead's company name is updated
  - Lead's contact is linked/updated
  - New lead is created

In addition, the agent refreshes the research data of the existing leads at the configured timeframe. Learn more about refresh schedule in [Adjust the frequency of research data refresh](configure-sales-qualification-agent.md#adjust-the-frequency-of-research-data-refresh). You can view the timestamp of the last refresh in the **Lead insights** page.

## Why don't I see the **Draft email** option?

The **Draft email** option appears only in the following scenarios:

- Server-side synchronization is enabled for your organization.
- The lead's email address is available.