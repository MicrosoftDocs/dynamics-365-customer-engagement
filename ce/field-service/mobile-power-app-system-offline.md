---
title: "Configure offline data for the Field Service (Dynamics 365) mobile app | MicrosoftDocs"
description: Learn how to configure offline data for the Field Service (Dynamics 365) mobile app.
ms.custom: 
  - dyn365-fieldservice
ms.date: 06/02/2021
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

# Configure offline capabilities in the Field Service (Dynamics 365) mobile app

Often frontline workers need to work in areas without internet access like remote areas or underground. Configure offline capabilities to allow frontline workers to continue using the Field Service (Dynamics 365) mobile app when there is no internet connection. 

With offline capabilities, important data is downloaded to the device for viewing when there is no internet, and updates made by the frontline workers are stored locally on the device and synced to the server when internet connection is restored. 

> [!div class="mx-imgBorder"]
> ![Device render showing offline status mode in Field Service (Dynamics 365) mobile app.](./media/mobile-2020-offline-complete.png)



>[!TIP] 
> Configuring offline capabilities creates a fast and consistent experience and is strongly recommended. 

Administrators can control what data is downloaded to the Field Service (Dynamics 365) mobile app with the offline profile. 

Configure offline capabilities in four steps:

1. Set up an offline profile (one exists by default).
2. Add users to the offline profile.
3. Edit and publish the offline profile as needed.
4. Add the offline profile to the Field Service mobile model-driven app. 

For a guided walkthrough, check out the following video.

