---
title: "Frequently Asked Questions about Dynamics 365 App for Outlook  (Dynamics 365 for Customer Engagement apps) | MicrosoftDocs"
ms.custom: 
ms.date: 01/15/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement apps 
  - Dynamics 365 for Customer Engagement apps Version 9.x
ms.assetid: 0dfd6100-b4ed-4959-9acb-cc0a1dbbb6d6
caps.latest.revision: 99
author: mduelae
ms.author: mkaur
manager: kvivek
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Outlook
---
# Frequently Asked Questions about Dynamics 365 App for Outlook

## Are there any known issues?
Yes, here is the list known issues:

- Users who are assigned a custom security role may not be able to access [!INCLUDE[pn_crm_app_for_outlook_short](../includes/pn-crm-app-for-outlook-short.md)]. We are working on a fix for this issue. In the meantime, for a workaround, see this [support article](https://support.microsoft.com/help/4078135/sorry-something-went-wrong-while-initializing-the-app-when-accessing-t). 
- Delegated users cannot track emails using [!INCLUDE[pn_crm_app_for_outlook_short](../includes/pn-crm-app-for-outlook-short.md)]. Try using folder-level tracking or automatic tracking for delegated users.  

For other known issues with this version of [!INCLUDE[pn_crm_app_for_outlook_short](../includes/pn-crm-app-for-outlook-short.md)], see the [Dynamics 365 for Customer Engagement apps Readme](../admin/readme-9.md). 

## Dynamics 365 App for Outlook does not display the recipient picker and instead displays a different dashboard. How do I switch it back?
Dynamics 365 Dynamics 365 App for Outlook landing page is a dashboard that is configured in the App Module named “App for Outlook”. An administrator or a system customizer will need to ensure that the default dashboard is correctly set in Dynamics 365. For more information, see [Limitations when customizing Dynamics 365 App for Outlook](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/outlook-app/limitations-when-customizing-app-for-outlook#customizing-app-for-outlook-sitemap).

## When I open Dynamics 365 App for Outlook, I see a blue screen with errors related to Server-Side Synchronization. How do I recover from this?
Currently, Dynamics 365 App for Outlook requires Server-Side Synchronization to be successfully set up on the Exchange mailbox. Depending on the scenario, you may see one of the following messages displayed.

 -	Email account isn't configured with server-side synchronization for incoming email
 -	Email account isn’t configured with server-side sync for appointments, contacts, and tasks
 -	Your mailbox is inactive

This means that there is an issue with the Server-Side Synchronization settings on the mailbox. Make sure Server-Side Synchronization is set up correctly. Note, this requires admin privileges. For more information see, [Connect Dynamics 365 for Customer Engagement apps to Exchange Online](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/admin/connect-exchange-online). 

## When I track or set the Regarding record on an email or an appointment in Outlook, it goes into a “Pending” state. Why?
Dynamics 365 App for Outlook tracks and synchronizes your mail and calendar data between Outlook (Exchange) and Dynamics 365 via Server-Side Synchronization, which is an asynchronous service that runs in the background approximately every 15 minutes.
The scenarios where an Outlook item is immediately tracked to Dynamics 365 is documented in the [Synchronization and tracking
](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/outlook-app/dynamics-365-app-outlook-user-s-guide#synchronization-and-tracking) section of the user guide.

## As an administrator, when I go to the Dynamics 365 App for Outlook section in **Settings**, a user does not appear in the **All Eligible Users** list. 
For more information, see [A user does not appear in the All Eligible Users list within the Dynamics 365 App for Outlook area](https://support.microsoft.com/help/4345543).

## When I open Dynamics 365 App for Outlook on Outlook desktop, I see a blank page instead of the App. Why is this happening?
For more information, see [Blank page appears within Dynamics App for Outlook](https://go.microsoft.com/fwlink/p/?linkid=2007128).

> [!Note]
> If the link above does not work in Internet Explorer (IE), please try using another browser.

## Some of my appointments in Outlook and Dynamics 365 are cancelled or deleted unexpectedly. Why is this happening?
For more information, see [An appointment is cancelled or deleted unexpectedly when using Server-Side Synchronization](https://go.microsoft.com/fwlink/p/?linkid=2007027).

## I am unable to track contacts.
For more information, see [Issue when trying to access Dynamics 365 within the Add-ins area of Outlook](https://support.microsoft.com/help/3211586).

## I need help troubleshooting the App.
For more information, see [Troubleshooting](https://go.microsoft.com/fwlink/p/?linkid=2007025).

## The warning and error messages in Dynamics 365 are not in the language selected in Dynamics 365. Why?
When we display diagnostic information and some labels in contact tracking module in Dynamics 365 App for Outlook, we use the Office (Outlook) display language setting and not Dynamics 365 language setting in order to be consistent with the host application experience.

## We have defined a web resource on a form in Unified Interface. The web resource is not displayed in the form when opened in Dynamics 365 App for Outlook. Why?
In general, web resources on Forms will not be rendered in App for Outlook as they require cookie authentication, which is currently only supported in browsers. An example of this type of JavaScript customization is XMLHttpRequest based ODATA API calls, which are not supported.

However, when scripts which do not rely on cookie authentication are used, those will be rendered on a Form in Dynamics 365 App for Outlook. An example of this is the use of XRM WebAPI.

## I am able to use Dynamics 365 App for Outlook in Outlook Web Access in Edge browser, but it doesn’t work in Outlook Desktop. Why?
Dynamics 365 App for Outlook needs Internet Explorer 11 or higher to be installed on your machine. If you have Internet Explorer 11 already, please also make sure your organization URL <orgname.crm.dynamics.com> is not in the Compatibility View list.
