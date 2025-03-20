---
title: FAQ about responsible AI in sales qualification agent
description: Get answers to frequently asked questions about the sales qualification agent in Dynamics 365 Sales, which helps sellers qualify leads and improve sales outcomes.
ms.date: 10/14/2024
ms.custom:
  - responsible-ai-faqs
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/03/2023
  - bap-template
ms.topic: faq
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
---

# FAQ about sales qualification agent

These frequently asked questions are intended to help you understand the impact of AI on the sales qualification agent in Dynamics 365 Sales.

## What is the sales qualification agent in Copilot?

The sales qualification agent is an AI agent that automates manual jobs in the sales process. They can be configured to act on behalf of a sales team to:

- Research leads
- Determine lead fit with the sales team's ideal customer profile

## How is the sales qualification agent intended to be used?

The sales qualification agent is designed to help sellers automate manual tasks so that sellers can invest more time in 1 on 1 interactions with top leads. Rather than act on behalf of sellers, the agent proactively finds and surfaces top leads along with actions that sellers can quickly review and approve. Here are some key use cases for copilot agents:

- **Configuration**: The agent can be configured to work only for a specific "team" of sellers (i.e., sellers who are part of security roles defined by the admin in settings) that sell specific products or services and target a particular ideal customer profile.
- **Research**: For each lead, sellers can access the **Lead insights** page that synthesizes insights about a lead and their company from data in Dataverse and the public web.
- **Ideal customer profile match**: Sellers get an evaluation for why a lead matches or doesn't match their ideal customer profile.

## How was the sales qualification agent evaluated? What metrics are used to measure performance?

The sales qualification agent was carefully evaluated for each use case using curated datasets and quality metrics:

- **Research**: The agent does public web research on companies, so we used a dataset covering different types of companies (public, private, start-up, non-profit, etc.) across different industries. We evaluated the research based on a set of 15 criteria, and iterated until we met a threshold score of passing criteria.
- **Ideal customer profile match**: Generated a diverse range of synthetic leads with varying amounts of data available to evaluate if the output of the agent matched the expected output. Iterated until an accuracy threshold was surpassed.

## What are the limitations of the sales qualification agent? How can users minimize the impact of these limitations?

- *Number of agents*: Only 1 agent can be created per org. Customers will need to decide the sellers for whom they want to activate this agent.
- *Entity*: Agent only works on the out of box lead entity.
- *Initial agent activation*: When the agent gets activated for the first time, only the 100 most recently created leads that meet the following criteria will get processed: (a) lead status is open, (b) lead is owned by a seller who is part of a security role assigned to the agent, (c) lead is 14 days old or newer. The leads will be processed in batches of 10, with a 15 second delay between each batch.
- *Overnight lead processing*: Agent processes leads overnight to make sure that outputs are up-to-date. At most 200 leads that meet the following criteria can be processed overnight:

  - Lead status is open
  - Lead is owned by a seller who is part of a security role assigned to the agent
  - Lead has been created in the last 14 days. The newest leads are processed first

- *Ad hoc lead processing*: Agent processes leads "ad hoc" based on event triggers that cause outputs to change:

  - Lead's account is linked/updated
  - Lead's company name
  - Lead's contact is linked/updated
  - New lead is created

There's no limit to the number of leads that can be processed ad hoc.

## What operational factors and settings allow for effective and responsible use of the sales qualification agent?

The sales qualification agent has a configuration experience that allows an admin to personalize the agent to work for their specific sales team:

- Select which sellers should have access to the agent by selecting security roles for the agent. Any sellers who have the selected security roles will have access to the agent, and it follows that any leads owned by these sellers will get processed by the agent.
- Clearly define the products and value proposition of the products and/or services that your sellers sell. This will help the agent better determine ideal customer profile fit.
- Define the ideal customer profile attributes that the agent should look for based on your sales team's target customer and the data you have available in Dataverse.
- The agent primarily operates on data that resides in Dataverse – the more information available about a lead, the better your outputs will be.

## Which languages are supported by the sales qualification agent?

The sales qualification agent is currently only supported in English.