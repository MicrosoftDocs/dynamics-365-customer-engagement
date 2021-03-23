---
title: How to set up Power Platform Mailbox 
description: How to set up Power Platform mailbox to send Frontline Workers 
author: xonatia
ms.service: dynamics-365-customerservice
ms.reviewer: krbjoran
ms.custom:
  - dyn365-fieldservice
ms.date: 04/01/2021
ms.topic: overview
 - field-service
ms.author: xolee
search.app:
  - D365CE
  - D365FS
---

# Set Steps to send FLW email notification???

As a part of the **Frontline Worker Set Up** process, admins have the ability to automatically send an email to their frontline workers with a link to download the Dynamics 365 Field Service mobile application. In order to use this capability, all admins must have their mailbox approved by their global admin through the Power Platform. Follow this documentation to learn the steps to approve an admin's mailbox through the Power Platform. 

## Prerequisities 
- You must have global admin privileges.

There are 2 ways to enable email address
Option1: Need to approve email address first
1. Need Office 365 Global admin or Exchange Admin role
2. Select Settings > Email Configuration > Mailboxes. Select Active Mailboxes.
3. Select the mailbox that you want to approve
4. Set the processing and synchronization fields as follows and save:
Server Profile: Microsoft Exchange Online
Incoming Email: Server-Side Synchronization or Email Router
Outgoing Email: Server-Side Synchronization or Email Router
5 Click Approve Email and select OK
6.Select Test & Enable Mailbox and select OK
7.If Outgoing Email Status is showing "Success", the send email checkbox will be enabled.

Option2: Remove requirement to approve mailboxes
1. Need Office 365 Global admin or Exchange Admin role
2. In the Power Platform admin center, select an environment.
3. Select Settings > Email > Email settings.
4. Under Security and permissions, Process emails only for approved users and Process emails only for approved queues to Off. These settings are enabled by default.
5. Select Save.
6. In Dynamics365 instance, select Settings > Email Configuration > Mailboxes. Select Active Mailboxes.
7. Select the mailbox that you want to enable
8. Set the processing and synchronization fields as follows and save:
Server Profile: Microsoft Exchange Online
Incoming Email: Server-Side Synchronization or Email Router
Outgoing Email: Server-Side Synchronization or Email Router
9.Select Test & Enable Mailbox and select OK
10.If Outgoing Email Status is showing "Success", the send email checkbox will be enabled.
