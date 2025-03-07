---
title: Customize the business card scan control
description: Customize how the data from the scanned business cards maps to the fields in the Contact and Lead forms.
ms.date: 01/31/2025
ms.topic: how-to
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
---

# Customize the business card scanner control
 
Customize how the data from the scanned business cards maps to the fields in the **Contact** and **Lead** forms.

## Customize the mapping

Dynamics 365 Sales comes with an out-of-the-box business card control that defines the mapping of what information from the business card goes in which fields of the **Contact** or **Lead** forms. If you have custom fields on your **Contact** or **Lead** form and you want the data from the business card to be populated in these fields, edit the default mappings of the business card control.

> [!IMPORTANT]
> - To learn about the availability of the business card feature in a region, see [Feature availability by region](/ai-builder/availability-region#availability-and-release-status-of-features-by-region).
> - To know about the business card scan limits with your user license, see the [Microsoft Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/p/?LinkId=866544).

To customize the mappings:

1. In the sales app, go to **Settings** > **Advanced Settings**.  

    :::image type="content" source="media/advanced-settings-option.png" alt-text="Screenshot of the Advanced Settings option on the Settings menu.":::

1. Go to **Customization** > **Customizations** > **Customize the System**.  
1. In the left pane, expand **Tables** and then the **Contact** or **Lead** entity, and select **Forms**.

    >[!NOTE]
    >If you are using the classic view, under **Components**, expand **Entities**, and then the **Contact** or **Lead** entity, and select **Forms**.

1. Open the quick create form. For example, for contact, the **Contact Quick Create** form.  
1. Locate and select the **Business Card** field on the form.  
    The business card properties opens in the right pane.  
1. In the **Properties** tab, go to the **Components** section and select **AI Builder Business Card control**.  
1. Select the property that you want to change the mapping for, and select **Done**.  
1. Save and publish the form.  
1. Assign the **Basic User** security role in Power Platform to the salespeople who will use the business card scanner control. For more information, see [Assign security roles to users in a Dataverse environment](/power-platform/admin/database-security#assign-security-roles-to-users-in-an-environment-that-has-a-dataverse-database) or [Assign security roles to users in non-Dataverse environment](/power-platform/admin/database-security#assign-security-roles-to-users-in-an-environment-that-has-no-dataverse-database).  

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

## Related information

[Scan business cards](scan-business-cards.md)  
[Use the business card reader in model-driven apps](/ai-builder/business-card-reader-component-model-driven)
