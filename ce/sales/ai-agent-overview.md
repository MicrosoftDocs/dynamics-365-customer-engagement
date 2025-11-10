---
title: AI Agents in Dynamics 365 Sales
description: Learn about the out-of-the-box AI agents in Dynamics 365 Sales that help sales teams qualify leads and close deals faster.
ms.date: 11/10/2025
ms.update-cycle: 180-days
ms.topic: concept-article
ms.service: dynamics-365-sales
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-description
  - ai-seo-date:07/09/2025
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# AI Agents in Dynamics 365 Sales

Dynamics 365 Sales includes out-of-the-box AI agents that help sales teams qualify leads and close deals faster by autonomously researching leads and opportunities, providing insights, and engaging with customers. These agents support sales professionals in enhancing productivity and effectiveness. 

## Sales Qualification Agent

The Sales Qualification Agent helps sales teams qualify leads effortlessly by autonomously researching leads, determining if they're a good fit for further engagement, sending outreach emails, and engaging with leads. This agent is available in two modes: Research-only and Research and engage. Depending on your sales process and requirements, you can choose the mode that best fits your needs. Learn more in [Sales Qualification Agent overview](sales-qualification-agent.md). 

## Sales Close Agent

The Sales Close Agent - Research helps sales teams close deals faster by autonomously researching opportunities, providing visibility into emerging risks, and highlighting promising opportunities. Learn more in [Sales Close Agent - Research overview (preview)](opportunity-research-agent.md). 

The Sales Close Agent - Engage autonomously manages the end-to-end sales cycle for high-velocity, low-complexity deals. It engages customers, recommends products, handles objections, and drives transactions to closure using templated personalization for outreach and follow-ups. Learn more in [Sales Close Agent - Engage overview (preview)](sales-close-agent-overview.md).

## Sales Research Agent

The Sales Research Agent in Dynamics 365 Sales empowers you to solve complex business questions through a dialog with your data using natural language. This AI-powered research canvas offers rich insights into all aspect of your sales data, empowering you to make informed decisions taking a myriad of variables into account. Learn more in [Sales research agent overview (preview)](sales-research-agent.md).

## Control access to AI agents

There are three levels of control available for AI Agents in Dynamics 365 Sales. The controls are linear, meaning that if a control is disabled at a higher level, it can't be enabled at a lower level. These controls help ensure that AI Agents are used appropriately and effectively within your organization.
 
1. **Tenant-level control for environments and environment groups**: The tenant administrator can then specify which environments or environment groups can use AI Agents in Dynamics 365 Sales. This setting is also configured in the Power Platform admin center from **Copilot** > **Settings** > **Dynamics 365 Sales** > **AI Agents**.
1. **Security group-level control**: The tenant administrator can then specify which Entra groups within the tenant can use AI Agents in Dynamics 365 Sales. This setting is also configured in the Power Platform admin center from **Copilot** > **Settings** > **Control who can use AI features in model-driven apps**.
1. **App-level control**: The administrator of the Sales Hub app can then specify whether AI Agents should be enabled in the Dynamics 365 Sales. This setting is configured in the Sales Hub app from **App Settings** > **Dynamics 365 AI Hub** > **Create and manage agents** > **AI Agents**.


## FAQs about sales AI agents

- [FAQs about Sales Qualification Agent](sales-qualification-agent-faq.md)
- [FAQs about Opportunity Research Agent (preview)](opportunity-research-agent-faqs.md)
- [FAQs about Sales Research Agent (preview)](faqs-sales-research-agent.md)