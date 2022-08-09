---
title: Modify quick view forms for the Dynamics 365 Sales mobile app
description: Learn to modify quick view forms for the Dynamics 365 Sales mobile app.
ms.date: 08/09/2022
ms.topic: article
author: sbmjais
ms.author: shjais
manager: shujoshi
---

# Modify quick view forms 

The Dynamics 365 Sales mobile app uses the quick view form to display table details. This is a lightweight form that doesn't include all attributes of the table. More information: [Create a quick view form](/powerapps/maker/model-driven-apps/create-edit-quick-view-forms)

## License and role requirements
| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, Dynamics 365 Sales Professional, or Microsoft Relationship Sales <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System administrator <br>  More information: [Predefined security roles for Sales](../security-roles-for-sales.md)|


## How does quick view form work for the mobile app?

If you've created multiple quick view forms, the mobile app uses the first form in the quick view form order. In the following example, three quick view forms were created for the **Contacts** table with the form order as shown.

|Form order|Form name|
|----------|---------|
|1|Contact quick view form one|
|2|Contact quick view form two|
|3|Contact quick view form three|


In this example, the mobile app displays information based on the fields defined in **Contact quick view form one**.

If you want to change the fields that the mobile app displays, modify the first quick view form in the form order. If you want a different quick view form to be used for displaying information, move that form to the top of the form order. More information: [Set the form order](/powerapps/maker/model-driven-apps/control-access-forms#set-the-form-order)

> [!NOTE]
> When you modify a quick view form, the changes take up to 6 hours to reflect in the mobile app.

## Use Unified Interface forms to view and update records

If you want table details to be viewed, created, and updated using Unified Interface forms in the Dynamics 365 mobile app, you can enable the functionality through Power Platform admin center. You can also choose to completely disable the quick create functionality from the mobile app.

1. Sign in to [Power Platform admin center](https://admin.powerplatform.microsoft.com/).

2. In the **Environments** tab, select the environment for which the settings need to be changed.

3. Go to **Settings** > **Product** > **Features**.

4. In the **Dynamics 365 Sales mobile app** section, turn on the toggles as needed:

    - **Create new records and activities using Unified Interface forms instead of quick view forms**: Allows the mobile app to use the Unified Interface forms for creating new records.

    - **Disable the option to quick create new records and activities in the Mobile application**: Disables the quick create functionality. This toggle is enabled only when the **Create new records and activities using Unified Interface forms instead of quick view forms** toggle is turned on.

    - **Edit and view records and activities using Unified Interface forms instead of quick view forms**: Allows the mobile app to use Unified Interface forms for viewing and editing entities.

    :::image type="content" source="media/ppac-sm-settings.png" alt-text="Update settings for Dynamics 365 Sales mobile app":::


### See also

[Use the Dynamics 365 Sales mobile app](use-sales-mobile-app.md)    
[Learn the basics](learn-basics-mobile-app.md)
