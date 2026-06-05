---
title: Customize the Opportunity Close form
description: Customize the opportunity close form so that sellers can capture details about why an opportunity was closed.
ms.date: 06/05/2026
ms.topic: how-to
author: lavanyakr01
ms.author: ramakris
ms.reviewer: ramakris
ms.custom: bap-template
ai-usage: ai-assisted
---
# Customize the Opportunity Close form 

Customize the opportunity close form so that sellers can capture details about the closed opportunity such as reason for closure and profit margin. These details help sales managers to draw key insights and develop a better strategy.

## Prerequisites

- [Enable customization of the Opportunity Close form](enable-opportunity-close-customization.md)
- Customizations are only supported on apps built on Unified Interface. If you're using a custom app, ensure that it's built on Unified Interface.

## How to customize the Opportunity Close form

1. [Open the solution explorer page](#step-1-open-the-solution-explorer-page)  

1. [Create a custom field in the Opportunity Close entity](#step-2-create-a-custom-field-in-the-opportunity-close-entity)
1. [Add the field to the Opportunity Close form](#step-3-add-the-field-to-the-opportunity-close-form)
1. [Pre-populate values in the Opportunity Close form from the corresponding opportunity](#step-4-pre-populate-values-in-the-opportunity-close-form-from-the-corresponding-opportunity)
1. [Publish the customizations](#step-5-publish-the-customizations)

### Step 1: Open the solution explorer page

The solution explorer page is where you can create and manage customizations.

1. In the sales app, go to **Settings** > **Advanced Settings**.  

    :::image type="content" source="media/advanced-settings-option.png" alt-text="Screenshot of the Advanced Settings option on the Settings menu.":::

1. Go to **Customization** > **Customizations** > **Customize the System**.  

### Step 2: Create a custom field in the Opportunity Close entity

The Opportunity Close entity has certain out-of-the-box fields. If the information you want to capture isn't available in the out-of-the-box fields, you can create a custom field. For example, if you want to capture the profit margin for all the won opportunities, you can create a new field called **Profit Margin**. 

> [!NOTE]
> If your organization is using a custom app, ensure that the Opportunity Close entity is added to the custom app module. [Learn more about adding an entity to a custom app module](/power-apps/maker/model-driven-apps/add-edit-app-components)

1. In the left pane, expand **Tables** and then **Opportunity Close**, and select **Forms**.

    >[!NOTE]
    >If you are using the classic view, under **Components**, expand **Entities**, and then **Opportunity Close** entity, and select **Forms**.

1. Select the form to which you want to add the custom field.  

1. On the **Table columns** pane, select **+ New table column**, and enter a **Display Name** to generate the **Name**. [Learn more about how to create and edit columns](/powerapps/maker/data-platform/create-edit-fields).  
1. Save and publish the form.  
    When a field is added to the form, it's available for other forms of the same entity.

### Step 3: Add the field to the Opportunity Close form

1. Open the **Opportunity Close** form.  
1. Add the field to forms as required.  
    - For the **Quick Create** form type  
        1. Add fields as required to the quick create opportunity close form.  
             > [!NOTE]  
             > - You can’t delete or customize the out-of-the-box fields or entity relationships.  
             > - Creating an Opportunity Close record (for example, from a related entity record or the Quick create menu) closes the related opportunity.  
        1. Save and publish the form.  
    - For the **Main** form type  
         1. Add fields as required to the main opportunity close form as added to the quick create form.  
         1. Save and publish the form.  
        The **Information** form (main) is used to [view details of the closed opportunity](close-opportunity-won-lost-sales.md#view-details-entered-while-closing-an-opportunity) later on.

### Step 4: Pre-populate values in the Opportunity Close form from the corresponding opportunity

To pre-populate values in the Opportunity Close form from the corresponding opportunity, map the fields in the Opportunity entity to the corresponding fields in the Opportunity Close entity. For example, if you want to pre-populate the estimated revenue of the opportunity in the Opportunity Close form, you can do so by adding the estimated revenue field to the Opportunity Close form and then mapping the field to the corresponding field in the Opportunity entity. This mapping also ensures that the values are synchronized between the two entities.

If you want to pre-populate or synchronize values from other entities, use a plug-in or a [client-side script to pre-populate and synchronize the values](/power-apps/developer/model-driven-apps/clientapi/walkthrough-write-your-first-client-script).

1. In the solution explorer, go to **Tables** > **Opportunity** and under the Schema section, select **Relationships**.
1. Open the **Opportunity_OpportunityClose** relationship schema with the **One-to-many** relationship type.  
1. In the **Relationship** window, Select **Mappings**.
1. Select **New** to create field mapping between the Opportunity and Opportunity Close fields.
1. Save the changes.

### Step 5: Customize Status Reason fields

The Opportunity entity has the following statuses, which aren't customizable: **Open**, **Won**, **Lost**. However, you can add multiple status reasons corresponding to the Won and Lost statuses. Consider the following points while customizing the status reason fields:

- If you add custom values to a **Status Reason** field against a state (Won/Lost) in the Opportunity entity, you must add the same custom value to the special attribute **OpportunityStatusCode** on the Opportunity Close entity manually, and vice versa. This ensures the correct customized values with the right defaults appear preselected for each opportunity Win and Loss state.
- There are two fields on the Opportunity Close entity with the display name **Status Reason** but with different schema names: `statuscode` and `opportunitystatuscode`. Custom status reasons should be added to the `opportunitystatuscode` attribute, not to the `statuscode` attribute.

### Step 6: Publish the customizations

After you're done with the customizations, select **Publish All Customizations** on the toolbar to make the changes available to users. Open your app and verify the changes.

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

## Troubleshoot common issues

### Quick Create form doesn't appear when closing an opportunity

If the **Main** form appears instead of the **Quick Create** form when you close an opportunity:

1. Verify that the **Custom fields on closing form** toggle is set to **Yes** in Sales Hub. Go to **App Settings** > **General Settings** > **Lead + Opportunity management** > **Opportunity Closing**.
1. In **Advanced Settings**, go to **Administration** > **System Settings** > **Sales** tab, and confirm **Customize close opportunity form** is set to **Yes**.
1. In the solution explorer, go to **Entities** > **Opportunity Close** > **General** tab and verify that both **Allow quick create** and **Enable for Unified Client** are enabled.
1. If the settings are correct in one environment but the issue occurs only in production, compare the **Opportunity Close** entity configuration across environments.

### Custom fields don't appear on the Opportunity Close form

If you added custom fields to the Opportunity Close form but they don't appear in the app:

1. Ensure that the **Opportunity Close** entity is added to your custom app module. In the app designer, select **Add** > **Entities**, search for **Opportunity Close**, add it, and then select **Include entity metadata**.
1. After adding the entity, publish the app again.

### "Selected entity is not valid for this client" error

If you receive this error when you enable the **Custom fields on closing form** toggle and try to close an opportunity:

1. Verify that your app is built on Unified Interface. The Opportunity Close form customization is only supported in Unified Interface apps.
1. Ensure that the **Opportunity Close** entity is added to your custom app module with all assets included.
1. Check for any unmanaged solution layers on the Sales Hub app that might override the configuration. Go to **Settings** > **Advanced Settings** > **Customizations** > **Customize the System** > **Client Extensions**, select the affected app, and review the solution layers.

### Custom status reasons don't appear in the close form

If you added new status reason values to the Opportunity Close entity but they don't appear in the form:

1. Verify that the custom values were added to the `opportunitystatuscode` attribute (not the `statuscode` attribute) on the Opportunity Close entity.
1. Ensure that matching values exist on both the Opportunity entity's **Status Reason** field and the Opportunity Close entity's `opportunitystatuscode` attribute.
1. Check for and remove any unmanaged layers that might be overriding the field options.
1. Publish all customizations and clear your browser cache.

### Customization option is missing from settings

If you can't find the option to enable Opportunity Close form customization:

1. In Sales Hub, go to **App Settings** > **General Settings** > **Lead + Opportunity management** > **Opportunity Closing**.
1. If the option isn't visible, check for an active solution layer on the app that might hide it. Go to **Settings** > **Advanced Settings** > **Customizations** > **Customize the System** > **Client Extensions**, select the Sales Hub app, and review and remove any blocking solution layer.

### Errors when closing an opportunity with custom form

If you receive errors when closing an opportunity after customizing the form, the issue might be caused by customizations on the **Quick Create** form. Try the following:

1. Disable any custom JavaScript or business rules on the Opportunity Close form temporarily to isolate the issue.
1. If you have customizations on the **Opportunity Line Quick Create** form, review them for conflicts.
1. Verify that all required fields have valid values before closing.

## Related information

[Close opportunity as won or lost](close-opportunity-won-lost-sales.md)  
[Enable customization of the Opportunity Close form](enable-opportunity-close-customization.md)
