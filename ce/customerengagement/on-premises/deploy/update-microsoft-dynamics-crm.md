---
title: "Update Dynamics 365 Customer Engagement (on-premises) | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.prod: crm-2016
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 025396f7-bc98-44ba-9df9-677f0524edf3
caps.latest.revision: 54
author: Mattp123
ms.author: matp
manager: kvivek
---
# Update Dynamics 365 Customer Engagement (on-premises)

With Dynamics 365 Customer Engagement (on-premises), you have several options that help make your deployment run optimally, reliably, and securely. In most situations where Dynamics 365 Customer Engagement (on-premises) is running in a production environment, we recommend that you apply the latest update for all Dynamics 365 Customer Engagement (on-premises) applications shortly after the update becomes available.  
  
 Dynamics 365 Server and desktop applications use two kinds of update technology:  
  
-   **Setup updates**, which can be applied as part of the Setup process.  
  
-   **Application updates**, which are provided as an update package that can be automatically installed by using [!INCLUDE[pn_Microsoft_Update](../includes/pn-microsoft-update.md)].  
  
  
<a name="BKMK_CRMSetup"></a>   
## Dynamics 365 Customer Engagement (on-premises) Setup update  
 Dynamics 365 Customer Engagement (on-premises) Setup update, also known as *self-healing* Setup, makes sure that you have the latest version of Setup. By using this feature, you can update the Setup program, before it installs anything on the computer, for the following Dynamics 365 Customer Engagement (on-premises) applications:  
  
-   Dynamics 365 Server  
  
-   Dynamics 365 Reporting Extensions 
  
-   Dynamics 365 Report Authoring Extensions  
  
 To use Setup update, select **Get updates for Microsoft Dynamics 365 Customer Engagement (on-premises)** during Setup.  For  Dynamics 365 for Outlook, Setup update applies the latest published update package at the end of Setup.  
  
<a name="BKMK_UpdateRollup"></a>   
## Microsoft Dynamics 365 Customer Engagement (on-premises) application updates  
 Dynamics 365 Customer Engagement (on-premises) publishes updates in a package format that is a collection of software updates. Microsoft fully tests and supports installing any published update for Dynamics 365 Customer Engagement (on-premises) at the time of its release. Get the latest Dynamics 365 Customer Engagement (on-premises) application updates [KB: Microsoft Dynamics 365 Customer Engagement (on-premises) on-premises cumulative updates](https://support.microsoft.com/kb/3142345). 

### Dynamics 365 Customer Engagement (on-premises), update 9.1
The Dynamics 365 Customer Engagement (on-premises), version 9.1 update introduces many feature enhancements designed to empower marketing, sales, and service teams. More information: [New features in Dynamics 365 Customer Engagement (on-premises), version 9.x](../whats-new.md)
  
### Distribution and application of Dynamics 365 Customer Engagement (on-premises) updates  
Dynamics 365 Server and desktop applications are engineered to use [!INCLUDE[pn_Microsoft_Update](../includes/pn-microsoft-update.md)], a service that can automatically download and install updates to Microsoft applications.  
  
 During installation or upgrade of a Dynamics 365 Customer Engagement (on-premises) application, Setup asks whether you want to opt in, which sets [!INCLUDE[pn_Microsoft_Update](../includes/pn-microsoft-update.md)] to apply automatic updates. If you don’t want to apply automatic updates during Setup, you can enable this feature later by turning on automatic updates in the [!INCLUDE[pn_ms_Windows_Update](../includes/pn-ms-windows-update.md)] area of Settings. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Windows Update: FAQ](https://support.microsoft.com/help/12373/windows-update-faq).  
  
 When you enable [!INCLUDE[pn_Microsoft_Update](../includes/pn-microsoft-update.md)], updates are automatically downloaded for Dynamics 365 Customer Engagement (on-premises) for Customer Enagement and for any other Microsoft applications that are enabled to use [!INCLUDE[pn_Microsoft_Update](../includes/pn-microsoft-update.md)].  
  
 If you don’t want to use [!INCLUDE[pn_Microsoft_Update](../includes/pn-microsoft-update.md)], you can still download updates from the [!INCLUDE[pn_Microsoft_Download_Center](../includes/pn-microsoft-download-center.md)] and manually install them or push them out to the appropriate computers by using [!INCLUDE[pn_ms_Windows_Update_Srvcs_long](../includes/pn-ms-windows-update-srvcs-long.md)]. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Windows Server Update Services](/windows-server/administration/windows-server-update-services/get-started/windows-server-update-services-wsus).  
  
### Update requirements

 An update may require updates to required components, such as the [!INCLUDE[pn_Microsoft_.Net_Framework](../includes/pn-microsoft-net-framework.md)] or even an earlier Dynamics 365 Customer Engagement (on-premises) update. For more information about such requirements, see the [!INCLUDE[pn_Microsoft_Knowledge_Base](../includes/pn-microsoft-knowledge-base.md)] article for the update.  
  
<!-- ## See Also  
 [Operating Microsoft Dynamics 365 Customer Engagement (on-premises)](operating-microsoft-dynamics-365.md)  -->



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]