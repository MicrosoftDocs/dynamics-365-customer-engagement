---
title: Use sensitivity labels in emails
description: Classify and protect sensitive information in emails in Dynamics 365 Customer Service and Dynamics 365 Contact Center using sensitivity labels.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection: 
ms.date: 05/01/2026
---

# Use sensitivity labels in emails

Sensitivity labels help you classify and protect business data. When you send or receive emails in Dynamics 365 Customer Service or Dynamics 365 Contact Center, sensitivity labels make sure your communications follow your organization’s security and compliance policies. These labels help protect sensitive information, prevent accidental sharing, and ensure that attachments and replies remain consistent with organizational rules.

## How sensitivity labels work in your emails

You can apply a sensitivity label to an email in the following ways:

- From the **Inbox** in **Copilot Service workspace**, select an email. In the preview pane, select the **Sensitivity label** dropdown in the **Command** bar to choose a label.
- From the email editor, when composing a new email or replying to an existing one. To choose a label, select the sensitivity label dropdown in the command bar.

For an incoming email, the sensitivity label applied by the sender is displayed in the email header. 

When you compose or respond to emails, the following actions apply:

- If you apply labels such as **Do Not Forward** or **Do Not Reply** to an email, the corresponding actions are automatically restricted for email recipients within the organization.
- When you reply to or forward an email that has a sensitivity label, the system automatically applies the same label to your email. You can’t change the current label to a less restrictive label. For example, if the original email is labeled **Confidential**, you can’t change it to **General**.
- Your organization can have a default sensitivity label configured. This label is automatically applied when you start composing a new email in the email editor. 
- Based on your organization's configurations, you can't send or save an email until you apply the required sensitivity label.
- When you add an attachment to an email, the attachment keeps its existing sensitivity label. If there’s a conflict between the attachment’s label and the email’s label, a message appears in the email indicating which label should take priority. Displaying this message helps ensure the entire message is classified consistently.

## Work with encrypted emails

Some sensitivity labels apply encryption to emails, which means only authorized recipients can read them.

When a customer sends an encrypted email, users can see that the email exists in the case timeline. The encrypted message content isn't displayed in the application.

To view the message, users are redirected to Outlook on the web, where the email can be decrypted and opened securely.

> [!NOTE]  
> Encrypted email content isn't decrypted or stored in Dataverse.

Encrypted emails:

- Appear in the timeline
- Must be viewed through Outlook on the web

Encrypted emails aren’t supported for the following features:

- Case summaries
- Case enrichment
- Intent detection
- Other AI-driven workflows

> [!Note]
> Copilot features that rely on email content for AI-generated insights aren't avaialble for encrypted email content unless the content is decrypted outside the application.


### Related information

[Configure sensitivity label support for emails](../administer/configure-email-sensitivity.md)
