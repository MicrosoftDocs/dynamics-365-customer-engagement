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

3. Enable geo-auditing in Woodford
   


## Instructions

1) Verify geofence solutions are present in your environment
2) verify location data is being pulled from mobile app (resco_mobileaudit) by enabling mobile auditing 
   1) go into project and set auditing to yes 
   2) enable background gps monitoring 
3) test location tracking
4) Set a unit of measure and minimum distance radius value
5) verify the account entity is enabled for geofence with desired radius
   1) The geofence entity is a mostly static location the geofence will sit around. (example: Account)
6) Verify bookable resource is configured for geotracking
   1) The tracking point entity is the mostly mobile location that can breach the geofence. (example: Bookable Resource)
7) Activate gefoence processes
   1) activate default geofence radius visiblity 
   2) activate generate geofence when booking process
   3)  activate delete geofence when booking is completed or cancelled
8)  book a work order (async workflow) and verify geofence is created
9)  test breaking a geofence
    1)  Consent to sharing GPS data on the Field Service Mobile app. A message will appear after a geofence is active. 



## use push notifications with geofencing

see topic on push notifications
activate remind to change status upon arrival
activate remind to change status upon leaving

## Create a custom geofence 

**Field Service > Settings > Geofencing > Entity Configurations**
- entity configuration
- will have to create custom workflows by using our workflows as a template

## Configuration
- pro tip: to test breaking a geofence you can physically break the geofence by syncing your mobile app within the geofence, or as a system administrator you cna manually update lat/long in mobile audit table
- - As part of this feature, latitude and longitude fields have been added to the bookable resource and are populated with the most recent location these could and should be added to the bookable resource form
## Additional notes

- currently geofencing looks at the resco_mobileaudit table but expecting to geofencing is application agnostic and can be used for multiple dynamics use cases including field service


