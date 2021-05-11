---
title: "Configure offline data for the Field Service (Dynamics 365) mobile app | MicrosoftDocs"
description: Learn how to configure offline data for the Field Service (Dynamics 365) mobile app.
ms.custom: 
  - dyn365-fieldservice
ms.date: 03/19/2021
ms.reviewer: krbjoran
ms.topic: article
ms.service: dynamics-365-customerservice
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: FieldServiceDave
ms.author: daclar
manager: shellyha
search.app: 
  - D365CE
  - D365FS
---

# Configure offline data and sync filters for the Field Service (Dynamics 365) mobile app

Administrators can control what data is downloaded to the Field Service (Dynamics 365) mobile app with their offline profile.  

When a user is added to an offline profile, the app will download data to the device. In offline mode, entity data is read from the local device database and will not read live data from the server. This allows the app to perform consistently with or without internet connectivity. The local database will be updated with new data as defined by the administrator in the offline profile at predefined intervals or on demand by the app user. 

Offline configuration is achieved by:

1. Setting up an offline profile (one exists by default).
2. Adding users to the offline profile.
3. Publishing the offline profile.
4. Adding the offline profile to the Field Service mobile model-driven app. 

> [!div class="mx-imgBorder"]
> ![Device render showing offline status mode in Field Service (Dynamics 365) mobile app.](./media/mobile-2020-offline-complete.png)

> [!Note]
> When the technician has internet connectivity, data on the device will automatically be refreshed at a minimum interval of five minutes. For more information, see [sync filters](#sync-intervals) in this article.

For more information on offline profiles, see the article on [setting up mobile offline synchronization](/dynamics365/mobile-app/preview-setup-mobile-offline).


For a guided walkthrough, check out the following video.

> [!VIDEO https://www.microsoft.com/videoplayer/embed/RE4J8no]

## Set up an offline profile

Go to the Power Platform admin center at [https://admin.powerplatform.microsoft.com/](https://admin.powerplatform.microsoft.com/), and find and select your environment.

Select **Settings** at the top.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Power Platform admin center, on an environment, showing the settings option.](./media/offline-2020-ppac-settings.png)

Go to **Users + permissions section** > **Mobile configuration**.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Power Platform admin center, showing the Mobile configuration option.](./media/offline-2020-ppac-mobile-configuration.png)

Offline entities, relationships, and user assignment is managed through your **Offline Profile**. Field Service provides an out-of-the-box offline profile called **Field Service Mobile - Offline Profile** with recommended default settings for Field Service entities. 

Within your offline profile you can:

- Define entities that are available offline and their sync interval.
- Define filters for each entity. For example, by default we set a filter to only get the bookings entity within a range of seven days before or after current date.
- Set up item association by creating relationships between entities. Item association saves time because you won't need to set filters for every entity; you can associate related entities that follow filters set on the related entity.


### Best practices for the offline profile:

- Use the default **Field Service Mobile - Offline Profile** as your starting point and update it based on your business needs.
- Keep default record types in place; these record types are intentionally selected as a core set of record types used in Field Service.
- Avoid using "All Data" filter, which can result in significant amounts of data coming down and can impact sync times.


> [!div class="mx-imgBorder"]
> ![Screenshot of the Power Platform admin center, showing mobile offline profiles.](./media/mobile-2020-offline-profile-ppac.png)

## Add users and teams to the offline profile

Open the **Field Service Mobile - Offline Profile**.  

Add users or [teams](/power-platform/admin/manage-group-teams) to the offline profile in the right **People with offline access** panel. When a team is added to the profile, the users within that team are displayed under the team, while individual users are displayed directly in the offline profile. Organizations with many users should leverage teams to help ease maintenance of user access.
\
A user or team can only be added to one offline profile at a time. If a user or team is added to another offline profile, you will see a warning stating that the user is already part of a different offline profile. If you continue with the change, the user or team will be moved to the new profile. 

> [!div class="mx-imgBorder"]
> ![Screenshot of the Power Platform admin center, showing the section where to add users to the offline profile.](./media/mobile-2020-offline-profile-add-user.png)

## Edit the offline profile

For each entity, you can choose a data download filter:

1. Download related data only.
2. All records.
3. Other data filter.
4. Custom data filter.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Power Platform admin center, showing the edit bookable resource booking entity options.](./media/mobile-offline-mop-latest.png)

For example, the **Bookable Resource Booking** (in other words, the booking) entity has a data download filter set to **custom data filter** that downloads resource bookings that start or end in the next seven days or today.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Power Platform admin center, showing the set filter logic.](./media/mobile-2020-offline-ppac-brb-custom-filter.png)

**Save and Publish** the offline profile.

> [!Note]
> The default offline profile is updated periodically as part of Field Service updates. If you edited the offline sync filter of an entity, the entity's sync filter will not receive updates; other entity sync filters that have not been edited will receive updates in an unpublished state. Administrators can review the updates and decide if they want to take the update or continue with the previous sync filters. This only applies to sync filters and relationships will receive updates while keeping your specific changes.


