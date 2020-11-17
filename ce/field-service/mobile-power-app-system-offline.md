---
title: "Configure offline data for the Field Service (Dynamics 365) mobile app | MicrosoftDocs"
description: Learn how to configure the Field Service (Dynamics 365) mobile app.
ms.custom: 
  - dyn365-fieldservice
ms.date: 10/30/2020
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: FieldServiceDave
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: daclar
manager: shellyha
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365FS
---


# Configure offline data and sync filters

Administrators can control what data is downloaded to the Field Service (Dynamics 365) mobile app in offline mode when no internet access is available. Offline configuration is achieved by:

1. Setting up an offline profile (one exists by default).
2. Adding users to the offline profile.
3. Publishing the offline profile.
4. Adding the offline profile to the Field Service Mobile model driven app. 

> [!div class="mx-imgBorder"]
> ![Device render showing offline status mode in Field Service (Dynamics 365) mobile app.](./media/mobile-2020-offline-complete.png)

> [!Note]
> When the technician has internet connectivity, data on the device will automatically be refreshed at a minimum interval of five minutes.

For more information on offline profiles, see the article on [setting up mobile offline synchronization](https://docs.microsoft.com/dynamics365/mobile-app/preview-setup-mobile-offline). 

## Set up an offline profile

Go to the Power Platform admin center at [https://admin.powerplatform.microsoft.com/](https://admin.powerplatform.microsoft.com/), and find and select your environment.


> [!div class="mx-imgBorder"]
> ![Screenshot of the Power Platform admin center showing environments.](./media/offline-2020-ppac.png)

Select **Settings** at the top.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Power Platform admin center, on an environment, showing the settings option.](./media/offline-2020-ppac-settings.png)

Go to **Users + permissions section** > **Mobile configuration**.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Power Platform admin center, showing the Mobile configuration option.](./media/offline-2020-ppac-mobile-configuration.png)

Offline entities, relationships, and user assignment is managed through your **Offline Profile**. Field Service provides an out-of-the-box offline profile called **Field Service Mobile - Offline Profile** with recommended default settings for common Field Service entities. This profile can be updated based on unique business needs.

Within your offline profile you can:

- Define entities which are available offline.
- Define filters for each entity. For example, by default we set a filter to only get the bookings entity within a range of seven days before or after current date.
- Setup item association by creating relationships between entities. This will save time where you will not need to set filters for every entity rather you can associate related entities which will follow filters set on the related entity.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Power Platform admin center, showing mobile offline profiles.](./media/mobile-2020-offline-profile-ppac.png)

Choose the **Field Service Mobile - Offline Profile**, which is the default configuration for offline data that is included with the Field Service app.

Add the users who need to work offline in the right **People with offline access** panel. Users must be added here in order to download data offline.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Power Platform admin center, showing the section where to add users to the offline profile.](./media/mobile-2020-offline-profile-add-user.png)

For each entity, you can choose a data download filter:

1. Download related data only.
2. All records.
3. Other data filter.
4. Custom data filter.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Power Platform admin center, showing the edit bookable resource booking entity options.](./media/mobile-2020-offline-ppac-options.png)

For example, the **Bookable Resource Booking** (in other words, the booking) entity has a data download filter set to **custom data filter** that downloads resource bookings that start or end in the next seven days or today.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Power Platform admin center, showing the set filter logic.](./media/mobile-2020-offline-ppac-brb-custom-filter.png)

**Save and Publish** the offline profile.

## Add the offline profile to the app

Go to your Dynamics 365 apps by going to ```yourenvironment.crm.dynamics.com/apps```, then go to the app designer for Field Service Mobile.

> [!div class="mx-imgBorder"]
> ![Screenshot of the app designer.](./media/mobile-2020-open-app-designer.png)

Go to **Properties** and add the offline profile you just published if it is not already there.

> [!div class="mx-imgBorder"]
> ![Screenshot of the app designer, on the Field Service Mobile properties tab.](./media/mobile-2020-add-offline-profiles.png)

> [!Note]
> Field Service customers can create additional offline profiles to enable scenarios where different user roles have different sync settings or entities available to them. For example, a Field Service manager may require seeing a broader scope of work orders that may not be assigned to the current operator of the mobile app. If you create a new offline profile, you'll need to add it to the Field Service Mobile app in the app designer as well.


## Configuration considerations

### Offline sync filters

- **Offline profiles get updated**. The default offline profile may receive updates over time, but updates will come in an unpublished state. This allows organizations to review the updates and decide if they want to take the update or continue with previous version. If entities in the default offline profile are modified, those entities will be considered unmanaged and won't receive future updates while unmodified entities are still eligible for update.

- **Sync conflicts.**  Sync conflicts can happen if there is a mismatch between data on the device and data on the server. A conflict is raised at the entity level and not per field. Conflict errors can be resolved based on the settings set by the administrator. If your administrator has set the conflict resolution to "No," then the data value on your client device wins and there will be no sync errors. This is the default value for Field Service Mobile. If your administrator has set the conflict resolution to "Yes," then the data value on the server wins. In this case, while syncing changes to the server, you might see some errors that are automatically resolved. Client changes are overwritten by server values.

### Known limitations

- Offline sync filters: If a record is created from the device while in offline mode, and that record does not meet filter conditions, then the record does not get re-synchronized from the service until conditions are met.
- Offline sync filters: If commands or capabilities are setup to work with internet connectivity but not in offline mode, those capabilities should be reviewed to confirm they are calling correct APIs: ```xml.webapi.online```.


### See also

- [What are model-driven apps in Power Apps?](https://docs.microsoft.com/powerapps/maker/model-driven-apps/model-driven-app-overview)
- [Enable entities for mobile offline synchronization](https://docs.microsoft.com/dynamics365/mobile-app/setup-mobile-offline-for-admin#step-1-enable-entities-for-mobile-offline-synchronization)