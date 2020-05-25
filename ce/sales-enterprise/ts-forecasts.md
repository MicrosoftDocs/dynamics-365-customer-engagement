---
title: "Troubleshooting forecasting (Dynamics 365 Sales) | MicrosoftDocs"
description: "Learn how to troubleshoot issues with forecasting in Dynamics 365 Sales."
ms.date: 03/24/2020
ms.service:
  - "dynamics-365-sales"
ms.topic: article
author: shubhadaj
ms.author: shujoshi
manager: annbe
---

# Troubleshooting forecasting 

This article helps you troubleshoot and resolve issues related to forecasting.

<a name="territory_based_forecast_issues"> </a>
## Territory-based forecast issues and resolution

### Issue: An error is displayed when I try to create a territory-based forecast. 
### -Or-
### The data in a territory-based forecast is not refreshing.

**Reason:**

When system updates are performed, the territory entity's hierarchy is disabled (though you've enabled it earlier), which causes this error. 

**Resolution:**

To resolve this error, you must enable hierarchy in the **territory_parent_territory**<!--Edit okay? I imagine this isn't misspelled in the UI. --> relationship definition from **Relationships**. Follow these steps:

1.	Go to **Advance settings**. 
    
    The advance settings page opens in a tab.

2.	Select **Settings** > **Customization** > **Customizations**.
    
    The **Power Apps** settings page opens. 

3.	Select **Data** > **Entities**, and then select **Territory**.

    > [!div class="mx-imgBorder"]
    > ![Select the territory entity in Power Apps](media/forecast-troubleshooting-power-apps-select-territory.png "Select the territory entity in Power Apps")

4.	On the **Territory** page, select **Relationships** tab, and then select **Parent**.

    > [!div class="mx-imgBorder"]
    > ![Select the parent for the territory entity](media/forecast-troubleshooting-power-apps-select-territory-parent.png "Select the parent for the territory entity")
    
5.	In the **Many-to-one** dialog box, select to enable **Hierarchical**, and then select **Done**.

    > [!div class="mx-imgBorder"]
    > ![Enable Hierarchy option](media/forecast-troubleshooting-power-apps-select-enable-hierarchy.png "Enable Hierarchy option")
    
6.	Save and close the entity.

<a name="hide_forecast_category_field"> </a>
## Unable to hide the forecast category field in opportunity forms

**Reason**

Sometimes, the app displays the **Forecast category** field in opportunity forms, even after it has been configured as invisible by default through form customizations.

**Resolutions**

To resolve this error, you must delete the **Forecast category** field from the form. Follow these steps:

1.  In your app, on the nav bar, select the **Settings** icon, and then select **Advanced Settings**.

    > [!div class="mx-imgBorder"]
    > ![Advanced Settings on the Settings menu](media/advanced-settings-option.png "Advanced Settings on the Settings menu")

    The **Business Management** settings page opens in a new browser tab.

2. On the nav bar, select **Settings**, and then under **Customization**, select **Customizations**. 

3. Select **Customize the System**.

4. Under **Components** in the solution explorer, expand **Entities**, expand **Opportunity**, and then select **Forms**.

5. Open the **Opportunity** form of form type **Main**.

    The opportunity form opens in a new window.

6. In the **Summary** section, select the **Forecast category** field, and then select **Remove**. 

    > [!div class="mx-imgBorder"]
    > ![Remove the forecast category field](media/ts-forecasting-remove-forecast-category-field.png "Remove the forecast category field")

7. Save and publish the configuration.


### See also

[Dynamics 365 Sales troubleshooting guide](troubleshooting.md)  