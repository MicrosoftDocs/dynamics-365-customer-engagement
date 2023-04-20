---
title: "Common issues and resolutions for Dynamics 365 for phones and tablets | MicrosoftDocs"
ms.custom:
description: Troubleshoot and issues to know about Dynamics 365 for phones and tablets.
ms.date: 04/20/2023
ms.reviewer:
ms.suite:
ms.tgt_pltfrm:
ms.topic: error-reference
applies_to: Dynamics 365 apps
ms.assetid: 55e7ba52-2f18-4eaf-8281-70cd639887f8
caps.latest.revision: 33
ms.author: sericks
author: sericks007
search.audienceType:
  - admin
  - customizer
  - enduser
---
# Common issues and resolutions for Dynamics 365 for phones and tablets

This article describes common issues you may experience when using Dynamics 365 for phones and tablets, and provides resolutions for those issues.

## Error message: Your device configuration is preventing sign-in

If you receive this message it means that your IT administrator is using Microsoft Intune and requires you to sign-in securely using an authenticator app, but your device configuration is blocking the Dynamics 365 mobile app from launching the authenticator app installed on your device. Microsoft authenticator apps are Authenticator and Company Portal. Your company may also use a third-party authenticator app. If you are unsure, ask your IT administrator which authenticator app you should be using and then follow the instructions below.

On iOS and sometimes on Android devices, manually opening (or restarting) your authenticator app on your device before you try to sign-in again from the Dynamics 365 mobile app is enough to fix the issue.
 
If you are using an Android device and the suggestion above did not work, the steps to resolve the issue are device manufacturer-specific and depend which authenticator app you have installed.

For **Huawei** and **Honor** device, do the following:

1. Go to **Settings** > **Battery** > **App launch**. 

    > [!NOTE]
    > The **App launch** menu can have different names depending on the model and the operating version of your mobile device. If you   don’t see the **App launch** menu option, then look for one of the following menu options:
    > 
    > - **Close apps after screen lock** 
    > - **Applications** 
    > - **Background applications**

2. Under **Manage automatically** for the authenticator app set the toggle switch to **OFF**.
3. On the **Manage manually** screen ensure that **Secondary launch / Can be launched by other apps** is enabled. This will allow the Dynamics 365 mobile app to launch the app.

For **Vivo** device, do the following:

1. Go to **Settings** > **More Settings** > **Applications** > **Autostart**.
2. Set the toggle switch to **ON** for the authenticator app.

For other device manufacturers, please email Dynamics 365 Mobile Support at dynmobisup@microsoft.com and include your device make and model, session ID ([learn how to find the session ID and logs](logs-session-id.md) and quote the error message above.


## Redirected URLs do not work when you configure the Dynamics 365 mobile app
URLs that redirect, such as [!INCLUDE[pn_iis](../includes/pn-iis.md)] host headers or link-shortening websites such as tinyurl or bitly, do not work when you use the URL in the **Dynamics 365 apps web address** field with Dynamics 365 mobile during configuration.  
  
For example, an `https://www.contosocrm.com` host header for a Dynamics 365 apps online  website URL that is actually `https://crm.contososerver001.com`, will not work and will display an error message. To work around this behavior, you must enter the actual web address for the Microsoft Dataverse or Dynamics 365 Customer Engagement (on-premises) organization. When this issue occurs and you have enabled logging, the information logged is similar to the following. Notice that the URLs in lines 2 and 3 are different. That difference indicates a redirected URL.  
  
1.  User entered URL: `https://URL_entered`  
  
2.  Constructed server URL: `https://URL_after_CRMforTablets_processing`  
  
3.  HTTP Response location: `https://URL_that_the_response_came_from`  











   
   






[!INCLUDE[footer-include](../includes/footer-banner.md)]
