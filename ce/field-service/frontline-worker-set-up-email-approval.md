---
title: Send frontline workers a download link for the mobile app
description: Learn how admins can enable the mailboxes of system admins to send emails to their frontline workers in Dynamics 365 Field Service.
ms.author: jacoh
author: jasonccohen
ms.subservice: field-service-mobile
ms.date: 08/27/2025
ms.topic: how-to
---

# Send frontline workers a download link for the mobile app

As a part of the [**Frontline Worker Set Up**](frontline-worker-set-up.md) process, admins can automatically send an email to their frontline workers with a link to download the Dynamics 365 Field Service mobile app. 

Field Service admins need approval to send email to their frontline workers. This article explains the steps to get approval through Power Platform.

## Prerequisites

- Your organization's admin must have a Microsoft 365 [administrator account](https://www.microsoft.com/microsoft-365/business/office-365-administration?rtc=1). Learn more in [admin permissions](/microsoft-365/admin/add-users/about-admin-roles?view=o365-worldwide&preserve-view=true).

## Step 1: Add the approve email addresses privilege for admins

Your organization's admin requires the **Approve Email Addresses for Users or Queues** privilege to receive access to their Dynamics 365 mailbox. A role administrator can assign the **Approve Email Addresses for Users or Queues** privilege to the **Security Role: System Admin**.

To manually assign the **Approve Email Addresses for Users or Queues** privilege to the **Security Role: System Admin**, follow these steps:

1. In the [Power Platform admin Center](https://admin.powerplatform.microsoft.com), select your organization's environment.

2. Select **Settings** > **Users + Permissions** > **Security roles**.

3. Select the **System Administrator** security role, and then select the **Business Management** tab.

4. Under **Miscellaneous Privileges**, set the privilege level for **Approve Email Addresses for Users or Queues**.

:::image type="content" source="./media/add-email-privileges-security-role-new.png" alt-text="Screenshot of adding approve email addresses in Power Platform admin center.":::

## Step 2: Approve mailboxes for system admins

1. In the [Power Platform admin center](https://admin.powerplatform.microsoft.com), select your organization's environment.

2. Select **Settings** > **Email** > **Mailboxes**.

3. Select **Active Mailboxes**.

4. Select the mailboxes you want to approve.

5. In the top bar, select **Approve Email** > **OK**.

6. Select **Test & Enable Mailbox** > **OK**.

:::image type="content" source="./media/test-mailbox-config-new.png" alt-text="Screenshot of testing mailbox configuration in Power Platform admin center.":::

6. If **Outgoing Email Status** displays **Success**, your organization's system admin can now automatically send emails to their frontline workers with a link to download the Dynamics 365 Field Service mobile app. This capability is through the [Quick Set Up: Frontline Worker form](frontline-worker-set-up.md).

:::image type="content" source="./media/mailbox_template.PNG" alt-text="Screenshot of the frontline worker email template in Field Service.":::

[!INCLUDE[footer-include](../includes/footer-banner.md)]