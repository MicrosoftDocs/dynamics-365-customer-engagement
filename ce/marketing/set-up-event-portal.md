---
title: "Set up an event website (Dynamics 365 for Marketing) | Microsoft Docs"
description: "Set up a Dynamics 365 for Marketing event website, where people can read about your event and its speakers, create an account, register for the event, purchase passes, view their session schedule, and more."
keywords: event;portals;event website
ms.date: 03/08/2019
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - Dynamics 365 for Customer Engagement Version 9.x
ms.assetid: b83e8cb2-38a4-462f-87bc-0fc52357f01e
author: kamaybac
ms.author: kamaybac
manager: shellyha
ms.reviewer:
topic-status: Drafting
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Set up the event website

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

The event website provides an online resource where people can read about your event and its speakers, create an account, register for the event, purchase passes, view their session schedule, and more. The following image shows a simplified site map of your event website as your attendees will see it.

![Sitemap for the standard event website](media/event-portal-sitemap-ill.png "Site map for the standard event website")

The event site is preconfigured to fetch all the relevant graphics and information for each published event from [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], and to enable visitors to create a registration account (including username and password), edit their profile, register themselves and others for an event, choose session passes, view their event schedule, and modify or cancel an event registration.

<a name="customize"></a>

## Customize and host the event website

The first time you install [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], the event website is installed onto your [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] portals solution and is ready to use right out of the box. The website is built using the [Angular](https://angular.io/) framework (which makes it easy to customize) and you can choose to host it anywhere (not just on the [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] portals solution). The following table describes the hosting options.

| | Dynamics&nbsp;365<br/>native portal | Angular site hosted by<br/>Dynamics&nbsp;365 portals | Angular site<br>hosted externally |
|--|--|--|--|
|Availability | Discontinued (no longer available) | Installed out-of-the-box; fully customizable | [Download the project, customize it, and deploy it to your own server](developer/event-management-web-application.md) |
| Event information and graphics | Fetched directly from [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] event records | Fetched directly from [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] event records | Fetched directly from [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] event records |
| Payment gateway |  [Build a gateway page](event-payment-gateway.md) using native [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] portal entities and customize it according to instructions from your third-party payment provider  | [Build a gateway page](event-payment-gateway.md) using native [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] portal entities and customize it according to instructions from your third-party payment provider | [Customize the Angular app](developer/event-management-web-application.md) according to instructions from your third-party payment provider |
| Registration&nbsp;account and sign-in | Implemented using native [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] portal features; works out-of-the-box | Implemented using native [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] portal features; works out-of-the-box | You must [integrate the event website with Azure Active Directory (AAD)](developer/event-management-web-application.md) to enable registration accounts |
| The **Payment gateway** setting of the event record | Use this setting to select a [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] portal page to use as the payment gateway for each event | Use this setting to select a [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] portal page to use as the payment gateway for each event | This setting has no effect for externally hosted event websites |
| The **Allow anonymous registration** setting of the event record | Use this setting to control whether attendees can register without first creating a registration account | Use this setting to control whether attendees can register without first creating a registration account | This setting has no effect for externally hosted event websites |
| Link to the event website | The URL is generated automatically for each event. Check the **Event URL** field of the event record to find it. | The URL is generated automatically for each event. Check the **Event URL** field of the event record to find it. | The URL depends on where you host the site. You can store the URL in the event record by selecting the **Custom event URL** check box and then filling in the **Event URL** field.

You can download the Angular project from the Microsoft download center, customize it in your preferred development environment, build the project, and then either overwrite the version on your [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] portal, set it up as a new site on your portal, or host it on your own server. The entire final site comprises just two files: a JavaScript file (named `main.js`) and a stylesheet (named `styles.css`).

The first time you install [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], the then-current event website is installed onto your [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] portals solution and is ready to use right out of the box. The website won't be updated or overwritten when you update [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], so you can freely customize the copy that's installed on your portal. However, [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] will continue to develop the event website and improve it with with each new release of [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], so if you want to take advantage of the latest features, you can always download it, compare it with your own customized site, and add any of the new features that you like.

For more information about how to download the latest version of the event website, customize it, build it, and then deploy it on a [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] portal or external website, see [Build and host a custom event website](developer/event-management-web-application.md).

## Publish events, sessions, tracks, and related records to the website

Most of the information shown on the website comes directly from your event models and their various related records, so all you need to do get the website online is make sure that all the information is available in [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] and that the event itself, plus its relevant sessions and tracks, are set to be published on the website.

To publish an event, session, or track, open the relevant record and set its **Publish Status** in the drop-down list (usually shown in the upper-right corner of the form) to **Live**. Set the **Publish Status** to any other value to unpublish an event, session, or track if needed, thus removing it from your event website.

![The Publish Status menu](media/event-publish-ill.png "How to set the publish status of an event to the website")

The following table summarizes how to publish each publishable entity to the website, and which types of information are publish for each of them. Be especially careful and thorough when entering values for published fields, because they are exposed to the public.

|   **Entity**   |  **How and where it gets published**   |  **Which fields get published** |
|-------|----|-----------|
|     Events     |  Publish each event manually by opening the event record and setting the **Publish status** to **Live**. Unpublished events won't be shown on the website.<p>All published events are listed on the **All Events** page of the website.</p> |  Event name, Start date & time, End date & time, Primary venue, Description|
|    Sessions    | Publish each session manually by opening the session record and setting the **Publish status** to **Live**. Unpublished sessions won't be shown on the website.<p>Each published session is listed on the **Sessions** page for the event it belongs to, on the **Speaker** page for the speaker presenting it, and on the **Session Tracks** page for tracks it belongs to. | Session title, Start date & time, End date & time, Session summary, Detailed description, Session tracks, Duration|
|    Speakers    | Speakers are published automatically when you publish a session they are assigned to.<p>Speakers are listed on the front page for each event where they are speaking, on the **Speakers** page, and on session pages for each session they are running. A speaker profile page shows additional details and a schedule of sessions for that speaker.</p> | Name, Photo, Title, About, [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)], [!INCLUDE[tn-twitter](../includes/tn-twitter.md)], Website |
| Session Tracks |    Publish each track manually by opening the track record and setting the **Publish status** to **Live**. Unpublished tracks won't be shown on the website.<p>Published external tracks are listed on the **Session Tracks** page for the event they belong to. Each session track shows its name and a list of sessions that belong to it (with links).<p>You can only publish external tracks (not internal ones).</p>     |  Name, Audience |
|     Passes     | Passes are published automatically when you publish the event they belong to.<p>All passes associated with a published session track are listed on the **Pass Information** page for the event the track belongs to. The system tracks the number of passes available and the number assigned, and indicates when passes are sold out.</p>| Name, Name of the related track record, Pass price, Sold out status</p>             |
|    Sponsors    | Sponsors are published automatically when you publish the event they belong to.<p>Sponsors associated with published events are displayed at the bottom of most pages of the website for those events.  |  Event sponsor (the  name of the related account record), Logo (taken from the related account record for each sponsor)</p>                          |

