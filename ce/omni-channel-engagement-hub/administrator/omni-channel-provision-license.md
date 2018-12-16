---
title: "Provision Omni-channel Engagement Hub"
description: 
keywords: ""
author: anjgupta
ms.author: anjgup
manager: shujoshi
applies_to: 
ms.date: 11/13/2018
ms.service: 
ms.topic: article
ms.assetid: dcb07f11-106d-4368-87e9-015da0999f06
ms.custom: 
---

# Provision and License Omni-channel Engagement Hub

The Omni-channel Engagement Hub for Dynamics 365 is a cloud-based application that helps you extend the power of Dynamics 365 for Customer Service. It enables the customer service agents to instantly connect and engage with their customers and resolve their queries quickly. 

Quick engagement and problem solving with customers helps improve customer satisfaction. Omni-channel Engagement Hub provides a modern, customizable, high-productivity app that empowers agents to assist customers across different channels via a unified interface.

With the Omni-channel Engagement Hub, you can start a conversation with a support agent via social media and seamlessly transition to another channel like email, text, or chat. The Omni-channel Engagement Hub lets you choose the channel that suits your business needs and ensures that high responsiveness, and quality of service is received across channels.

As an administrator, you can provision Omni-channel Engagement Hub through the purchase of an add-on in office portal. 

You can set up the add-on from the Dynamics 365 Administration Center and start using it on 1 or more orgs. 

> [!NOTE]
> If you have set up a trial version, you should purchase the add-on license once the trial expires, else the application is suspended. 

The complete provisioning cycle for the omni-channel application can be explained as below:

![Provision and license cycle](../media/provision-cycle.png)

All system users who have an omni-channel license provisioned for themselves are referred to as omni-channel users. The licensed version of Omni-channel Engagement Hub provisions the following channels and capabilities for omni-channel users:

#### Channels
- Chat
- SMS
- Secure asynchronous messaging (enabled with Portal)

> [!NOTE]
> You can avail, install, and enable the above channels independent of each other.

#### Capabilities
- Routing & presence
- Profile & work distribution
- Enhanced agent and supervisor experience

Follow the steps to provision and license Omni-channel Engagement Hub:

**Step 1:** Provision the Omni-channel Engagement Hub package

**Step 2:** Enable Omni-channel Engagement Hub on an org

A. On the Manage Omni-channel Instances page, select Add Org to add an org and begin omni-channel installation. </br>

The First run experience wizard is displayed.

B. Select an org from the drop-down to begin the installation. 

C. Enable Unified Service Desk (USD) as part of omni-channel installation. </br>

   Select the checkbox to enable USD along with omni-channel organization.

> [!IMPORTANT]
> The minimum specific version of USD that is required for omni-channel is version 4.0. A single page application should be checked if USD is already installed in the org. 
If you have an older version of USD, then this installation will update the USD to the latest version.


D. Select the checkbox to enable Chat channel for your org.

E. Select the checkbox to enable SMS channel for your org.

F. Select the checkbox to enable Async Messaging channel for your org.

G. You can view the set-up progress on the Summary page.

   The following channels and capabilities are enabled for omni-channel as the install progresses:

- Routing
- Presence
- Agent profile
- Work distribution
- Unified Service Desk
- Chat
- SMS

Once the setup is complete, you receive an email with the status of the installation.

> [!NOTE]
> As an admin, you can view the orgs on which omni-channel is enabled on the Manage Instances page. 

For example, the following screen shows that all the channels and capabilities are correctly installed in the org.

**Step 3:** Set up the DNS for Omni-channel Engagement Hub

**Step 4:** Create users and assign system user roles

**Step 5:** License Omni-channel Engagement Hub