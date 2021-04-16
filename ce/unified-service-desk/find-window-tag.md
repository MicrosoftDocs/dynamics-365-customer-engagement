---
title: "FindWindow Tag in Unified Service Desk | MicrosoftDocs"
description: "The <FindWindow> tag consists of a list of child elements that represent a sequence of match operations, all of which need to succeed for the target window to be considered found."
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
# FindWindow Tag in Unified Service Desk
The `<FindWindow>` tag consists of a list of child elements that represent a sequence of match operations, all of which need to succeed for the target window to be considered found.  
  
 The following code snippet shows how the various `<FindWindow>` elements are used to find the target window:  
  
```xml  
# RELAX NG XML grammar for FindWindow  
# https://relaxng.org/compact-tutorial-20030326.html  
#  
grammar {  
   start      = FindWindow  
   FindWindow = element FindWindow {  
element ControlId { attribute match { xsd:integer }?, text }*  
& element Caption { attribute match { xsd:integer }?, text }*  
& element CaptionStartsWith { same as Caption }*  
& element CaptionEndsWith { same as Caption }*  
& element CaptionContains { same as Caption }*  
& element Class { attribute match { xsd:integer }?, text }*  
& element ClassStartsWith { same as Class }*  
& element ClassEndsWith { same as Class }*  
& element ClassContains { same as Class }*  
& element Find { Caption & Class }*  
& element Desktop { empty }*  
& element Application { empty }*  
& element Owner { empty }*  
& element RelaxProcessIdRestriction { empty }*  
& element RelaxThreadIdRestriction  { empty }*  
}  
}  
  
```  
  
### \<FindWindow> tag elements  
 The following table describes the various elements of the `<FindWindow>` tag:  
  
|Element|Description|  
|-------------|-----------------|  
|ControlId|Window with ID.|  
|Caption|Window caption text.|  
|CaptionStartsWith|Caption starts with text.|  
|CaptionEndsWith|Caption ends with text.|  
|CaptionContains|Caption contains text.|  
|Class|Window with class name.|  
|ClassStartsWith|Class name stats with text.|  
|ClassEndsWith|Class name ends with text.|  
|ClassContains|Class contains text.|  
|Find|Searches for window as specified via `Class` or `Caption` element.|  
|Desktop|Sets the search point to the desktop.|  
|Application|Sets the search point to the applications top-level window.|  
|Owner|Window with specified owner.|  
|RelaxProcessIdRestriction|Includes windows with different process IDs in search. By default, all windows belong to the same process ID.|  
|RelaxThreadIdRestriction|Includes windows with different thread ID in search process. By default all windows belong to the same thread ID.|  
  
 The following XML shows control definition using the **\<FindWindow>** tag.  
  
```xml  
<FindWindow>  
<Desktop/>  
<Caption match="1">Font</Caption>  
<Class>#32770</Class>  
<Caption>OK</Caption>  
</FindWindow>  
<FindWindow>  
<Application/>  
<ControlId>7d</ControlId>  
</FindWindow>  
<FindWindow>  
<Desktop/>  
<Class>Notepad</Class>  
</FindWindow>  
  
```  
  
 In the preceding `XML` example, the elements have the following definitions:  
  
- `<Application/>` – Sets the context window to the top-level window of the application. By default, the context is initialized to the top-level window before the first child node in \<FindWindow/>.  
  
- `<Desktop/>` – Sets the context window to the root-level desktop window.  
  
- \<Caption match="1">Font\</Caption> – Searches the window hierarchy, starting at the current context window and working down the hierarchy, for the first window with caption text that matches the text provided. If `match="2"`, it searches for the second window with caption text that matches the provided text. If no `match` attribute is provided,  `match="1"` is the default. The text comparison is a substring match against the caption text. If the provided text can be found as a substring in the subject window's caption, it is considered a match. The successful matching window becomes the new context window. If no match is found, the search fails. By default, only windows that belong to the same `ProcessId` and `ThreadId` are considered a match.  
  
- `<Class>#32770</Class>` – Searches the window hierarchy, for the first window with class text that matches the provided text. All other behavioral details are identical to `<Caption/>.`  
  
- `<ControlId>7d</ControlId>` – Searches the window hierarchy, for the first window with a control ID that matches the provided value. This must be an exact match. All other behavioral details are identical to `<Caption/>`.  
  
  The following XML searches for the window with the caption **OK** in the first window with the caption **Font** and the class ID 32770, starting at the desktop.  
  
```xml  
<FindWindow>  
<Desktop/>  
<Caption match="1">Font</Caption>  
<Class>#32770</Class>  
<Caption>OK</Caption>  
</FindWindow>  
  
```  
  
 The following `XML` looks for the window with Control ID 7D, starting at the application's top-level window.  
  
```xml  
<FindWindow>  
<Application/>  
<ControlId>7d</ControlId>  
</FindWindow>  
  
```  
  
 The following `XML` searches for the (first) window with the class name **Notepad**, starting at the desktop.  
  
```xml  
<FindWindow>  
<Desktop/>  
<Class>Notepad</Class>  
</FindWindow>  
  
```  
  
### See also  
 [Win DDA](../unified-service-desk/windda.md)   
 [Use Data Driven Adapters (DDAs)](../unified-service-desk/use-data-driven-adapters-ddas.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]