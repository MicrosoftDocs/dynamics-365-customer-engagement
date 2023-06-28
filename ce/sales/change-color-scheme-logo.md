---
title: "Set up branding and theming in Dynamics 365 Sales | MicrosoftDocs"
description: "Use themes in Dynamics 365 Sales to change the color scheme of your app to match your organization's branding guidelines."
ms.date: 11/18/2021
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
ms.custom: 
  - "dyn365-sales"
---

# Set up branding and theming

You can create a custom look and feel (a theme), for your app by making changes to the default colors and visual elements provided in the uncustomized system. For example, you can create your personal product branding by adding a company logo and providing table-specific coloring. The theme colors are applied globally throughout the application.

## License and role requirements
| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, or Dynamics 365 Sales Professional <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br> More information: [Predefined security roles for Sales](security-roles-for-sales.md)|


Depending on the Dynamics 365 Sales license you have, select one of the following tabs for specific information:

# [Sales Premium or Sales Enterprise](#tab/sales)

You can apply or create a theme in the Sales Hub app by selecting the **Settings** icon ![Settings icon.](media/settings-icon.png "Settings icon"), and then **Advanced settings** > **Customizations** > **Theme**. For more information on how to apply and create a new theme, go to [Use a theme to create a custom look for your app](/powerapps/maker/model-driven-apps/create-themes-organization-branding).

# [Sales Professional](#tab/salespro)

> [!IMPORTANT]
> This capability is introduced in the Dynamics 365 Sales Professional app version 9.1.0.0.

You can enhance the following visual elements in the UI:

-   Product logos

-   Background color for the navigation bar (defined by **Nav Bar color**)

-   Color for the command bar, buttons, and tabs (defined by **Main Color**)

-   Color for the process bar (defined by **Accent Color**)

## Apply a theme

The Dynamics 365 Sales app comes with three default themes that you can use. You can choose one of these default themes and apply it, or pick a custom theme that you have created.

**To apply a theme**:

1. In the site map, select **Sales settings**.

2. Under **Advanced settings**, select **Branding and theming**.

3. In the **Select Theme** list, select a theme. 

4. Select **Save**.

  The theme name currently being used is suffixed with the text "- Currently applied".

## Create a new theme

**To create a new theme**:

1.  In the site map, select **Sales settings**.

2.  Under **Advanced settings**, select **Branding and theming**.

3.  Select **Create new theme**.

4.  In the **Theme Name** field, enter a descriptive name for the new theme.

5.  To change the logo, select the pencil icon on the logo box, and then choose an image file of type JPG, PNG, GIF, or SVG format. The image file is converted to a web resource. 

    To revert to the default logo, select **Restore default logo**.

6.  Enter a tooltip for the logo.

7.  Choose colors in the **Nav Bar Color**, **Main Color**, and **Accent Color** boxes.

8.  Select **Save**.

  The theme name currently being used is suffixed with the text "- Currently applied".

---

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also

[Admin settings overview](admin-settings-overview.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
