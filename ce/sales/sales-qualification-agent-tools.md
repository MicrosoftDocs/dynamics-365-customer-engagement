---
title: MCP tools for Sales Qualification Agent capabilities
description: Learn about the tools available in the Sales MCP server that support the Sales Qualification Agent capabilities in Dynamics 365 Sales.
ms.date: 11/17/2025
ms.update-cycle: 180-days
ms.topic: how-to
ms.service: dynamics-365-sales
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.custom: bap-template
ai-usage: ai-assisted
---

# MCP tools for Sales Qualification Agent capabilities

This article lists the tools for using the Sales Qualification Agent capabilities. Make sure that the agent is [configured and turned on](configure-sales-qualification-agent.md).

Learn more about the insights returned by the following tools in [Lead research page](use-sales-qualification-agent.md#lead-research-page).

| Tool name (friendly)         | API name                                         | Purpose                                                      | Parameter(s)                | Returns                                                                                 |
|------------------------------|--------------------------------------------------|--------------------------------------------------------------|-----------------------------|-----------------------------------------------------------------------------------------|
| Account research tool        | `mcp_sales-mcp-ser_get_account_research`         | Retrieve comprehensive account research data                 | `msdyn_EntityId` (guid)     | Financial information, company overview, strategic goals, recent news                   |
| Competitor research tool     | `mcp_sales-mcp-ser_get_competitor_research`      | Retrieve competitor research and competitive landscape       | `msdyn_EntityId` (guid)     | Competitive threats, market positioning, alternative suppliers                          |
| Engagement analysis tool     | `mcp_sales-mcp-ser_get_engage_summary`           | Retrieve engagement summary and interaction history for a lead | `msdyn_LeadId` (string)     | Engagement patterns, touchpoint analysis, interaction effectiveness                     |
| Lead qualification tool      | `mcp_sales-mcp-ser_get_lead_qualification_assessment` | Get comprehensive lead qualification assessment against target customer profile criteria | `LeadId` (string)           | Target customer profile standards evaluation, qualification ranking, overall assessment  |
| Lead research tool           | `mcp_sales-mcp-ser_get_lead_research`            | Retrieve detailed lead research and individual prospect analysis | `msdyn_LeadId` (string)     | Professional background, decision-making authority, preferences                         |
| Outreach email generation tool | `mcp_sales-mcp-ser_draft_outreach_email`        | Draft personalized sales qualification agent outreach emails | `LeadId` (string)           | Personalized email subject and body with company-specific insights                      |
