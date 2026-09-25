---
title: Sales Development agent overview (preview)
description: Learn how to deploy, onboard, and use the Sales Development agent in Microsoft Teams to automate sales outreach and prospect management.
ms.date: 09/25/2026
ms.topic: overview
author: sbmjais
ms.author: shjais
ai-usage: ai-assisted
---

# Sales Development agent overview (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

> [!IMPORTANT]
> The Sales Development agent is available to customers who opt into the Microsoft 365 Targeted release program. You can choose Targeted release for your entire organization, or just for selected users. For more information about opting into the program, see [Standard or Targeted release options in Microsoft 365](/microsoft-365/admin/manage/release-options-in-office-365).

The Sales Development agent automates sales outreach and prospect management within Microsoft Teams. This AI-powered agent helps sales teams scale prospecting while maintaining personalized communication.

Here's a quick demo of the Sales Development agent in action:

> [!VIDEO 7f78c18f-5526-432e-93d2-cdad8f2f8c0d]

[!INCLUDE [preview-note](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## AI processing, cross-geo data flows, and EU compliance

The Sales Development agent uses AI processing components in your selected geographic region.

When in-region processing capacity or required service components are unavailable, certain data associated with the service might be processed outside your selected geographic region.

> [!IMPORTANT]
> For customers within the EU Data Boundary, this consent doesn't modify, waive, or otherwise affect existing EU Data Boundary commitments. Those commitments remain in effect.

### Installation flow transparency notice

The Sales Development agent may route requests to different supported generative AI models based on service availability and capacity, which may include models provided by third‑party providers such as Anthropic. In certain regions, availability of the service may depend on whether required model providers are enabled at the tenant level through Microsoft 365 admin center. Disabling supported model providers may affect the functionality of Sales Development agent in those regions.

If you don't consent to potential processing of requests outside your selected geographic region or by different supported AI models:

- Don't install the Sales Development agent.
- If already installed, uninstall the Sales Development agent to revoke consent.

To manage AI providers that operate as Microsoft subprocessors in the Microsoft 365 admin center, review [this setting](/microsoft-365/copilot/connect-to-ai-subprocessor).

## Supported and unsupported content types

When you interact with the Sales Development agent in Teams, here's what works and what doesn't:

**Supported content:**

- Structured business data (CSV or Excel files).
- Text-based documents and decks (.docx, .pptx, .pdf, .txt).
- Public or internal web links (nonmedia content).
- Conversations in 1:1 Teams chats.

**Unsupported content:**

- Video or audio files.
- Image-based content (.jpg, .png).
- Group chats or Teams channels.
- Outlook threads or forwarded emails.
- Personal, confidential, or unrelated information not relevant to outreach configuration.

If you share unsupported content, such as a video file, the agent prompts: "I can't access video files. Please share a written summary or document."

## Multilingual capabilities

Sales managers in global markets often need to engage prospects in multiple languages without creating separate regional teams. Multilingual capabilities help you scale outreach into new geographies while maintaining message quality and local relevance.

The Sales Development agent can generate outreach and replies in the following 22 languages:

- Arabic
- Chinese (Simplified)
- Czech
- Danish
- Dutch
- English
- Finnish
- French
- German
- Greek
- Hebrew
- Italian
- Japanese
- Korean
- Norwegian (Bokmal)
- Polish
- Portuguese (Brazil)
- Russian
- Spanish
- Swedish
- Thai
- Turkish

Using a single configuration, the agent adapts message tone and structure for each language and market, including formality, email structure, and call-to-action style. It can also continue conversations when a prospect switches languages mid-thread.

### Configure language targeting in prospect data

When you upload a prospect list, you can include the following optional columns:

| Field | Purpose |
|---|---|
| Language | Sets the target language for each prospect. |
| Country/Region | Further tailors messaging to regional business norms within the same language (for example, Spanish for Spain versus Mexico, or French for France versus Canada). |

If you don't provide a `Language` value, the agent uses the default language configured in agent settings.

### Search and testing behavior

For personalization, the Sales Development agent automatically searches in both English and the prospect's target language.

Before live deployment, you can run simulation-based conversation testing in any supported language to validate behavior and quality.

## Sales Development agent permissions

The Sales Development agent uses the following permissions to perform its work.

### Agent 365 Tools

- McpServers.Mail.All: Allows the application to access the Mail MCP server.
- McpServers.OneDriveSharepoint.All: Allows the application to access the OneDrive and SharePoint MCP server.
- McpServers.Word.All: Allows the application to access the Word MCP server.
- McpServers.Excel.All: Allows the application to access the Excel MCP server.
- McpServers.Knowledge.All: Allows the application to access the Knowledge MCP server.
- McpServers.Teams.All: Allows the application to access the Teams MCP server.
- McpServers.Dataverse.All: Allows the application to access the Dataverse MCP server.
- McpServers.Sales.All: Allows the application to access the Sales MCP server.
- McpServersMetadata.Read.All: Allows the application to read metadata of all MCP servers.
- McpServers.SharepointLists.All: Allows the application to access the SharePoint Lists MCP server.
- McpServers.Me.All: Allows the application to access the Me MCP server.
- McpServers.CopilotMCP.All: Allows the application to access the Copilot MCP server.

### Microsoft Graph

- ChannelMessage.Read.All: Read all channel messages.
- Chat.Read: Read user chat messages.
- ChatMessage.Send: Send user chat messages.
- Files.ReadWrite.All: Have full access to all files user can access.
- Mail.ReadWrite.Shared: Read and write mail in shared folders.
- Mail.Send: Send mail.
- Sites.ReadWrite.All: Have full control of all site collections.
- User.Read.All: Read all users' full profiles.
- Chat.Create: Create chats.
- Presence.ReadWrite: Read and write your presence information.

### Power Platform Environment Service

- user_impersonation: Allows users to access all APIs.

### Dataverse

- user_impersonation: Allows the application to access Common Data Service.

### Power Platform API

- Connectivity.Connections.Read: Read connections.
- CopilotStudio.Copilots.Invoke: Invoke Copilot Studio Copilots.

### Messaging Bot API Application

- AgentData.ReadWrite: Allows read/write of agent data.

## Current limitations of the Sales Development agent

The following table outlines current limitations of the Sales Development agent in Agent 365:

| Area | How it works |
|------|----------------------------|
| Teams chat | Supports only 1:1 chats between the agent's creator and the agent. Other people can't chat with the agent. |
| Communication channels | The agent interacts with users only through email and Teams chats. It doesn't support conversations in Teams Channels, comments in documents, Teams meetings, or other channels. |
| Email threads | The agent replies only to email threads that it starts. It ignores email sent to it unless it started the thread. |
| Renaming | You can change the agent's name and email address in the Microsoft 365 admin center. |
| Data ingestion | Supports SharePoint, OneDrive, and web links, but not recursive crawling or media files. |
| Analytics | No built-in visual reporting dashboards; shares progress via Teams chat. |
| Human oversight | Once launched, runs autonomously until stopped. |
| Testing scope | Validation limited to Teams 1:1 chat. |
| Automatic progression | Doesn't automatically switch from testing to pilot. |
| Email sending | Sends emails at all hours, including weekends. |

## Submit feedback

If you have any questions about the product, AI-generated content, or need help configuring your agent, contact us at [salesagentteam@microsoft.com](mailto:salesagentteam@microsoft.com).