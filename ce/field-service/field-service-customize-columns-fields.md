---
title: "Create and edit columns (fields) in Dynamics 365 Field Service | MicrosoftDocs"
description: DESCRIPTION
ms.date: 02/09/2022
ms.reviewer: krbjoran
ms.service: dynamics-365-field-service
ms.topic: article
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: FieldServiceDave
ms.author: daclar
manager: shellyha
search.app: 
  - D365CE
  - D365FS
---

# Create and edit Field Service columns (fields)

When deploying Field Service, you may need to add new columns (also called fields) to the various tables (sometimes referred to as "entities") that you use, like work orders, bookable resource bookings, customer assets, and more.

Follow best practices when creating, editing, and deleting columns.

In this article, we'll discuss how to create, edit, and delete fields for the work order table; however, the following guidance applies to all Field Service tables.

## Create new fields

> [!Important]
> Before editing or deleting existing fields, make sure you consider possible system implications. Review the documentation to help avoid potential performance or process disruption.

After understanding the existing fields and processes on the work order form, you may need to create additional fields based on your unique business processes.

Go to `https://make.powerapps.com`.

To create a new field, select **+Add column**.

> [!div class="mx-imgBorder"]
> ![Power Apps, showing the "Add column" option on the work order table.](./media/customization-form-create-fields.png)


> [!div class="mx-imgBorder"]
> ![Power Apps showing the edit panel for a new column.](./media/customization-form-create-fields2.png)

Do not add new fields to the form yet, review the topic on [customizing Field Service forms](field-service-customize-forms.md) before doing so.

## Edit fields

Administrators can edit the display names and labels of existing fields, but can't edit field properties. 

For example, you can change the field display name of **Service Account** to **Customer**, as seen in the following screenshot.

> [!div class="mx-imgBorder"]
> ![Power Apps field editor panel, showing "Service Account" selected and editable.](./media/customization-form-field-display-name.png)

Or consider the **System Status** field; you can change choice option labels, like changing the **In Progress** label to **Work Started**. 

> [!div class="mx-imgBorder"]
> ![Power Apps field editor showing "WO System Status," with "Unscheduled" selected and editable.](./media/customization-form-field-choice-option-set.png)

Optional fields can be made required, but required fields cannot be made optional.

### Editing field properties

Don't edit field properties! Editing field properties can result in performance and process disruptions.

For example, editing fields in the following ways is unsupported and can cause issues when upgrading.

- Changing field types. for example, don't change the type of a field from _Date Only_ to _Date and Time_, or change a _Whole Number_ field to a _Decimal_ field. 
- Removing choice options.
- Adding choice options.
- Changing field requirement from _Required_ to _Optional_ (though it's okay to change from *Optional* to *Required*)

## Delete fields

Don't delete existing fields. Deleting fields can cause important processes to fail causing errors. You can simply hide or remove fields from the forms so that users cannot see them.

## Summary of recommended best practices

- Understand existing fields and try to use them before creating new ones
- Field display names and labels can be edited
- Field properties cannot be edited
- Optional fields can be made required, but required fields cannot be made optional.