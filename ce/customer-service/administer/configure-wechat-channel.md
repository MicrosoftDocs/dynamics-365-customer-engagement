---
title: "Configure a WeChat channel in Omnichannel for Customer Service | MicrosoftDocs"
description: "Perform the steps mentioned in this topic to configure a WeChat channel in Omnichannel for Customer Service."
ms.date: 01/10/2024
ms.topic: article
author: neeranelli
ms.author: nenellim
---
# Configure a WeChat channel

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

## WeChat channel

Organizations enhance business efficiencies in certain geographical areas by integrating social messaging channels such as WeChat, which has a large user base in Asia, into Omnichannel for Customer Service.

  > [!NOTE]
  > The WeChat channel isn't available in the Government Community Cloud (GCC) region.

## Prerequisites

Make sure that the following prerequisites are met:

- WeChat is provisioned in your environment. More information: [Provision Omnichannel for Customer Service](../implement/omnichannel-provision-license.md)
 
  > [!NOTE]
  > To enable the WeChat channel in an existing environment, you must upgrade to the latest version of Omnichannel for Customer Service. For information, [Upgrade Omnichannel for Customer Service](../implement/upgrade-omnichannel.md).

- An active subscription to the WeChat service account or sandbox account (if using sandbox for testing) exists and is stored as a contact on your phone. You initiate WeChat conversations by contacting the subscription account. More information: [WeChat documentation](https://go.microsoft.com/fwlink/p/?linkid=2124569)

- Verify that you have permissions on the secure columns. More information: [Configure permissions to access secure columns](../implement/add-users-assign-roles.md#configure-permissions-to-access-secure-columns)

### Get WeChat account details

To integrate a WeChat channel with Omnichannel for Customer Service, get the following details:

- **Original ID:** Original ID in the WeChat service or sandbox account.
- **Developer ID:** Application ID associated with your WeChat service or sandbox account.
- **Developer password:** Application secret used for authentication.
- **Token:** Customer-defined string.
- **Message encryption key:** Message encryption key in WeChat. If you're using a sandbox WeChat account, use a key of your choice.
  
## Create a WeChat channel

**To create a WeChat channel**

1. In Dynamics 365, go to one of the apps, and perform the following steps.

   ### [Customer Service admin center](#tab/customerserviceadmincenter)
    
    1. In the site map, in **Customer support**, select **Channels**.
    
    1. In **Accounts**, for **Messaging accounts**, select **Manage**.
   
   ### [Omnichannel admin center (deprecated)](#tab/omnichanneladmincenter)

    [!INCLUDE[oac-deprecation](../../includes/oac-deprecation.md)] 

    - In the site map, in **General settings**, select **Channels**.

1. On the **Accounts and channels** page, select **New account**.

1. Enter the following details:
   1. On the **Channel details** page, specify a name and in **Channels**, select **WeChat**, and select **Next**.
   1. In **Account details**, enter the following information:
     - **Original ID:** Specify the WeChat account number.
     - **Developer ID (AppID):** Specify the WeChat Developer ID.
     - **Developer password (AppSecret):** Specify the WeChat Developer password.
     - **Token:** Specify the WeChat token.
     - **Message encryption key (EncodingAESKey):** Specify the WeChat Message encryption key for service account. If you're configuring a sandbox account, use a key of your choice.
   1. On the **Callback information** page, copy the values that you see in the two boxes. You'll update the copied information in the WeChat account.
   1. Select **Done**. The WeChat account instance is created.

1. To configure routing and work distribution, you can create a [workstream](create-workstreams.md) or select an existing one.

1. Select the workstream that you created for the WeChat channel and on the workstream page, select **Set up WeChat**, and do the following steps:
   
   1. On the **WeChat setup** dialog box, on the **WeChat** page, select the account that you created.
   
   1. On the **Language** page, select a language.
   
   1. On the **Behaviors** page, configure the following options:
      - [Custom automated messages](configure-automated-message.md)
      - [Post-conversation survey](configure-post-conversation-survey.md)
   
   1. On the **User features** page, set the toggle for **File attachments** to **On** and select the following checkboxes if you want to allow agents and customers to send and receive file attachments. More information: [Enable file attachments](enable-file-attachments.md).
      - Customers can send file attachments
      - Agents can send file attachments
   
   1. Verify the settings on the **Summary** page, and select **Finish**. The WeChat channel instance is configured.

1. Configure routing rules. More information: [Configure work classification](configure-work-classification.md).

1. Configure work distribution. More information: [Work distribution settings](create-workstreams.md#configure-work-distribution)

1. Add a bot. More information [Configure a bot](create-workstreams.md#add-a-bot-to-a-workstream).

1.  In **Advanced settings**, configure the following options based on your business needs:
   - [Sessions](session-templates.md)
   - [Agent notifications](notification-templates.md#out-of-the-box-notification-templates)
   - [Context variables](manage-context-variables.md#add-context-variables)
   - [Smart assist bots](../develop/smart-assist-bot.md)
   - [Quick replies](create-quick-replies.md)

### Configure WeChat details

If you're using the service account of WeChat, perform the following steps:

1. Sign in to your WeChat Service Account, and then paste the IP allowlist and server address, which you copied from Omnichannel admin center (deprecated) app in the preceding procedure, in their respective boxes. The IP address of the Omnichannel for Customer Service application is not blocked in the WeChat firewall. The server address helps establish the connection between WeChat and Omnichannel for Customer Service.

2. In WeChat, make sure that you select **Security Mode** under **Message Encryption Method** for encryption of the chat messages.

3. Select **Submit**.

## Privacy notice

If you enable this feature, your data is shared with WeChat and flows outside of your organization's compliance and geo boundaries (even if your organization is in a Government Cloud Community region). More information: [Connect a bot to WeChat](/azure/bot-service/bot-service-channel-connect-wechat).

Customers are solely responsible for using Dynamics 365, this feature, and any associated feature or service in compliance with all applicable laws. This responsibility includes laws that relate to monitoring, recording, and storing communications with their end users. This includes adequately notifying end users that their communications with agents might be monitored, recorded, or stored and, as required by applicable laws, obtaining consent from end users before using the feature with them. Customers are also encouraged to have a mechanism in place to inform their agents that their communications with end users might be monitored, recorded, or stored.

### See also

[Channels in Omnichannel for Customer Service](../use/channels.md)  
[Use a WeChat channel](../use/wechat-channel.md)  
[Delete a configured channel](delete-channel.md)  
[Support for live chat and asynchronous channels](../use/channels.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
