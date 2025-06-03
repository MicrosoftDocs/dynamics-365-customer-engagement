---
title: Setup and configure Sales Research Agent (preview)
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

# Setup and configure Sales Research Agent (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

The Sales Research Agent complies with both feedback and Bing search consent settings configured in the Power Platform Admin Center. These controls ensure that organizations can manage user interactions and data usage in alignment with their compliance and governance policies.

## Feedback Consent

At the environment level, administrators can [configure feedback settings](/power-platform/admin/tenant-settings) such as, whether users are allowed to submit feedback on their experience with the agent. Options include:

- Disabling feedback collection entirely
- Allowing users to provide basic feedback (e.g., thumbs up/down)
- Enabling detailed feedback submissions with additional comments

These settings help organizations tailor the feedback experience to their privacy and data collection standards.

## Bing Search Consent

The Sales Research Agent also honors the [Bing search consent setting](/power-platform/admin/geographical-availability-copilot?tabs=new#turn-on-data-movement-bing-search-and-microsoft-365-services-for-copilots-and-generative-ai-features). This means:

- If Bing search is **enabled**, the agent can access external web search capabilities to enhance its responses.
- If Bing search is **disabled**, the agent will operate solely on internal data sources—such as uploaded files or connected Dynamics 365 data—without querying the web.

This ensures that external data usage is fully controlled by tenant-level policies.

## Control access to the Sales Research Agent

Administrator can either grant access to all users in the environment or restrict it to specific security groups. This setting allows for granular control over who can leverage the agent's capabilities, ensuring that only authorized personnel can utilize AI-generated insights.

**Prerequisite:**
If you want to restrict access to a specific group of users, create a security group in Azure Portal and add only the intended users to that group. Learn more in [Create, change, or delete a network security group](/azure/virtual-network/manage-network-security-group?tabs=network-security-group-portal). 

1. In the Power Platform Admin Center, navigate to the environment where you want to configure the Sales Research Agent.
1. Select **Settings** > **Business Research Agent**, and then select **See details**.
1. In the **Business Research Agent Access** dialog, select one of the following options:
   - **Everyone**: This option allows all users in the environment to access the Sales Research Agent.
   - **Specific security group**: This option allows you to specify which security groups can access the agent.
1. Save your changes and verify that only the intended users can access the Sales Research Agent.