---
title: "Context custom action (Dynamics 365 Sales) | MicrosoftDocs"
description: Context custom action for Dynamics 365 Sales
ms.date: 10/12/2020
ms.service: dynamics-365-sales
ms.custom: dyn365-sales
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi

---
# Events and context object

>[!NOTE]
>Forecasting context object that is referred here is different from the execution context of platform. Forecasting context object is specific to forecasting and supports the advanced configurations of underlying records grid.

## Events for underlying records grid

Events occur in forecasting for underlying records grid whenever a grid loads, data is changed, or saved. The application executes JavaScript code by associating it with a handler when the event occurs. The following events are supported in forecasting:
- [OnRowLoad](#onrowload-event)
- [OnSave](#onsave-event)
- [OnChange](#onchange-event)

The following samples scenarios are created based on the supported event handlers:

-	[Make grid read-only by disabling all fields](#make-grid-read-only). 
-	[Always enable only few fields based on entity](#always-enable-only-few-fields-based-on-entity).
-	[Disable editing of fields based on logic and entity](#disable-editing-of-fields-based-on-logic-and-entity).
-	[Show error notification based on value](#show-error-notification-based-on-revenue-value). 
-	[Block autosave based on estimated value using preventDefault and open a window event](#block-autosave-based-on-estimated-revenue-value). 

### OnRowLoad event

The `OnRowLoad` event is triggered for every underlying record loaded in the grid. The context object that is passed to `OnRowLoad` event handler contains APIs that are specific to the underlying record. 

The following are the sample scenarios that you can perform using `OnRowLoad` handler:

-	[Make grid read-only by disabling all fields](#make-grid-read-only). 
-	[Always enable only few fields based on entity](#always-enable-only-few-fields-based-on-entity).
-	[Disable editing of fields based on logic and entity](#disable-editing-of-fields-based-on-logic-and-entity).

>[!NOTE]
>For forecast configuration, underlying records of different entities are viewed by selecting **Groupby** attribute in forecasting editable grid. To handle logic based on these entities, see samples [Always enable only few fields based on entity](#always-enable-only-few-fields-based-on-entity) and [Disable editing of fields based on logic and entity](#disable-editing-of-fields-based-on-logic-and-entity).

### OnChange event

The `OnChange` event is triggered when value of a cell of forecasting editable grid is updated and the cell is out of focus.

>[!NOTE]
>- For forecasting editable grid, any field change will trigger `OnChange` and `OnSave` event handlers, if exists.
>- The save will not be triggered if a field is set with an error notifications using the client API in `OnChange` handler. For notification related to forecasting client APIs, see `setNotification` API in [context.getFormContext().data.entity.attributes.getByName("Attribute Name").controls.get(0)](#context.getformcontext-data-entity-attributes-getbyname-controls-get).
>- There is no mapping between attribute to `OnChange` handler and any field change will trigger `OnChange` handler with context object parameter. To identify the attribute that triggered the handler, use `getIsDirty` function on attribute object. More information: [context.getFormContext().data.entity.attributes.getByName("Attribute Name")](#context-getformcontext-data-entity-attributes-getbyname)

The following is a sample scenario that you can perform using `OnChange` handler:

-	[Show error notification based on value](#show-error-notification-based-on-revenue-value). 

### OnSave event

The `onSave` event is triggered when a value is changed in a cell of forecasting editable grid and the cell is out of focus. However, if `OnChange` handler exists for the same forecast configuration, `OnSave` handler is invoked after `OnChange` handler.

The `OnSave` handler is invoked before the actual save of field.

>[!NOTE]
>- For forecasting editable grid, any field change will trigger `OnChange` and `OnSave` event handlers, if exists.
>- The save will not be triggered if a field is set with an error notifications using the client API in `onSave` handler. For notification related to forecasting client APIs, see `setNotification` API in [context.getFormContext().data.entity.attributes.getByName("Attribute Name").controls.get(0)](#context.getformcontext-data-entity-attributes-getbyname-controls-get).
>- There is no mapping between attribute to `onSave` handler and any field change will trigger `onSave` handler with context object parameter. To identify the attribute that triggered the handler, use `getIsDirty` function on attribute object. More information: [context.getFormContext().data.entity.attributes.getByName("Attribute Name")](#context-getformcontext-data-entity-attributes-getbyname)

The following is a sample scenario that you can perform using `OnSave` handler:

-	[Block autosave based on estimated value using preventDefault and open a window event](#block-autosave-based-on-estimated-revenue-value). 

## Context object for event handlers in editable grid

The context object contains set of APIs to perform operations specific to an underlying record in a forecast. This context object is passed as parameters to the event handlers in the forecasting editable grid view.

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
| `attributes` | List |Returns a list of attributes that are related to the view and entity that is loaded as part of forecasting editable grid. You can perform the following operations:<br>- `context.getFormContext().data.entity.attributes.forEach` <br>- `context.getFormContext().data.entity.attributes.getByName(arg)`<br>- `context.getFormContext().data.entity.attributes.get(index)` |

<a name=context-getformcontext-data-entity-attributes-getbyname></a>
#### context.getFormContext().data.entity.attributes.getByName("Attribute Name")

This returns an attribute object and has the following methods:

| Method | Return type | Description |
|--------|-------------|-------------|
| `getName()` | String | Returns a string that represents the logical name of the attribute. |
| `getValue()` | -- | Retrieves the data value for an attribute. |
| `getIsDirty()` | Boolean | Returns a boolean value indicating if there are any unsaved changes to the attribute value. |
| `controls` | List | Returns a list of controls for each attribute object. <br> **Note**: Controls object list length is always 1 and get(0) can be directly used. |

<a name=context.getformcontext-data-entity-attributes-getbyname-controls-get></a>
#### context.getFormContext().data.entity.attributes.getByName("Attribute Name").controls.get(0)

This returns a control object mapping to attribute and has the following methods:

| Method | Return type | Description |
|--------|-------------|-------------|
| `getDisabled()` | Boolean | Returns whether the control is disabled or not. |
| `setDisabled(bool)` | -- | Sets disabled value (true or false) to control. |
| `setNotification(message: string, uniqueId?: string)` | Boolean | Displays an error message for the control to indicate that data isn’t valid. When this method is used,  a red cross icon appears next to the control within the cell. Hovering over the error icon will display the provided message. Selecting the error icon will reload the row and undo any changes. The `uniqueId` is used to clear this message when using the `clearNotification` method. |
| `clearNotification(uniqueId?: string)` | Boolean | Removes a message that is already displayed for a control. If no unique ID is provided, all notifications for that control are removed. |


> [!NOTE]
> The function names in JavaScript file should match the event names and must accept context object parameter. More information: [Forecasting related events](../events/forecasting-events.md).  

<a name=make-grid-read-only></a>
**Example 1:**

Let's create a JavaScript to make an editable forecasting grid READ-ONLY. Also, the `onRowLoad` function is called for each row when the grid is loaded and saved successfully. 
 
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

Let's create a JavaScript to disable all fields except few for Opportunity entity only. Also, the `OnRowLoad` function is called for each row when the grid is loaded and saved successfully.

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

Let's create a JavaScript to handle different entities for the loaded forecast configuration. 

For an Opportunity entity, the script will disable the following: 
- Name column
- actualRevenue and actualCloseData if the forecastCategory value is in best case, committed, omitted, or pipeline.
- estimatedRevenue & estimatedCloseDate if forecastCategory value is in won or lost.

Similarly, the script will disable name column for Account entity and disable all columns for other entities.

Also, the `OnRowLoad` function is called for each row when the grid is loaded and saved successfully.
 

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

Let's create a validation JavaScript that will block save and show error notification on estimated revenue column when the value is less than 10. Also, the error notification will be removed and save is allowed when the estimated revenue column value is corrected to be greater than or equal to 10. Here, `OnChange` function is invoked when any field's value is updated on the editable grid.

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
| `retrieveRecord(entityLogicalName, id, options)`<br>`then (successCallback, errorCallback);` | Retrieves an entity record. More information: [retrieveRecord (Client API reference)](https://docs.microsoft.com/powerapps/developer/model-driven-apps/clientapi/reference/xrm-webapi/retrieverecord). |
| `updateRecord(entityLogicalName, id, data)`<br>`then(successCallback, errorCallback);` | Updates an entity record. More information: [updateRecord (Client API reference)](https://docs.microsoft.com/powerapps/developer/model-driven-apps/clientapi/reference/xrm-webapi/updaterecord). |
| `createRecord(entityLogicalName, data)`<br>`then(successCallback, errorCallback);` | Creates an entity record. More information: [createRecord (Client API reference)](https://docs.microsoft.com/powerapps/developer/model-driven-apps/clientapi/reference/xrm-webapi/createrecord). |
| `deleteRecord(entityLogicalName, id)`<br>`then(successCallback, errorCallback);` | Deletes an entity record. More information: [deleteRecord (Client API reference)](https://docs.microsoft.com/powerapps/developer/model-driven-apps/clientapi/reference/xrm-webapi/deleterecord). |

<a name=api-context-geteventargs-preventdefault></a>
### context.getEventArgs().preventDefault()

The `preventDefault()` method is available only within the `OnSave` event. Calling this method within `OnSave` prevents the save event from proceeding. 

<a name=block-autosave-based-on-estimated-revenue-value></a>
**Example:**

Let's create a sample JavaScript to open opportunities grid, and block auto save event and open a window alert if estimated revenue value is less than 10. Also, allow auto save event if the estimated revenue value is greater than or equal to 10.

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

[Customize underlying records](https://docs.microsoft.com/dynamics365/sales-enterprise/forecast-configure-advanced-settings#customize-underlying-records)

[Forecasting related events](../events/forecasting-events.md)
