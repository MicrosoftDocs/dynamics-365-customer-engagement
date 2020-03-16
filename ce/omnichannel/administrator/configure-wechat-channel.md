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
By leveraging social messaging channels such as WeChat that has a large user base in Asia, business efficiencies in certain geographical areas can be addressed by integrating their services into Omnichannel for Customer Service.

## Prerequisites

Make sure that the following prerequisites are met:

- WeChat is provisioned in your environment. For more information, see [Provision Omnichannel for Customer Service](omnichannel-provision-license.md)
- Active subscription to the WeChat account exists.
- Connection 

## Configure a WeChat channel in Omnichannel

### Step 1: Get WeChat account details

To integrate a WeChat channel with Omnichannel for Customer Service, make sure you have the following details:
- Service Account
- Developer ID
- Developer password
- Token
- Message encryption key
  
### Step 2: Create a work stream

Perform the following steps to create a work stream for the WeChat channel:

1. Sign in to Omnichannel Administrator.

2. Select **Work Streams** under **Work Distribution Management**.

3. Select **New**. The **New Work Stream **page appears.

4. Specify details in the **General information** and **Work distribution** sections. For information, see [Understand and create work streams](work-streams-introduction.md)

5. Select **Save**. The work stream for WeChat is saved.

### Step 3: Create a WeChat channel

Perform the following steps to create a WeChat channel in Omnichannel:

1. In Omnichannel Administrator, select **WeChat** under **Channels**. 
2. Select **New**. The **New WeChat** page appears.
3. In the General > Step 1: Account details area, enter the following details:
    
    - **Name:**
    - **Service Account:**
    - **Developer ID (AppID):**
    - **Developer password (AppSecret):**
    - **Token:**
    - **Message encryption key (EncodingAESKey):**
  
4. In **Step 2: Work distribution** > **Work Stream**, select the work stream that you created for WeChat.
5. In **Step 3: Callback information**, copy the information that is displayed in the IP whitelist and Server address (URL) boxes.