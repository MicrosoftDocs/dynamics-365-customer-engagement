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

1. Field Service v8.3+

2. Field Service Mobile 11.2+

3. Enable geocoding
   


## Instructions

1) Verify geofence solutions are present in your environment
mobile-geofence-solutions
2) Activate gefoence processes
   1) activate generate geofence when booking process
   2) activate delete geofence when booking is completed or cancelled
mobile-geofence-activate-processes
3) verify location data is being pulled from mobile app (resco_mobileaudit) by enabling mobile auditing 
   1) go into project and set auditing to yes 
   2) In the Auditing section of the project you can set what kind of action will be recorded on selected entities by using the Mobile CRM application. Then it will be sent to the CRM server when the application is synchronized. You can track the time and GPS position (the device must contain the GPS chip) when the action/change was performed. It‘s also possible to record the time and location where the synchronization was performed. 

mobile-geofence-enable-auditing
You can track application’s state events, and that is whether the application is running, it’s terminated,  paused (put to background) or resumed (put back to foreground). 
If you want to audit the movement, you can use the Track GPS position changes, where you can set the Delay and Distance of the GPS position. If the device moves for the defined distance after the set time interval expires, the position is recorded. 
 
 
   1) enable background gps monitoring 

mobile-geofence-enable-location-tracking
1) test location tracking
mobile-geofence-sync-mobile-app
mobile-geofence-mobile-audit-table
mobile-geofence-map-location
mobile-geofence-real-time-location-filter
mobile-geofence-resource-location
2) Set a unit of measure and minimum distance radius value

mobile-geofence-minimum-radius
3) verify the account entity is enabled for geofence with desired radius

mobile-geofence-entities
   1) The geofence entity is a mostly static location the geofence will sit around. (example: Account)

mobile-geofence-service-account
1) Verify bookable resource is configured for geotracking
   1) The tracking point entity is the mostly mobile location that can breach the geofence. (example: Bookable Resource)

mobile-geofence-bookable-resource
1)  book a work order (async workflow) and verify geofence is created

mobile-geofence-book
mobile-geofence-created
mobile-geofence-created-record
2)  test breaking a geofence
    1)  Consent to sharing GPS data on the Field Service Mobile app. A message will appear after a geofence is active. 

mobile-geofence-arrive

mobile-geofence-mobile-audit-table

mobile-geofence-event

mobile-geofence-status-inside



## use push notifications with geofencing

see topic on push notifications
activate remind to change status upon arrival
activate remind to change status upon leaving

mobile-geofence-activate-reminders

## Create a custom geofence 

**Field Service > Settings > Geofencing > Entity Configurations**
- entity configuration
- will have to create custom workflows by using our workflows as a template

## Configuration
- pro tip: to test breaking a geofence you can physically break the geofence by syncing your mobile app within the geofence, or as a system administrator you cna manually update lat/long in mobile audit table
- - As part of this feature, latitude and longitude fields have been added to the bookable resource and are populated with the most recent location these could and should be added to the bookable resource form
## Additional notes

- currently geofencing looks at the resco_mobileaudit table but expecting to geofencing is application agnostic and can be used for multiple dynamics use cases including field service


