---
title: "Troubleshoot and Frequently Asked Questions about Dynamics 365 App for Outlook  (Dynamics 365 apps) | MicrosoftDocs"
ms.custom: 
description: Troubleshoot and Frequently Asked Questions about Dynamics 365 App for Outlook
ms.date: 05/20/2021
ms.reviewer: jimholtz
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: Dynamics 365 apps
ms.assetid: 0dfd6100-b4ed-4959-9acb-cc0a1dbbb6d6
caps.latest.revision: 99
author: sidhartg
ms.author: sidhartg
search.audienceType: 
  - admin
  - customizer
  - enduser
---
# Troubleshoot and FAQs about Dynamics 365 App for Outlook

## Users with custom security role can't access Dynamics 365 App for Outlook

Users who are assigned a custom security role may not be able to access Dynamics 365 App for Outlook. You may also get this error: **Sorry, something went wrong while initializing the app**

To workaround this issue, see
-  [Sorry something went wrong while initializing the app when accessing the Dynamics 365 App for Outlook](https://support.microsoft.com/help/4078135/sorry-something-went-wrong-while-initializing-the-app-when-accessing-t). 
-  [Configure Outlook or Exchange folder-level tracking](/power-platform/admin/configure-outlook-exchange-folder-level-tracking)

## When I open Dynamics 365 App for Outlook, I see a blue screen with errors related to Server-Side Synchronization. How do I recover from this?
Currently, Dynamics 365 App for Outlook requires Server-Side Synchronization to be successfully set up on the Exchange mailbox. Depending on the scenario, you may see one of the following messages displayed.

 -	Email account isn't configured with server-side synchronization for incoming email
 -	Email account isn’t configured with server-side sync for appointments, contacts, and tasks
 -	Your mailbox is inactive

This means that there is an issue with the Server-Side Synchronization settings on the mailbox. Make sure Server-Side Synchronization is set up correctly. Note, this requires admin privileges. For more information see, [Connect Dynamics 365 apps to Exchange Online](/power-platform/admin/connect-exchange-online).


## Some users might experience add-in error with the following symptoms:

You try to use the add-in by selecting Dynamics 365 App for Outlook, and the pane appears. After about 30 seconds, a yellow error section is displayed at the of
    the pane. The error could be any of the following:

- ADD-IN ERROR This add-in could not be started. Close this dialog
        to ignore the problem or select **Restart** to try again.

- ADD-IN ERROR This add-in is not responding. Close this warning
        dialog to keep it running or select **Restart** to try again.

- ADD-IN ERROR This add-in seems to be having problems. Select **Restart** to try starting it again.

- ADD-IN ERROR Sorry, we had to rest because this add-in wasn't
        responding.

Sometimes, selecting **Restart** causes the error again.

**Solutions**

Here are some of the ways in which you can address this issue:

-  Add/update the below registry keys for the users experiencing the
    add-in error.

    - **\[**HKEY\_LOCAL\_MACHINE\\SOFTWARE\\Microsoft\\Office\\16.0\\Wef**\]  
 **AlertInterval**=dword:00000000**

    - **\[**HKEY\_LOCAL\_MACHINE\\SOFTWARE\\Wow6432Node\\Microsoft\\Office\\16.0\\Wef**\]  
 **AlertInterval**=dword:00000000**

    Additional information on the registry keys can be found
[When debugging with the Microsoft Edge DevTools, the add-in crashes or reloads](/office/dev/add-ins/concepts/browsers-used-by-office-web-add-ins#when-debugging-with-the-microsoft-edge-devtools-the-add-in-crashes-or-reloads).

If the registry key doesn't work, one of the below are the only solutions for the add-in error.

-  Users experiencing add-in error can use Outlook Web App in Microsoft
    Edge or Google Chrome browsers to access Dynamics 365 App for
    Outlook.

-  Alternatively, users can update their Outlook client to the latest
    CR2 monthly enterprise channel or current channel.


## I am having authentication issues with Dynamics 365 App for Outlook while using Dynamics 365 Customer Engagement (on-premises) and Active Directory Federation Services. What can I do to resolve it?

If you have enabled Internet-facing deployment on the Microsoft Dynamics 365 Server and Configure the AD FS and still have issues with authentication then do the following:

1. On the server open the Internet Information Services (IIS) Manager program.
2. In the left panel, expand the domain name > expand and navigate to **Sites** > **Microsoft Dynamics CRM**.
3. Expand **XRMServices** and then select **2011**.
    1. Double-click on **Authentication** in the features view.
    2. Right-click on the **Windows Authentication** row and then select **Enable** if it is disabled.
    3. Right-click again on the **Windows Authentication** and then select **Providers**.
    4. For each of the listed providers, select the provider and then choose **Remove**.
    5. Close **Providers** window.
    6. Right-click again on the **Windows Authentication** and then select **Disable**.

All of the  above steps need to be completed for all included folders and files for **XRMServices** > **2011**, and for the NGA and AppWebServices folders.

> [!div class="mx-imgBorder"] 
> ![IIS Manager.](media/iis.png "IIS Manager")

## When I open Dynamics 365 App for Outlook on Outlook desktop, I see a blank page instead of the App. Why is this happening?
For more information, see [Blank page appears within Dynamics App for Outlook](https://go.microsoft.com/fwlink/p/?linkid=2007128).

> [!Note]
> If the link above does not work in Internet Explorer (IE), try using another browser.

## I am able to use Dynamics 365 App for Outlook in Outlook Web Access in the Microsoft Edge browser, but it doesn’t work in Outlook Desktop. Why?
Dynamics 365 App for Outlook needs Internet Explorer 11 or higher to be installed on your machine. If you have Internet Explorer 11 already, also make sure your organization URL <orgname.crm.dynamics.com> is not in the Compatibility View list.

## My App for Outlook launch takes time every time I load it for mail item.
For frequently used pages, pin the app so that it will stay loaded even when you switch to other mail items. 


## Dynamics 365 App for Outlook does not display the recipient picker and instead displays a different dashboard. How do I switch it back?
Dynamics 365 Dynamics 365 App for Outlook landing page is a dashboard that is configured in the App Module named “App for Outlook”. An administrator or a system customizer will need to ensure that the default dashboard is correctly set in Dynamics 365 apps. For more information, see [Limitations when customizing Dynamics 365 App for Outlook](./limitations-when-customizing-app-for-outlook.md#customizing-app-for-outlook-sitemap).

## Some of my appointments in Outlook and Dynamics 365 apps are canceled or deleted unexpectedly. Why is this happening?
For more information, see [An appointment is canceled or deleted unexpectedly when using Server-Side Synchronization](https://go.microsoft.com/fwlink/p/?linkid=2007027).


## The warning and error messages in Dynamics 365 apps are not in the language selected in Dynamics 365 apps. Why?
When we display diagnostic information and some labels in contact tracking module in Dynamics 365 App for Outlook, we use the Office (Outlook) display language setting and not Dynamics 365 apps language setting in order to be consistent with the host application experience.


## What does this notification mean, Track and Set Regarding are currently disabled. To use these features, contact your admin. You can still view and interact with your Dynamics 365 apps data?

When you use Dynamics 365 App for Outlook, you might see this notification, **Track and Set Regarding are currently disabled. To use these features, contact your admin. You can still view and interact with your Dynamics 365 apps data**.

> [!div class="mx-imgBorder"] 
> ![Outlook app notification.](media/serversidesync.png "Outlook app notification")

Dynamics 365 App for Outlook leverages server-side synchronization to keep your Exchange items in sync with Dynamics 365 apps. For example, if you track a meeting in Outlook, then the App for Outlook relies on server-side synchronization to create the activity in Dynamics 365 apps and keep the two items in sync.

If server-side synchronization is inactive on your mailbox, then you will not have the ability to track and set regarding on emails and appointments.

With the recent update, instead of blocking you from using App for Outlook, you now can view your Dynamics 365 apps information such as, accounts, contacts, and activities. You can continue to create, update and manage your information since it not related to synchronization.

To fix issues with server-side synchronization, contact your administrator, who can view the status of the service and take necessary steps to address the issue.


## When I track or set the Regarding record on an email or an appointment in Outlook, it goes into a “Pending” state. Why?
Dynamics 365 App for Outlook tracks and synchronizes your mail and calendar data between Outlook (Exchange) and Dynamics 365 via Server-Side Synchronization, which is an asynchronous service that runs in the background approximately every 15 minutes.


## I'm unable to track contacts.
For more information, see [Issue when trying to access Dynamics 365 apps within the Add-ins area of Outlook](https://support.microsoft.com/help/3211586).


## As an administrator, when I go to the Dynamics 365 App for Outlook section in **Settings**, a user does not appear in the **All Eligible Users** list. 
For more information, see [A user does not appear in the All Eligible Users list within the Dynamics 365 App for Outlook area](https://support.microsoft.com/help/4345543).

## We have defined a web resource on a form in Unified Interface. The web resource is not displayed in the form when opened in Dynamics 365 App for Outlook. Why?
In general, web resources on Forms will not be rendered in App for Outlook as they require cookie authentication, which is currently only supported in browsers. An example of this type of JavaScript customization is XMLHttpRequest based ODATA API calls, which are not supported.

However, when scripts which do not rely on cookie authentication are used, those will be rendered on a Form in Dynamics 365 App for Outlook. An example of this is the use of XRM WebAPI.


## User is not able to configure *Follow this email* button on the top pane in Dynamics 365 App for Outlook.

This feature is no longer available for configuration.



## I need help with troubleshooting the App.
For more information, see [Troubleshooting](https://go.microsoft.com/fwlink/p/?linkid=2007025).
[!INCLUDE[footer-include](../includes/footer-banner.md)]
