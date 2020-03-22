---
title: "Configure a WeChat channel | MicrosoftDocs"
description: "Instructions for configuring a WeChat channel in Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 04/01/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---
# Configure a WeChat channel

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

## WeChat channel

By leveraging social messaging channels, such as WeChat, that has a large user base in Asia, business efficiencies in certain geographical areas can be addressed by integrating their services into Omnichannel for Customer Service.

## Prerequisites

Make sure that the following prerequisites are met:

- WeChat is provisioned in your environment. For information, see [Provision Omnichannel for Customer Service](omnichannel-provision-license.md)
- An active subscription to the WeChat account exists and is stored as a contact on your phone. You will initiate WeChat conversations by contacting the subscription account.

## Configure a WeChat channel in Omnichannel

### Step 1: Get WeChat account details

To integrate a WeChat channel with Omnichannel for Customer Service, get the following details:

- Service Account; **Original ID** in WeChat
- Developer ID
- Developer password
- Token
- Message encryption key
  
### Step 2: Create a work stream

Perform the following steps to create a work stream:

1. Sign in to Omnichannel Administrator.

2. Select **Work Streams** under **Work Distribution Management**.

3. Select **New**. The **New Work Stream** page appears.

4. Specify details in the **General information** and **Work distribution** sections. For information, see [Understand and create work streams](work-streams-introduction.md)

5. Select **WeChat** in **Channels**.
6. Select **Save**. The work stream for WeChat is saved.

> [!NOTE]
>
> To configure other options in the work stream, see the following:
>
> - [Skill-based routing](overview-skill-work-distribution.md)
> - [Productivity tools](productivity-tools.md)
> - [Smart assist](smart-assist.md)
> - [Templates](templates-overview.md)

### Step 3: Create a WeChat channel

Perform the following steps to create a WeChat channel:

1. In Omnichannel Administrator, select **WeChat** under **Channels**.
2. Select **New**. The **New WeChat** page appears.
3. In the **General** > **Step 1: Account details** area, enter the following details:

    - **Name:** Specify a name for the channel.
    - **Owner:** Accept the default owner or change to specify a different owner.
    - **Service Account:** Specify the WeChat service account number.
    - **Developer ID (AppID):** Specify the WeChat Developer ID.
    - **Developer password (AppSecret):** Specify the WeChat Developer password.
    - **Token:** Specify the WeChat token.
    - **Message encryption key (EncodingAESKey):** Specify the WeChat Message encryption key.
  
4. In **Step 2: Work distribution** > **Work Stream**, select the work stream that you created for WeChat.
5. Select **Save**. The details are saved, and data is populated in **Step 3: Callback information**.
6. In **Step 3: Callback information**, copy the information that is displayed in the **IP whitelist** and **Server address (URL)** boxes.

### Step 4: Configure WeChat details

1. Sign in to your WeChat account, and paste the IP whitelist and server address in the respective boxes. The IP address of the Omnichannel application is white listed in the WeChat firewall. The server address helps establish the connection between WeChat and Omnichannel application.
2. In WeChat, make sure that you select **Security Mode** under **Message Encryption Method** for encryption of the chat messages.
3. Select **Submit**.

### See also

[Channels in Omnichannel](channels.md)
[Use WeChat channel](../agent/agent-oc/wechat-channel.md)