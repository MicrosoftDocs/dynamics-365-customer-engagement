---
title: Overview of Dynamics 365 Customer Service MCP tools
description: Learn what MCP tools are available in Dynamics 365 Customer Service, what they do, and which personas use them.
ms.date: 06/30/2026
ms.topic: overview
author: lalexms
ms.author: laalexan
ms.reviewer: gandhamm
search.audienceType: 
  - developer
---

# Overview of Dynamics 365 Customer Service MCP tools

Dynamics 365 Customer Service Model Context Protocol (MCP) tools provide standardized business actions that AI-powered experiences can use to access customer service data and perform service-related operations. These tools help connect a conversational AI experience, such as Service Agent, with Dynamics 365 Customer Service and Dataverse so users can complete tasks through natural language interactions.

Service representatives and supervisors don't typically use MCP tools directly. Instead, these users interact with an AI-powered experience, such as Service Agent. The agent determines which tool to use, invokes the tool in the background, and presents the result to the user in chat or through an app-in-chat component.

For example, when a service representative asks Service Agent to summarize a case, the agent can use the appropriate case-related MCP tools to retrieve and summarize the information. The representative sees the result in the conversational experience and doesn't need to know the internal tool name or call the tool directly.

MCP tools can support interactive app-in-chat experiences. In these experiences, the result of a tool is shown inside the chat as an interactive component, where users can review the information and take supported follow-up actions.

## Key uses

Organizations can use Dynamics 365 Customer Service MCP tools to enable AI-powered customer service experiences across several scenarios.

### Case management

MCP tools can help retrieve, search, update, assign, and resolve customer cases. These tools support scenarios where users need quick access to case details, related activities, next actions, or resolution workflows.

### Customer information access

MCP tools can retrieve and summarize customer information such as accounts, contacts, and related records. This capability helps users understand customer context during service interactions.

### Knowledge management

MCP tools can support knowledge-related tasks such as searching knowledge articles, retrieving article details, drafting knowledge content, and publishing articles. These capabilities help users find and reuse knowledge while resolving customer issues.

### Email assistance

MCP tools can support AI-assisted email workflows such as drafting, editing, rewriting, translating, and sending emails. For example, an email rewrite tool can return revised email content in an app-in-chat component so the user can review the text before saving or sending it.

### Activity and conversation management

MCP tools can help you create activities, add notes, view timelines, and summarize conversations or customer interactions. These capabilities help you capture and review service context without manually navigating across multiple records.

### Administration and configuration

Some MCP tools support administrative tasks such as managing environments, agent configurations, MCP registrations, profiles, tool selections, and user preferences. These tools are more relevant to administrators and developers who configure or maintain AI-powered service experiences.

## Personas

### Service representatives

Service representatives use AI-powered experiences, such as Service Agent, to complete customer service tasks through natural language. They don't need to call MCP tools directly or understand internal tool names.

Common tasks include:

- Retrieve case details.
- Summarize customer interactions.
- Find relevant knowledge articles.
- Draft or refine customer emails.
- Add notes or create activities.
- Resolve or update cases.

### Supervisors

Supervisors use AI-powered experiences, such as Service Agent, to review service activity, monitor escalations, understand case context, and support service teams. Like service representatives, supervisors typically interact with Service Agent rather than individual MCP tools.

Common tasks include:

- Reviewing case or queue activity.
- Understanding escalated or high-priority issues.
- Getting summaries of customer service interactions.
- Monitoring autonomous agent activity through supervisory experiences.
- Taking follow-up actions based on service insights.

### Administrators

Administrators configure and maintain the environments and settings that support AI-powered customer service experiences. They might work with tools or configuration experiences related to environments, profiles, registrations, and tool selections.

Common tasks include:

- Configuring customer service environments.
- Managing agent configurations.
- Managing MCP registrations.
- Configuring user preferences or profile settings.
- Enabling or maintaining AI-powered service experiences.

### MCP app developers and agent developers

MCP app developers and agent developers are the primary personas who work directly with the MCP tool catalog. They use tools as reusable building blocks to create conversational applications, app-in-chat components, and AI agent workflows.

Common tasks include:

- Build app-in-chat components that present tool results to users.
- Orchestrate multiple MCP tools into end-to-end workflows.
- Decide how tool responses should appear in the user experience.
- Build conversational experiences for case management, knowledge assistance, email workflows, and service operations.
- Design experiences that use available tools at runtime rather than hard-coding dependencies on specific tool names or schemas.

## Privileges, access, and security considerations

Access to Dynamics 365 Customer Service MCP tools is governed by Dataverse security privileges. A user must hold all of the privileges that a tool requires before that tool becomes discoverable to the AI-powered experience. Tools that aren't mapped to specific privileges are discoverable by default. Privileges are also enforced when a tool runs, so a tool can be discoverable yet still be denied at execution time if the underlying record or action isn't permitted.

Because each tool maps to one or more privileges, administrators can use security roles to control which capabilities are available to service representatives, supervisors, administrators, and developers.

Dynamics Customer Service MCP server is extensible by design.

> [!IMPORTANT]
> When you connect to non-Microsoft MCP servers, you do so at your own risk. Microsoft has no responsibility related to your use of non-Microsoft MCP servers, and you're responsible for any associated terms and charges. Some of your data might be passed to the non-Microsoft MCP server, or your MCP client might receive data from the non-Microsoft MCP server. You're responsible for managing whether your data flows outside your organization's compliance and geographic boundaries.
> 
> MCP implementations are vulnerable to attacks, cascading failures, and loss of human oversight. To mitigate these risks, vet MCP servers for security and reliability, follow Microsoft's recommendations and industry best practices, and implement approval mechanisms to monitor cascading behaviors.

## Available tools

Learn more about the available MCP tools in [Service Agent tools](../../developer/reference/mcp-tools/summarize_account.md).
