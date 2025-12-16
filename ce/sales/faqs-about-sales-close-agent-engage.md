---
title: FAQs about Sales Close Agent - Engage (preview)
description: Get to know answers to frequently asked questions about the Sales Close Agent - Engage in Dynamics 365 Sales.
ms.date: 11/07/2025
ms.topic: overview
ms.service: dynamics-365-sales
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-description
  - ai-seo-date:08/04/2025
author: udaykirang    
ms.author: udag
ms.reviewer: udag
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# FAQs about Sales Close Agent - Engage (preview)

These frequently asked questions (FAQ) describe the AI impact of Sales Close Agent - Engage feature in Dynamics 365 Sales.  

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## What is Sales Close Agent - Engage?  

The Sales Close Agent Engage is an autonomous, configurable sales agent that personalizes customer outreach, automates follow-ups, answers product questions using approved knowledge sources like sales training content and product specs, addresses objections and comparisons, and drives buyers to complete transactions, such as on an e-commerce site. If a buyer asks for a human, it hands off via a defined escalation process.  

**Inputs (high-level)**:  

- Lead/contact list and basic buyer context.
- Product catalog/specs, pricing, FAQs, and objection-handling guidance.
- Sales playbook, including intents, tactics, voice/tone, and escalation rules.
- Channel and cadence settings, such as email-first and follow-up windows.
- Compliance and brand guardrails.

**Outputs (high-level)**:  

- Outreach and follow-up messages, grounded answers, and comparison summaries.
- Product recommendations and purchase link click-through actions (CTAs).
- CRM/e-commerce events (clicks, orders, escalations) and analytics.
- Escalation tickets and notes when a supervisor is requested or thresholds are met.

## What are capabilities of the Sales Close Agent - Engage?  

- **Autonomous outreach and follow-ups**: Generates first-touch and multi-touch follow-ups.  
- **Grounded Q&A**: Answers questions using the provided knowledge sources.  
- **Objection handling**: Detects common objections (price, fit, timing, and risk) and responds with playbook-approved tactics and proof points.  
- **Intent detection and playbook adherence**: Maps buyer utterances to intents or topics and selects the correct tactic per the playbook.  
- **Purchase intent detection and CTA**: Recognizes buying signals, shares purchase links, and nudges to check out. Tracks click-through and conversions.  
- **Escalation handling**: When asked or when risk or uncertainty thresholds trip, routes to a supervisor with conversation context and suggested next actions.  

## What is the intended use of the Sales Close Agent - Engage?  

The Sales Close Agent - Engage is intended to be used by sales organizations looking for a cost-efficient approach to fully automating sales.  

## How is Sales Close Agent - Engage evaluated? What metrics are used to measure performance?  

The Sales Close Agent – Engage is evaluated per use case with curated datasets, synthetic scenarios, limited pilots, and a rubric that emphasizes groundedness, playbook adherence, and sales best practices. Conversion metrics such as the following parameters are used to measure performance:  

- **Engagement rate**: (Replies classified as interest/qualified) ÷ total replies.
- **Click-through rate (CTR)**: (Unique clicks on in-email links) ÷ delivered.
- **Win rate**: (How many deals were closed) ÷ (How many were disqualified).  
- **Total number of records (leads, accounts, contacts, or opportunities) managed by agent**.

## What are the limitations of Sales Close Agent - Engage, and how can I minimize their impact when using the system?

**Only one agent** can be created per org. You must decide the record type for which you want to activate this agent. Select the [records based on segmentation criteria](configure-sales-close-agent-target-customers.md) to process them with the agent.  

## What operational factors and settings allow for effective and responsible use of the feature?  

The Sales Close Agent - Engage has a configuration experience that allows an admin to personalize the agent to work for a specific sales team:  

- Select the leads, contacts, accounts, or opportunities the agent targets by choosing segments for the agent.  
- Define the products and their value proposition for your sellers.  
- Update the agent playbook with intents and instructions for each intent.  
- Provide knowledge sources to support the agent's answers.  

## How do I provide feedback on the Sales Close Agent - Engage?  

The Sales Close Agent – Engage, which focuses on autonomous engagement, primarily interacts with end customers. As a result, we don't provide an end-user pathway for feedback. Customers of Dynamics 365 Sales who have feedback on the agent can follow the existing pathways for feedback collection in the application by selecting the global command ribbon in the Dynamics 365 Sales app and choosing **Dynamics 365 Community Feedback**, **Share Feedback**, or **Submit an Idea**.
 