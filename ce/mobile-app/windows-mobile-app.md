---
title: "Navigating the Dynamics 365 (Preview) app for Windows (Dynamics 365 apps)| MicrosoftDocs"
ms.custom: 
description: How to use the Dynamics 365 (Preview) app for Windows
ms.date: 01/29/2021
ms.reviewer: kvivek
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: Dynamics 365 apps
ms.assetid: 6828239b-1645-4710-a192-0014acb03198
caps.latest.revision: 1
ms.author: mkaur
author: mduelae
manager: kvivek
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Sales
---

# Basic navigation for Dynamics 365 (Preview) app for Windows

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

Use the Microsoft Dynamics 365 (Preview) app for Windows to run your customer engagement apps in Dynamics 365 (such as Dynamics 365 Sales, Dynamics 365 Customer Service, and Dynamics 365 Marketing) on your mobile device.

With early access, you can also use Dynamics 365 (Preview) app for Windows in offline mode. Offline mode is described [later in this topic](#set-up-mobile-offline-for-admins).

## Install Dynamics 365 (Preview) for Windows

Install the app from the Windows app store: [Install Microsoft Dynamics 365 (Preview) app for Windows](https://www.microsoft.com/store/apps/9N0RWZ9KZZT8)

**Note for administrators**: To distribute the app automatically, use the Microsoft Store for Business and Education to find, acquire, distribute, and manage apps for your organization or school. Configuration Manager supports managing Microsoft Store for Business apps on both Windows 10 devices with the Configuration Manager client and Windows 10 devices enrolled with Microsoft Intune. More information: [Manage apps from the Microsoft Store for Business and Education with Configuration Manager](/mem/configmgr/apps/deploy-use/manage-apps-from-the-windows-store-for-business)

## Sign in

Sign in to Dynamics 365 (Preview) app for Windows by using your work email address for the Dynamics 365 app that you use. If you need help with your sign-in information, contact your Dynamics 365 administrator.

1. On the Welcome screen, select **Sign in**.

   > [!NOTE]
   > If your administrator instructs you to change your region setting, select the gear icon ![Settings](media/gear-icon-1.png "Settings"), and then select your region. The default is **Global**.

     ![Sign in](media/wpsignin-1.png "Sign in").

2. Enter your email address, select **Continue**, enter your password, and then select **Sign in**.

    > [!div class="mx-imgBorder"] 
    > ![Enter your email address](media/enter-email-address-2.png "Enter your email address")

3. From the list of apps that you have access to, select the app that you want to use.

    > [!div class="mx-imgBorder"] 
    > ![Choose an app](media/choose-your-app-3.png "Choose an app")

### Show non-production apps

By default, only production model-driven apps are shown in the list of apps. You can change this default setting.

1. On the **Apps** page, select **More**.

    > [!div class="mx-imgBorder"] 
    > ![See non-production apps](media/nonprod-4.png "See non-production apps")

2. Select **Settings**.

   > [!div class="mx-imgBorder"] 
   > ![Select the setting to see non-production apps](media/show-nonprod-apps-5.png "Select the setting to see non-production apps")

3. Under **Model apps**, turn on the **Show non-production apps** toggle.

    > [!div class="mx-imgBorder"] 
    > ![Show non-production apps toggle](media/toggle-on-6.png "Show non-production apps toggle")

4. Select the back arrow to go back to the **Apps** screen.

   > [!div class="mx-imgBorder"] 
   > ![Go back to list of apps](media/go-back-to-appspage-7.png "Go back to list of apps")

## Home screen

Use the home screen to get to your work area, create a new record, search, switch apps, and more.

> [!div class="mx-imgBorder"] 
> ![Home screen on a Windows mobile app](media/d365winodsapp-9.png "Home screen on a Windows mobile app")

Legend:

1. **Site map**: Select to expand or minimize the site map.
2. **Recent items**: View a list of records you recently used.
3. **Pinned items**: View and open your favorite (pinned) records.
4. **Entity navigator**: This area lists the entities available in the app.
5. **Area switcher**: Open this menu to move to another work area. The current work area is named here.
6. **Click to change app**: Select the current app name to go to the **Apps** page and select a different app.
7. **Go back**: Select to go back to the previous page. **Go back** is available on the form, view, and dashboard pages.
8. **Search**: Search for records in your app.
9. **Task flow**: Start automated task flows for common tasks.
10. **Relationship Assistant**: Use the assistant to monitor and track daily actions and communications.
11. **Add record**: Create a new record.
12. **Offline Status**: Work in offline mode when you don't have internet access.
13. **Advanced find**: Find the records you want in your app by using the advanced find search option.
14. **Add activity**: Create a new activity record.
15. **Settings**: Access app settings.
16. **Help**: Access online help.
17. **User info and sign out**: Access your user information, sign out of the app, or reconfigure the app.

## Site map

On the left pane, select **Site map** ![Site map](media/dyn365-sitemap.png "Site map") to expand or minimize the site map.

> [!div class="mx-imgBorder"] 
> ![Expand or minimize the site map](media/wp_sitemap-10.png "Expand or minimize the site map")

## Pin favorite records

The **Pinned** and **Recent** lists provide quick access to records that you've recently used or pinned to favorites. Use the **Recent** list to pin favorite records.

1. On the site map, select **Recent** ![Recent items](media/recent-items-icon.png).

2. From the list of records, select **Add to Pinned** ![Add to pinned items](media/add-to-pinned-button.png) next to the record that you want to add to favorites.

3. When the record is pinned, you'll see a pin next to the record name.

   > [!div class="mx-imgBorder"] 
   > ![Shows pinned records](media/wp-pinned-records-11.png "Shows pinned records").

## Remove records from pinned items

1. On the site map, select **Pinned** ![Pinned items](media/pinned-button.png).

2. Select **Remove from Pinned** next to the record that you want to remove from the favorites list.

   > [!div class="mx-imgBorder"] 
   > ![Remove from pinned items](media/remove-from-pinned-12.png "Remove from pinned items")

## Record set navigation

Navigate through multiple records by using record set navigation. The record-focused navigation improves productivity by letting you jump from record to record in the list and easily navigate back without losing your working list.

The number of records that you see in the record set navigation pane is based on the number of records that your system administrator has defined for the subgrid (record type).

**To use record set navigation**

1. On the left pane, select the type of record that you want to open. For example, **Contacts**.
2. Open a contact record, and then select **Open record set** ![Open record set](media/wp-record-set-nav-button.png "Open record set") to open all records in the list and easily move from one record to another.

   > [!div class="mx-imgBorder"] 
   > ![Open record set navigation](media/wp-recordset-nav.png "Open record set navigation")

## Change views

Each record type has system views and personal views. System views are
default views that already existed in the system or were created by your system customizer. Personal views are views that you created, or another user created and shared with you.

**To change a view**

1. Select a record type. For example, **Contacts**.

   > [!div class="mx-imgBorder"] 
   > ![Select a record](media/select-view-13.png "Select a record")

2. Expand the menu, and then select the view you want.

   > [!div class="mx-imgBorder"] 
   > ![Expand the menu to change your](media/select-view-14.png "Expand the menu to change your view").

## Add a record quickly

1. On the command bar, select **Add** ![Add](media/add-record-button.png "Add").

2. Select the type of record that you want to create.

   > [!div class="mx-imgBorder"] 
   > ![Select the type of record to add](media/add-new-record-15.png "Select the type of record to add")

3. Fill in the required fields, and then do one of the following:<br>Select **Save and Close**.<br>or<br>Expand the menu, and then select **Save & Create New**.

   > [!div class="mx-imgBorder"] 
   > ![Save the record](media/save-new-record-16.png "Save the record")

## Edit a record

1. Select a record type. For example, **Contacts**.

   > [!div class="mx-imgBorder"] 
   > ![Select a record](media/select-view-13.png "Select a record")

2. From the list of records, select the record that you want to edit.

   > [!div class="mx-imgBorder"] 
   > ![Select a record to edit](media/wp-edit-record-17.png "Select a record to edit")

3. When you're done editing the record, it's automatically saved.

## Sign out

To sign out, select the profile button, and then select **Sign out**.

> [!div class="mx-imgBorder"] 
> ![Sign out](media/sign-out-8.png "Sign out")

## Set up mobile offline (for admins)

To allow users to use Dynamics 365 (Preview) app for Windows in offline mode, a Dynamics 365 administrator will need to set up mobile offline for your organization. More information: [Set up mobile offline synchronization](setup-mobile-offline.md)

## Work in offline mode (for users)

When your admin has enabled mobile offline, the next time you access the mobile app, you'll be prompted to download offline updates. After you download the updates, you can start using the mobile app in offline mode.

1. When you see the dialog box that asks you to download updates to work offline, select **Download**.

   > [!div class="mx-imgBorder"] 
   > ![Select download](media/download-offline-updates-18.png "Select download")

2. Offline data automatically starts downloading in the background. You'll get a notification when the download is complete.

   > [!div class="mx-imgBorder"] 
   > ![Download is complete](media/offline-notification-19.png "Download is complete")

## Download offline data later

If you didn't download offline data and selected **Skip for Now**, you can still download offline data when you're ready.

1. Open your app and on the nav bar, select the Wi-Fi button.

   > [!div class="mx-imgBorder"] 
   > ![Select the Wi-Fi button](media/offline-updates-wifibutton-20.png "Select the Wi-Fi button")

2. On the **Offline Status** panel, select **Download offline updates**.

   > [!div class="mx-imgBorder"] 
   > ![Select to download offline updates](media/later-download-offline-updates-21.png "Select to download offline updates")

3. Offline data automatically starts downloading in the background. You'll get a notification when the download is complete.

## See whether offline mode is available

When updates are downloaded, you can check to see whether mobile offline mode is available. Open your app, and on the nav bar, select the Wi-Fi button.

> [!div class="mx-imgBorder"] 
> ![Select the Wi-Fi button](media/offline-updates-wifibutton-20.png "Select the Wi-Fi button")

The **Offline Status** page provides information about your offline status.

> [!div class="mx-imgBorder"] 
> ![Offline status page](media/workoffline-legend-22.png "Offline status page")

**Legend**

1. **Status**: Tracks the offline status of the whole app and the status of each individual entity. When the status appears as **Available**, offline mode is available and data has been synced successfully.
2. **Entity**: Provides the offline status of each entity individually. For the available entities, you can also track the last time the entity was synced. Data is synced periodically in the background to ensure that you have access to the latest data when you go offline.
3. **Last Sync Date**: Indicates the last time your data was synced with the server.
4. **Work in offline mode**: Turn offline mode on or off with this toggle.

## Work in offline mode

When you turn on the **Work in offline mode** toggle, you'll see the notification "You are now working in offline mode."

> [!div class="mx-imgBorder"] 
> ![Notification that you're working in offline mode](media/offlinemode-notification-23.png "Notification that you're working in offline mode")

## Get back online and sync your changes

When you go back online, changes you've made are synchronized with your app.

1. On the nav bar, select the Wi-Fi button.

   > [!div class="mx-imgBorder"] 
   > ![Select the Wi-Fi button](media/offline-updates-wifibutton-20.png "Select the Wi-Fi button")

2. Set the **Work in offline mode** toggle to off.

3. When you're back online, you'll get the notification "The connection was successfully restored." Your changes are automatically synchronized with your app.

   > [!div class="mx-imgBorder"] 
   > ![Notification when you're back online](media/offline-mode-turn-off-24.png "Notification when you're back online")

## Reconfigure the app

If you run into issues, you can always reconfigure the app. Select the profile button, and then select **Reconfigure**.

> [!div class="mx-imgBorder"] 
> ![Reconfigure the app](media/reconfigure-25.png "Reconfigure the app")

## Send feedback

To send feedback about the app, go back to the **Apps** page, and then select **More** > **Send feedback**.

> [!div class="mx-imgBorder"] 
> ![More button](media/more-settings-button.png "More button")

## Known issues and unsupported features

### Web resources are not supported for offline

Web resources are not supported for Windows devices for offline mode.

### Media capture isn't supported

You can add notes, but can't capture and attach photos, videos, or audio. However, you can attach local files of any type, including photo, video, or audio.  

### Can't use the barcode scanner

You'll see the barcode scanner button ![Barcode scanner](media/scannerbutton.png "Barcode scanner") on multiple forms; however, it isn't supported in early access.

### Embedded Power BI and report canvas won't render

No embedded Power BI dashboard will be rendered if it requires authentication to access the report.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
