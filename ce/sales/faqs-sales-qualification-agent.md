---
title: Responsible AI FAQ about the Sales Qualification Agent
description: Get answers to frequently asked questions about the use of AI in the Sales Qualification Agent in Dynamics 365 Sales.
ms.date: 05/20/2025
ms.custom: bap-template
ms.topic: faq
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
---

# Responsible AI FAQ for the Sales Qualification Agent

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

These frequently asked questions are intended to help you understand the effect of AI on the Sales Qualification Agent in Dynamics 365 Sales.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## What is the Sales Qualification Agent?

The Sales Qualification Agent is an AI agent that automates the following tasks for sellers:

- Researches leads and their companies using public web sources and data in Dataverse.
- Synthesizes the research insights to provide a 360-degree view of the lead.
- Uses the research insights and data in Dataverse to evaluate the lead's fit with the sales team's ideal customer profile.

When sellers choose to send an initial outreach email to a lead, the agent drafts the email based on the research insights.

## How is the Sales Qualification Agent intended to be used?

The Sales Qualification Agent is designed to help sellers automate manual aspects of lead qualification so that they can invest more time in one-on-one interactions with top leads. The agent is intended to be used as a productivity tool to help sellers qualify leads faster and more effectively. It's not intended to replace the seller's judgment or decision-making process.

- **Configuration**: Admins can configure the agent to work for specific security roles. The security roles can include sellers who sell specific products or services and target an ideal customer. Admins can also configure the attributes of the ideal customer to determine a lead's fit. 

- **Research**: For each lead, sellers can access the **Lead insights** page that synthesizes insights about a lead and their company from data in Dataverse and public web sources.

- **Ideal customer profile match**: Sellers get an evaluation of why a lead matches or doesn't match their ideal customer profile.

- **Initial outreach email**: The agent drafts an initial outreach email to the lead based on the research insights and ideal customer profile match. Sellers can review and send the draft email.

## How was the Sales Qualification Agent evaluated? What metrics are used to measure performance?

The Sales Qualification Agent was carefully evaluated for each use case using curated datasets and quality metrics:

- **Research**: The agent does public web research on companies, so we used a dataset that covers different types of companies, such as public, private, start-up, and non-profit, in different industries. We evaluated the research based on a set of 15 criteria, and iterated until the agent met a threshold score of passing criteria.

- **Ideal customer profile match**: We generated a diverse range of sample leads with varying amounts of data available, then evaluated how well the agent's output matched the expected output. We iterated until the agent met a threshold accuracy score.

## What are the limitations of the Sales Qualification Agent? How can users minimize the effect of these limitations?

- **Number of agents**: An org can contain at most one agent. Customers need to decide the security roles for which they want to activate the agent.

- **Entity**: The agent works only on the out-of-the-box lead entity.

- **Initial agent activation**: When the agent activates for the first time, it processes only the 100 most recently created leads that meet the following criteria:

  - The lead's status is open.
  - The lead is owned by a seller who's part of a security role that's assigned to the agent.
  - The lead was created in the last 14 days.

The agent can process any number of leads based on event triggers.

The agent processes leads in batches of 10, with a 15-second delay between each batch.

## What operational factors and settings allow for effective and responsible use of the Sales Qualification Agent?

The Sales Qualification Agent has a configuration experience that allows admins to personalize the agent to work for their specific sales team:

- Select security roles in the agent settings to determine which sellers should have access to the agent. The agent processes only the leads that are owned by sellers in the selected security roles.

- Clearly define the products your sales team sells and their value proposition to help the agent better determine the ideal customer profile fit.

- Define the attributes of your ideal customer that the agent should look for based on your sales team's target customer and the data in Dataverse.

The agent primarily operates on data that resides in Dataverse. The more information available about a lead, the better the agent's outputs are.

## Which languages does the Sales Qualification Agent support?

The Sales Qualification Agent supports English at this time.
