---
title: Responsible AI FAQs about the Engage Agent
description: Get answers to frequently asked questions about the use of AI in the Engage Agent (part of Sales Qualification Agent) in Dynamics 365 Sales.
ms.date: 05/20/2025
ms.update-cycle: 180-days
ms.custom: bap-template
ms.topic: faq
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
---

## Responsible AI FAQs about the Engage Agent

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

These frequently asked questions help you understand the impact of AI on the Engage Agent (part of Sales Qualification Agent) in Dynamics 365 Sales.

### What is the Engage Agent in Copilot?

The Engage Agent automates the sales development workflow by dynamically researching, engaging, and answering questions to determine lead intent and handover qualified leads to sales. It proactively gathers insights from internal and external sources, enabling data-driven decision-making. The agent focuses on lower priority leads that sellers can't manage due to volume, helping qualify and convert them into opportunities. The agent engages with leads simultaneously through personalized emails and follow-ups, ensuring consistent and efficient outreach. By identifying buying intent, it transitions leads further along the sales journey, allowing sellers to focus on high-potential opportunities. This intelligent automation enhances efficiency and improves conversion rates, making the sales qualification process more effective and scalable.

### How is the Engage Agent intended to be used?

The agent is designed to help sellers automate manual tasks so they can invest more time in 1-on-1 interactions with top leads. Rather than act on behalf of sellers, the agent proactively works on leads and qualifies them by sending outreach and follow-up emails.

**Key use cases:**

- Proactively researches information from internal and external sources.
- Engages hundreds of leads at once with personalized emails and follow-ups.
- Identifies buying intent and transitions leads further along the journey to sellers.

### How was the Engage Agent evaluated? What metrics are used to measure performance?

The agent was evaluated for each use case using curated datasets and quality metrics:

- **Research:** Evaluated using a dataset covering various company types and industries, based on 15 criteria, iterated until a passing threshold was met.
- **Ideal customer profile match:** Used synthetic leads to test output accuracy, iterated until accuracy threshold was surpassed.
- **Outreach:** Generated personalized emails and evaluated quality based on binary, evaluative, and comparative criteria, iterated until pass rates and similarity scores were met.
- **Follow up:** Generated responses based on customer emails and knowledge articles, handed off to human sellers when needed, and evaluated groundedness using search results and LLM ratings.

### What are the limitations of the Engage Agent? How can users minimize the impact of these limitations?

- Only one agent can be created per organization. Customers must decide which leads to activate the agent for, using segmentation criteria.
- The agent only works on the out-of-box lead entity.

### What operational factors and settings allow for effective and responsible use of the Engage Agent?

Admins can personalize the agent for a specific sales team:

- Select which leads should have access to the agent by choosing segments.
- Clearly define products and value propositions to help the agent determine ideal customer profile fit and personalize outreach.
- Define ideal customer profile attributes based on target customers and available data in Dataverse.
- The agent primarily operates on data in Dataverse&mdash;the more information available about a lead, the better the outputs.

### Which languages are supported by the Engage Agent?

The Engage Agent is currently supported only in English.
