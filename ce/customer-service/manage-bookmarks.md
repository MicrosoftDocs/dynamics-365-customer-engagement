---
title: Manage bookmarks for reports
description: Create bookmarks to save personalized views of your Dynamics 365 Customer Service reports, set a bookmark as your default view, and delete bookmarks you no longer need.
author: neeranelli
ms.author: nenellim
ms.topic: how-to
ms.date: 02/14/2023
ms.reviewer: nenellim
ms.custom: bap-template
---

# Manage bookmarks for reports

A bookmark captures the state of a report page, including changes that you've made to the filters. Use bookmark options to select a saved view, update or delete a bookmark, and set a bookmark as your default view of a report.

A bookmark that you create for a [report group](report-filters-groups.md) saves a personalized view using that group's filters. For example, if you create a bookmark in the Omnichannel historical report's **Conversation** tab, the bookmark applies to the **Conversation**, **Queue**, and **Agent** tabs, and doesn't include filters for the other tabs.

Bookmarks are available in Customer Service historical analytics reports, Omnichannel historical analytics reports, and knowledge analytics reports.

## Prerequisites

Grant **Create**, **Read**, **Write**, and **Delete** privileges to the following security roles as applicable, for the **Report Bookmark** custom entity:

- CSR Manager
- Customer Service Representative
- Knowledge Manager
- Omnichannel administrator
- Omnichannel supervisor
- Omnichannel agent

[Learn more about configuring user access to analytics and dashboards](configure-customer-service-analytics-insights-csh.md#configure-user-access-to-analytics-and-dashboards).

## Create bookmarks

1. In Customer Service workspace or Omnichannel for Customer Service, open one of the following reports:

    - **Customer Service historical analytics**
    - **Omnichannel historical analytics**
    - **Knowledge analytics**

1. On the report page, select a tab, such as **Summary**.

1. Use the report filters to customize the data in your view.

1. Select **Bookmarks**, and then select **Create new**.

1. Enter a name for the bookmark, and then save it.

   :::image type="content" source="media/manage-bookmarks.png" alt-text="Screenshot of creating a bookmark to save a custom filtered view of a report.":::

## Manage bookmarks

Select **Bookmarks**, and then:

- To delete a bookmark, select the delete icon.
- To set a bookmark as the default view for the report, select the pin icon. The report always opens to the pinned view.
- To reset the bookmarked view of a report, select **Reset**.

To modify a saved view, adjust the report filters as needed. Then, select **Bookmarks** > **Update Bookmark**.

### See also

[Customer Service dashboards](customer-service-analytics-insights-csh.md)  
[Omnichannel for Customer Service dashboards](omnichannel-analytics-insights.md)  
[Knowledge analytics](knowledge-search-analytics-cs.md)  
