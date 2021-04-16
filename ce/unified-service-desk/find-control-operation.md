---
title: "FindControl Operation in Unified Service Desk | MicrosoftDocs"
description: "The topic describes the two approaches that can be used to identify a user interface (UI) control."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/23/2017
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-USD
search.audienceType: 
  - customizer
  - developer
search.app: 
  - D365CE
  - D365USD
---
# FindControl Operation in Unified Service Desk
This topic describes the two approaches that can be used to identify a user interface (UI) control.  
  
<a name="tree"></a>   
## UI Tree-based identification  
 This approach captures the complete control tree structure. It uses all the control properties to traverse to the final control.  
  
 The following is a sample binding format:  
  
```xml  
<UIElement Name="UISystemandSecurityHyperlink">  
<UIObject MatchCount="1">                              
              <AndCondition>  
                <PropertyCondition Name="Name">CPCategoryPanel</PropertyCondition>  
                <PropertyCondition Name="ControlType">Pane</PropertyCondition>  
              </AndCondition>  
                <UIObject>                                     
                  <AndCondition>  
                    <PropertyCondition Name="Name">System and Security</PropertyCondition>  
                    <PropertyCondition Name="ControlType">Hyperlink</PropertyCondition>  
                  </AndCondition>                    
                </UIObject>  
            </UIObject>  
<UIElement>  
  
```  
  
 The tags are explained as follows:  
  
-   `<UIElement>` – This is the root node, which has the `Name` attribute:  
  
    -   `Name` – Captures the friendly name that will be used in the DDA.  
  
    -   `StartFromDesktop` – Specifies if the search is from the desktop or the current parent.  
  
    -   `ParentUIElement` – Specifies the `UIElement` that needs to be taken as a parent control. For the buttons, "pane" needs to be specified as `ParentUIElement`. This will be useful when you create a binding manually.  
  
    -   `MatchCount` – Specifies the match count. If more than one control has the same properties, it will be identified based on this index.  
  
-   `<UIObject>` – This node captures the complete tree structure to identify the control:  
  
    -   `<PropertyCondition Name="Name">CPCategoryPanel</PropertyCondition>` – Captures the property condition that the control is searched for. This will be grouped in the `AndCondition/OrCondition/NotCondition`. If there is only one `PropertyCondition`, it should be presented in root node without any grouping.  `Name` represents the name of the control property.  
  
    -   `AndCondition`,  `OrCondition`, and `NotCondition` – Grouping conditions for the property condition.  
  
    -   `<AndCondition Id="SearchCondition">` – Captures the property condition with which the control can be identified.  `Id` represents the condition list ID. More than one `AndCondition` can be used when grouping is provided later.  
  
    -   `<OrCondition Id="SearchCondition">` – Captures the property condition with which the control can be identified.   `Id` represents the condition list ID. More than one `OrCondition` can be used when grouping is provided later.  
  
    -   `<NotCondition Id="SearchCondition">` – Captures the property condition with which the control can be identified.  `Id` represents the condition list ID. More than one `NotCondition` can be used when grouping is provided later.  
  
    -   `AndCondition`,  `NotCondition`, and `OrCondition` – Can be nested, but they should be grouped correctly. The top XML bindings should have only one condition, and they can be internally grouped.  
  
<a name="offset"></a>   
## Offset-based Identification  
 This approach is very easy to use and also builds the bindings.  
  
> [!NOTE]
>  This approach is not usable when the control tree location keeps changing, because it uses the position number in the UI Tree to identify the controls. If the UI Tree position gets changed dynamically, this approach is unusable.  
  
 `MatchCount` attribute will be used as an offset level. Conditions shall be provided if required.  
  
 The following shows a sample binding format.  
  
```xml  
<UIElement name="textBoxTabPage1">  
          <UIObject MatchCount="2">              
            <UIObject  MatchCount="1">               
              <UIObject   MatchCount="2">                  
              </UIObject>  
            </UIObject>  
          </UIObject>  
        </UIElement>  
  
```  
  
### See also  
 [UIADDA](../unified-service-desk/uiadda.md)   
 [Use Data Driven Adapters (DDAs)](../unified-service-desk/use-data-driven-adapters-ddas.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]