---
title: Configure sensitivity labels in emails (preview)
description: Learn how to configure sensitivity label support for emails in Dynamics 365 Customer Service and Dynamics 365 Contact Center.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection: 
ms.date: 04/09/2026
---

# Configure sensitivity label support for emails (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

You can configure sensitivity labels in Dynamics 365 Customer Service and Contact Center to ensure email communications comply with your organization’s security and compliance policies. These labels help protect sensitive information and keep attachments, replies, and forwards aligned with organizational rules.

[!INCLUDE [preview-banner](../../../shared-content/shared/preview-includes/production-ready-preview-dynamics365.md)]


## Prerequisites

- Sensitivity labels are created and configured in the Microsoft Purview portal. Learn more in [Create and configure sensitivity labels](/purview/create-sensitivity-labels?tabs=classic-label-scheme).
- An email server profile with **Server-to-Server Authentication (Same Tenant)** is configured for Exchange Online. Learn more in [Connect to Exchange Online](/power-platform/admin/connect-exchange-online).
- Server side synchronization is set up for email. Learn more in [Set up server-side synchronization for email](/power-platform/admin/set-up-server-side-synchronization-of-email-appointments-contacts-and-tasks).
- The Microsoft Entra ID user associated with the mailbox must have access to the required sensitivity labels in Microsoft Purview. Learn more in [Permissions in the Microsoft Purview portal](/purview/purview-permissions).

## Enable sensitivity labels on email form

Perform the following steps:

1. Go to **Power Apps**, and then open the default solution.
1. Select **Email**, and then open the **Email form**.
1. Add the **Sensitivity label** field to the Email form.
1. Select the field, and then do the following steps:
   1. Select **Component**.
   1. Select **Get more component**.
   1. Choose **Email sensitivity label control**.
   1. Select **Add**.
   1. Select the control, and then select **Done**.
1. Save and publish your changes.
 

## Set email data sensitivity labels

1. In the app, go to **Settings** > **Advanced Settings**. The **System Settings** page appears.
1. 1. Select the **Email** tab. 
1. In the **Set Email data sensitivity** section, select the checkbox for for **Email data sensitivity labels for emails**.
1. Select **OK**.

### Related information 

[Use sensitivity labels in emails(preview)](../use/use-sensitivity-labels.md)
