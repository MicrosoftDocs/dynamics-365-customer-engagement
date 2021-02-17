---
title: "Install Microsoft Dynamics CRM Server by using a command prompt | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: 0497afad-c0d9-4f6a-8b10-b08fe6b4e559
caps.latest.revision: 16
ms.author: matp
author: Mattp123
manager: kvivek
---
# Install Microsoft Dynamics 365 Server by using a command prompt



The following command will install Dynamics 365 Server:  
  
 **SetupServer.exe** [**/Q**] [/InstallAlways] [**/L** [drive:][[path] logfilename.log]] [**/config** [drive:] [[path] configfilename.xml]]  
  
## Parameters  
 `None`  
  
-   Used without parameters, Setup will run with all display screens.  
  
 `/Q`  
  
-   Quiet mode installation. This parameter requires a configuration file in XML format. The `/config` parameter contains the name of the XML configuration file. No dialog boxes or error messages will appear on the display screen.  
  
 `/InstallAlways`  
  
-   This parameter forces Setup to ignore the installation state and operate in install mode. When you use this parameter, Setup will try to install on a server where Dynamics 365 Server is already installed.  
  
 `/QR`  
  
-   Requires a configuration file in XML format specified by the /config parameter. Similar to the `/Q` parameter, but displays installation progress bars and all error messages.  
  
 `/L [drive:][[path] logfilename.log]]`  
  
-   Specifies the location and name of the log file to record installation activity. Additional log files may be created during prerequisites installation and will be located in the path specified. The path value cannot be a relative path, such as ..\\..\crmlog.txt. If you do not specify a name or location, a log file will be created in the drive:\Documents and Settings\\*UserName*\Application Data\Microsoft\MSCRM\Logs folder, where *UserName* is the account name of the user running Setup.  
  
 `/config [drive:] [[path] configfilename.xml]]`  
  
-   The `/config` parameter uses the specified XML configuration file to provide Setup with the additional information to complete installation successfully. An example XML configuration file is discussed in the following section. Notice that when you specify a configuration file without the `/Q` or `/QR` parameter, Setup screens appear filled with the information from the configuration file.  
  
## See Also  
 [Use the Command Prompt to Install Microsoft Dynamics 365](use-command-prompt-install-dynamics-365-server.md)   </br>
 [Microsoft Dynamics 365 Server XML configuration file](microsoft-dynamics-365-server-xml-configuration-file.md)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]