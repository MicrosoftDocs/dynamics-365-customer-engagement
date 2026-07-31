---
title: Copilot Studio agents and app registrations for sales agents
description: Learn about Copilot Studio agents and Microsoft Entra app registrations used by various Dynamics 365 Sales agents.
ms.date: 07/30/2026
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

Each agent in Dynamics 365 Sales can use multiple skill-based agents in Microsoft Copilot Studio, which are designed to handle specific tasks or skills. For example, a Sales Qualification Agent can have skill-based agents for outreach, readiness, and research.

When you provision a skill-based agent, Copilot Studio automatically generates an app registration in Microsoft Entra. You manage these app registrations at the tenant level. To learn more about app registrations, see [App registration, certificates, and configuration values for Copilot Studio](/microsoft-copilot-studio/requirements-certificates-configuration-values).

The total number of app registrations depends on the number of organizations (orgs) in the tenant and the number of agents each org uses. For example:

1. **Number of Dynamics 365 Sales orgs in the tenant**: 30 
1. **Number of agents per org**: 5 
1. **Total app registrations**: 30 orgs × 5 agents = **150 app registrations** in Microsoft Entra

This article lists the skill-based agents in Copilot Studio for each Dynamics 365 Sales agent.


## Sales Qualification Agent

The Sales Qualification Agent helps sales teams qualify leads effortlessly by autonomously researching leads, determining if they're a good fit for further engagement, and drafting an outreach email to the lead. Learn more in [Sales Qualification Agent overview](sales-qualification-agent.md).

The Sales Qualification Agent provisions the following skill-based agents in Copilot Studio for both research-only and research and engage modes:

| Agent | Description |
|-------|-------------|
| **D365 Sales Agent - Research** (`msdyn_SalesResearch`) | Conducts research to gather insights and data that can help in understanding leads and tailoring the sales approach. |
| **D365 Sales Agent - Competitor** (`msdyn_SalesCompeteResearch`) | Analyzes competitors related to the lead, providing valuable information that can be used to position offerings effectively. |
| **D365 Sales Agent - Custom Research** (`msdyn_SalesCustomization`) | Performs research on custom topics as specified by the sales team to gather specific insights relevant to their sales strategy. |
| **D365 Sales Agent - Readiness** (`msdyn_SalesReadiness`) | Determines if the lead is a good fit for further engagement by analyzing the lead's profile against the target customer profile. Shared across Sales Qualification Agent and Sales Close Agent. |
| **D365 Sales Agent - Email Validation** (`msdyn_SalesEmailValidation`) | Verifies the validity of a lead's email ID and categorizes it as personal or work. Shared across Sales Qualification Agent, Sales Close Agent, and Sales Opportunity Agent. |
| **D365 Sales Agent - Outreach** (`msdyn_SalesOutreach`) | Drafts an outreach email to the lead, making it easier for sales professionals to initiate contact. Shared across Sales Qualification Agent and Sales Close Agent. |
| **D365 Sales Agent - Engage Autonomous** (`msdyn_SalesEngage`) | Autonomously engages with leads and answers their questions using knowledge sources configured by the administrator. Shared across Sales Qualification Agent and Sales Close Agent. |
| **D365 Sales Agent - TCP Prefill Agent** (`msdyn_SalesTCPPrefillAgent`) | Auto-generates the Target Customer Profile (TCP) based on the company description and value proposition. |
| **D365 Sales Agent - Stakeholder Research** (`msdyn_StakeholderResearch`) | Identifies and researches key stakeholders within the lead's organization to provide insights that can help in building relationships. Shared across Sales Qualification Agent and Sales Opportunity Agent. |
| **D365 Sales Agent - Summary Synthesizer** (`msdyn_SalesAgentSummarySynthesizer`) | Synthesizes summaries of research findings and insights to provide a concise overview for sales professionals. Shared across Sales Qualification Agent, Sales Close Agent, and Sales Opportunity Agent. |
| **D365 Sales Agent - Company Resolver** (`msdyn_SalesCompanyResolver`) | Resolves and enriches company data for leads by looking up company information such as industry, size, and location to support qualification research. |
| **Sales Qualification Agent Config Assistant** (`msdyn_SQASetupAgent`) | Guides administrators through the configuration and setup of the Sales Qualification Agent, helping to define target customer profiles and configure agent settings. |

## Sales Close Agent

The Sales Close Agent helps sales teams close deals faster by autonomously researching opportunities, provides visibility into emerging risks, and engages with customers for outreach and follow-up. Learn more in [Sales Close Agent overview](sales-close-agent.md).

