---
title: "Events and context object for forecasting (Dynamics 365 Sales) | MicrosoftDocs"
description: Events and context object for forecasting in Dynamics 365 Sales
ms.date: 10/12/2020
ms.service: dynamics-365-sales
ms.custom: dyn365-sales
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi

---
# Events and context object

[!INCLUDE[cc-data-platform-banner](../../../../includes/cc-data-platform-banner.md)]

>[!NOTE]
>The *forecasting context object* that's referred to in this topic is different from the execution context of Common Data Service. The forecasting context object is specific to forecasting and supports the advanced configurations of the underlying records grid.

## Events for the underlying records grid

Events occur in forecasting for the underlying records grid whenever a grid is loaded, data is changed, or data is saved. The application executes JavaScript code by associating it with a handler when the event occurs. The following events are supported in forecasting:
- [OnRowLoad](#onrowload-event)
- [OnSave](#onsave-event)
- [OnChange](#onchange-event)

The following samples scenarios are created based on the supported event handlers:

-	[Make a grid read-only by disabling all fields](#make-grid-read-only). 
-	[Always enable only a few fields based on entity](#always-enable-only-few-fields-based-on-entity).
-	[Disable editing of fields based on logic and entity](#disable-editing-of-fields-based-on-logic-and-entity).
-	[Show an error notification based on value](#show-error-notification-based-on-revenue-value). 
-	[Block autosave based on the estimated value by using preventDefault, and open a window event](#block-autosave-based-on-estimated-revenue-value). 

### OnRowLoad event

The `OnRowLoad` event is triggered for every underlying record loaded in the grid. The context object that's passed to the `OnRowLoad` event handler contains APIs that are specific to the underlying record. 

The following are the sample scenarios that you can perform using `OnRowLoad` handler:

-	[Make a grid read-only by disabling all fields](#make-grid-read-only). 
-	[Always enable only a few fields based on entity](#always-enable-only-few-fields-based-on-entity).
-	[Disable editing of fields based on logic and entity](#disable-editing-of-fields-based-on-logic-and-entity).

>[!NOTE]
>For forecast configuration, underlying records of different entities are viewed by selecting the **Groupby** attribute in the forecasting editable grid. To handle logic based on these entities, see the samples [Always enable only a few fields based on entity](#always-enable-only-few-fields-based-on-entity) and [Disable editing of fields based on logic and entity](#disable-editing-of-fields-based-on-logic-and-entity).

### OnChange event

The `OnChange` event is triggered when the value of a cell in the forecasting editable grid is updated and the cell is out of focus.

>[!NOTE]
>- For the forecasting editable grid, any field change will trigger `OnChange` and `OnSave` event handlers, if they exist.
>- The save won't be triggered if a field is set with an error notifications by using the client API in the `OnChange` handler. For notifications related to forecasting client APIs, go to the `setNotification` API in [context.getFormContext().data.entity.attributes.getByName("Attribute Name").controls.get(0)](#context.getformcontext-data-entity-attributes-getbyname-controls-get).
>- There is no mapping between attributes to the `OnChange` handler, and any field change will trigger the `OnChange` handler with the context object parameter. To identify the attribute that triggered the handler, use the `getIsDirty` function on the attribute object. More information: [context.getFormContext().data.entity.attributes.getByName("Attribute Name")](#context-getformcontext-data-entity-attributes-getbyname)

The following is a sample scenario that you can perform by using the `OnChange` handler:

-	[Show error notification based on value](#show-error-notification-based-on-revenue-value). 

### OnSave event

The `OnSave` event is triggered when a value is changed in a cell of the forecasting editable grid and the cell is out of focus. However, if the `OnChange` handler exists for the same forecast configuration, the `OnSave` handler is invoked after the `OnChange` handler.

The `OnSave` handler is invoked before the actual save of the field.

>[!NOTE]
>- For the forecasting editable grid, any field change will trigger `OnChange` and `OnSave` event handlers, if they exist.
>- The save won't be triggered if a field is set with an error notifications by using the client API in the `OnSave` handler. For notification related to forecasting client APIs, go to the `setNotification` API in [context.getFormContext().data.entity.attributes.getByName("Attribute Name").controls.get(0)](#context.getformcontext-data-entity-attributes-getbyname-controls-get).
>- There's no mapping between attributes to the `OnSave` handler, and any field change will trigger the `OnSave` handler with the context object parameter. To identify the attribute that triggered the handler, use the `getIsDirty` function on the attribute object. More information: [context.getFormContext().data.entity.attributes.getByName("Attribute Name")](#context-getformcontext-data-entity-attributes-getbyname)

The following is a sample scenario that you can perform by using the `OnSave` handler:

-	[Block autosave based on the estimated value using preventDefault, and open a window event](#block-autosave-based-on-estimated-revenue-value). 

## Context object for event handlers in the editable grid

The context object contains a set of APIs to perform operations specific to an underlying record in a forecast. This context object is passed as a parameter to the event handlers in the forecasting editable grid view.

The following APIs are supported:

- [context.getFormContext method](#api-context-getformcontext)
- [context.getWebApiContext()](#api-context-getwebapicontext)
- [context.getEventArgs().preventDefault()](#api-context-geteventargs-preventdefault)

<a name=api-context-getformcontext></a>
### context.getFormContext method

Returns a reference to a record on the forecasting editable grid.

#### context.getFormContext().data.entity

This returns an entity object and has the following methods:

| Method | Return type | Description |
|--------|-------------|-------------|
| `getEntityName()` | String | Returns a string representing the logical name of the entity for the record. |
| `getId()` | String | Returns a string representing the GUID value for the record. |
| `attributes` | List |Returns a list of attributes that are related to the view and an entity that's loaded as part of the forecasting editable grid. You can perform the following operations:<br>- `context.getFormContext().data.entity.attributes.forEach` <br>- `context.getFormContext().data.entity.attributes.getByName(arg)`<br>- `context.getFormContext().data.entity.attributes.get(index)` |

<a name=context-getformcontext-data-entity-attributes-getbyname></a>
#### context.getFormContext().data.entity.attributes.getByName("Attribute Name")

This returns an attribute object and has the following methods:

| Method | Return type | Description |
|--------|-------------|-------------|
| `getName()` | String | Returns a string that represents the logical name of the attribute. |
| `getValue()` | -- | Retrieves the data value for an attribute. |
| `getIsDirty()` | Boolean | Returns a Boolean value indicating whether there are any unsaved changes to the attribute value. |
| `controls` | List | Returns a list of controls for each attribute object. <br> **Note**: The `controls` object list length is always 1, and `get(0)` can be directly used. |

<a name=context.getformcontext-data-entity-attributes-getbyname-controls-get></a>
#### context.getFormContext().data.entity.attributes.getByName("Attribute Name").controls.get(0)

This returns a control object mapping to the attribute and has the following methods:

| Method | Return type | Description |
|--------|-------------|-------------|
| `getDisabled()` | Boolean | Returns whether the control is disabled. |
| `setDisabled(bool)` | -- | Sets the disabled value (true or false) to the control. |
| `setNotification(message: string, uniqueId?: string)` | Boolean | Displays an error message for the control to indicate that data isn’t valid. When this method is used, a red cross icon appears next to the control within the cell. Hovering over the error icon will display the provided message. Selecting the error icon will reload the row and undo any changes. The `uniqueId` is used to clear this message when using the `clearNotification` method. |
| `clearNotification(uniqueId?: string)` | Boolean | Removes a message that's already displayed for a control. If no unique ID is provided, all notifications for that control are removed. |


> [!NOTE]
> We recommend that the function names in the JavaScript file must match the event names and must accept the context object parameter.

<a name=make-grid-read-only></a>
**Example 1:**

Let's create JavaScript code to make an editable forecasting grid READ-ONLY. Also, we'll call the `OnRowLoad` function for each row when the grid is loaded and saved successfully.
 
```JavaScript
function OnRowLoad(executionContext) {
    // Iterating through all attributes and disabling it.
    executionContext.getFormContext().data.entity.attributes.forEach(
        attribute => {
            attribute.controls.get(0).setDisabled(true);
        }
    )
}
```

<a name=always-enable-only-few-fields-based-on-entity></a>
**Example 2:**

Let's create JavaScript code to disable all fields except a few for the Opportunity entity only. Also, we'll call the `OnRowLoad` function for each row when the grid is loaded and saved successfully.

```JavaScript
function OnRowLoad(executionContext) {

    // Get the logical name of the loaded entity as part of forecasting editable grid.
    var entityName = executionContext.getFormContext().data.entity.getEntityName();

    if (entityName === "opportunity") {

        // Defining the attributes list from opportunity that has to be enabled if loaded as part of view.
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

<a name=disable-editing-of-fields-based-on-logic-and-entity></a>

**Example 3:**

Let's create JavaScript code to handle different entities for the loaded forecast configuration. 

For an Opportunity entity, the script will disable the following:
- Name column
- `actualRevenue` and `actualCloseData` if the `forecastCategory` value is best case, committed, omitted, or pipeline.
- `estimatedRevenue` and `estimatedCloseDate` if the `forecastCategory` value is won or lost.

Similarly, the script will disable the name column for the Account entity and disable all columns for other entities.

Also, we'll call the `OnRowLoad` function for each row when the grid is loaded and saved successfully.
 

```JavaScript

function OnRowLoad(executionContext) {
		 
    // Get the logical name of the loaded entity as part of forecasting editable grid.
    var entityName = executionContext.getFormContext().data.entity.getEntityName();
    
    // If loaded logical name of entity in editable grid is opportunity.
    if (entityName === "opportunity") {
        
       var allAttrs = executionContext.getFormContext().data.entity.attributes;

       // Disable column name for all records if exists in the view.
       var nameAttr = allAttrs.getByName("name");
       if (nameAttr) {
           nameAttr.controls.get(0).setDisabled(true);
       }

       var fcatAttr = allAttrs.getByName("msdyn_forecastcategory");
       if (fcatAttr) {
           // Disable actualRevenue, actualCloseDate for forecastcategory Bestcase, committed, omitted, or pipeline.
           if (fcatAttr.getValue() <= 100000004 && fcatAttr.getValue() >= 100000001) {
                   var actualRevenueAttr = allAttrs.getByName("actualvalue");
                   var actualCloseDateAttr = allAttrs.getByName("actualclosedate");
                   if (actualRevenueAttr) actualRevenueAttr.controls.get(0).setDisabled(true);
                   if (actualCloseDateAttr) actualCloseDateAttr.controls.get(0).setDisabled(true);
           }
           // Disable estimatedRevenue, estimatedCloseDate for forecastCategory won or lost.
           else if (fcatAttr.getValue() == 100000005 || fcatAttr.getValue() == 100000006) {
                   var estimatedRevenueAttr = allAttrs.getByName("estimatedvalue");
                   var estimatedCloseDateAttr = allAttrs.getByName("estimatedclosedate");
                   if (estimatedRevenueAttr) estimatedRevenueAttr.controls.get(0).setDisabled(true);
                   if (estimatedCloseDateAttr) estimatedCloseDateAttr.controls.get(0).setDisabled(true);
           }
       }
   } 
   
   // Else disable name column, if loaded logical name of entity is Account.
   else if (entityName === "account"){
       var attrNameObj = executionContext.getFormContext().data.entity.attributes.getByName("name");
       if (attrNameObj) {
               attrNameObj.controls.get(0).setDisabled(true);
       }
   } 
   
   // For all other entities
   else {
       executionContext.getFormContext().data.entity.attributes.forEach(
           attribute => {
               attribute.controls.get(0).setDisabled(true);
           }
       )
   }
}
```

<a name=show-error-notification-based-on-revenue-value> </a>
**Example 4:**

Let's create a validation JavaScript file that will block save and show an error notification on the estimated revenue column when the value is less than 10. Also, we'll remove the error notification and allow save when the estimated revenue column value is corrected to be greater than or equal to 10. Here, the `OnChange` function is invoked when any field's value is updated on the editable grid.

```JavaScript

// OnChange function is invoked when any field's value is updated on the editable grid
function OnChange(executionContext) {

    let entity = executionContext.getFormContext().data.entity;

    // Verify the logical name of the entity and load as part of the editable grid.
    if (entity.getEntityName() === "opportunity") {

        // Verify estimated revenue value
        let estValAttr = entity.attributes.get("estimatedvalue");

        // Verify if this attribute exists within the grid view and changed
        if(estValAttr && estValAttr.getIsDirty()) 
        {
            if(estValAttr.getValue() < 10){

                // This will show an error icon next to the estimated revenue field. On hovering over the icon, the below provided message is displayed.
                // Any save attempts are blocked by the system until all notifications are cleared from the columns.
                estValAttr.controls.get(0).setNotification("Estimated revenue cannot be less than 10");
            }
            else{
                // Clearing notifications to save.
                estValAttr.controls.get(0).clearNotification();
            }
        }
    }
}
```
<a name=api-context-getwebapicontext></a>
### context.getWebApiContext()

This returns a `webApiContext` object and has the following methods:

| Method | Description |
|--------|-------------|
| `retrieveRecord(entityLogicalName, id, options)`<br>`then (successCallback, errorCallback);` | Retrieves an entity record. More information: [retrieveRecord (Client API reference)](/powerapps/developer/model-driven-apps/clientapi/reference/xrm-webapi/retrieverecord) |
| `updateRecord(entityLogicalName, id, data)`<br>`then(successCallback, errorCallback);` | Updates an entity record. More information: [updateRecord (Client API reference)](/powerapps/developer/model-driven-apps/clientapi/reference/xrm-webapi/updaterecord) |
| `createRecord(entityLogicalName, data)`<br>`then(successCallback, errorCallback);` | Creates an entity record. More information: [createRecord (Client API reference)](/powerapps/developer/model-driven-apps/clientapi/reference/xrm-webapi/createrecord) |
| `deleteRecord(entityLogicalName, id)`<br>`then(successCallback, errorCallback);` | Deletes an entity record. More information: [deleteRecord (Client API reference)](/powerapps/developer/model-driven-apps/clientapi/reference/xrm-webapi/deleterecord) |

<a name=api-context-geteventargs-preventdefault></a>
### context.getEventArgs().preventDefault()

The `preventDefault()` method is available only within the `OnSave` event. Calling this method within `OnSave` prevents the save event from proceeding. 

<a name=block-autosave-based-on-estimated-revenue-value></a>
**Example:**

Let's create sample JavaScript to open the opportunities grid, and block the auto save event and open a window alert if the estimated revenue value is less than 10. Also, we'll allow the auto save event if the estimated revenue value is greater than or equal to 10.

```JavaScript
// OnSave function will be invoked whenever grid attempts to save changes made to any field. 
function OnSave(executionContext){

    let entity = executionContext.getFormContext().data.entity;

    // Verify the logical name of the entity and load as part of the editable grid.
    if (entity.getEntityName() === "opportunity") {

        // Verify estimated revenue value
        var estValAttr = entity.attributes.get("estimatedvalue");

        if(estValAttr && estValAttr.getIsDirty() && estValAttr.getValue() < 10){

            // This call will prevent the save event from proceeding
            executionContext.getEventArgs().preventDefault(); 
            alert("Estimated revenue cannot be less than 10");

        }
    }
}
```

### See also

[Customize underlying records](../../../forecast-configure-advanced-settings.md#customize-underlying-records)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]