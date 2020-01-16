---
title: "Create or delete custom sources in Social Engagement | Microsoft Docs"
description: "Learn how you can add RSS and Atom feeds to a group of custom sources and how you can manage custom sources."
keywords: custom source, custom sources
ms.date: 06/11/2019
ms.service: dynamics-365-marketing
ms.topic: article
applies_to: 
  - Social Engagement
ms.assetid: eeda21ac-40b8-45ec-a90a-3c22e07c872a
author: m-hartmann
ms.author: mhart
manager: shellyha
topic-status: Drafting
ms.custom: 
  - dyn365-socialengagement
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365SE
---

# Create or delete custom sources

[!INCLUDE [mse-service-discontinuation](../includes/mse-service-discontinuation.md)]

Extend the coverage of your data sources by adding public RSS feeds in [!INCLUDE[pn_netbreeze_long](../includes/pn-social-engagement-long.md)]. Custom sources offer a way to receive additional data from your favorite RSS and Atom feeds. Broaden your sources while efficiently keeping track of all of your feeds. Administrators can also define Search Setup defaults. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Manage global settings](manage-global-settings.md)

> [!NOTE]
> [!INCLUDE[proc_permissions_social_listening_admin](../includes/proc-permissions-social-listening-admin.md)] [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Understand user roles](user-roles.md)

## Create custom sources

> [!TIP]
> You need to create a group and add feeds before adding custom sources in Search Setup but you can have one custom source per group.

1. Go to **Search Setup** > **Custom Sources**.

2. In the **Custom Sources** pane, click **Add a custom source** ![Add button](media/add-icon.png "Add button").

3. Enter the name of the group and initials to uniquely identify your sources.

   > [!NOTE]
   > It is important to create distinct initials so you can differentiate your custom sources when analyzing your data. The initials will appear anywhere your custom sources are displayed.

4. Enter your RSS or Atom feed and click the **Add** ![New or Add button](media/plus-icon.png "New or Add button") button to validate and add a source.

   **Example of feed URL**: `https://contoso.com/rss`

5. Click **Save** ![Save button](media/save-icon.png "Save button").

## Edit custom sources

1.  Go to **Search Setup** > **Custom Sources**.

2.  In the custom sources pane, click the custom source group you want to edit.

3.  Remove sources from the group by clicking the **Remove** ![Delete button](media/delete-icon.png "Delete button") button. You can also change the name of the group or the initials.

4.  Click **Save** ![Save button](media/save-icon.png "Save button").

## Delete groups of custom sources

1.  Go to **Search Setup** > **Custom Sources**.

2.  In the list of custom sources, click the **Delete** ![Delete button](media/trashbin-icon.png "Delete button") button by the custom sources group you want to delete, and confirm the deletion.

> [!IMPORTANT]
> Deleting a custom source has the following effects:
> - Data acquisition for the deleted custom source stops immediately.
> - The custom source is no longer visible in the user interface.
> - Search topics, rules, alerts and streams based exclusively on this custom source are deactivated.

### See Also

[Set up searches to listen to social media conversations](set-up-searches.md)    
[Create or delete a search topic](create-delete-search-topic.md)    
[Add rules to a search topic](add-rules-search-topic.md)
