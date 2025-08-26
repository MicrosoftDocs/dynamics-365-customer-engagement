---
title: Copilot Studio agents and app registrations for sales agents
description: Learn about Copilot Studio agents and Microsoft Entra app registrations used by various Dynamics 365 Sales agents.
ms.date: 07/09/2025
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

# Copilot Studio agents and Entra app registrations for sales agents

Each agent in Dynamics 365 Sales can use multiple Microsoft Copilot Studio (MCS) agents, which are designed to handle specific tasks or capabilities. For example, a Sales Qualification Agent (SQA) can have MCS agents for outreach, readiness, and research.

When an MCS agent is created, Copilot Studio automatically generates an app registration in Microsoft Entra. These app registrations are managed at the tenant level. Learn more about app registrations at [App registration, certificates, and configuration values for Copilot Studio](/microsoft-copilot-studio/requirements-certificates-configuration-values).

The total number of app registrations depends on the number of organizations (orgs) in the tenant and the number of agents each org uses. For example, if a tenant has 30 Dynamics 365 Sales orgs and each org uses 5 agents, Copilot Studio will create 150 app registrations (30 orgs × 5 agents each = 150 registrations) in Microsoft Entra.

This article lists the Copilot Studio agents and the corresponding app registrations for all Dynamics 365 Sales agents.
 
## Sales Qualification Agent (SQA)  

The Sales Qualification Agent (SQA) helps sales teams qualify leads effortlessly by autonomously researching leads, determining if they're a good fit for further engagement, and drafting an outreach email to the lead. Learn more about SQA in [Sales Qualification Agent overview](sales-qualification-agent.md).

The Sales Qualification Agent (SQA) uses the following Copilot Studio agents:

- **D365 Sales Agent - Research**: This agent conducts research to gather insights and data that can help in understanding leads and tailoring the sales approach.
- **D365 Sales Agent - Readiness**: This agent determines if the lead is a good fit for further engagement by analyzing the lead's profile against the ideal customer profile.
- **D365 Sales Agent - Outreach**: This agent drafts an outreach email to the lead, making it easier for sales professionals to initiate contact.
- **D365 Sales Agent - Email Validation**: This agent verifies the validity of a lead's email ID and categorizes it as personal or work.

## Copilot in Dynamics 365 Sales

Copilot in Dynamics 365 Sales is a personal AI assistant that helps sales professionals be more productive by providing insights and summaries in a chat interface. Learn more in [Copilot in Dynamics 365 Sales overview](copilot-overview.md). 

Copilot uses the **Copilot in D365 Sales** Copilot Studio agent to provide these capabilities. The app registration for this agent is: **Copilot in Dynamics 365 Sales**.
