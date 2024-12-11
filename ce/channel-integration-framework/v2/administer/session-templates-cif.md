---
title: Manage session templates in Dynamics 365 Channel Integration Framework 2.0
description: Learn how to manage session templates in Dynamics 365 Channel Integration Framework 2.0.
ms.date: 12/10/2024
ms.topic: how-to
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.custom: bap-template
---

# Manage session templates in Dynamics 365 Channel Integration Framework 2.0

Session templates are a combination of attributes and application tab information that are reusable. You can manage session templates in Customer Service admin center.

When an agent accepts an incoming conversation request, a session is started. The system opens an application that you (an administrator) defined as **Anchor Tab** in the application tab panel. The **Anchor Tab** isn't closable. Simultaneously, the system expands the communication panel for you to exchange messages with the customer. 

Session templates are used to define a session experience like the one described, such as: 

- Which application must be opened as an anchor tab in the application tab panel.
- What additional application tabs must be opened when a session is started.
- What the default mode of the communication panel is when a session is started.

You can use the out-of-the-box session templates, or you can create new ones. As an administrator, you can create multiple session templates in your environment.

- **Chat - Default Session**: This session template is used for any incoming conversation from the Chat channel.
- **SMS - Default Session**: This session template is used for any incoming conversation from the SMS channel.
- **Entity routing - Default Session**: This session template is used for a case and other entity record requests.

A session template is the place where, as an administrator, you need to define the anchor tab and additional application tabs that must open when a session starts.

## Create a session template 

To create or manage a session template, go to the agent experience profile. For more information, see [Create a session template](../../../customer-service/administer/session-templates.md#create-a-session-template) in the agent experience profiles documentation.

> [!NOTE]
> Dynamics 365 Channel Integration Framework must be enabled to load generic session templates with the [createsession](../../../customer-service/develop/reference/methods/createSession.md) API.

##Related information

[App experience management overview](../../../customer-service/administer/overview.md)  
[Manage application tab templates](application-tab-templates-cif.md)  
[Manage notification templates](notification-templates-cif.md)  
[Use automation dictionary to pass data parameter keys](automation-dictionary-keys-cif.md)  


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
