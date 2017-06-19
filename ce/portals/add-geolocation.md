---
title: "Add geolocation to a managed form in Dynamics 365 | MicrosoftDocs"
description: "Instructions to add geolocation to a managed form."
ms.custom: ""
ms.date: 05/22/2017
ms.service: crm-online
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: 9B1BA475-0061-455C-925F-039372CCE431
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: sakudes
---
# Geolocation
Geolocation is the identification of the real-world geographic location of an object. Geolocation is closely related to the use of positioning systems but may be distinguished from it by a greater emphasis on determining a meaningful location (e.g. a street address) rather than just a set of geographic coordinates. The word geolocation is also the latitude and longitude coordinates of a particular location.

A managed form can be configured to display a map control to either display an existing location as a pin on a map or to provide the ability for the user to specify a location.

![Location data in a form.](media/location-data-form.png "Location data in a form.")

If the form or Address Line field is editable and this field is blank, then when the page loads it will prompt the user asking if they would like to share their location. If they choose to share their location then the map will be updated with their currently detected location. The pin on the map will also be draggable to allow the user to refine the location. If the user chooses not to share their location they can manually specify the location address parts in the fields provided and the mapping service will be queried to find the location and update the latitude and longitude as well as reposition the pin on the map accordingly.

## Add Geolocation
In order to add geolocation functionality to a managed form, the following tasks must be completed.

### Form customization
Edit the [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] entity form using the form designer and make the following modifications:
1. Create a new section and provide an appropriate label, for example, Map. This section will contain map.
2. Set the name of the section to "section_map" or a name that ends with "section_map", for example, contoso_section_map. This name is important as the form engine looks for a section with name to determine when to render a map. 
3. Add a new or existing field that will store the formatted address and add it to the **Map** section created in the previous step.
4. Create a new section and provide an appropriate label, for example, Location. This section will contain the address fields for the selected location.
5. Add the required address fields to the **Location** section created in the previous step. For example: 
    - Address Line
    - City
    - County
    - State/Province
    - Country/Region
    - Zip/Postal Code
    - Latitude
    - Longitude

The resulting form should look similar to the following. You may choose different display names for these fields as desired. You may also choose to layout these sections anyway you prefer.

![Custom geolocation form.](media/custom-geolocation-form.png "Custom geolocation form.")

### Site settings
Geolocation with map functionality on Managed Forms requires configuration settings in order to complete requests with the mapping service REST endpoint. The following Site Settings are used to configure the location service.
|Name|Value|
|---|---|
|Bingmaps/credentials|Unique key to authenticate requests to the Bing Maps API. Visit [www.bingmapsportal.com](https://www.bingmapsportal.com) to create a Bing Maps account and get a key. Required.|
|Bingmaps/restURL|URL to the Bing Maps REST API. Optional. If a value is not specified the default http://dev.virtualearth.net/REST/v1/Locations is used.|
| |

### Field configurations
The map control requires additional configuration to tell it what the ids of the various location fields are in order to assign/retrieve values to/from them. The configuration depends on the type of managed form.
- For Entity Form, see [Geolocation Configuration for Entity Form](entity-forms-custom-logic.md#geolocation-configuration-for-entity-form).
- For Web Form, see [Geolocation Configuration for Web Form](web-form-properties.md#geolocation-configuration-for-web-form).
