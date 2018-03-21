---
title: "Display custom icons instead of values in list views (Dynamics 365 Customer Engagement) | MicrosoftDocs"
ms.custom: ""
ms.date: 01/30/2018
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: "rdubois-msft"
ms.assetid: af866aed-2586-4b6f-bb1c-3519baae3645
caps.latest.revision: 25
ms.author: "rdubois"
manager: "brycho"
---
# Display custom icons instead of values in list views

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

<a name="GridIcons"></a>   

 Some Relationship Insights features display list views that show  icons rather than text or numerical values in some columns. Though this capability was created to support specific Relationship Insights features, administrators and customizers can also add new  graphics and establish the logic used to select them based on a column values using JavaScript.  
  
> [!NOTE]
>  Grid icons are only shown in the web interface. They are not shown in [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)] or the mobile app.  
  
### Add custom graphics and JavaScript as web resources in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)]  
  
1.  Create the new graphic files needed for your customization. We recommend an icon size of 16x16 pixels (larger images will be scaled down).  
  
2.  Write one or more JavaScript functions that establish which icons to show for which values (you'll typically need one function for each column you want to customize). Each function must accept a row data object and a language (LCID) code as input and return an array containing an image name and tooltip text. For an example function, see [Sample JavaScript function](#SampleJavascript), later in this topic.  
  
3.  Sign into [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] as an administrator and go and go to **Settings** > **Customizations** > **Customize the System**.  
  
4.  The **Default Solution** pop-up window opens. Navigate to **Components** > **Web Resources** here.  
  
5.  Now, you'll upload your custom graphics, one at a time, as web resources. Click the **New** button in the toolbar to create a new web resource. Another pop-up window opens to help you create the resource. Do the following:  
  
    1.  Give the new resource a meaningful **Name**. The is the name that you'll use to refer to each graphic from your JavaScript code.  
  
    2.  Set the **Type** to the graphic format you've used to save your graphic file (PNG, JPEG, or GIF).  
  
    3.  Click on the **Choose File** button to open a file browser window. Use it to find and select your graphic file.  
  
    4.  Add a **Display Name** and/or **Description** if you wish.  
  
    5.  Click on **Save** and then close the **Web Resource** window.  
  
6.  Repeat the previous step for each graphic file that you have.  
  
7.  Now, you'll add your JavaScript as the final web resource. Click the **New** button in the toolbar to create a new web resource. Another pop-up window opens to help you create the resource. Do the following:  
  
    1.  Give the new resource a meaningful **Name**.  
  
    2.  Set the **Type** to **Script (JScript)**.  
  
    3.  Click on **Text Editor** (next to the **Type** setting) to open a text-editor window. Paste your Javascript code here and click **OK** to save it.  
  
    4.  Add a **Display Name** and/or **Description** if you wish.  
  
    5.  Click on **Save** and then close the **Web Resource** window.  
  
8.  With the **Default Solution** pop-up window still open, expand the **Components** > **Entities** tree and locate the entity that you want to customize.  
  
9. Expand your entity and select its **Views** icon.  
  
10. You now see a list of views for your selected entity. Click on a view from the list to select it. Then open the **More Actions** drop-down list in the toolbar and choose **Edit**.  
  
11. A new pop-up window opens with controls for editing your selected view. It shows each column that is part of the view. Click to select the target column and then click the **Change Properties** button in the **Common Tasks** box. The **Change Column Properties** dialog opens; make the following settings here:  
  
    - **Web Resource**: specify the name of the web resource that you created to hold your Javascript functions (click the browse button to choose from a list).  
  
    - **Function Name**: type the name of the function that you wrote to modify the selected column and view.  
  
12. Click **OK** to close the **Change Column Properties** dialog.  
  
13. Click **Save and Close** to save your view.  
  
14. Repeat these steps for each entity, view, and column as needed.  
  
15. When you are ready, click **Publish All Customizations** to publish  your changes. Then you can close the **Default Solution** pop-up window.  
  
<a name="SampleJavascript"></a>   

### Sample JavaScript function  
 The JavaScript function for displaying custom icons and tooltips expects the following two arguments: the entire row object specified in layoutxml and the calling user’s Locale ID (LCID). The LCID parameter enables you to specify tooltip text in multiple languages. For more information about the languages supported by [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)], see [Enable languages](../admin/enable-languages.md) and [Install or upgrade language packs for Dynamics 365](https://technet.microsoft.com/library/hh699674.aspx). For a list of locale ID (LCID) values that you can use in your code, see [Locale IDs assigned by Microsoft](https://go.microsoft.com/fwlink/?linkid=829588).
<!-- TODO: the link above for language packs appears to be on-prem only. Delete or wait for on-prem to be here? -->  
  
 Assuming you will be adding custom icons for an option-set type of attribute, which has a limited set of predefined options, make sure you use the integer value of the options instead of label to avoid localization issues.  
  
 The following sample code displays icons and tooltips based on one of three values (1: Hot, 2: Warm, 3: Cold) in the opportunityratingcode (Rating) attribute. The sample code also shows how to display localized tooltip text. For this sample to work, you must create three image web resources with 16x16 images in your [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] instance with the following names: new_Hot, new_Warm, and new_Cold.  
  
```  
function displayIconTooltip(rowData, userLCID) {      
    var str = JSON.parse(rowData);  
    var coldata = str.opportunityratingcode_Value;  
    var imgName = "";  
    var tooltip = "";  
    switch (parseInt(coldata,10)) { 
        case 1:  
            imgName = "new_Hot";  
            switch (userLCID) {  
                case 1036:  
                    tooltip = "French: Opportunity is Hot";  
                    break;  
                default:  
                    tooltip = "Opportunity is Hot";  
                    break;  
            }  
            break;  
        case 2:  
            imgName = "new_Warm";  
            switch (userLCID) {  
                case 1036:  
                    tooltip = "French: Opportunity is Warm";  
                    break;  
                default:  
                    tooltip = "Opportunity is Warm";  
                    break;  
            }  
            break;  
        case 3:  
            imgName = "new_Cold";  
            switch (userLCID) {  
                case 1036:  
                    tooltip = "French: Opportunity is Cold";  
                    break;  
                default:  
                    tooltip = "Opportunity is Cold";  
                    break;  
            }  
            break;  
        default:  
            imgName = "";  
            tooltip = "";  
            break;  
    }  
    var resultarray = [imgName, tooltip];  
    return resultarray;  
}  
```  
  
 This results in displaying icons with tooltips in the **Rating** column that depend on the value in each row. The result could look like this:  
  
 ![Custom column graphics example](../customize/media/custom-column-graphics-example.png "Custom column graphics example")  
 
 ### See also
 [Create or edit views](create-edit-views.md)
