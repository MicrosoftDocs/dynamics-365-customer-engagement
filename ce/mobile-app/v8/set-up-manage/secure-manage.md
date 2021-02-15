---
title: "Secure and manage Dynamics 365 for phones and Dynamics 365 for tablets | MicrosoftDocs"
ms.custom:
ms.date: 01/22/2018
ms.reviewer:
ms.service: crm-online
ms.suite:
ms.tgt_pltfrm:
ms.topic: get-started-article
applies_to: Dynamics 365 apps
ms.assetid: f42ec901-846a-4503-8e78-c9a57b7e7c0b
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
# Secure and manage Dynamics 365 for phones and tablets

You can secure and manage [!INCLUDE[pn_Mobile_Express_long](../../../includes/pn-mobile-express-long.md)] and [!INCLUDE[pn_moca_full](../../../includes/pn-moca-full.md)] with the following technologies:

1. **[!INCLUDE[pn_microsoft_intune](../../../includes/pn-microsoft-intune.md)]**. You can use [!INCLUDE[pn_microsoft_intune](../../../includes/pn-microsoft-intune.md)] to manage [!INCLUDE[pn_Mobile_Express_short](../../../includes/pn-mobile-express-short.md)] and [!INCLUDE[pn_moca_short](../../../includes/pn-moca-short.md)] on [!INCLUDE[tn_apple](../../../includes/tn-apple.md)] and [!INCLUDE[tn_android](../../../includes/tn-android.md)] tablets and phones. [!INCLUDE[pn_intune](../../../includes/pn-intune.md)] provides mobile device management, mobile application management, and PC management capabilities from the cloud. Using [!INCLUDE[pn_intune](../../../includes/pn-intune.md)], you can provide your users with access to corporate applications, data, and resources from virtually anywhere on almost any device, while helping to keep corporate information secure.

   > [!IMPORTANT]
   >  This feature was introduced in [!INCLUDE[pn_crm_online_2016_update_shortest](../../../includes/pn-crm-online-2016-update-shortest.md)].

2. **[!INCLUDE[pn_microsoft_dynamics_crm_for_good](../../../includes/pn-microsoft-dynamics-crm-for-good.md)]**. [!INCLUDE[pn_microsoft_dynamics_crm_for_good](../../../includes/pn-microsoft-dynamics-crm-for-good.md)], integrated with [!INCLUDE[pn_good_dynamics](../../../includes/pn-good-dynamics.md)], protects your [!INCLUDE[pn_crm_shortest](../../../includes/pn-crm-shortest.md)] data even if your users lose or leave their mobile devices somewhere. For example, if someone leaves their device in a taxi cab and can’t get it back right away, [!INCLUDE[pn_crm_shortest](../../../includes/pn-crm-shortest.md)] data is protected by [!INCLUDE[pn_good_shortest](../../../includes/pn-good-shortest.md)] encryption. If someone loses their device entirely, all they have to do is notify you so you can remotely wipe [!INCLUDE[pn_microsoft_dynamics_crm_for_good](../../../includes/pn-microsoft-dynamics-crm-for-good.md)] data from their device.

   > [!IMPORTANT]
   >  This feature was introduced in [!INCLUDE[pn_crm_online_2016_update_shortest](../../../includes/pn-crm-online-2016-update-shortest.md)].  
  
<a name="BKMK_MobileIntune"></a>   

## Manage Dynamics 365 apps on mobile devices with [!INCLUDE[pn_microsoft_intune](../../../includes/pn-microsoft-intune.md)]  
 If your organization is set up with [!INCLUDE[pn_intune](../../../includes/pn-intune.md)], you can use it to manage the [!INCLUDE[pn_crm_shortest](../../../includes/pn-crm-shortest.md)] for phones and tablets apps on Apple, Android, and Windows 10 tablets and phones. [!INCLUDE[pn_intune](../../../includes/pn-intune.md)] manages encryption at the device level, as well as app-to-app communications. With [!INCLUDE[pn_intune](../../../includes/pn-intune.md)], you can selectively wipe managed apps and related data on devices that are unenrolled, no longer compliant, lost, stolen, or retired from use.  
  
 With [!INCLUDE[pn_crm_8_1_0_online_subsequent](../../../includes/pn-crm-8-1-0-online-subsequent.md)], you can use [!INCLUDE[pn_intune](../../../includes/pn-intune.md)] mobile application management (MAM) to manage [!INCLUDE[pn_crm_shortest](../../../includes/pn-crm-shortest.md)] mobile applications for [!INCLUDE[tn_apple](../../../includes/tn-apple.md)] and [!INCLUDE[tn_android](../../../includes/tn-android.md)] without enrolling the device. This protects company data in [!INCLUDE[pn_crm_shortest](../../../includes/pn-crm-shortest.md)] without requiring you to enroll and deeply manage the end user's entire device. This is particularly useful for bring-your-own-device (BYOD) scenarios where end users don’t want to or can’t enroll their devices for IT management. This capability is also useful if a device is already enrolled in another mobile application management solution.  
  
### More information  
 For more information about getting and using [!INCLUDE[pn_intune](../../../includes/pn-intune.md)], see:  
  
