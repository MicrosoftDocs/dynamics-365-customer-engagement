---
title: Manage bookmarks for reports | MicrosoftDocs
description: Create bookmarks for reports and save personalized views of your reports.
author: neeranelli
ms.author: nenellim
ms.service: dynamics-365
ms.topic: how-to
ms.date: 12/12/2022
ms.reviewer: nenellim
ms.custom: bap-template
---

# Manage bookmarks for reports

A bookmark captures the state of a report page, including changes that you've made to the filters. Use bookmark options to select a saved view, update or delete a bookmark, and set a default bookmark. 

> [!Note]
> You can use bookmarks only in historical and knowledge analytics reports.

## Prerequisites

Be sure to grant **Create**, **Read**, **Write**, and **Delete** privileges to the following security roles as applicable, for the **Report Bookmark** custom entity.
- CSR Manager
- Customer Service Representative
- Knowledge Manager
- Omnichannel administrator
- Omnichannel supervisor
- Omnichannel agent

For more information on configuring user access to analytics and dashboards, see [Configure user access to analytics and dashboards](configure-customer-service-analytics-insights-csh.md#configure-user-access-to-analytics-and-dashboards).

## Report groups

Reports are grouped into the following categories and subcategories. 
- Omnichannel historical analytics reports
    - Conversation, Queue, Agent, Topics
    - Voice 
    - Unified routing
- Customer Service historical analytics reports
    - Summary, Agent, Topics
- Knowledge analytics reports 
    - Search Term Insights
    - Article Insights

A bookmark created for a report group will save a personalized view using filters in that group, and won't filter or display information from other groups. 
For example, if you create a bookmark in the Omnichannel historical report's Conversation tab, the bookmark will apply to Conversation, Queue, Agent, and Topics, and won't include filters for voice or unified routing. Similarly, if you create a bookmark for voice, it won't have any filters related to the other groups.
## Create and manage bookmarks

1. In Customer Service workspace or Omnichannel for Customer Service, open one of the following reports:

    - **Customer Service historical analytics**
    - **Omnichannel historical analytics**
    - **Knowledge analytics**

1. On the report page, select a tab, such as **Summary**.

1. Adjust the report filters to customize your data view.

1. Select **Bookmarks**, and then select **Create new**.

1. Enter a name for the bookmark, and then save it.

1. Repeat the steps to create as many bookmarks as you require.

   :::image type="content" source="media/manage-bookmarks.png" alt-text="Create a report bookmark to save personalized filters.":::

1. Select **Bookmarks** and then do the following on the **Bookmarks** flyout menu:

    - To delete a bookmark, select the delete icon.
    - To set a bookmark as the default view for the report, select the pin icon. The report will always open with the pinned view.
    - To reset the bookmarked view of a report, select **Reset**.

1. To modify a saved view, adjust the report filters as needed. Then, select **Bookmarks** > **Update Bookmark**.



### See also

[Customer Service dashboards](customer-service-analytics-insights-csh.md)  
[Omnichannel for Customer Service dashboards](omnichannel-analytics-insights.md)  
[Knowledge analytics](knowledge-search-analytics-cs.md)  


