---
title: How-to topic template #Required; page title displayed in search results. Don't enclose in quotation marks.
description: How-to description #Required; article description that's displayed in search results. Don't enclose in quotation marks. Do end with a period.
author: rhanajoy #Required; your GitHub user alias, with correct capitalization.
ms.author: rhcassid #Required; your Microsoft alias; optional team alias.
ms.reviewer: kfend #Required; Microsoft alias of content publishing team member.
ms.topic: how-to #Required; don't change.
ms.collection: get-started #Required; If this isn't a getting started article, don't remove the attribute, but leave the value blank. The values for this attribute will be updated over time.
ms.date: 08/05/2024
ms.custom: bap-template #Required; don't change.
---

# Configure a WhatsApp channel through Azure Communication Services

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

The WhatsApp channel feature lets you integrate WhatsApp through Azure Communication Services to engage with customers who prefer to use the WhatsApp channel.

The success of social media customer service, like all other customer service, depends on the quality of care provided. Communications from agents should be timely, accurate, sensitive, brief, and friendly, which ultimately improves the customer satisfaction and brand loyalty.

## Prerequisites

- Make sure channels are provisioned in your environment. More information: [Provision Omnichannel for Customer Service](../implement/omnichannel-provision-license.md).
- Verify that you have permissions on the secure columns. More information: [Configure permissions to access secure columns](../implement/add-users-assign-roles.md#configure-permissions-to-access-secure-columns)
-  A Facebook ID.
- A phone number, you can bring your own phone number or get a new phone number from Azure Communication Services. these numbers should be able to receive SMS and texts. Phone number must not be associated with other whatsapp business accounts.


## End-to-end walkthrough

1. [Get a phone number](/azure/communication-services/quickstarts/telephony/get-phone-number). You will use this phone number to create a WhatsApp channel in Azure Communication Services.
1. Create a new Azure Communication Services resource or use an existing resource. Learn more at [Create and manage Communication Services resources](/azure/communication-services/quickstarts/create-communication-resource). Copy the resource name.
1. Access the communication string for the resource, and copy the **Connection string**. Learn more at [Access your connection strings and service endpoints](/azure/communication-services/quickstarts/create-communication-resource#access-your-connection-strings-and-service-endpoints)
1. [Create a WhatsApp channel in Azure Communication Services](/azure/communication-services/quickstarts/advanced-messaging/whatsapp/connect-whatsapp-business-account). Copy the **Channel ID** corresponding to the channel you've created.
1. [Create an active Event subscription and deploy an event gird viewer](/azure/communication-services/quickstarts/advanced-messaging/whatsapp/handle-advanced-messaging-events)
1. Get the **AAD Tenant ID** and **AAD Application ID or URI** values. Perform the following steps in Azure Communication Services to retrieve the values:
     - Go to **Events**  and select the Event subscription that you created in the previous step.
     - In the Event Subscription page, select **Additional Features** tab.
    - In the **AAD AUTHENTICATION** section, copy the **AAD Tenant ID** and **AAD Application ID or URI** values.

## Account



## Fetch Twilio account details

To integrate a WhatsApp channel through Twilio with Omnichannel for Customer Service, you need to go to your Twilio account and fetch the **ACCOUNT SID** and **AUTH TOKEN** values. Save the values safely because they're required to configure a WhatsApp channel through Customer Service admin center.

Go to your **Twilio Console Dashboard** > **Settings** > **General** to fetch the details.

## Create a WhatsApp channel

1. In the site map of Contact Center admin center or Customer Service admin center, select **Channels** in **Customer support**. The **Channels** page appears.
    
1. Select **Manage** for **Messaging accounts**. The **Accounts and channels** page appears.
   
1. Select **New account**.

1. Enter the following details:

    1. On the **Channel details** page, enter a name and select **WhatsApp** in **Channels**.

    2. On the **Account details** page, specify Azure Communication Services as the **Provider** and then specify the following information:
      - **ACS resource name:** The ACS resource that you've created
      - **ACS connection string:** Connection key
      - **Event grid app ID**: AAD Tenant id
      - **Event grid app tenant ID**: AAD app ID
 
    3. On the **WhatsApp channel IDs** page, select **Add**, and on the page that appears, enter the following information:
      - **Name:** Specify a name.
      - **Channel ID:** Specify the Channel ID from ACS.
    
    4. On the **Callback information** page, copy the value in the **Twilio inbound URL** box to use for the Twilio account.
    
    5. Select **Done**. The account is added to the list.


## Configure a workstream for the WhatsApp channel

1. To configure routing and work distribution, you can create a [workstream](create-workstreams.md) or select an existing one.

1. Select the workstream that you've created for the WhatsApp channel and on the workstream page, select **Set up WhatsApp** to configure the following options:
   
    1. On the **WhatsApp number** page, in the **Available WhatsApp numbers** list, select the number that you created.
   
    2. On the **Language** page, select the language.
    
    3. On the **Behaviors** page, configure the following options:
      - [Custom automated messages](configure-automated-message.md)
      - [WhatsApp message templates](#configure-whatsapp-message-templates)
      - [Post-conversation survey](configure-post-conversation-survey.md)
    4. On the **User features** page, set the toggle for **File attachments** to **On** and select the following checkboxes if you want to allow agents and customers to send and receive file attachments. More information: [Enable file attachments](enable-file-attachments.md).
      - Customers can send file attachments
      - Agents can send file attachments
    5. Verify the settings on the **Summary** page, and select **Finish**. The WhatsApp channel instance is configured.

1. Configure routing rules. More information: [Configure work classification](configure-work-classification.md).

1. Configure work distribution. More information: [Work distribution settings](create-workstreams.md#configure-work-distribution)

1. Optionally, [add a bot](create-workstreams.md#add-a-bot-to-a-workstream).

1. Based on your business needs, in **Advanced settings**, configure the following options:
   - [Sessions](session-templates.md)
   - [Agent notifications](notification-templates.md#out-of-the-box-notification-templates)
   - [Context variables](manage-context-variables.md#add-context-variables))
   - [Smart assist bots](../develop/smart-assist-bot.md)
   - [Quick replies](create-quick-replies.md)

### Configure WhatsApp message templates

You can configure the option for agents to send WhatsApp-approved messages. If 24 hours pass after a customer's last message, agents will only be able to send messages from WhatsApp-approved templates until the customer responds. You must create your message templates in your Twilio account and have them approved by WhatsApp before you add them in Omnichannel for Customer Service.

Perform the following steps:

1. For the selected workstream for WhatsApp, edit the WhatsApp account.
2. On the **Behaviors** tab, in **WhatsApp message templates**, select **Add**.
3. On the **Add message template** dialog box, do the following:
   - **Name:** Specify a name for the template.
   - **Default language:** Select the language from the list.
   - **WhatsApp approved text:** Copy and paste the approved text from the template that you created in WhatsApp.
4. Select **Save**.
5. Create as many templates as required.

### Integrate a Twilio sandbox account with Omnichannel for Customer Service

1. In Twilio, go to the **Programmable SMS** > **Programmable Messaging** > **WhatsApp sandbox**.
2. In the **WHEN A MESSAGE COMES IN** box, enter the Twilio inbound URL that you generated in Omnichannel for Customer Service, and save the changes.
3. To test the WhatsApp channel with the Twilio sandbox, you can send a WhatsApp message to the number provided by Twilio with a unique code that is also provided by Twilio. You can also use the sandbox message template provided by Twilio to test sending messages outside of the 24-hour window.

### See also

[Understand and create workstreams](../work-streams-introduction.md)  
[Configure automated messages](configure-automated-message.md)  
[Configure a post-conversation survey](configure-post-conversation-survey.md)  
[Skill-based routing](overview-skill-work-distribution.md)  
[Create message templates](create-message-templates.md)  
[Templates](/dynamics365/app-profile-manager/templates-overview)  
[Delete a configured channel](delete-channel.md)  
[Support for live chat and asynchronous channels](card-support-in-channels.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
