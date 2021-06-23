---
title: "Use localized labels with ribbons (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Learn about using localized labels with ribbons."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - ribbon, labels
ms.assetid: 8f5c65a8-3134-46a9-aee5-8d876e045f1e
caps.latest.revision: 14
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Use localized labels with ribbons

Although Ribbon elements that display text allow for direct entry of text, it is a best practice to use localized labels to define text displayed in the ribbon. This enables multi-language capabilities and better management of shared text.  
  
## Using localized labels  
 The `<RibbonDiffXml>` element includes the `<LocLabels>` element. 
 As shown in the following example, this is where you can specify which text to display in the ribbon labels and tooltips using the `<Titles>` element.  
  
```xml  
<LocLabels>  
 <LocLabel Id="MyISV.account.SendToOtherSystem.LabelText">  
  <Titles>  
   <Title languagecode="1033"  
          description="Send to Other System" />  
  </Titles>  
 </LocLabel>  
 <LocLabel Id="MyISV.account.SendToOtherSystem.ToolTip">  
  <Titles>  
   <Title languagecode="1033"  
          description="Sends this Record to another system" />  
  </Titles>  
 </LocLabel>  
</LocLabels>  
```  
  
 Within the definition of a ribbon element that displays text, the following example show how the localized label can be referenced using the `$LocLabels:` directive.  
  
```xml  
ToolTipTitle="$LocLabels:MyISV.account.SendToOtherSystem.LabelText"  
ToolTipDescription="$LocLabels:MyISV.account.SendToOtherSystem.ToolTip"  
```  
  
## Force a line break in a ribbon control label  
 If you have a ribbon control label that is very long, the text will wrap to fit the available space. You can specify where you want to include a line break by using the following characters: `&#x200b;&#x200b;`.  
  
 If the label text is very long without a space for the text to wrap, the width of the control expands to allow for the entire label to be displayed.  
  
### See also  
 [Customize commands and the ribbon](customize-commands-ribbon.md)   
 [Export, Prepare to Edit, and Import the Ribbon](export-prepare-edit-import-ribbon.md)   
 [Use Localized Labels with Ribbons](use-localized-labels-ribbons.md)   
 [Define Ribbon Commands](define-ribbon-commands.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]