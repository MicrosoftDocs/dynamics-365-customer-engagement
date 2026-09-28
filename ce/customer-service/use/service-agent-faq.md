---
title: Frequently asked questions about Service Agent
description: Review answers to common questions about using Service Agent in Dynamics 365 Customer Service.
ms.date: 09/26/2026
author: lalexms
ms.author: laalexan
ms.collection: bap-ai-copilot
ms.topic: faq
ms.reviewer: laalexan
ms.update-cycle: 180-days
ms.custom: bap-template
---

# Frequently asked questions about Service Agent

## General

### What is Service Agent?

Service Agent is a Microsoft 365 Copilot agent that helps customer service representatives find, summarize, and update customer service information. You can use natural language to ask questions, summarize cases, draft communications, and complete supported tasks in Copilot Service workspace and other supported Copilot experiences.

Service Agent is also a Microsoft 365 Copilot agent. You can use Service Agent in Microsoft 365 Copilot and Copilot Service workspace to retrieve, summarize, and update customer service information and complete supported service-related tasks.

### How is Service Agent different from Copilot in Customer Service?

Service Agent provides AI assistance in Dynamics 365 Customer Service through a dedicated agent in Microsoft 365 Copilot. It provides capabilities for retrieving and summarizing customer service information, finding knowledge, drafting communications, and completing supported service-related tasks. Service Agent is available in Microsoft 365 Copilot, Copilot Service workspace, and other supported Microsoft 365, Dynamics 365, and Power Apps experiences where Copilot is enabled.

### What tools can Service Agent use?

Service Agent uses Dynamics 365 Customer Service Model Context Protocol (MCP) tools to access customer service data and perform supported service-related actions. These tools support scenarios such as case management, customer information, knowledge management, email assistance, activities and conversations, and other service operations. Service Agent can also provide interactive experiences such as file upload, image generation, charts, and Microsoft Word, Excel, and PowerPoint creation. The tools available to you depend on the configuration of Service Agent and the Dataverse security privileges assigned to you.

### Do I need to enable Service Agent, or is it on automatically?

Your administrator must configure Service Agent before you can use it. In Copilot Service workspace, Service Agent is selected automatically as the active agent in the Copilot pane. If Service Agent isn't available, contact your administrator.

### Is Service Agent available in all languages?

Service Agent supports the following languages:
- Arabic
- Chinese (Simplified)
- Czech
- Danish
- Dutch
- English (United States)
- Finnish
- French
- German
- Greek
- Hebrew
- Italian
- Japanese
- Korean
- Norwegian (Bokmål)
- Polish
- Portuguese (Brazil)
- Russian
- Spanish
- Swedish
- Thai
- Turkish

## Using Service Agent

### How do I start a conversation with Service Agent?

When you open Copilot Service workspace, Service Agent is selected automatically in the Copilot pane. Type your question or request in the message box and press **Enter**. You can also select one of the starter prompts available when you first open Service Agent.

Learn more in [Use starter prompts in Service Agent](use-service-agent-starter-prompts.md)

### Can I reference a specific case or record in my prompt?

Yes. Type "/" in the message box to search for and reference supported records, such as cases, contacts, and other Dataverse records directly in your prompt. Service Agent uses the referenced record as context when generating its response.

Learn more in [Reference records and context in Service Agent](reference-records-service-agent.md)

### Why do my starter prompts already include case details?

When you're working on a case, Service Agent automatically includes relevant case information, such as the case number and title, in starter prompts so you don't have to enter it manually.

### Can I save prompts I use frequently?

Yes. You can save prompts to the prompt gallery for future use and share them with others in your organization.

Learn more in [Use the prompt gallery in Service Agent](use-service-agent-prompt-gallery.md).

### Can I upload files to Service Agent?

Yes. You can upload files and ask Service Agent questions about them. Service Agent can also generate Word, Excel, and PowerPoint files, create images, and generate charts.

### What happens to my conversation when I navigate away from a case?

When you return to a case, Service Agent automatically restores your most recent conversation for that case so you can continue where you left off.

Learn more in [Return to a previous Service Agent conversation](service-agent-return-conversation.md).

## Availability and access

### Can I use Service Agent in Outlook?

Yes. Service Agent can use the currently open email thread in Outlook as context to summarize messages, draft replies, answer questions, and recommend next steps.

Learn more in [Use Service Agent with Outlook](use-service-agent-outlook.md).

### What's required to provision and use Service Agent?

Your Microsoft 365 administrator installs the Service app from the Microsoft 365 admin center, and an administrator who manages the Dynamics 365 Customer Service environment completes the configuration. Specific licensing requirements apply when you use Service Agent.

Learn more in [Configure Service Agent](../administer/configure-service-agent.md).

### Can my administrator control which tools are available?

Yes. Administrators can configure which Service Agent tools are available. Access to Dynamics 365 Customer Service MCP tools is governed by Dataverse security privileges, so the tools available to you depend on your assigned security roles and privileges. Administrators can also extend Service Agent with Model Context Protocol (MCP) tools and Microsoft Copilot Studio agents.

## Related information

- [Service Agent overview](service-agent-overview.md)
