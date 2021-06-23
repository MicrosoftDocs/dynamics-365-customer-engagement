---
title: "Check your message for errors and prepare it for delivery (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to finalize your email message, check it for errors, go live, and schedule it for delivery using a customer journey in Dynamics 365 Marketing."
ms.date: 04/07/2020
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Check for errors, go live, and deliver the messages

When you're done designing and previewing your email, you're ready to start sending it. First, you need to check it for errors. Then, once it passes the error check, you must go live to activate it and make it available on the marketing services. Finally, set up a customer journey to establish the target segment, delivery schedule, and follow-up actions.

<a name="error-check"></a>

## Required elements: How to pass the error check

Before you can go-live with or test-send your message, it must pass an error check. You can run an error check at any time by selecting **Check for Errors** on the command bar. An error check is also run automatically each time you select **Go Live** or **Test Send**.

All messages must include the following:

- Subscription center link, using a URL taken from the [content settings](dynamic-email-content.md#content-settings) using the expression `{{msdyncrm_contentsettings.msdyncrm_subscriptioncenter}}` (required for commercial messages only). More information: [Add standard, required, and specialized links to your message](email-design.md#required-links) and [Use assist edit to place dynamic field values](dynamic-email-content.md#assist-edit)
- Sender's physical address, taken from the [content settings](dynamic-email-content.md#content-settings) using the expression `{{msdyncrm_contentsettings.msdyncrm_addressmain}}`. More information: [Use assist edit to place dynamic field values](dynamic-email-content.md#assist-edit)
- A **Subject** entered as static text or a [dynamic expression](dynamic-email-content.md) that resolves to valid text.
- A **From name** and valid **From address** entered as static text or [dynamic expressions](dynamic-email-content.md) that resolve to a valid name and address.
- An HTML body (your message content).
- A [plain-text version](email-properties.md#text-only) of the message. This version must exist and must also include a subscription center link and the sender's physical address (this usually gets generated automatically, but you should review it).

The following are also confirmed by the check:

- All [dynamic expressions](dynamic-email-content.md) and HTML code must compile and generate valid values.
- All videos and images referenced from the Dynamics 365 Marketing content libraries must exist.
- The **To** field must be an expression (not a static value) that results in a valid email address. The customer journey that sends the message will use this expression to find the address to use for each recipient (contact) processed by the journey. The default expression provided for this (`{{contact.emailaddress1}}`) is usually best, but you might customize this to support custom scenarios (such as email addresses stored in another field).
- The **From address** should use a domain that is authenticated and registered using DKIM as belonging to your organization. You can go live with a **From address** that uses an unauthenticated domain, but you'll get a warning because this isn't recommended. You can't go live with a domain that is authenticated as belonging to another organization (this generates an error). More information: [Authenticate your domains](mkt-settings-authenticate-domains.md)

> [!NOTE]
> Errors that result from problems with your dynamic expressions are described in detail and provide a code sample that should help you locate the problem. However, one message, which shows the text "Dynamic content references a static entity that's missing a record ID", can appear for two different reasons. The first reason is the one implied by the text, which means you included a [reference to a specific record](dynamic-email-content.md#assist-edit-expressions), but left out the ID of the record you want to show. The second reason (which is only loosely related to the displayed text) is that you are referencing an entity that isn't yet synced with the marketing-insights service and therefore isn't available to the error checker; to fix this, ask your admin to confirm whether the required entity is synced, and to add it if it isn't. More information: [Choose entities to sync with the marketing-insights service](mkt-settings-sync.md) 

<a name="go-live-journey"></a>

## Go live and set up a customer journey to deliver your message

While you prepare a message, it stays in a draft state, which means that it's inactive and can't be sent. To send it, you must first go live with it (which activates its dynamic content and moves it to the bulk messaging server), and then add it to a customer journey.

To publish a message, open it and select **Go Live** on the command bar. Dynamics 365 Marketing will run a final validation check, as described in the previous section, and&mdash;if it passes&mdash;publish the message. If errors are returned, read the error messages, address the issues, and try again until the message is successfully published.

To address, schedule and deliver the message, set up a customer journey that includes a segment tile to define the target audience and an email tile that references your live email design and delivers it to each contact that enters the tile. You can also include any number of other tiles, including triggers and follow-up actions. To run the customer journey and begin sending messages, choose a start date and end date and go live.

[!INCLUDE [cc-marketing-email-size](../includes/cc-marketing-email-size.md)]

More information: [Use customer journeys to create automated campaigns](customer-journeys-create-automated-campaigns.md) and [Go live with publishable entities and track their status](go-live.md)

## Gain insights from your email results

Once you start delivering an email message using a customer journey, Dynamics 365 Marketing will begin to collect information about how recipients interact with that message.  The system provides a wealth of information, including analyitics, KPIs, graphs, and more, to help you gain insights from your marketing results. More information: [Analyze results to gain insights from your marketing activities](insights.md)

### See also

[Tutorial: Create a marketing email and go live](create-marketing-email.md)  
[Email marketing overview](prepare-marketing-emails.md)  
[Create a new email and design its content](email-design.md)  
[Add dynamic content to email messages](dynamic-email-content.md)  
[Set the sender, receiver, language, and legal designation](email-properties.md) 
[Check your work using previews and test sends](email-preview.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]