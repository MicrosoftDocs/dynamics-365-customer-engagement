---
title: "Associate templates with workstreams in the Omnichannel Administration app | MicrosoftDocs"
description: "Learn how to associate templates with workstreams in the Omnichannel Administration app"
author: kabala123
ms.author: kabala
manager: shujoshi
ms.date: 01/31/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Associate templates with workstreams

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

After creating the session, notification, and application tab templates, you must associate these with a workstream so that the Omnichannel system uses the corresponding templates for an incoming conversation.

After an agent accepts the conversation request, a session starts for which the session template is used. In the session, certain application tabs are required such as dashboard, knowledge article search, case pages, and so on. These application tabs are configured using the application tab templates and are associated with a session.

## Attach templates in workstreams

1. Sign in to the Omnichannel Administration app.

2. Select **Work Streams** under **Work Distribution Management**.

3. Select a workstream for which you want to associate the templates.

4. Select the **Templates** in the workstream. <br> You can see the **Sessions** and **Notifications** sections. By default, out-of-the-box templates are associated based on the channel. However, you can replace the default templates with the ones you create.

5. Remove the default session template from the **Sessions** section.

6. Select the search icon in the **Look for Session Templates** lookup. The list of templates that you created appears. Select a template.

7. Remove the default notification template from the **Notifications** section.

8. Repeat step 6 to add templates for the following fields.

    - Incoming authenticated
    - Incoming unauthenticated
    - Consult
    - Transfer

9. Select **Save** to save the changes to the workstream.

## See also

- [Manage session templates](session-templates.md)
- [Manage application tab templates](application-tab-templates.md)
- [Manage notification templates](notification-templates.md)