## Configure website graphics and registration options

The website provides several per-event configuration options that you can set up using the relevant event record, without needing to customize the website code. These include graphics, check-out, and payment options.

### Upload and assign website graphics

The website features a banner image for each event, and also shows speaker photos and sponsor logos.

- You can set the banner image shown for any event by [editing the event record](set-up-event.md), going to the **General** tab and using the **Portal image** setting.

- Speaker images come from each speaker record (not from the associated contact record). To upload a speaker image, go to **Events** > **Participants** > **Speakers** and open the relevant speaker record. Then select the existing photo (or generic placeholder) in the heading area of the page to open a dialog where you can upload an image. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Set up an event](set-up-event.md)  
    ![Edit the speaker image](media/speaker-edit-image.png "Edit the speaker image")

- Sponsor images come from each sponsorship record, which you can edit by working in the event record where the sponsorship applies (found on the **Agenda** tab, which links to related sponsorship records), or by finding the appropriate sponsorship record under **Events** > **Sponsorship management** > **Sponsorships**. As with speaker images, you can edit the image by selecting the existing photo (or generic placeholder) in the heading area of the sponsorship record page.

<a name="registration"></a>

### Set registration options

When a visitor to the website decides to register for your event, they proceed as follows:

1. Open the event website and choose an event.
1. Select the **Register** button.
1. The registration page opens. If you've enabled anonymous registration, then the visitor can enter registration details right away, or they can choose to sign in (or to create an account first). If you've disabled anonymous registration, then they must sign in or create an account before they can register anyone.
    - The registration can allow several people to be registered at once, or you can set it to allow just one attendee to be registered at a time.
    - If your event offers pass-level registration and includes more than one pass, then the form allows a different pass to be selected for each registrant as needed. (Session-level registration isn't available when you use this option.)
    - If your event offers session-level registration, then the form allows the registrant to assemble their own schedule from all available sessions. (Passes and online payment aren't available if you use this option)
    - If you've chosen to enable a CAPTCHA, then the visitor must fill out the CAPTCHA field to continue after entering details about each registrant.
    - One advantage of creating a registration account is that those contacts can sign in again to view their event schedules and to cancel registrations if needed.
    - If you are hosting the event website on a [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] portal, then visitors who use the site to create a registration account must do so using an email address that doesn't belong to any contact already in your database.
1. If your event requires payment, a payment gateway opens and the visitor must enter their payment details.
1. When payment confirmation is received (or right away, if no payment is required), contact records are matched or created (as required) and registration records are created and linked to each new or existing contact that was entered into the registration form.
1. If you've enabled lead generation for the event, then a new lead record will be generated for each registered contact.

Here's how to configure each of the options that's described as optional in the previous procedure:

1. Do the following if you want to support online payment for events:
    - Create an account with a third-party payment provider.
    - Customize your event website (or set up the portal) to include a payment page that interacts with your payment provider. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Set up online payment for events](event-payment-gateway.md).
    - Set up at least one [pass for the event](set-up-event.md#event-passes). (Events with no passes assigned will skip the payment page.)
1. Go to **Events** > **Event** > **Events** and then open or create an event.
1. On the **General** tab of the event form, go to the **Key information** section. If you want to generate a lead for each contact that gets registered for this event, set **Create leads for event registrations** to **Yes**. <!-- What happens if this is "no"? -->
1. Scroll down to the **Website** section and make the following settings:
    - **Enable CAPTCHA**: Set to **Yes** to include a CAPTCHA field on the registration page. Set to **No** to hide it. This setting works for both portal hosted and externally hosted event websites.
    - **Portal payment gateway**:  If you are hosting the event website on a [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] portal, set this to the name of the portal page that you set up to implement a payment gateway. A default or simulated payment page may be used if you leave this setting blank (to disable payment, either customize the site to remove the feature, or don't create any passes for your free events). This setting has no effect if you are hosting your event website externally.
    - **Enable multi-attendee registration**: Set this to **Yes** to allow users of the event website to register several attendees at once. Set to **No** to allow just one attendee per registration.
    - **Allow anonymous registrations**: If you are hosting the event website on a [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] portal, set this to **No** to require all visitors to create an event-website account before they can register themselves or others for an event; set to **Yes** to allow visitors to register without creating an event-website account. This setting has no effect if you are hosting your event website externally; see [Build and host a custom event website](developer/event-management-web-application.md) for details about how to enable registration accounts on externally hosted sites.
1. Go to the **Agenda** tab and set the **Allow registrants to create their own agenda** option to **Yes** if you want to use session-level registration, or to **No** to use pass-level registration (with optional online payment).
1. Save your settings.

<a name="generate-leads"></a>

## Generate and match contacts and leads from event registrations

When a new event registration is received, [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] looks to see if a matching contact record already exists. If a match is found, then a new event registration is created and linked to that contact. If no match is found, a new contact record is created and linked to the new registration record. 

Your admin can choose to match incoming registrations by email alone; first name and last name; or email, first name, and last name. For details about how to choose your matching strategy, see [Event administration](events-settings.md#event-admin).

If you choose to enable lead generation for events, then a new lead will also be generated for each registration and linked to the appropriate contact. The system won't attempt to match to an existing lead. To control whether or not to generate new leads for any event, open the event record and set the **Create leads for event registrations** option to **Yes** or **No**.

<a name="open-site"></a>

## Open the event website

To find the URL for your sample event website and open it:

1. Open the relevant [event record](set-up-event.md).
1. Make sure the **Publish status** is set to **Live**.
1. Open the **General** tab and find the **Key information** section.
1. The **Event URL** field here shows the address of the website for this event. This URL is provided automatically if you're using the event website that was installed together with [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], but if you're hosting the site [somewhere else](#customize), you (or another user) must mark the **Custom event URL** check box and specify this value as required. Select the globe button at the edge of this field to open the URL.

The URL for any specific event takes the following form:

`https://<domainAndPath>/?event=<ReadableEventID>`

Where:

- _&lt;domainAndPath&gt;_ is the location where you installed the event website on your portal or external site.
- _&lt;ReadableEventID&gt;_ is a readable ID that was generated the first time you saved the event record (based on the event name). To find this value, open the relevant event record, go to the **General** tab, scroll to the **Website** section, where you'll find the **Readable event ID**. If you leave off this ID then the event website opens to a list of available events.

## Privacy notice

[!INCLUDE[cc-marketing-cookies](../includes/cc-marketing-cookies.md)]

### See also

[Set up online payment for events](event-payment-gateway.md)  
[Create interactive features with or without portals](portals.md)  
[Set up an event](set-up-event.md)  
[Go live with publishable entities and track their status](go-live.md)
