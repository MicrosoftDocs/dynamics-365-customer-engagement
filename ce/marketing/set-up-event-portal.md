---
title: "Set up an event website (Dynamics 365 for Marketing) | Microsoft Docs"
description: "Set up a Dynamics 365 for Marketing event website, where people can read about your event and its speakers, create an account, register for the event, purchase passes, view their session schedule, and more."
keywords: "event;portals;event website"
ms.date: 04/01/2018
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
applies_to: 
  - Dynamics 365 (online)
  - Dynamics 365 Version 9.x
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

The event site is preconfigured to fetch all the relevant graphics and information for each published event from [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)], and to enable visitors to create a registration account (including username and password), edit their profile, register themselves and others for an event, choose session passes, view their event schedule, and modify or cancel an event registration.

The first time you install [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], the event website is installed onto your [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] portals solution and is ready to use right out of the box. The website is built using the [Angular](https://angular.io/) framework (which makes it easy to [customize](#customize)) and you can choose to [host it anywhere](#customize) (not just on the [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] portals solution). 

## Publish events, sessions, tracks, and related records to the website

Most of the information shown on the website comes directly from your event models and their various related records, so all you need to do get the website online is make sure that all the information is available in [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] and that the event itself, plus its relevant sessions and tracks, are set to be published on the website.

To publish an event, session, or track, open the relevant record and set its **Publish Status** in the drop-down list (usually shown in the upper-right corner of the form) to **Published**. Set the **Publish Status** to any other value to unpublish an event, session, or track if needed, thus removing it from your event website.

![The Publish Status menu](media/event-publish-ill.png "How to set the publish status of an event to the website")

The following table summarizes how to publish each publishable entity to the website, and which types of information are publish for each of them. Be especially careful and thorough when entering values for published fields, because they are exposed to the public.


|   **Entity**   |  **How and where it gets published**   |  **Which fields get published** |
|-------|----|-----------|
|     Events     |  Publish each event manually by opening the event record and setting the **Publish status** to **Published**. Unpublished events won't be shown on the website.<p>All published events are listed on the **All Events** page of the website.</p> |  Event name, Start date & time, End date & time, Primary venue, Description|
|    Sessions    | Publish each session manually by opening the session record and setting the **Publish status** to **Published**. Unpublished sessions won't be shown on the website.<p>Each published session is listed on the **Sessions** page for the event it belongs to, on the **Speaker** page for the speaker presenting it, and on the **Session Tracks** page for tracks it belongs to. | Session title, Start date & time, End date & time, Session summary, Detailed description, Session tracks, Duration|
|    Speakers    | Speakers are published automatically when you publish a session they are assigned to.<p>Speakers are listed on the front page for each event where they are speaking, on the **Speakers** page, and on session pages for each session they are running. A speaker profile page shows additional details and a schedule of sessions for that speaker.</p> | Name, Photo, Title, About, [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)], [!INCLUDE[tn-twitter](../includes/tn-twitter.md)], Website |
| Session Tracks |    Publish each track manually by opening the track record and setting the **Publish status** to **Published**. Unpublished tracks won't be shown on the website.<p>Published external tracks are listed on the **Session Tracks** page for the event they belong to. Each session track shows its name and a list of sessions that belong to it (with links).<p>You can only publish external tracks (not internal ones).</p>     |  Name, Audience |
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

### Set registration options

When a visitor to the website decides to register for your event, they proceed as follows:

1. Open the event website and choose an event.
1. Select the **Register** button.
1. The registration page opens. If you've enabled anonymous registration, then the visitor can enter registration details right away, or they can choose to sign in (or to create an account first). If you've disabled anonymous registration, then they must sign in or create an account before they can register anyone.
    - The registration form allows several people to be registered at once.
    - If the visitor chooses to create a registration account, then they must do so using an email address that does not belong to any contact already in your database.
    - One advantage of creating a registration account is that those contacts can sign in again to view their event schedules and to cancel registrations if needed.
    - If you've chosen to enable a CAPTCHA, then the visitor must fill out the CAPTCHA field to continue after entering details about each registrant.
1. If your event requires payment, a payment gateway opens and the visitor must enter their payment details.  The following must be in place to enable the payment gateway:
    - You must create an account with a third-party payment provider and integrate their system into the event website as described in their documentation.
    - The event must have at least one pass.
    - The pass must have a price assigned to it.
    <!-- configure payment gateway page on the event? -->
1. When payment confirmation is received (or right away, if no payment is required), contact records are matched or created (as required) and registration records are created for each new or existing contact that was entered into the registration form.
1. If you've enabled lead generation for the event, then a new lead record will be generated for each registered contact. <!-- matching strategy for existing contacts? -->

Here's how to configure each of the options that's described as optional in this procedure:

1. Go to **Events** > **Event** > **Events** to open the events list.
1. Find and select a listed event (or create a new one) to open the event form.
1. On the **General** tab of the event form, go to the **Key information** section. If you want to generate a lead for each contact that gets registered for this event, set **Create leads for event registrations** to **Yes**. <!-- What happens if this is "no"? -->
1. Scroll down to the **Website** section and make the following settings:
    - **Allow anonymous registrations**: Set this to **No** to require all visitors to create an event-website account before they can register themselves or others for an event. Set to **Yes** to allow visitors to register without creating an event-website account.
    - **Portal payment gateway**: <!-- how do we use this now? -->
    - **Enable CAPTCHA**: Set to **Yes** to include a CAPTCHA field on the registration page. Set to **No** to hide it.
1. Save your settings.

## Open the event website

To find the URL for your sample event website and open it:

1. Open the relevant event record.
1. Make sure the **Publish status** is set to **Published**.
1. Open the **General** tab and find the **Key information** section.
1. The **Event URL** field here shows the address of the website for this event. This URL is provided automatically if you're using the event website that was installed together with [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], but if you're hosting the site somewhere else, you (or another user) must mark the **Custom event URL** check box and specify this value as required. Select the globe button at the edge of this field to open the URL.

<a name="angular"></a>

## Customize the event website and host it anywhere

If you are comfortable developing web applications using the [Angular](https://angular.io/) framework, then a good way to customize the event website for production is to download it from the Microsoft download center, customize it in your preferred development environment, and then overwrite the version on your [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] portal, set it up as a new site on your portal, or host it on your own server. The entire site comprises just two files: a JavaScript file (named `main.js`) and a stylesheet (named `styles.css`).

The first time you install [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], the then-current event website is installed onto your [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] portals solution and is ready to use right out of the box. The website won't be updated or overwritten when you update [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], so you can freely customize the copy that's installed on your portal. However, [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] will continue to develop the event website and improve it with with each new release of [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], so if you want to take advantage of the latest features, you can always download it, compare it with your own customized site, and add any of the new features that you like.

For more information about how to customize the event website, and how to download the latest version, see [Build and host a custom event website](developer/event-management-web-application.md).

## Privacy notice

[!INCLUDE[cc-marketing-cookies](../includes/cc-marketing-cookies.md)]

### See also

[Set up online payment for events](event-payment-gateway.md)  
[Engage customers online with portals](portals.md)  
[Set up an event](set-up-event.md)  
[Go live with publishable entities and track their status](go-live.md)
