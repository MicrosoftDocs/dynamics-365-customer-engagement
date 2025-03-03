---
title: Download and email chat transcripts
description: This topic provides information on how to download or email chat transcripts in Dynamics 365 Customer Service.
ms.topic: how-to
ms.date: 02/05/2025
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
---

# Configure download and email of chat transcripts

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]

Chat for Dynamics 365 Contact Center allows customers to download and email a copy of their chat transcripts. When your administrator enables download and email options, customers can download or request an email of their chat transcript at any time during a chat session. At the end of the conversation, customers can request a transcript. If the customer requests an email of the chat transcript, the email is sent at the end of the conversation.

**Prerequisite**: Administrators should set up mailboxes before enabling this feature, and must select the **Allow other Dynamics 365 users to send email on your behalf** checkbox for it to work. Learn more in [Dynamics 365 Email Setup](https://support.microsoft.com/help/4020807/dynamics-365-e-mail-setup-configuration-and-dynamics-365-for-mobile-ho) and [Dynamics 365 Email tab options](/dynamics365/customerengagement/on-premises/basics/set-personal-options#email-tab-options).

## Download and email chat transcripts

To configure options to download and email chat transcripts for both customers and customer service representatives:

1. In Customer Service admin center or Contact Center admin center, select the workstream of the chat widget in which you want to configure the settings.

2. Select **Edit** for the chat channel that you want to update, and then select the **User features** tab.

3. For **Conversation transcripts**, set the toggle to **On**, and then select the following check boxes:
   - Allow download of transcripts
   - Allow email of transcripts

4. Select a template in **Email template**.

5. Select a mailbox in **From mailbox**.

6. Select **Save and close**.

## Customer experience

Customers can choose to download and email a copy of their chat transcript conversation from the chat window: 

- **Download the chat transcript:** Select the download icon at the bottom of the chat screen. 

    > [!div class=mx-imgBorder]
    > ![Download chat transcript.](../media/oc-chat-transcript-download.png "Download chat transcript")

- **Email the chat transcript:** Select the email icon at the bottom of the chat screen.

    1. Enter email address in pop-up window.
        
    2. Select **Send** to receive a copy of the chat transcript once the conversation ends.

     > [!div class=mx-imgBorder]
     > ![Email chat transcript.](../media/oc-chat-transcript-email.png "Email chat transcript")

    At the end of the chat conversation, the following window appears, reminding the customer they can either download or email a copy of their chat transcript to keep for themselves.

    > [!div class=mx-imgBorder]
    > ![Chat transcript prompt.](../media/oc-chat-transcript-prompt-screen.png "Chat transcript prompt")

> [!NOTE]
> If files of MIME type '.txt' are blocked in the Dataverse instance, you won't be able to save conversation transcripts.

### Related information

[Add a chat widget](add-chat-widget.md)<br>
[Configure a pre-chat survey](configure-pre-chat-survey.md) <br>
[Configure agent display name](agent-display-name.md)<br>
[Configure file attachment capability](configure-file-attachment.md)<br>
[Create quick replies](create-quick-replies.md) <br>
[Create and manage operating hours](create-operating-hours.md) <br>
[Create chat authentication settings](create-chat-auth-settings.md) <br> 
[Embed chat widget in Power Apps portals](embed-chat-widget-portal.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
