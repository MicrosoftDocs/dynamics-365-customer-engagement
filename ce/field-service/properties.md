---
title: "Properties in Dynamics 365 Field Service"
description: Learn how to use properties in Dynamics 365 Field Service.
ms.date: 12/09/2022
ms.reviewer: mhart
ms.topic: article
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: jshotts
ms.author: jasonshotts
manager: shellyha
search.app: 
  - D365CE
  - D365FS
---

# Properties in Dynamics 365 Field Service

In cases where field service organizations service assets or locations for their customers, it's important to be able to capture relevant information about those assets.

Properties allow you to record information about assets and functional locations in Dynamics 365 Field Service. After [creating the property definitions](#create-property-definitions), you can [define templates for properties](#create-templates-for-properties). When performing service tasks, technicians can fill in a [property log to create a log history](property-logs.md).

For a guided walkthrough, see this video: ![Video symbol](../field-service/media/video-icon.png "Video symbol") [Create and configure asset properties](https://youtu.be/dhruNqBXMgw)

## Create property definitions

Create the properties to use in your field service scenarios.

1. In Field Service, change to the **Settings** area.

1. Go to **Properties** > **Property Definitions**.

   :::image type="content" source="media/assets-properties-nav.png" alt-text="Screenshot of a list of active properties.":::

1. Select **+New**. Give the property a **Name** and select the type of **Value** for the property.

   - **Number**: Numeric values.  
   - **String**: Alphanumeric values.
   - **Boolean**: True or false.
   - **Date/time**: Date and time value.
  
   As an example, we'll use a laptop and create a new property called *RAM (GB)*, where the property value will always be a number.

   :::image type="content" source="media/assets-properties-form.png" alt-text="Screenshot of a property definition.":::

1. Select **Save and close**.

## Create templates for properties

Templates for properties let you quickly select a group of properties to apply to an asset a functional location. For example, laptops may always have the same set of properties that need to be captured.

1. In Field Service, change to the **Settings** area.

1. Go to **Properties** > **Templates for Properties**.

1. Select **+New**.

1. Give the template a **Name**, and **Save**.

1. In the **Properties** section, you can associate existing properties. Select New Property Template Association and add properties. In our example, we made a property template for laptops, which includes the following properties:

   - Temperature
   - Is active past 30 days
   - RAM (GB)
   - Processor

   :::image type="content" source="media/assets-properties-templates-properties-only.png" alt-text="Screenshot of a template for properties.":::

1. Select **Save and close**.

## Associate templates to assets, functional locations, or categories

From a property template, you can also associate assets, asset categories.md, functional locations, or location categories. By associating a template with a category, all records in that category use the property template.

1. In Field Service, change to the **Settings** area.

1. Go to **Properties** > **Templates for Properties** and select a template.

1. In the respective section, add the records to relate. For example, in the **Asset Categories** section, select **+New Asset Category Template** and select an existing category. In our example, we use an asset category for our laptop.

   :::image type="content" source="media/assets-properties-templates.png" alt-text="Screenshot of the template for properties showing a related asset category.":::

1. Select **Save and close**.

## Manually add properties

In some cases, you may need to manually add properties to records that don't belong to a template or add properties on top of template properties.  

1. Open the record and select **Related** > **Property Associations**.

1. Select **+Property Association**.

1. Select **Save and close**.

The property is now added to the list of eligible properties for this record.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
