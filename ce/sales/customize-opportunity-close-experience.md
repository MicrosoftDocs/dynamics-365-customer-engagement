---
title: Customize the Opportunity Close form in Dynamics 365 Sales
description: Customize the opportunity close form so that sellers can capture details about why an opportunity was closed.
ms.date: 01/16/2024
ms.topic: how-to
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.custom: bap-template
content_well_notification:
  - AI-contribution
ai-usage: ai-assisted
---
# Customize the Opportunity Close form 

Customize the opportunity close form so that sellers can capture details about the closed opportunity such as reason for closure and profit margin. These details help sales managers to draw key insights and develop a better strategy.

## License and role requirements

| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, or Dynamics 365 Sales Professional <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br> More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

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

1. In the Sales Hub app, select the **Settings** icon, and then select **Advanced Settings**.

   :::image type="content" source="media/advanced-settings-option.png" alt-text="Screenshot of the Advanced Settings option in Sales Hub.":::

   > [!NOTE]
   > The **Advanced Settings** page is moving from the web client to an Unified Interface app. If your organization has enabled the public preview of the **Advanced settings redirection** feature you’ll see the settings open in the Power Platform Environment Settings app. Find more information about the app and navigation path in [Advanced settings in the new experience](advanced-settings-new-experience.md).

3. On the navigation bar of the **Business Management** page, select **Settings** > **Customizations**.

4. On the **Customization** page, select **Customize the System**.

### Step 2: Create a custom field in the Opportunity Close entity

The Opportunity Close entity has certain out-of-the-box fields. If the information you want to capture isn't available in the out-of-the-box fields, you can create a custom field. For example, if you want to capture the profit margin for all the won opportunities, you can create a new field called **Profit Margin**. 

> [!NOTE]
> If your organization is using a custom app, ensure that the Opportunity Close entity is added to the custom app module. [Learn more about adding an entity to a custom app module](/power-apps/maker/model-driven-apps/add-edit-app-components)

1. In the solution explorer, go to **Components** > **Entities** > **Opportunity** > **Opportunity Close** > **Fields**. The out-of-the-box fields are displayed.

1. On the **Actions** toolbar, select **New**, and enter a **Display Name** to generate the **Name**. [Learn more about how to create and edit columns](/powerapps/maker/data-platform/create-edit-fields).

1. Save the changes.

### Step 3: Add the field to the Opportunity Close form

1. In the solution explorer, go to **Components** > **Entities** > **Opportunity** > **Opportunity Close** > **Forms**.

1. Open the **Opportunity Close** form of type **Quick Create**.
1. Add or remove any fields, as required on the **Opportunity Close** form.
    > [!NOTE]
    > - You can’t delete or customize the out-of-the-box fields or entity relationships.
    > - Creating an Opportunity Close record (for example, from a related entity record or the Quick create menu) closes the related opportunity.
1. To add the same fields to the **Opportunity Close Information** form, open the **Information** form of type **Main**, and make the same changes that you did in Step 2. The **Opportunity Close Information** form is used to [view details of the closed opportunity](close-opportunity-won-lost-sales.md#view-details-entered-while-closing-an-opportunity) later on.
1. Save the changes.

### Step 4: Pre-populate values in the Opportunity Close form from the corresponding opportunity

To pre-populate values in the Opportunity Close form from the corresponding opportunity, map the fields in the Opportunity entity to the corresponding fields in the Opportunity Close entity. For example, if you want to pre-populate the estimated revenue of the opportunity in the Opportunity Close form, you can do so by adding the estimated revenue field to the Opportunity Close form and then mapping the field to the corresponding field in the Opportunity entity. This mapping also ensures that the values are synchronized between the two entities.

If you want to pre-populate or synchronize values from other entities, use a plug-in or a [client-side script to pre-populate and synchronize the values](/power-apps/developer/model-driven-apps/clientapi/walkthrough-write-your-first-client-script).

1. In the solution explorer, go to **Components** > **Entities** > **Opportunity** > **1:N Relationships**.
1. From the **Type** drop-down list, select **Mappable**.
1. Double-click the Schema name of the relationship **Opportunity_OpportunityClose**.

   :::image type="content" source="media/mappable-opportunity-close.png" alt-text="Screenshot of the Opportunity to Opportunity Close relationship mapping":::

1. In the **Relationship** window, Select **Mappings**.
1. Select **New** to create field mapping between the Opportunity and Opportunity Close fields.
1. Save the changes.

### Step 5: Publish the customizations

After you're done with the customizations, select **Publish All Customizations** on the toolbar to make the changes available to users. Open your app and verify the changes.


[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

## Related information
[Close opportunity as won or lost](close-opportunity-won-lost-sales.md)  
[Enable customization of the Opportunity Close form](enable-opportunity-close-customization.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]

