---
title: "Configure analytics and insights dashboards | MicrosoftDocs"
description: "Learn how to configure analytics and insights dashboards in Customer Service workspace."
ms.date: 11/14/2022
ms.topic: article
author: lalexms
ms.author: laalexan
manager: shujoshi
feedback_product_url: https //experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
---

# Configure analytics and insights dashboards

You can enable and configure the Customer Service Insights features and services and share them with service managers, who can then view and analyze different activities. Setup is done in Customer Service Hub, but applies to both Customer Service Hub and Customer Service workspace.

   > [!div class="mx-imgBorder"]
   > ![Customer Service analytics configuration.](media/cs-enable-analyticsinsights.png "Configuration of Customer Service historical analytics reports")

The following report is available out of the box:

**Insights reports:** You can view Customer Service Insights reports with a combination of BI analytics and AI insights for your organization. The reports use natural language processing (NLP) to automatically detect the language used in your support cases and can also group related  cases into topics.

> [!NOTE]
> Settings for the Power BI template applications are separate from these services.


## Configuration details

See the following articles for configuring insights:

- [Configure Customer Service historical analytics](configure-cs-historical-analytics-csh.md)
- [Topic clustering configuration](configure-topics-clustering-cases-cs.md)
- [Configure Knowledge search insights](enable-knowledge-search-insights.md)

 ## Configure user access to analytics

1. Open the [Power Platform admin center](https://admin.powerplatform.microsoft.com/) and select your environment.

1. In the **Access** section, under **Security roles**, select **See all**.

1. Select a role, and then select **Edit**. <br>
    If you want to create a new role, select **New role**, and in the new **New Security role** dialog, enter a name in the **Role Name** field of the **Details** tab.

1. On the **Custom Entities** tab, grant **Read** privileges to the following analytics reports:
    - **Omnichannel historical analytics**  
    - **Omnichannel Realtime analytics**   
    - **Customer service historical analytics** 
    - **Knowledge analytics** 

1. Select **Save and close**. 

1. Select the role that you just created or updated, and then select **Add people** to add your supervisors to the role.

### See also

[Introduction to Customer Service analytics and insights](introduction-customer-service-analytics.md)  
[View and understand Customer Service analytics and insights in Customer Service Hub](customer-service-analytics-insights-csh.md)  
[View and understand Customer Service analytics](customer-service-analytics.md)  
[Manage report bookmarks](manage-bookmarks.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
