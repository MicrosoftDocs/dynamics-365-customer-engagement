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

The duplicate lead detection feature in Dynamics 365 Sales helps you to detect duplicate leads. This feature is enabled by default for standard lead forms. You can enable this feature for custom lead forms. 

>[!NOTE]
>Customizations can only be applied to custom apps for the main forms of leads.

## License and role requirements

| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Enterprise, Dynamics 365 Sales Premium, or [Microsoft Relationship Sales](https://dynamics.microsoft.com/sales/relationship-sales/)<br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator<br> More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## Add Onload event handler to the custom form

Add an event handler to the **OnLoad** event. When the **OnLoad** event handler is added, the duplicate lead detection feature is added to the form. Follow these steps:

1. Sign in to the [Power Apps](https://make.powerapps.com/) portal.  
1. Search for and select your organization's environment.   
1. From the site map, select **Tables** and then select the table.  
1. Under the **Data experiences** section, select **Forms** and then select the custom lead form you want to customize.  
    The custom lead form opens.
1. On the main form pane that opens on the right side, select the **Events** tab.   
1. Under the **On Load** section, select **+ Event Handler**.   
1. On the **Configure Event** dialog box, select **+ Add library**.
1. Add the **DataHygiene/Data/salesdatahygiene_form_notification_library.js** library and then select it from the list.  
1. In the **Function** name field, enter the **Mscrm.LeadHygiene.DataHygieneNotificationLibrary.duplicateDetectionFormOnLoad** value.
1. Enable **Pass execution context as first parameter**.
1. Select **Done**.  

    :::image type="content" source="media/dld-add-onload-event-library.png" alt-text="Screenshot of the event configuration for event handler for duplicate lead detection.":::

    Under the **Handlers** section, you can see the required event handler is added to the custom lead form.

1. Save and publish the form.

    If duplicate lead detection is enabled, you see a duplicate detection message on the custom lead forms when duplicate leads are detected.

### See also

[Enable duplicate lead detection](enable-duplicate-lead-detection.md)   
[Manage duplicate leads](manage-duplicate-leads.md)

