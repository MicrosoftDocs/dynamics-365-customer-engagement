---
title: Send frontline workers email with link to download Dynamics 365 Field Service mobile app 
description: How global admins can enable the mailbox of system admins to send emails to their frontline workers
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

# Send frontline workers email with link to download Dynamics 365 Field Service mobile app

As a part of the [**Frontline Worker Set Up**](frontline-worker-set-up.md) process, admins have the ability to automatically send an email to their frontline workers with a link to download the Dynamics 365 Field Service mobile application. In order to use this capability, system admins must have their mailbox approved by their global admins through the Power Platform. Follow this documentation to learn the steps to approve the system admin's mailbox through the Power Platform. 

## Prerequisities 
- Your organization's global admin must have a Microsoft 365 [administrator account](https://www.microsoft.com/microsoft-365/business/office-365-administration?rtc=1). For more information, learn more about [admin permissions](https://docs.microsoft.com/microsoft-365/admin/add-users/about-admin-roles?view=o365-worldwide).

## Step 1: Add Approve Email Addresses privilege for System Admins

Your organization's system admin requires the **Approve Email Addresses for Users or Queues** privilege in order to receive access to their Dynamics 365 mailbox. A global admin can assign the **Approve Email Addresses for Users or Queues** privilege to the Security Role: System Admin. 

To manually assign the **Approve Email Addresses for Users or Queues** privilege to the Security Role: System Admin:

1. In the [Power Platform Admin Center](https://admin.powerplatform.com), select your organization's environment.

2. Select **Settings** > **Users + Permissions** > **Security roles**.

3. Select the **System Admin** security role, and then select the **Business Management** tab.

4. Under **Miscellaneous Privileges**, set the privilege level for **Approve Email Addresses for Users or Queues**.

> ![Screenshot of Adding Approve Email Addresses in Field Service.](./media/add_email_privileges_security_role.PNG)

## Step 2: Approve Mailboxes of System Admins

1. In the [Power Platform Admin Center](https://admin.powerplatform.com), select your organization's environment.

2. Select **Settings** > **Email** > **Mailboxes**.

3. Select **Active Mailboxes**.

4. Select the **mailboxes** that you want to approve > **More Commands (…)** > **Approve Email** > **OK**.

6. Select **Test & Enable Mailbox** > **OK**.

> ![Screenshot of Testing Mailbox Configuration in Field Service.](./media/test_mailbox_config.PNG)

7. If **Outgoing Email Status** displays **Success**, your organization's system admin can now automatically send emails to their frontline workers with a link to download the Dynamics 365 Field Service mobile application through the [Quick Set Up: Frontline Worker form](frontline-worker-set-up.md).

> ![Screenshot of Frontline worker Email Template in Field Service.](./media/email_template.PNG)