The Sales Close Agent provisions the following skill-based agents in Copilot Studio:

| Agent | Description |
|-------|-------------|
| **Sales Close Agent** (`msdyn_SalesIntentEngage`) | Orchestrates the deal-closing process by understanding and routing user intents, coordinating with other agents to deliver insights and facilitate sales activities. |
| **Email draft generation** (`msdyn_salesEmailGenerator`) | Generates professional email drafts for customer follow-up and outreach, supporting sales professionals in maintaining communication throughout the deal cycle. |
| **D365 Sales Agent - Email Validation** (`msdyn_SalesEmailValidation`) | Verifies the validity of a customer's email ID and categorizes it as personal or work. Shared across Sales Qualification Agent, Sales Close Agent, and Sales Opportunity Agent. |
| **D365 Sales Agent - Engage Autonomous** (`msdyn_SalesEngage`) | Autonomously engages with customers and answers their questions using knowledge sources configured by the administrator. Shared across Sales Qualification Agent and Sales Close Agent. |
| **D365 Sales Agent - Outreach** (`msdyn_SalesOutreach`) | Drafts outreach emails to customers, making it easier for sales professionals to follow up on opportunities. Shared across Sales Qualification Agent and Sales Close Agent. |
| **D365 Sales Agent - Readiness** (`msdyn_SalesReadiness`) | Assesses deal readiness by analyzing the opportunity against key criteria to help determine the likelihood of closing. Shared across Sales Qualification Agent and Sales Close Agent. |
| **D365 Sales Agent - Summary Synthesizer** (`msdyn_SalesAgentSummarySynthesizer`) | Synthesizes summaries of research findings and insights to provide a concise overview for sales professionals. Shared across Sales Qualification Agent, Sales Close Agent, and Sales Opportunity Agent. |

## Sales Opportunity Agent

The Sales Opportunity Agent helps sales teams manage and advance open opportunities by autonomously researching accounts, competitors, and stakeholders, and by providing actionable insights throughout the sales cycle. Learn more in [Sales Opportunity Agent overview](sales-opportunity-agent.md).

The Sales Opportunity Agent provisions the following skill-based agents in Copilot Studio:

| Agent | Description |
|-------|-------------|
| **Sales Opportunity Agent** (`msdyn_SalesOpportunityResearchAgent`) | Conducts research on opportunities by analyzing account data, competitive landscape, and stakeholder information to provide comprehensive insights for sales professionals. |
| **Sales Opportunity Agent - Account Research** (`msdyn_OpportunityAccountResearch`) | Researches the accounts associated with an opportunity, providing insights on company background, recent news, and strategic information to support deal progression. |
| **Sales Opportunity Agent - Custom Research** (`msdyn_SalesOpportunityResearchCustomizationAgent`) | Performs research on custom topics as specified by the sales team to gather specific insights relevant to the opportunity. |
| **Sales Opportunity Agent - Compete Research** (`msdyn_SalesCloseCompeteResearchAgent`) | Analyzes competitors related to the opportunity, providing competitive intelligence to help position offerings effectively. |
| **Sales Opportunity Agent - Stakeholder** (`msdyn_SalesStakeholderAgent`) | Maps and profiles key stakeholders involved in the opportunity to help sales professionals navigate the decision-making process and build strategic relationships. |
| **D365 Sales Agent - Stakeholder Research** (`msdyn_StakeholderResearch`) | Identifies and researches key stakeholders within the opportunity's organization to provide insights that can help in building relationships. Shared across Sales Qualification Agent and Sales Opportunity Agent. |
| **D365 Sales Agent - Email Validation** (`msdyn_SalesEmailValidation`) | Verifies the validity of a contact's email ID and categorizes it as personal or work. Shared across Sales Qualification Agent, Sales Close Agent, and Sales Opportunity Agent. |
| **D365 Sales Agent - Summary Synthesizer** (`msdyn_SalesAgentSummarySynthesizer`) | Synthesizes summaries of research findings and insights to provide a concise overview of the opportunity for sales professionals. Shared across Sales Qualification Agent, Sales Close Agent, and Sales Opportunity Agent. |

## Copilot in Dynamics 365 Sales

Copilot in Dynamics 365 Sales is a personal AI assistant that helps sales professionals be more productive by providing insights and summaries in a chat interface. Learn more in [Copilot in Dynamics 365 Sales overview](copilot-overview.md). 

Copilot uses the **Copilot in D365 Sales** Copilot Studio agent to provide these capabilities. The app registration for this agent is: **Copilot in Dynamics 365 Sales**.
