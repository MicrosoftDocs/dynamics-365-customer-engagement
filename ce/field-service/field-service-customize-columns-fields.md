---
title: "Create and edit Field Service columns (fields)"
description: Learn about best practices for creating and editing fields in Dynamics 365 Field Service.
ms.date: 06/21/2024
ms.topic: how-to
author: lmasieri
ms.author: lmasieri
---

# Create and edit Field Service columns (fields)

You can add columns (also called fields) to the various tables (also called entities) that you use in Field Service. For example, work orders, bookable resource bookings, or customer assets. Mobile views can display up to three columns.

Follow these best practices when creating and editing columns:

- Understand existing columns and try to use them before creating new ones.
- Try editing field display names and labels.
- Don't edit field properties.
- Don't make required fields optional. But, you can make optional fields required.
- Don't delete existing fields.

> [!Important]
> Deleting fields can cause important processes to fail causing errors. Instead, hide or remove fields from the forms so that users can't see them.

This article uses the work order table as an example. However, the following guidance applies to all Field Service tables.

## Create new fields

> [!Important]
> Before editing existing fields, make sure you consider possible system implications. Review the documentation to help avoid potential performance or process disruption.

After understanding the existing fields and processes on the work order form, you can create more fields based on your unique business processes.

1. Sign in to `https://make.powerapps.com`.

1. Select your environment and navigate to the table. For example, the work order table.

1. Select **New** > **Column**. Enter the information for the new column.

   :::image type="content" source="media/customization-form-create-fields.png" alt-text="Screenshot of Power Apps, showing the Add column option on the work order table.":::

1. Save your changes.

## Edit fields

Administrators can edit the display names and labels of existing fields, but can't edit field properties.

For example, you can change the field display name of **Service Account** to **Customer**. Or consider the **System Status** field; you can change choice option labels, like changing the **In Progress** label to **Work Started**.

From the table, under **Schema**, select **Columns**. Select the column and select **Edit column**.

:::image type="content" source="media/customization-form-field-choice-option-set.png" alt-text="Screenshot of Power Apps Edit column option showing System Status.":::

Optional fields can be made required, but required fields can't be made optional.

### Edit field properties

> [!IMPORTANT]
> Don't edit field properties. Editing field properties can result in performance and process disruptions.

For example, editing fields in the following ways is unsupported and can cause issues when upgrading.

- Removing choice options.
- Adding choice options.
- Changing field requirement from _Required_ to _Optional_ (though it's okay to change from *Optional* to *Required*).
- Changing the behavior of a **Date Only** or **Date and Time** field is unsupported. They must be left as **User Local** and can't be set to _Date Only_ or _Time Zone independent_.

### Delete fields

> [!IMPORTANT]
> Don't delete existing fields as it can cause unexpected issues.

Instead of deleting a field, hide or remove fields from the forms so that users can't see them.

### Change the behavior of a Date and Time field

Don't change the behavior of a **Date Only** or **Date and Time** column that is included with Field Service. It isn't supported, isn't reversible, and can cause upgrade issues.
