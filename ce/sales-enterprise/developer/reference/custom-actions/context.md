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
# Context custom action

This custom action passes the forecasting context object to the event handlers. 

> [!NOTE]
> This context object is forecasting context though API structure looks similar.

## context.getFormContext method

Returns a reference to a record on the forecasting editable grid.

### context.getFormContext().data.entity

This returns an entity object and has the following methods:

| Method | Description |
|--------|-------------|
| `getEntityName():string` | Returns a string representing the logical name of the entity for the record. |
| `getId():string` | Returns a string representing the GUID value for the record. |
| `attributes` | Returns a list of attributes that are related to the view and entity that is loaded as part of forecasting editable grid. You can perform the following operations:<br>- `context.getFormContext().data.entity.attributes.forEach` <br>- `context.getFormContext().data.entity.attributes.getByName(arg)`<br>- `context.getFormContext().data.entity.attributes.get(index)` |

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

### context.getFormContext().data.entity.attributes.getByName("<Attr Name>")

This returns an attribute object and has the following methods:

| Method | Description |
|--------|-------------|
| `getName():string` | Returns a string that represents the logical name of the attribute. |
| `getValue()` | Retrieves the data value for an attribute. |
| `getIsDirty():boolean` | Returns a boolean value indicating if there are any unsaved changes to the attribute value. |
| `controls` | Returns a list of controls for each attribute object. <br> **Note**: Controls object list length is always 1 and get(0) can be directly used. |

**Example:**

Let's create a validation JavaScript that will block save and show error notification on estimated revenue column when the value is less than 10. Also, the error notification will be removed and save is allowed when the estimated revenue column value is corrected to be greater than or equal to 10.

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
### context.getFormContext().data.entity.attributes.getByName("<Attr Name>").controls.get(0)

This returns a control object mapping to attribute and has the following methods:

| Method | Description |
|--------|-------------|
| `getDisabled():boolean` | Returns whether the control is disabled or not. |
| `setDisabled(bool)` | Sets disabled value (true or false) to control. |
| `setNotification(message: string, uniqueId?: string):boolean` | Displays an error message for the control to indicate that data isn’t valid. When this method is used,  a red cross icon appears next to the control within the cell. Hovering over the error icon will display the provided message. Selecting the error icon will reload the row and undo any changes. The `uniqueId` is used to clear this message when using the `clearNotification` method. |
| `clearNotification(uniqueId?: string): boolean` | Removes a message that is already displayed for a control. If no unique ID is provided, all notifications for that control are removed. |

**Example:**

Let's create a JavaScript to handle different entities for the loaded forecast configuration. 
For an Opportunity entity, the script will disable the following: 
- Name column
- actualRevenue and actualCloseData if the forecastCategory value is in bestcase, committed, omitted, or pipeline.
- estimatedRevenue & estimatedCloseDate if forecastCategory value is in won or lost.
Similarly, the script will disable name column for Account entity and disable all columns for other entities.
Also, the `onRowLoad` function is called for each row when the is grid loaded and saved successfully.
 

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

## context.getWebApiContext()

This returns a `webApiContext` object and has the following methods:

| Method | Description |
|--------|-------------|
| `retrieveRecord(entityLogicalName, id, options)`<br>`then (successCallback, errorCallback);` | Retrieves an entity record. More information: [retrieveRecord (Client API reference)](https://docs.microsoft.com/powerapps/developer/model-driven-apps/clientapi/reference/xrm-webapi/retrieverecord). |
| `updateRecord(entityLogicalName, id, data)`<br>`then(successCallback, errorCallback);` | Updates an entity record. More information: [updateRecord (Client API reference)](https://docs.microsoft.com/powerapps/developer/model-driven-apps/clientapi/reference/xrm-webapi/updaterecord). |
| `createRecord(entityLogicalName, data)`<br>`then(successCallback, errorCallback);` | Creates an entity record. More information: [createRecord (Client API reference)](https://docs.microsoft.com/powerapps/developer/model-driven-apps/clientapi/reference/xrm-webapi/createrecord). |
| `deleteRecord(entityLogicalName, id)`<br>`then(successCallback, errorCallback);` | Deletes an entity record. More information: [deleteRecord (Client API reference)](https://docs.microsoft.com/powerapps/developer/model-driven-apps/clientapi/reference/xrm-webapi/deleterecord). |

## context.getEventArgs().preventDefault()

The `preventDefault()` method is available only within the `OnSave` event. Calling this method within `OnSave` prevents the save event from proceeding. 

### See also

