---
title: "WinDDA events in Unified Service Desk | MicrosoftDocs"
description: "Learn about the Windows DDA (WinDDA) events in Unified Service Desk."
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
# WinDDA events
The [!INCLUDE[pn_ms_Windows_short](../includes/pn-ms-windows-short.md)] data-driven adapter (DDA) distinguishes between two types of events, application events and control events. This topic describes these two events.  
  
<a name="control"></a>   
## Control events  
 Control events are fired by controls in an application. For all of these events, the control name must be specified during registration (`RegisterActionForEvent`). The controls must also be accessible in the application during registration. You can use the [FindControl](/dotnet/api/microsoft.uii.hostedapplicationtoolkit.datadrivenadapter.operationtype.findcontrol) method or add an exception handler to ensure that the control is accessible.  
  
 The [!INCLUDE[pn_hosted_application_toolkit_hat](../includes/pn-hosted-application-toolkit-hat.md)] Software Factory lists the events that are supported for a specific User Interface (UI) control type. If you do not specify the type in the [!INCLUDE[pn_uii_acronym](../includes/pn-uii-acronym.md)] Inspector, [!INCLUDE[pn_uii_acronym](../includes/pn-uii-acronym.md)] lists all events for the control. All available control events are listed by the [!INCLUDE[pn_hosted_application_toolkit_hat](../includes/pn-hosted-application-toolkit-hat.md)] Software Factory if no control type is detected. The following table describes the supported control events.  
  
|Element|Description|  
|-------------|-----------------|  
|GotFocus|The event is raised when the control gets the focus.|  
|LostFocus|The event is raised when the control loses the focus.|  
|ButtonPressed|The event is raised when the button is clicked.|  
|ButtonReleased|The event is raised when the button is released.|  
|CheckBoxSet|The event is raised when the check box is selected.|  
|CheckBoxCleared|The event is raised when the check box is cleared.|  
|RadioButtonSet|The event is raised when the radio button is selected.|  
  
 The following table lists the events that each control supports.  
  
|Element|Description|  
|-------------|-----------------|  
|Push Button|ButtonPressed, ButtonReleased, GotFocus, LostFocus|  
|Check Box|GotFocus, CheckBoxSet, CheckBoxCleared, LostFocus|  
|Radio Button|GotFocus, RadioButtonSet, LostFocus|  
|Text|GotFocus, LostFocus|  
|Editable Text|GotFocus, LostFocus|  
  
<a name="application"></a>   
## Application events  
 Application events are not bound to a control; therefore, you do not have to specify a control name in the `RegisterActionForEvent` activity. The following table describes the application events that are available in the [!INCLUDE[pn_hosted_application_toolkit_hat](../includes/pn-hosted-application-toolkit-hat.md)]:  
  
|Element|Description|  
|-------------|-----------------|  
|WindowShown|The event is raised when the window is displayed.|  
|WindowDisappeared|The event is raised when the window is hidden.|  
  
### See also  
 [Win DDA](../unified-service-desk/windda.md)   
 [Use Data Driven Adapters (DDAs)](../unified-service-desk/use-data-driven-adapters-ddas.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]