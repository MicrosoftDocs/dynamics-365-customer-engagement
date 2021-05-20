---
title: "Use deep links with the Field Service (Dynamics 365) mobile app | MicrosoftDocs"
description: description
ms.custom:
- dyn365-fieldservice
ms.date: 05/20/2021
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.topic: article
ms.suite: ""
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

# Use deep links with the Field Service (Dynamics 365) mobile app

Deep linking lets users move from one application to another on computers and mobile devices. Simple examples include a mobile application deep linking to Facebook to sign in, an email address deep linking to a mail app to compose a message, or a website deep linking to an app store to download the related mobile application. As multiple apps may be needed to complete onsite work, an organization can allow technicians to deep link from Field Service Mobile to other apps and vice versa.

## Open an entity record or entity list view in Field Service (Dynamics 365) mobile app

You can open an entityrecord or an entitylist view in the Field Service (Dynamics 365) application using deep link URLs from other applications. When you click on the link from an external application, the target element opens in Field Service (Dynamics 365) app for phones or tablets.

If you are already signed-in to your instance in the app, the target record is displayed when you click the link in external application. Otherwise, you're prompted to sign-in to your instance in the mobile client, and upon doing so, the target element is displayed. You must have Field Service (Dynamics 365) app for phones or tablets installed on your mobile device to use this feature.

## Query string parameters for the URL

Use the following application handler and query string parameters to compose the URL.

Deeplinks for Field Service should always start with the following:

    ms-apps-fs://<org-url>_<app-id>?tenantId=<tenant-id>&isShortcut=true&appType=AppModule&openApp=true&restartApp=true&forceOfflineDataSync=true

| **Parameter**        | **Description**                                                              |
|----------------------|------------------------------------------------------------------------------|
| &lt;org-url&gt;      | Connects to the correct org URL                                              |
| &lt;app-id&gt;       | Opens the correct app module                                                 |
| tenantId             | Connects to the correct tenant                                               |
| forceOfflineDataSync | Ensures that data sync is triggered so that all the latest data is available |

If opening an entityrecord form or creating a new entityrecord use the following params:

| Parameter                       | Description                                                                                            |
|---------------------------------|--------------------------------------------------------------------------------------------------------|
| etn=&lt;entity-logical-name&gt; | Designates which entity to navigate to                                                                 |
| pagetype=entityrecord           | Indicates that we are navigating to a form                                                             |
| extraqs=&lt;form-id&gt;         | Designates which form to open for the entityrecord, if not specified the default form will open        |
| id=&lt;record-id&gt;            | Designates which specific record to navigate to, if left blank it opens the create form for the entity |

If navigating to an entitylist view add the following parameters:

| **Parameter**                                                | **Description**                                                     |
|--------------------------------------------------------------|---------------------------------------------------------------------|
| etn=&lt;entity-logical-name&gt;                              | Designates which entity to navigate to                              |
| pagetype=entitylist                                          | Indicates we are navigating to a view                               |
| viewid=&lt;view-id&gt;                                       | Designates which view to open                                       |
| Viewtype= &lt;1039 if system view, 4230 if personal view&gt; | Designates whether we are going to a system view or a personal view |

**Example URLs**

| **Action**                                       | **Example Deep link URL**                                                                                                                                                                                                  |
|--------------------------------------------------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Open a create form for Bookable resource booking | ms-apps-fs:// &lt;org-url&gt;\_&lt;app-id&gt;?tenantId=&lt;tenant-id&gt;&isShortcut=true&appType=AppModule&openApp=true&restartApp=true&forceOfflineDataSync=true&etn=bookableresourcebooking&pagetype=entityrecord&id=    |
| Open a Bookable resource booking with id=xyz     | ms-apps-fs:// &lt;org-url&gt;\_&lt;app-id&gt;?tenantId=&lt;tenant-id&gt;&isShortcut=true&appType=AppModule&openApp=true&restartApp=true&forceOfflineDataSync=true&etn=bookableresourcebooking&pagetype=entityrecord&id=xyz |

