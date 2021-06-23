---
title: "Set and use waitlists for events (Dynamics 365 Marketing) | Microsoft Docs"
description: "Describes how event waitlists work, how to set them up, and how to invite waiting people when capacity becomes available in  Dynamics 365 Marketing."
ms.date: 01/24/2020
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

# Set up and manage an event waitlist

You can assign a maximum capacity to each event or session when needed. When the number of registrations reaches that capacity, the system won't accept any more active registrations, but you can still allow new registrants to add themselves to a waitlist.

Read this topic to learn how to set up a waitlist and how to invite contacts on the list when space becomes available.

> [!IMPORTANT]
> Event-level and session-level waitlisting is only available for on-site events. Hybrid and webinar events don't support waitlisting.

## How the waitlist works

The waitlist holds a list of contacts who submitted a registration through the event website after an event or session was fully booked. The waitlist registers the time and day that each contact registered, so when space becomes available, contacts are either automatically registered or offered an invitation to register in the same order that they joined the waitlist. You can choose whether contacts will be automatically registered when space becomes available for them, or whether they should instead be sent an invitation to register manually.

For events or session already at capacity, visitors to the event website can only join the waitlist, but Dynamics 365 Marketing users from your organization can still add new registrations by opening the [event record](set-up-event.md) and doing one of the following:

- If you are using event-level registration, go to the **Registration and attendance** tab for the event and add new registrations to the **Event registration** list here.
- If you are using session-level registration, go to the **Agenda** tab and open the relevant session. Then go to the **Registration and attendance** tab for the session and add new registrations to the **Session registration** list here.

Registrants added to the **Event registration** or **Session registration** lists in this way will join the event immediately without getting placed on the waitlist. Users can also add registrants directly to the session or event **Waitlist** from here.

When new space becomes available, the waitlist reacts as follows:

1. The oldest existing waitlist record is identified by checking the registration date/time.

1. One of the following occurs, depending on whether the contact is using automatic registration or not:

    - If the identified waitlist record has **Automatically register** set to **Yes**, then an event registration record is generated for the contact and the associated waitlist record is deleted.
    - If the identified waitlist record has **Automatically register** set to **No**, then the waitlist record has its **Invited** field changed from **No** to **Yes** to indicate that space is now available for that contact. You should create a segment that finds these contacts (where (Automatically-register = No) and (Invited = Yes)) and then use a customer journey to send them an email that invites them to visit the event website to accept the slot.

## Enable a waitlist for an event

To enable or disable the waitlist for any event (for both event-level and session-level registration):

1. [Open the Events work area](open-events.md), go to the events list (**Events** > **Event** > **Events**), and then open or create an event.

1. Open the **General** tab and find the **Venue constraints** area.

    ![Enable the waitlist for an event](media/event-waitlist-enable.png "Enable the waitlist for an event")

1. Make the following settings:

    - **Maximum event capacity** (event-level registration only): Enter the maximum number of people who can attend your event. The waitlist will only take effect after this number of contacts have registered. This setting isn't shown if you are using [session-level registration](session-level-registration.md); in this case, set the capacity for each session individually. 
    - **Waitlist this event**: Set to **Yes** to enable the waitlist feature and reveal the **Waitlist** section, which contains the other settings described here.
    - **Number of invitations per slot**: When an extra space becomes available, the system will invite this many contacts from the waitlist, in the same order they joined. Often you will set this to one, but if you are using manual waitlist registration, then you might choose a higher number to increase the chance that at least one contact will follow through with the registration. When a slot opens, the system changes this many waitlist records' **Invited** field from **No** to **Yes**.
    - **Automatically register waitlisted contacts**: Automatic registration is only available for free events, so if you have one or more passes set up for your event, this setting is never shown because passes imply a paid event. When shown, set this to **Yes** to automatically register the next contact in line when space becomes available. When this is set to **Yes**, all waitlist records for this event will therefore have their **Automatically register** fields set to **Yes**. When this is set to **No**, then you can choose whether or not to allow contacts to choose this option for themselves while joining the waitlist.
    - **Contact can choose to be registered automatically**: This option is only shown for free events where you aren't using automatic registration. If you have or more passes set up for your event, this setting is never shown because passes imply a paid event.  When shown, set this to **Yes** to provide a check box on the registration form where contacts can choose to be registered automatically. Choose **No** to use manual registration for all contacts. The **Automatically register** field for each waitlist record will be assigned to match either this option or the choice made by contacts when they join the waitlist.

## View the waitlist

To see who is currently on the waitlist for any event or session:

1. [Open the Events work area](open-events.md), go to the events list (**Events** > **Event** > **Events**), and then open the event.

1. If you are using [session-level registration](session-level-registration.md), then go to the the **Agenda** tab for the event and open the session you want to view.

1. Open the **Registration and attendance** tab for your selected event or session and scroll down to the **Waitlist** section. (Note that the **Waitlist** section is only shown when the waitlist is enabled.)  

    ![View the waitlist for an event](media/event-waitlist-view.png "View the waitlist for an event")

    Here you'll find a list of each contact who is waiting to be invited to this event or session. You can see the following information for each:

    - **Contact**: Shows the name of the contact that registered. This is a lookup value taken from the actual contact record. Select the name to open the contact record. Double-click anywhere else on a row to open the waitlist item itself.
    - **Automatically register**: Shows whether this contact chose to be registered automatically when space becomes available.
    - **Invited**: Shows whether this contact is now eligible to be invited. This value is initially set to **No** but will automatically change to **Yes** when space becomes available, provided this contact is not set to register automatically, _and_ this contact is next in line.
    - **Event**: Shows the name of the event.
    - **Created on**: Shows the date the contact submitted their waitlisted registration.