For more information on offline profiles, see the article on [setting up mobile offline synchronization](/dynamics365/mobile-app/preview-setup-mobile-offline).

## Sync intervals

Sync intervals define how often record type data will automatically sync down to the users' devices. Sync intervals can be a minimum of five minutes or as long as one day. Records that change frequently can have a short duration sync interval, while infrequently changed records do not need to sync as often. With variable sync intervals, administrators have greater control over data and can help improve sync performance.

The default **Field Service Mobile - Offline Profile** has predetermined sync intervals for each record type, which is selected based on typical usage patterns of those record types. 

> [!Note]
> Even if the value for sync interval is set to be less frequent than **Every 1 hour**, data will still be synched every hour. A sync is only initiated when there is connectivity and when the app is actively running on the user’s mobile device. For Android devices, once the sync is initiated, it can be completed in the background.
Dependencies based on selected relationships and custom filters that includes related tables are analyzed at each sync request. This might also result in a sync being triggered for related tables.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Power Platform admin center, showing the option to customize the records you want to make available offline.](./media/mobile-2020-offline-sync-filter.png)

> [!Note]
> Sync intervals are defined per record type with Field Service v8.8.40+. Prior to this version, all record types will have a five-minute sync interval.


## Add the offline profile to the app

Go to your Dynamics 365 apps by going to ```yourenvironment.crm.dynamics.com/apps```, then go to the app designer for Field Service mobile.

> [!div class="mx-imgBorder"]
> ![Screenshot of the app designer.](./media/mobile-2020-open-app-designer.png)

Go to **Properties** and add the offline profile you published if it is not already there.

> [!div class="mx-imgBorder"]
> ![Screenshot of the app designer, on the Field Service mobile properties tab.](./media/mobile-2020-add-offline-profiles.png)

> [!Note]
> Field Service customers can create additional offline profiles to enable scenarios where different user roles have different sync settings or entities available to them. For example, a Field Service manager may require seeing a broader scope of work orders that may not be assigned to the current operator of the mobile app. If you create a new offline profile, you'll need to add it to the Field Service mobile app in the app designer as well.

## Sync conflicts 

Sync conflicts can happen if there is a mismatch between data on the device and data on the server. For example, when a frontline worker edits a work order on their mobile app and a back-office dispatcher edits the same work order on their computer, neither of these modifications have yet been synchronized between them. Which modification should be applied to the record, both in the app and on the server, after the next synchronization takes place?

Conflict errors can be resolved based on the settings set by the administrator. A conflict is raised at the entity level and not per field.

To set conflict detection, go to **Settings** > **Mobile Offline** > **Mobile Offline Settings** and the **Mobile Client** tab.

> [!div class="mx-imgBorder"]
> ![Screenshot of Field Service settings showing the mobile offline menu option.](./media/mobile-powerapp-sync-conflict-navigate.png)

### Set conflict detection for mobile offline synchronization

- **No**: Data on the client device (mobile app) wins and there will be no sync errors. This setting is the default.

- **Yes**: Data on the server wins. The technician using the app may see errors informing them of conflict. In this case, while syncing changes to the server, you might see some errors that are automatically resolved. Client changes are overwritten by server values. Data on the device may be overwritten by data from the server. In this case, while syncing changes to the server, the technician using the application may see errors informing them of conflict.

> [!div class="mx-imgBorder"]
> ![Screenshot of system settings for Dynamics 365 showing the conflict detection setting.](./media/mobile-powerapp-sync-conflict.png)

Administrators can view past sync errors by going to **Settings** > **Sync Error**.

## Configuration considerations

#### Copy the offline profile 

While we recommend making changes directly to the default offline profile to receive updates, you can also copy the offline profile and make offline filter changes in the copy. The copy is considered unmanaged and will not receive any updates. If you make changes to the default offline profile and want to see the latest unadulterated offline profile, you can create a new trial of Field Service and view the included profile.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Power Platform admin center showing the copy option for the Field Service Mobile - Offline profile.](./media/mobile-2020-offline-profile-copy.png)




#### Known limitations

- Offline sync filters: If a record is created from the device while in offline mode, and that record does not meet filter conditions, then the record does not get resynchronized from the service until conditions are met.
- Offline sync filters: If commands or capabilities are set up to work with internet connectivity but not in offline mode, those capabilities should be reviewed to confirm they are calling correct APIs: ``` Xrm.WebApi.online```.
- [More platform supported capabilities and limitations for offline](../mobile-app/mobile-offline-capabilities.md)


### See also

- [What are model-driven apps in Power Apps?](/powerapps/maker/model-driven-apps/model-driven-app-overview)
- [Enable entities for mobile offline synchronization](../mobile-app/setup-mobile-offline-for-admin.md#step-1-enable-entities-for-mobile-offline-synchronization)


[!INCLUDE[footer-include](../includes/footer-banner.md)]