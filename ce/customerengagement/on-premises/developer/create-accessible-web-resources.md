---
title: "Create accessible web resources (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "The topic introduces general guidance and links to more resources that will help you design web resource user interface elements that are accessible to people with disabilities."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 6235894d-218b-4ac7-8edd-0dd0517a5f0d
caps.latest.revision: 22
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Create accessible web resources

When you include web resources that provide user interface elements in your solution, make sure that you include requirements that let people with disabilities use your web resources.  
  
 The [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] application user interface elements follow standards and best practices that will allow for equivalent functionality for all users. People with disabilities may rely on the use of assistive technology (AT) such as screen readers or a variety of alternative input devices to interact with applications.  
  
 This topic introduces general guidance and links to more resources that will help you design web resource user interface elements that are accessible to people with disabilities.  
  
<a name="BKMK_AT"></a>   
## Assistive technology  
 There are a variety of assistive technology (AT) applications that include screen readers, Braille terminals, and speech recognition software. These applications provide an intermediary with your user interface elements so that people using the AT application can use your program.  
  
 For Windows applications, the Microsoft UI Automation (UIA) classes provide programmatic access to user interface elements. These classes support both automated testing and AT. AT applications can use the properties and elements defined by the developer and exposed through UIA. A windows application developer has considerable control over how their UI elements are exposed by using UIA.  
  
 For web applications, certain HTML elements are exposed through the Document Object Model (DOM). The browser converts DOM elements to UIA objects with properties and events that AT can use to enable the user to use the web application. The developer has limited control over how the UI elements are exposed by the browser that uses UIA.  
  
<a name="BKMK_HTMLWebResources"></a>   
## Accessible HTML web resources  
 The HTML in your web resources is processed by the browser and made available to AT applications.  
  
 The first thing to consider is making sure that your HTML follows expected patterns of usage. For example, you can define an HTML `div` element with a click event so that it functions exactly like an HTML `button` element. However, the browser will not expect that a `div` element is being used as a button and will not expose the same properties and events to an AT application.  
  
 It is important that you use the correct HTML elements for the types of interactions users will have with your web resources. This is known as [semantic HTML](https://msdn.microsoft.com/gg671917.aspx).  
  
 However, semantic HTML can only go so far. Modern web applications typically include custom controls that are composed of many HTML elements working together. Page content that is frequently updated dynamically using asynchronous [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] is confusing for AT applications that rely only on semantic HTML. [Accessible Rich Internet Applications (ARIA)](https://msdn.microsoft.com/gg671918.aspx) technology provides a solution by extending HTML with additional attributes that communicate custom semantics.  
  
 ARIA provides a standard set of extended attributes that can be applied to HTML elements that are used in a control, or “widget.” These attributes describe the role that the HTML element plays in the control. ARIA also provides capabilities to improve the navigation experience and make the user aware of elements that may be updated dynamically. The recommended practice is to layer ARIA over semantic HTML.  
  
 In addition to including support for AT, there are other requirements you have to consider. For example, how does the UI adjust when the user increases the text size? Does your UI require that the user be able to differentiate colors to perform tasks? Can all actions be performed by using a keyboard? For more information, see [Introduction to Web Accessibility](https://msdn.microsoft.com/windows/gg671915).  
  
<a name="BKMK_SilverlightWebResources"></a>   
## Accessible Silverlight web resources  
 [!INCLUDE[pn_Silverlight_short](../includes/pn-silverlight-short.md)] web resources are hosted in a [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] form or an HTML web resource and the UI is rendered by the [!INCLUDE[pn_Silverlight_short](../includes/pn-silverlight-short.md)] browser plug-in. [!INCLUDE[pn_Silverlight_short](../includes/pn-silverlight-short.md)] is a subset of the Windows Presentation Framework (WPF) and therefore programmatic access and AT are exposed by using UIA that resembles WPF windows applications. For more information, see [Silverlight Accessibility for Developers](https://msdn.microsoft.com/windows/gg591270).  
  
<a name="BKMK_AccessiblityTestingTools"></a>   
## Accessibility testing tools  
 The following list provides some publicly available accessibility testing tools:  
  
 [Visual Studio Accessibility Checker](https://msdn.microsoft.com/library/ms228004)  
 If you are using [!INCLUDE[pn_Visual_Studio](../includes/pn-visual-studio.md)] to edit your HTML web resource files, you will find that there are built-in tools to check for issues related to accessibility. In the **Tools** menu, select **Check Accessibility** to see a report that will provide guidance about accessibility related issues.  
  
 [UI Accessibility Checker](https://acccheck.codeplex.com/)  
 UI Accessibility Checker (or AccChecker) enables testers to easily discover accessibility problems with [!INCLUDE[cc_Microsoft](../includes/cc-microsoft.md)] Active Accessibility (MSAA) and other user interface (UI) implementations for [!INCLUDE[pn_ms_Windows_short](../includes/pn-ms-windows-short.md)]. AccChecker was born from the realization that existing [!INCLUDE[pn_ms_Windows_short](../includes/pn-ms-windows-short.md)] Automation API tools, such as Inspect, provided in-depth details on the implementation, but no information about whether that implementation is correct or not.  
  
 [Inspect (Inspect.exe)](https://msdn.microsoft.com/library/windows/desktop/dd318521\(v=vs.85\).aspx)  
 Inspect (Inspect.exe) is a Windows-based tool that enables you select any UI element and view the element's accessibility data. You can view Microsoft UI Automation properties and control patterns in addition to Microsoft Active Accessibility properties. Inspect also enables you to test the navigational structure of the automation elements in the UI Automation tree, and the accessible objects in the Microsoft Active Accessibility hierarchy  
  
 [Accessible Event Watcher (AccEvent.exe)](https://msdn.microsoft.com/library/windows/desktop/dd317979\(v=vs.85\).aspx)  
 The Accessible Event Watcher (AccEvent) tool allows developers and testers to validate that an application's UI elements raise appropriate Microsoft UI Automation and Microsoft Active Accessibility events when UI changes occur. Changes in the UI can occur when the focus changes, or when a UI element is invoked, selected, or has a state or property change.  
  
<a name="BKMK_AdditionalResources"></a>   
## Additional resources  
 The following resources provide a starting point for defining requirements for making your web resources accessible:  
  
-   [CRM, Accessibility, and 508](https://blogs.msdn.com/b/devkeydet/archive/2013/01/29/crm-accessibility-and-508.aspx)  
  
-   [Introduction to Web Accessibility](https://msdn.microsoft.com/windows/gg671915)  
  
-   [Accessibility in Visual Studio and ASP.NET](https://msdn.microsoft.com/library/ms228004)  
  
-   [Silverlight Accessibility for Developers](https://msdn.microsoft.com/windows/gg591270)  
  
-   [Accessibility Overview](https://msdn.microsoft.com/windows/bb735024.aspx)  
  
-   [Accessibility - W3C](https://www.w3.org/standards/webdesign/accessibility)  
  
-   [Web Content Accessibility Guidelines (WCAG) 2.0](https://www.w3.org/TR/WCAG20/)  
  
### See also  
 [Web Page (HTML) Web Resources](webpage-html-web-resources.md)   
 [Silverlight (XAP) Web Resources](silverlight-xap-web-resources.md)   
 [Web Resources for Dynamics 365 Customer Engagement (on-premises)](web-resources.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]