---
title: Customize forms
description: Learn how to use the form designer in Dynamics 365 Sales to customize the forms that your sellers use to enter and find information.
ms.date: 01/24/2023
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
ms.custom: 
  - dyn365-sales
  - bap-template
---

# Customize forms

In Dynamics 365 Sales, sellers use forms to interact with the data they need to do their work. It's important that the forms they use are designed to allow them to find or enter the information they need quickly. Use the form designer to customize the forms included with Dynamics 365 Sales to meet your sales organization's specific needs.

> [!IMPORTANT]
> You should only customize forms in the Sales app. Don't customize forms outside the app.

## License and role requirements

| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, or Dynamics 365 Sales Professional<br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Sales Manager, Sales Professional Manager, or Vice President of Sales <br>More information: [Predefined security roles for Sales](security-roles-for-sales.md) |

## How do forms relate to entities?

A form is a set of fields, or table columns, that match the information your organization tracks for an entity. For example, your organization might have columns in an Orders table that track customers' orders and their requested reorder dates. In this example, Orders is the entity and OrderNumber, Quantity, and ReorderDate are fields in a form that sellers use to manage reorders.

When you publish a customized form, you're publishing an updated version of the entity that's associated with the form.

## What forms can you customize?

You can customize any of the following forms in Dynamics 365 Sales:

- Account
- Contact
- Invoice
- Lead
- Opportunity
- Quote

## Customize the forms

Select the appropriate tab for your license:

# [Sales Premium and Sales Enterprise](#tab/SE)

1. Sign in to [Power Apps](https://make.powerapps.com/).

1. Follow the instructions in [Create and customize a model-driven app form](/powerapps/maker/model-driven-apps/create-and-edit-a-model-driven-form?context=/dynamics365/context/sales-context) to create or customize a form.  

# [Sales Professional](#tab/SP)

1. In the navigation panel, select **Sales Settings**.

1. Under **Customization**, select **Forms**.

    The page displays the date when the form was published and whether it's active or not.

1. To open a form, select the form in the **Name** column. Alternately, you can select a form, and then select **Edit** above the **Quick find** field.

For more information on creating forms, see [Create and design model-driven app forms](/powerapps/maker/model-driven-apps/create-design-forms).

To set a form as the default form in the app, see [Why isn't my form displayed as the default form in the app?](/powerapps/maker/model-driven-apps/create-design-forms#form-display-faq)



[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also

[Customize views](customize-views.md)  
[Customize business process flows](customize-business-process-flows.md)  
[Column-level security to control access](/power-platform/admin/field-level-security)

[!INCLUDE [footer-include](../includes/footer-banner.md)]
