---
title: Configure a WhatsApp channel through Azure Communication Services (preview)
description: Use this article to learn how to configure the WhatsApp channel through Azure Communication Services.
ms.date: 08/30/2024
ms.topic: how-to
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.collection:
ms.custom: bap-template
---

# Configure a WhatsApp channel through Azure Communication Services (preview)

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

> [!IMPORTANT]
> This is a preview feature.
> Preview features aren’t meant for production use and might have restricted functionality. To sign up to use this feature, fill out [this](https://forms.office.com/r/xu3K2hDic1) form.

The success of social media customer service, like all other customer services, depends on the quality of customer care provided. Communications from agents should be timely, accurate, sensitive, brief, and friendly, which ultimately improves customer satisfaction and brand loyalty. To enhance customer satisfaction and improve communications, the omnichannel capability in the application enables you to send and receive WhatsApp messages using [Azure Communication Services](/azure/communication-services). You can use the WhatsApp channel feature to engage in conversations with customers for product inquiry and customer service scenarios with those who prefer to communicate using WhatsApp. 


## Prerequisites

- Make sure channels are provisioned in your environment. More information: [Provision Omnichannel for Customer Service](../implement/omnichannel-provision-license.md).
- Have an Azure account with an active subscription. Make sure that the Azure subscription and Dynamics 365 account are in the same tenant. Learn more at [Create an account for free](https://azure.microsoft.com/pricing/purchase-options/azure-account).
   - Create or use an existing Azure Communication Services resource. Learn more at [Create and manage Communication Services resources](/azure/communication-services/quickstarts/create-communication-resource).
    - Obtain a phone number that can send and receive SMS. The following are supported:
       - Purchase a [phone number](/azure/communication-services/quickstarts/telephony/get-phone-number) or [import phone numbers](voice-channel-sync-from-acs.md)
       - [Bring your own phone number from existing providers](voice-channel-bring-your-own-number.md) or migrate your existing WhatsApp business accounts with phone number.
   - [Advanced Messaging for WhatsApp](/azure/communication-services/concepts/advanced-messaging/whatsapp/whatsapp-overview) is set up in Azure Communication Services. Perform the steps in [register WhatsApp business account](/azure/communication-services/quickstarts/advanced-messaging/whatsapp/connect-whatsapp-business-account).
   - Configure [Event Grid](/azure/communication-services/quickstarts/advanced-messaging/whatsapp/handle-advanced-messaging-events) with Microsoft Entra app authentication. Learn more at [Secure WebHook delivery with Microsoft Entra ID in Azure Event Grid](/azure/event-grid/secure-webhook-delivery).

## End-to-end walkthrough

1. Get Azure Communication Services details to connect.
2. Create a WhatsApp channel
3. Create routing rules
4. Modify settings for a specific WhatsApp phone number

## Fetch Azure Communication Services details

Copy the following information from the [Azure portal](https://ms.portal.azure.com/). You will need these details to configure the WhatsApp channel through Contact Center admin center or Customer Service admin center.
   
   1. Go to **Resource groups** and select the required resource group. 
   1. Select the required **Resource** from the resource group.
   1. Select **Properties** in **Settings**. 
   1. On the **Properties** page, copy the **Name**. 
   1. Select **Keys** in **Settings**. On the **Keys** page, copy **Connection string** in **Primary key**.
   1. Select **Events**. Select the event subscription you've created as a part of setting up advanced messaging for WhatsApp in [Prerequisities](#prerequisites).
   1. Select **Additional features** in the **Event Subscription** page. 
   1. In **AAD AUTHENTICATION**, copy the **AAD Tenant ID** and **AAD Application ID or URI** values.
   1. Select **Channels** in **Advanced Messaging**. Copy the **Channel ID** corresponding to the channel you've created as a part of setting up advanced messaging for WhatsApp in [Prerequisities](#prerequisites).

## Create a WhatsApp channel

1. In the site map of Contact Center admin center or Customer Service admin center, select **Channels** in **Customer support**. The **Channels** page appears.
    
1. Select **Manage** for **Messaging accounts**. The **Accounts and channels** page appears.
   
1. Select the required **Provider**. Based on your selection, specify the following details.
 
    You must specify the information you've copied from in [Fetch Azure Communication Services details](#fetch-azure-communication-services-details).
    
     1. In the **Channel settings** page, specify the following. 
         - **ACS resource name**: The **Name** of the resource.
         - **ACS connection string**: The **Connection string** corresponding to the resource.
         - **Event grid app ID**: **AAD Tenant ID**.
         - **Event grid app tenant ID**:  **Microsoft Entra Application  or URI**.
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

You can configure the option for agents to send WhatsApp-approved messages. If 24 hours pass after a customer's last message, agents will only be able to send messages from WhatsApp-approved templates until the customer responds. You must perform the steps in Send WhatsApp template messages to send WhatsApp Template messages using Advanced Communication Messages SDK before you add them in the application.

> [!NOTE]
> Only text based message templates are supported.

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
