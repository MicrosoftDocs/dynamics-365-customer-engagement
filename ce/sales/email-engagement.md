---
title: Use email engagement to view message interactions
description: Learn how to use email engagement in Dynamics 365 Sales to track your customers' interactions with your messages, such as selected links, opened attachments, and replies, and to get alerts to help you remember to follow up.
ms.date: 02/27/2023
ms.topic: conceptual
author: udaykirang
ms.author: udag
---

# Use email engagement to view message interactions

Email engagement in Dynamics 365 Sales tracks your customers' interactions with your messages. You can learn whether they selected a link, opened an attachment, or sent a reply. You can also get alerts to help you remember to follow up with your customers.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | [Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | [Any primary sales role](security-roles-for-sales.md#primary-sales-roles) |

## Prerequisites

- Your administrator has turned on email engagement.
- Your administrator has turned on the assistant. Email engagement uses the assistant to deliver alerts and other messages.

## How email engagement helps you to be a more effective seller

With email engagement, you can:

- Find out when a customer opened your message, selected a link, opened an attachment, or sent a reply. (When the customer's email client scans your email for security reasons, it can artificially inflate the count for email open and link selections.)
- Get an immediate alert when a customer opens your message for the first time.
- Schedule the most effective delivery time based on the recipient's time zone.
- Choose the most effective message template based on your organization's email interaction history.
- Set an alert to remind you when it's time to follow up on an email.
- Review the full interaction history of a single message or view key performance indicators (KPIs) for all your messages.

Some features of email engagement might be visible even when the feature is turned off. These features still appear but are empty:

- The **Attachments** table, which is shown when you compose an email message or email template, always includes the **Followed** column.
- The **Followed Email** table always shows the **Opens**, **Last Opened Time**, **Attachment Views**, **Link Clicks**, and **Replies** columns.
- The **Email Template** table always shows the **Reply Rate**, **Open Rate**, **Recommended**, and **Email Count** columns.
- The out-of-the-box versions of the account, contact, and lead forms all include the **Follow Email** field.

## View email engagement history

The status, interaction statistics, and key performance indicators (KPIs) for your followed email messages are available in many parts of Dynamics 365 Sales for each record where they're relevant.

### Email history in the Activities column <a name="COLAhistory"></a>

After you save or send a message, it appears in the **Activities** list for its **Regarding** record, which is usually the record you were viewing when you composed it. In some cases, it may be a related record.

:::image type="content" source="media/email-messages-activities-list.png" alt-text="Screenshot of email messages in the Activities list.":::<!-- EDITOR'S NOTE: Please highlight the screenshot IAW the new [screenshot guidelines](/bacx/screenshots-for-bap?branch=main). -->

Followed messages show their current interaction status on their tile in the **Activities** list. Use the buttons in the upper-right corner of an email tile to expand its content and interaction history right in the list or to open the full message page.

### Email KPIs in the emails list

You can view the number of opens, attachment views, link clicks, and replies for followed messages in the list of emails your sales organization has sent.

1. Go to **Sales** > **Activities**.

1. In the list at the top of the page, select **Email** > **All Followed Emails**.

:::image type="content" source="media/email-kpi-email-list.png" alt-text="Screenshot of email KPIs in an email list."":::<!-- EDITOR'S NOTE: Please highlight the screenshot IAW the new [screenshot guidelines](/bacx/screenshots-for-bap?branch=main). -->

### Message details <a name="MessageHistory"></a>

To open a read-only view of the details of a delivered message, select its subject in an **Activities** or **Emails** list. The details you can view include the message interaction history and KPIs.

:::image type="content" source="media/email-message-recipient-activity.png" alt-text="Screenshot of email message details.":::

The KPIs at the top of the timeline show the total opens, attachment views, clicks, and replies that have been recorded for the message. The timeline shows a symbol for each interaction event, with the newest at the top, and a few details about each event.

### Template results and recommendations in the template list <a name="TemplateList"></a>

You can view the performance of your email templates, including the reply rate, open rate, the number of times they've been used, and whether they're recommended or not.

Go to **Settings** > **Business** > **Templates**, and then select **Email Templates**.

:::image type="content" source="media/email-template-list.png" alt-text="Screenshot  of KPIs in the email templates list.":::

## Understand email interaction history

Usually when you send an email, you don't know if it was opened or read unless the recipient chooses to write back to you. That's because email was created to simulate traditional mail and wasn't designed with response tracking in mind. Dynamics 365 Sales uses special techniques to work around this limitation and provide the message-following features in email engagement.

- **Find out when your message was opened**: When you send a followed email message from Dynamics 365 Sales, the system generates a uniquely named, transparent, one-pixel GIF and adds it to the message as a linked image. This invisible GIF, along with any other images you add to the message, are stored in Dynamics 365. They're fetched when the recipient opens the message and chooses to download its images. When a unique GIF is requested, Dynamics 365 Sales registers that the associated message was opened.

    We recommend that you always include images in your messages, like a company logo or an arresting illustration, because it motivates recipients to download them. You won't know they've opened the message if images aren't loaded.

- **Find out when each link was clicked**: When you send a followed email message from Dynamics 365 Sales, the system replaces each of its hyperlinks with a unique redirect link that points to Dynamics 365. Each redirect link includes an ID that uniquely identifies both the message that contains it and the URL of the original link target. When Dynamics 365 receives the link request, it logs the click and then redirects the click to its original address so that the recipient gets the correct information with little or no delay.

- **Find out when each attachment was opened**: When you add a followed attachment to a message, the file isn't attached directly as with a standard email. Instead, it's stored on the OneDrive for Business share that's used by Dynamics 365 and added to the message as a link. As with followed links, when a recipient clicks to download the attachment, Dynamics 365 notes the click and the time. Your recipients may even prefer to receive attachments as links rather than files because your messages take up much less room in their inbox.

    You can mix followed and unfollowed attachments in a single email. That can be important if you're sending sensitive files that you don't want to save in OneDrive for Business.

Actions that are performed on email are stored in Microsoft Azure Storage. Azure Storage is unique for each organization. If an organization is restored to another organization, the history of the email actions in the previous organization isn't carried over to the restored organization.

> [!IMPORTANT]
> You should treat all email interaction data as approximations. The system can only register an email-open event if the recipient also downloads the message's images, including the invisible GIF. The actual number of opens could be larger than the number recorded in Dynamics 365 Sales. Similarly, if images are cached, which is typical for web-based email clients, then subsequent opens may not be reported to Sales.

### See also

[Turn on email engagement](configure-email-engagement.md)  
[Create and send an email message](create-send-email-message.md)
[Configure privacy preferences](configure-individuals-privacy-preferences.md)
