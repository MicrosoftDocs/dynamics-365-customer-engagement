---
title: "Personalized calendar content for events and sessions (Dynamics 365 Marketing Developer Guide) | Microsoft Docs"
description: "Learn how to use API calls to generate an .ics file with personalized calendar content for events and sessions."
ms.date: 12/18/2020
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - developer
search.app: 
  - D365CE
  - D365Mktg
---

# Use API calls to generate an .ics file with personalized calendar content for events and sessions

Using API calls, you can create a button for registration confirmation emails that generates a personalized .ics (iCalendar) file containing details about the event or session.

## Accessing the calendar content field

You will enter the code for the API call in the **Calendar content** field, which you can find under the **Additional information** tab in your event. If you do not see the calendar content field, you may have to activate it. To activate the field:

1. Go to the top ribbon, then select the **Settings** gear. Next, select **Advanced Settings**.
1. Select the chevron next to **Settings** in the top ribbon, then select **Customizations**.
1. On the next screen, select **Customize the System**. A new window will pop up containing component customization options.
1. In the left navigation of the new window, go to **Components** > **Entities** > **Event** > **Forms**. The right pane will display **Active Forms** for events. To open the main event form, select **Event** from the list. A new window titled Solution: Default Solution, Form: Event will open.
1. Scroll down to the section titled **Additional information**.