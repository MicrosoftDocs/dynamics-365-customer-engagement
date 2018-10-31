---
title: "Set and use waitlists for events (Dynamics 365 for Marketing) | Microsoft Docs "
description: "Describes how event waitlists work, how to set them up, and how to invite waiting people when capacity becomes available in  Dynamics 365 for Marketing"
keywords: "events; waitlist"
ms.date: 07/06/2018
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
applies_to: 
  - Dynamics 365 (online)
  - Dynamics 365 Version 9.x
ms.assetid: 4aa6d5c3-1b29-46b1-bbf3-9bf260853b20
author: kamaybac
ms.author: kamaybac
manager: shellyha
ms.reviewer:
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Set up and manage an event waitlist

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

You can assign a maximum capacity to each event when needed. When the number of registrations reaches that capacity, the system won't accept any more active registrations, but you can still allow new registrants to add themselves to a waitlist.

Read this topic to learn how to set up a waitlist and how to invite contacts on the list when space becomes available.

## How the waitlist works

The waitlist holds a list of contacts who submitted a registration after an event was fully booked. The waitlist registers the time and day that each contact registered, so when space becomes available, contacts are either automatically registered or offered an invitation to register in the same order that they joined the waitlist. You can choose whether contacts will be automatically registered when space becomes available for them, or whether they should instead be sent an invitation to register manually.

When new space becomes available, the waitlist reacts as follows:

1. The oldest existing waitlist record is identified by checking the registration date/time.

1. The identified waitlist record changes its **Invited** field from **No** to **Yes** to indicate that space is now available for that contact. In addition, one of the following occurs, depending on whether the contact is using automatic registration:

    - If the waitlist record has **Automatically register** set to **Yes**, then an event registration record is generated for the contact and the associated waitlist record is hidden. You should create a segment that finds these contacts (where (Automatically-register = Yes) and (Invited = Yes)) and then use a customer journey to send them a notification email that they are now registered.
    - If the waitlist record has **Automatically register** set to **No**, then nothing happens right away. You should create a segment that finds these contacts (where (Automatically-register = No) and (Invited = Yes)) and then use a customer journey to send them an email that invites them to visit the event portal to accept the slot.

## Enable a waitlist for an event

To enable or disable the waitlist for any event:

1. Go to the events list (**Events** > **Event** > **Events**), and then open or create an event.

1. Open the **General** tab and find the **Venue constraints** area.

    ![Enable the waitlist for an event](media/event-waitlist-enable.png "Enable the waitlist for an event")

1. Make the following settings:

    - **Maximum event capacity**: Enter the maximum number of people who can attend your event. The waitlist will only take effect after this number of contacts have registered.
    - **Waitlist this event**: Set to **Yes** to enable the waitlist feature and reveal the **Waitlist** section, which contains the other settings described here.
    - **Number of invitations per slot**: When an extra space becomes available, the system will invite this many contacts from the waitlist, in the same order they joined. Often you will set this to one, but if you are using manual waitlist registration, then you might choose a higher number to increase the chance that at least one contact will follow through with the registration. When a slot opens, the system changes this many waitlist records' **Invited** field from **No** to **Yes**.
    - **Automatically register waitlisted contacts**: Set to **Yes** to automatically register the next contact in line when space becomes available. When this is set to **Yes**, all waitlist records for this event will therefore have their **Automatically register** fields set to **Yes**. When this is set to **No**, then you can choose whether or not to allow contacts to choose this option for themselves while joining the waitlist.
    - **Contact can choose to be registered automatically**: This option is only shown when  you aren't using automatic registration. Choose **Yes** to provide a check box on the registration form where contacts can choose  to be registered automatically. Choose **No** to use manual registration for all contacts. The **Automatically register** field for each waitlist record will be assigned to match either this option or the choice made by contacts when they join the waitlist. -->

## View the waitlist

To see who is currently on the waitlist for any event:

1. Go to the events list (**Events** > **Event** > **Events**), and then open or create an event.

1. Open the **Registration and attendance** tab and scroll down to the **Waitlist** section. (Note that the **Waitlist** section is only shown for events where the waitlist is enabled.)  

    ![View the waitlist for an event](media/event-waitlist-view.png "View the waitlist for an event")

    Here you'll find a list of each contact who is waiting to be invited to this event. You can see the following information for each:

    - **Contact**: Shows the name of the contact that registered. This is a lookup value taken from the actual contact record. Select the name to open the contact record. Double-click anywhere else on a row to open the waitlist item itself.
    - **Automatically register**: Shows whether this contact chose to be registered automatically when space becomes available.
    - **Invited**: Shows whether this contact is now eligible to be invited. This value is initially set to **No** but will automatically change to **Yes** when space becomes available, provided this contact is not set to register automatically, _and_ this contact is next in line.
    - **Event**: Shows the name of the event.
    - **Created on**: Shows the date the contact submitted their waitlisted registration.

## Send notifications or invites for newly available places

When space becomes available for a waitlisted contact, you need to let them know. You can automate this using the standard segmentation and customer journey features of [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]. The way you set up the segment varies slightly depending on whether you are using automatic registration or invite-based manual registration.

### Make sure the waitlist entity is being synced

The segmentation engine used by Marketing relies on database information being synced from your main customer database to an external service that is optimized to work with big data, analytics, and segmentation. To maximize the performance of your system, you should only sync those specific entities that you want to use in your segmentation. If you are using waitlists, then you must sync the waitlist entity to enable you to find and communicate with waitlisted contacts.

