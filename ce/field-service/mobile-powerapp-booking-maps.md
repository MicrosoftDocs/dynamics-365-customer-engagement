---
title: "Booking maps | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 04/01/2021
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

# Booking maps

Frontline workers can view their scheduled work orders on a map from the Field Service mobile app. This helps them plan their day and provides an easy way to trigger travel directions or contact the customer.  


> [!div class="mx-imgBorder"]
> ![Screenshot of bookings on a map in the Field Service mobile app.](./media/mobile-2020-booking-maps.png)



## Prerequisites

To use Booking maps your administrator must **enable Geospatial services**. Go to [https://admin.powerplatform.microsoft.com/](https://admin.powerplatform.microsoft.com/) > select your environment > Settings > 
Product > Features. 

Set _Geospatial Services_ to **On**.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/booking-maps-settings.png)





## Schedule work orders

To see bookings on a map you first need to schedule work orders.

Go to the schedule board and schedule work orders to a fronltine worker that has mobile access.

> [!Note]
> Booking maps only displays bookings related to work orders, and not bookings for other tables (entities).

## View booking map on mobile app

Log into the mobile app with the user for which work orders are scheduled to and go to Bookings from the site map. 


Select _Agenda_ in the top right of the bookings view and go to _Map_ view.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/booking-maps-navigate-wf.png)

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/booking-maps-option-wf.png)

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/bookable-maps-pins3-wf.png)





> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/boking-map-phone-wf.png)


## Trigger directions or contact a customer

Tap a booking icon 


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/booking-maps-info-card-wf.png)







booking pin color is based on Field Service status : 


Gray : Completed/canceled
Green: Traveling, On Break, In Progress
Blue: Default or everything else


1) Verify that the Map is not enabled if the Geospatial Setting is not enabled in the PPAC. 
2) Able to switch the Day filter and users would only see the Pins (bookings) for the selected Day filter. 
3) Able to click on the Pin to show Info Card 
4) Able to see different Pin Colors based on Field Service Status (InProgress / Travelling / OnBreak = Green,  Canceled / Completed = Gray, the rest = Blue) 
5) On the popup Info Card, able to click on "View Details" to open the booking record 
6) On the popup Info Card, able to click on the Address to open the Driving Direction App 
7) If users are already on the Map view and navigate away then navigate back, users should still be on the Map View. 
8) Booking map should work in OBD (offline but with internet connection) 
9) Map view should only be visible on Mobile. 
10) Should be able to interact with the map (Zoom in/out, changing the pitch, rotating the map)




## Configuration considerations

- Booking maps will not show if mobile device is not connected to the Internet

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/booking-maps-no-internet-wf.png)


- Booking locations are dervied from related work order address. 

## Additional Notes

### Known Issues
- If there are multiple bookings with the same address on a same day then out of the overlapped pins only the one with the latest start time can be clicked to view the info card.