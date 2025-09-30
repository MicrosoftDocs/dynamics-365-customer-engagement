---
title: Configure sensitivity labels in emails (preview)
description: Learn how to configure sensitivity label support for emails in Dynamics 365 Customer Service and Dynamics 365 Contact Center.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection: 
ms.date: 09/21/2025
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

1. In Power Apps, for your solution, select **Tables** > **Email**.  
2. Select **Forms** and then select the required email form.  
3. Add the **Sensitivity Label** table column to the form. Learn more in [Add column to a form](/power-apps/maker/model-driven-apps/add-field-form).  
4. In the **Properties** pane for **Sensitivity Label**, do the following:  
   - Select the **Hide Label** checkbox.  
   - Set the **Form field width** in **Formatting** to 2 columns.  
   - In **Components**, add the **Email sensitivity label control**. Learn more in [Add components for a column on the form](/power-apps/maker/model-driven-apps/add-control-field).  
5. Save and publish your changes.  

## Set email data sensitivity labels

1. In the app, go to **Settings** > **Advanced Settings**.
2. Select **System** > **Email configuration**. The Email Configuration page appears.
3. Select **Email Settings**. The **System Settings** page appears.
4. Select the **Email** tab, scroll down to the **Set email sensitivity labels** section, and then select **Enable email sensitivity labels**.
1. Select **Ok**.


### Related information 

[Use sensitivity labels in emails(preview)](../use/use-sensitivity-labels.md)