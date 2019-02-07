---
title: Provision Omni-channel Engagement Hub | MicrosoftDocs
description: See how you can provision omni-channel engagement hub
keywords: Provision Omni-channel Engagement Hub
author: anjgupta
ms.author: anjgup
manager: shujoshi
applies_to: 
ms.date: 1/29/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: dcb07f11-106d-4368-87e9-015da0999f06
ms.custom: 
---

# Provision Omni-channel Engagement Hub

[!INCLUDE[cc-applies-to-update-9-0-0](../../includes/cc_applies_to_update_9_0_0.md)]

Omni-channel Engagement Hub is a cloud-based application that helps you extend the power of Microsoft Dynamics 365 for Customer Service. It lets customer service agents instantly connect to and engage with their customers, so that they can quickly resolve the queries.

Omni-channel Engagement Hub provides a modern, customizable, high-productivity app that lets agents help customers across different channels via a unified interface. It lets organizations choose the channel that suits their business needs. It also ensures that a high level of responsive, quality service is received across channels.

Omni-channel Engagement Hub enables the following channels and capabilities for Omni-channel users:

**Channels**

- [Chat](set-up-chat-widget.md)

**Capabilities**

- [Unified routing and work distribution](unified-routing-work-distribution.md)
- [Enhanced agent experience](../agent/agent-usd/omni-channel-engagement-hub-agent.md)

## Provision Omni-channel Engagement Hub application

Follow these steps to set up Omni-channel Engagement Hub.

**Step 1**: Get the Omni-channel Engagement Hub app.

   1. Sign up for the Omni-channel Engagement Hub preview from the [Dynamics Insider Portal](http://experience.dynamics.com/insider). 

   2. Once you receive a confirmation email from Microsoft, you can view the app in **Manage applications** in the **Dynamics 365 Administration Center**.
    
        > [!div class=mx-imgBorder]
        > ![provision omni-channel](../media/provision-oc.png)

**Step 2**: Set up Omni-channel Engagement Hub.

   1. In the **Dynamics 365 Administration Center**, select **Manage**.
      
        > [!div class=mx-imgBorder]
        > ![Manage omni-channel](../media/manage-oc.png)

       The **Manage Omni-channel Instances** page is displayed.

   3. On the **Manage Omni-channel Instances** page, select **Add Org** to add an organization. </br> Omni-channel is set up on the organization instance that you add here.
   
       > [!div class=mx-imgBorder]
       > ![manage instances](../media/manage-instances.png)

       > [!IMPORTANT]
       > As an admin, you can configure Omni-channel on multiple org instances. You can view the status of all org instances where the Omni-channel app has been configured in the **Manage Instances** view.

   3. Select the organization in the **Organization Selector** drop-down list. 

        > [!div class=mx-imgBorder]
        > ![select org](../media/select-org.png)

       
      You must select the checkboxes for **Microsoft Privacy Statement** and **Terms and Conditions** to accept the terms and proceed with the set up. You can read the privacy and preview conditions by selecting them in the **Terms & Conditions** section. 

        > [!div class=mx-imgBorder]
        > ![Preview terms](../media/preview-terms.png)
        
      Select **Continue** to proceed.

   4. Ensure that the check box to enable **Chat** channel on your org is selected by default. Select **Continue** to proceed.

       > [!div class=mx-imgBorder]
       > ![enable chat](../media/enable-chat.png)

       > [!NOTE]
       > In this preview, **Chat** check box is selected by default as this preview supports the set up of only the **Chat** channel. You cannot un-select the check box.
   
       Once the set up is completed successfully, you can see the **Chat** channel enabled on the **Summary** page.

      > [!div class=mx-imgBorder]
      > ![summary of set up](../media/summary-fre.png)


On successful set up, you can view the org and the enabled channel in the **Manage Instances** view.

> [!div class=mx-imgBorder]
> ![Set up complete](../media/install-complete.png)



### See also

[Assign roles and enable users for Omni-channel Engagement Hub](add-users-assign-roles.md)

[Manage users](users-user-profiles.md)

[Understand unified routing and work distribution](unified-routing-work-distribution.md)
