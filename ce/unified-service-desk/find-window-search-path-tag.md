---
title: "FindWindow search path tag in Unified Service Desk | MicrosoftDocs"
description: "<FindWindow> tag contains a list of matching elements that are executed in the order of their listing within the tag. This topic describes the <FindWindow> elements with example code."
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
# FindWindow search path tag in Unified Service Desk
`<FindWindow>` tag contains a list of matching elements that are executed in the order of their listing within the tag. This topic describes the `<FindWindow>` elements with example code.  
  
<a name="elements"></a>   
## \<FindWindow> elements  
 The following code snippet shows the elements in a `<FindWindow>` tag  
  
```vb  
# RELAX NG XML grammar for FindWindow   
# https://relaxng.org/compact-tutorial-20030326.html   
#   
Grammar  
{   
start = FindWindow FindWindow = element   
FindWindow  
{   
  element ControlId { attribute match { xsd:integer }?, text }*  
& element Caption { attribute match { xsd:integer }?, text }*  
& element CaptionStartsWith { same as Caption }*  
& element CaptionEndsWith { same as Caption }*  
& element CaptionContains { same as Caption }*  
& element Class { attribute match { xsd:integer }?, text }*  
& element ClassStartsWith { same as Class }*  
& element ClassEndsWith { same as Class }*  
& element ClassContains { same as Class }*  
& element Position { xsd:integer, xsd:integer } *  
& element Find { Caption & Class }*  
& element Desktop { empty }*  
& element Application { empty }*  
& element Owner { empty }*  
& element RelaxProcessIdRestriction { empty }*  
& element RelaxThreadIdRestriction { empty }*  
}  
}  
  
```  
  
 The following table describes the `<FindWinow>` elements.  
  
|Element|Description|  
|-------------|-----------------|  
|`ControlId`|Window with ID|  
|`Caption`|Window caption text.|  
|`CaptionStartsWith`|Caption starts with text|  
|`CaptionEndsWith`|Caption ends with text.|  
|`CaptionContains`|Caption contains text.|  
|`Class`|Window with class name|  
|`ClassStartsWith`|Class name starts with text.|  
|`ClassEndsWith`|Class name ends with text.|  
|`ClassContains`|Class contains text.|  
|`Position`|Search for a window at a specified position. The position is defined as the upper-left corner of the window as (x,y) coordinates. The position is calculated either from the \<Application/> (default) or from the \<Desktop/>. If \<Desktop/> is used, it must be specified before the \<Position> element.|  
|Find|Search for a window as specified via the `Class` or `Caption` element. The same elements as for `FindWindow` can be used here (`Caption`,  `CaptionStartsWith`,  `CaptionEndsWith`,  `CaptionContains`,  `Class`,  `ClassStartsWith`,  `ClassEndsWith`, or `ClassContains`).|  
|`Desktop`|Sets the search point to the desktop|  
|`Application`|Sets the search point to the application's top-level window.|  
|`Owner`|Window with a specified owner.|  
|`RelaxProcessIdRestriction`|Includes windows with different process IDs in the search. By default, all windows belong to the same process ID.|  
|`RelaxThreadIdRestriction`|Includes windows with different thread IDs in the search process. By default, all windows belong to the same thread ID.|  
  
<a name="samplecode"></a>   
## Sample code  
 The following set of samples show the how the various attributes are used.  
  
```xml  
The following sample searches for a window with the control ID 1003.  
<FindWindow>  
<ControlID>1003</ControlID>  
</FindWindow>  
  
The following sample searches for a window with the class name SunAWTFrame.  
<FindWindow>  
<Class>SunAWTFrame</Class>  
</FindWindow>  
  
The following sample searches for a window at desktop position x200 y400.   
<FindWindow>  
<Desktop/>  
<Position>200,400</Position>  
</FindWindow>  
  
The following sample searches for the second application with the caption CurrencyConv that is not within the same process as the DDA loaded application.   
  
<FindWindow>  
<RelaxProcessIdRestriction/>  
<Caption match="2">CurrencyConv</Caption>  
</FindWindow>  
  
```  
  
### See also  
 [JavaDDA](../unified-service-desk/javadda.md)   
 [Use Data Driven Adapters (DDAs)](../unified-service-desk/use-data-driven-adapters-ddas.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]