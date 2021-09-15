---
title: "Configure Omnichannel historical analytics reports | MicrosoftDocs"
description: "Configure historical analytics reports for Omnichannel"
ms.date: 10/04/2021
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
feedback_product_url: https //experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
---

# Configure Omnichannel historical analytics reports

## Introduction

You can configure historical analytics to give your service managers a combination of BI analytics and AI insights for their organization. The reports use natural language understanding to automatically detect the language used in your support conversations and group related support conversations into topics. 

The following historical analytics reports are available:

[Conversation report](oc-conversation-dashboard.md)
[Queue report](oc-queue-dashboard.md)
[Agent report](agent-dashboard.md)
[Bot report](oc-bot-dashboard.md)
[Conversation Topics report](oc-conversation-topics-dashboard.md)
[Unified routing](oc-historical-analytics-unified-routing.md)


## Enable Omnichannel historical analytics reports in Omnichannel for Customer Service

Make sure that you have the required administrator permissions for Dynamics 365.

1. Sign in to Dynamics 365, and select **Omnichannel admin center**.

2. In the site map, go to **Insights** and select **Settings**. The **Insights settings** page is displayed.

3. Select **Manage** next to Omnichannel historical analytics.

4. On the Omnichannel historical analytics page, toggle the **Status** to **Enabled**.

5. Select **Save** or **Save & Close**.

This configuration will also enable AI-discovered topics from conversations with default settings.

## Enable Historical analytics for unified routing in Omnichannel for Customer Service

You can enable historical analytics for unified routing on the **Insights** page in Omnichannel admin center. The metrics are available in the report after 24 hours.

> [!IMPORTANT]
>
> Omnichannel historical analytics must be enabled before you can enable historical analytics for unified routing.

1. On the **Insights** page, select **Manage** for **Historical analytics for unified routing**.
2. On the **Historical analytics for unified routing** page, set the **Status** toggle to enabled.
3. Save and close.

### View Omnichannel historical analytics reports

The service managers must have the admin or service manager role to view the reports. Users with the OC supervisor role will be able to view the reports only after the reports are shared with them.

### Provide report access to additional security roles

If your organization needs to enable users with different privileges to access the reports beyond the default ones, the following steps outline how to share the reports to additional roles. 

1. In Dynamics 365, select **Settings**, and then select **Advanced Settings**.

2. On the page that appears, select **Security**, and then select **Security roles**.

3. Select the security role that you want to provide access for. For example, Omnichannel supervisor.

4. Select the **Custom Entities** tab, and then select an entity, for example "Omnichannel historical analytics".

5. Select **Save and Close**. The Omnichannel supervisor will now be able to see the historical anaytics report.

You can see the following reports by navigating to **Omnichannel for Customer Service**, creating a new session tab, and selecting **Omnichannel historical analytics**. The **Conversation** page is displayed.

### See Also

[Dashboard Overview](customer-service-analytics-insights-csh.md)  
