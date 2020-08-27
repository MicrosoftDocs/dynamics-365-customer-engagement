---
title: "Support for Dynamics 365 for phones and Dynamics 365 for tablets | MicrosoftDocs"
ms.custom:
ms.date: 6/2/2020
ms.reviewer:
ms.service: crm-online
ms.suite:
ms.tgt_pltfrm:
ms.topic: get-started-article
applies_to: Dynamics 365 apps
ms.assetid: 7f9d8425-f26c-43ac-bdc7-ff258977ff80
caps.latest.revision: 136
ms.author: mkaur
author: mduelae
manager: kvivek
search.audienceType:
  - admin
  - customizer
  - enduser
search.app:
  - D365CE
  - D365Sales
---
# What's supported

You can access Common Data Service or Dynamics 365 Customer Engagement (on-premises) data from mobile devices in different ways. You can install and use the Dynamics 365 for phones and tablets mobile app on your iOS, [!INCLUDE[tn_android](../includes/tn-android.md)], and Windows 10 devices, or you can use your tablet’s web browser to run the model-driven apps as long as your device has sufficiently high screen resolution.
  
## Supported devices for the mobile app
  
|                              Platform                              |   Versions    | RAM (minimum)  | 
|--------------------------------------------------------------------|---------------|---------------|
|       [iOS](https://docs.microsoft.com/dynamics365/mobile-app/install-dynamics-365-for-phones-and-tablets#install-the-app-from-your-devices-app-store)       | 11.4.1 or later  |     1 GB (2 GB recommended)     
|     [Android](https://docs.microsoft.com/dynamics365/mobile-app/install-dynamics-365-for-phones-and-tablets#install-the-app-from-your-devices-app-store)     | 6.0.1 or later |     2 GB (3 GB recommended)    |                                  |
| [Windows](https://docs.microsoft.com/dynamics365/mobile-app/install-dynamics-365-for-phones-and-tablets#install-the-app-from-your-devices-app-store) |      10       |     2 GB (4 GB recommended)                     
 
 
  
## Install the app 

To install the app see, [Install the app from your device’s app store](https://docs.microsoft.com/dynamics365/mobile-app/install-dynamics-365-for-phones-and-tablets#install-the-app-from-your-devices-app-store).

   

## Supported tablets to run model-driven apps in your web browser 

For full functionality and optimized experience, we strongly recommend that you use the Dynamics 365 for phones and tablets mobile app. If you don't have the Dynamics 365 for phones and tablets app installed, you can still use the web browser on your tablet to run the model-driven apps. 

> [!NOTE]
> Using the web browser on your phone to run your model-driven apps isn't supported; you must use the Dynamics 365 for phones app. 


## Supported tablets to use the web browser
  
|                              Platform                             |   Versions  | Minimum Resolution or Screen Size  | 
|--------------------------------------------------------------------|---------------|---------------|
|       Apple iPad      | iOS 11.4.1 or later  |     9-inch screen (diagonal) or larger or iPad Mini with 7.9 inch screen      |                                     | 
|     Android tablet  | 6.0.1 or later |     1366 x 768 resolution (720p)    |                                  |
| Windows tablet or PC |      10       |     1366 x 768 resolution (720p)
        

  
Model-driven apps running on a web browser on an iOS or Android tablet provides a similar experience to using it with a web browser on your desktop or laptop computer. However, some features are not available on the mobile app or mobile web browser, including:
  
- Pinch and zoom  
  
- [!INCLUDE[pn_yammer](../includes/pn-yammer.md)]  
  
- Reports 

- Service Calendar 
  
- Customization/Editors  
  
- System Settings  
  
- Advanced Find  
  
- Process dialogs  
  
- [!INCLUDE[pn_skype_for_business](../includes/pn-skype-for-business.md)] presence  
  
- Entities that use classic forms such as Goal and Order Product see, [Entities using classic forms](../customize/create-design-forms.md).  

For more information about web browser support, see [Web application requirements for Microsoft Dynamics 365 apps](../admin/web-application-requirements.md).

## Supported languages for [!INCLUDE[pn_Mobile_Express_short](../includes/pn-mobile-express-short.md)] and [!INCLUDE[pn_moca_short](../includes/pn-moca-short.md)] 

When the application first loads after installation, it will determine the device language and load the user interface in that language.  Once you sign in and launched an app, the language will be selected based on your personal options or the base language in Common Data Service or Dynamics 365 Customer Engagement (on-premises). If a language is not supported, the user experience will be shown in English. 

 [!INCLUDE[pn_Mobile_Express_short](../includes/pn-mobile-express-short.md)] and [!INCLUDE[pn_moca_short](../includes/pn-moca-short.md)] support the following languages:  
  
- Basque (Basque) - 1069  
  
- Bulgarian (Bulgaria) - 1026  
  
- Catalan (Catalan) - 1027  
  
- Chinese (Hong Kong S.A.R.) - 3076  
  
- Chinese (People's Republic of China) - 2052  
  
- Chinese (Simplified) - 2052  
  
- Chinese (Taiwan) - 1028  
  
- Chinese (Traditional) - 1028  
  
- Croatian (Croatia) - 1050  
  
- Czech (Czech Republic) - 1029  
  
- Danish - 1030  
  
- Dutch - 1043  
  
- English - 1033  
  
- Estonian - 1061  
  
- Finnish - 1035  
  
- French - 1036  
  
- Galician  
  
- German - 1031  
  
- Greek - 30  
  
- Hindi (India) - 91  
  
- Hungarian - 36  
  
- Indonesian - 62  
  
- Italian - 1040  
  
- Japanese - 1041  
  
- Kazakh - 705  
  
- Korean - 82  
  
- Latvian - 371  
  
- Lithuanian - 370  
  
- Norwegian - 47  
  
- Polish - 48  
  
- Portuguese (Brazil) - 55  
  
- Portuguese (Portugal) - 2070  
  
- Romanian - 40  
  
- Russian - 7  
  
- Serbian  
  
- Slovak - 421  
  
- Slovenian - 386  
  
- Spanish - 3082  
  
- Swedish - 46  
  
- Thai - 66  
  
- Turkish - 90  
  
- Ukrainian - 380  


## Deprecated and unsupported platforms

- On December 1, 2019, the mobile app will no longer support iOS 10, Android 4.4, and Android 5. The minimum Android version will be 6.0.1 and the minimum iOS version will be 11.4.1.

- As of December 3, 2018, Microsoft Dynamics 365 for Blackberry App is deprecated and will be removed from the iOS App Store on October 31, 2019. For more information, [Dynamics 365 for Blackberry is deprecated
](https://docs.microsoft.com/power-platform/important-changes-coming#dynamics-365-for-blackberry-is-deprecated).

- On February 21, 2018, we announced the deprecation of the Windows Phone app for Dynamics 365 apps. Effective May 22, 2018, the Windows phone app is no longer supported for model-driven apps in Dynamics 365.

  
### See also  
 [Set up and manage tablets and phones](set-up-dynamics-365-for-phones-and-dynamics-365-for-tablets.md)   
 [Web application requirements for Dynamics 365 apps](../admin/web-application-requirements.md)   
