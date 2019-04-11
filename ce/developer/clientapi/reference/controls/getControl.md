---
title: "getControl (Client API reference) in Dynamics 365 for Customer Engagement| MicrosoftDocs"
ms.date: 10/31/2017
ms.service: crm-online
ms.topic: reference
applies_to: Dynamics 365 for Customer Engagement (online)
ms.assetid: 34715e1f-35c0-4b7f-971e-e0a6518f0722
author: KumarVivek
ms.author: kvivek
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# getControl (Client API reference)

[!INCLUDE[](../../../../includes/cc_applies_to_update_9_0_0.md)]

Gets a control on the form. 

## Syntax

`formContext.getControl(arg);`

The **formContext.getControl(arg)** method is a shortcut method to access **formContext.ui.controls.get**.

## Examples 
### Example 1: GetControl for single attribute
```JavaScript
function attachEvents() {
        if (formContext.getControl(FIELD.NAME) != null) {
            formContext.getControl(FIELD.NAME).addPreSearch(<CustomFilterCriteria>);
        }
        }
```
### Example 2: GetControl for multiple attributes
The following sample code sets the visibility propert for multiple controls:
```JavaScript
function SetVisibile(visible) {
        var fieldIds = [FIELD.NAME, FIELD.CITY, FIELD.PROVINCE_NAME, FIELD.REGION_NAME];
        for (var i = 0; i < fieldIds.length; i++) {
            var field = formContext.getControl(fieldIds[i]);
            if (field != null && field != undefined) {
                field && field.setVisible(visible);
            }
            else {
                visible = false;
            }
        }
 ```       
## Parameter

**arg**: Optional. You can access a control on a form by passing an argument as either the **name** or the **index valu**e of the control on a form. For example: `formContext.getControl("firstname")` or `formContext.getControl(0)`


## Return Value

**Type**: Object or Object collection.

**Description**: Object if you use the method with parameter; object collection if you use the method without any parameters.



### Related topics

[formContext](../../clientapi-form-Context.md)



