---
title: "Add the up next widget to an entity form | MicrosoftDocs"
description: "Learn how to add the up next widget to an entity form."
ms.date: 11/16/2020
ms.service: crm-online
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---

# Add the Up next widget to an entity form

By default, the up next widget is available only in the out-of-the-box Sales Insights, lead, and opportunity forms. If you're using customized forms for leads or opportunities, you can display the up next widget on your custom forms by following these steps.
>[!NOTE]
>- You can add the **Up next** widget only to managed forms.
>- Adding the **Up next** widget is supported only in the Unified Interface apps.

1. Sign in to the **Sales Hub** app.   
2. Go to **Change area** in the lower-left corner of the page, and select **Sales Insights settings**.   
3. Under **Acceleration**, select **Sales accelerator (preview)**.   
4. Go to the **Choose content and layout** section. Choose a custom form from the drop-down for which you want to add the up next widget.  
    >[!div class="mx-imgBorder"]
    >![Choose custom entity form](media/sa-choose-custom-entity-form.png "Choose custom entity form")   
    >[!NOTE]
    >Here we are using custom lead form as an example to add up next widget for leads. For Opportunities, you can perform the steps described in the procedure with opportunity form selector.
5. Select the open in new tab icon (![open in new tab icon](media/sa-open-new-tab.png "open in new tab icon")) and the form designer tab opens.   
    >[!div class="mx-imgBorder"]
    >![Entity form in designer](media/sa-powerapps-form-designer.png "Entity form in designer")   
6. In the form designer, select **Component**, and then from **Layout**, add a column to the form as a placeholder to add the widget.      
    >[!div class="mx-imgBorder"]
    >![Add new column as place holder](media/sa-powerapps-add-new-column.png "Add new column as place holder")   
7. From the site map, select **Related data** > **Sequence (Up next)**.   
    >[!NOTE]
    >Ensure that the added placeholder column is selected. If it isn't, the widget will be added at a random place in the form.   
8. In the **Edit sequence (up next)** pop-up window, select **Done**.  
    The up next widget is added to the form, as shown in the following image.   
    > [!div class="mx-imgBorder"]  
    > ![Up next widget added to the form](media/sa-upnext-widget-added.png "Up next widget added to the form")    
    >[!NOTE]
    >To hide the **New section** label, go to the **Properties** tab of the **New Section** settings pane, and then select **Hide label**.    
9. Save and publish the form.

### See also

[Enable and configure sales accelerator](enable-configure-sales-accelerator.md)   
[Connect with customers through a record or the up next widget](connect-with-customers.md)
