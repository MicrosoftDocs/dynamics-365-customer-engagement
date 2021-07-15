---
title: "Customize deal manager - Sales Enterprise | MicrosoftDocs"
description: "Customize the grid, side panel, and charts displayed in deal manager according to your sales team's requirement."
ms.date: 07/15/2021
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
---

# Customize the deal manager workspace (Preview)

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> A preview is a feature that is not complete, but is made available to you before general availability so you can evaluate the preview and provide feedback to Microsoft. Previews may have restricted functionality and may employ reduced or different privacy, security, or compliance commitments than a commercial version. As such, previews are not intended for production use, which means they are not meant for "live" Customer Data, Personal Data, or other data that is subject to heightened compliance requirements. Use of such data is at your sole risk and it's your sole responsibility to notify your end users about not including personal or sensitive information with their use of previews, as appropriate. We don't provide support for previews and Microsoft Dynamics 365 Technical Support won't be able to help you with issues or questions. This preview, and any one-off support Microsoft may elect to provide, is provided "as-is," "with all faults," "as available," and without warranty.

As an administrator, you can customize the workspace to enhance your sales team's productivity. For example, depending on the information that your sales team wants to view or update quickly, you can customize the grid or side panel. You can customize the following objects in the deal manager:

- [Charts](#customize-the-charts)
- [Editable grid](#customize-the-editable-grid-in-deal-manager)
- [Side panel](#customize-the-side-panel)

## Customize the charts

The deal manager charts help sellers visualize their pipeline better. As an administrator, you can customize various elements in the bubble chart, such as the data on the x-axis and y-axis, the size and color of the bubble, the sort order for the legend, and tooltips.

> [!NOTE]
> This release has a few limitations related to chart customization. More information: [Known issues in deal manager](deal-manager-known-issues.md#charts)

<!--markdownlint-disable MD036-->
**To customize the bubble chart**

1. Access the [deal manager settings](enable-deal-manager-preview.md#access-deal-manager-settings) page.
1. In the **Manage charts** section, edit the **Deal tracker** chart. 
1. Customize the following elements:
    - **Horizontal (x) axis**  
      Select any field of type DateTime. For example, you can choose to plot the chart based on delivered date instead of closed date.  
    - **Vertical (y) axis**  
      Select any numerical field to plot on the vertical axis.
    - **Segment by**  
        Select how you want distinguish the bubbles by using different color codes. For example, select **Pipeline Phase** to distinguish the bubbles based on the different phases of the pipeline, such as identify, qualify, or propose.
    - **Size**  
        Select a numerical field to indicate the size of the bubble.
    - **Sort legend**  
        Select how you want to sort the legends displayed on the chart. Legends indicate the color used for each segment. For example, if you select **Opportunity grade** as the segment, the legends will be sorted based on the chronological order of the grades.
    - **Tooltips**  
        Select the details that you want users to see displayed as tooltips when they hover over each bubble.  

1. Save the changes. Access the deal manager workspace to verify whether the changes took effect.


## Customize the editable grid in deal manager

The editable grid in the deal manager workspace lets sellers quickly view a list of opportunities that they're interested in. You can customize the editable grid to apply any business rules, or to include fields that sellers want to view by default and update.<!--note from editor: Suggested.-->

Customize the editable grid by adding a JavaScript library. These customizations include disabling fields based on a certain logic, preventing fields from being automatically saved, and setting error notifications for fields. Before you upload it, the JavaScript library must be created in accordance with the schemas defined for forecasting [events and context object](../sales-enterprise/developer/reference/custom-actions/events-context.md).  

**To create and upload a JavaScript library**

1. Write your custom JavaScript code. In the following example, we create JavaScript to disable all fields except a few for the Opportunity entity.   
    ```JavaScript
    function OnRowLoad(executionContext) {

    // Get the logical name of the loaded entity as part of deal manager editable grid.
    var entityName = executionContext.getFormContext().data.entity.getEntityName();

        if (entityName === "opportunity") {

            // Defining the attributes list from opportunity that has to be enabled in the editable grid in deal manager workspace.
            var OPTY_ENABLE_ATTRS_LIST = ["name", "msdyn_forecastcategory", "actualvalue", "actualclosedate", "estimatedvalue", "estimatedclosedate"];

            executionContext.getFormContext().data.entity.attributes.forEach(
                attribute => {
                    // Disabling all attributes other than OPTY_ENABLE_ATTRS_LIST
                    if (!OPTY_ENABLE_ATTRS_LIST.includes(attribute.getName())) {
                        attribute.controls.get(0).setDisabled(true);
                    }
                }
            )        
        }
    }
    ```      

    > [!NOTE]
    > -	The function names in the JavaScript file must match the event names and must accept the context object parameter. 
    > -	The deal manager context object that's referred to in the example is different from the execution context of Common Data Service<!--note from editor: Should this be "Dataverse"?-->. Currently, the  deal manager context object is the same as the forecasting context object and supports advanced configurations of the underlying records grid in deal manager. More information: [Events and context object](../sales-enterprise/developer/reference/custom-actions/events-context.md)  

1.	Add your JavaScript code in a script web resource:  

     1. Sign in to [Power Apps](https://make.powerapps.com/).
     1. Select the gear icon, and then select **Advanced Settings**. 
     1. In the Business Management app, select the **Settings** dropdown list, and then select **Customizations**.
     1. Select **Customize the System**.
     1. In the solution explorer under **Components**, select **Web Resources**.
     1. Select **New**.
     1. In the new web resource dialog, enter the **Name** (for example, **mySampleScript.js**) and **Display Name**(for example, **My sample script**) for your web resource.
     1. From the **Type** dropdown list, select **Script (JScript)**, and then do one of the following:
        - Select **Choose File** to upload the file containing your JavaScript code.
        - Select **Text Editor**, and then paste your JavaScript code in the editor. 
     1. Select **Save**, and then select **Publish**. 

1.	Upload the JavaScript library to the deal manager workspace:
    1. Access the [deal manager settings](enable-deal-manager-preview.md#access-deal-manager-settings) page. 
    2. In the **Customize the workspace** section, select **Advanced field controls**.
    3. Select **Add a JavaScript library**. Search for and select the web resource file. 
        >[!NOTE]
        > This field supports only one JavaScript file at a time. To upload a new file, you must first remove the existing file.  
    
1. Select **Publish** to save the changes.
  

## Customize the side panel

The side panel helps sellers view quick details about a selected record. It offers more details about the record and displays notes, tasks, and activities associated with the record. Some customizations are supported in this release, others are slated for a future release.<!--note from editor: Suggested, along with the changes to the next paragraphs so they can fit better with the procedure.-->

**Supported side panel customizations** include:

- Define (add or remove) fields in the header.
- Define (add or remove) fields in the **Key Details** section.
- Change a field label.
- Set a field requirement (for example, read-only).
- Enable or disable tabs.
- Rearrange tabs.

**Unsupported side panel customizations** include:

- Adding custom tabs or sections.
- Adding a web resource.
- Adding a subgrid.
- Changing the format or layout for headers, tabs, sections, or fields.
- Changing certain properties for headers, tabs, sections, or fields. For example, the **available on phone**<!--note from editor: Edit okay?--> property can't be changed. 


**To customize the side panel**

1. Sign in to [Power Apps](https://make.powerapps.com/).
1. Select the environment, and then select **Data** > **Tables**.
1. In the upper-right corner, select the dropdown list and then select **All**.
1. Search for **Opportunity** to view all the opportunity-related entities.
1. Select the **Opportunity** table, and then select **Forms**.
1. Search for the **In Context View** form, and edit the form to manage the fields that appear in the side panel.
    :::image type="content" source="media/incontexview.PNG" alt-text="Screenshot of the In context view form in Power Apps.":::



### See also

[Access the deal manager workspace (Preview)](access-deal-manager.md)  
[Using the deal manager workspace (Preview)](deal-manager-seller-overview.md)
