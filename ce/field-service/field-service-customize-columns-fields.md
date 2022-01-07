---
title: "How to create and edit Field Service columns (fields) | MicrosoftDocs"
description: description
ms.custom:
- dyn365-fieldservice
ms.date: 01/05/2021
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.topic: article
ms.suite: ""
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
# How to create and edit Field Service columns (fields)


## 3. Create new fields as needed

After understanding the existing fields and processes on the work order form, you may need to create additional fields based on your unique business processes.

Go to https://make.powerapps.com 

Create new fields also called "columns" as needed.

Do not add them to the form yet.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/customization-form-create-fields.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/customization-form-create-fields2.png)

> [!Note]
> **Do not delete existing fields!** Deleting fields can cause important processes to fail causing errors. We will hide unwanted fields from the form later on.


## 5. Edit field display names and labels as needed

Edit the display names of fields or the labels of choices as needed. 

As an example, you can change the field display name of Service Account to Customer.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/customization-form-field-display-name.png)


As another example, for the _System Status_ field, you can change the labels of the choice options like changing the _In Progress_ label to _Work Started_. 

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/customization-form-field-choice-option-set.png)

> [!Note]
> **Do not edit field properties!** It is highly recommended to not edit the properties of existing fields. 

As an example, editing fields in the following ways is unsupported and can cause errors and issues when upgrading.

- Changing field types - As an example you should not change the type of a field from _Date Only_ to _Date and Time_, or change a _Whole Number_ field to a _Decimal_  
- Removing choice options
- Adding choice options
- Changing field requirement from _Required_ to _Optional_ (it is okay to change from Optional to Required)


## Create new columns (fields)

## Edit existing columns (fields)

## Delete columns (fields)

## Summary of recommended best practices