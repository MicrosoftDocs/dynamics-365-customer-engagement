---
title: "Add the AD FS website to the Local intranet security zone | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: f1baf330-e070-4735-8ebe-ec5724595462
caps.latest.revision: 21
ms.author: matp
author: Mattp123
manager: kvivek
---
# Add the AD FS website to the Local intranet security zone in Internet Explorer



Because the [!INCLUDE[pn_adfs_short](../includes/pn-adfs-short.md)] website is loaded as a FQDN, [!INCLUDE[pn_Internet_Explorer](../includes/pn-internet-explorer.md)] places it in the **Internet** zone. 
  
### Add the AD FS server to the Local intranet zone in Internet Explorer  

By default, [!INCLUDE[pn_Internet_Explorer](../includes/pn-internet-explorer.md)] clients do not pass Kerberos tickets to websites in the **Internet** zone. You must add the [!INCLUDE[pn_adfs_short](../includes/pn-adfs-short.md)] website to the **Intranet** zone in [!INCLUDE[pn_Internet_Explorer](../includes/pn-internet-explorer.md)] on each client computer accessing [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] data internally.  
  
1.  In [!INCLUDE[pn_Internet_Explorer](../includes/pn-internet-explorer.md)], select **Tools**, and then select **Internet Options**.  
  
2.  Select the **Security** tab, select the **Local intranet** zone, and then select **Sites**.  
  
3.  Select **Advanced**.  
  
4.  In **Add this website to the zone**, type the URL for your [!INCLUDE[pn_adfs_short](../includes/pn-adfs-short.md)] server, for example, https://sts1.contoso.com.  
  
5.  Select **Add**, select **Close**, and then select **OK**.  
  
6.  Select the **Advanced** tab. Scroll down and verify that under Security **Enable Integrated Windows Authentication** is checked.  
  
7.  Select **OK** to close the Internet Options dialog box.  
  
 You will need to update the Local intranet zone on each client computer accessing [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] data internally.  
  
## See Also  
 [Implement claims-based authentication: internal access](implement-claims-based-authentication-internal-access.md)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]