---
title: "Condition Algorithm | MicrosoftDocs"
description: "The topic describes the groupings of a control that needs to be uniquely identified by specifying some property condition to distinguish it from other controls."
ms.custom:
  - dyn365-USD
ms.date: 08/23/2017
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2013"
  - "Dynamics CRM 2015"
  - "Dynamics CRM 2016"
ms.assetid: 855ec0d6-33a4-450f-a77a-b580b2b24946
caps.latest.revision: 7
author: kabala123
ms.author: kabala
manager: sakudes
---
# Condition Algorithm
A control needs to be uniquely identified by specifying some property condition to distinguish it from other controls. This topic describes the groupings that help specify the condition.  
  
## Conditions to uniquely identify the controls  
  
-   `NoCondition`:  `NoCondition` should be given to specify the first element of the tree.  
  
-   `PropertyCondition`: It specifies the actual property and the expected value. The following is an example.  
  
    ```xml  
    <PropertyCondition Name="ControlType">ControlType.Pane</PropertyCondition>  
  
    ```  
  
     This condition specifies that `ControlType` should be `"ControlType.Pane".`  
  
-   `AndCondition`:  
  
    -   This groups the property conditions and results in TruePositive if all the property conditions are satisfied.  
  
    -   A minimum of two conditions must be given inside an `AndCondition` group. The following is an example.  
  
        ```xml  
        <AndCondition Id="SearchCondition">  
        <PropertyCondition Name="Name">System and Security</PropertyCondition>  
        <PropertyCondition Name="ControlType">Hyperlink</PropertyCondition>  
        </AndCondition>  
  
        ```  
  
         This condition specifies that both the `ControlType` and `Name` properties need to be satisfied. The `Name` and the `Value` can be determined from the UISpy details of the control.  
  
-   `OrCondition`:  
  
    -   This groups the property conditions and results in `TruePositive` if any one of the property conditions is satisfied.  
  
    -   A minimum of two conditions should be given inside the `OrCondition` group. The following is an example.  
  
        ```xml  
        <OrCondition Id="SearchCondition">  
        <PropertyCondition Name="Name">System and Security</PropertyCondition>  
        <PropertyCondition Name="ControlType">Hyperlink</PropertyCondition>  
        </OrCondition>    
        ```  
  
         This condition specifies that either `ControlType` or `Name` property needs to be satisfied. The `Name` and the `Value` can be determined from the UISpy details of the control.  
  
-   `NotCondition`:  
  
    -   This groups the property conditions and results in `TruePositive` if the property conditions are not satisfied.  
  
    -   Only one condition can be given inside a `NotCondition` group. The following is an example.  
  
        ```xml  
        <NotCondition Id="SearchCondition">  
        <PropertyCondition Name="Name">System and Security</PropertyCondition>  
        </NotCondition>  
  
        ```  
  
         This condition specifies if the `Name` property condition is not satisfied. The `Name` and the `Value` can be determined from the UISpy details of the control.  
  
-   `NestedCondition`:  
  
    -   The nested grouping must be specified, such as an `OrCondition` in an `AndCondition`. The final child condition should be a `PropertyCondition`.  
  
    -   Any property of following type can be included in the condition:  
  
        -   `System.Boolean`  
  
        -   `System.String`  
  
        -   `System.Windows.Rect`  
  
        -   `System.Windows.Point`  
  
        -   `System.Windows.Automation.OrientationType`  
  
        -   `System.Windows.Automation.ControlType`  
  
### See also  
 [UIADDA](../unified-service-desk/uiadda.md)   
 [Use Data Driven Adapters (DDAs)](../unified-service-desk/use-data-driven-adapters-ddas.md)
