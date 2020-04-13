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

Minimum Woodford Version required for this configuration:
- For Bing Maps: Woodford 11.3



> [!Note]
>


## Get Map API key

The first step is to generate a Bing Maps API key. Reference the topic on [https://docs.microsoft.com/en-us/bingmaps/getting-started/bing-maps-dev-center-help/getting-a-bing-maps-key](Getting a Bing Maps API key) for more details.


1. Go to the Bing Maps Dev Center at [https://www.bingmapsportal.com/](https://www.bingmapsportal.com/) and sign in.
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

After retreiving your Map API key, enter it in your mobile project. 

To Configure your API Keys:
Navigate to your Woodford Project:  
1.	Log in to your Dynamics Org.
2.	Navigate to Settings > Advanced Settings
3.	In MobileCRM section, click on Woodford.
 
 
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-map-api-navigate.png)
 
1.	On resulting screen, click into MobileCRM Woodford (HTML or Silverlight version; whichever your org primarily users)
2.	Within Woodford, double-click into your active project.
i.	The active project being used is noted by a Blue Arrow next to project name.
ii.	Note if you use multiple projects for different users, you will have to follow these steps for each project.
iii. this project is the derivative of the mobile project template


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-map-api-projects.png)

- Click into Components > Configuration.
- In Configuration, click on "Integrations" tab.
- From there you an paste your Google and/or Bing Maps API Keys.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-map-api-key.png)

2.	Save your Project
3.	Publish your project


## Configuration considertations

### Google maps

- For Google Maps: Woodford 10.0

Alternatively, you can use Google Maps for visualizations and location calulations with the following steps.


1. Reference: https://developers.google.com/maps/documentation/embed/get-api-key
2. Visit the Google Cloud Platform Console.
3.	Click the project drop-down and select or create the project for which you want to add an API key.
4.	Click the menu button and select APIs & Services > Credentials.
  i.	On the Credentials page, click Create credentials > API key.
  ii.	The API key created dialog displays your newly created API key.
  iii.	Click Close.
5.	The new API key is listed on the Credentials page under API keys.



> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-map-api-key-google.png)




 






 
 

 
 
 
