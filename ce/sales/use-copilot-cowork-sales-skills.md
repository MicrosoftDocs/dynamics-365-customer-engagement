---
title: Use Dynamics 365 Sales skills in Copilot Cowork
description: Dynamics 365 Sales Skills in Copilot Cowork help teams prep for meetings, review pipeline, and act faster. Learn what they do and how to enable and use them.
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.date: 07/14/2026
ms.topic: how-to
ms.update-cycle: 180-days
ai.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Use Dynamics 365 Sales skills in Copilot Cowork 

Dynamics 365 Sales skills in Microsoft 365 Copilot Cowork deliver insights and recommendations based on your sales data and Microsoft 365 context such as emails, meetings, and collaboration activity. Use Cowork to handle complex tasks that pull data from multiple sources—Dynamics 365 records, knowledge bases, email, and meetings. Cowork works within Microsoft 365, analyzes your Dynamics 365 data, and keeps you in control throughout the process. All insights are based on your data and the permissions you have in Dynamics 365 Sales, ensuring that you only see information you're authorized to access.

For example, you can ask "*Prepare me for the Contoso Inc's Renewal. Surface deal risks, competitive signals, and missing stakeholders. Build a PowerPoint based on the insights.*" Cowork gets the context from Dynamics 365 Sales and Microsoft 365, draws insights based on the data, and generates a PowerPoint deck with the insights and recommendations.  

To learn how you can use Copilot Cowork to do multistep tasks that pull data from multiple sources, including Dynamics 365 Sales and Customer Service, watch the following video:  

:::image type="content" source="media/agentic-platform-mechanics-video.png" alt-text="Thumbnail of the Agentic Platform Mechanics video" link="https://youtu.be/wGBHAclqhG8?t=272"::: 

## Key capabilities 

- Lets you select the Dynamics 365 Sales environment in Cowork so that every action surfaces correct org data.

- Extend Cowork with user-specific custom skills stored in OneDrive.

- Every task is grounded in live Dynamics 365 Sales data and Microsoft 365 context such as emails, meetings, chats that requires no manual lookup.

- Cowork operates within the Dynamics 365 and Microsoft 365 permissions that're already in place per user or groups persona.


## Prerequisites 

**For administrators:**

- [Dataverse MCP server](/power-apps/maker/data-platform/data-platform-mcp-disable) is enabled for your environment. The plugin for Dynamics 365 Sales in Cowork uses the Dataverse MCP server to access your Dynamics 365 Sales data.

- [Cowork](/microsoft-365/copilot/cowork/cowork-admin-governance) is available for your organization. 
- The plugin for Dynamics 365 Sales in Cowork is preinstalled and available for all users who have access to Cowork. However, users with the appropriate Dynamics 365 Sales license only can use the plugin to access their Dynamics 365 Sales data.
 
**For users:**

- An appropriate Microsoft 365 Copilot license to access Cowork. 
- An appropriate license to access a Dynamics 365 Sales environment. 

## Enable the plugin

To use the sales skills in your Cowork experience, turn on the plugin for Dynamics 365 Sales in Cowork. 

1. In Microsoft 365 Copilot, select the **Cowork** tab. 
1. In the chat composer, select the **+** button and then select **Customize**.
1. Turn on the toggle for **Dynamics 365 Sales**.
1. Select the plugin to view the details like the skills available.
   :::image type="content" source="media/cowork-sales-plugin.png" alt-text="Screenshot of Cowork Manage Plugins page with the Dynamics 365 Sales plugin listed.":::

## Select the environment

Environment selection lets you choose the Dynamics 365 environment that Cowork prompts need to use. It's useful when you work across multiple environments for different lines of business, regions, or use cases. You see a list of allowed environments to which you have access.

After you turn on the plugin, the settings icon is available on the plugin. Select the settings icon, and in the pop-up window, select the environment to connect.

:::image type="content" source="media/cowork-environment-selection.png" alt-text="Screenshot of the plugin page with the Settings option highlighted.":::

## Use sales skills in Cowork

When you submit a request in Cowork, the workspace plan translates the request into a sequence of smaller actions that can run reliably and transparently. Instead of treating the prompt as one opaque task, Cowork identifies the intention, determines the systems that hold the needed data, and then invokes the appropriate skill for each step. The plan makes this visible to you by showing the order of operations.

1. In Microsoft 365 Copilot, select the **Cowork** tab. 
1. Ask a sales-related question in natural language. You need not specify that you want to use the Dynamics 365 Sales plugin in your prompt. If the question is related to sales and the plugin is enabled, Cowork automatically uses the plugin to answer your question. The following screenshot shows the response from Cowork for the prompt "*Help me prepare for my upcoming meeting with Adatum Corp, what should I know?*" 
   :::image type="content" source="media/copilot-cowork-response.png" alt-text="Screenshot of response from Cowork with a step-by-step plan and real-time progress for a sales-related question.":::

If you want to know the environment that Cowork is pulling data from, or if you want to change it, refer to [Select the environment](#select-the-environment).

Some example prompts to try are as follows:  

- Help me prepare for my meeting with Contoso. 
- Which of my deals slipped this week and why? 
- Summarize everything that changed on my top opportunities since I was on leave. 
- Which leads have stopped responding and what’s a good re-engagement angle? 
- Which reps are behind on activity and which metrics matter most? 
- Which segments are underperforming and what’s the pattern? 

## Supported scenarios

The following scenarios are examples of how you can use the Dynamics 365 Sales skills in Cowork to save time and be more productive:

- Understand customer, opportunity, and pipeline context. 

- Prepare for customer meetings and account reviews. 
- Identify changes, risks, blockers, and engagement gaps. 
- Prioritize opportunities, leads, and customer activities. 
- Generate follow-up recommendations and customer communications. 
- Analyze pipeline health, team performance, and sales trends. 
- Receive recommendations and next-best actions grounded in business data. 

## Skills that Cowork uses

Cowork invokes the necessary skills based on the user's prompt such as the following:

**Built-in skills from WorkIQ:**  Includes Microsoft Word, Microsoft Excel, Microsoft PowerPoint, PDF, email, calendar, meetings, daily briefing, enterprise search, communications, deep research, and adaptive cards.

**Dynamics 365 Sales-related skills:** Includes skills that pull data and insights from Dynamics 365 Sales, such as meeting preparation, activity synthesis, and pipeline prioritizer.

**Custom skills:** Includes custom skills, if any, stored in your OneDrive. Learn more in [Create custom skills](/microsoft-365/copilot/cowork/use-cowork#create-custom-skills).

When Cowork invokes skills to complete your request, the Workspace panel shows a step-by-step plan with real-time progress. For more information, refer to [What displays while Cowork is working](/microsoft-365/copilot/cowork/use-cowork#what-displays-while-cowork-is-working).

### Related information

- [Responsible AI FAQ for Cowork](/microsoft-365/copilot/responsible-ai/cowork-responsible-ai-faq)
- [Best practices for Cowork](/microsoft-365/copilot/cowork/best-practices)