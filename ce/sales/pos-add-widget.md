---
title: "Add the opportunity scoring widget to a form"
description: Learn how to display the predictive opportunity scoring widget on your custom forms.
ms.date: 10/11/2022
ms.custom: 
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
---

# Add the opportunity scoring widget to a form

By default, the predictive opportunity scoring widget is available only in the out-of-the-box **Sales Insights** form. If you're using customized forms for opportunities, you can display the predictive opportunity scoring widget on your custom forms by following these steps.

> [!IMPORTANT]
> - Adding opportunity scoring widgets is only supported in Unified Interface apps.
> - You can't use the legacy form designer to add an opportunity scoring widget to a form.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## Add the opportunity scoring widget to a custom form

1. Sign in to the [Power Apps](https://make.powerapps.com/) portal.

    > [!div class="mx-imgBorder"]  
    > ![Power Apps home page](media/power-apps-home-page.png "Power Apps home page")

2. Search for and select your organization's environment.

    > [!div class="mx-imgBorder"]  
    > ![Select your organization](media/power-apps-select-org.png "Select your organization")

3. Select **Data** > **Tables**.

    The **Tables** page opens with the list of tables.

    > [!div class="mx-imgBorder"]  
    > ![Tables page with list of tables](media/power-apps-entities-page.png "Tables page with list of tables")

4. Open the table, select the **Forms** tab, and then select a main form to add the widget to. In this example, the table **Opportunity** is selected and the main form **Opportunity** is selected.

    >[!NOTE]
    >If you're unable to view the table to which you want to add the widget, in the upper-right corner of the page, change the filters settings to **All**. 

    > [!div class="mx-imgBorder"]  
    > ![Select the Opportunity main form underon the Forms tab](media/power-apps-opportunity-main-form.png "Select the Opportunity main form on the Forms tab")

5. In the form designer, select **Component**, and then from **Layout**, add a column to the form as a placeholder to add the widget.

    > [!div class="mx-imgBorder"]  
    > ![Add a column to the form](media/power-apps-layout-add-column-form.png "Add a column to the form")

    The column is added to the form.

7. From the site map, select **Display** > **Predictive score**.

    >[!NOTE]
    >Ensure that the added placeholder column is selected. If it isn't, the widget will be added at a random place in the form. 

    > [!div class="mx-imgBorder"]  
    > ![Select the predictive score widget](media/power-select-predictive-score-widget.png "Select the predictive score widget")

8. In the **Edit predictive score** pop-up window, select **Done**.

    > [!div class="mx-imgBorder"]  
    > ![Select Done to add the predictive score widget](media/power-app-predictive-score-widget-options.png "Select Done to add the predictive score widget")

    The predictive score widget is added to the form, as shown in the following image.

    > [!div class="mx-imgBorder"]  
    > ![Predictive score widget added to the form](media/power-app-predictive-opportunity-score-widget-added.png "Predictive score widget added to the form")

    >[!NOTE]
    >To hide the **New section** label, go to the **Properties** tab of the **New Section** settings pane, and then select **Hide label**.

9. Save and publish the form.

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]
