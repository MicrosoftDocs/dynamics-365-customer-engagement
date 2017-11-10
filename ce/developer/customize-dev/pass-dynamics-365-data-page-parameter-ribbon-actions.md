---
title: "Pass Microsoft Dynamics 365 data from a page as a parameter to Ribbon Actions (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The topic describes options for using the <CrmParameter> element to retrieve these values. "
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
helpviewer_keywords: 
  - "ribbon, pass data to"
ms.assetid: 15245f11-a7e6-445a-8f18-06765268f1ad
caps.latest.revision: 23
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Pass Microsoft Dynamics 365 data from a page as a parameter to Ribbon Actions

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

When you define an action in a ribbon, you frequently have to pass data from the page to either a [!INCLUDE[pn_JavaScript](../../includes/pn-javascript.md)] function or a URL. 
This topic describes options for using the `<CrmParameter>` element to retrieve these values.  
  
## Grid values  
 The majority of the values available for the `<CrmParameter>` element are related to working with data displayed in a grid or hierarchy chart. By using the `Value` attribute enumeration options, you can easily isolate items by:  
  
- **Selected items**  
  
    -   SelectedControlSelectedItemCount  
  
    -   SelectedControlSelectedItemIds  
  
    -   SelectedControlSelectedItemReferences  
  
- **All items**  
  
    -   SelectedControlAllItemCount  
  
    -   SelectedControlAllItemIds  
  
    -   SelectedControlAllItemReferences  
  
- **Unselected items**  
  
    -   SelectedControlUnselectedItemCount  
  
    -   SelectedControlUnselectedItemIds  
  
    -   SelectedControlUnselectedItemReferences  
  
 For each of these groupings, you can gather the number of items and the GUID identifier. If you are passing the values to a URL, you can also retrieve `EntityReference` objects that contain all the information that you need to uniquely identify the objects in the grid. These parameters apply whether the page viewed is the main grid (`HomepageGrid`) or a sub grid located in a form. When used together with the `SelectedEntityTypeName` parameter, you have all the information that you must have to pass to another application.  
  
## Form values  
 With a form ribbon, you can use the `formContext.data.entity`.[attributes](../clientapi/reference/collections.md) collection and the `formContext.ui`.[controls](../clientapi/reference/collections.md) collection to retrieve values for known fields. For more information about **formContext**, see [Client API form context](../clientapi/clientapi-form-context.md). 

However, if you want to pass the value of a selected form field, you’ll have to do more scripting to get the value. You can use the `PrimaryControlId` parameter to get the Id value for the control that has focus when the ribbon control received focus. This Id is the Document Object Model (DOM) Id value. To get the data value, you will have to try using that value by using code such as that in the following example:  
  
```javascript  
function myFunction(executionContext) {
    var formContext = executionContext.getFormContext();
    varFocusFieldValue = formContext.ui.controls.get(PrimaryControlId).getAttribute().getValue();
}  
```  
  
## Context information  
 In addition to data values, you can retrieve additional context information by using `<CrmParameter>`.  
  
 For convenience, the `Value` attribute options `OrgName`, `OrgLcid`, and `UserLcid` are available.
 
 For a `<Url>` action, you can also use the `PassParams` attribute to include contextual information.  
  
 `Value` options `PrimaryEntityTypeName` and `FirstPrimaryItemId` provide information for an entity record. You can use `PrimaryItemIds` for a `HomepageGrid` ribbon to get a list of all the displayed items.  
  
 Finally, you can use the `CommandProperties` value to pass details about the event from the ribbon control. You can use this to send contextual information to a central function where specific actions can be determined based on the context of the event.  
  
### See also  
 [Customize the Ribbon for Microsoft Dynamics 365](customize-commands-ribbon.md)   
 [Passing Parameters to a URL using the Ribbon](pass-parameters-url-by-using-ribbon.md)    
 [Define Ribbon Actions](define-ribbon-actions.md)   
 [Define Custom Actions to modify the Ribbon](define-custom-actions-modify-ribbon.md)
