---
title: "Install Microsoft Dynamics 365 Report Authoring Extension using a command prompt | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: 44fd7c36-e818-4426-965d-c94eef03fd7b
caps.latest.revision: 12
ms.author: matp
author: Mattp123
manager: kvivek
---
# Install Microsoft Dynamics 365 Report Authoring Extension using a command prompt



From a command prompt, you can use the following command to install Dynamics 365 Report Authoring Extension:  
  
 `SetupBIDSExtensions.exe [/Q] [/config configfile.xml]`  
  
### Microsoft Dynamics 365 Report Authoring Extension command-line parameters  
 `/Q`  
 Quiet mode installation. This parameter requires an XML configuration file. The **/config** parameter contains the name of the  configuration file. No dialog boxes or error messages will appear on the display screen.  
  
 `/config [drive:] [[path] configfilename.xml]]`  
 The **/config** parameter uses the specified XML configuration file to provide Setup with the additional information to complete the installation. An example XML configuration file is shown in [Microsoft Dynamics 365 Report Authoring Extension XML configuration file](dynamics-365-report-authoring-extension-xml-config-file.md). Notice that if you specify a configuration file without the /Q parameter, you’ll see Setup screens displayed with the information from the configuration file.  
  
 `/uninstall`  
 Uninstalls [!INCLUDE[pn_CRM_Reporting_Extensions_server_side](../includes/pn-crm-reporting-extensions-server-side.md)]. This is a maintenance mode option that is only available after the application is installed.  
  
## See Also  
 [Install Microsoft Dynamics 365 Reporting Extensions using a command prompt](install-dynamics-365-reporting-extensions-command.md)  </br> 
 [Microsoft Dynamics 365 Report Authoring Extension XML configuration file](dynamics-365-report-authoring-extension-xml-config-file.md)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]