---
title: "Timeline FAQs | MicrosoftDocs"
description: "Timeline FAQs"
author: lalexms
ms.author: laalexan
manager: shujoshi
ms.date: 07/27/2020
ms.topic: article
ms.service: "dynamics-365-customerservice"
ms.reviewer: lalexms
---

# Timeline FAQs	

Find answers to common questions regarding the timeline experience features and functionality, configurations, and other key concepts.	

## Why can't I assign or delete an activity from the timeline?	

- If you use the **HideCustomActions** rule to hide buttons, such as **Assign** and **Delete** in the ribbon command bar definition, then those buttons that are present in the Timeline control will not work. The buttons in the command bar are the same as the buttons in the Timeline control; therefore, when a user selects the **Assign** or **Delete** button in the Timeline control, the following error message is displayed:

  **You do not have permission to perform this action. Please contact your system administrator.**	

  To mitigate the issue, show the buttons in the command bar definitions.	

## Why do my users see different activities and records in My activities stream or other dashboard timelines?	

- The **My activities** stream in the dashboard shows the records and activities that are owned by a particular user. For example, user "A" sees records and activities that are owned by "A", and user "B" sees records and activities that are owned by "B".	

### See also	

[Overview of timeline](customer-service-hub-user-guide-timeline-overview.md)  	
[Configure timeline](customer-service-hub-user-guide-timeline-admin.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]