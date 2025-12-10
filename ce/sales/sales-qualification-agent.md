---
title: Sales Qualification Agent overview
description: Discover how Sales Qualification Agent in Dynamics 365 Sales automates lead research and engagement to help your team focus on high-potential opportunities.
ms.date: 09/24/2025
ms.update-cycle: 180-days
ms.topic: overview
ms.service: dynamics-365-sales
content_well_notification:
  - AI-contribution
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

# Sales Qualification Agent overview

Sales teams often struggle to keep up with the volume of inbound leads from websites, events, and webinars, leading to missed opportunities and idle leads in CRM. Sales Qualification Agent in Dynamics 365 Sales is an AI agent that automates lead qualification. It helps you qualify leads faster and more effectively, so you can spend more time interacting with your top leads. The agent doesn't replace your judgment or decision-making process.

## Sales Qualification Agent modes

Sales Qualification Agent is available in two modes:

- **Research-only mode**: Automates the research aspect of lead qualification. The agent works on assigned leads based on your selection criteria, such as lead source, rating, or geography. It provides detailed insights about each lead&mdash;their background, recent opportunities, and news about their company. The agent evaluates the lead's fit with your target customer profile and generates an initial outreach email for leads that meet your criteria. Sellers can use these insights to make informed decisions about which leads to pursue and send the outreach email to.

- **Research and engage mode**: Automates the research and engagement aspects of lead qualification. The agent helps you manage high lead volumes by researching and engaging with leads. The agent works on assigned leads based on your selection criteria, such as lead source, rating, or geography. Additionally, the agent autonomously engages with each lead, follows up, and evaluates fit based on your seller hand-off rules. Leads that demonstrate purchase intent and meet most of your criteria are handed over to sellers for qualification, while those that don’t are disqualified, ensuring your sales team focuses only on high-potential opportunities.

## Difference between Research-only and Research and engage modes

The following table summarizes the difference between the Research-only and Research and engage modes:

| Functionality                              | Research-only | Research and engage |
|--------------------------------------------|:--------:|:------:|
| Research leads                             |    ✅     |   ✅    |
| Check target customer profile criteria                         |    ✅     |   ✅    |
| Check BANT criteria                        |    ❌     |   ✅    |
| Generate outreach emails                   |    ✅     |   ✅    |
| Send outreach emails                       |    ❌     |   ✅    |
| Detect positive intent based on responses  |    ❌     |   ✅    |
| Send follow-up emails and clarify questions|    ❌     |   ✅    |
| Hand over promising leads to sellers       |    ✅     |   ✅    |
| Notify supervisors about disqualified leads |   ✅     |   ✅    |


## Understand Sales Qualification Agent concepts

The Sales Qualification Agent is designed to assist you in the lead qualification process. Here are some key concepts to understand how the agent works on leads and help you qualify leads:

**Target customer profile**: Applicable for both Research-only and Research and engage modes, the target customer profile is a set of criteria that defines the characteristics of your ideal customer. The agent uses this profile to evaluate leads and determine their fit. More information: [What is the target customer profile and how is the fit determined?](sales-qualification-agent-concepts.md#what-is-the-target-customer-profile-and-how-is-the-fit-determined)

**Purchase interest**: Applicable for the Engage mode, purchase interest is an indicator of the lead's intent to buy. The agent evaluates leads based on their engagement and interest level. More information: [What is purchase interest and how is it determined?](sales-qualification-agent-concepts.md#what-is-purchase-interest-and-how-is-it-determined)

**BANT (Budget, Authority, Need, Timeline)**: Applicable for the Engage mode, BANT is a framework used to evaluate leads based on their budget, authority, need, and timeline. The agent uses this framework to assess the lead's potential and readiness to buy. More information: [What is BANT and how is the fit calculated?](sales-qualification-agent-concepts.md#what-is-bant-and-how-is-the-fit-calculated)

## How to use the agent

The usage of the Sales Qualification Agent depends on your role in the sales process.

| User role | Reference |
|-----------|-----------|
| Administrator | [Set up and configure Sales Qualification Agent](configure-sales-qualification-agent.md)<br>[Test the Sales Qualification Agent](test-sales-qualification-agent-research-engage.md) |
| Seller | [Work on leads handed over by the Sales Qualification Agent](use-sales-qualification-agent.md) |
| Supervisor | [Monitor leads handled by the Sales Qualification Agent](monitor-leads-by-sales-qualification-agent.md)|

## Capacity usage

The Sales Qualification Agent uses the capacity assigned to your tenant to process leads and generate insights. You can set up either prepaid capacity or pay-as-you-go capacity for the agent. Use the following resources to learn more about setting up capacity and monitoring usage:  

- [Manage consumption-based billing for agent capabilities](copilot-consumption-based-billing.md)
- [View the agent's usage consumption](/power-platform/admin/manage-copilot-studio-messages-capacity?tabs=new#use-the-summary-tab)

## Responsible AI

Sales Qualification Agent is built with responsible AI principles in mind. The agent has been carefully evaluated to ensure that it meets quality standards and is designed to be used as a productivity tool. For more information about the agent's responsible AI practices, go to the following articles:  

- [Responsible AI FAQ for the Research-only mode](faqs-sales-qualification-agent.md)
- [Responsible AI FAQs about Research and engage mode](faqs-sales-qualification-agent-engage.md)

## Related information

- [Sales Qualification Agent FAQ](sales-qualification-agent-faq.md)
