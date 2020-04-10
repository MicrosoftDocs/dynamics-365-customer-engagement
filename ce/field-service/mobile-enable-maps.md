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



> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-map-api-navigate.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-map-api-key.png)

## Prerequisites
> [!Note]
>



## Configuration considerations
## Additional Notes




To Create your API Keys:
Google Maps:  https://developers.google.com/maps/documentation/embed/get-api-key
Bing Maps: https://docs.microsoft.com/en-us/bingmaps/getting-started/bing-maps-dev-center-help/getting-a-bing-maps-key
 
To Configure your API Keys:
1.	Navigate to your Woodford Project:  
•	Within Woodford, open your active project.
•	Click into Components > Configuration.
•	In Configuration, click on "Integrations" tab.
•	From there you an paste your Google and/or Bing Maps API Keys.
2.	Save your Project
3.	Publish your project




Minimum Woodford Version required for this configuration:
•	For Google Maps: Woodford 10.0
•	For Bing Maps: Woodford 11.3
 
 
To Create your API Keys:
Google Maps
Reference: https://developers.google.com/maps/documentation/embed/get-api-key
Steps 
1.	Visit the Google Cloud Platform Console.
2.	Click the project drop-down and select or create the project for which you want to add an API key.
3.	Click the menu button and select APIs & Services > Credentials.
i.	On the Credentials page, click Create credentials > API key.
ii.	The API key created dialog displays your newly created API key.
iii.	Click Close.
2.	The new API key is listed on the Credentials page under API keys.
 
Bing Maps
Reference: https://docs.microsoft.com/en-us/bingmaps/getting-started/bing-maps-dev-center-help/getting-a-bing-maps-key
Steps:
1.	Go to the Bing Maps Dev Center at https://www.bingmapsportal.com/.
2.	Select My keys under My Account.
3.	Select the option to create a new key.
4.	Provide the following information to create a key:
i.	Application name: Required. The name of the application (Field Service Mobile, or however you would like to identify this app).
ii.	Application URL:  This is an optional field which is useful in helping you remember the purpose of that key in the future.
iii.	Key type: Required. Select the key type that you want to create. In normal scenarios you will want a Basic key.
iv.	Application type: Required. Select the application type of Mobile Application.
2.	Click the Create button. The new key displays in the list of available keys. 
 
 
 
To Configure your API Keys:
Navigate to your Woodford Project:  
1.	Log in to your Dynamics Org.
2.	Navigate to Settings > Advanced Settings
3.	In MobileCRM section, click on Woodford.
 
 
 
 
1.	On resulting screen, click into MobileCRM Woodford (HTML or Silverlight version; whichever your org primarily users)
2.	Within Woodford, double-click into your active project.
i.	The active project being used is noted by a Blue Arrow next to project name.
ii.	Note if you use multiple projects for different users, you will have to follow these steps for each project.
4.	When your project loads, click into Components > Configuration
5.	In Configuration, click on "Integrations" tab
6.	From there you an paste your Google and/or Bing Maps API Keys
 
 
1.	Save your Project
2.	Publish your project