-   [Microsoft Intune](https://www.microsoft.com/server-cloud/products/microsoft-intune/)  
  
-   [Documentation for Microsoft Intune](https://technet.microsoft.com/library/jj676587.aspx)  
  
## Set up  conditional access to Dynamics 365 apps  
 You can use [!INCLUDE[pn_ms_System_Center_Config_Mgr_short](../../../includes/pn-ms-system-center-config-mgr-short.md)] conditional access to manage access to [!INCLUDE[pn_crm_shortest](../../../includes/pn-crm-shortest.md)] from mobile devices based on conditions you specify. For more information about setting up conditional access, see [Conditional Access in Configuration Manager](https://technet.microsoft.com/library/dn919655.aspx).  
  
> [!NOTE]
>  To use conditional access, you must have an Azure Active Directory premium subscription.
>
> [!IMPORTANT]
> [!INCLUDE[cc_feature_included_with_update_8_1_0_admins](../../../includes/cc-feature-included-with-update-8-1-0-admins.md)]

## Secure [!INCLUDE[pn_crm_shortest](../../../includes/pn-crm-shortest.md)] on mobile devices with [!INCLUDE[pn_dynamics_crm_for_good](../../../includes/pn-dynamics-crm-for-good.md)]
 [!INCLUDE[pn_dynamics_crm_for_good](../../../includes/pn-dynamics-crm-for-good.md)] is a special version of [!INCLUDE[pn_moca_short](../../../includes/pn-moca-short.md)] that works with the [!INCLUDE[pn_good_technology](../../../includes/pn-good-technology.md)] mobile security platform. [!INCLUDE[pn_dynamics_crm_for_good](../../../includes/pn-dynamics-crm-for-good.md)] is currently supported for [!INCLUDE[tn_Apple_ipad](../../../includes/tn-apple-ipad.md)] and [!INCLUDE[tn_Apple_iphone](../../../includes/tn-apple-iphone.md)] running iOS 7 or later. To use [!INCLUDE[pn_dynamics_crm_for_good](../../../includes/pn-dynamics-crm-for-good.md)], you must have [!INCLUDE[pn_good_dynamics](../../../includes/pn-good-dynamics.md)] server software and services from [Good Technology](https://www1.good.com/).

### Prepare to use [!INCLUDE[pn_dynamics_crm_for_good](../../../includes/pn-dynamics-crm-for-good.md)]
 Your organization should have services set up with [!INCLUDE[pn_good_technology](../../../includes/pn-good-technology.md)]. Then follow the common directions for configuring [!INCLUDE[pn_moca_short](../../../includes/pn-moca-short.md)] in [Set up Dynamics 365 for phones and Dynamics 365 for tablets](set-up.md).

 In addition, the [!INCLUDE[pn_good_dynamics](../../../includes/pn-good-dynamics.md)] admin should do the following:

1. Within the Good Control server, authorize the [!INCLUDE[pn_dynamics_crm_for_good](../../../includes/pn-dynamics-crm-for-good.md)] app for mobile users.

2. Within the Good Control server, add connection URLs to the allowed list. Any domain that the app needs to access for connection or content must be in the **Allowed Domains** list.

   If you're using an on-premises deployment, see [Configure a Microsoft Dynamics 365 apps Internet-facing deployment](https://technet.microsoft.com/library/hh699814.aspx).
  
3. Send users the email address and access key they will need to set up the app, or set up another secured application to act as an authentication delegate.  
  
### What users need to do  
 Users should update to the latest version of the [!INCLUDE[pn_dynamics_crm_for_good](../../../includes/pn-dynamics-crm-for-good.md)] application. On the Apple App store, the latest version is 1.1. On the [Good Dynamics Marketplace](https://go.microsoft.com/fwlink/p/?LinkId=524809) or Good Control Console, the latest version is listed as 1.1.0.  
  
 Direct your users to [Secure your mobile data with Microsoft Dynamics 365 apps for Good](https://go.microsoft.com/fwlink/p/?LinkID=525026)  
  
### Install [!INCLUDE[pn_dynamics_crm_for_good](../../../includes/pn-dynamics-crm-for-good.md)]  
 The app is listed in the [Good Dynamics Marketplace](https://go.microsoft.com/fwlink/p/?LinkId=524809) and can be downloaded from the [Apple App Store](https://go.microsoft.com/fwlink/p/?LinkId=524762).  
  
### Supported languages for [!INCLUDE[pn_dynamics_crm_for_good](../../../includes/pn-dynamics-crm-for-good.md)]  
 [!INCLUDE[pn_dynamics_crm_for_good](../../../includes/pn-dynamics-crm-for-good.md)] supports the same languages as [!INCLUDE[pn_moca_short](../../../includes/pn-moca-short.md)]. However, when users are viewing [!INCLUDE[pn_good_dynamics](../../../includes/pn-good-dynamics.md)] pages, only the following languages are supported:  
  
- Dutch - 1043  
  
- English - 1033  
  
- French - 1036  
  
- German - 1031  
  
- Italian - 1040  
  
- Spanish - 3082  
  
  While viewing [!INCLUDE[pn_good_dynamics](../../../includes/pn-good-dynamics.md)] pages, if you’re not using one of the languages listed, the screens will be in English.  
  
### Things to know about [!INCLUDE[pn_dynamics_crm_for_good](../../../includes/pn-dynamics-crm-for-good.md)]  
  
- Requires [!INCLUDE[pn_crm_2015](../../../includes/pn-crm-2015.md)] or later. Connecting to earlier versions is not a supported secure configuration.  
  
- The [!INCLUDE[pn_dynamics_crm_for_good](../../../includes/pn-dynamics-crm-for-good.md)] Apple app requires [!INCLUDE[pn_crm_online_2015_update_1](../../../includes/pn-crm-online-2015-update-1.md)] when running on an [!INCLUDE[tn_iphone](../../../includes/tn-iphone.md)].  
  
- There are multiple policies [!INCLUDE[pn_good_dynamics](../../../includes/pn-good-dynamics.md)] administrators set to control data sharing between apps on the mobile device.  
  
  1. **Prevent click-to-call:** Prevents users from initiating a phone call from within the [!INCLUDE[pn_dynamics_crm_for_good](../../../includes/pn-dynamics-crm-for-good.md)] app.  
  
  2. **Prevent click for mapping:** Prevents users from opening an address in the mobile device's native maps application.  
  
  3. **Prevent opening OneNote:** Prevents users from opening [!INCLUDE[pn_microsoft_onenote](../../../includes/pn-microsoft-onenote.md)] notebooks from external sources from within the [!INCLUDE[pn_dynamics_crm_for_good](../../../includes/pn-dynamics-crm-for-good.md)] app.  
  
  4. **Prevent opening Word:** Prevents users from opening [!INCLUDE[pn_ms_Word_short](../../../includes/pn-ms-word-short.md)] files from external sources within the [!INCLUDE[pn_dynamics_crm_for_good](../../../includes/pn-dynamics-crm-for-good.md)] app.  
  
  5. **Prevent opening Excel:** Prevents users from opening [!INCLUDE[pn_microsoft_excel](../../../includes/pn-microsoft-excel.md)] files from external sources from within the [!INCLUDE[pn_dynamics_crm_for_good](../../../includes/pn-dynamics-crm-for-good.md)] app.  
  
  6. **Prevent opening PowerPoint:** Prevents users from opening [!INCLUDE[pn_MS_Powerpoint](../../../includes/pn-ms-powerpoint.md)] files from external sources from within the [!INCLUDE[pn_dynamics_crm_for_good](../../../includes/pn-dynamics-crm-for-good.md)] app.  
  
  7. **Require a secure browser for opening URLs:** Enable to ensure browser windows launched from the [!INCLUDE[pn_dynamics_crm_for_good](../../../includes/pn-dynamics-crm-for-good.md)] app use a secure browser application.  
  
  > [!IMPORTANT]
  >  The policies for preventing opening [!INCLUDE[pn_microsoft_onenote](../../../includes/pn-microsoft-onenote.md)], [!INCLUDE[pn_ms_Word_short](../../../includes/pn-ms-word-short.md)], [!INCLUDE[pn_microsoft_excel](../../../includes/pn-microsoft-excel.md)], and [!INCLUDE[pn_MS_Powerpoint](../../../includes/pn-ms-powerpoint.md)] files block opening these files on external sources such as [!INCLUDE[pn_ms_SharePoint_long](../../../includes/pn-ms-sharepoint-long.md)], [!INCLUDE[pn_onedrive_for_business](../../../includes/pn-onedrive-for-business.md)], and [!INCLUDE[pn_office_365_groups](../../../includes/pn-office-365-groups.md)]. These policies don’t apply to items attached to notes in [!INCLUDE[pn_crm_shortest](../../../includes/pn-crm-shortest.md)] or when exporting to [!INCLUDE[pn_microsoft_excel](../../../includes/pn-microsoft-excel.md)], [!INCLUDE[pn_microsoft_excel](../../../includes/pn-microsoft-excel.md)] templates, and [!INCLUDE[pn_ms_Word_short](../../../includes/pn-ms-word-short.md)] templates. These files download to Good-compliant encrypted file stores and require a Good-compliant application for viewing.  
  
- Enable the **Prevent Data Leakage** setting in the **Security Policies** tab to cover other situations including using a secure app for email, and handling of copy/paste scenarios.  
  
  ![Enable to prevent data leakage in Dynamics 365 apps](../../../admin/media/good-prevent-data-leakage.png "Enable to prevent data leakage in Dynamics 365 apps")  
  
- All data stored on the client when using [!INCLUDE[pn_dynamics_crm_for_good](../../../includes/pn-dynamics-crm-for-good.md)] is encrypted using [!INCLUDE[pn_good_dynamics](../../../includes/pn-good-dynamics.md)] APIs.  
  
- Remote wipe is available and will not affect non-secured apps leaving personal apps and information untouched.  
  
- Contact [Good Technology](https://www1.good.com/) regarding the specific support that can be provided with your suite/pricing, as well as the correct server setup for your needs and situation.  



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]