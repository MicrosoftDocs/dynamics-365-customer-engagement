---
title: Configure a WhatsApp channel through Twilio
description: Use this article to learn how to configure the WhatsApp channel through Twilio in Omnichannel for Customer Service.
ms.date: 06/14/2024
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.collection:
ms.custom: bap-template
---

# Configure a WhatsApp channel through Twilio

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

The WhatsApp channel feature lets you integrate WhatsApp through Twilio with Omnichannel for Customer Service to engage with customers who prefer to use the WhatsApp channel.

The success of social media customer service, like all other customer service, depends on the quality of care provided. Communications from agents should be timely, accurate, sensitive, brief, and friendly, which ultimately improves the customer satisfaction and brand loyalty.

## Prerequisites

- Make sure channels are provisioned in your environment. More information: [Provision Omnichannel for Customer Service](../implement/omnichannel-provision-license.md).
- You can configure the WhatApp channel through Twilio or Azure Communication Services. Follow the appropriate steps based on your requirements.

   ### [Azure Communication Services](#tab/azurecommunicationservices)

   - Have an Azure subscription that's in the same tenant as your Dynamics 365 account. Ensure that your Azure subscription meets the Subscription eligibility and number capabilities requirements.
   - Have at least contributor-level permissions to the Azure subscription. To check your role, open your subscription and view the My role column of your subscription on the Azure portal. You'll be able to deploy your Azure Communication Services resource only if you have contributor-level permissions.
   - Create or use an existing Azure Communication Services resource. Learn more at [Create and manage Communication Services resources](/azure/communication-services/quickstarts/create-communication-resource).
   - [Advanced Messaging for WhatsApp](/azure/communication-services/concepts/advanced-messaging/whatsapp/whatsapp-overview) is setup in Azure Communication Services.

   ### [Twilio](#tab/twilio)
    
  
   - For newly created Twilio accounts, you must disable a security setting that blocks the ability to send media files. More information: [Extended notice and update on security changes: HTTP Authentication for Voice and Messaging Media enabled by default](https://go.microsoft.com/fwlink/p/?linkid=2248938)

   - Obtain a Twilio account with an appropriate subscription or a Twilio sandbox account. For information on configuring a Twilio sandbox account, see [Integrate a Twilio sandbox account with Omnichannel for Customer Service](#integrate-a-twilio-sandbox-account-with-omnichannel-for-customer-service)

  - Connect Twilio Number to your WhatsApp Business Profile. To learn more, see [Connect your Twilio Number to your WhatsApp Business Profile](https://www.twilio.com/docs/sms/whatsapp/tutorial/connect-number-business-profile).

  - Verify that you have permissions on the secure columns. More information: [Configure permissions to access secure columns](../implement/add-users-assign-roles.md#configure-permissions-to-access-secure-columns)

---
 
## WhatsApp message types and 24-hour session rule

- **Template messages:** Are the outbound messages that agents send through Twilio using one of the preapproved templates? They're typically transactional messages, such as delivery alerts and appointment reminders, sent to users who have opted in to receive messages from your organization. For messages requiring localization, you must get the message approved by WhatsApp in each language. For more information about WhatsApp message templates, see [WhatsApp documentation](https://developers.facebook.com/docs/whatsapp/message-templates/).

- **Session messages:** According to WhatsApp, session messages are incoming messages from a customer or outgoing replies by an agent to the incoming messages, within 24 hours. A messaging session starts when agents receive a message from a customer. It lasts for 24 hours from the most recently received message. Session messages don't need to follow a template, and can include media attachments.

- **24 hours session rule:** A messaging session starts when an agent receives a message from a customer or replies to the incoming message from the customer. When the customer sends a message, the agent has 24 hours to reply from the time the agent received it. However, after 24 hours, the agent can send a message to customer only by using a predefined and approved template.

## End-to-end walkthrough

1. Fetch Twilio account or Azure Communication Services details.
2. Create a WhatsApp channel
3. Create routing rules
4. Modify settings for a specific WhatsApp phone number

## Fetch Twilio account Azure Communication Services details

Based on the messaging infrastructure you have configured, follow the appropriate steps to fetch the required details.

   ### [Azure Communication Services](#tab/azurecommunicationservices)

   Copy the following information from the [Azure portal](https://ms.portal.azure.com/). You will need these details to configure the WhatsApp channel through Customer Service admin center.
   
   1. Go to **Resource groups** and select the required resource group. 
   1. Select the required **Resource** from the resource group.
   1. Select **Properties** in **Settings**. 
   1. On the **Properties** page, copy the **Name**. 
   1. Select **Keys** in **Settings**. On the **Keys** page, copy **Connection string** in **Primary key**.
   1. Select **Events**. Select the event subscription you've created as a part of setting up advanced messaging for WhatsApp in [Prerequisities](#prerequisites).
   1. Select **Additional features** in the **Event Subscription** page. 
   1. In **AAD AUTHENTICATION**, copy the **AAD Tenant ID** and **AAD Application ID or URI** values.
   1. Select **Channels** in **Advanced Messaging**. Copy the **Channel ID** corresponding to the channel you've created as a part of setting up advanced messaging for WhatsApp in [Prerequisities](#prerequisites).

   ### [Twilio](#tab/twilio)
    
  
   To integrate a WhatsApp channel through Twilio with Omnichannel for Customer Service, you need to go to your Twilio account and fetch the **ACCOUNT SID** and **AUTH TOKEN** values. Save the values safely because they're required to configure a WhatsApp channel through Customer Service admin center.

   Go to your **Twilio Console Dashboard** > **Settings** > **General** to fetch the details.
   
---

## Create a WhatsApp channel

1. In the site map of Customer Service admin center, select **Channels** in **Customer support**. The **Channels** page appears.
    
1. Select **Manage** for **Messaging accounts**. The **Accounts and channels** page appears.
   
1. Select the required **Provider**. Based on your selection, specify the following details.

   ### [Azure Communication Services](#tab/azurecommunicationservices)


   You must specify the information you've copied from in [Fetch Azure Communication Services details](#azure-communication-services-1).
    
     1. In the **Channel settings** page, specify the following. 
         - **ACS resource name**: The **Name** of the resource.
         - **ACS connection string**: The **Connection string** corresponding to the resource.
         - **Event grid app ID**: **AAD Tenant ID**.
         - **Event grid app tenant ID**:  **AAD Application ID or URI**.
         - Select the check box to confirm that the Azure Communication Services resource is connected only to one organization.
      1. In the **WhatsApp channel ID**, select **Add**, and on the page that appears, enter the following information:
         - **Name**: Specify a name.
         - **Channel ID**: Specify the **Channel ID** for the WhatsApp channel you've created in Azure Communication Services.
      1. On the **Callback information** page, copy the value in the **WhatsApp inbound URL** box to use in the Azure Communication Services event grid.
      1. Perform the steps the following section to add the WhatsApp endpoint to the Azure Communication Services resource.
      1. Select the check box to confirm that the WhatsApp channel is setup correctly and then select **Done**.
      
      **Add the WhatsApp endpoint to Azure Communication Services resource**

       1. In the Azure portal, go to the **Events** page.
       1. Select the event subscription that you created as a part of the [Advanced Messaging for WhatsApp](/azure/communication-services/concepts/advanced-messaging/whatsapp/whatsapp-overview) setup in Azure Communication Services.
       1. In the Event Subscription page > **Endpoint** select **Change** for the endpoint and add the **WhatsApp inbound URL** that you copied from the Callback information page in the WhatsApp channel setup.

      
   ### [Twilio](#tab/twilio)
    
   1. On the **Account details** page, specify the following:
    - **Account SID:** Specify the value from your Twilio account.
    - **Authentication token:** Specify the value from your Twilio account.
   2. On the **WhatsApp channel ID** page, select **Add**, and on the page that appears, enter the following information:
    - **Name:** Specify a name.
    - **Number:** Specify the WhatsApp phone number by prefixing the plus (+) symbol.
   3. On the **Callback information** page, copy the value in the **Twilio inbound URL** box to use for the Twilio account. 
   1. Select **Done**. The account is added to the list.
   
   **Integrate a Twilio sandbox account**

   1. In Twilio, go to the **Programmable SMS** > **Programmable Messaging** > **WhatsApp sandbox**.
   2. In the **WHEN A MESSAGE COMES IN** box, enter the Twilio inbound URL that you generated and save the changes.
   3. To test the WhatsApp channel with the Twilio sandbox, you can send a WhatsApp message to the number provided by Twilio with a unique code that is also provided by Twilio. You can also use the sandbox message template provided by Twilio to test sending messages outside of the 24-hour window.
    
---

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
1. To configure routing and work distribution, you can create a [workstream](create-workstreams.md) with the **Channel** set to **WhatsApp** or select an existing one.

1. Select the workstream that you've created for the WhatsApp channel and on the workstream page, select **Set up WhatsApp** to configure the following options:
   
    1. On the **Channel** page, select the Azure Communication Services channel or the Twilio number that you created.
   
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
