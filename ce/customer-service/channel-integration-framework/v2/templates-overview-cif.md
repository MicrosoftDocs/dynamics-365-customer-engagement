---
title: "Overview of templates in the Dynamics 365 Channel Integration Framework version 2.0 | Microsoft Docs"
description: "Learn about templates in Dynamics 365 Channel Integration Framework version 2.0"
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 12/31/2019
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# Overview of templates

When you (an agent) get an incoming conversation request, Dynamics 365 Channel Integration Framework version 2.0 allows channel providers to search and open records on an incoming call. However, your organization might have different requirements and want to use different custom entities and correlate to a conversation.

Also, the **Omnichannel for Customer Service app** allows you to open third-party web applications in the application tabs. Your organization might have different line-of-business applications, and while starting a session, you might want to load the line-of-business applications for a specific conversation type.

To choose the applications you want to open for every session, according to your organization requirements, session templates are introduced:

- [Session templates](session-templates-cif.md)
- [Application tab templates](application-tab-templates-cif.md)
- [Notification templates](notification-templates-cif.md)

> [!WARNING]
> It is recommended that you don’t edit the out-of-the-box sample templates in the package because it affects the functionality.

## See also

[Associate templates with scenarios](associate-templates-cif.md)
