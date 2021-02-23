---
title: "Troubleshoot Dynamics 365 Server IFD | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: f37300dc-279a-49cf-8b7f-f3912b877aea
caps.latest.revision: 31
ms.author: matp
author: Mattp123
manager: kvivek
---
# Troubleshoot Dynamics 365 Server IFD



## A quick checklist  
  
|Did you…|Reference|  
|--------------|---------------|  
|Configure DNS records?|See “DNS configuration” in the [downloadable document](https://go.microsoft.com/fwlink/p/?LinkID=390483)|  
|Install and bind your certificate on the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] website?|See “Certificate selection and requirements” in the [downloadable document](https://go.microsoft.com/fwlink/p/?LinkID=390483)|  
|Add an [!INCLUDE[pn_adfs_short](../includes/pn-adfs-short.md)] signing certificate as a trusted certificate under the CRMAppPool account profile?|See “Enable AD FS token signing” in the [downloadable document](https://go.microsoft.com/fwlink/p/?LinkID=390483)|  
|Change the binding type for [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] websites to HTTPS and use the correct web addresses in [!INCLUDE[pn_deploymentmanager](../includes/pn-deploymentmanager.md)]?|[Configure the Microsoft Dynamics 365 Server for IFD](configure-the-dynamics-365-server-for-ifd.md)|  
|Give the CRMAppPool account the rights to use an existing certificate used by [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] as signing certificate? This could be the wildcard certificate installed on the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] server.|[Configure the Microsoft Dynamics 365 Server for claims-based authentication](configure-the-dynamics-365-server-for-claims-based-authentication.md)|  
|Run the [!INCLUDE[pn_Configure_Claims-based_Wizard](../includes/pn-configure-claims-based-wizard.md)] from [!INCLUDE[pn_Deployment_Manager_long](../includes/pn-deployment-manager-long.md)]? Have you specified the correct URL in this wizard? Have you selected the appropriate encryption certificate?|[Configure the Microsoft Dynamics 365 Server for claims-based authentication](configure-the-dynamics-365-server-for-claims-based-authentication.md)|  
|Configure relying party trust in [!INCLUDE[pn_adfs_short](../includes/pn-adfs-short.md)] for [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] internal claims endpoint? Have you provided the correct URL for the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] IFD claims endpoint? Have you setup the correct rules for the relying party trusts?|[Configure the AD FS server for claims-based authentication](configure-the-ad-fs-server-for-claims-based-authentication.md)<br /><br /> [Configure the AD FS server for IFD](configure-the-ad-fs-server-for-ifd.md)|  
| Verify that clients can connect from the Internet?  | If unable to connect, see [Additional steps for clients unable to connect to the Dynamics 365 Server via IFD](post-installation-configuration-guidelines-dynamics-365.md#additional-steps-for-clients-unable-to-connect-to-the-dynamics-365-server-via-ifd).  |  
  
## AD FS  
 Use the following to verify your [!INCLUDE[pn_adfs_short](../includes/pn-adfs-short.md)] settings.  
  
#### Review AD FS events  
  
1.  Open Event Viewer.  
  
2.  Expand **Applications and Services Logs**. Expand **AD FS**. Select **Admin**.  
  
3.  Review the events looking for errors.  
  
 Events such as Event ID 184 describing an unknown relying party trust could indicate missing host records in DNS or incorrect path configuration for the relying party’s federation metadata URL.  
  
#### Verify relying party trust identifiers  
  
1.  Open the [!INCLUDE[pn_adfs_short](../includes/pn-adfs-short.md)] Management console.  
  
2.  Under **Trust Relationships**, select **Relying Party Trusts**. Verify the relying party trusts are enabled and not displaying an alert.  
  
3.  Right-click the relying party trust and select **Properties**. Select the **Identifiers** tab. You should see identifiers like the following.  
  
     Relying party trust for claims: internalcrm.contoso.com  
  
     ![Relying party trust for claims](media/crm-itpro-claimswp-identintern.PNG "Relying party trust for claims")  
  
     Relying party trust for IFD: auth.contoso.com  
  
     ![Dynamics 365 IFD Relying Party](media/crm-itpro-claimswp-identauth.PNG "Dynamics 365 IFD Relying Party")  
  
 If your identifiers aren’t similar to the above examples, check the path entered for the relying party’s federation metadata URL on the **Monitoring** tab and check your DNS records.  
  
 When attempting an internal claims-based authentication connection, you might receive prompt for your credentials. Try the following steps.  
  
#### Resolve prompt for credentials  
  
1.  Add the add website address for the [!INCLUDE[pn_adfs_short](../includes/pn-adfs-short.md)] server (for example, https://sts1.contoso.com) to the Trusted Intranet Zone in [!INCLUDE[pn_Internet_Explorer](../includes/pn-internet-explorer.md)].  
  
2.  Turn off Extended Protection. On the server running IIS for the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] website:  
  
     Turn off extended protection on the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] website.  
  
    1.  Open IIS.  
  
    2.  Select the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] website.  
  
    3.  Under IIS, double-click **Authentication**.  
  
    4.  Right-click **Windows Authentication**, and then select **Advanced Settings**.  
  
    5.  Set **Extended Protection** to **Off**.  
  
#### For more AD FS troubleshooting information  
  
1.  See the following: [Troubleshoot AD FS 2.0](https://social.technet.microsoft.com/wiki/contents/articles/2735.ad-fs-content-map.aspx#tshoot)  
  
## HTTP Error 401.1 - Unauthorized: Access is denied  
 If the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] website fails to display or produces the following error: HTTP Error 401.1 - Unauthorized: Access is denied, there are two steps to try to resolve this issue:  
  
1.  You might need to update the Federation metadata URLs and do an IIs reset. See [KB2686840](https://go.microsoft.com/fwlink/p/?LinkID=390718).  
  
2.  You might need to register the [!INCLUDE[pn_adfs_short](../includes/pn-adfs-short.md)] server as a service principal name (SPN). See “Register the AD FS server as a service principal name (SPN)” in the [downloadable document](https://go.microsoft.com/fwlink/p/?LinkID=390483).  
  
## Time differs between two servers  
 An authentication error can occur if the time between the [!INCLUDE[pn_adfs_short](../includes/pn-adfs-short.md)] and the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] server differs by more than 5 minutes. See [Windows Time Service Technical Reference](https://technet.microsoft.com/library/cc773061\(v=ws.10\).aspx) for information on how to configure time synchronization on your servers.  
  
## See Also  
 [Configure IFD for Microsoft Dynamics 365](configure-ifd-for-dynamics-365.md)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]