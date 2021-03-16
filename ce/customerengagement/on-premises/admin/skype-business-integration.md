---
title: "Skype for Business and SKype integration with Dynamics 365 for Customer Engagement apps | MicrosoftDocs"
ms.custom: 
ms.date: 08/07/2020
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
ms.assetid: 6cc410d4-2c5a-42f6-97a0-af7259182e9a
caps.latest.revision: 27
author: Mattp123
ms.author: matp
manager: brycho
search.audienceType: 
  - admin

---
# Skype for Business and Skype integration

*This content also applies to the on-premises version.*

If your organization uses [!INCLUDE[pn_skype_for_business](../includes/pn-skype-for-business.md)] or Skype, you can take advantage of connectivity features like click-to-call or checking user availability from within [!INCLUDE[pn_microsoftcrm](../includes/pn-dynamics-crm.md)] apps or [!INCLUDE[pn_microsoft_dynamics_crm_for_outlook](../includes/pn-microsoft-dynamics-crm-for-outlook.md)].  
  
<a name="BKMK_UseLync"></a>   
## Using Skype for Business with Dynamics 365 for Customer Engagement apps 

 When you use [!INCLUDE[pn_skype_for_business](../includes/pn-skype-for-business.md)] and [!INCLUDE[pn_microsoftcrm](../includes/pn-dynamics-crm.md)] apps together, you can use [!INCLUDE[pn_skype_for_business](../includes/pn-skype-for-business.md)] presence and click-to-call from within [!INCLUDE[pn_microsoftcrm](../includes/pn-dynamics-crm.md)] apps.  
  
### Requirements and Dynamics 365 for Customer Engagement apps configuration  

- Your organization must have a Skype for Business Online license.
  
- To use click-to-call, [!INCLUDE[pn_skype_for_business](../includes/pn-skype-for-business.md)] must be selected as the telephony provider in [!INCLUDE[pn_microsoftcrm](../includes/pn-dynamics-crm.md)] apps. You can set this on the General tab at Settings > Administration > System Settings.  
  
- By default, [!INCLUDE[pn_skype_for_business](../includes/pn-skype-for-business.md)] presence is enabled in [!INCLUDE[pn_microsoftcrm](../includes/pn-dynamics-crm.md)] apps. System administrators can enable or disable presence in [!INCLUDE[pn_microsoftcrm](../includes/pn-dynamics-crm.md)] apps. To do this, click **Settings** > **Administration** > **System Settings** and on the **General** tab, **Set the IM presence option** to **Yes** or **No**.  
  
- Each user must have the [!INCLUDE[pn_skype_for_business](../includes/pn-skype-for-business.md)] client installed and running on their PC.  
  
- For [!INCLUDE[pn_skype_for_business](../includes/pn-skype-for-business.md)] presence, [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] apps users must have `https://*.dynamics.com` added to their web browsers trusted sites list in Internet options in [!INCLUDE[pn_Internet_Explorer](../includes/pn-internet-explorer.md)].  
  
### Supported devices and web browsers when you use Skype for Business with Microsoft Dynamics 365 for Customer Engagement apps 
  
|                             Mobile app or web browser                             | Skype for Business click-to-call | Skype for Business presence |
|-----------------------------------------------------------------------------------|----------------------------------|-----------------------------|
|            [!INCLUDE[pn_crm_for_ipad](../includes/pn-crm-for-ipad.md)]            |               Yes                |             No              |
|        [!INCLUDE[pn_moca_CRM_Android](../includes/pn-moca-crm-android.md)]        |               Yes                |             No              |
| [!INCLUDE[pn_ms_Windows_short](../includes/pn-ms-windows-short.md)]-based tablets |               Yes                |             No              |
|       [!INCLUDE[pn_Internet_Explorer](../includes/pn-internet-explorer.md)]       |               Yes                |             Yes             |
|           [!INCLUDE[tn_Google_Chrome](../includes/tn-google-chrome.md)]           |               Yes                |             No              |
|         [!INCLUDE[tn_Mozilla_Firefox](../includes/tn-mozilla-firefox.md)]         |               Yes                |             No              |
|            [!INCLUDE[tn_Apple_Safari](../includes/tn-apple-safari.md)]            |               Yes                |             No              |

