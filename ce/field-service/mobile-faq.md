---
title: "Frequently asked questions for Field Service Mobile | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 09/30/2019
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