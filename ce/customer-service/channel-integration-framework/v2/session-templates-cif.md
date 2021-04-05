---
title: "Manage session templates in Dynamics 365 Channel Integration Framework version 2.0 | MicrosoftDocs"
description: "Learn about managing session templates in Dynamics 365 Channel Integration Framework version 2.0."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 04/05/2021
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Manage session templates

## Overview

Session templates are a combination of attributes and application tab information that are reusable. You can manage session templates in the app profile manager.

When an agent accepts an incoming conversation request, a session is started. The system opens an application that you (an administrator) defined as **Anchor Tab** in the application tab panel. The **Anchor Tab** is not closable. Simultaneously, the system expands the communication panel for you to exchange messages with the customer. 

Session templates are used to define a session experience like the one just described, such as: 

- Which application must be opened as an anchor tab in the application tab panel.
- What additional application tabs must be opened when a session is started.
- What the default mode of the communication panel will be when a session is started.

You can use the out-of-the-box session templates, or you can create new ones. As an administrator, you can create multiple session templates in your environment.

- **Chat - Default Session**: This session template is used for any incoming conversation from the Chat channel.
- **SMS - Default Session**: This session template is used for any incoming conversation from the SMS channel.
- **Entity routing - Default Session**: This session template is used for a case and other entity record requests.

A session template is the place where, as an administrator, you need to define the anchor tab and additional application tabs that must open when a session starts.

## Create a session template 

To create or manage a session template, go to the app profile manager. For more information, see [Manage session templates](../../app-profile-manager/session-templates.md) in the app profile manager documentation.

## See also

[App profile manager overview](../app-profile-manager/overview.md)

[Manage application tab templates](application-tab-templates-cif.md)

[Manage notification templates](notification-templates-cif.md)

[Use automation dictionary to pass data parameter keys](automation-dictionary-keys-cif.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
