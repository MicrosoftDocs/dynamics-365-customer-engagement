---
title: "Associate templates with workstreams | MicrosoftDocs"
description: "Learn how to associate the different templates with workstreams that will be used for incoming conversations in Customer Service."
author: neeranelli
ms.author: nenellim
ms.date: 05/17/2021
ms.topic: article
---

# Associate templates with workstreams

The session, notification, and application tab templates that you create need to be associated with a workstream so that the Omnichannel system uses the corresponding templates for an incoming conversation.

After an agent accepts the conversation request, a session starts for which the session template is used. In the session, certain application tabs are required such as dashboard, knowledge article search, and case pages. These application tabs are configured using the application tab templates and are associated with a session.

## Associate templates with workstreams in Omnichannel admin center

After you create a workstream, you can modify the default templates that are attached to the workstream.

Perform the following steps:

1. Go to the workstream for which you want to modify the template, and expand the **Advanced settings** section.
2. Select **Edit** beside **Sessions**, and on the **Sessions** panel that appears, select a template in the **Default template** list.
3. Select **Save and close**.
4. Select **Edit** beside **Agent notifications**, and on the **Agent notifications** panel that appears, select a template for each of the following types of notifications:
    - Incoming unauthenticated
    - Incoming authenticated
    - Consult
    - Transfer
    - Supervisor assign

5. Select **Save and close**.

## Associate templates with workstreams in Omnichannel Administration

[!INCLUDE[cc-omnichannel-administration-deprecation-note.md](../includes/cc-omnichannel-administration-deprecation-note.md)]

You can attach only generic type of templates to work streams. By default, the out-of-the-box templates are associated based on the channel. However, you can replace the default templates with the ones that you create.

1. Sign in to the Omnichannel Administration app.

2. Select **Work Streams** under **Work Distribution Management**.

3. Select a work stream for which you want to associate the templates.

4. Select the **Templates** tab in the work stream. You can see the **Sessions** and **Notifications** sections.

5. You can accept the default session template or select the search icon in **Look for Session Templates**.

6. In the list of templates that you created, select a template.

7. In the **Notifications** section, for each of the following fields, you can accept the default notification template or select the search icon in **Look for Notification Templates**, and select a template.

    - Incoming authenticated
    - Incoming unauthenticated
    - Consult
    - Transfer
    - Supervisor Assign

9. Select **Save** to save the changes to the work stream.

### See also

[Manage session templates](session-templates.md)  
[Manage application tab templates](application-tab-templates.md)  
[Manage notification templates](notification-templates.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
