---
title: Use Dynamics 365 Customer Service skills in Copilot Cowork
description: Customer Service skills in Copilot Cowork streamline case workflows. Learn how to enable the Dynamics 365 plugin and boost agent productivity today.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.date: 06/16/2026
ms.update-cycle: 180-days
ms.topic: how-to
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Use Customer Service skills in Copilot Cowork

Use the plugin for Dynamics 365 Customer Service in Microsoft 365 Copilot Cowork to delegate end-to-end case workflows. The plugin assists in investigating issues and surfacing the right records, coordinating actions and triggering next steps using a single unified workspace that eliminates app-switching. By grounding every action in Microsoft 365 using Dynamics 365 context, Cowork autonomously runs service workflows on your behalf. The plugin helps unlock agent-driven productivity at scale keeping service teams in control with checkpoints while Cowork handles the complexity of multi-step, cross-system customer service processes.

For example, when you ask "Compose an escalation summary for case #12345 on what's been tried, known, and what the customer expects to assist the correct next owner or assignee", the Cowork response includes the following details:

- An escalation summary

- What the customer reported so far
- What the customer has already tried
- List of knowns
- What the customer expects
- Recommended next steps for the incoming owner
- Reason for flagging it as an escalation

## Key capabilities

- Lets you select the Dynamics 365 environment for Customer Service in Cowork so that every action surfaces correct org data.

- Extend Cowork with custom skills tailored to your team's workflows, knowledge sources, and triage rules to sharpen representative assistance.
- Every task is grounded in live Dynamics 365 case data and Microsoft 365 context such as emails, meetings, chats that requires no manual lookup.
- Checkpoints let representatives review and approve proposed field updates and actions before anything is committed to Dynamics 365.
- Cowork operates within the Dynamics 365 and Microsoft 365 permissions that are already in place per user or groups persona.

## Prerequisites

- [Dataverse MCP server](/power-apps/maker/data-platform/data-platform-mcp-disable) is enabled for your Customer Service environment.

- Microsoft 365 Copilot license to access [Cowork](/microsoft-365/copilot/cowork/cowork-admin-governance) in your organization.
- Specific licensing requirements apply to access Dynamics 365 Customer Service. Learn more in [Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/p/?LinkId=866544). While the plugin is preinstalled and available to all Cowork users, users with the appropriate license for Customer Service only can use the plugin to access the Customer Service data.

## Enable the plugin

1. In Microsoft 365 Copilot, search for and select **Cowork** in the site map.

1. In the chat composer, select plus (**+**), and then select **Customize**.
1. Turn on the **Dynamics 365 Customer Service** toggle.
1. Select the plugin to view the details like the skills available.

   :::image type="content" source="../media/cowork-plugin-customer-service.png" alt-text="Screenshot of the Cowork plugin for Customer Service" lightbox="../media/cowork-plugin-customer-service.png":::

## Select the environment

Environment selection lets you choose the Dynamics 365 environment that Cowork prompts need to use. It's useful when teams work across multiple environments for different lines of business, regions, or use cases. Your administrator can configure a default environment. You see a list of allowed environments to which you have access.

After you turn on the plugin, the settings icon is available on the plugin. Select the settings icon, and in the pop-up window, select the environment to connect.

## Use skills in Cowork

When you submit a request in Cowork, the workspace plan translates the request into a sequence of smaller actions that can run reliably and transparently. Instead of treating the prompt as one opaque task, Cowork identifies the intention, determines the systems that hold the needed data, and then invokes the appropriate plugin or skill for each step. The plan makes this visible to you by showing the order of operations.

1. In Microsoft 365 Copilot, select **Cowork**.

1. In chat composer, ask a service-related question using natural language. For example, enter "Draft a summary that lists all open cases blocked on customer reply for more than 48 hours." Cowork breaks the request into steps. It finds the open cases that are waiting on customer response for more than 48 hours and organizes the results into fields like case number, title, and days waiting.

   :::image type="content" source="../media/screenshot-cowork-response.png" alt-text="Screenshot of Cowork response for Customer Service question." lightbox="../media/screenshot-cowork-response.png":::
1. To switch environments or view the environment that's currently connected for your use, go to the **Customize** option in Cowork and do the steps mentioned in **Select the environment**. 

Some example prompts are as follows:

- Give me a one-screen brief on case #12345 - customer, product, history, prior cases.

- Compose an escalation summary for case #12345 - what's been tried, what's known, what the customer expects to assist the correct next owner or assignee.
- Draft my reply to the customer using the knowledge article that matches a specific article ID#1234.
- Find me my cases that are open > 5 days with no customer reply - diagnose each.
- Draft a reengagement reply to a customer who's gone silent on this case.

> [!NOTE]
> Service-related tool calls might require user approval before Cowork applies them.

### Skills that Cowork uses

Cowork invokes the following skills:

- **Built-in skills from WorkIQ**: Includes Microsoft Word, Microsoft Excel, Microsoft PowerPoint, PDF, email, calendar, meetings, daily briefing, enterprise search, communications, deep research, and adaptive cards.

- **Customer Service-related skills**: Includes skills that pull data and insights from Customer Service, such as case enrichment, customer-ready response drafting, and incident resolution. Learn more in [Use the AI agent](../administer/configure-customer-service-mcp-server.md#use-the-ai-agent).

- **Custom skills**: You can also create and install custom skills stored in your OneDrive. Learn more in [Create custom skills](/microsoft-365/copilot/cowork/use-cowork#create-custom-skills).

When Cowork invokes skills to complete your request, the Workspace panel shows a step-by-step plan with real-time progress. Learn more in [What displays while Cowork is working](/microsoft-365/copilot/cowork/use-cowork#what-displays-while-cowork-is-working).

### Related information

[Responsible AI FAQ for Cowork](/microsoft-365/copilot/responsible-ai/cowork-responsible-ai-faq)  
[Best practices for Cowork](/microsoft-365/copilot/cowork/best-practices)  
