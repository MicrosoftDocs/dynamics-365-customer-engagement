---
title: "Location auditing for the Dynamics 365 Field Service mobile app | MicrosoftDocs"
description: Learn how to enable and set up location auditing for the Dynamics 365 Field Service mobile app
ms.custom: 
  - dyn365-fieldservice
ms.date: 11/19/2020
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: FieldServiceDave
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: daclar
manager: shellyha
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365FS
---

# Location auditing for the Dynamics 365 Field Service mobile app

Field technicians often travel to various locations throughout their work day, and it's helpful for schedulers to know where technicians are at any given time.

Technicians using the Field Service (Dynamics 365) mobile app can enable location sharing from the app, allowing schedulers to visualize their location on the schedule board, and also audit a list showing a technician's location history.

In this article, we'll look at how to enable location tracking, and how to access location audits in Field Service.


## Prerequisites

- Administrator access to Dynamics 365 Field Service
- Field Service mobile app

## Step 1. Enable location tracking

First, we need to make sure location tracking is enabled in Field Service.

1. In Field Service, go to **Geolocation Settings**.
2. Set **Enable Location Tracking**  to **Yes**.  
3. Configure tracking times to meet your business needs. In the screenshot example, we have it configured so that tracking happens 24 hours a day, every day.

> [!div class="mx-imgBorder"]
> ![Screenshot of Field Service, showing the geolocation settings.](./media/mobile-location-geolocation-settings.png)

These settings allow a technician's location data to be sent to Dynamics 365 Field Service, which surfaces a technician’s location on the schedule board. The technician’s location data is stored in the geolocation tracking entity.

## Step 2. Allow Field Service mobile to access your location

After enabling location tracking on the scheduler's side, make sure it's enabled and working on the mobile device side.

On a mobile device, sign into the Dynamics 365 Field Service mobile app. When prompted, allow the Field Service app to access your location while using the app.

> [!div class="mx-imgBorder"]
> ![Simulated device showing Field Service mobile app, with the "Allow Field Service to use your location" prompt.](./media/mobile-location-allow-location-access-fsm.png)

## Step 3. Verify location tracking

Back in Dynamics 365 Field Service, the bookable resource's current location appears on the schedule board map. Select the map pin icon next to the bookable resource's name, and the map will display the location with a different icon.

> [!div class="mx-imgBorder"]
> ![Screenshot of current location on schedule board map](./media/mobile-geofence-map-location.png)

## Step 4. Location audit

By using the **Geolocation Tracking** entity and advanced find in Field Service, you can query to run audits on technician locations.

> [!div class="mx-imgBorder"]
> ![Screenshot of advanced find in Field Service](./media/mobile-location-geolocation-tracking-entity-advance-find.png)

Here you see a list of locations throughout the day, listed by user.

> [!div class="mx-imgBorder"]
> ![Screenshot of advanced find in Field Service, showing a location audit for one user.](./media/mobile-location-geolocation-tracking-results.png)

> [!Note]
> If you want to correlate technician location with other Field Service entity updates, such as booking resource bookings, go to [auditing overview](https://docs.microsoft.com/power-platform/admin/audit-data-user-activity) for more info with instructions to enable for your organization and select entities.  
