---
title: Set up and configure Sales Research Agent (preview)
description: Learn how to configure the Sales Research Agent so that sellers can get AI-generated insights and provide feedback on the insights.
manager:
ms.date: 06/03/2025
ms.topic: overview
ms.service: dynamics-365-sales
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ai-usage: ai-assisted
---

# Set up and configure Sales Research Agent (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

As an admin, set up and configure the Sales Research Agent in Dynamics 365 Sales to help sales managers and sales leaders gain insights from their sales data.  

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Configure Copilot Studio capacity

The agent needs Copilot Studio capacity to run. Ensure that you have enough capacity for the agent. Learn more in [Manage Copilot Studio messages and capacity](/power-platform/admin/manage-copilot-studio-messages-capacity?tabs=new).

## Enable AI Agents in Power Platform Admin Center

The tenant admin must enable AI Agents in Power Platform Admin Center to use the Sales Research Agent in Dynamics 365 Sales. Learn more in [Turn on AI capabilities in Dynamics 365 Sales](/power-platform/admin/copilot/copilot-hub#turn-on-ai-capabilities-in-dynamics-365-sales).

## Grant access to the Sales Research Agent

By default, the **Sales Research Agent** menu in the Sales Hub app is only visible and accessible to the **System Administrator** role.  
:::image type="content" source="media/sales-research-agent-navigation.png" alt-text="Screenshot of the Sales Research Agent navigation in the Sales Hub app.":::

To grant access to other users, you must assign the **Sales Research Agent Reader** security role to users in the Power Platform Admin Center. Learn more in [Assign a security role to a user](/power-platform/admin/assign-security-roles).

Alternatively, you can create a group team in Power Platform Admin Center, add users to that group, and then assign the **Sales Research Agent Reader** role to that security group. This approach simplifies role management for larger teams. Learn more in [Manage group teams](/power-platform/admin/manage-group-teams).

## Configure tenant settings

The Sales Research Agent complies with both Copilot feedback and Bing search consent settings configured in the Power Platform Admin Center. These controls ensure that organizations can manage user interactions and data usage in alignment with their compliance and governance policies.

### Feedback consent

At the environment level, administrators can [configure feedback settings](/power-platform/admin/tenant-settings) such as, whether users are allowed to submit feedback on their experience with the agent. Options include:

- Disabling feedback collection entirely
- Allowing users to provide basic feedback such as, thumbs up or thumbs down
- Enabling detailed feedback submissions with additional comments

These settings help organizations tailor the feedback experience to their privacy and data collection standards.

### Bing search consent

The Sales Research Agent also honors the [Bing search consent setting](/power-platform/admin/geographical-availability-copilot?tabs=new#turn-on-data-movement-bing-search-and-microsoft-365-services-for-copilots-and-generative-ai-features). This means:

- If Bing search is **enabled**, the agent can access external web search capabilities to enhance its responses.
- If Bing search is **disabled**, the agent will operate solely on internal data sources—such as uploaded files or connected Dynamics 365 data—without querying the web.

This ensures that external data usage is fully controlled by tenant-level policies.

## Related information

- [Analyze your sales performance using the Sales Research Agent (preview)](use-sales-research-agent.md)
- [Frequently asked questions about Sales Research Agent (preview)](faqs-sales-research-agent.md)