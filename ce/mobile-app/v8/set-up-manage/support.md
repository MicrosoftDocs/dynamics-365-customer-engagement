---
title: "Support for Dynamics 365 for phones and tablets | MicrosoftDocs"
ms.custom:
ms.date: 01/22/2018
ms.reviewer:
ms.service: crm-online
ms.suite:
ms.tgt_pltfrm:
ms.topic: get-started-article
applies_to: Dynamics 365 apps
ms.assetid: 7f9d8425-f26c-43ac-bdc7-ff258977ff80
caps.latest.revision: 141
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
# Support for Dynamics 365 for phones and Dynamics 365 for tablets

You can access [!INCLUDE[pn_microsoftcrm](../../../includes/pn-microsoftcrm.md)] data from mobile devices in different ways. You can install and use the apps for Windows, iOS, and [!INCLUDE[tn_android](../../../includes/tn-android.md)] mobile devices, or you can run the [!INCLUDE[pn_crm_shortest](../../../includes/pn-crm-shortest.md)] web app on the device’s preferred browser for those devices described here.

CRM Online 2015 Update 1 introduced a new version of Dynamics 365 for phones that’s based on and shares many of the features of Dynamics 365 for tablets. To use this new version of Dynamics 365 for phones, you must be running CRM Online 2015 Update 1 or later or Dynamics CRM 2016 on-premises or later.

> [!NOTE]
> Tablet support requires Microsoft Dynamics CRM Online Fall ‘13 or later, or Microsoft Dynamics CRM 2015 or later.
>
> For on-premises deployments of Dynamics 365 apps, the mobile apps require an [Internet-facing deployment](/previous-versions/dynamicscrm-2016/deployment-administrators-guide/dn609803(v=crm.8)) of Microsoft Dynamics 365 apps Server that uses claims-based authentication.

<a name="BKMK_CRMforPhones"></a>

## Support for Dynamics 365 for phones

### Version support

Dynamics 365 for phones requires and can only connect to Microsoft Dynamics CRM Online 2015 Update 1 (online) or later (Windows Phone*, iPhone, and Android) or Microsoft Dynamics CRM 2016 (on-premises) or later (Windows Phone, iPhone, Android).

Dynamics CRM for phones express is deprecated and will not connect to releases **after** Microsoft Dynamics CRM 2016. Dynamics CRM for phones express is not available in the iOS and Android stores anymore.

