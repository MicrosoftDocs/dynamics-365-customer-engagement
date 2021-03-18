---
title: "Add the forecast grid and configuration options in a site map (Dynamics 365 Sales) | MicrosoftDocs"
description: "How to add the forecast grid and configuration options in a site map in Dynamics 365 Sales."
ms.date: 12/13/2019
ms.service: 
  - "dynamics-365-sales"
ms.custom: 
  - "dyn365-sales"
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---

# Add the forecast grid and configuration options in a site map

When you create a custom model-driven app, you can choose a default solution to create a site map for the app. However, the list contains solutions that are based on entity forms only. The forecast options are based on URL custom control forms and do not appear in the solution list. You must manually add these options to the site map. After you add these options, users in your organization can see them on the app’s site map. 

Follow these steps to individually configure the site map for forecast grid and forecast configuration:

1.	Open your custom app on the app designer and go to the site map designer.

2.	Select a group from the area for which you want to add the forecast options. 

    >[!NOTE]
    >We recommend using the General area for forecast grid and the Administration area for forecast configuration.

3.	On the site map designer canvas, select **Add** > **Subarea**.

    OR

    From the **Components** tab, drag the **Subarea** tile to an empty box under the **Group** section in the canvas. You'll see the empty box when you move the tile to the correct place in the canvas.

4.	Select the subarea that you have created and go to the **Properties** tab.

5.	Under the **General** section, do the following:

    a.	Select **Type** as **URL**.

    b.	In **URL**:
        
       - For the forecast grid, enter: **/main.aspx?pagetype=control&controlName=ForecastingControls.FieldControls.ForecastGridPage**
        
       - For the forecast configuration, enter: **/main.aspx?pagetype=control&controlName=ForecastingControls.FieldControls.CCFForecastConfig**
    
    c.	In **Title**:

       - For the forecast grid, enter **Forecasts**.

       - For the forecast configurations, enter **Forecast configurations**.

    d.	In **Icon**, select the following:

       - For the forecast grid, select **Forecast Instance Entity icon**.

       - For the forecast configurations, select **Forecast Definition Entity icon**.
            
    e.	(Optional) If required, enter unique IDs for the forecast grid and forecast configuration. You can also use the default IDs.
    
       > [!div class="mx-imgBorder"]
       > ![Properties tab of site map designer](media/forecast-sitemap-properties.png "Properties tab of site map designer")

6.	Save and close the site map designer page.

7.	Publish your custom app.

    The forecast grid and configuration options are now displayed on the site map.

More information: [Create a site map for an app using the site map designer](/customerengagement/on-premises/customize/create-site-map-app.md#add-a-subarea-to-a-group-in-the-site-map)


### See also

[Configure a forecast in your organization](configure-forecast.md)

[Design custom business apps by using the app designer](/customerengagement/on-premises/customize/design-custom-business-apps-using-app-designer)


[!INCLUDE[footer-include](../includes/footer-banner.md)]