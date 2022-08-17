---
title: "Install the asset library add-on (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to install the real-time marketing asset library add-on in the Dynamics 365 Marketing settings."
ms.date: 08/01/2022
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

Assets are critical for meaningful and successful customer experiences. In Outbound Marketing and Trials, you can use the default image library which offers out-of-box solution for managing image files such as png, jpeg and gif. [Learn more](https://docs.microsoft.com/en-us/dynamics365/marketing/upload-images-files)

In real-time marketing, you can also install an Asset Library add-on that gives you access to different set of capabilities for managing digital assets such as images, files, and videos. Learn more. [Learn more](https://docs.microsoft.com/en-us/dynamics365/marketing/real-time-marketing-asset-library)

> [!NOTE] 
> Please note that add-on is not available for trials and customers in India, Brazil and United Arab Emirates.

## Capabilities

There are some functional differences between the two libraries, and it is up to each organization to decide, which one suit their needs better. Please see the comparison chart below:

| **Feature​** | **Default asset library​** | **Asset library add-on​** |
| --- | --- | --- |
| Access​ | Installed automatically​ | Needs installation​ |
| Availability​ | Outbound Marketing, Real-time marketing, Trials​ | Real-time marketing​ |
| Geo availability​ | All geos where D365 Marketing is supported​ | Not available in UAE, India, Brazil ​ |
| File type support​ | Images​ | Images, videos, documents​ |
| Tags​ | ✔ (keywords)​ | ✔​ |
| Alternative text​ | ❌​ | ✔​ |
| Automated tagging​ | ❌​ | ✔​ |
| Smart recommendations for images​ | ❌​ | ✔​​ |
| Bulk actions​ | ❌​ | ✔​ |
| Security roles for asset ownership​ | ✔​ | ❌​ |
| Business units​ | ✔​ | ❌​ |
| Application Lifecycle Management​ | ✔​ | ❌​ |
| Resizing of assets​ | ❌​ | ✔ (no UI support yet) |

## Installing the add-on

### Installation from asset library

You can install the asset library add-on from the Library. By default, all users will have the permissions to trigger installation and the permissions can be removed by system administrators.

1. Navigate to Images in Real-time marketing
2. Click "Library add-on" in the command bar
3. Trigger installation from the confirmation dialog

<img width="1367" alt="Screenshot 2022-08-17 at 21 59 30" src="https://user-images.githubusercontent.com/110179398/185231579-bdc3dd2d-d4e0-4704-bc20-04543ebb1ef1.png">

Please note this action may take up to 6 hours. You will be informed about the progress, and you can continue to use the default asset library in the meantime. If the installation fails, you can trigger it again.

### Installation from Settings

You can also install the asset library add-on from the Add-on page in Settings. By default, all users will have the permissions to trigger installation and the permissions can be removed by system administrators .

1. Navigate to Add-ons in Settings
2. Click "Install" on the Asset Library card
3. Confirm the action

![Asset library add-on](https://user-images.githubusercontent.com/110179398/185231664-626518c8-e9a2-4ee2-acee-65a39b4e1d33.png)

### Copy of assets

As mentioned in the table above, the asset library add-on does not have a support for security roles for asset ownership, therefore the copy of existing assets from the default library will start automatically only if you have sufficient permissions to access all assets.

If a user without permissions to all assets triggers the installation, the assets won't be copied over for security purposes.

> [!TIP]
> If your assets haven't been copied, you can go to Images in Outbound Marketing and click on Copy to Real-time marketing from there. Only assets that you have access to will be copied over so it is best to ask system admin for assistance.

## Uninstalling the add-on

The add-on can be uninstalled by users with delete permissions granted. To uninstall the add-on library:

1. Navigate to Add-ons in Settings
2. Click "Uninstall" on the Asset Library card
3. Confirm the action

> [!IMPORTANT]
> When uninstalling the add-on, assets that have been uploaded won't copied back to the default library. At present, the default library does not support the same file types for us to be able to do that. Assets that have been previously uploaded to the default library will still be available. If you want to use the assets that you have uploaded while the add-on was installed, please download them in bulk.
