---
title: "Geofencing for Field Service Mobile | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 10/24/2018
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


## Prerequisites

1. Field Service v8.3+

2. Field Service Mobile 11.2+

3. Enable geo-auditing in Woodford


## Instructions

1) Set a minimum distance radius value
2) Define geofence entity
   
   The geofence entity is a mostly static location the geofence will sit around. (example: Account)
3) Define tracking point entity 
   
   The tracking point entity is the mostly mobile location that can breach the geofence. (example: Bookable Resource)
   
4) Create geofence
5) Activate default workflow or create custom Dynamics workflow or Microsoft Flow
6) Consent to sharing GPS data from mobile app. A message will appear after a geofence is active. 


default settings and configure them (radius)
workflow that generates geofences
edit geofence worflow and when its triggered
geofence events



## Configuration

## Additional notes
- As part of this feature, latitude and longitude fields have been added to the bookable resource and are populated with the most recent location


