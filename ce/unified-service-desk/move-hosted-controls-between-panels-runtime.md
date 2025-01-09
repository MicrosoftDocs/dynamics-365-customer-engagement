---
title: "Move hosted controls across panels at runtime in Unified Service Desk | MicrosoftDocs"
description: "Learn to move hosted controls across panels at runtime using the MoveToPanel action and the IDesktopFeatureAccess class."
ms.date: 06/27/2024
ms.topic: article
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
search.audienceType: 
  - customizer
  - developer
ms.custom: evergreen
---
# Move hosted controls between panels at runtime Unified Service Desk
[!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] provides the ability to move applications between panels at runtime. You can do so by using the [MoveToPanel](../unified-service-desk/global-manager-hosted-control.md#MoveToPanel) action for the **Global Manager** hosted control type. This action takes two parameters:  
  
- **app**: name of the hosted control to be moved.  
  
- **panel**: target panel for the hosted control.  
  
  This can also be done through code where developers can program this while creating new panel types. [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] provides a special panel called the `Unknown` panel. This panel is a temporary storage for hosted controls when the panel layout they were intended to be placed on, is not yet loaded. Let’s suppose that you have a **Horizontal Split** panel populated with a **CRM Page** type of hosted control, but you have closed your **Horizontal Split** panel. The **CRM Page** hosted control is still loaded but has been moved to the **Unknown** panel, which is not visible. Once the **Horizontal Split** panel is loaded again, the **CRM Page** hosted control would be moved from the **Unknown** panel to the appropriate panel again.  
  
```  
IDesktopFeatureAccess desktop = AifServiceContainer.Instance.GetService<IDesktopFeatureAccess>();  
if (desktop != null)  
{  
   desktop.SendApplicationToUnknownPanel(this, tabApp);  
}  
```  
  
 The [IDesktopFeatureAccess](/dotnet/api/microsoft.crm.unifiedservicedesk.basecontrol.idesktopfeatureaccess) class has another function, [String)](/dotnet/api/microsoft.crm.unifiedservicedesk.basecontrol.idesktopfeatureaccess.moveapplicationtopanel), which allows you to move a hosted control from and to arbitrary panels. This function takes a reference to the hosted application you wish to move and a string that represents the panel name, which is the name of the hosted control defined as a panel layout.  
  
### See also  
 [Panels, panel types, and panel layouts in Unified Service Desk](../unified-service-desk/panels-panel-types-panel-layouts.md)   
 [Global Manager (Hosted Control)](../unified-service-desk/global-manager-hosted-control.md)   
 [CRM Page (Hosted Control)](../unified-service-desk/crm-page-hosted-control.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
