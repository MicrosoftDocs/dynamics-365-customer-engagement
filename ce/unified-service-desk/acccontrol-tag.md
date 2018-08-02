---
title: "AccControl Tag | MicrosoftDocs"
description: "Learn about the AccControl tag that uses the IAccessible interface from Microsoft Active Accessibility (MSAA)."
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
ms.assetid: e4d9d212-1709-4983-8d57-9359cda932fd
caps.latest.revision: 8
author: kabala123
ms.author: kabala
manager: sakudes
---
# AccControl Tag
The `AccControl` tag uses the [IAccessible](https://msdn.microsoft.com/library/accessibility.iaccessible\(v=vs.110\).aspx) interface from Microsoft Active Accessibility (MSAA). The AccControl tag has:  
  
-   `Name` property to define the user-accessible (friendly) name for a control.  
  
-   `Path` tag to define a search path for the control in the application's `IAccessibility` tree. The `<Path>` tag contains the following: [FindWindow Tag](../unified-service-desk/find-window-tag.md) and [Next Tag](../unified-service-desk/next-tag-windda.md).  
  
 The following XML example shows a control definition using the `AccControl` tag.  
  
```xml  
<AccControl name="Control Name">  
   <Path>   
      <FindWindow>  
         <CaptionStartsWith>Customer App</CaptionStartsWith>  
      </FindWindow>  
      <Next/>  
      <Next match="2">Customer Name:</Next>  
   </Path>  
</AccControl>  
```  
  
> [!NOTE]
>  Some elements in the `Path` tag have a `<match>` attribute that you can use to add a counter to the search description. Both the following examples return the same search result, but the first example implements the `<match>` tag:  
>   
>  - **Example 1**  
>   
>     ```  
>     <Caption match="2">Test Application</Caption>  
>     ```  
> -   Example 2:  
>   
>     ```  
>     <Caption>Test Application</Caption>  
>     <Caption>Test Application</Caption>  
>     ```  
>   
>  If `<match>` isn’t specified, the default value is 0.  
  
 The [String)](https://docs.microsoft.com/dotnet/api/microsoft.uii.hostedapplicationtoolkit.datadrivenadapter.datadrivenadapterbase.getcontrolvalue\(system.string,system.string\)) method on an `AccControl` tag is always mapped to the `get_accValue` method on the subject `IAccessible` node, unless the node contains `role="radio button"` or `role="check box"`. In these cases, the [String)](https://docs.microsoft.com/dotnet/api/microsoft.uii.hostedapplicationtoolkit.datadrivenadapter.datadrivenadapterbase.getcontrolvalue\(system.string,system.string\)) method returns `True` or `False`, depending on whether the state of the node is selected.  
  
 The [String)](https://docs.microsoft.com/dotnet/api/microsoft.uii.hostedapplicationtoolkit.datadrivenadapter.datadrivenadapterbase.setcontrolvalue\(system.string,system.string,system.string\)) method on an `AccControl` tag is always mapped to the `set_accValue` method on the subject `IAccessible` node, with the exception of nodes that have `role="radio button"` or `role="check box"`. In the case of a radio button, an `UnsupportedControlOperation` exception is raised because a radio button can’t be assigned a `True` or `False` value.  
  
 The following example displays the [RELAX NG](http://relaxng.org/compact-tutorial-20030326.html) XML code for the \<Path> tag.  
  
```xml  
# RELAX NG XML grammar for Path  
# http://relaxng.org/compact-tutorial-20030326.html  
#  
grammar   
{  
   start = Path  
   Path = element Path   
   {   
      FindWindow* & element Next   
      { attribute match { xsd:integer }?  
      ,attribute offset { xsd:integer  }?,text? }*   
   }  
}  
```  
  
### See also  
 [Win DDA](../unified-service-desk/windda.md)   
 [Use Data Driven Adapters (DDAs)](../unified-service-desk/use-data-driven-adapters-ddas.md)
