---
title: "Sample Dynamics 365 Report Authoring Extension XML configuration file | Microsoft Docs"
description: Use the sample reporting authoring extension Setup XML configuration file with Dynamics 365 Customer Engagement (on-premises) 
ms.custom: ""

ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: 090de410-ae36-4ac4-a7a9-2a05fe24e9a5
caps.latest.revision: 10
ms.author: matp
author: Mattp123
---
# Sample Dynamics 365 Report Authoring Extension XML configuration file

::: moniker range="op-9-1"
[!INCLUDE [applies-not-to-9-1](../includes/applies-not-to-9-1.md)]

::: moniker-end

::: moniker range="op-9-0"

The following XML configuration contents will install [!INCLUDE[pn_crm_fetch_extension_short](../includes/pn-crm-fetch-extension-short.md)] that will opt-in to use [!INCLUDE[pn_Microsoft_Update](../includes/pn-microsoft-update.md)], search and apply existing updates, and install [!INCLUDE[pn_crm_fetch_extension_short](../includes/pn-crm-fetch-extension-short.md)] in the C:\Program Files (x86)\Not default Report Authoring Extension folder. By default, Setup installs in the `<drive>:\Program Files (x86)\Microsoft Dynamics CRM Report Authoring Extension` folder.  
  
```xml  
<crmsetup>  
<bidsextensions>  
  <patch update="true" />   
  <muoptin optin="true" />  
  <installdir>C:\Program Files (x86)\Not default Report Authoring Extension</installdir>  
</bidsextensions>  
</crmsetup>  
```  
  
## See Also  
 [Microsoft Dynamics 365 Report Authoring Extension XML configuration file](dynamics-365-report-authoring-extension-xml-config-file.md)   </br>
 [Install Microsoft Dynamics 365 for Outlook using a command prompt](../../../outlook-addin/admin-guide/install-using-command-prompt.md)

::: moniker-end

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
