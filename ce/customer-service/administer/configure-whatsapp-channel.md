---
title: Configure a WhatsApp channel through Twilio
description: Use this article to learn how to configure the WhatsApp channel through Twilio.
ms.date: 02/27/2025
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.collection:
ms.custom: bap-template
---

# Configure a WhatsApp channel through Twilio

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

[!INCLUDE[cc-rebrand-bot-agent](../../includes/cc-rebrand-bot-agent.md)]


The WhatsApp channel feature lets you integrate WhatsApp through Twilio with either the Customer Service admin center or Contact Center admin center application to engage with customers who prefer to use the WhatsApp channel.

The success of social media customer service, like all other customer service, depends on the quality of care provided. Communications from customer service representatives (service representatives or representatives) should be timely, accurate, sensitive, brief, and friendly, which ultimately improves the customer satisfaction and brand loyalty.

## Prerequisites

- Make sure channels are provisioned in your environment. Learn more in [Provision channels](/dynamics365/contact-center/implement/provision-channels#set-up-channels).
  > For newly created Twilio accounts, you must disable a security setting that blocks the ability to send media files. Learn more in [Extended notice and update on security changes: HTTP Authentication for Voice and Messaging Media enabled by default](https://go.microsoft.com/fwlink/p/?linkid=2248938).

- Obtain a Twilio account with an appropriate subscription or a Twilio sandbox account. Learn more about configuring a Twilio sandbox account in [Integrate a Twilio sandbox account](#integrate-omnichannel-application-with-a-twilio-sandbox-account).

- Connect Twilio Number to your WhatsApp Business Profile. Learn more in [Connect your Twilio Number to your WhatsApp Business Profile](https://www.twilio.com/docs/sms/whatsapp/tutorial/connect-number-business-profile).

- Verify that you have permissions on the secure columns. Learn more in [Configure permissions to access secure columns](../implement/add-users-assign-roles.md#configure-permissions-to-access-secure-columns).

## WhatsApp message types and 24-hour session rule

- **Template messages:** Are the outbound messages that service representatives send through Twilio using one of the preapproved templates? They're typically transactional messages, such as delivery alerts and appointment reminders, sent to users who have opted in to receive messages from your organization. For messages requiring localization, you must get the message approved by WhatsApp in each language. Learn more about WhatsApp message templates in [WhatsApp documentation](https://developers.facebook.com/docs/whatsapp/message-templates/).

- **Session messages:** According to WhatsApp, session messages are incoming messages from a customer or outgoing replies by a representative to the incoming messages, within 24 hours. A messaging session starts when representatives receive a message from a customer. It lasts for 24 hours from the most recently received message. Session messages don't need to follow a template, and can include media attachments.

- **24 hours session rule:** A messaging session starts when a representative receives a message from a customer or replies to the incoming message from the customer. When the customer sends a message, the representative has 24 hours to reply from the time it was received. However, after 24 hours, the representative can send a message to customer only by using a predefined and approved template.

## End-to-end walkthrough

1. Fetch Twilio account details
2. Create a WhatsApp channel
3. Create routing rules
4. Modify settings for a specific WhatsApp phone number

## Fetch Twilio account details

To integrate a WhatsApp channel through Twilio with the Customer Service admin center or Contact Center admin center application, you need to go to your Twilio account and fetch the **ACCOUNT SID** and **AUTH TOKEN** values. Save the values as they're required to configure a WhatsApp channel through the admin application.

Go to your **Twilio Console Dashboard** > **Settings** > **General** to fetch the details.

## Create a WhatsApp channel

1. In the site map of Customer Service admin center or Contact Center admin center, select **Channels** in **Customer support**. The **Channels** page appears.
    
1. Select **Manage** for **Messaging accounts**. The **Accounts and channels** page appears.
   
1. Select **New account**.

1. Enter the following details:

    1. On the **Channel details** page, enter a name and select **WhatsApp** in **Channels**.

    2. On the **Account details** page, enter the following details:
      - **Account SID:** Specify the value from your Twilio account.
      - **Authentication token:** Specify the value from your Twilio account.
 
    3. On the **WhatsApp numbers** page, select **Add**, and on the page that appears, enter the following information:
      - **Name:** Specify a name.
      - **Number:** Specify the WhatsApp phone number by prefixing the plus (+) symbol.
    
    4. On the **Callback information** page, copy the value in the **Twilio inbound URL** box to use for the Twilio account.
    
    5. Select **Done**. The account is added to the list.

1. To configure routing and work distribution, you can create a [workstream](create-workstreams.md) or select an existing one.

1. Select the workstream that you've created for the WhatsApp channel and on the workstream page, select **Set up WhatsApp** to configure the following options:
   
    1. On the **WhatsApp number** page, in the **Available WhatsApp numbers** list, select the number that you created.
   
    2. On the **Language** page, select the language.
    
    3. On the **Behaviors** page, configure the following options:
      - [Custom automated messages](configure-automated-message.md)
      - [WhatsApp message templates](#configure-whatsapp-message-templates)
      - [Post-conversation survey](configure-post-conversation-survey.md)
    4. On the **User features** page, set the toggle for **File attachments** to **On** and select the following checkboxes if you want to allow representatives and customers to send and receive file attachments. Learn more in [Enable file attachments](enable-file-attachments.md).
      - Customers can send file attachments
      - Representatives can send file attachments
    5. Verify the settings on the **Summary** page, and select **Finish**. The WhatsApp channel instance is configured.

1. Configure routing rules. Learn more in [Configure work classification](configure-work-classification.md).

1. Configure work distribution. Learn more in [Work distribution settings](create-workstreams.md#configure-work-distribution).

1. Optionally, [add an agent](create-workstreams.md#add-a-bot-to-a-workstream).

1. Based on your business needs, in **Advanced settings**, configure the following options:
   - [Sessions](session-templates.md)
   - [Agent notifications](notification-templates.md#out-of-the-box-notification-templates)
   - [Context variables](manage-context-variables.md#add-context-variables))
   - [Smart assist bots](../develop/smart-assist-bot.md)
   - [Quick replies](create-quick-replies.md)

### Configure WhatsApp message templates

You can configure the option for representatives to send WhatsApp-approved messages. If 24 hours pass after a customer's last message, representatives will only be able to send messages from WhatsApp-approved templates until the customer responds. You must create your message templates in your Twilio account and have them approved by WhatsApp before you add them in Dynamics 365 Contact Center or Dynamics 365 Customer Service.

Perform the following steps:

1. For the selected workstream for WhatsApp, edit the WhatsApp account.
2. On the **Behaviors** tab, in **WhatsApp message templates**, select **Add**.
3. On the **Add message template** dialog box, do the following:
   - **Name:** Specify a name for the template.
   - **Default language:** Select the language from the list.
   - **WhatsApp approved text:** Copy and paste the approved text from the template that you created in WhatsApp.
4. Select **Save**.
5. Create as many templates as required.

### Integrate omnichannel application with a Twilio sandbox account

1. In Twilio, go to the **Programmable SMS** > **Programmable Messaging** > **WhatsApp sandbox**.
2. In the **WHEN A MESSAGE COMES IN** box, enter the Twilio inbound URL that you generated in the application, and save the changes.
3. To test the WhatsApp channel with the Twilio sandbox, you can send a WhatsApp message to the number provided by Twilio with a unique code that is also provided by Twilio. You can also use the sandbox message template provided by Twilio to test sending messages outside of the 24-hour window.

### Related information

[Understand and create workstreams](../work-streams-introduction.md)  
[Configure automated messages](configure-automated-message.md)  
[Configure a post-conversation survey](configure-post-conversation-survey.md)  
[Skill-based routing](overview-skill-work-distribution.md)  
[Create message templates](create-message-templates.md)  
[Templates](/dynamics365/app-profile-manager/templates-overview)  
[Delete a configured channel](delete-channel.md)  
[Support for live chat and asynchronous channels](card-support-in-channels.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
