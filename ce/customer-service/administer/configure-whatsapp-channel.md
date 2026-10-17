---
title: Configure a WhatsApp channel through Twilio
description: Learn how to configure the WhatsApp channel through Twilio, including sandbox and production checklists, message templates, the 24-hour session rule, and validation steps.
ms.date: 10/16/2026
ms.topic: how-to
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
ms.collection:
ms.custom: bap-template
---

# Configure a WhatsApp channel through Twilio

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

[!INCLUDE[cc-rebrand-bot-agent](../../includes/cc-rebrand-bot-agent.md)]

The WhatsApp channel lets you integrate WhatsApp through Twilio with the Copilot Service admin center app, so that representatives can engage with customers who prefer to use WhatsApp.

Use this article to:

- Choose between the Twilio sandbox (for testing) and a production Twilio account.
- Collect the Twilio IDs and values that you need before you start.
- Create the WhatsApp channel, connect it to Twilio, and configure message templates.
- Understand the 24-hour session rule and how it affects what representatives can send.
- Validate your setup.

> [!IMPORTANT]
> WhatsApp is releasing usernames and a new customer identifier called the Business-Scoped User ID. When a customer adopts a username, their phone number is no longer sent, and the Business-Scoped User ID becomes the primary identifier. Learn more in [Prepare for WhatsApp usernames and Business-Scoped User IDs](#prepare-for-whatsapp-usernames-and-business-scoped-user-ids).

## Choose sandbox or production

| | Twilio sandbox | Production Twilio account |
|---|---|---|
| **Purpose** | Test the WhatsApp channel before you go live. | Engage with customers on your own WhatsApp business number. |
| **WhatsApp number** | A shared number provided by Twilio. | Your Twilio number connected to your WhatsApp Business Profile. |
| **How customers connect** | Send `join <your sandbox code>` to the sandbox number. Only phones that join the sandbox can exchange messages with it. | Send a WhatsApp message to your business number. |
| **Message templates** | Custom message templates aren't supported. | Create templates in the Twilio Content Template Builder and have them approved by WhatsApp. |
| **Where to enter the Twilio inbound URL** | In the legacy Twilio Console, under **Sandbox settings** > **Sandbox configuration**, in the **When a Message Comes in** box. | The incoming message webhook for your WhatsApp sender in your Twilio account. |

## Information you need from Twilio

Collect the following values before you create the channel. Enter the Twilio values in Copilot Service admin center, and enter the Twilio inbound URL from Copilot Service admin center in Twilio.

| Value | Where to find it | Where to use it | Sandbox | Production |
|---|---|---|---|---|
| Account SID | Twilio Console Dashboard > **Settings** > **General** | **Account details** page, **Account SID** | Required | Required |
| Auth token | Twilio Console Dashboard > **Settings** > **General** | **Account details** page, **Authentication token** | Required | Required |
| WhatsApp number | The sandbox number provided by Twilio, or your Twilio number connected to your WhatsApp Business Profile | **WhatsApp numbers** page, **Number** (prefix with +) | Required | Required |
| Content template SID | Twilio Content Template Builder, after WhatsApp approves the template | **Add message template** dialog, **Content template SID** | Not required | Required to send messages outside the 24-hour window |
| WhatsApp-approved text | The approved template in Twilio | **Add message template** dialog, **WhatsApp approved text** | Not required | Required for each template |
| Twilio inbound URL | Generated in Copilot Service admin center on the **Callback information** page | Twilio: sandbox settings or WhatsApp sender webhook | Required | Required |

## Prerequisites

Ensure that:

- Channels are provisioned in your environment. Learn more in [Provision channels](/dynamics365/contact-center/implement/provision-channels#set-up-channels).
- You have permissions on the secure columns. Learn more in [Configure permissions to access secure columns](../implement/add-users-assign-roles.md#configure-permissions-to-access-secure-columns).
- You have a Twilio account with an appropriate subscription. To test before you go live, you can use the Twilio sandbox.
- For newly created Twilio accounts, you turned off the security setting that blocks sending media files. Learn more in [Extended notice and update on security changes: HTTP Authentication for Voice and Messaging Media enabled by default](https://go.microsoft.com/fwlink/p/?linkid=2248938).

## Sandbox setup checklist

Use this checklist to test the WhatsApp channel with the Twilio sandbox.

> [!NOTE]
> The Twilio sandbox is available only in the legacy Twilio Console. If you use a trial account in the current Twilio Console, Twilio provides the **Try out WhatsApp** experience instead. Learn more in [Test WhatsApp messaging with the Sandbox](https://www.twilio.com/docs/whatsapp/sandbox).

1. Get your **Account SID** and **Auth token** from Twilio. Learn more in [Fetch Twilio account details](#fetch-twilio-account-details).
1. In Copilot Service admin center, create a WhatsApp account. For the WhatsApp number, use the sandbox number provided by Twilio. Learn more in [Create a WhatsApp channel](#create-a-whatsapp-channel).
1. On the **Callback information** page, copy the **Twilio inbound URL**.
1. In the legacy Twilio Console, go to the **Try WhatsApp** page, and activate the sandbox.
1. Under **Sandbox settings** > **Sandbox configuration**, in the **When a Message Comes in** box, paste the Twilio inbound URL, and then save your changes.
1. Create or select a workstream, and set up WhatsApp for the sandbox number. Learn more in [Set up the workstream](#set-up-the-workstream).
1. Configure routing rules and work distribution for the workstream.
1. From a WhatsApp app on each phone that you test with, send `join <your sandbox code>` to the sandbox number.
1. Send a test message, and confirm that a representative receives it. Learn more in [Validate your setup](#validate-your-setup).

Keep the following sandbox limits in mind:

- Only phones that joined your sandbox can exchange messages with it.
- A phone's connection to the sandbox expires three days after it joins. To continue testing, send the join message again.
- The sandbox number can send only one message every three seconds.

## Production setup checklist

Use this checklist to go live with your own WhatsApp business number.

1. Get a Twilio account with an appropriate subscription.
1. Connect your Twilio number to your WhatsApp Business Profile. Learn more in [Connect your Twilio Number to your WhatsApp Business Profile](https://www.twilio.com/docs/sms/whatsapp/tutorial/connect-number-business-profile).
1. If your Twilio account is newly created, turn off the security setting that blocks sending media files.
1. Get your **Account SID** and **Auth token** from Twilio. Learn more in [Fetch Twilio account details](#fetch-twilio-account-details).
1. In Copilot Service admin center, create a WhatsApp account and add your WhatsApp business number. Learn more in [Create a WhatsApp channel](#create-a-whatsapp-channel).
1. On the **Callback information** page, copy the **Twilio inbound URL**, and enter it as the incoming message webhook for your WhatsApp sender in Twilio.
1. Create or select a workstream, and set up WhatsApp for your number. Learn more in [Set up the workstream](#set-up-the-workstream).
1. Configure routing rules and work distribution for the workstream. If you route on phone number patterns, add a fallback rule for conversations that only have a Business-Scoped User ID.
1. In the Twilio Content Template Builder, create your message templates, and submit them for WhatsApp approval. Create a separate template for each language.
1. After WhatsApp approves the templates, add them to the WhatsApp account by using their **Content template SID**. Learn more in [Configure WhatsApp message templates](#configure-whatsapp-message-templates).
1. Validate the channel end to end before you share the number with customers. Learn more in [Validate your setup](#validate-your-setup).

## WhatsApp message types and the 24-hour session rule

WhatsApp supports two types of messages.

| Message type | What it is | Template required? | Media attachments |
|---|---|---|---|
| Session message | An incoming message from a customer, or a representative's reply to an incoming message within 24 hours. | No | Supported |
| Template message | An outbound message that representatives send through Twilio by using a preapproved template. Typically transactional, such as delivery alerts and appointment reminders, sent to customers who opted in to receive messages from your organization. | Yes | Depends on the template |

### How the 24-hour session rule works

- A messaging session starts when a representative receives a message from a customer.
- The session lasts for 24 hours from the most recently received customer message.
- Within the session, representatives can reply freely, without a template.
- After 24 hours pass, representatives can send messages only by using a WhatsApp-approved template, until the customer responds.
- When the customer responds, a new 24-hour session starts.

### Template requirements

- Create templates in the [Twilio Content Template Builder](https://go.microsoft.com/fwlink/?linkid=2306633). The WhatsApp Template Console tab and Templates API are deprecated.
- In Copilot Service admin center, identify each template by its **Content template SID**, not by template name.
- Each content template supports one language. To use the same template in multiple languages, create a separate content template for each language, and get each one approved by WhatsApp.

Learn more in [Create a content template](https://www.twilio.com/docs/content/create-templates-with-the-content-template-builder) and [WhatsApp message templates](https://developers.facebook.com/docs/whatsapp/message-templates/) in the WhatsApp documentation.

## Fetch Twilio account details

1. Sign in to your Twilio account.
1. Go to **Console Dashboard** > **Settings** > **General**.
1. Copy and save the **ACCOUNT SID** and **AUTH TOKEN** values. You need them to create the WhatsApp channel.

## Create a WhatsApp channel

1. In the site map of Copilot Service admin center, under **Customer support**, select **Channels**.
1. For **Messaging accounts**, select **Manage**. The **Accounts and channels** page appears.
1. Select **New account**.
1. On the **Channel details** page, enter a name, and in **Channels**, select **WhatsApp**.
1. On the **Account details** page, enter the following values from your Twilio account:
    - **Account SID**
    - **Authentication token**
1. On the **WhatsApp numbers** page, select **Add**, and then enter the following information:
    - **Name**: A name for the number.
    - **Number**: The WhatsApp phone number, prefixed with the plus (+) symbol.
1. On the **Callback information** page, copy the value in the **Twilio inbound URL** box. Enter this value in Twilio.
1. Select **Done**. The account is added to the list.

## Set up the workstream

1. [Create a workstream](create-workstreams.md) for the WhatsApp channel, or select an existing one.
1. On the workstream page, select **Set up WhatsApp**.
1. On the **WhatsApp number** page, in the **Available WhatsApp numbers** list, select the number that you created.
1. On the **Language** page, select the language.
1. On the **Behaviors** page, configure the following options:
    - [Custom automated messages](configure-automated-message.md)
    - [WhatsApp message templates](#configure-whatsapp-message-templates)
    - [Post-conversation survey](configure-post-conversation-survey.md)
1. On the **User features** page, set **File attachments** to **On**, and then select the checkboxes for the attachments you want to allow. Learn more in [Enable file attachments](enable-file-attachments.md).
    - **Customers can send file attachments**
    - **Representatives can send file attachments**
1. On the **Summary** page, verify the settings, and then select **Finish**.
1. Configure routing rules. Learn more in [Configure work classification](configure-work-classification.md).
1. Configure work distribution. Learn more in [Work distribution settings](create-workstreams.md#configure-work-distribution).
1. Optionally, [add an agent](create-workstreams.md#add-an-agent-to-a-workstream).
1. Based on your business needs, in **Advanced settings**, configure the following options:
    - [Sessions](session-templates.md)
    - [Agent notifications](notification-templates.md#out-of-the-box-notification-templates)
    - [Context variables](manage-context-variables.md#add-context-variables)
    - [Smart assist agents](../develop/smart-assist-bot.md)
    - [Quick replies](create-quick-replies.md)

## Configure WhatsApp message templates

Configure templates so that representatives can contact customers after the 24-hour session ends. You must create your message templates in your Twilio account and have them approved by WhatsApp before you add them in Dynamics 365 Contact Center or Dynamics 365 Customer Service.

1. For the WhatsApp workstream, edit the WhatsApp account.
1. On the **Behaviors** tab, in **WhatsApp message templates**, select **Add**.
1. In the **Add message template** dialog, enter the following information:
    - **Content template SID**: The content template SID from Twilio.
    - **Default language**: The template language.
    - **WhatsApp approved text**: The approved text from the template, copied exactly.
1. Select **Save**.
1. Repeat these steps for each template you need.

## Prepare for WhatsApp usernames and Business-Scoped User IDs

WhatsApp assigns a Business-Scoped User ID to every WhatsApp user that interacts with your organization. For updates on the timeline, go to [WhatsApp Business-Scoped User IDs](https://developers.facebook.com/documentation/business-messaging/whatsapp/business-scoped-user-ids/) in the Meta documentation.

- When a customer adopts a WhatsApp username, their phone number is no longer sent, and the Business-Scoped User ID acts as the primary identifier.
- The Business-Scoped User ID starts with a two-letter country code and a period, followed by up to 128 alphanumeric characters. For example: `US.13491208655302741918`.
- The Contact Book is turned on by default for your WhatsApp business account. Keep it turned on to continue identifying customers by phone number after they adopt a username.
- If you turn off the Contact Book, the phone number is permanently lost as an identifier for the customer.
- When a customer's phone number isn't available, representatives get the customer's first and last name if the conversation is linked to a contact record. Otherwise, the customer appears as **Visitor**.

> [!IMPORTANT]
> If you turn off the Contact Book, you can't recover customers' phone numbers as identifiers.

Take the following actions:

1. **Review your routing rules.** Custom routing rules with conditions on phone number patterns, such as country or region code–based routing, don't match conversations that only have a Business-Scoped User ID. Add a fallback rule so these conversations are routed correctly.
1. **Review integrations and automation.** Update integrations and workflows, such as Power Automate flows, that rely on phone numbers to identify customers so that they also handle the Business-Scoped User ID.
1. **Review context variables in your AI agents.** If your AI agent configuration uses `msdyn_CustomerPhoneNumber`, update your logic to handle conversations where only the Business-Scoped User ID is available.

Learn more in [WhatsApp usernames](https://www.twilio.com/docs/whatsapp/key-concepts#whatsapp-usernames).

## Validate your setup

1. In Copilot Service admin center, confirm that the WhatsApp account appears on the **Accounts and channels** page with the correct number.
1. In Twilio, confirm that the Twilio inbound URL is entered in the sandbox configuration or as the WhatsApp sender's incoming message webhook.
1. Confirm that the workstream has the WhatsApp number selected and that routing rules and work distribution are configured.
1. Sign in as a representative who's assigned to the workstream's queue, and set your presence to available.
1. From the WhatsApp app on a phone, send a message to the WhatsApp number. For the sandbox, send the join message first. If more than three days passed since the phone joined, send the join message again.
1. Confirm that the representative receives the conversation and can reply.
1. If you turned on file attachments, send and receive a test attachment.
1. In production, test a template message to a customer who hasn't messaged in the last 24 hours, and confirm that it's delivered.

## Related information

[Understand and create workstreams](../work-streams-introduction.md)  
[Configure automated messages](configure-automated-message.md)  
[Configure a post-conversation survey](configure-post-conversation-survey.md)  
[Skill-based routing](overview-skill-work-distribution.md)  
[Create message templates](create-message-templates.md)  
[Delete a configured channel](delete-channel.md)  
[Support for live chat and asynchronous channels](card-support-in-channels.md)  
[Configure outbound messaging in Dynamics 365 Contact Center](outbound-messaging.md)  
[Overview of channels](../use/channels.md)  
[Provision channels in Dynamics 365 Contact Center](/dynamics365/contact-center/implement/provision-channels)

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
