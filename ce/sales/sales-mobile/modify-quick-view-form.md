---
title: Manage forms
description: Manage quick view forms or use Unified Interface forms in the Microsoft Dynamics 365 Sales mobile app.
ms.date: 02/27/2023
ms.topic: article
author: sbmjais
ms.author: shjais
manager: shujoshi
---

# Manage forms

The Dynamics 365 Sales mobile app uses quick view forms by default to display tables. A quick view form is a lightweight view that doesn't include all the attributes of the table. [Create or edit a quick view form](/powerapps/maker/model-driven-apps/create-edit-quick-view-forms).

You can [use Unified Interface forms](#use-unified-interface-forms) in the Sales mobile app instead of quick view forms. You need to turn on this option in the Power Platform admin center.

## License and role requirements

You must have the following licenses and security roles to manage forms in the Sales mobile app.

| Requirement type | You must have |
| ---------------- | ------------- |
| **License** | Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, Dynamics 365 Sales Professional, or Microsoft Relationship Sales <br>For more information, refer to [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/). |
| **Security roles** | System administrator <br>For more information, refer to [Predefined security roles for Sales](../security-roles-for-sales.md). |

## Manage quick view forms

If you've created multiple quick view forms, the Sales mobile app uses the first one in the form order.

For example, here we've created three quick view forms for the **Contacts** table, ordered as shown:

| Form order | Form name |
| ---------- | --------- |
| 1 | Addresses |
| 2 | Various contacts |
| 3 | Contact details |

The mobile app displays information based on the fields defined in **Addresses** since it's first in the list.

To change the fields the mobile app displays, modify the first quick view form in the list.

The order of the input fields in the mobile app is determined by their field types as follows:

1.	Title (represents the primary attribute for the entity)
2.	Text inputs without icons (String, Money, Integer)
3.	Text inputs with icons (String, Money, Integer)
4.	Value selection inputs (DateTime)
5.	Assign inputs (State, SubGrid, PickList, PartyList, Lookup, Customer)
6.	Multiline (Memo)


> [!NOTE]
> When you [modify a quick view form](/powerapps/maker/model-driven-apps/create-edit-quick-view-forms), the changes may take up to six hours to appear in the mobile app.

To change which quick view form the mobile app uses to display tables, [set the form order](/powerapps/maker/model-driven-apps/control-access-forms#set-the-form-order) so that the form you want is first in the list.

## Use Unified Interface forms

To view, create, and update tables using Unified Interface forms instead of quick view forms, you need to change some settings in the Power Platform admin center. You can also turn off the mobile app's quick create functionality.

1. Sign in to [Power Platform admin center](https://admin.powerplatform.microsoft.com/).

2. In the **Environments** tab, select your environment.

3. Go to **Settings** > **Product** > **Features**.

4. In the **Dynamics 365 Sales mobile app** section, turn on the following settings as needed:

    - **Create new records and activities using Unified Interface forms instead of quick view forms**: Allows the mobile app to use Unified Interface forms for creating records and activities.

    - **Disable the option to quick create new records and activities in the Mobile application**: Turns off the quick create functionality in the mobile app. Available only when **Create new records and activities using Unified Interface forms instead of quick view forms** is turned on.

    - **Edit and view records and activities using Unified Interface forms instead of quick view forms**: Allows the mobile app to use Unified Interface forms for viewing and editing records and activities.

    :::image type="content" source="media/ppac-sm-settings.png" alt-text="Screenshot of the Dynamics 365 Sales mobile app settings.":::

### See also

[Use the Dynamics 365 Sales mobile app](use-sales-mobile-app.md)  
[Learn the basics](learn-basics-mobile-app.md)  
[Create or edit a quick view form](/powerapps/maker/model-driven-apps/create-edit-quick-view-forms)
