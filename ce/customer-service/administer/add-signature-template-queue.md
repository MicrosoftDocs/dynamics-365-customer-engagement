---
title: Configure a default signature template for a queue 
description: Learn how to set up email signature templates for queues.
ms.date: 08/29/2024
ms.topic: how-to
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.custom: bap-template

---

# Add a default signature template to a queue

You can add a default signature template for a queue to ensure that emails sent with the queue as the sender have consistent email signatures. When you send an email with the queue as the sender or reply to messages received by the queue, the default signature is added to the body of the email. If you don't specify a default signature template for a queue, the application adds the signature queue's owner.

## Prerequisites

Email signature templates must be available in the application before you can add them to a queue.

## Set up default email signature for queues


1. In the site map of Customer Service admin center, select **Queues** in **Customer support**.
    
1. On the **Queues** page, select **Manage** for **Basic queues**.

2. To create a queue, select **New**. To edit a queue, select the queue in the list of queues, and then select **Edit** on the command bar.  
1. In the **EMAIL SETTINGS** section, specify the signature template in  **Email Signature**.

 ![Add a default signature template.](../media/email-sig-temp-queue.png "Add a default signature template to a queue")

### Related information  

[Create a signature for emails](/power-apps/user/email-signature)  
