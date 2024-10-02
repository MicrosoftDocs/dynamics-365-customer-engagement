---
title: Dynamics 365 Field Service mobile app troubleshooting
description: Learn how to troubleshoot issues in the Dynamics 365 Field Service mobile app.
ms.date: 08/28/2024
ms.topic: troubleshooting
author: JonBaker007
ms.author: jobaker
ms.custom: bap-template
---

# Dynamics 365 Field Service mobile app troubleshooting

This article lists common issues with the [Field Service mobile app](set-up-field-service-mobile.md) and steps to resolve them. You need administrator permissions in Field Service for all resolution steps.

## Error on start due to permission/privilege issues

The new user experience for the Field Service mobile experience requires some privileges added to the security roles that the user belongs to.

### Symptoms

The Field Service mobile app fails to launch with the following error: `Principal user (Id=<GUID>, …) is missing 'prvReadmsdyn_Mobile' privilege (Id=<GUID>) on OTC=<INT> for entity 'msdyn_mobilesource' …`

### Resolution

The new experience for Field Service mobile app requires privileges for users' security roles. The system automatically adds these privileges to all default security roles. If your organization uses custom security roles, you need to [edit the security roles](/power-platform/admin/create-edit-security-role) by adding the following [table privileges](/power-platform/admin/security-roles-privileges#table-privileges):

- Name=`"msdyn_richtextfile"` Permission="Create" Value="User"
- Name=`"msdyn_richtextfile"` Permission="Delete" Value="User"
- Name=`"msdyn_richtextfile"` Permission="Read" Value="User"
- Name=`"msdyn_richtextfile"` Permission="Write" Value="User"
- Name=`"msdyn_MobileSource"` Permission="Read" Value="Organization"
- Name=`"msdyn_solutioncomponentsummary"` Permission="Read" Value="Organization"
- Name=`"SettingDefinition"` Permission="Read" Value="Organization"
- Name=`"Solution"` Permission="Read" Value="Organization"
- Name=`"SettingDefinition"` Permission="Read" Value="Organization"

> [!TIP]
> If you don't know the name of the custom security role, expand **Users + permissions**, select **Users** and look for the user that is reported seeing the error message. Take note of the user's security role and review the table privileges for that security role.

## Error on start due to missing files in the solution

### Symptoms

Some required source records are missing. These records should be created when installing the solution. In rare cases, these records don't get created successfully or corrupted. In some cases, a user deleted the records.

### Resolution

#### Step 1: Check if the mobilesource table contains data

1. Go to [Power Apps](https://make.powerapps.com/) and open the environment to check.

1. Select **Tables**, choose the **All** filter and search for the table `MobileSource (msdyn_mobilesource)`.

1. Select the table and verify if the table contains the following data in the **Name** column: 

   - /card/bookingListViewItem.yml
   - /card/defaultViewItem.yml
   - /card/serviceTaskGridItem.yml
   - /sitemaps/mobile.yml

If there's no data in the table, something went wrong with the solution update.

#### Step 2: Apply the Field Service solution update again

1. In [Power Apps](https://make.powerapps.com/), open your environment and go to **Solutions**.

1. Search for `fieldservice_anchor` and delete the `FieldService_Anchor` solution.

1. Go to [Power Platform admin center](https://admin.powerplatform.microsoft.com/environments) and select the environment in which you deleted the solution.

1. In the environment details, under **Resources**, select **Dynamics 365 applications**.

1. Select **Install app**, choose **Dynamics 365 for Field Service** and select **Next**.

1. Accept the terms of service and select **Install**.

After installing the solution, [verify that the table now contains the required data](#step-1-check-if-the-mobilesource-table-contains-data).

## Settings area is missing in the Field Service Mobile app module navigation

### Symptoms

The Field Service Mobile app module doesn't show the settings area, blocking administrators to enable the new experience.

### Resolution

The new mobile experience settings toggle is available through a new navigation area that comes with the default Field Service Mobile app module. Users need *write* permissions for the `FieldServiceSetting` entity to access this area. Default security roles like System Admin or Field Service Admin roles have that permission automatically.

If any customizations were made on the sitemap of the out-of-box Field Service Mobile app module between release version 6.1 and 6.3 in 2023, there are two options to enable the settings area:

- [Remove the sitemap customization layer and manually customize it again](#remove-the-sitemap-customization-layer-and-manually-customize-it-again).
- [Manually add the settings area and toggle to the sitemap](#manually-add-settings-area-and-toggle-to-sitemap).

#### Remove the sitemap customization layer and manually customize it again

First, check whether the sitemap area exists on the default Field Service Mobile solution layer but a customization layer overrides it:

1. Sign in to [Power Apps](https://make.powerapps.com).
1. Change to your environment and open `fieldservice_patch_update` solution.
1. [View the solution layers](/power-apps/maker/data-platform/solution-layers) for the `msdyn_FSMobileSettingsArea` component in the `fieldservice_patch_update` solution.

If the area is present, a customization layer on the sitemap sits on top, which removes the area. In that case, there are two options:

1. Remove the customization layer and then manually customize the sitemap again:
   1. [Remove the unmanaged customization layer](/power-apps/maker/data-platform/solution-layers#remove-an-unmanaged-layer).
   2. Apply the [sitemap customizations](/power-apps/maker/model-driven-apps/create-site-map-app) again.
2. [Manually add the Settings area and toggle to the sitemap](#manually-add-settings-area-and-toggle-to-sitemap).

#### Manually add settings area and toggle to sitemap

1. Open your customized app in the App Designer.
1. [Enable areas and create a new area](/power-apps/maker/model-driven-apps/app-navigation#create-an-area) for the Field Service Mobile settings.
1. [Create a new group](/power-apps/maker/model-driven-apps/app-navigation#create-a-group) for the mobile settings
1. [Add a new page to the group](/power-apps/maker/model-driven-apps/app-navigation#create-a-page). Select **URL** for content type.
1. Use `/main.aspx?etn=msdyn_fieldservicesetting&pagetype=entityrecord&id=e49c6117-5065-423f-8ab5-fcacfda85a04&formid=ee334fea-0cd5-471c-bb30-829f4511a59f` as URL input.
1. Add a child area for new features. Under **ID**, expand **Advanced settings** and **privileges**.
1. Select **Add table privilege**, choose **Field Service Setting** and select only the **Write** privilege.
1. **Apply** the change, then **Save and Publish** them.

## The new experience doesn't show after enabling it in settings

### Symptoms

The mobile app doesn't load the new experience, even if it has been [enabled in the settings](set-up-field-service-mobile.md).

### Resolution

The new experience currently doesn't support users or apps with offline enabled. Verify and update the following cases:

1. The user of the mobile app must not be part of the Mobile Offline Profile.
1. The app itself shouldn't be set up for offline. In the app designer, open **Field Service Mobile** and open **Settings** for the app. On the **General** tab, turn off **Can be used offline**. For more information, see [Set up mobile offline](/power-apps/mobile/setup-mobile-offline#enable-your-app-for-offline-use-preview).

## The new experience doesn’t show dashboards from the navigation

### Symptoms

Dashboards configured in the navigation aren't supported. Selecting a dashboard from the new UX results in an error. When a dashboard is configured as the first entity in the navigation for the new experience, the home experience doesn't render correctly.

### Resolution

Remove dashboards from the navigation until it's officially supported.

## The new experience doesn’t reflect configuration changes to Agenda and Lists right away

### Symptoms

After updating a View to change data in the Agenda or List experience, the changes are not reflected on the users device right away.

### Resolution

The application will cache changes for up to 24 hours. To see those changes, the user would need to wait, or sign out and back into the application. 

