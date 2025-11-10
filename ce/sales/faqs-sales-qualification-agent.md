---
title: Responsible AI FAQ about the Research-only mode of Sales Qualification Agent
description: Get answers to frequently asked questions about the use of AI in the Research-only mode (part of Sales Qualification Agent) in Dynamics 365 Sales.
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

# Responsible AI FAQ for the Research-only mode of Sales Qualification Agent

These frequently asked questions are intended to help you understand the effect of AI on the Research-only mode of the Sales Qualification Agent in Dynamics 365 Sales.

## What is Research-only mode of the Sales Qualification Agent?

The Research-only mode of the Sales Qualification Agent automates the following tasks for sellers:

- Researches leads and their companies using configured knowledge sources, public web sources, and data in Dataverse.
- Synthesizes the research insights to provide a 360-degree view of the lead.
- Uses the research insights and data in Dataverse to evaluate the lead's fit with the sales team's ideal customer profile.
- Drafts an initial outreach email to the lead based on the research insights and lead's current interests. Sellers can review and send the draft email.

## How is the Research-only mode of the Sales Qualification Agent intended to be used?

The Research-only mode of the Sales Qualification Agent is designed to help sellers automate the research aspect of lead qualification so that they can invest more time in one-on-one interactions with top leads. The agent is intended to be used as a productivity tool to help sellers qualify leads faster and more effectively. It's not intended to replace the seller's judgment or decision-making process.

- **Selection criteria**: Admins can define the selection criteria to determine which leads should be processed by the agent.

- **Research**: For each lead, sellers can access the **Lead research** page that synthesizes insights about a lead and their company from data in Dataverse and public web sources.

- **Ideal customer profile match**: Sellers get an evaluation of why a lead matches or doesn't match their ideal customer profile.

- **Initial outreach email**: The agent drafts an initial outreach email based on the research insights and ideal customer profile match. Sellers can review and send the draft email.

## How was the Research-only mode evaluated? What metrics are used to measure performance?

The Research-only mode was carefully evaluated for each use case using curated datasets and quality metrics:

- **Research**: The agent does public web research on companies, so we used a dataset that covers different types of companies, such as public, private, start-up, and non-profit, in different industries. We evaluated the research based on a set of 15 criteria, and iterated until the agent met a threshold score of passing criteria.

- **Ideal customer profile match**: We generated a diverse range of sample leads with varying amounts of data available, then evaluated how well the agent's output matched the expected output. We iterated until the agent met a threshold accuracy score.

## What are the limitations of the Research-only mode? How can users minimize the effect of these limitations?

- Only one mode of the agent (either research-only or research and engage) can be created per organization.

- The agent works only on the out-of-the-box lead entity.

## What operational factors and settings allow for effective and responsible use of the Research-only mode?

The Research-only mode has a configuration experience that allows admins to personalize the agent to work for their specific sales team:

- Select security roles in the agent settings to determine which sellers should have access to the agent. The agent processes only the leads that are owned by sellers in the selected security roles.

- Clearly define the products your sales team sells and their value proposition to help the agent better determine the ideal customer profile fit.

- Define the attributes of your ideal customer that the agent should look for based on your sales team's target customer and the data in Dataverse.

The agent primarily operates on data that resides in Dataverse. The more information available about a lead, the better the agent's outputs are.

## Which languages are supported by the Research-only mode?

The Research-only mode is only supported in English language.