> [!VIDEO https://www.microsoft.com/videoplayer/embed/RE4J8no]

## Step 1: Set up an offline profile

Offline record types, relationships, and user assignments are managed through your **Offline Profile**. 

Within your offline profile you can:

- Define record types that are available offline and their sync interval.
- Define filters for each record type. For example, by default only bookings that start within the next seven days are downloaded to the device. 
- Set up item association by creating relationships between entities. Item association saves time because you won't need to set filters for every record type; you can associate related record types that follow filters set on the related record type.

Go to the Power Platform admin center at [https://admin.powerplatform.microsoft.com/](https://admin.powerplatform.microsoft.com/), and find and select your environment.

Select **Settings** at the top.

> [!div class="mx-imgBorder"]
> ![The Power Platform admin center, on an environment, showing the settings option.](./media/offline-2020-ppac-settings.png)

Go to **Users + permissions section** > **Mobile configuration**.

> [!div class="mx-imgBorder"]
> ![The Power Platform admin center, showing the Mobile configuration option.](./media/offline-2020-ppac-mobile-configuration.png)

Field Service provides an out-of-the-box offline profile called **Field Service Mobile - Offline Profile** with recommended default settings for Field Service record types. 

> [!div class="mx-imgBorder"]
> ![The Power Platform admin center, showing mobile offline profiles.](./media/mobile-2020-offline-profile-ppac.png)

### Implementation guidance for the offline profile:

**Use the offline profile included with Field Service**. The default **Field Service Mobile - Offline Profile** provides an ideal starting point for offline configuration, with defaults for out-of-the-box record types and sync intervals. Use this profile and build upon it by including your custom record types. By working within the provided profile, default entities can still receive updates over time. With offline data, in-app performance such as displaying forms will be much better. Limiting the amount of data in the offline profile to what is needed by the user will improve sync performance.

**Avoid removing default record types from the offline profile**. These default record types are purposefully added to ensure the right data is available to the frontline worker. Focus on adding the record types you need to the offline profile rather than removing ones you don't need.

**Avoid using "All records" as an offline filter**. The offline profile is the gate that controls the amount of data downloaded to the frontline workers’ devices. To keep sync times fast and efficient, avoid including "All records" as an entity filter and avoid wide date ranges. For example, rather than downloading all customer asset records, download only the records related to scheduled work orders. This will reduce the number of customer asset records without impacting work that needs to be done. 

**Use offline JavaScript**. Organizations often need to run workflows on mobile devices to execute business processes. However, Power Automate flows only run when the device is connected to the internet or on the next sync. Use offline JavaScript to run workflows on the device quickly and without internet access. For more information, go to [Workflows and scripts for the Field Service (Dynamics 365) mobile app](mobile-power-app-workflows.md).

> [!div class="mx-imgBorder"]
> ![The Power Platform admin center, showing mobile offline profiles.](./media/mobile-2020-offline-profile-ppac.png)

## Step 2: Add users and teams to the offline profile

Open the **Field Service Mobile - Offline Profile**.  

Add users or [teams](/power-platform/admin/manage-group-teams) to the offline profile in the right **People with offline access** panel. When a team is added to the profile, the users within that team are displayed under the team, while individual users are displayed directly in the offline profile. Organizations with many users should use teams to help ease maintenance of user access.

A user or team can only be added to one offline profile one at a time. If a user or team is added to another offline profile, you will see a warning stating that the user is already part of a different offline profile. If you continue with the change, the user or team will be moved to the new profile. 

> [!div class="mx-imgBorder"]
> ![Screenshot of the Power Platform admin center, showing the section where to add users to the offline profile.](./media/mobile-2020-offline-profile-add-user.png)

## Step 3: Edit and publish the offline profile as needed

For each record type, you can choose a data download filter:

1. Download related data only.
2. All records. This is not recommended. 
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


## Step 4: Add the offline profile to the app

Go to your Dynamics 365 apps by going to `yourenvironment.crm.dynamics.com/apps`, then go to the app designer for Field Service mobile.

> [!div class="mx-imgBorder"]
> ![Screenshot of the app designer.](./media/mobile-2020-open-app-designer.png)

Go to **Properties** and add the offline profile you published if it's not already there. Remember to save and publish your changes if you add an offline profile.

> [!div class="mx-imgBorder"]
> ![Screenshot of the app designer, on the Field Service mobile properties tab.](./media/mobile-2020-add-offline-profiles.png)

> [!Note]
> Field Service customers can create additional offline profiles to enable scenarios where different user roles have different sync settings or entities available to them. For example, a Field Service manager may require seeing a broader scope of work orders that may not be assigned to the current operator of the mobile app. If you create a new offline profile, you'll need to add it to the Field Service mobile app in the app designer as well.

Sign into your mobile app, then go to **Settings** > **Offline Setting (globe icon)** to see the status of downloaded data.

> [!div class="mx-imgBorder"]
> ![Device render showing offline status mode in Field Service (Dynamics 365) mobile app.](./media/mobile-2020-offline-complete.png)

If data is not downloading, try signing out and signing back in. If offline data is still not downloading, make sure the user you are signing into the mobile app as has been assigned to a **Published** mobile offline profile. 

## Understanding offline vs. online capabilities

Once an offline profile is configured and user assigned, the mobile app _always_ runs offline-first; both with and without internet connection. This functionality optimizes performance and creates a consistent experience for frontline workers as they move through areas with and without internet connection. 

1.	**Online**: Occurs when there is internet but no offline profile is configured. The mobile app functions like using a Dynamics 365 app with internet on your PC. When internet is lost or diminished, the mobile app is unusable. Not recommended.
2.	**Offline First _without_ internet connection**: Data is downloaded to the device and all changes are saved locally to your mobile device. When internet is restored, the changes are synced to the server.
3. **Offline First _With_ internet connection**: Data is downloaded to the device and all changes are saved locally; but because there is internet connection, the user can manually sync to receive the latest data from the server like a new booking. The app will also automatically attempt to sync every few minutes. For more information, see [sync filters](#sync-intervals) in this article.

In summary, an Offline-First application will always read from local device database and only leverage an active internet connection during the synchronization process. This makes it important that your Offline Profile is configured to sync all data to the device which the front line worker will require during their working hours.

## Sync intervals

Sync intervals define how often record type data will automatically sync down to the users' devices. Sync intervals can be a minimum of five minutes or as long as one day. Records that change frequently can have a short duration sync interval, while infrequently changed records do not need to sync as often. With variable sync intervals, administrators have greater control over data and can help improve sync performance.

The default **Field Service Mobile - Offline Profile** has predetermined sync intervals for each record type, which is selected based on typical usage patterns of those record types. 

> [!Note]
> Even if the value for sync interval is set to be less frequent than **Every 1 hour**, data will still be synched every hour. A sync is only initiated when there is connectivity and when the app is actively running on the user’s mobile device. For Android devices, once the sync is initiated, it can be completed even when the app is in the background.
Dependencies based on selected relationships and custom filters that includes related tables are analyzed at each sync request. This might also result in a sync being triggered for related tables.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Power Platform admin center, showing the option to customize the records you want to make available offline.](./media/mobile-2020-offline-sync-filter.png)

> [!Note]
> Sync intervals are defined per record type with Field Service v8.8.40+. Prior to this version, all record types will have a five-minute sync interval.

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

### Should I make a copy of the offline profile?

It is recommended to use the mobile offline profile included with Field Service and then make offline filter changes directly in the *Field Service Mobile - Offline Profile*. Using the default offline profile allows your offline profile to receive updates to unchanges entity sync filters. You can also copy the default *Field Service Mobile - Offline Profile*, and make changes to the copy. The copy is considered unmanaged and will not receive any updates. If you make changes to the default offline profile and want to see the latest unadulterated offline profile, you can create a new trial of Field Service and view the included profile.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Power Platform admin center showing the copy option for the Field Service Mobile - Offline profile.](./media/mobile-2020-offline-profile-copy.png)

### Known limitations

- Offline sync filters: If a record is created from the device while in offline mode, and that record does not meet filter conditions, then the record does not get resynchronized from the service until conditions are met.
- Offline sync filters: If commands or capabilities are set up to work with internet connectivity but not in offline mode, those capabilities should be reviewed to confirm they are calling correct APIs: `Xrm.WebApi.online`.
- [More platform supported capabilities and limitations for offline](../mobile-app/mobile-offline-capabilities.md)

### See also

- [Set up mobile offline synchronization](/dynamics365/mobile-app/preview-setup-mobile-offline).
- [What are model-driven apps in Power Apps?](/powerapps/maker/model-driven-apps/model-driven-app-overview)
- [Enable entities for mobile offline synchronization](../mobile-app/setup-mobile-offline-for-admin.md#step-1-enable-entities-for-mobile-offline-synchronization)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
