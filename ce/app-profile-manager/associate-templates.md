---
title: "Associate templates with work streams in the Omnichannel Administration app | MicrosoftDocs"
description: "Learn how to associate templates with work streams in the Omnichannel Administration app"
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 10/12/2020
ms.service: "dynamics-365-customerservice"
ms.topic: article 
---

# Associate templates with work streams

The session, notification, and application tab templates that you create need to be associated with a work stream so that the Omnichannel system uses the corresponding templates for an incoming conversation.

After an agent accepts the conversation request, a session starts for which the session template is used. In the session, certain application tabs are required such as dashboard, knowledge article search, and case pages. These application tabs are configured using the application tab templates and are associated with a session.

## Attach templates in work streams

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