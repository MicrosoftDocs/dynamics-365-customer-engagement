---
title: "Enable maps for Field Service Mobile | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 04/08/2020
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

# Enable maps for Field Service Mobile

Set up maps and location services for Field Service Mobile to enable functionality such as:

1. displaying work order location on a map
2. the Update GPS command to replace work order location with current location of the mobile device
3. location auditing to understand the realtime location of technicians for scheduling, displaying on the schedule board map, and [geocoding](./geofencing.md).



> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-map-api-mobile.png)
 

Set up maps and location services by retreiving a Bing Maps API key and entering it into the Mobile Configuration Tool (Woodford) mobile project template.


## Prerequisites

Minimum Woodford Version required is **Woodford 11.3+**.

If you do not meet the minimum Woodford version, download the latest Woodford version from [http://aka.ms/fsmobile-configurator](http://aka.ms/fsmobile-configurator) and import it in your Dynamics 365 envronment at **Settings > Solutions**.

## Get Map API key

The first step is to generate a Bing Maps API key. Reference the topic on [Getting a Bing Maps API key](https://docs.microsoft.com/en-us/bingmaps/getting-started/bing-maps-dev-center-help/getting-a-bing-maps-key) for more details.


1. Go to the Bing Maps Dev Center at [https://www.bingmapsportal.com/](https://www.bingmapsportal.com/).
2. Sign in with a Microsoft account or create a new account. 
3. Under **My Account** select **My keys**.
3. Select the option to create a new key.
4. Provide the following information to create a key:
  - **Application name**: Required. The name of the application (Field Service Mobile, or however you would like to identify this app).
  - **Application URL:**  This is an optional field which is useful in helping you remember the purpose of that key in the future.
  - **Key type:** Required. Select the key type that you want to create. A **Basic key** is recommmended.
  - **Application type:** Required. Select the application type of Mobile Application.
6.	Click the Create button. The new key displays in the list of available keys. 
7. Copy the API key to your clipboard.


## Enter Map API key in Woodford

After retreiving your Map API key, you will need to enter it in your mobile project template that dictates how the mobile app looks and functions. 

In your Dynamics 365 environment go to **Settings > Woodford**

On resulting screen, click into **MobileCRM Woodford HTML5**

 
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-map-api-navigate.png)
 
	
Within Woodford, double-click into your active project.
  - The active project being used is noted by a Blue Arrow next to project name.
  - If you followed the [Field Service installation instructions](./install-field-service.md), double click in to the derivative of the mobile project template.
  - If you use multiple projects for different users, you will have to follow these steps for each project.
  


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-map-api-projects.png)

From the left menu pane go to **Configuration** then go to the **Integrations** tab.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-map-api-key.png)

From there paste your copied api key in the **Bing Maps API Key** field in the **Maps** section.

Save your Project.

Publish your project.


## Configuration considertations

### Google maps

You can also use Google Maps for map visualizations and location calculations instead of Bing maps.

Minimum Woodford Version required is **Woodford 10.0+**.

First retrieve a _Google_ Maps API key. Reference the topic on [Getting a Google Maps API key](https://developers.google.com/maps/documentation/embed/get-api-key) for more details.

1. Visit the [Google Cloud Platform Console](https://console.cloud.google.com/google/maps-apis/overview?pli=1).
2.	Click the project drop-down and select or create the project for which you want to add an API key.
3.	Click the menu button and select APIs & Services > Credentials.
  - On the Credentials page, click Create credentials > API key.
  - The API key created dialog displays your newly created API key.
  - Click Close.
5.	The new API key is listed on the Credentials page under API keys.

Back in Woodford, copy and paste the API key in the **Google Maps API Key** field in the **Google** section.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-map-api-key-google.png)




 






 
 

 
 
 
