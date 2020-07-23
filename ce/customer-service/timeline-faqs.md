---
title: "Timeline FAQs | Microsoft Docs"
description: "Timeline FAQs"
ms.date: 07/24/2020
ms.service:
  - "dynamics-365-customerservice"
ms.topic: article
author: lerobbin
ms.author: lerobbin
manager: shujoshi
---

# Timeline FAQs

Find answers to common questions regarding the timeline experience features and functionality, configurations, and other key concepts.

<!-- ## Missing images in timeline records

<li>I'm not able to see my images in my timeline messages.</li> 
<li>I don't see my images or the option to ‘View full Email content message’ does not display/appear.</li>

![This Email has been blocked due to potentially harmful content. View full Email content message](media\timeline-expand-records-with-images-display-optiones-advanced-1.png "This Email has been blocked due to potentially harmful content. View Full Email content message") -->

## Why I can't assign or delete an activity from the timeline?

- If you use the **HideCustomActions** rule to hide buttons, such as **Assign** and **Delete** in the ribbon command bar definition, then those buttons that are present in the Timeline control will not work. The buttons in the command bar are same as the buttons in the Timeline control; therefore, when a user selects the **Assign** or **Delete** button in the Timeline control, an error message is displayed.

  **You do not have permission to perform this action. Please contact your system administrator.**

  To mitigate the issue, unhide the buttons in the command bar definitions.

## Why my users see different activities and records in their My activities stream in the dashboard?

- **My activities** stream in the dashboard shows the records and activities that are owned by a particular user. For example, user **A** see records and activities that are owned by **A**, and user **B** see records and activities that are owned by **B**.
