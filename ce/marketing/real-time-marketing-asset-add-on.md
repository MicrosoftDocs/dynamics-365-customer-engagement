---
title: "Install the asset library add-on (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to install the real-time marketing asset library add-on in the Dynamics 365 Marketing settings."
ms.date: 09/05/2022
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

# Install the real-time marketing asset library add-on

Assets are critical for meaningful and successful customer experiences. In outbound marketing and trials, you can use the default image library as an out-of-the-box solution for managing image file types such as png, jpeg, and gif. Learn more: [Upload and use images and files in online content](upload-images-files.md).

In real-time marketing, instead of using the default image library, you can install the asset library add-on. This gives you access to a different set of capabilities for managing digital assets such as images, files, and videos. Learn more: [Real-time marketing asset library](real-time-marketing-asset-library.md).

> [!NOTE] 
> The real-time marketing asset library add-on is not available for trials and customers in India, Brazil, and United Arab Emirates.

## Default capabilities vs the real-time marketing asset library

There are some functional differences between the two libraries. It's up to you to decide which one suits your needs better. The table below compares the features of the two libraries:

| **Feature​** | **Default asset library​** | **Asset library add-on​** |
| --- | --- | --- |
| Access​ | Installed automatically​ | Needs installation​ |
| Availability​ | Outbound marketing, real-time marketing, trials​ | Real-time marketing​ |
| Geo availability​ | All regions where Dynamics 365 Marketing is supported​ | Not available in United Arab Emirates, India, and Brazil ​ |
| File type support​ | Images​ | Images, videos, documents​ |
| Tags​ | ✔ (Keywords)​ | ✔​ |
| Alternative text​ | ❌​ | ✔​ |
| Automated tagging​ | ❌​ | ✔​ |
| Smart recommendations for images​ | ❌​ | ✔​​ |
| Bulk actions​ | ❌​ | ✔​ |
| Security roles for asset ownership​ | ✔​ | ❌​ |
| Business units​ | ✔​ | ❌​ |
| Application Lifecycle Management​ | ✔​ | ❌​ |
| Resizing of assets​ | ❌​ | ✔ (No UI support yet) |

## Installing the add-on

You can install the real-time marketing asset library add-on from the asset library or from the Marketing settings.

### Installation from the asset library

By default, all users have the necessary permissions to trigger the asset library installation. System administrators can remove these permissions. To install the asset library add-on from real-time marketing:

1. Go to real-time marketing, then go to **Assets** > **Library** in the left navigation pane.
1. Select **Library add-on** in the command bar.
1. Trigger the installation from the confirmation dialog.

    > [!div class="mx-imgBorder"]
    > ![Asset add-on install from asset library.](media/real-time-marketing-asset-add-on-install.png "Asset add-on install from asset library")

> [!NOTE]
> This action may take up to six hours. You will be informed about the progress and you can continue to use the default asset library in the meantime. If the installation fails, you can trigger it again.

### Installation from settings

You can also install the asset library add-on from the add-on page in the settings. By default, all users have the necessary permissions to trigger the asset library installation. System administrators can remove these permissions. To install the asset library add-on from the settings:

1. Go to **Settings** in the area switcher then go to **Overview** > **Add-ons**.
1. Select **Install** on the asset library card.
1. Confirm the action.

    > [!div class="mx-imgBorder"]
    > ![Asset add-on install from settings.](media/real-time-marketing-asset-add-on-settings.png "Asset add-on install from settings")

### Copying assets

As mentioned in the table above, the asset library add-on doesn't support security roles for asset ownership. Therefore, copying existing assets from the default library will start automatically *only* if you have sufficient permissions to access all assets.

If a user without permissions to access all assets triggers the installation, the assets won't be copied over for security purposes.

> [!TIP]
> If your assets haven't been copied, you can go to **Images** in outbound marketing and select **Copy to real-time marketing** from there. Only assets that you have access to will be copied over, so it is best to ask your system administrator for assistance.

## Uninstalling the add-on

The add-on can be uninstalled by users with delete permissions granted. To uninstall the asset library:

1. Go to **Settings** in the area switcher then go to **Overview** > **Add-ons**.
1. Select **Uninstall** on the asset library card.
1. Confirm the action.

> [!IMPORTANT]
> When uninstalling the add-on, assets that have been uploaded won't be copied back to the default library. At present, the default library does not support the same file types to allow this capability. Assets that have been previously uploaded to the default library will still be available. If you want to use the assets that you have uploaded while the add-on was installed, download them in bulk before you uninstall the add-on.