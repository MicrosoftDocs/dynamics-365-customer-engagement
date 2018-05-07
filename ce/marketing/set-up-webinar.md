---
title: "Set up an online event or simulcast (Dynamics 365 for Marketing) | Microsoft Docs "
description: "How to set up a webinar to create an online-only event or to simulcast a live event in Dynamics 365 for Marketing"
keywords: "events; event management; webinar"
ms.date: 04/01/2018
ms.service: dynamics-365-marketing
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 2fe1cc7a-ba3a-43bb-b947-3a672834e650
author: kamaybac
ms.author: kamaybac
manager: sakudes
ms.reviewer: renwe
topic-status: Drafting
ms.custom:
  - dyn365-marketing
---

# Set up a webinar

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

A *webinar* (short for "web seminar") is a live event that one or more people can watch simultaneously online. You can set up any session or event to function as a webinar. An event or session can be webinar-only (where live attendance is not possible) or a simulcast for attendees who can't make it to the venue to attend a live event. You can also set an event or session as onsite only, which will disable webinars for that item and hide its webinar settings.

## Webinar prerequisites

Before you can set up a webinar, the following must be in place:

- Your organization must have an account with a webinar provider, and you must have sign-in credentials to access your organization's account with them.
- [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] must be configured to use your organization's webinar account. Your [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] administrator might already have done this for you. If you are the admin, see [Event management settings](events-settings.md) for instructions.

During the webinar itself, you must set up a camera, microphone, projector, and other equipment as required to capture and broadcast the session through your webinar provider. Check with your webinar provider for information about how to do this, and always test the system end-to-end before your webinar begins.

## Configure an event or session for broadcast as a webinar

To configure an event or session for broadcast as a webinar:

1. Sign in to [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)], and open the event or session that you want to set up as a webinar.

1. On the **Event** or **Session** page, find the **Format** setting (on the **General** tab) and set it to **Webinar** (for webinar-only) or **Hybrid** (to simulcast a live session).

1. Open the event's **Organize** tab, which now includes a **Webinar Set-up** section. Make the following settings:

    - **Webinar Configuration**: Identify the webinar-configuration record you will use for this event or session. This configuration record establishes the webinar provider and account that you'll use to run the webinar. Select the magnifying glass icon for this field, and then select a configuration. Your admin must create a configuration entry for each webinar provider that your organization uses; typically, you'll just have one. Talk to your admin if you're not sure which to choose (if you are the admin, see [Event management settings](events-settings.md) for more information).
    - **Webinar Type**: Choose the webinar type.
    - **Language**: Choose the language the webinar will be presented in.
    - **Producer**: Choose the event team member that is responsible for managing the webinar during the event here. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Set up your event team](set-up-event.md#set-up-your-event-team)

1. Allow the event or session to save itself (which usually occurs every few seconds), or select **Save** in the lower-right corner of the window to save it immediately. As soon as you've saved an event with a valid webinar configuration, [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] will create the webinar in your webinar provider's system, which will return the following values:

    - **Webinar URL**: A link to the webinar at the webinar provider. [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] uses this link to synchronize registrations and metrics between the two systems.
    - **Presentation Manager URL**: A link that the presenter can use to control his or her presentation.

Attendees who register for the webinar by using a valid email address will receive an email from the webinar provider that confirms the registration and provides a link for accessing the webinar.

### See also

[Event management settings](events-settings.md)
