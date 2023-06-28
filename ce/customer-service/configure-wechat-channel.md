---
title: "Configure a WeChat channel in Omnichannel for Customer Service | MicrosoftDocs"
description: "Perform the steps mentioned in this topic to configure a WeChat channel in Omnichannel for Customer Service."
ms.date: 10/27/2022
ms.topic: article
author: neeranelli
ms.author: nenellim
---
# Configure a WeChat channel

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## WeChat channel

organizations enhance business efficiencies in certain geographical areas by integrating social messaging channels such as WeChat, which has a large user base in Asia, into Omnichannel for Customer Service.

  > [!NOTE]
  > The WeChat channel isn't available in the Government Community Cloud (GCC) region.

## Prerequisites

Make sure that the following prerequisites are met:

- WeChat is provisioned in your environment. More information: [Provision Omnichannel for Customer Service](omnichannel-provision-license.md)
 
  > [!NOTE]
  > To enable the WeChat channel in an existing environment, you must upgrade to the latest version of Omnichannel for Customer Service. For information, [Upgrade Omnichannel for Customer Service](upgrade-omnichannel.md).

- An active subscription to the WeChat service account or sandbox account (if using sandbox for testing) exists and is stored as a contact on your phone. You'll initiate WeChat conversations by contacting the subscription account. More information: [WeChat documentation](https://go.microsoft.com/fwlink/p/?linkid=2124569)

- Verify that you have permissions on the secure columns. More information: [Configure permissions to access secure columns](add-users-assign-roles.md#configure-permissions-to-access-secure-columns)

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
   
   ### [Omnichannel admin center](#tab/omnichanneladmincenter) 

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

1. Select the workstream that you've created for the WeChat channel and on the workstream page, select **Set up WeChat**, and do the following steps:
   
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
   - [Sessions](../app-profile-manager/session-templates.md)
   - [Agent notifications](../app-profile-manager/notification-templates.md#out-of-the-box-notification-templates)
   - [Context variables](manage-context-variables.md#add-context-variables)
   - [Smart assist bots](smart-assist-bot.md)
   - [Quick replies](create-quick-replies.md)

### Configure WeChat details

If you're using the service account of WeChat, perform the following steps:

1. Sign in to your WeChat Service Account, and then paste the IP allowlist and server address, which you copied from Omnichannel admin center in the preceding procedure, in their respective boxes. The IP address of the Omnichannel for Customer Service application is not blocked in the WeChat firewall. The server address helps establish the connection between WeChat and Omnichannel for Customer Service.

2. In WeChat, make sure that you select **Security Mode** under **Message Encryption Method** for encryption of the chat messages.

3. Select **Submit**.

#### Create a WeChat channel in Omnichannel Administration

[!INCLUDE[cc-omnichannel-administration-deprecation-note.md](../includes/cc-omnichannel-administration-deprecation-note.md)]

1. In Omnichannel Administration, under **Channels**, select **WeChat**.

2. Select **New**. The **New WeChat** page appears.

3. On the **General** tab, in the **Step 1: Account details** area, enter the following details:

    - **Name:** Specify a name for the channel.
    - **Owner:** Accept the default owner, or change to specify a different owner.
    - **Service Account:** Specify the WeChat service or sandbox account number.
    - **Developer ID (AppID):** Specify the WeChat Developer ID.
    - **Developer password (AppSecret):** Specify the WeChat Developer password.
    - **Token:** Specify the WeChat token.
    - **Message encryption key (EncodingAESKey):** Specify the WeChat Message encryption key for service account. If you're configuring a sandbox account, use a key of your choice.
  
4. In the **Step 2: Work distribution** area, for **Work Stream**, select the out-of-the-box workstream for WeChat. Alternatively, you can create a [work stream](work-streams-introduction.md) for WeChat and associate it with the WeChat channel.

5. Select **Save**. The details are saved, and data is populated in the **Step 3: Callback information** section.

6. Copy the information that's displayed in the boxes. This step is required for only WeChat service account.


#### Modify settings for a specific WeChat account


1. In the Omnichannel Administration app, go to your WeChat application and select the WeChat account you want to modify.

2. On the **General settings** tab, provide the following information:
    
    - **Language**: Select the preferred language for your WeChat account.
    
    - **Work stream**: Select an existing workstream or create a new one.

    - **Enable file attachments for customers**: Set to **Yes** to allow customers to send file attachments to agents. Otherwise, set **No**. 

    - **Enable file attachments for agents**: Set to **Yes** to allow agents to send file attachments to customers. When the agent sends an attachment, the app uploads the attachment to WeChat and captures the media ID. Otherwise, set **No**.
    
      To learn more about attachments, see [Enable file attachments](enable-file-attachments.md). 
       
      To learn more about uploading media in WeChat, see [WeChat developer documentation](https://developers.weixin.qq.com/doc/offiaccount/en/Asset_Management/New_temporary_materials.html).

3. On the **Automated messages** tab, [configure automated messages](configure-automated-message.md).
4. On the **Surveys** tab, [configure a post-conversation survey](configure-post-conversation-survey.md).

## Privacy notice

By enabling this feature, your data will be shared with WeChat and flow outside of your organization's compliance and geo boundaries (even if your organization is in a Government Cloud Community region). Consult the feature technical documentation for more information [here](/azure/bot-service/bot-service-channel-connect-wechat).

Customers are solely responsible for using Dynamics 365, this feature, and any associated feature or service in compliance with all applicable laws, such as laws relating to monitoring, recording, and storing communications with their end users. This includes adequately notifying end users that their communications with agents may be monitored, recorded, or stored and, as required by applicable laws, obtaining consent from end users before using the feature with them. Customers are also encouraged to have a mechanism in place to inform their agents that their communications with end users may be monitored, recorded, or stored.

### See also

[Channels in Omnichannel for Customer Service](channels.md)  
[Use a WeChat channel](wechat-channel.md)  
[Delete a configured channel](delete-channel.md)  
[Support for live chat and asynchronous channels](card-support-in-channels.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
