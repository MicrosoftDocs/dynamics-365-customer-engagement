---
title: Responsible AI FAQs about Research and engage mode of Sales Qualification Agent
description: Get answers to frequently asked questions about the use of AI in the Research and engage mode (part of Sales Qualification Agent) in Dynamics 365 Sales.
ms.date: 08/11/2025
ms.update-cycle: 180-days
ms.custom: bap-template
ms.topic: faq
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
---

# Responsible AI FAQs about Research and engage mode of Sales Qualification Agent

These frequently asked questions help you understand the impact of AI on the Research and engage mode (part of Sales Qualification Agent) in Dynamics 365 Sales.

## What is the Research and engage mode in Copilot?

The Research and engage mode automates the sales development workflow by dynamically researching, engaging, and answering questions to determine lead intent and hands over qualified leads to sales. It proactively gathers insights from internal and external sources, enabling data-driven decision-making. The agent focuses on lower priority leads that sellers can't manage due to volume, helping qualify and convert them into opportunities. The agent engages with leads simultaneously through personalized emails and follow-ups, ensuring consistent and efficient outreach. By identifying buying intent, it transitions leads further along the sales journey, allowing sellers to focus on high-potential opportunities. This intelligent automation enhances efficiency and improves conversion rates, making the sales qualification process more effective and scalable.

## How is the Research and engage mode intended to be used?

The agent is designed to help sellers automate manual tasks so they can invest more time in 1-on-1 interactions with top leads. Rather than act on behalf of sellers, the agent proactively works on leads by sending outreach and follow-up emails and determining lead intent.

**Key use cases:**

- Proactively researches information from internal and external sources.
- Engages hundreds of leads at once with personalized emails and follow-ups.
- Disqualifies leads that don't match the handoff criteria.
- Hands over leads that show positive buying intent to sellers for further engagement and qualification.

## How was the Research and engage mode evaluated? What metrics are used to measure performance?

The agent was evaluated for each use case using curated datasets and quality metrics:

- **Research:** Evaluated using a dataset covering various company types and industries, based on 15 criteria, iterated until a passing threshold was met.
- **Ideal customer profile match:** Used synthetic leads to test output accuracy, iterated until accuracy threshold was surpassed.
- **Outreach:** Generated personalized emails and evaluated quality based on binary, evaluative, and comparative criteria, iterated until pass rates and similarity scores were met.
- **Follow up:** Generated responses based on customer emails and knowledge articles, handed over to human sellers when needed, and evaluated groundedness using search results and LLM ratings.

## What are the limitations of the Research and engage mode? How can users minimize the impact of these limitations?

- Only one mode of the agent (either research-only or research and engage) can be created per organization.

- The agent only works on the out-of-box lead entity.

## What operational factors and settings allow for effective and responsible use of the Research and engage mode?

The Research-only mode has a configuration experience that allows admins to personalize the agent to work for their specific sales team:

- Select which leads should be processed by the agent by defining the selection criteria. 
- Clearly define products and value propositions to help the agent determine ideal customer profile fit and personalize outreach.
- Define ideal customer profile attributes based on target customers and available data in Dataverse.
- Define budget, authority, need, and timeline (BANT) criteria to determine the lead's fit to qualify.
- Configure internal and external knowledge sources to help the agent research leads and draft outreach and follow-up emails.
- The agent primarily operates on data in Dataverse&mdash;the more information available about a lead, the better the outputs.

## Which languages are supported by the Research and engage mode?

The Research and engage mode is only supported in English language.

## What data is passed to Bing Search?

The agent uses Bing Search to find information about your lead from the public web and generate insights. The agent only passes the lead's company name, website URL, and any Dataverse fields that you manually define in the configuration settings to Bing Search.
