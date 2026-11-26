---
title: Use sales skills in Copilot Cowork
description: Dynamics 365 Sales Skills in Copilot Cowork help teams prep for meetings, review pipeline, and act faster. Learn what they do and how to enable and use them.
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.date: 10/05/2026
ms.topic: how-to
ms.update-cycle: 180-days
ai.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Use sales skills in Copilot Cowork

Sales skills in Microsoft Copilot Cowork help you drive better outcomes across your sales organization. With these skills, you can analyze deal health and advance readiness, assess competitive positioning and develop counter-strategies, build compelling business cases and proposals, and more—all while leveraging your Dynamics 365 Sales data alongside your Microsoft 365 context. Some sales skills are CRM-agnostic and work with uploaded data as well. For a list of supported sales skills, see [Sales skills available in Copilot Cowork](#sales-skills-available-in-copilot-cowork).

## Prerequisites

The following prerequisites are required to use the sales skills packaged in the **Sales** plugin. For CRM-agnostic sales skills, you need an appropriate license to access Microsoft Copilot.

**For administrators:**

- [Dataverse MCP server](/power-apps/maker/data-platform/data-platform-mcp-disable) is enabled for your environment. The Copilot Cowork plugin for Dynamics 365 Sales uses the Dataverse MCP server to access your Dynamics 365 Sales data.

- The Sales app is installed and available for your organization. The app includes the Sales plugin for Cowork. The app is auto-installed for eligible organizations and users based on their license. Learn more in [Automatic installation for eligible Dynamics 365 users](/microsoft-sales-copilot/install-sales-app#automatic-installation-for-eligible-dynamics-365-users).

**For users:**

- A **Sales Enterprise** or **Sales Premium** license to use the **Sales** plugin in Copilot Cowork. This plugin includes all Dynamics 365 Sales skills. 
- An appropriate license to access Microsoft Copilot.
- The Dynamics 365 Sales plugin installed in your Copilot experience. To determine whether it's installed, follow the steps in the **[Enable the Sales plugin in Cowork](#enable-the-sales-plugin-in-cowork)** section. If the plugin isn't installed, you won't see the **Sales** option in the plugin list.

## Copilot Cowork

Use Copilot Cowork when you need to orchestrate multi-step tasks that require coordination across your sales data and Microsoft 365 context, including emails, meetings, and collaboration activity. 

To learn how you can use Copilot Cowork to do multi-step tasks that pull data from multiple sources, including Dynamics 365 Sales and Customer Service, watch the following video:

:::image type="content" source="media/agentic-platform-mechanics-video.png" alt-text="Thumbnail of the Agentic Platform Mechanics video" link="https://youtu.be/wGBHAclqhG8?t=272":::

### Enable the Sales plugin in Cowork

1. In Microsoft Copilot, select the **Cowork** tab.
1. Select **Customize** from the left navigation pane.
1. Turn on the toggle for **Sales** to enable the plugin for Dynamics 365 Sales.
1. If you don't have a CRM license, turn on the **Sales for Cowork** toggle to access CRM-agnostic sales skills.
1. Select the plugin to view available skills.
    :::image type="content" source="media/cowork-sales-plugin.png" alt-text="Screenshot of Cowork Manage Plugins page with the Dynamics 365 Sales plugin listed.":::

### Select the environment in Copilot Cowork

Select the Dynamics 365 environment that Copilot needs to use. It's useful when you work across multiple environments for different lines of business, regions, or use cases.

When you enter a sales-specific prompt in Cowork for the first time, it prompts you to select the Dynamics 365 environment from which to pull the data. Cowork remembers your selection for future prompts. You can change the environment at any time by asking Cowork to `list environments` and then selecting a different one, or by saying `Set environment to [environment name]`.

### Use sales skills in Cowork

When you submit a prompt in Cowork, instead of treating the prompt as one opaque task, Cowork identifies the user intent, comes up with a plan, identifies the systems that hold the required data, and identifies the skills and tools needed for the job. Cowork doesn't take any consequential actions autonomously. It asks you to confirm before executing any actions such as updating records, sending emails, or creating tasks.

> [!IMPORTANT]
> Cowork requires an appropriate license for access and is also billed based on usage. Charges aren't part of a fixed license plan; they vary based on token usage, which depends on factors such as the user prompt, task duration, and underlying model. Learn more in [Credit usage for Microsoft Copilot Cowork tasks](/microsoft-365/copilot/usage-based-billing-copilot-credits-cost).

1. In Microsoft Copilot, select the **Cowork** tab.

1. Ask a sales-related question in natural language. You don't need to specify that you want to use the Dynamics 365 Sales plugin in your prompt. If the question is related to sales and the plugin is enabled, Cowork automatically uses the appropriate skills from the plugin to answer your question. 
   
   The following screenshot shows the response from Cowork for the prompt ""*Analyze my open pipeline for the next 2 quarters. Identify the biggest areas of risk and the patterns driving that risk. Look across deal value, stage, close timing, activity and customer engagement across CRM and Microsoft 365. Highlight the opportunities I should investigate further and explain why.*"
 
    :::image type="content" source="media/copilot-cowork-response.png" alt-text="Screenshot of response from Cowork with a step-by-step plan and real-time progress for a sales-related question.":::

### Example prompts for Copilot Cowork

The following example prompts show how you can structure your sales-related requests in Cowork to use Dynamics 365 Sales data and Microsoft 365 context effectively.

**Prompt for competitive strategy:** 

Help me develop a competitive strategy for [opportunity] where we're competing with [competitor]. Use Dynamics 365 Sales and Microsoft 365 to understand the customer's priorities, decision criteria, stakeholder concerns, and any competitive objections. Map the customer's requirements to our relevant strengths, trade-offs, and proof points. Identify how I should respond to the key competitive concerns. Distinguish what we know from what we're inferring. Flag any competitive claims that need validation. End with the recommended positioning and next move. 

**Prompt for customer engagement strategy:** 

Build a 30-day customer engagement strategy for [account] around the current business objective. Use Dynamics 365 Sales and Microsoft 365 to identify the stakeholders who matter, assess our current relationship and coverage gaps, and identify legitimate paths to engage the right people. Recommend how to sequence the engagement, including who to engage, why they matter, the best approach or introduction path, and what each interaction should accomplish. Ground the strategy in customer evidence and call out any important gaps, unknowns, or relationship assumptions. 

**Prompt for lead disposition:** 

Assess [lead] against our qualification criteria and tell me what we know, what's still missing, and what the evidence supports. Use Dynamics 365 Sales and Microsoft 365 to evaluate each qualification criterion, distinguish confirmed information from unknowns or conflicting evidence, and explain the rationale. Recommend the appropriate disposition and routing only where the available qualification method supports it. Identify the next evidence or action needed to move the lead forward.

### Business skills and custom skills in Cowork

Administrators and sales managers can create business skills in Dataverse to meet the specific needs and workflows of your organization. To learn more, see [Business skills overview (preview)](/power-apps/maker/data-platform/data-platform-business-skill-overview).

Sellers can extend Cowork with user-specific custom skills stored in your OneDrive. To learn more, see [Create custom skills](/microsoft-365/copilot/cowork/use-cowork#create-custom-skills).

## Sales skills available in Copilot Cowork

Copilot Cowork invokes the necessary skills based on your prompts. The following table lists the skills included in the **Sales** and **Sales for Cowork** plugins. As sales skills continue to evolve, check the **Skills** section of the plugin page in Cowork for the latest list of packaged skills.

| Skill name | Description | Sales plugin (requires Dynamics 365 Sales license) | Sales for Cowork plugin (CRM-agnostic) |
|---|---|---|---|
| Business case composer | Build compelling business cases and proposals grounded in customer data. | Yes | Yes |
| Competitive strategy | Analyze competitive threats and develop counter-strategies for your deals. | Yes | Yes |
| CRM data hygiene | Identify and resolve data quality issues in your CRM. | Yes | No |
| Customer engagement strategy | Develop a data-driven engagement strategy based on customer and deal context. | Yes | No |
| Deal catch-up | Quickly understand changes and updates to your deals with a comprehensive summary of what's new. | Yes | Yes |
| Deal desk | Access deal support, guidance, and escalation for complex or at-risk opportunities. | Yes | No |
| Draft outreach | Generate personalized customer communications and outreach templates. | Yes | No |
| Executive deal review | Prepare executive summaries of critical deals and pipeline status. | Yes | No |
| Forecast rollup | Consolidate and verify forecast data across your team or organization. | Yes | No |
| Meeting preparation | Automatically prepare for customer meetings by pulling relevant account, opportunity, and activity context. | Yes | Yes |
| Pipeline prioritizer | Identify which opportunities to focus on based on deal stage, size, timeline, and engagement signals. | No | Yes |
| Post-meeting follow-up | Create follow-up actions and communications after customer interactions. | Yes | Yes |
| Reconcile my opportunity | Align your pipeline data and resolve discrepancies to ensure accurate forecasting. | Yes | No |
| Sales Research Agent | Conduct research on accounts, competitors, and market trends. | Yes | No |
| Segment analysis | Analyze your customer segments and identify patterns and opportunities. | Yes | No |
| Stage advance readiness | Assess whether deals are ready to move forward with criteria-based readiness checks. | Yes | No |
| Team activity coaching | Monitor team activity and provide coaching recommendations to improve performance. | Yes | No |
| Team pipeline review | Analyze team pipeline health, velocity, and forecast accuracy. | Yes | No |

## Governance and compliance

Governance applies throughout each request. Identity and access controls determine what users can discover and use, while business logic and approval requirements remain in effect during execution. All activity is auditable from end to end. Although the experience is simple for sellers—one request, one result—it is supported by a governed agentic flow.


### Related information

- [Responsible AI FAQ for Cowork](/microsoft-365/copilot/responsible-ai/cowork-responsible-ai-faq)
- [Best practices for Cowork](/microsoft-365/copilot/cowork/best-practices)
