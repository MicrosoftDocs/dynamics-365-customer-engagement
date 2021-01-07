---
title: "Geofencing | MicrosoftDocs"
description: description
ms.custom:
- dyn365-fieldservice
ms.date: 01/07/2021
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

# Geofencing
## Prerequisites

- **Field Service v8.3+**. Geofence solutions are included as part of the Field Service v8.3 upgrade.

- [Connect to Bing Maps](https://docs.microsoft.com/dynamics365/customer-engagement/field-service/perform-initial-configurations-setup#step-1-resource-scheduling) in order to connect your Dynamics 365 environment to Bing Maps in order to locate service accounts and work orders to later place geofences around them.
   
- [Set auto geo code addresses to **yes**](https://docs.microsoft.com/dynamics365/customer-engagement/field-service/perform-initial-configurations-setup#step-2-field-service-settings) in order to automatically geo code accounts and work orders when addresses are entered. Geo coding an account or work order record populates latitude and longitude values, which are required to place geofences around them.

- Location auditing
- this applies to the Field Service mobile app, 
- Geofecing is also available for the Field Service Mobile (Xamarin) see more details in this article 
> [!Note]
>

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)

For a guided walkthrough, check out the following video.

> [!VIDEO https://www.microsoft.com/videoplayer/embed/RE4GEjn]

See the video on![Video symbol](../field-service/media/video-icon.png "Video symbol") [Field Service (Dynamics 365) mobile app: Offline JavaScript](https://youtu.be/tUdL5YZA29A) for more details.


## Configuration considerations
## Additional Notes