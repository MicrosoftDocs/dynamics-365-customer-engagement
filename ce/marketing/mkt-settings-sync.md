---
title: "Marketing data configuration (Dynamics 365 Marketing) | Microsoft Docs"
description: "Choose which entities to make available for use in dynamic email content, segmentation criteria, and lead scoring in Dynamics 365 Marketing."
ms.date: 08/19/2020
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Sync entities and track insights using Marketing data configuration

The Marketing data configuration settings allow you to choose which entities to make available for use in dynamic email content, segmentation criteria, and lead scoring in Dynamics 365 Marketing. Tracking insights allows you to better understand your customers and set up subscription lists and target segments for use in email-marketing campaigns. The Marketing data configuration settings also make dynamic field values available for use in marketing email messages as they are processed and sent.

The analytical and data-crunching capabilities of the insights capabilities are powerful, but also resource-intensive, so the solution maximizes performance by synchronizing only the relevant customer and account data. The insights capabilities also collect and manage all interaction data. For optimal performance and functionality, choose only the entities you need.

> [!IMPORTANT]
> The sync settings are permanent, so once you begin syncing an entity you won't be able to remove it again later. Syncing occurs often, and each entity that you sync requires storage space and processing time, so you should only sync those entities you are sure you will need.

The most-used entities (including contacts, accounts, and events) are synced by default, but you can sync any set of entities that you want, including custom entities. The following features require all the relevant data to be present in the insights service:

- **Segmentation**: All entities that you need to query in your segmentation criteria must be present.
- **Dynamic email content**: All entities with field values that you want to show as dynamic data in an email message must be present.
- **Lead scoring**: All entities with field values that you want to use in scoring models must be present.

 > [!NOTE]
 > Lead scoring models must begin with the lead entity at the top level. Custom entities can only be used in a lead scoring model if they have a 1:N relationship with the lead entity. See [Create advanced lead scoring conditions by using traversals](score-manage-leads.md#create-advanced-lead-scoring-conditions-by-using-traversals) for more information.

> [!IMPORTANT]
> You can only sync entities that are configured with **Change tracking** enabled. Entities without change tacking won't be listed on the **Marketing data configuration** page. If you are a system customizer or admin, you can find this setting by doing the following:
> 
> 1. Open the **Settings** menu ![The Settings menu icon](media/settings-icon.png "The Settings menu icon") at the top of the page and select **Advanced settings**. The advanced-settings area then opens in a new browser tab. Note that this area uses a horizontal navigator at the top of the page instead of a side navigator.
> 1. Navigate to **Settings** > **Customization** > **Customization**.
> 1. Select **Customize the system** (or select **Solutions** and open a solution if your entity is part of a solution).
> 1. Find and select the entity you want to sync.
> 1. On the **General** tab for the entity, select the **Change tracking** check box.
> 1. Save and publish the change.
> 
> More information: [Customizing Dynamics 365 Marketing](customize.md)

To sync a new entity with the insights service:

1. Go to **Settings** > **Advanced settings** > **Marketing settings** > **Marketing data configuration**.

1. Find and select the check box for each entity you want to sync.

1. Select **Publish changes** at the top of the list and confirm your setting when prompted. (You may need to scroll to the top of the list to see the **Publish changes** button.)

1. Wait until you see a pop-up dialog that says "Your new settings have been saved. Allow up to half an hour for them to take effect." If you don't see the announcement, select **Publish changes** again and then wait again; repeat until you see the message.  

1. Depending on how much data needs to be synced (and other factors), you may need to wait for several minutes (up to half an hour) before your data is available for use in your segments, messages, and scoring models. Here are some ways you'll be able to tell that a new entity is synced and ready for use (you only need to check one of these):

    - The check box for the relevant entity on the **Marketing data configuration** page is shown as checked and grayed out when you first enter the page. The check box is gray to indicate that you can't disable the sync once it has started. You must reload the page manually to see this change.
    - The relevant entity is shown in the [assist-edit dialog](dynamic-email-content.md#assist-edit) for marketing email messages.
    - The relevant entity is shown in the **Profiles** list in the [segment designer](segmentation-lists-subscriptions.md). (Note that you must either create a new query group or remove all clauses from the existing query group to see the **Profiles** drop-down list here&mdash;otherwise the contact entity is already selected by default.)
    - The relevant entity is shown in the **Entity** list when you are editing a condition for a [lead scoring rule](score-manage-leads.md).

### See also

[Open the advanced settings](open-advanced-settings.md)  
[Add dynamic content to email messages](dynamic-email-content.md)  
[Working with segments](segmentation-lists-subscriptions.md)  
[Design lead-scoring models](score-manage-leads.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]