---
title: "Field Service Mobile (2020) | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 04/28/2020
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

# Field Service Mobile (2020)


Field Service Mobile (2020) is a mobile app designed and optimized for technicians to view Dynamics 365 Field Service work orders, customer assets, accounts and contacts. Different than Field Service Mobile (see feature comparison below), this alternative mobile app is built on Microsoft's Power Platform as a model-driven app and is customizbale to your business needs with the same admin console as all Dynamics 365 business apps.


Available natively for Apple iOS and Google Android phones and tablets, Field Service Mobile (2020) offers technicians many capabilities they need to perform on site customer service like a calendar view of assigned jobs, support for picture, video, and asset barcode scanning, customer signature capture, and offline capabilities so technicians can continue viewing and recording work in areas without internet.


## Implementation and migration guidance

It is recommended to continue using the existing "[Field Service Mobile](./field-service-mobile-app-user-guide.md)" mobile app for current and new deployments of Dynamics 365 Field Service. As development in Field Service Mobile (2020) continues through 2021, capabiltiies will become comparable to Field Service Mobile and system administrators should use the feature comparison information below to decide which mobile app is right for their organization or department.

During the period in which the new app continues to evolve, we will continue to make available and support the current Field Service Mobile app. Organizations which are using the current app as of May, 2021 can continue to use the app until June 30, 2022. 

## Feature comparison: Field Service Mobile (2020) and Field Service Mobile

Field Service Mobile (2020) is recommended for simpler use cases where administrators want to replicate a simpler version of the work order form for technicians. Because Field Service Mobile (2020) its built on the Power Platform and uses the same admin console as Field Service web, it is easy to set up and get started.

Field Service Mobile is recommended for more complex use cases where you may need to custom reporting, push notifications, geo fencing, and business processes or validations that work online and offline.


| Feature | Cateogry | Field Service Mobile (2020) | Field Service Mobile |
| --- | --- | --- | --- |
| Mobile Platform | Hardware & software | iOS, Android | iOS, Android, Windows |
| Camera capture (photo & video) | Technician | Yes | Yes |
| Barcode scanning | Technician | Yes | Yes |
| Offline data | Technician | Yes | Yes |
| Calendar view | Technician | Yes | Yes |
| Driving directions | Technician | Yes | Yes |
| Speech to text | Technician | Yes | Yes |
| Push notifications | Technician | | Yes |
| Multi entity maps | Technician | | Yes |
| Chat | Technician | | Yes |
| Geofencing | Technician | | Yes |
| IoT alerts | Technician | | Yes |
| Geocoding | Technician | Yes | Yes |
| Reporting | Technician | | Yes |
| Scan to find asset | Technician | | Yes |
| Editable grids | Technician | Yes | Yes |
| Location sharing and auditing | Admin | | Yes |
| Mobile workflows | Admin | | Yes |
| Enhanced offline sync filters | Admin | | Yes |
| Encryption | Admin | | Yes |
| Multiple configuration profiles | Admin | | Yes |
| Branding and theming | Admin | | Yes |
| Custom commands (Call, email, etc) | Admin | | Yes |
| View (Row) scripts | Admin | | Yes |
| Exchange | Integration | | Yes |
| Remote Assist | Integration | | Yes |
| Sharepoint | Integration | | Yes |
| Microsoft Intune  | Integration | | Yes |



## Prerequisites

Install or upgrade to **Field Service v8.8.22+**, the Field Service Mobile app will appear in your list of Dynamics 365 applications.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-2020-app-list.png)

Set up a Dynamics 35 Field Service user with the **Field Service-Resource** security role. This user will sign in to the Field Service Mobile (2020) app as a technician.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-2020-resource-secuirty-role.png)

To schedule work orders to view on the mobile app, you must also [create a bookable resource](./set-up-bookable-resources.md) related to your technician user.

Then, to view bookings on Field Service Mobile (2020) schedule work orders to the bookable resource related to your user.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-2020-scheduled-work-orders.png)

> [!Note]
>




## Install and set up Field Service Mobile (2020)

- Download from iOS or Android app stores
- Standalone app available in app store

- Sign in with Field Service resource user

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-2020-download-signin.jpg)




## Use Field Service Mobile (2020)

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-2020-download-offline.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-2020-booking-view.jpg)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-2020-work-order-navigate-directions-map.jpg)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-2020-work-order-service-notes.jpg)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-2020-sitemap-account.jpg)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-2020-offline.jpg)

## Configure Field Service Mobile (2020)

Log in as a system administrator



### Edit Sitemap entities on home screen

mobile-2020-admin-app-designer

mobile-2020-admin-sitemap1

mobile-2020-admin-sitemap2

mobile-2020-admin-sitemap3

can i put entities not in FS app in sitemap?

### Edit the Booking and Work Order form

- Fields and PCF controls

mobile-2020-admin-work-order-form

mobile-2020-admin-work-order-form-tabs

mobile-2020-admin-booking-form

mobile-2020-admin-booking-form-combined

mobile-2020-admin-booking-form-combined-add-fields

mobile-2020-admin-booking-form-combined-classic

mobile-2020-admin-booking-form-combined-classic-control


    <QuickForms><QuickFormIds><QuickFormId entityname="msdyn_workorder">c0ebdf20-f27f-4acc-8c9f-a9a202a5e917</QuickFormId></QuickFormIds></QuickForms>


mobile-2020-admin-booking-form-combined-classic-control-service

### Configure offline data and sync filters


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-2020-offline-list.png)


## FAQs
- is this different than FSM and D365 mobile apps?
- can i add cases, sales orders, and other entities

## Provide feedback
