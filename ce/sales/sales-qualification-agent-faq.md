---
title: Sales Qualification Agent FAQ
description: Find answers to frequently asked questions about the Sales Qualification Agent in Dynamics 365 Sales, which helps sellers qualify leads and improve sales outcomes.
ms.date: 07/01/2025
ms.topic: faq
ms.service: dynamics-365-sales
content_well_notification:
  - AI-contribution
ms.custom: bap-template
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Sales Qualification Agent FAQ


[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

This FAQ provides answers to common questions about the Sales Qualification Agent in Dynamics 365 Sales.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

<a name="icp"></a>

## What is the ideal customer profile and how is the ICP fit determined? 

The *ideal customer profile* (ICP) is a detailed description of a customer who would benefit the most from your company's products or services. Your ideal customer profile might include characteristics like industry, company size, job title of the lead, location, and annual revenue.

The ICP fit is determined based on the attributes defined in [the Ideal customer profile section of the agent configuration](configure-sales-qualification-agent.md#ideal-customer-profile). The agent categorizes leads into three categories based on the ICP attributes:

- **High fit**: The lead matches more than 70% of the ICP attributes. This indicates that the lead is a strong candidate for your products or services.
- **Moderate fit**: The lead matches 50% to 70% of the ICP attributes. This indicates that the lead may be a potential candidate for your products or services, and can be pursued after the high fit leads.
- **Low fit**: The lead matches less than 50% of the ICP attributes. This indicates that the lead is not a good candidate to pursue.

For instance, if your company sells software solutions for retail businesses, your ICP might include companies in the retail industry with a certain number of employees and annual revenue. The following table provides examples of ICP attributes for retail businesses:

| Criteria                     | Details                                                                                     |
|------------------------------|---------------------------------------------------------------------------------------------|
| Industries targeted          | Retail companies, including department stores, specialty retailers, e-commerce platforms, quick commerce, and grocery chains |
| Size of the customer         | 1000 to 50000+ employees                                                                  |
| Job Title of the lead | Procurement decision makers in retail industry or C-Suite executives |
| Annual revenue range         | $100 million to $10 billion+                                                               |
| Location of target customers | Urban and suburban areas in North America with high consumer traffic, except New York |

The following table provides a few sample leads and their ICP fit category based on the above attributes:

| Account Name | Industry | Company Size | Job Title | Annual Revenue | Location | ICP Fit | Reasoning |
|--------------|----------|--------------|-----------|----------------|----------|---------|-----------|
| Contoso Ltd. | Retail | 10,000 employees | Procurement Manager | $500 million | New York, NY | High fit | Matches all ICP criteria, except location as New York is excluded. |
| Fabrikam Inc. | E-commerce | 500 employees | CFO | $1 billion | San Francisco, CA | High fit | Matches all ICP criteria except company size |
| Northwind Traders | Specialty Retail | 200 employees | CEO | $80 million | Chicago, IL | Moderate fit | Matches industry, job title, and location criteria, but company size and revenue don't match. |
| Tailspin Toys | Department Store | 1000 employees | Procurement Director | $95 million | Santiago, Chile | Moderate fit | Matches industry, company size, and job title criteria, but revenue and location don't match. |
| Wingtip Toys | Manufacturing | 500 employees | Operations Manager | $150 million | Hyderabad, India | Low fit | Except for revenue, none of the ICP criteria match. |
| Blue Yonder Airlines | Aviation | 500 employees | Software engineering manager | $500 million | Suburban area, CA | Low fit | Does not match any of the ICP criteria. |

## Why don't I see the insights banner in the lead form?

The insights banner appears only for leads that the agent researched. Learn more in [Selection criteria for research](use-sales-qualification-agent.md#selection-criteria-for-research).

## Why did the agent pause?

The agent might pause for the following reasons:

- An admin revoked one or more consents the agent needs to run.
- No capacity is available for the agent to process leads. Ask your admin to check the capacity and resolve the issue.

<a name="trigger-events"></a>
## Can I trigger the agent to process leads manually?

No. The agent processes leads automatically when any of the following events occur:

- A lead is created.
- The lead's account is linked or updated.
- The lead's company name is updated.
- The lead's contact information is linked or updated.

The agent refreshes the research data of existing leads on a schedule that your admin sets. Learn more in [Set up and activate the agent](configure-sales-qualification-agent.md#set-up-and-activate-the-agent). The timestamp on the **Lead insights** page shows the last refresh date.

## What activities consume Copilot Studio capacity?

The Sales Qualification Agent uses Copilot Studio capacity for research, matching the ideal customer profile, and generating the initial outreach email.

Viewing insights that have been generated doesn't consume capacity.

<a name="cant-see-email-options"></a>
## Why don't I see the **Review email** or **Draft email** option?

The **Review email** option appears in the banner, and the **Draft email** option appears on the **Lead insights** page, only if the following conditions are met:

- Your organization is using server-side synchronization. Ask your admin if you're not sure.
- The lead's email address is available.