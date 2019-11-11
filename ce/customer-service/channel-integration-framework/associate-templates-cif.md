---
title: "Associate templates with scenarios in the Dynamics 365 Channel Integration Framework app | MicrosoftDocs"
description: "Learn about associating templates with scenarios in the Dynamics 365 Channel Integration Framework app"
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 10/25/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 29FDEE50-8CED-4E2C-899A-5E8512251FC7
ms.custom: 
---

# Preview: Associate templates with scenarios

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided “as-is,” “with all faults,” “as available,” and without warranty.​
> - This preview feature does not come with technical support and Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions.  If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.​
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk.  All previews are subject to separate [Terms and Conditions](../../legal/dynamics-insider-agreement.md).

After creating the session, notification, and application tab templates, you must associate these with your scenarios so that the notification template is used for an incoming conversation. After an agent accepts the conversation, a session starts for which the session template is used. In the session, certain application tabs are required such as Knowledge article search and Case page. These application tabs are configured using the application tab templates and are associated with a session.

To associate the templates in your scenarios, you must use the `templateName` parameter in your code. For more information on notification, session, and application tab management APIs, see [JavaScript API Reference](reference/microsoft-ciframework.md).


## See also

- [Manage session templates](session-templates-cif.md)
- [Manage application tab templates](application-tab-templates-cif.md)
- [Manage notification templates](notification-templates-cif.md)
- [Use automation dictionary to pass data parameter keys](automation-dictionary-keys-cif.md)
