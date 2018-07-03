---
title: "Set and use event templates (Dynamics 365 for Marketing) | Microsoft Docs "
description: "Describes how to create an event template and how to use templates when creating a new event in Dynamics 365 for Marketing"
keywords: "events; template"
ms.date: 07/01/2018
ms.service:
  - "dynamics-365-marketing"
ms.custom:
  - "dyn365-marketing"
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: d557e6c9-4fc2-4546-b90a-dd9b0945fdbb
author: kamaybac
ms.author: kamaybac
manager: sakudes
ms.reviewer: renwe
---

<!--Note to author: Reminder to update the publication date.-->

# Create and use event templates

If you often create similar events, then you can save time by setting up one or more event templates. Each template can hold all the same settings as a standard event, including:

- Basic event setup (name, description, type, and so on)
- Event venues
- Event sessions and speakers
- Event passes
- Custom registration fields

When you create an event from a template, the main template record and all its related records are copied to create new, standard records. No link to the template remains, so you can now work with your new event just as you would with an event that you created from scratch.

> [!NOTE]
> Session speakers aren't part of the event, but are linked to from each session. These links are preserved in the template and included in events created based on a template, but the speaker records themselves are not copied or otherwise affected.

## Save an event as a template

You can save any event as a template. To do so, open the event and select **Save as template** on the command bar.

## Create an event from a template

To create a new event based on a template:

1. Go to **Events** > **Event** > **Events** to open the events list.
1. Select **Create from template** on the command bar.
1. The **Create from template** dialog opens. Use it to find the template you want and then select **OK**.
1. Your new event is created. Give it a new name, set its start and end dates, and then select **Save** in the bottom-right corner of the window.

> [!IMPORTANT]
> If your template includes sessions, then each session will keep the schedule it had when the template was saved. You'll need to adjust the schedule of each individual session to ensure that they all fit into the new event dates and times.

## View and edit your event templates

To view the event templates available on your system:

1. Go to **Events** > **Event** > **Events** to open the events list.

2. Open the view selector (located just above the list) and choose **Event templates**.  

    ![The view selector menu](media/events-template-view-selector.png "The view selector menu")

3. The list now shows only event templates. You can open and work with these templates just as you can with standard events. Changes you make to a template won't affect events that were created based on that template.

### See also

[Event planning and management in Dynamics 365](event-management.md)  
[Set up an event](set-up-event.md)
