---
title: Honor individuals' privacy preferences
description: Learn how to set the email following options for contact, lead, and account records to address your customers' privacy and security concerns. 
author: udaykirang
ms.author: udag
ms.reviewer: shujoshi
ms.topic: how-to
ms.date: 05/25/2023
ms.custom: bap-template
---

# Honor individuals' privacy preferences

Your customers who have privacy or security concerns may ask you not to use email following features when you communicate with them. You can easily turn off these features for specific customers by setting email following options on their contact, lead, or account record. Email following is turned on by default for all records, so you must explicitly turn it off.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | [Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | [Any primary sales role](security-roles-for-sales.md#primary-sales-roles), such as salesperson or sales manager |

## Set privacy options for a contact, account, or lead

1. In Dynamics 365 Sales, open the contact, account, or lead record.

1. Open the **Details** tab.

1. In the **Contact Preferences** section, set **Follow Email** to **Do Not Allow** or **Allow** as needed.

    :::image type="content" source="media/contact-preferences-contact.png" alt-text="Screenshot of a record's contact preferences, with the Follow Email setting highlighted.":::

1. Select **Save**.

When you compose an email that includes one or more recipients that don't allow following, email following features are turned off.

- The message doesn't include [a web beacon](email-engagement.md#understand-email-interaction-history) or invisible, one-pixel GIF.
- Files are attached directly rather than linked, and no links are redirected through Dynamics 365 Sales.
- You can still schedule delivery and may still get template and delivery-time recommendations.

To view the tracking preferences for all the recipients of a message, select **View Recipients' Preferences** above the body of your message. The name and follow preference of each recipient is shown in a separate window. To open a recipient's record, select a name in the list.

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also

[Turn on email engagement](configure-email-engagement.md)
[View message interactions with email engagement](email-engagement.md)
[Create and send an email message](create-send-email-message.md)
