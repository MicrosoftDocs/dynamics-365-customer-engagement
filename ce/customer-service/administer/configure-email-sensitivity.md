---
title: Configure sensitivity labels in emails
description: Learn how to configure sensitivity label support for emails in Dynamics 365 Customer Service and Dynamics 365 Contact Center.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection: 
ms.date: 04/14/2026
---

# Configure sensitivity label support for emails

You can configure sensitivity labels in Dynamics 365 Customer Service and Contact Center to ensure email communications comply with your organization’s security and compliance policies. These labels help protect sensitive information and keep attachments, replies, and forwards aligned with organizational rules.

## Prerequisites

- Sensitivity labels are created and configured in the Microsoft Purview portal. Learn more in [Create and configure sensitivity labels](/purview/create-sensitivity-labels?tabs=classic-label-scheme).
- An email server profile with **Server-to-Server Authentication (Same Tenant)** is configured for Exchange Online. Learn more in [Connect to Exchange Online](/power-platform/admin/connect-exchange-online).
- Server side synchronization is set up for email. Learn more in [Set up server-side synchronization for email](/power-platform/admin/set-up-server-side-synchronization-of-email-appointments-contacts-and-tasks).
- The Microsoft Entra ID user associated with the mailbox must have access to the required sensitivity labels in Microsoft Purview. Learn more in [Permissions in the Microsoft Purview portal](/purview/purview-permissions).

## Enable email data sensitivity labels

Before you add sensitivity labels to the email form, enable email data sensitivity labels in the environment.

Perform the following steps:

1. Go to **Copilot Service admin center**.
1. Select **Settings** (gear icon), and then select **Advanced Settings**.
1. Go to **Email Configuration** > **Email settings**.
1. On the **System Settings** page, select the **Email** tab.
1. In the **Email data sensitivity** section, select **Enable data sensitivity labels for emails**.

   :::image type="content" source="../media/enable-data-sensitivity-labels-emails.png" alt-text="Screenshot of the Enable data sensitivity labels for emails checkbox on the System Settings page.":::

1. Select **OK**.

## Add the sensitivity label column to email form

To display sensitivity labels in emails, add the **Sensitivity label** column and control to the email form in Power Apps.

Perform the following steps:

1. Go to [Power Apps](https://make.powerapps.com).
1. Select the environment.
1. In the navigation pane, select **Solutions**.
1. Open **Default Solution**.
1. Select **Table**, and then select the **Email** table.
1. Select **Forms**, and then open the main email form.
1. In the form designer, select **Columns**.
1. Search for **Sensitivity label**.
1. Drag the **Sensitivity label** column onto the form canvas.
1. Select the **Sensitivity label** column on the form.
1. In the properties pane, select **Component** > **More components**.   
1. Search for and select **Email sensitivity label control**, and then select **Add**.
   
   :::image type="content" source="../media/email-sensitivity-label-control.png" alt-text="Screenshot of the email sensitivity label control properties.":::
   
1. Configure the control properties as required.
1. Select **Done**.
1. Select **Save and publish**.

### Related information 

[Use sensitivity labels in emails](../use/use-sensitivity-labels.md)
