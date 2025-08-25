---
title: Testing preparation and recommendations for Sales Qualification Agent
description: Learn how to test the research and engage mode of Sales Qualification Agent in Dynamics 365 Sales and evaluate its accuracy and performance.
ms.date: 06/13/2025
ms.topic: how-to
ms.service: dynamics-365-sales
ms.custom: bap-template
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
---

# Testing preparation and recommendations

To effectively test the Sales Qualification Agent, follow these recommendations in your test environment:

### Create users for each role

Ensure that your test environment includes:

| User Role     | Details                                                                 |
|---------------|-------------------------------------------------------------------------|
| **Sellers**   | 3–4 users with seller role and valid email addresses.                  |
| **Supervisors** | At least 1 user to monitor the agent and intervene when necessary.   |
| **Mock Customer** | Test contacts representing external leads with valid email addresses. You can use email IDs in your organization's domain to avoid sending emails to real customers. |

### Create test leads

Ensure your test data includes the following:

- **Company names**: Use real organization names for leads to ensure meaningful research insights. As the agent relies on public data, using fictitious names doesn't yield relevant insights as there's no public data available for those names. If you need to use a fictitious name for demonstration purposes, consider using the fictitious organization **Proseware** (https://proseware.azurewebsites.net/).

- **Selection criteria**: When you configure the agent, you define the kind of leads the agent should process. For example, you can have agent process only **Hot** leads from a **Trade Show**. 
    - At least 10 leads that meet the selection criteria.
    - At least 5 leads that don't match the criteria and hence should be excluded from agent processing.
- **Target customer profile**: When you configure the agent, you define the characteristics of your target customer. For the purpose of testing, use a simple set of criteria. For example:
  - Industry: Technology
  - Annual revenue: Over $1 million
  - Job title: C-Level Executive
  - Location: North America
-  Out of the 10 leads that meet the selection criteria, ensure you have:

    - **High fit leads**: At least 3-4 leads that match at least 70% of the target customer profile criteria. In our example, the lead should meet at least 3 of the 4 criteria.
    - **Medium fit leads**: At least 3-4 leads that match between 50% and 70% of the target customer profile criteria.
    - **Low fit leads**: At least 3-4 leads that match less than 50% of the target customer profile criteria.

- Leads must be assigned to different sellers and contain:
  - **Mock customer email ID:** Enter a valid email ID to test the agent. As the agent will send outreach and follow-up emails to this ID, use your email ID or create test email IDs in your organization's domain to avoid sending emails to real customers.
  - **Note down your assessment:** In a spreadsheet, create a list of leads with the following columns and your assessment of their target customer profile fit and selection criteria match. This will help you validate the agent's behavior against expected outcomes:
    - Lead name
    - Company name
    - Lead source
    - Lead rating (Hot, Warm, Cold)
    - Email address
    - Industry
    - Annual revenue
    - Job title
    - Location
    - Target customer profile fit (High/Medium/Low)
    - Selection criteria match (Yes/No)

## Related information:

- [Set up and configure the Sales Qualification Agent (preview)](configure-sales-qualification-agent.md)
- [Test the Sales Qualification Agent](test-sales-qualification-agent-research-engage.md)