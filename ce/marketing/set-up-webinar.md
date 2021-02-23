---
title: "Set up an online event or simulcast (Dynamics 365 Marketing) | Microsoft Docs"
description: "How to set up a webinar to create an online-only event or to simulcast a live event in Dynamics 365 Marketing."
ms.date: 04/01/2018
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

# Set up a webinar

A *webinar* (short for "web seminar") is a live event that one or more people can watch simultaneously online. You can set up any session or event to function as a webinar. An event or session can be webinar-only (where live attendance is not possible) or a simulcast for attendees who can't make it to the venue to attend a live event. You can also set an event or session as onsite only, which will disable webinars for that item and hide its webinar settings.

## Webinar prerequisites

Before you can set up a webinar, the following must be in place:

- Your organization must have an account with a webinar provider, and you must have sign-in credentials to access your organization's account with them.
- Dynamics 365 Marketing must be configured to use your organization's webinar account. Your administrator might already have done this for you. If you are the admin, see [Event management settings](events-settings.md) for instructions.

During the webinar itself, you must set up a camera, microphone, projector, and other equipment as required to capture and broadcast the session through your webinar provider. Check with your webinar provider for information about how to do this, and always test the system end-to-end before your webinar begins.

## Configure an event or session for broadcast as a webinar

To configure an event or session for broadcast as a webinar:

1. Sign in to Dynamics 365 Marketing, and [open the event or session](set-up-event.md) that you want to set up as a webinar.

2. On the **Event** or **Session** page, find the **Format** setting (on the **General** tab) and set it to **Webinar** (for webinar-only) or **Hybrid** (to simulcast a live session).

3. The **General** tab should now include a **Webinar Set-up** section. Make the following settings:

   - **Webinar Configuration**: Identify the webinar-configuration record you will use for this event or session. This configuration record establishes the webinar provider and account that you'll use to run the webinar. Select the magnifying glass icon for this field, and then select a configuration. Your admin must create a configuration entry for each webinar provider that your organization uses; typically, you'll just have one. Talk to your admin if you're not sure which to choose (if you are the admin, see [Event management settings](events-settings.md) for more information).
   - **Webinar Type**: Choose the webinar type. This setting can affect the collection of features available to presenters and attendees of the webinar. The available options are established by your webinar provider, so please contact your provider if you need more information about which type to choose.
   - **Language**: Choose the language the webinar will be presented in.
   - **Producer**: Choose the event team member that is responsible for managing the webinar during the event here. More information: [Set up your event team](set-up-event.md#set-up-your-event-team)

4. Allow the event or session to save itself (which usually occurs every few seconds), or select **Save** in the lower-right corner of the window to save it immediately. As soon as you've saved an event with a valid webinar configuration, Dynamics 365 Marketing will create the webinar in your webinar provider's system, which will return the following values:

   - **Webinar URL**: A link to the webinar at the webinar provider. Dynamics 365 Marketing uses this link to synchronize registrations and metrics between the two systems.
   - **Presentation Manager URL**: A link that the presenter can use to control his or her presentation.

## Send the webinar URL to attendees

Attendees can join the webinar by selecting a link sent to them in email. Some webinar providers may send an invitation message including this link for you, while others may require that you send out the links (or you may prefer to send the links yourself).

If you want to send out the links yourself then one way to do so is to set up a [customer journey](customer-journeys-create-automated-campaigns.md) with an event tile followed by a trigger tile that reacts to event registrations and then an email tile that sends a message with the URL to each contact that registers.

### See also

[Event management settings](events-settings.md)  
[Early access: Set up a Microsoft Teams webinar](teams-webinar.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]