---
title: Manage bookmarks for reports
description: Create bookmarks and navigate a personalized view of your reports.
ms.date: 10/04/2022
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
---

# Manage bookmarks for reports

A bookmark captures the state of a report page, including changes that you've made to the filters. Use bookmark options to select a saved view, update or delete a bookmark, and set a default bookmark. You can save personalized views of your reports as bookmarks at user level.

> [!Note]
> Bookmarks are only available in historical analytics reports and knowledge analytics reports.

## Prerequisites

To enable bookmarks for Customer Service historical, intraday historical, and knowledge management analytics reports, you must add **Create**, **Read**, **Write**, and **Delete** privileges for the following security roles, in the **Report Bookmark** custom entity.
- CSR Manager
- Customer Service Representative
- Knowledge Manager
- Omnichannel administrator
- Omnichannel supervisor
- Omnichannel agent

For more information on configuring user access to analytics and dashboards, see [Configure user access to analytics and dashboards](configure-customer-service-analytics-insights-csh.md#configure-user-access-to-analytics-and-dashboards).

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
