---
title: "Frequently asked questions for Field Service Mobile | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 10/16/2019
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

The Mobile Configuration Tool (Woodford) is used to configure and customize the Field Service Mobile app. After [installing and setting up Field Service Mobile](https://docs.microsoft.com/en-us/dynamics365/field-service/install-field-service#download-the-field-service-mobile-app-on-a-phone-or-tablet) you will need to activate or extend the Mobile Configuration Tool (Woodford) within 30 days. See the topic on [activating or extending my mobile configuration tool (Woodford) trial](activate-fs-mobile-app-license.md) for more details.

## What version of Field Service Mobile am I using?

See the topic on [identifying your Field Service Mobile version](mobile-faq-latest-version).

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

## Bookings not scheduled to me show up when logged into the mobile app

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

It is rare for a field technician to need access to the entire field service entity database so it is recommended to use sync filters in offline mode that filters the data that is downloaded to the device.

If you'd like to work in online mode but not call so much data, there is an option to **Use Sync filter in Online Mode**  in the properties dialog of a view.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/use-sync-filter-online-mode.png)
 

## Question3: Did someone by chance change our Scan Customer Asset code to query an asset by serial number, not GUID? I assume we implemented this approach because it was a low hanging fruit, but in reality 100% of my customers wanted to search for serial number, not create new QR codes based on GUIDs.

Answer3: this can be modified by using offline html and JSBridge. This is controlled by replaces the JS in Woodford>Offline HTML>CustomerAsset, but OOB offline HTML should never be edited so it can be upgraded.

## Question4: Is there a way to have an entity form be device specific.   If there are 2 forms in the same project is it possible to load a specific form based on the device even using JSBridge is acceptable.  I have a scenario where the same user will be logging in from a laptop and smart phone.  On the phone the customer would like forms to have fewer fields to maximize the screen realestate. 

Answer4: There's definitely Form Rules to change Forms based on Platform:
If you go into the HTML5 Configurator and into the Forms/Views editor, then you can select Form Rules:
 
 
 
and in the Rule, you can choose configuration by platform:
 
I believe it's also possible to have a configuration based on width; but I think it's a bit more explicit (specific number of pixels, if wider than X, display form Y), but I haven't gotten that far with configuration.

## Question5: Are the Sales Entities (Leads, Opportunities, etc) still out of scope in our mobile app?
Answer5: Any entity can be used in our app SO LONG as it is used in the context of Field Service. That is, a field service rep who needs access to opportunities can have access to those. BUT a sales person could not use our app to do purely sales stuff. Sales folks should use a D365 model app, power app, or a 3rd party (e.g. Resco).


## Question6: Is the Total Amount on the Work Order Product supposed to automatically calculate when marking the Work Order Product to Used? Right now it does not automatically do that...
Answer6: assuming you are working in offline mode, after you sync with the server, that value should get populated. In FSM 2016/2017 we were doing subtotal and total calculations in the app C# code for offline, but now with all of our logic in JS in the mobile project, we found that JavaScript does not play nicely with calculations when it comes to all sorts of different currencies. As such, we have moved away from supporting WO product/service total/subtotal calculations due to the limitations of JavaScript when it comes to precise calculations. JavaScript makes use of 64-bit floating point representation, which introduces complications when performing calculations that must be precise.
Entitlement capability coming, this is no longer be feasible. When a WOP or WOS is eligible for an Entitlement, this won't currently be applied until after they sync, especially as the Entitlement Allocation Types get more complex with Limit-based entitlements. It will likely never make sense to try to enable this offline from the mobile device due to the complexity of the application logic. 




## Question7: what is recommended way for field techs to chat?
Answer7: Kaizala or Teams https://docs.microsoft.com/en-us/microsoftteams/platform/concepts/deep-links


## Question8: Error "Your Organization has not configured the Field Service Mobile app with the correct project"

Answer8: This message means that the project the user is getting is not our project for Field Service Mobile.



## Question9: Bluetooth, Someone may asked this before, But can't find any information. I have 3 on-going projects, they all ask same questions. When service technician doing onsite service, they will perform some device test(network speed, or Bluetooth reading etc). They want device test being triggered by Fields Service mobile and return data to Field service mobile. Testing needs to be done by Bluetooth. is it possible. Does anyone done similar thing before.  Using Resco SDK, Offline HTML?  or JS Bridge

Answer9: What we support in v11.3 of FSM is the ability to use a bluetooth RFID reader in conjunction with FSM. That is, if you have a bluetooth RFID reader, you can connect that to FSM. First connect that reader to your phone/tablet, then in FSM go to Setup > RFID Bluetooth Reader and select the reader you connected. Then whenever you click on the barcode button in the app you will see the scanner at which point you can click the scanner's button. It is only supported on Android.




## Question10: Does anyone know how to add logo to field service mobile, I try to add one but didn't show up. any trick?

Answer10: https://www.resco.net/woodford-user-guide/#__RefHeading__5907_1627906509


