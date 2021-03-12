---
title: "Configure a WeChat channel in Omnichannel for Customer Service | MicrosoftDocs"
description: "Instructions for configuring a WeChat channel in Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 08/06/2020
ms.topic: article
ms.service: dynamics-365-customerservice
---
# Configure a WeChat channel

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## WeChat channel

Using social messaging channels such as WeChat&mdash;which has a large user base in Asia&mdash;lets organizations enhance business efficiencies in certain geographical areas by integrating these services into Omnichannel for Customer Service.

  > [!NOTE]
  > The WeChat channel isn't available in the Government Community Cloud (GCC) region.

## Prerequisites

Make sure that the following prerequisites are met:

- WeChat is provisioned in your environment. More information: [Provision Omnichannel for Customer Service](omnichannel-provision-license.md)
 
  > [!NOTE]
  > To enable the WeChat channel in an existing environment, you must upgrade to the latest version of Omnichannel for Customer Service. For information, [Upgrade Omnichannel for Customer Service](upgrade-omnichannel.md).

- An active subscription to the WeChat service account or sandbox account (if using sandbox for testing) exists and is stored as a contact on your phone. You'll initiate WeChat conversations by contacting the subscription account. More information: [WeChat documentation](https://go.microsoft.com/fwlink/p/?linkid=2124569)

### Get WeChat account details

To integrate a WeChat channel with Omnichannel for Customer Service, get the following details:

- **Original ID:** Original ID in the WeChat service or sandbox account.
- **Developer ID:** Application ID associated with your WeChat service or sandbox account.
- **Developer password:** Application secret used for authentication.
- **Token:** Customer-defined string.
- **Message encryption key:** Message encryption key in WeChat. If you are using a sandbox WeChat account, use a key of your choice.
  
## Create a WeChat channel in Omnichannel admin center


## Create a WeChat channel in Omnichannel Administration

1. In Omnichannel Administration, under **Channels**, select **WeChat**.

2. Select **New**. The **New WeChat** page appears.

3. On the **General** tab, in the **Step 1: Account details** area, enter the following details:

    - **Name:** Specify a name for the channel.
    - **Owner:** Accept the default owner, or change to specify a different owner.
    - **Service Account:** Specify the WeChat service or sandbox account number.
    - **Developer ID (AppID):** Specify the WeChat Developer ID.
    - **Developer password (AppSecret):** Specify the WeChat Developer password.
    - **Token:** Specify the WeChat token.
    - **Message encryption key (EncodingAESKey):** Specify the WeChat Message encryption key for service account. If you are configuring a sandbox account, use a key of your choice.
  
4. In the **Step 2: Work distribution** area, for **Work Stream**, select the out-of-the-box work stream for WeChat. Alternatively, you can create a [work stream](work-streams-introduction.md) for WeChat and associate it with the WeChat channel.

5. Select **Save**. The details are saved, and data is populated in the **Step 3: Callback information** section.

6. Copy the information that's displayed in the **IP whitelist** and **Server address (URL)** boxes. This step is required for only WeChat service account.

    > [!div class=mx-imgBorder]
    > ![Create a WeChat channel](media/wechat-channel-config.png "Create a WeChat channel")

### Configure WeChat details

If you are using the service account of WeChat, perform the following steps:

1. Sign in to your WeChat Service Account, and then paste the IP whitelist and server address, which you copied from Omnichannel Administration in the preceding procedure, in their respective boxes. The IP address of the Omnichannel for Customer Service application is not blocked in the WeChat firewall. The server address helps establish the connection between WeChat and Omnichannel for Customer Service.

2. In WeChat, make sure that you select **Security Mode** under **Message Encryption Method** for encryption of the chat messages.

3. Select **Submit**.

## Modify settings for a specific WeChat account

1. In the Omnichannel Administration app, go to your WeChat application and select the WeChat account you want to modify.

2. On the **General settings** tab, provide the following information:
    
    - **Language**: Select the preferred language for your WeChat account.
    
    - **Work stream**: Select an existing work stream or create a new one.

    - **Enable file attachments for customers**: Set to **Yes** to allow customers to send file attachments to agents. Otherwise, set **No**. 

    - **Enable file attachments for agents**: Set to **Yes** to allow agents to send file attachments to customers. When the agent sends an attachment, the app uploads the attachment to WeChat and captures the media ID. Otherwise, set **No**. 
    
       To learn more about attachments, see [Enable file attachments](enable-file-attachments.md). 
       
       To learn more about uploading media in WeChat, see [WeChat developer documentation](https://developers.weixin.qq.com/doc/offiaccount/en/Asset_Management/New_temporary_materials.html).

3. On the **Automated messages** tab, [configure automated messages](configure-automated-message.md).
    
4. On the **Surveys** tab, [configure a post-conversation survey](configure-post-conversation-survey.md).

## Privacy notice

By enabling this feature, your data will be shared with WeChat and flow outside of your organization's compliance and geo boundaries (even if your organization is in a Government Cloud Community region). Consult the feature technical documentation for more information [here](https://go.microsoft.com/fwlink/p/?linkid=2124947).

Customers are solely responsible for using Dynamics 365, this feature, and any associated feature or service in compliance with all applicable laws, such as laws relating to monitoring, recording, and storing communications with their end users. This includes adequately notifying end users that their communications with agents may be monitored, recorded, or stored and, as required by applicable laws, obtaining consent from end users before using the feature with them. Customers are also encouraged to have a mechanism in place to inform their agents that their communications with end users may be monitored, recorded, or stored.

### See also

[Channels in Omnichannel for Customer Service](channels.md)<br>
[Use a WeChat channel](wechat-channel.md)<br>
[Delete a configured channel](delete-channel.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]