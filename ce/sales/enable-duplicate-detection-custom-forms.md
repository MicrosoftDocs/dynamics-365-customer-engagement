---
title: Enable duplicate lead detection for custom forms
description: Learn how to enable duplicate lead detection for custom forms in Dynamics 365 Sales.
author: udaykirang
ms.author: udag
ms.reviewer: shujoshi
ms.topic: how-to
ms.date: 04/13/2023
ms.custom: bap-template 
---

# Enable duplicate lead detection for custom forms

The duplicate lead detection feature in Dynamics 365 Sales helps detect duplicate leads. By default, this feature is enabled for the main lead form in the Sales Hub app. However, if you've customized the main lead form, you must manually enable duplicate lead detection.

> [!NOTE]
> This customization can be applied only to main forms of the `Lead` table in the custom app.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Enterprise, Dynamics 365 Sales Premium, or [Microsoft Relationship Sales](https://dynamics.microsoft.com/sales/relationship-sales/)<br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator<br>More information: [Predefined security roles for Sales](security-roles-for-sales.md) |

## Add an OnLoad event handler to the custom form

Add an event handler to the `OnLoad` event of the main lead form to enable duplicate detection on the form.

1. Sign in to the [Power Apps portal](https://make.powerapps.com/).
1. Search for and select your organization's environment. 
1. In the site map, select **Tables**, and then select the `Lead` table.
1. In the **Data experiences** section, select **Forms**, and then select your custom lead form of the *Main* type.
1. In the **Main form** pane that opens on the right, select the **Events** tab.
1. In the **On Load** section, select **+ Event Handler**.
1. In the **Configure Event** dialog box, select **+ Add library**.
1. Add the `DataHygiene/Data/salesdatahygiene_form_notification_library.js` library, and then select it in the list.
1. In the **Function** field, enter *Mscrm.LeadHygiene.DataHygieneNotificationLibrary.duplicateDetectionFormOnLoad*.
1. Select the **Pass execution context as first parameter** checkbox.
1. Select **Done**.

    :::image type="content" source="media/dld-add-onload-event-library.png" alt-text="Screenshot of the event configuration for the event handler for duplicate lead detection.":::

    In the **Handlers** section, notice that the required event handler has been added to the custom lead form.

1. Save and publish the form.

    Duplicate lead detection is now enabled for the custom form. You must now enable the duplicate lead detection feature from the Sales Hub app. [Learn how to enable duplicate lead detection.](enable-duplicate-lead-detection.md)

### See also

[Enable duplicate lead detection](enable-duplicate-lead-detection.md)  
[Manage duplicate leads](manage-duplicate-leads.md)
