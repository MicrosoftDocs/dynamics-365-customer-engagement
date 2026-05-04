---
title: MCP tools for Copilot in Dynamics 365 Sales
description: Learn about the tools available in the Sales MCP server that support the Copilot capabilities in Dynamics 365 Sales.
ms.date: 02/27/2026
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

# MCP tools for Copilot in Dynamics 365 Sales

This article lists the tools for using the Copilot capabilities. Make sure that Copilot in Dynamics 365 Sales is [configured and turned on](enable-setup-copilot.md). 

Learn more about the summaries and insights returned by the following tools in [Use Copilot in Dynamics 365 Sales](use-sales-copilot.md).

| Tool name (friendly)         | API name                                         | Purpose                                                      | Parameter(s)                | Returns                                                                                 |
|------------------------------|--------------------------------------------------|--------------------------------------------------------------|-----------------------------|-----------------------------------------------------------------------------------------|
| Recent changes tool                  | `msdyn_GetInsights`                      | Retrieve recent changes to leads, accounts, and opportunities owned by the user | None           | List of leads, accounts, and opportunities that were updated since the user's last login                                              |
| Sales record summary tool              | `msdyn_SalesRecordSummary`               | Retrieve record summary for the given record | `RecordId` (string)         | Summary of the given record based on the fields [configured by the admin](copilot-configure-summary-fields.md).                                                  |
| Sales lead catchup tool                | `msdyn_SalesLeadCatchup`                 | Retrieve recent lead updates                                 | `LeadId` (string)           | Recent changes to the given lead record for fields [configured by the admin](copilot-configure-summary-fields.md)                                                            |
| Sales account catchup tool             | `msdyn_SalesAccountCatchup`              | Retrieve recent account updates                              | `AccountId` (string)        | Recent changes to the given account record for fields [configured by the admin](copilot-configure-summary-fields.md)                                                           |
| Sales opportunity catchup tool         | `msdyn_SalesOpportunityCatchup`          | Retrieve recent opportunity updates                          | `OpportunityId` (string)    | Recent changes to the given opportunity record for fields [configured by the admin](copilot-configure-summary-fields.md)                                                       |
| SharePoint search results tool         | `msdyn_GetDocumentSearchResults`         | Search SharePoint documents for the given query             | `Query` (string)            | List of documents that contain the given query terms from the [configured SharePoint sites](copilot-sharepoint-config.md).                                                 |
| SharePoint Q&A tool                    | `msdyn_SalesAnswerFromDocuments`         | Get answers from SharePoint documents for the given query           | `Query` (string)            | Answers from SharePoint documents for the given query from the [configured SharePoint sites](copilot-sharepoint-config.md).                                                        |


## Related information

- [Connect your AI agents and assistants to Sales MCP Server](connect-agents-to-model-context-protocol.md)
- [Examples of using Sales MCP Server with AI agents and assistants](model-context-protocol-examples.md)