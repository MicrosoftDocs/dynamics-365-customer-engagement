---
title: Create properties and property templates
description: Learn how to use asset properties in Dynamics 365 Field Service.
ms.date: 01/25/2023
author: jshotts
ms.author: jasonshotts
ms.topic: how-to
ms.custom: bap-template
search.app: 
  - D365CE
  - D365FS
---

# Create properties and property templates

Properties record important information about customer assets. After you [define properties](#define-properties), you can [create property templates](#create-property-templates) to quickly and easily apply a set of properties to an asset or an entire category of assets.

Watch this short [video about how to create and configure asset properties](https://www.youtube.com/watch?v=dhruNqBXMgw).

## Define properties

Before you can assign values to properties, you need to define them.

1. In Field Service, select the **Settings** area. Under **Properties**, select **Property Definitions**, and then select **New**.

   :::image type="content" source="media/assets-properties-nav.png" alt-text="Screenshot of a list of active properties, with the New icon highlighted.":::

1. Enter the **Property Name** and select the **Property Type**: **Number**, **String** (alphanumeric), **Boolean** (true or false), or **Date/time**.
  
    :::image type="content" source="media/assets-properties-form.png" alt-text="Screenshot of a property definition.":::

1. Select **Save**.

## Create property templates

Use property templates to quickly select a group of properties to apply to an asset or a functional location. For example, laptops may always have the same set of properties that need to be captured.

1. In Field Service, select the **Settings** area. Under **Properties**, select **Templates for Properties**, and then select **New**.

1. Enter the **Template Name**, and then select **Save**.

1. In the **Properties** section, select **New Property Template Association**.

1. To associate an existing property with the template, search for and select it.
  
   If the property doesn't exist yet, select **New Property Definition** to create it. You'll need to return to this page to add the property to the template.

   :::image type="content" source="media/assets-properties-templates-properties-lookup.png" alt-text="Screenshot of the Property Template Association lookup pane.":::

1. To add another property to the template, select the caret to the right of **Save and Close**, and then select **Save & Create New**.

    :::image type="content" source="media/assets-properties-templates-properties-lookup-save-new.png" alt-text="Screenshot of the Property Template Association lookup pane, with the Save & Create New button highlighted.":::

1. When you're finished adding properties, select **Save and Close**.

   :::image type="content" source="media/assets-properties-templates-properties-only.png" alt-text="Screenshot of a template for properties.":::

## Associate asset categories with property templates

Associate a property template with an asset category to quickly add a set of properties to all records in the category.

1. In Field Service, select the **Settings** area. Under **Properties**, select **Templates for Properties**, and then select a template.

1. In the **Asset Categories** section, select **New Asset Category Template Association**.

1. To associate an existing asset category with the template, search for and select it.
  
   If the category doesn't exist yet, select **New Customer Asset Category** to create it. You'll need to return to this page to add the category to the template.

1. To add another category to the template, select the caret to the right of **Save and Close**, and then select **Save & Create New**.

1. When you're finished adding categories, select **Save and Close**.

   :::image type="content" source="media/assets-properties-templates.png" alt-text="Screenshot of the template for properties showing a related asset category.":::

## Associate assets with property templates

In addition to associating a property template with an asset category, you can associate a template with individual assets.

1. Open the customer asset record and select **Related** > **Asset Template Associations**.

1. Select **New Asset Template Association**.

1. To associate an existing property template with the asset, search for and select it.
  
   If the template doesn't exist yet, select **New Template for Properties** to create it. You'll need to return to this page to add the template to the asset.

1. To add another property template to the asset, select the caret to the right of **Save and Close**, and then select **Save & Create New**.

1. When you're finished adding templates, select **Save and Close**.

## Associate assets with properties

It's easy to assign a set of properties to a customer asset using a property template. Sometimes, however, you may want to add a property that's not part of a template, or add more properties on top of a property template.

1. Open the customer asset record and select **Related** > **Property Asset Associations**.

1. Select **New Property Asset Association**.

1. To associate an existing property with the asset, search for and select it.
  
   If the property doesn't exist yet, select **New Property Definition** to create it. You'll need to return to this page to add the property to the asset.

1. To add another property to the asset, select the caret to the right of **Save and Close**, and then select **Save & Create New**.

1. When you're finished adding properties, select **Save and Close**.

## Next steps

- [Add property logs](property-logs.md)
- [Build a service history for assets](service-history.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
