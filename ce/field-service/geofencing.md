---
title: "Geofencing for Field Service Mobile | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 2/18/2018
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

# Geofencing 

A geofence is a virtual perimeter around a specific location. Geofencing allows users of the system to draw zones around places of work, customer's sites and secure areas. These geo-fences when crossed by an equipped vehicle or person can trigger a warning to the user or operator via SMS or email. 

In Dynamics 365 for Field Service, geofencing is designed to send push notifications to field technicians based on their location (as defined by their mobile phone/tablet) relative to a work order location. As an example, when a field technician is within 50 meters of a work order location, a text message will be sent to the technician reminding him/her to document their arrival. 

The push notification scenario is delivered out-of-the-box with the geofencing feature. Nevertheless, the geofenced entity (Work order, account) and the distance radius of the fence, tracking point entity (field technician, equipment), and the resulting action (notification, workflow, etc) are configurable.

**scenario:** in this article lets explore creating a geofence around a work order and compare this to the location of a bookable resource. when a work order is booked, a geofence will be created. by tracking the location of a bookable resource via the field service mobile app


## Prerequisites

1. **Field Service v8.3+**. Geofence solutions are included as part of the Field Service v8.3 upgrade/installation. In order to utilize mobile push notifications with geofencing, ensure the [Mobile Configuration Tool (Woodford solution)](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/field-service/install-field-service#install-the-field-service-mobile-configuration-tool) is installed in your environment before upgrade/installation to v8.3.

2. **Field Service Mobile v11.2+**

3. [Connect to Maps](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/field-service/perform-initial-configurations-setup#step-1-resource-scheduling) in order to connect your Dynamics 365 environment to Bing Maps to locate service accounts and work orders to later place geofences around them.
4. [Set Auto Geo Code Addresses to Yes](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/field-service/perform-initial-configurations-setup#step-2-field-service-settings) (Recommended) in order to automatically geo code accounts and work orders as addresses are entered. Geo coding an account or work order record populates latitude and longitude values which are required to place geofences around them.
   



## 1. Verify geofence solutions are installed

**Settings > Solutions**

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-geofence-solutions.png)

## 2. Activate geofence processes

**Settings > Processes**
   1) activate generate geofence when booking process
   2) activate delete geofence when booking is completed or cancelled
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-geofence-activate-processes.png)

## 3. Enable location auditing for the Field Service Mobile app

**Settings > Woodford > MobileCRM Woodford HTML5**

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-geofence-mobile-project.png)

   1) go into project and set auditing to yes 


   2) In the Auditing section of the project you can set what kind of action will be recorded on selected entities by using the Mobile CRM application. Then it will be sent to the CRM server when the application is synchronized. You can track the time and GPS position (the device must contain the GPS chip) when the action/change was performed. It's also possible to record the time and location where the synchronization was performed. 

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-geofence-enable-auditing.png)
You can track application’s state events, and that is whether the application is running, it’s terminated,  paused (put to background) or resumed (put back to foreground). 
If you want to audit the movement, you can use the Track GPS position changes, where you can set the Delay and Distance of the GPS position. If the device moves for the defined distance after the set time interval expires, the position is recorded. 
 
 
## 4. Enable background gps monitoring 

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-geofence-enable-location-tracking.png)


## 5. Test location auditing

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-geofence-sync-mobile-app.png)
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-geofence-mobile-audit-table.png)
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-geofence-map-location.png)
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-geofence-real-time-location-filter.png)
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-geofence-resource-location.png)

## 6. Configure Geofencing Settings

**Field Service > Settings > Geofencing Settings**



> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-geofence-minimum-radius.png)

## 7. Configure Geofence Entities

**Field Service > Settings > Entity Configurations**

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-geofence-entities.png)
   
   1) The geofence entity is a mostly static location the geofence will sit around. (example: Account)

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-geofence-service-account.png)
 
 2) Verify bookable resource is configured for geotracking
   1) The tracking point entity is the mostly mobile location that can breach the geofence. (example: Bookable Resource)

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-geofence-bookable-resource.png)

## 8. Book a work order 

(async workflow) and verify geofence is created
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-geofence-book.png)
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-geofence-created.png)
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-geofence-created-record.png)


## 9. Test a geofence event
    
    Consent to sharing GPS data on the Field Service Mobile app. A message will appear after a geofence is active. 

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-geofence-arrive.png)

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-geofence-mobile-audit-table.png)

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-geofence-event.png)

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-geofence-status-inside.png)



## Use push notifications with geofencing

see topic on push notifications
activate remind to change status upon arrival
activate remind to change status upon leaving

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-geofence-activate-reminders.png)

## Configuration considerations
- Create a custom geofence
- pro tip: to test breaking a geofence you can physically break the geofence by syncing your mobile app within the geofence, or as a system administrator you cna manually update lat/long in mobile audit table
- As part of this feature, latitude and longitude fields have been added to the bookable resource and are populated with the most recent location these could and should be added to the bookable resource form
  
## Additional notes

- currently geofencing looks at the resco_mobileaudit table but expecting to geofencing is application agnostic and can be used for multiple dynamics use cases including field service


