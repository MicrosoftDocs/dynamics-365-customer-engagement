---
title: "Manage application tab templates in Dynamics 365 Channel Integration Framework version 2.0 | MicrosoftDocs"
description: "Learn about managing application tab templates in Dynamics 365 Channel Integration Framework version 2.0"
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 04/05/2021
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Manage application tab templates

## Overview

Application tab templates provide the type of applications you want to open when a session is started. Each application type has a predefined set of parameters associated with it.

The horizontal bar below the model-driven app navigation bar is called the application tab panel. Every customer session has at least one application tab that is not closable; it is called **Anchor Tab**. That is, when a session is started, by default the system opens an application in the application tab panel. In addition, the system might open a few other applications that system opens by default based on the configuration. 

![Application tab panel](../media/app-tab.png "Application tab panel")  

With the application tab templates, you can define the applications that are available for a session and then associate the applications with a session. 

For example, you can create the **Dashboard** application type and associate it with chat and SMS sessions. Now, when an agent accepts a notification from  the chat or SMS channels, a session starts and by default the **Customer summary** page loads.

As an administrator, you can create multiple application tab templates.

## Create an application tab template

To create or manage an application tab template, go to the app profile manager. For more information, see [Create an application tab template](../../../app-profile-manager/application-tab-templates#create-an-application-tab-template.md) in the app profile manager documentation.

## See also

[App profile manager overview](../../../app-profile-manager/overview.md)

[Manage session templates](session-templates-cif.md)

[Manage notification templates](notification-templates-cif.md)

[Use automation dictionary to pass data parameter keys](automation-dictionary-keys-cif.md)

[Associate templates with workstreams](associate-templates-cif.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
