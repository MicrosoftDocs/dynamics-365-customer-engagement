---
title: "Configure Knowledge search insights for Dynamics 365 in Customer Service Hub and Customer Service workspace | MicrosoftDocs"
description: "Learn how to configure Knowledge search insights in Customer Service Hub and Customer Service workspace"
ms.date: 10/12/2021
ms.topic: article
author: lalexms
ms.author: laalexan
manager: shujoshi
feedback_product_url: https //experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
---

# Configure Knowledge search insights for Dynamics 365 Customer Service

The knowledge search analytics dashboard is designed to provide your organization's customer service supervisors and knowledge workers with valuable insights into how your support agents are finding and using knowledge articles. 

> [!NOTE]
> Knowledge search analytics will not provide information about customer search behavior. Data is only from internal knowledge searches.

## Configure the Knowledge search analytics dashboard

To enable the Knowledge search analytics dashboard:

1. Sign in to Dynamics 365 as an administrator, and go to Customer Service Hub.

2. In the **Change area**, select **Service Management**.

3. Go to **Insights** and select **Settings**. The **Insights settings** page is displayed.

    > [!div class=ms-imgBorder]
    > ![Enable knowledge search analytics.](media/cs-enable-analyticsinsights.png "Enable knowledge search analytics")

4. Navigate to **Knowledge search** and select **Manage**.

5. On the **Knowledge search analytics** page, set the **Status** toggle to **Enabled**.

6. Select **Save** or **Save & Close**.

### View Customer Service knowledge search analytics reports

The service managers must have the system administrator, knowledge manager, or CSR manager role to view the reports.

You can see the reports by navigating to the **Service** > **Insights** > **Knowledge search analytics** page. Search term insights are displayed.

### Provide report access to additional security roles

If your organization needs to enable users with different privileges to access the reports beyond the default ones, you can perform the following steps to share the reports to the additional roles.

1. In Dynamics 365, select **Settings**, and then select **Advanced Settings**.

2. On the page that appears, select **Security**, and then select **Security roles**.

3. Select the security role that you want to provide access for. For example, Omnichannel supervisor.

4. Select the Custom Entities tab, and then select an entity, for example "Knowledge search analytics".

5. Select **Save and Close**.

> [!NOTE]
> The knowledge base analytics dashboard supports only English content and is available only in organizations that have the base language set as English.

### See also

[Introduction to Customer Service analytics and insights](introduction-customer-service-analytics.md)  
[View and understand Customer Service analytics and insights in Customer Service Hub](customer-service-analytics-insights-csh.md)  
[View and understand Customer Service analytics](customer-service-analytics.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
