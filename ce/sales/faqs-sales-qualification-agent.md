---
title: Responsible AI FAQs for the Sales qualification agent
description: Get answers to frequently asked questions about the Sales qualification agent in Dynamics 365 Sales, which helps sellers qualify leads and improve sales outcomes.
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

# Responsible AI FAQs for the Sales qualification agent

These frequently asked questions are intended to help you understand the impact of AI on the Sales qualification agent in Dynamics 365 Sales.

## What is Sales qualification agent?

The Sales qualification agent is an AI agent that automates the following tasks for sellers:

- Researches leads and their companies using public web sources and data in Dataverse.
- Synthesizes the research insights to provide a 360-degree view of the lead.
- Evaluates the lead's fit with the sales team's ideal customer profile (ICP) based on the research insights and data in Dataverse.

When sellers choose to send an initial outreach email to a lead, the agent drafts the email based on the research insights.

## How is the Sales qualification agent intended to be used?

The Sales qualification agent is designed to help sellers automate manual tasks so that sellers can invest more time in one-on-one interactions with top leads. Here are some key use cases for copilot agents:

- **Configuration**: The admin can configure the agent to work for specific security roles. The security roles can include sellers who sell specific products or services and target a particular ideal customer profile. Admins can also configure the ideal customer profile attributes and web sites that the agent should look through to get the research insights. 
- **Research**: For each lead, sellers can access the **Lead insights** page that synthesizes insights about a lead and their company from data in Dataverse and public web sources.  
- **Ideal customer profile match**: Sellers get an evaluation for why a lead matches or doesn't match their ideal customer profile.
- **Initial outreach email**: The agent drafts an initial outreach email to the lead based on the research insights and ideal customer profile match, which sellers can review and send.

## How was the Sales qualification agent evaluated? What metrics are used to measure performance?

The Sales qualification agent was carefully evaluated for each use case using curated datasets and quality metrics:

- **Research**: The agent does public web research on companies, so we used a dataset covering different types of companies (public, private, start-up, non-profit, etc.) across different industries. We evaluated the research based on a set of 15 criteria, and iterated until we met a threshold score of passing criteria.
- **Ideal customer profile match**: Generated a diverse range of synthetic leads with varying amounts of data available to evaluate if the output of the agent matched the expected output. Iterated until an accuracy threshold was surpassed.

## What are the limitations of the Sales qualification agent? How can users minimize the impact of these limitations?

- *Number of agents*: Only one agent can be created per org. Customers need to decide the security roles for which they want to activate this agent.
- *Entity*: Agent only works on the out of box lead entity.
- *Initial agent activation*: When the agent gets activated for the first time, only the 100 most recently created leads that meet the following criteria get processed: 
    - Lead status is open
    - Lead is owned by a seller who is part of a security role assigned to the agent.
    - Lead is created in the last 14 days. The leads are processed in batches of 10, with a 15-second delay between each batch.

There's no limit to the number of leads that can be processed based on event triggers.

## What operational factors and settings allow for effective and responsible use of the Sales qualification agent?

The Sales qualification agent has a configuration experience that allows an admin to personalize the agent to work for their specific sales team:

- Select which sellers should have access to the agent by selecting their security roles in the agent settings. The agent processes only the leads that are owned by sellers in the selected security roles.

- Clearly define the products and value proposition of the products and/or services that your sellers sell. These details help the agent better determine the ideal customer profile fit.
- Define the ideal customer profile attributes that the agent should look for based on your sales team's target customer and the data you have available in Dataverse.
- The agent primarily operates on data that resides in Dataverse – the more information available about a lead, the better your outputs are.

## Which languages are supported by the Sales qualification agent?

Currently, the Sales qualification agent is only supported in English. 