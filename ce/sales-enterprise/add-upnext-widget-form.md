---
title: "Add the up next widget to a custom form | MicrosoftDocs"
description: "Display the up next widget on your customized forms through sales accelerator configuration in Sales Insights."
ms.date: 11/16/2020
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---

# Add the Up next widget to a custom form

By default, the Up next widget is available only in the out-of-the-box Sales Insights, lead, and opportunity forms. If you're using customized forms, you can display the Up next widget on your custom forms by following these steps.
>[!NOTE]
>- You can add the **Up next** widget only to managed forms.
>- Adding the **Up next** widget is supported only in Unified Interface apps.

1. Sign in to the **Sales Hub** app.   
2. Go to **Change area** in the lower-left corner of the page, and select **Sales Insights settings**.   
3. Under **Acceleration**, select **Sales accelerator (preview)**.   
4. In the **Choose content and layout** section, select the custom form for which you want to add the Up next widget.  
    >[!div class="mx-imgBorder"]
    >![Choose custom entity form](media/sa-choose-custom-entity-form.png "Choose custom entity form")   
    >[!NOTE]
    >Here we're using the custom lead form as an example to add the Up next widget for leads. For other record types, you can perform the steps described in the procedure with the custom form selector.
5. Select the open in new tab icon (![open in new tab icon](media/sa-open-new-tab.png "open in new tab icon")) and the form designer tab opens.   
    >[!div class="mx-imgBorder"]
    >![Entity form in designer](media/sa-powerapps-form-designer.png "Entity form in designer")   
6. In the form designer, select **Component**, and then from **Layout**, add a column to the form as a placeholder to add the widget.      
    >[!div class="mx-imgBorder"]
    >![Add new column as place holder](media/sa-powerapps-add-new-column.png "Add new column as place holder")   
7. From the site map, select **Related data** > **Sequence (Up next)**.   
    >[!NOTE]
    >Ensure that the added placeholder column is selected. If it isn't, the widget will be added at a random place in the form.   
8. In the **Edit sequence (Up next)** pop-up window, select **Done**.  
    The Up next widget is added to the form, as shown in the following image.   
    > [!div class="mx-imgBorder"]  
    > ![Up next widget added to the form](media/sa-upnext-widget-added.png "Up next widget added to the form")    
    >[!NOTE]
    >To hide the **New section** label, go to the **Properties** tab of the **New Section** settings pane, and then select **Hide label**.    
9. Save and publish the form.

### See also

[Enable and configure sales accelerator](enable-configure-sales-accelerator.md)   
[Connect with customers through a record or the Up next widget](connect-with-customers.md)
