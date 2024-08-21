---
title: Use Join a Teams call to enhance your customer conversations
description: Learn how to use the Join a Teams call feature.
ms.date: 04/01/2024
ms.topic: how-to
author: lalexms
ms.author: laalexan
ms.reviewer: shujoshi
ms.custom: bap-template
---

# Invite customers to join you on Teams to enhance your conversations

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]

> [!NOTE]
> Case is applicable to Customer Service only.


Join a Teams call is a feature that can help you have effective conversations with your customers. During an active conversation, you can quickly move your call or chat to Microsoft Teams. On Teams, you can share your screen, connect on video, and remotely connect with your customers to offer more personalized support. 

If you already have Teams, you don't need any other investments to use the Join a Teams call feature. Your customers don’t need a Teams license or previous experience using Teams.

## Prerequisites

Ensure that the following prerequisites are met:

- Your administrator must set up Teams for your account and enable the Join a Teams call feature.
- You must have a Teams license.
- To invite customers to Teams meetings via email, your email configuration must allow outbound mail.

## Use Join a Teams call

You can use the Join a Teams call feature when you’re in an active, ongoing conversation by doing the following steps:

1.	On the productivity pane, select the **Join a Teams call** icon. The option to **Start a Teams meeting** is displayed with the customer’s name.

2.	Next to the customer's name, select either of the following options:
    - Link icon: Generates a Teams meeting link and copies it to your clipboard so you can send it to the customer.
    - Email icon: Autosends an email that contains a Teams meeting link to the email address in the customer record.

    After the link is sent, a confirmation message is displayed in the productivity pane with a prompt for you to join the meeting. The message includes a timestamp of the meeting duration.

3. Select **Join call**. The link opens in a browser window and prompts you to open the Teams app if it's installed or continue your conversation with the customer in the web browser. If you disconnect from the meeting during the scheduled time, you can rejoin using the same link in the productivity pane. When the time ends, you can create a new link and reinvite the customer.

    > [!Note]
    > - When you join the Teams meeting, if you were on a voice call with the customer, you must manually end your call. Joining the Teams meeting with the customer doesn't automatically end your in-progress voice conversation.
    > - If you record the ongoing meeting, the recording is saved in your Microsoft 365 database, not in Microsoft Dataverse.
    
## How to use Join a Teams call with unknown customers

If you're in a conversation with an unknown customer whose record isn't displayed in Customer Service and you want to invite them to a Teams meeting, you must first locate or create their record.

To locate or create a customer record:

1. Do one of the following steps:
   - Search for the customer record: On the active conversation page, go to **Customer** > **Search for a customer** > type the name of the customer, and then select **Enter**. If the customer has a record, it appears and you can select it.
   - Create the customer record: If the customer doesn't have an existing record, you can create it: Go to **Customer** > **New record**, and then enter the customer's details.
     
2. Follow the steps in [Use Join a Teams call](#use-join-a-teams-call) to start the Teams meeting.

### Related information

[Set up Join a Teams call](../administer/set-up-join-a-teams-call.md) <br>
[Use Teams chat in Customer Service](use-teams-chat.md)
