---
title: "Configure claims-based authentication | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.prod: crm-2016
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 7bc51122-cd62-4946-bfc1-0db0785316ee
caps.latest.revision: 18
author: Mattp123
ms.author: matp
manager: kvivek
---
# Configure claims-based authentication



The claims-based security model extends traditional authentication models to include other directory sources that contain information about users. This identity federation lets users from various sources—such as [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] Domain Services, customers through the internet, or business partners—use [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].  
  
> [!IMPORTANT]
> Claims-based authentication is required for [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] [!INCLUDE[pn_Internet_facing_deployment](../includes/pn-internet-facing-deployment.md)] access. However, claims-based authentication isn’t required for intranet [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] access if [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] is deployed in the same domain where all [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] users are located, or users are in a trusted domain.  
>   
>  Before you run the [!INCLUDE[pn_Configure_Claims-based_Wizard](../includes/pn-configure-claims-based-wizard.md)], a [!INCLUDE[pn_security_token_service](../includes/pn-security-token-service.md)], such as [!INCLUDE[pn_Active_Dir_Fed_Svcs_AD_FS](../includes/pn-active-dir-fed-svcs-ad-fs.md)] must be available. For more information about [!INCLUDE[pn_Active_Dir_Fed_Svcs_AD_FS](../includes/pn-active-dir-fed-svcs-ad-fs.md)], see [Identity and Access Management](https://go.microsoft.com/fwlink/p/?LinkID=188371).  
  
#### Configure claims-based authentication  
  
1.  Start the [!INCLUDE[pn_deploymentmanager](../includes/pn-deploymentmanager.md)].  
  
2.  Set the **Binding Type** to HTTPS, as follows:  
  
    -   In the **Actions** pane, select **Properties**.  
  
    -   Select the **Web Address** tab.  
  
    -   Under **Binding Type**, select **HTTPS**.  
  
    -   Select **OK**.  
  
    > [!IMPORTANT]
    >  The **Binding Type** *must* be set to HTTPS to use claims-based authentication.  
    >   
    >  Verify that the web addresses are valid for your [!INCLUDE[pn_ssl_short](../includes/pn-ssl-short.md)] certificate and the [!INCLUDE[pn_ssl_short](../includes/pn-ssl-short.md)] port bound to the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] website.  
    >   
    >  If [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] clients were configured using the old binding values, these clients will need to be configured with the new values.  
  
3.  Open the [!INCLUDE[pn_Configure_Claims-based_Wizard](../includes/pn-configure-claims-based-wizard.md)] in one of two ways:  
  
    -   In the **Actions** pane, select **Configure Claims-Based Authentication**.  
  
    -   In the [!INCLUDE[pn_deploymentmanager](../includes/pn-deploymentmanager.md)] console tree, right-click **[!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]**, and then select **Configure Claims-Based Authentication**.  
  
4.  Select **Next**.  
  
5.  On the **Specify the security token service** page, enter the **Federation metadata URL**, such as *https://adfs.contoso.com/federationmetadata2007-06/federationmetadata.xml*.  
  
     This data is typically located on the website where the [!INCLUDE[pn_Active_Dir_Fed_Svcs_AD_FS](../includes/pn-active-dir-fed-svcs-ad-fs.md)] is running. To verify the correct URL, open an internet browser by using the URL to view the federation metadata. Verify that no certificate-related warnings appear.  
  
6.  Select **Next**.  
  
7.  On the **Specify the encryption certificate** page, specify the encryption certificate in one of two ways:  
  
    -   In the **Certificate** box, type the name of the certificate. Type the complete common name (CN) of the certificate by using the format CN=certificate_subject_name.  
  
    -   Under **Certificate**, select **Select**, and then select a certificate.  
  
     This certificate is used to encrypt authentication security tokens that are sent to the [!INCLUDE[pn_Active_Dir_Fed_Svcs_AD_FS](../includes/pn-active-dir-fed-svcs-ad-fs.md)] security token service (STS).  
 
    > [!NOTE]
    >  The [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] service account must have Read permissions for the private key of the encryption certificate. See [The CRMAppPool account and the Microsoft Dynamics 365 Customer Engagement (on-premises) encryption certificate](configure-claims-based-authentication.md#BKMK_CRMAppPool).  
  
8.  Select **Next**.  
  
     The [!INCLUDE[pn_Configure_Claims-based_Wizard](../includes/pn-configure-claims-based-wizard.md)] verifies the token and certificate you specified.  
  
9. On the **System Checks** page, review the results, fix any problems, and then select **Next**.  
  
10. On the **Review your selections and then click Apply** page, verify your selections, and then select **Apply**.  
  
11. Note the URL you must use to add the relying party to the security token service. View and save the log file for later reference.  
  
12. Note the information on the page, and then select **Finish**.  
  
13. Configure relying parties for claims-based authentication.  
  
    > [!IMPORTANT]
    >  Claims-based authentication won’t work until you create the relying parties in STS. For more information, see [Configure the AD FS server for claims-based authentication](https://technet.microsoft.com/library/gg188595.aspx).  
  
<a name="BKMK_CRMAppPool"></a>   
### The CRMAppPool account and the Microsoft Dynamics 365 Customer Engagement (on-premises) encryption certificate  

Claims data sent from [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] to [!INCLUDE[pn_Active_Dir_Fed_Svcs_AD_FS](../includes/pn-active-dir-fed-svcs-ad-fs.md)] is encrypted using a certificate you specify in the [!INCLUDE[pn_Configure_Claims-based_Wizard](../includes/pn-configure-claims-based-wizard.md)]. The CRMAppPool account of each [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] web application must have Read permissions to the private key of the encryption certificate.  
  
1.  On the [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)], create a [!INCLUDE[pn_Microsoft_Management_Console](../includes/pn-microsoft-management-console.md)] with the **Certificates** snap-in console that targets the **Local computer** certificate store.  
  
2.  In the console tree, expand the Certificates (**Local Computer**) node, expand the **Personal** store, and then select **Certificates**.  
  
3.  In the details pane, right-click the encryption certificate specified in the [!INCLUDE[pn_Configure_Claims-based_Wizard](../includes/pn-configure-claims-based-wizard.md)], point to **All Tasks**, and then select **Manage Private Keys**.  
  
4.  Select **Add** (or select the Network Service account if that is the account you used during setup), add the **CRMAppPool** account, and then grant Read permissions.  
  
    > [!TIP]
    >  You can use IIS Manager to determine what account was used during setup for the CRMAppPool account. In the **Connections** pane, select **Application Pools**, and then check the **Identity** value for CRMAppPool.  
  
5.  Select **OK**.  
  
## See also  
 [Disable claims-based authentication](disable-claims-based-authentication.md)   
 [Configure an Internet-facing deployment](configure-an-internet-facing-deployment.md)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]