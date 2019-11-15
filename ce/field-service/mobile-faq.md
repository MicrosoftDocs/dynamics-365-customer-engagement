---
title: "Frequently asked questions for Field Service Mobile | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 10/28/2019
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: krbjoran
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: FieldServiceDave
manager: shellyha
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365FS
---


# Frequently asked questions for Field Service Mobile

> [!Note]
> If you're looking for help with **errors**, **unexpected behavior**, **crashes**, and **bugs**, create a [Dynamics 365 support ticket](https://dynamics.microsoft.com/contact-us/). 


## How do I extend or activate my mobile configuration tool (Woodford) trial?

The Mobile Configuration Tool (Woodford) is used to configure and customize the Field Service Mobile app. After [installing and setting up Field Service Mobile](https://docs.microsoft.com/dynamics365/field-service/install-field-service#download-the-field-service-mobile-app-on-a-phone-or-tablet), you'll need to activate or extend the Mobile Configuration Tool (Woodford) within 30 days. See the topic on [activating or extending the mobile configuration tool (Woodford) trial](activate-fs-mobile-app-license.md) for more details.

## What version of Field Service Mobile am I using?

See the topic on [identifying your Field Service Mobile version](mobile-faq-latest-version.md).

## What is the latest version of the mobile app and configuration tool?

See the topic on [Field Service version history](version-history.md) to understand the latest versions of Field Service, Field Service Mobile, Mobile Configuration tool (Woodford), and the mobile project template.

## My mobile app will not sync to the server or crashes immediately

There are a few reasons why your mobile application may not be syncing (or crashes when launched):

1. Incorrect URL, username, or password. This is the most common reason.
2. There is no mobile project in Woodford, or the mobile project is unpublished
3. The mobile project is published to a later version than the mobile app
4. Your user doesn't have the correct security role to access the mobile application

See the topic on [common reasons Field Service Mobile does not sync to the server or crashes](mobile-faq-sync-crash.md) for more details.

## Why can't I see my bookings when logged into the app?

There are typically 3 reasons bookings don't show up in the mobile app:

1. The mobile application isn't synced to the server
2. The application is in offline mode and the booking is outside the sync filters
3. Drip scheduling is enabled for the related resource and the booking is outside the bookings to drip number parameter

See the topic on [common reasons no bookings are displayed in Field Service Mobile](mobile-faq-bookings-not-showing.md) for more details.

## Bookings not scheduled to me show up when logged in to the mobile app

Ensure your mobile user has only the Field Service resource security role, see the topic on [seeing bookings not scheduled to me](mobile-faq-bookings-not-scheduled-to-me.md) for more details.


## What are the supported encodings for barcode scanning in Field Service Mobile?

Field Service Mobile supports the following barcode encoding:  
 
 | 1D product | 2D product | 3D product |
 | --- | --- | --- |
 | UPC-A | Code 39 | QR Code |
 | UPC-E | Code 93 | Data Matrix |
 | EAN-8 | Code 128 | Aztec (beta) |
 | EAN-13 | Codabar | PDF 417 (beta) |
 || ITF | MaxiCode |
 |||RSS-14 |
 ||| RSS-Expanded|


## Why is loading data in offline mode often faster than in online mode?

When in offline mode, the user is looking at data stored locally on the device's storage; and in online mode the mobile app is looking at data on the server. Retrieving local data from the device is always faster than retrieving remote data from the server. Offline performance is often better because the mobile application is not making calls directly to the Dynamics 365 database. 

Field technician don't typically need access to the entire Field Service entity database, so we recommend using sync filters in offline mode to filter the data that is downloaded to the device.

In online mode, certain logic will run instantly rather than waiting for a sync. If you'd like to work in online mode but not call so much data, there is an option to **Use Sync filter in Online Mode**  in the properties dialog of a view.


> [!div class="mx-imgBorder"]
> ![Screenshot of the option to use the sync filter in online mode](./media/use-sync-filter-online-mode.png)
 

## What attribute does the "Scan Customer Asset" match for and how do I edit it? 

From the Field Service Mobile app home screen, the **Scan Customer Asset** function will by default attempt to match the scanned code with the GUID of a customer asset.

This is dictated by Offline HTML within your mobile project in **Woodford** > **Offline HTML** > **CustomerAsset** > **ScanCustomerAsset.JS**. To change the function to look for a customer asset attribute other than the GUID, such as a custom serial number field, you can create your own JavaScript using JSBridge. 

> [!Note]
> Offline HTML and JavaScript that is included with Microsoft's mobile project should never be edited. You must create your own JavaScript.


## Can a mobile form appear differently between Windows, iOS, and Android devices?  

Yes. In the forms and views editor, you can select **Form Rules** and in the rule, you can choose configuration by platform. See the following screenshot for reference. 


> [!div class="mx-imgBorder"]
> ![Screenshot of forms and views editor](./media/mobile-form-rule-platform.png)


## Are Dynamics 365 Sales entities such as leads and opportunities available for use on Field Service Mobile? 

Any entity can be used in Field Service Mobile as long as it is used in the context of Field Service. That is, a field service representative who needs access to opportunities can have access to those, but a sales person could not use Field Service Mobile for sales functions. 


## Why isn't the total amount on the work order product being automatically calculated when marking the work order product as "Used"? 

This depends on the version of the app: 

- **For Field Service Mobile v11+**: When in offline mode, calculated fields such as **Total Amount** will not be calculated and populated until the user syncs to the server or goes in online mode because the calculations take place in the server and not the mobile app. This is especially advantageous for [entitlement capabilities](work-order-entitlements.md), which apply dynamic pricing to work order products and services based on different factors.

- **For Field Service Mobile 2016 and 2017 v9**: Subtotal and total amount are calculated in offline mode and online mode.

## How can field technicians chat with each other from their mobile devices? 

We recommend using Microsoft Teams or Microsoft's Kaizala. See the [topic on deeplinking to Teams](https://docs.microsoft.com/microsoftteams/platform/concepts/deep-links) from Field Service Mobile. 


## Why do users get the error "Your Organization has not configured the Field Service Mobile app with the correct project"?

This message means the mobile application has not been set up with the correct mobile project or the logged in user is getting access to an incorrect mobile project based on their security role. See the topic on [installing and setting up Field Service Mobile](https://docs.microsoft.com/dynamics365/field-service/install-field-service#download-the-field-service-mobile-app-on-a-phone-or-tablet) to set up the mobile app with Microsoft's mobile project as a base parent and [Field Service mobile project library](https://docs.microsoft.com/dynamics365/field-service/version-history#mobile-project-file-library) to see a list of previous mobile projects. 


## When field technicians are performing onsite service, can they connect to bluetooth devices?

Yes, on Android only. Field Service Mobile v11.3+ can use a bluetooth RFID reader. If you have a bluetooth RFID reader, you can connect it to Field Service Mobile. Connect the reader to your phone or tablet, then in Field Service Mobile, go to **Setup** > **RFID Bluetooth Reader** and select the reader you connected. Then whenever you tap the barcode button in the app, you will see the scanner. Then you can click the scanner's button.


## How do you add or edit a logo in Field Service Mobile?

See this [blog post](https://www.resco.net/woodford-user-guide/#__RefHeading__5907_1627906509) for more details.


## Why am I getting the error "UNSUPPORTED CUSTOMIZATION VERSION: App:23 Srv:25" in the Field Service Mobile app? 

If you're receiving this error, it means that you published the mobile project to a version that is higher than your app supports.
Try publishing the mobile project again to match the version of the app. For instance, for Field Service Mobile v11.2, publish to 11.2.

> [!div class="mx-imgBorder"]
> ![Screenshot of the mobile configurator, showing the publish version](./media/mobile-faq-configurator-version.png)

## Can I use the Dynamics 365 mobile application to access Field Service? 

We strongly recommend using the Field Service Mobile app to access Field Service, rather than the Dynamics 365 mobile app with the Unified Interface. While the native Dyanmics 365 app does work in offline mode, it doesn't fully support offline mode for Field Service-specific scenarios. For more information, visit our topic on Field Service Mobile.
