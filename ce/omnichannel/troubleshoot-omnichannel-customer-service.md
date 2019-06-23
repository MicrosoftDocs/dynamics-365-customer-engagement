---
title: "Troubleshoot Omnichannel for Customer Service | MicrosoftDocs"
description: "Learn how to troubleshoot the issues you may face while working on Omnichannel for Customer Service."
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 07/01/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 2507DF5E-99CF-4AF9-BAEF-5B9C7B43ECF7
ms.custom: 
---

# Troubleshoot Omnichannel for Customer Service

Use the following list of troubleshooting topics to quickly find information to solve your issue.

## Chat widget icon does not load on the portal

### Issue: 

Chat icon does not load on the portal. The chat icon URL which was configured as default in Jan release, does not work anymore.

### Resolution:

Open Chat Settings, navigate to Design tab and change "logo" field and use an Icon URL which works

## Chat not getting initiated on starting a new chat from portal 

### Issue

A message stating "Sorry, we're not able to serve you at the moment" is shown to the customers when they start a chart on the portal. The possible issues might be: 
- Agents not configured in the Queue: 
- Allowed Presence is not updated in the Live Work Stream: The default work streams which are shipped out-of-the-box, does not have **Allowed Presence** values in the Live Work stream.

   > [!div class=mx-imgBorder]
   > ![Sorry, we are not able to serve you at this moment message on portal chat widget](media/oceh/chat-widget-not-able-serve.png "Sorry, we are not able to serve you at this moment")

### Resolution:

 To configure agents in the queue, follow these steps:

 1. In the Omnichannel site map, go to **Queues & Users** > **Queues**
 2. Select the queue from the list.
 3. In the **Users (Agents)** section, select **Add Existing User **to add existing agents to the queue.
 4. On the **Lookup Records** pane, select the agents to add, and then select **Add**.
 5. Select **Save** to save the record.


To Update default **Allowed Presence** in the Live Work Stream, follow these steps:

1. In the Omnichannel site map, go to **Work Distribution Management > Work Streams**.
2. Select a record from the list.
3. In the Work Distribution tab, under the Work Distribution section, type **Available**. Select the check box to add it. Similarly, type **Busy** and then select the check box to add it.
4. Select **Save** to the record.