<a name="BKMK_UseSkype"></a>   

## Using Skype with Dynamics 365 for Customer Engagement apps 
 When you use [!INCLUDE[pn_skype](../includes/pn-skype.md)] and [!INCLUDE[pn_microsoftcrm](../includes/pn-dynamics-crm.md)] apps together, you can use [!INCLUDE[pn_skype](../includes/pn-skype.md)] click-to-call from within [!INCLUDE[pn_microsoftcrm](../includes/pn-dynamics-crm.md)] apps.  
  
**Client requirements and [!INCLUDE[pn_microsoftcrm](../includes/pn-dynamics-crm.md)] apps configuration**  
  
- Each user must have the [!INCLUDE[pn_skype_for_windows](../includes/pn-skype-for-windows.md)] desktop client or the [!INCLUDE[pn_skype_for_windows_8](../includes/pn-skype-for-windows-8.md)] app installed and running on their PC or [!INCLUDE[pn_windows8](../includes/pn-windows8.md)] device.  
  
- **Skype** must be selected as the telephony provider in [!INCLUDE[pn_microsoftcrm](../includes/pn-dynamics-crm.md)] apps. You can set this on the **General** tab at **Settings** > **Administration** > **System Settings**.  
  
### Supported devices and web browsers when you use Skype with Dynamics 365 for Customer Engagement apps 
  
|                                                    Mobile app or web browser                                                     | Skype click-to-call |
|----------------------------------------------------------------------------------------------------------------------------------|---------------------|
|                                   [!INCLUDE[pn_crm_for_ipad](../includes/pn-crm-for-ipad.md)]                                    |         Yes         |
| [!INCLUDE[pn_moca_CRM_Android](../includes/pn-moca-crm-android.md)] on [!INCLUDE[tn_android](../includes/tn-android.md)] tablets |         Yes         |
|                        [!INCLUDE[pn_ms_Windows_short](../includes/pn-ms-windows-short.md)]-based tablets                         |         Yes         |
|                              [!INCLUDE[pn_Internet_Explorer](../includes/pn-internet-explorer.md)]                               |         Yes         |
|                                  [!INCLUDE[tn_Google_Chrome](../includes/tn-google-chrome.md)]                                   |        Yes\*        |
|                                [!INCLUDE[tn_Mozilla_Firefox](../includes/tn-mozilla-firefox.md)]                                 |       Yes\*\*       |
|                                   [!INCLUDE[tn_Apple_Safari](../includes/tn-apple-safari.md)]                                    |         Yes         |
  
 \* The [Skype Click-to-call plugin](https://www.skype.com/go/clicktocall) must be installed on the [!INCLUDE[tn_chrome](../includes/tn-chrome.md)] browser and enabled. More information: [How do I enable Skype Click to Call in Chrome?](https://support.skype.com/en/faq/FA12243/how-do-i-enable-skype-click-to-call-in-chrome)  
  
 Additionally, [!INCLUDE[pn_skype](../includes/pn-skype.md)] click-to-call is supported with [!INCLUDE[pn_crm_for_windows_8](../includes/pn-crm-for-windows-8.md)], [!INCLUDE[pn_moca_CRM_Windows_8_1](../includes/pn-moca-crm-windows-8-1.md)], and [!INCLUDE[pn_windows_10](../includes/pn-windows-10.md)].  
  
### See also  
 [Set up Dynamics 365 for Customer Engagement apps (online) to use Skype or Skype for Business](../admin/set-up-skype-or-skype-for-business.md)   



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]