*Windows Phone requires the [new Dynamics 365 apps for Windows app](https://go.microsoft.com/fwlink/p/?LinkID=799909) and Microsoft Dynamics CRM 2016 (on-premises) or later .
  
### Device support  
  
|Platform|Versions|RAM (minimum)|  
|--------------|--------------|---------------------|  
|[iOS](https://go.microsoft.com/fwlink/p/?LinkID=519213)|8.1 and above|1 GB|  
|[Android](https://go.microsoft.com/fwlink/p/?LinkID=519214)|4.4,5.0, 6.0, 7.0 **|1 GB|  
|[Windows Phone 8.1](https://go.microsoft.com/fwlink/p/?LinkId=519212)<br /><br /> [Windows Phone 10](https://go.microsoft.com/fwlink/p/?LinkID=799909)|8.1 and 10|2 GB*|  

*Enhancements to the app require this minimum memory amount.

**Dynamics 365 for phones and tablets app will only connect to servers that are trusted by the underlying operating system. On Android, beginning with Android Oreo (8.0) the app will only connect to the servers that rely on one of the trusted CA certificates installed on the device.

## Support for Dynamics 365 for tablets

### Windows tablets

 You can run the Dynamics 365 apps for Windows tablets app on devices that meet the following requirements. You can also run the Dynamics 365 apps web app on a supported web browser on these devices. For more information about web browser support, see [Web application requirements for Microsoft Dynamics 365 apps](/previous-versions/dynamicscrm-2016/administering-dynamics-365/hh699710(v=crm.8)).  
  
 Download the Microsoft Dynamics 365 apps from the Windows Marketplace for [Windows 8.1 tablets](https://go.microsoft.com/fwlink/p/?LinkID=392776) and [Windows 10 tablets](https://go.microsoft.com/fwlink/p/?LinkID=808734).  
  
|||  
|-|-|  
|Operating system|Windows 8 or later|  
|Memory|2 GB*|  
|Resolution|1366 x 768 resolution (720p)|  

*Enhancements to the app require this minimum memory amount.

> [!IMPORTANT]
> For on-premises deployments, support requires a Microsoft Windows registry modification on the user’s Windows 8.1 device. Not required for the new Windows 10 app. For more information, see “Get your on-premises deployment ready for Dynamics 365 apps for Windows 8.1 tablets” in [What admins need to do](support.md).
>
> Additional screen sizes and resolutions are supported because Windows can use system scaling.

<a name="BKMK_iPad"></a>

### Apple iPad
You can run the [!INCLUDE[pn_crm_for_ipad_shortest](../../../includes/pn-crm-for-ipad-shortest.md)] app on devices that meet the following requirements:

- Device: [!INCLUDE[tn_ipad](../../../includes/tn-ipad.md)] third generation or later

### Apple iPad  
You can run the [!INCLUDE[pn_crm_for_ipad_shortest](../../../includes/pn-crm-for-ipad-shortest.md)] app on devices that meet the following requirements:    
  
- Device: [!INCLUDE[tn_ipad](../../../includes/tn-ipad.md)] third generation or later  
  
- Screen: 9-inch (diagonal) or larger  
 
[Download Microsoft Dynamics 365 apps for iPad from the Apple Store](https://go.microsoft.com/fwlink/p/?LinkId=313327)

> [!IMPORTANT]
> - For CRM 2015, this app is supported on iOS 7, 8, 9, and 10.
> - For Microsoft Dynamics 365 apps (online & on-premises), this app is supported on iOS 7, 8, 9, and 10.
> - For Microsoft Dynamics CRM Online 2016 Update 1 and Microsoft Dynamics CRM 2016 Service Pack 1, this app is supported on iOS 8.1 and above.

#### How to find the version of your [!INCLUDE[pn_crm_for_ipad](../../../includes/pn-crm-for-ipad.md)] app

- In the [!INCLUDE[pn_moca_short](../../../includes/pn-moca-short.md)] app, go to the home screen, and then open the command bar. Tap **Settings**, and then tap **About**.

<a name="BKMK_Nexus"></a>

### Android
You can run the [!INCLUDE[pn_moca_CRM_Android](../../../includes/pn-moca-crm-android.md)] app on devices that meet the following requirements:

- Android versions 4.4<sup>1</sup>, 5.0<sup>2</sup>, and 6.0<sup>3</sup> are supported for tablets with screens larger than 7 inches (optimized for 9 to 10 inches) using Microsoft Dynamics 365 apps for Android.

1. This feature is available only if your organization has updated to Microsoft Dynamics CRM 2015 Update 0.1 or later.
2. This feature is available only if your organization has updated to Microsoft Dynamics CRM 2015 Update 1.1 or later.
3. This feature is available only if your organization has updated to Microsoft Dynamics CRM 2015 Update 1.1 or later.

[Download Microsoft Dynamics 365 apps for Android from Google play](https://go.microsoft.com/fwlink/p/?LinkID=392913)
  
<a name="BKMK_BrowserSupport"></a>   

## Web browser support for tablets  
You can run Microsoft Dynamics 365 apps in the default web browser on any of the supported [Windows tablets](#BKMK_Windows8) listed earlier. For [Apple iPad tablets](#BKMK_iPad), iOS 7, iOS 8, and iOS 9 are supported. For [Android](#BKMK_Nexus), versions 4.2.2, 4.3, 4.4, 5.0, and 6.0 are supported for the tablets listed earlier.
  
 Using [!INCLUDE[pn_microsoftcrm](../../../includes/pn-microsoftcrm.md)] on a web browser on an Apple or Android mobile device provides a similar experience to using it with a web browser on a desktop or laptop computer. However, some features are not available, including:  
  
-   Pinch and zoom  
  
-   Yammer 
  
-   Reports  
  
-   Customization/Editors  
  
-   System Settings  
  
-   Advanced Find  
  
-   Process dialogs  
  
-   Skype for Business presence  

- Adding attachments to Notes—for Apple iPad users with Dynamics 365 apps (on-premises)
  
-   Entities that use classic forms such as Goal and Order Product see, [Entities using classic forms](/previous-versions/dynamicscrm-2016/administering-dynamics-365/dn531143(v=crm.8)#BKMK_ClassicFormEntities).  
  


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]