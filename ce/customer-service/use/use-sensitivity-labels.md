---
title: Use sensitivity labels in emails
description: Classify and protect sensitive information in emails in Dynamics 365 Customer Service and Dynamics 365 Contact Center using sensitivity labels.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection: 
ms.date: 09/21/2025
---

# Use sensitivity labels in emails

Sensitivity labels help you classify and protect business data. When you send or receive emails in Dynamics 365 Customer Service or Dynamics 365 Contact Center, sensitivity labels make sure your communications follow your organization’s security and compliance policies. These labels help protect sensitive information, prevent accidental sharing, and ensure that attachments and replies remain consistent with organizational rules.

## How sensitivity labels work in your emails

You can apply a sensitivity label to an email as follows:

- From the **Inbox** in Copilot Service workspace. Select an email. In the preview pane, select the sensitivity label dropdown in the command bar to choose a label.
- From the email editor, when composing a new email or replying to an existing one. Select the sensitivity label dropdown in the command bar to choose a label.

For an incoming email, the sensitivity label applied by the sender is displayed in the email header. 

When you compose or respond to emails, the following actions apply:

- If you apply labels such as **Do Not Forward** or **Do Not Reply** to an email, the corresponding actions are automatically restricted for email recipients within the organization.
- When you reply to or forward an email that has a sensitivity label, the system automatically applies the same label to your email. You can’t change the current label to a less restrictive label. For example, if the original email is labeled **Confidential**, you can’t change it to **General**.
- Your organization can have a default sensitivity label configured. This label is automatically applied when you start composing a new email in the email editor. 
- Based on your organization's configurations, you can't send or save an email until you applied the required sensitivity label.
- When you add an attachment to an email, the attachment keeps its existing sensitivity label. If there’s a conflict between the attachment’s label and the email’s label, the application displays a message the email about which label should take priority. This ensures the entire message is classified consistently.

## Work with encrypted emails

Some sensitivity labels apply encryption to emails, which means only authorized recipients can read them.

- If you receive an encrypted email in Customer Service, you are able to view it in the app, or you can be redirected to Outlook on the web (OWA) if additional actions are required.  
- When you send an encrypted email, the label ensures only the intended recipients can open it. Recipients outside your organization can have restricted access depending on policy.  

