---
title: "Accessibility in Unified Service Desk | MicrosoftDocs"
description: "Learn about accessibility features such as keyboard access and screen reader support."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/23/2017
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-a11y
  - dyn365-USD
  - dyn365-admin
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - D365USD
tags: MigrationHO
---
# Accessibility features in Unified Service Desk
Microsoft is committed to making its products and services easier for everyone. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Microsoft accessibility](https://www.microsoft.com/enable/default.aspx)  
  
  
<a name="KeyboardAccess"></a>   
## Keyboard  access in the Unified Service Desk client  
 [!INCLUDE[pn_unified_service_desk_for_crm](../../includes/pn-unified-service-desk-for-crm.md)] offers keyboard navigation to help address issues faced by people with disabilities. Also, people who don’t use a mouse can use their keyboard to navigate in some areas of the [!INCLUDE[pn_unified_service_desk_for_crm](../../includes/pn-unified-service-desk-for-crm.md)] client.  
  
|To|Select|  
|--------|-----------|  
|Move from left to right and top to bottom towards the next control, option, option group, or field.|Tab|  
|Move from right to left and bottom to top towards the next control, option, option group, or field.|Shift + Tab|  
|Complete the command for the active, control, option, or button|Enter|  
|Cyclically navigates through all the active panels.|Ctrl + 0|  
|Changes the focus from an IE Process hosted control to the main window.|Alt + 0|  
|Navigates through all active notifications in a cyclical manner.|Alt + 1|  
  
 If the Alt + 0  key combination  is assigned as a shortcut in any other application, you can use the IEProcessKeyboardShortcut option in Unified Service Desk to assign a different key combination for moving out of an IE Process hosted control. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage Options for Unified Service Desk](../../unified-service-desk/admin/manage-options-unified-service-desk.md).  
  
 If the Alt + 1  key combination  is assigned as a shortcut in any other application, you can use the PopupCycleShortcut option in Unified Service Desk to assign a different key combination for moving out of an IE Process hosted control. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage Options for Unified Service Desk](../../unified-service-desk/admin/manage-options-unified-service-desk.md).  
  
<a name="SplashScreen"></a>   
## Keyboard access to the splash screen  
 Use the Tab key to navigate to the Change Credentials link in the [!INCLUDE[pn_unified_service_desk_for_crm](../../includes/pn-unified-service-desk-for-crm.md)] splash screen so you can view the login page.  
  
<a name="HighContrast"></a>   
## High contrast mode in the  Unified Service Desk client  
 The high contrast setting in [!INCLUDE[pn_ms_Windows_long](../../includes/pn-ms-windows-long.md)] increases the color contrast of some text and images on your screen, making them more distinct and easier to identify. You’ll find this setting on the **Ease of Access page** in the Control Panel in [!INCLUDE[pn_windows_10](../../includes/pn-windows-10.md)], [!INCLUDE[pn_windows8](../../includes/pn-windows8.md)], and [!INCLUDE[pn_Windows_7](../../includes/pn-windows-7.md)].  If you’re using the high contrast setting in  Windows, high contrast in the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client also becomes enabled. And if you change the Windows high contrast mode while the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client is running, [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] will  also switch to high contrast mode.  
  
 Note that there are two  themes available in earlier versions of [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)], Blue and Style, are no longer available because they  do not support high contrast mode.  
  
<a name="ScreenReader"></a>   
## Screen  reader support  
 All out-of-box [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] hosted controls and custom controls that are included in the Web Client sample application package work with JAWS version 18 to provide speech output.  
  
 For information about how developers can extend custom hosted controls or hosted controls in the other [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] sample application packages to support the JAWS screen reader, see [Configure JAWS Screen Reader in Unified Service Desk](../configure-jaws-screen-reader-support.md).  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]