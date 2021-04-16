---
title: "Microsoft Dynamics 365 for Outlook hardware requirements | MicrosoftDocs"
ms.custom: 
ms.date: 11/28/2016
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 apps 
ms.assetid: 3dbb25e8-befe-4466-9614-5d0b84e83ea7
caps.latest.revision: 31
author: mduelae
ms.author: mkaur
manager: kvivek
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Outlook
---
# Microsoft Dynamics 365 for Outlook hardware requirements
The following table lists the minimum recommended hardware requirements when you run [!INCLUDE [pn-microsoft-dynamics-crm-for-outlook](../../includes/pn-microsoft-dynamics-crm-for-outlook.md)] in either online only or go offline enabled modes.  
  
|Component|Online only mode|Go Offline enabled mode|  
|---------------|----------------------|-----------------------------|  
|Processor|x86- or x64-bit 1.9 gigahertz (GHz) or faster dual core processor with SSE2 instruction set|x86- or x64-bit 1.9 gigahertz (GHz) or faster dual core processor with SSE2 instruction set|  
|Memory|2-GB RAM or more|4-GB RAM or more|  
|Hard disk|1.5 GB of available hard disk space|2 GB of available hard disk space<br /><br /> 7200 RPM or more|  
|Display|Super VGA with a resolution of 1024 x 768|Super VGA with a resolution higher than 1024 x 768|  
  
> [!NOTE]
>  [!INCLUDE [cc-actual-requirements-and-product-functionality-may-vary](../../includes/cc-actual-requirements-and-product-functionality-may-vary.md)]
> 
>  Running Dynamics 365 apps on a computer that has less than the minimum recommended requirements may result in inadequate performance. For the best performance, we recommend running 64-bit versions of [!INCLUDE[pn-ms-Windows-long](../../includes/pn-ms-windows-long.md)], [!INCLUDE[pn_MS_Office](../../includes/pn-ms-office.md)], and [!INCLUDE[pn-crm-for-outlook-short](../../includes/pn-crm-for-outlook-short.md)].  

 **Network requirements**  
  
 Dynamics 365 apps are designed to work best over networks that have the following elements:  
  
- Bandwidth greater than 50 KBps (400 kbps)  
  
- Latency under 150 ms  
  
  These values are recommendations and don’t guarantee satisfactory performance. The recommended values are based on systems using out-of-the box forms that aren’t customized. If you significantly customize the out-of-box forms, we recommend that you test the form response to understand bandwidth needs. [!INCLUDE[proc-more-information](../../includes/proc-more-information.md)] [Verify network capacity and throughput for Dynamics 365 apps clients](/previous-versions/dynamicscrm-2016/administering-dynamics-365/mt269872(v=crm.8))  
  
> [!NOTE]
>  Successful network installation of [!INCLUDE[pn-crm-for-outlook-short](../../includes/pn-crm-for-outlook-short.md)] requires a reliable and high-throughput network. Otherwise, installation might fail. The recommended minimum available bandwidth of the network connection is 300 Kbps.  
  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]