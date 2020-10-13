---
title: "Send email using the enhanced email experience (Dynamics 365 Sales) | MicrosoftDocs"
description: "Use the enhanced email experience to compose an email without leaving the context of what you are working on."
ms.date: 10/13/2020
ms.service:
  - "dynamics-365-sales"
ms.topic: article
author: shubhadaj
ms.author: shujoshi
manager: annbe
---

# Send email using the enhanced email experience

The enhanced email experience in model-driven apps allows users to compose an email without leaving the record they're working on. With the enhanced email experience, you can:

- Navigate to different pages without losing the email content.
- Minimize the email window to get back to the records you were working on.
- Expand the email editor pop-up window to see more email options.
- Simultaneously open three email compose pop-up windows.
- Search for and apply a predefined template to an email you're composing.
- Insert attachments to email.

> [!NOTE]
> - System administrators must enable the enhanced email experience before you can use it.
> - The enhanced email experience is available only for email activities created from the **Timeline** section of any model-driven app.
> - The enhanced email pop-up window opens only when the height and width of your screen size is at least 400 x 650 pixels or greater. If lower, you will be taken to the standard form instead of the enhanced email experience. 
> - If you are working with the Sales app version 9.0.2006.5005 or later, you'll notice that the name of the existing Enhanced Email form is changed to Enhanced Email (deprecated). This form will be deactivated with the release of November 2020 updates. A new form named Enhanced Email has been introduced with the new capabilities like quick preview or multiple email attachments.

Compose an email using the enhanced experience:

1. In the **Timeline** section of records such as account or contact, select **+** and then under **Activities**, select **Email**.

   A new email pop-up window opens. 

   > [!div class="mx-imgBorder"]
   > ![Enhanced email pop-up window](media/enhanced-email-pop-up.png "Enhanced email pop-up window")

   The **From** and **To** fields are automatically populated based on the user and the account and contact of the original record.

2. Write your email from scratch or select **Insert Template** to search for and apply a template. For more information on inserting an email template, see [Insert an email template](insert-email-template.md).

3. Select **Attach file** if you want to add attachments.

4. Select **Insert signature** to search for and add your signature.

5. When you're done, select **Send**. 

For more information on working with email, see [Use email](https://docs.microsoft.com/dynamics365/customer-service/customer-service-hub-user-guide-email-overview).

### See also

[Set up enhanced email](set-up-enhanced-email.md)<br>
[Insert an email template](insert-email-template.md)