## Send invites for newly available places

When space becomes available for a waitlisted contact using manual registration, you need to let them know so they can sign up. You can automate the messaging using the standard segmentation and customer journey features of Dynamics 365 Marketing. The way you set up the segment varies slightly depending on whether you are using session-level or event-level registration.

### Make sure the required entities is being synced

The segmentation engine used by Marketing relies on database information being synced from your main customer database to an external service that is optimized to work with big data, analytics, and segmentation. To maximize the performance of your system, you should only sync those specific entities that you want to use in your segmentation. If you are using waitlists, then you must sync the waitlist entity to enable you to find and communicate with waitlisted contacts. If you are using session-level waitlisting, then you should also sync the session entity.

Talk to your system administrator to make sure the waitlisted entity is being synced. If you are the admin, then go to **Settings** > **Advanced settings** > **Marketing settings** > **Marketing data configuration** and make sure the **Waitlist Item (msevtmgt\_waitlistitem)** entity is selected; for session-level waitlisting, also select the **Session (msevtmgt\_session)** entity. More information: [Choose entities to sync with the marketing-insights service](mkt-settings-sync.md)

### Create a segment that finds waitlisted contacts to invite

To create a segment that finds contacts who _are not_ using automatic registration, but who should now be invited to register, do the following:

1. Go to **Marketing** > **Customers** > **Segments** and select **New** on the command bar. The **Segment templates** dialog box opens; select **Cancel** to close it, and then select **Demographic** on the **Let's create your segment** screen.

1. A new demographic segment opens. Check the view setting near the upper corner of the **Definition** tab and make sure it's set to **Tree view**. (You could use either view, but in this procedure we show and describe the tree view, so it's a good idea to use it for now.)

    ![Choose the tree view](media/segment-firmographic-tree-view.png "Choose the tree view")

1. Open the **Add** drop-down list under the **Contact** entity and select **Add related entity**.

    ![Add a related entity](media/segment-add-related-entity.png "Add a related entity")

1. A new related entity is added to your query. Select the field with **Select related entity** in ghost text to open a large drop-down list of available relations. Type "waitlist" in the field to filter the list and then select **Waitlist Item (Waitlist Item -> Contact (Contact))** from the drop-down list. This relation links the parent **Contact** entity to the **Waitlist Item** entity through the **Contact** field of the **Waitlist** entity. The **Contact** field identifies the contact associated with each found waitlist item. More information: [Move between entities with relationships](segments-profile.md#relationships)

    ![Link to waitlist items](media/segment-waitlist-relation.png "Link to waitlist items")

1. Open the **Add** drop-down list under the new related entity and select **Add row** to begin defining the collection of waitlist items you are looking for.

1. A new row is added to your query. Use it to create *one* of the following logical expressions:

    - For event-level registration:    
    **Event | Equals | _&lt;YourEventName&gt;_**  
    Where _&lt;YourEventName&gt;_ is the name of the event.
    - For session-level registration:    
    **Session | Equals | _&lt;YourSessionName&gt;_**  
    Where _&lt;YourSessionName&gt;_ is the name of the session.

    ![Identify the event or session you are looking for](media/segment-waitlist-event.png "Identify the event or session you are looking for")

1. Open the **Add** drop-down list under the previous row and select **Add row**. Use the fields and drop-down lists for the new row to set up the following clause:  
**Automatically register | Equals | No**.

    ![Set automatically register to no](media/segment-waitlist-register-no.png "Set automatically register to no")

1. Add a third row here and set up the following clause:  
**Invited | Equals | Yes**

    ![Set invited to yes](media/segment-waitlist-invited-yes.png "Set invited to yes")

1. Select the field above the query that shows **Enter segment name** as ghost text. Then type a name for your segment.

1. On the command bar, select **Save** to save your segment and then select **Go live**.

### Create a customer journey to send messages or invitations to waitlisted contacts

To deliver messages to your waitlist members, set up a customer journey that uses an appropriate segment (such as the one described in the previous section) followed by an email tile that sends a message that matches that segment. Set the journey to run for the entire registration period of your event.

Each email message should inform the recipient about what has happened (invited to register or some other news item), and include an event element to link to the relevant event website or registration page.

For a journey sending invites to waitlisted contacts who aren't auto-registered, consider adding an event tile as a child of the email-message tile so you can add a trigger that reacts to registration and follows up as needed.

The following example shows a journey that sends email to tell contacts using manual registration that space has become available for them and that they should register to claim it. Note that the message shows a child event tile, and that the invite flow includes a trigger, which is set to react by sending a welcome mail to contacts who register. After a few days, the trigger sends contacts who don't register down the bottom path, where a workflow removes unresponsive contacts from the waitlist so other waiting contacts can be invited (this requires that you create a [custom workflow](/flow/workflow-processes) to handle this).

![A customer journey for processing a waitlist](media/event-waitlist-journey.png "A customer journey for processing a waitlist")

More information: [Use customer journeys to create automated campaigns](customer-journeys-create-automated-campaigns.md), [Email marketing overview](prepare-marketing-emails.md), [Customer journey tiles reference](customer-journey-tiles-reference.md)

### See also

[Event planning and management](event-management.md)  
[Set up session-level registration and waitlisting](session-level-registration.md)  
[Set up an event](set-up-event.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]