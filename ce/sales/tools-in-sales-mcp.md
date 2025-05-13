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


## ListLead

Use this tool to search for leads based on various criteria such as `email`, `leadid`, or `rating`.

### Input schema

    ```json
    {
    "email": "string",  // Required: Use this to search for a lead by their email address.
    "leadid": "string", // Optional: Use this to search for a lead by its unique ID.
    "rating": "string"  // Optional: Use this to filter leads based on their rating.
    }
    ```
### Output

Lists leads based on the specified criteria. Each lead includes the following details:


## InvokeLeadSummary

Use this tool to retrieve a comprehensive summary of a lead using Copilot in Dynamics 365 Sales, including contact info and interaction history.

### Input schema

    ```json
    {
    "leadid": "string" // Required: Use this to specify the unique ID of the lead you want to summarize.
    }
    ```

### Output

Displays a summary of the lead, including the following details:


## QualifyLeadToOpportunity

Use this tool to qualify a lead and convert it to an opportunity, with options to create associated account and contact records.

### Input Schema

{
  "type": "object",
  "properties": {
    "leadId": { "type": "string" },
    "createAccount": { "type": "boolean" },
    "createContact": { "type": "boolean" },
    "createOpportunity": { "type": "boolean" },
   },
  "required": ["leadId"]
}

### Output

Opportunity: ID, name
Account: AccountName
New Contact: ContactName, Email

## DraftOutreachEmail

Use this tool to draft an outreach email for a lead, including the subject and body of the email.

### Input Schema:
{
  "type": "object",
  "properties": {
    "leadId": { "type": "string" },
   },
  "required": ["leadId"]
}

### Output

Draft outreach email with subject and body.

## SendOutreachEmail

Use this tool to send an outreach email to a lead.

### Input Schema:

### Output

Outreach email sent through Dynamics 365 Sales, ensuring it's tracked for engagement.  