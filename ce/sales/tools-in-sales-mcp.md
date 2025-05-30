---
title: Tools supported by the Sales MCP Server
description: Learn how to turn on and set up Copilot in Dynamics 365 Sales. Help your sales team can get summaries of their lead and opportunity records, catch up on recent changes, and prepare for meetings.
ms.date: 05/13/2025
ms.topic: how-to
ms.service: dynamics-365-sales
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.custom:
  - bap-template
---

# Tools supported by the Sales MCP Server

This article describes the tools supported by the Model Context Protocol (MCP) server in Dynamics 365 Sales. 

| Tool Name             | Description                                                                                   | More information                                                                 |
|-----------------------|-----------------------------------------------------------------------------------------------|---------------------------------------------------------------------------------|
| ListLead             | Retrieves a list of leads. Each lead includes `leadid` or `lead ID` and all the information in detail. | [ListLead](#listlead)                                                           |
| InvokeLeadSummary    | Provides a summary of a lead.                | [InvokeLeadSummary](#invokeleadsummary)                                         |
| QualifyLeadToOpportunity | Qualifies a lead and converts it into an opportunity.                                                | [QualifyLeadToOpportunity](#qualifyleadtoopportunity)                           |
| DraftOutreachEmail   | Drafts an outreach email for a lead.     | [DraftOutreachEmail](#draftoutreachemail)                                       |
| SendOutreachEmail    | Sends the outreach email to the lead. | [SendOutreachEmail](#sendoutreachemail)                                         |
