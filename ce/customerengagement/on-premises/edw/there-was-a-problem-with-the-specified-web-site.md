---
title: "There was a problem with the specified website | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: bb35e14c-3721-4139-b565-8b7bc30d47ed
caps.latest.revision: 8
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# There was a problem with the specified website

## Cause
  
 There was a problem with the website that was specified. The causes of this error or warning are as follows:  
  
-   The specified Microsoft Dynamics 365 for Customer Engagement website has not yet been created.  
  
-   There is a conflict with the Transmission Control Protocol (TCP) port designation on the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] web server. By default, [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] uses port 5555.  
  
-   SSL is not configured on the website where [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] is to be installed.  
  
## Solution
  
 Verify and correct the following items, and then run Setup again:  
  
-   Verify the URL and IP address of the [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)].  
  
-   Verify that there is no port conflict, such as another web application configured to use port 5555. See the Verify port bindings section in this topic for more information.  
  
-   Although not required for some internal-facing deployments, to help improve data confidentiality we strongly recommend that you configure the website to only use TLS.  
  
### Verify port bindings  
  
1.  On the computer where the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] web application will be installed, right-click **Start**, select **Run**, enter *InetMgr*, and then press **Enter** to start [!INCLUDE[pn_Internet_Information_Services](../includes/pn-internet-information-services.md)] Manager.  
  
2.  Expand the local computer, and then expand **Sites**.  
  
3.  Right-click a website, point to **Manage Web Site**, and then select **Advanced Settings**.  
  
4.  Notice the port number(s) in the Bindings row, and then select **Cancel**.  
  
5.  Repeat steps 3 through 4 for each website in the list, noting any port conflicts.  
  
> [!IMPORTANT]
>  Before you modify an application, such as changing the port bindings, review the application's documentation.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]