Talk to your system administrator to make sure the waitlisted entity is being synced. If you are the admin, then go to **Settings** > **Advanced settings** > **Marketing settings** > **Customer insights sync** and make sure the **Waitlist Item (msevtmgt\_waitlistitem)** entity is marked. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Choose entities to sync with the customer-insights services](marketing-settings.md#dci-sync)

### Create a segment that finds waitlisted contacts to invite

To create a segment that finds contacts who _are not_ using automatic registration, but who should now be invited to register, do the following:

1. Go to the events list ( **Events** > **Event** > **Events** ), and then open your event.

1. Check the address bar in your browser, which should show a URL such as:  

    `https://<MyOrg>.crm.dynamics.com/main.aspx?appid=c8cba597-4754-e811-a859-000d3a1be1a3&pagetype=entityrecord&etn=msevtmgt_event&id=5acc43d5-356e-e811-a960-000d3a1cae35`  

    Find the part of the URL that starts with `&id=`, which is followed by the ID number of your current record. Copy that number (the value only) and use it in your expression.

1. Go to **Marketing** > **Customers** > **Segments** and select **+ New** from the command bar.

1. Fill out the **General** tab with a name and description for your new segment.

1. Open the **Definition** tab. A default contact group is provided, but you don't want a contact group, so select the close button to remove this default group.  

    ![Close the default group](media/event-waitlist-invite-segment1.png "Close the default group")

1. The default group closes, leaving behind a **Select a profile or relationship** drop-down list. Select **Waitlist item** from here. 

    ![Select the waitlist-item entity](media/event-waitlist-invite-segment2.png "Select the waitlist-item entity")

1. Complete the row to create the logical expression:  
**Waitlist Item | Automatically register | is | False**.  

    ![Complete the waitlist-item clause](media/event-waitlist-invite-segment3.png "Complete the waitlist-item clause")

1. Select **+ And** to add a second clause using an AND operator. Use it to create the logical expression:  
**Waitlist Item | Invited | is | True**

1. Select **+ And** to add a third clause. Use it to create the logical expression:  
**Waitlist Item | Event msevtmgt\_event | is | &lt;YourEventID&gt;**

    Where _&lt;YourEventID&gt;_ is the event ID you found at the start of this procedure.

1. Select **+ And** to add a fourth clause. Use it to create the logical expression:  
**msevtmgt\_waitlistitem\_contact\_msevtmgt\_contact\_&lt;YourOrg&gt; | All&ast;**

    This last clause links from the waitlist entity to the contact entity. All segments must resolve to a contact record, so this clause links the found waitlist records to their related contacts and returns that list of contacts.

1. Your final segment should resemble the following screenshot. Select **Save** at the bottom-right corner of the window to save your settings.  

    ![The final invite segment query](media/event-waitlist-invite-segment4.png "The final invite segment query")

1. Select **Go Live** from the command bar to activate the segment.

### Create a segment that finds waitlisted contacts who have been registered automatically

To create a segment that finds contacts who _have already_ been registered automatically, but need to be informed about it, create a segment almost like the one described in the previous section, but this time look for waitlist records where **Automatically register** is **true**. The full set of clauses is:

**Waitlist Item | Automatically register | is | True**  
**AND Waitlist Item | Invited | is | True**  
**AND Waitlist Item | Event msevtmgt\_event | is | &lt;YourEventID&gt;**  
**AND msevtmgt\_waitlistitem\_contact\_msevtmgt\_contact\_&lt;YourOrg&gt; | All&ast;**

![The final auto-registered segment query](media/event-waitlist-auto-segment.png "The final auto-registered segment query")

### Create a customer journey to send invitations or notifications to waitlisted contacts

To deliver messages to your waitlist members, set up a customer journey that uses an appropriate segment (such as those described in the previous sections) followed by an email tile that sends a message that matches that segment. Set the journey to run for the entire registration period of your event. That way, each time a waitlist record gets moved to invited = true, the related contact will be added to the segment and will get processed by the journey.

Each email message should inform the recipient about what has happened (auto registered, or invited to register), and include an event element to link to the relevant event portal. The event link is especially important for invites where auto-register is not enabled, but even auto-registered attendees may still need to purchase a ticket on the portal.

For a journey sending invites to waitlist contacts who aren't auto-registered, consider adding an event tile as a child of the email-message tile so you can add a trigger that reacts to registration and follows up as needed.

The following example shows a journey that has two parallel paths, one for auto-registered contacts and one for invited (manual-register) contacts. Note that both email messages show a child event tile, and that the invite flow includes a trigger, which is set to react by sending a welcome mail to contacts who register. After a few days, the trigger sends contacts who don't register down the bottom path, where a workflow removes unresponsive contacts from the waitlist so other waiting contacts can be invited (this requires that you create a [custom workflow](../customize/workflow-processes.md) to handle this).

![A customer journey for processing a waitlist](media/event-waitlist-journey.png "A customer journey for processing a waitlist")

[!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Use customer journeys to create automated campaigns](customer-journeys-create-automated-campaigns.md), [Prepare marketing email messages](prepare-marketing-emails.md), [Customer journey tiles reference](customer-journey-tiles-reference.md)

### See also

[Event planning and management in Dynamics 365](event-management.md)  
[Set up an event](set-up-event.md)
