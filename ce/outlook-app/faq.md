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

## Dynamics 365 App for Outlook does not display the recipient picker and instead displays a different dashboard. How do I switch it back?

Dynamics 365 Dynamics 365 App for Outlook landing page is a dashboard that is configured in the App Module named “App for Outlook”. An administrator or a system customizer will need to ensure that the default dashboard is correctly set in Dynamics 365. This is documented here.

## When I open Dynamics 365 App for Outlook, I see a blue screen with errors related to Server-Side Synchronization. How do I recover from this?
Currently, Dynamics 365 App for Outlook requires Server-Side Synchronization to be successfully set up on the Exchange mailbox. Depending on the scenario, you may see one of the following messages displayed.

 -	Email account isn't configured with server-side synchronization for incoming email
 -	Email account isn’t configured with server-side sync for appointments, contacts, and tasks
 -	Your mailbox is inactive

This means that there is an issue with the Server-Side Synchronization settings on the mailbox. Ensure that you or your administrator follows the steps mentioned here to successfully set up Server-Side Synchronization.

## When I track or set the Regarding record on an email or an appointment in Outlook, it goes into a “Pending” state. Why?
Dynamics 365 App for Outlook tracks and synchronizes your mail and calendar data between Outlook (Exchange) and Dynamics 365 via Server-Side Synchronization, which is an asynchronous service that runs in the background approximately every 15 minutes.
The scenarios where an Outlook item is immediately tracked to Dynamics 365 is documented here.

## The warning and error messages in Dynamics 365 are not in the language selected in Dynamics 365. Why?
When we display diagnostic information and some labels in contact tracking module in Dynamics 365 App for Outlook, we use the Office (Outlook) display language setting and not Dynamics 365 language setting in order to be consistent with the host application experience.

## We have defined a web resource on a form in Unified Interface. The web resource is not displayed in the form when opened in Dynamics 365 App for Outlook. Why?
In general, web resources on Forms will not be rendered in App for Outlook as they require cookie authentication, which is currently only supported in browsers. 

However, when scripts which do not rely on cookie authentication are used, those will be rendered on a Form in Dynamics 365 App for Outlook.
