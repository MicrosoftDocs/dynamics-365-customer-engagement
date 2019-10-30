---
title: "Download and email chat transcripts | MicrosoftDocs"
description: "Learn how to download or email chat transcripts"
keywords: ""
author: lerobbin
ms.author: lerobbin
manager: autumna
applies_to: 
ms.date: 10/25/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: f19a0d99-8d53-492d-9157-9c2e7aa2d638
ms.custom: 
---

# Chat transcripts 

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

Chat for Dynamics 365 Customer Service allows customers to download and email a copy of their chat transcripts. When download and email options are enabled by an administrator, customers can request a copy of their chat transcript at any time during a chat session and are reminded at the end of the conversation to request a transcript. Icons at the bottom of the chat widget allow the customer to initiate an email or download a copy of their chat transcript, which is sent once the chat ends. 

Customers can choose to download and email a copy of their chat transcript conversation directly from the chat window when prompted by either: 

1. Download transcripts  

    Select the download icon at the bottom of the chat screen. 

    > [!div class=mx-imgBorder]
    > ![Download chat transcript](../media/oc-chat-transcript-download.png "Download chat transcript")

2. Email transcripts 

    Select the email icon at the bottom of the chat screen

    a. Enter email address in pop-up window.
    
    b. Select **Send** to receive a copy of chat transcript once the conversation ends.

    > [!div class=mx-imgBorder]
    > ![Email chat transcript](../media/oc-chat-transcript-email.png "Email chat transcript")

    At the end of the chat conversation, the following window appears reminding the customer they can either download or email a copy of their chat transcript to themselves.

    > [!div class=mx-imgBorder]
    > ![Chat Transcript Prompt](../media/oc-chat-transcript-prompt-screen.png "Chat Transcript Prompt")

## Prerequisites

- Administrators should set up mailboxes before enabling. 

    See [Dynamics 365 email setup](https://support.microsoft.com/en-us/help/4020807/dynamics-365-e-mail-setup-configuration-and-dynamics-365-for-mobile-ho) for more information.

## Configuration

Administrators can enable customers to download and/or email chat transcripts by going to the Omnichannel Administration Chat Widget and following these steps:

1. Under **Chat transcripts** section header, at a chat widget level:

    a. Enable download transcript
    
    b. Enable email transcript

   > [!div class=mx-imgBorder]
   > ![Enable Chat Transcript](../media/oc-chat-transcript-enable.png "Enable Chat Transcript Transcript")

   > [!NOTE]  
   > Both download and email transcript settings are disabled by default.

2. When email transcripts are enabled, administrators have a choice to either:

    - Use an email template provided by Chat for Dynamics 365 Customer Service

    - Modify the email template provided by Chat for Dynamics 365 Customer Service
    
    - Create their own email template


   > [!div class=mx-imgBorder]
   > ![Enable email chat transcript](../media/oc-chat-transcript-enable-email.png "Enable email chat transcript")

   > [!NOTE] 
   > Whether admin chooses to use the email template provided or create their own, the "{conversation.transcript}" text determines where the transcript is injected into email.

   > [!div class=mx-imgBorder]
   > ![Customize email chat transcript](../media/oc-chat-transcript-customize-email-transcript.png "Customize email chat transcript")

## See also

[Add a chat widget](add-chat-widget.md)<br>
[Configure a pre-chat survey](configure-pre-chat-survey.md) <br>
[Configure agent display name](agent-display-name.md)<br>
[Configure file attachment capability](configure-file-attachment.md)<br>
[Create quick replies](create-quick-replies.md) <br>
[Create and manage operating hours](create-operating-hours.md) <br>
[Create chat authentication settings](create-chat-auth-settings.md) <br> 
[Embed chat widget in Dynamics 365 Portals](embed-chat-widget-portal.md)









    

