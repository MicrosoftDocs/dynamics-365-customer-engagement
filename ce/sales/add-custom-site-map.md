---
title: Add site map entry to custom app
description: Learn how to add a site map entry to your custom app in a few simple steps.
ms.date: 02/02/2024
ms.topic: how-to
author: udaykirang
ms.author: udag
ms.owner: shujoshi
ms.custom: bap-template
---

# Add site map entry to custom app

When you create a custom model-driven app, you can choose a default solution to create a sitemap for the app. However, the list contains solutions that are based on entity forms only. More information: [Create a model-driven app site map using the site map designer](/power-apps/maker/model-driven-apps/create-site-map-app).

## License and role requirements
| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise  <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator or similar role<br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## Add the site entry

In this procedure, we're using URL to add a site map entry.

1. Sign in to [Power Apps portal](https://make.preprod.powerapps.com/).
1. On the left navigation pane, select **Apps**.
1. Select the app and then select **Edit**.
1. In the custom app edit page, from the **Navigation** section, hover over the group name for which you want to add the site map entry and then select **New page**.
1. In the **New page** dialog box, select an option according to your requirement. Here, we are adding the site map entry using a **URL**.
1. Select **Next**.
1. Enter the following URL information and title depending on the feature:
    
    | Feature name                | URL                                                                                             |
    |-----------------------------|-------------------------------------------------------------------------------------------------|
    | Administrator settings overview page | `/main.aspx?pagetype=control&controlName=MscrmControls.FieldControls.CCFadminsettings` |
    | Forecast grid               | `/main.aspx?pagetype=control&controlName=ForecastingControls.FieldControls.ForecastGridPage` |
    | Forecast configuration      | `/main.aspx?pagetype=control&controlName=ForecastingControls.FieldControls.CCFForecastConfig` |
    | Sales accelerator           | `/main.aspx?pagetype=control&controlName=MscrmControls.AcceleratedSales.AnchorShellControl` |
    
1. Select **Add**.
1. Save and publish the custom app.

The site map entry is added to your custom app.

### See also

[Customize the app](manage-app.md)