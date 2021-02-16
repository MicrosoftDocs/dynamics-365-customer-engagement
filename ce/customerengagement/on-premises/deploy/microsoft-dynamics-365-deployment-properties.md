---
title: "Dynamics 365 Customer Engagement (on-premises) deployment properties | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 8b73f1ac-51ac-4e18-bb4c-19b427fcb141
caps.latest.revision: 24
ms.author: matp
author: Mattp123
manager: kvivek
---
# Dynamics 365 Customer Engagement (on-premises) deployment properties



The [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] **Properties** dialog box displays information about the deployment and lets you specify settings for Web Address, License, and Usage Reporting.  
  
### Open the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] Properties dialog box  
 You can open the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] Properties dialog box in one of two ways:  
  
-   In the **Actions** pane, select **Properties**.  
  
-   In the console tree, right-click **[!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]**, and then select **Properties**.  
  
> [!TIP]
>  You can implement some of the procedures described here by using a [!INCLUDE[pn_PowerShell](../includes/pn-powershell.md)] cmdlet. For more information, see [Using Windows PowerShell to perform Deployment Manager tasks](powershell-deployment-manager-tasks.md).  
  
<a name="BKMKGeneral"></a>   
#### General tab  
 The **General** tab shows information about the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] deployment  
  
<a name="BKMKWebAdd"></a>   
#### Web Address tab  
 Use the **Web Address** tab to set the **Binding Type** and to specify information for the **[!INCLUDE[pn_Web_Application_Server](../includes/pn-web-application-server.md)]**, **[!INCLUDE[pn_Organization_Web_Service](../includes/pn-organization-web-service.md)]**, **[!INCLUDE[pn_Discovery_Web_Service](../includes/pn-discovery-web-service.md)]**, and **[!INCLUDE[pn_Deployment_Web_Service](../includes/pn-deployment-web-service.md)]**.  
  
> [!WARNING]
>  If you enter incorrect values in these fields, some users might not be able to access [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].  
  
##### Enter Web Address information  
  
1.  After opening the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]**Properties** dialog box, select the **Web Address** tab.  
  
2.  Specify the **Binding Type**, either HTTP or HTTPS.  
  
    > [!NOTE]
    >  -   The **Binding Type** *must* be set to HTTPS to use claims-based authentication.  
    > -   The [!INCLUDE[pn_deploymentmanager](../includes/pn-deploymentmanager.md)] does not configure the Microsoft Dynamics 365 website site to use HTTPS. The website must already be configured for HTTPS. For information about how to configure a website to use HTTPS, see the [!INCLUDE[pn_Internet_Information_Services](../includes/pn-internet-information-services.md)] Manager Help.  
  
3.  In the boxes provided, enter the domain paths.  
  
     For the domain paths, the values for the paths must be in the form:  
  
    ```  
    server:port  
    ```  
  
     or  
  
    ```  
    server.domain.tld:port  
    ```  
  
     where:  
  
    -   `server` is the computer name  
  
    -   `domain` is the complete sub domain path where the computer is located  
  
    -   `tld` is the top level domain, such as com or org  
  
    -   The `:port` designation is required if you are not using the standard http port (80) or https port (443)  
  
     Typically, in a Full Server or Front End Server role deployment, the path values are the same. However, if you deploy [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] on multiple servers with separate server roles, that is, where the **[!INCLUDE[pn_Web_Application_Server](../includes/pn-web-application-server.md)]**, **[!INCLUDE[pn_Organization_Web_Service](../includes/pn-organization-web-service.md)]**, or **[!INCLUDE[pn_Discovery_Web_Service](../includes/pn-discovery-web-service.md)]** server roles are located on different servers, these path values will be different:  
  
    -   **[!INCLUDE[pn_Web_Application_Server](../includes/pn-web-application-server.md)]** . WebApplicationServerName.domain.tld:port  
  
    -   **[!INCLUDE[pn_Organization_Web_Service](../includes/pn-organization-web-service.md)]** . OrganizationWebServiceServerName.domain.tld:port  
  
    -   **[!INCLUDE[pn_Discovery_Web_Service](../includes/pn-discovery-web-service.md)]** .  DiscoveryWebServiceServerName.domain.tld:port  
  
    -   **[!INCLUDE[pn_Deployment_Web_Service](../includes/pn-deployment-web-service.md)]** .  DeploymentWebServiceServerName.domain.tld:port  
  
##### Specify NLB and SSL header information  
  
1.  At the bottom of the **Web Address** tab, select **Advanced**.  
  
2.  In the **NLB and SSL Header Information** dialog box, specify if you are using network load-balancing (NLB) and the header for the [!INCLUDE[pn_Secure_Sockets_Layer](../includes/pn-secure-sockets-layer.md)] offloading system.  
  
     Selecting **The deployment uses an NLB** sets [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] to configure Windows Identity Foundation (WIF) to use the encryption certificate to encrypt, decrypt, and sign the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] session authentication cookies. The encrypted cookies can then be processed by any server in the NLB cluster.  
  
     For information about procedures for loading and administering NLB on [!INCLUDE[pn_Windows_Server](../includes/pn-windows-server.md)], see the Network Load Balancing Manager Help on the [!INCLUDE[pn_Windows_Server](../includes/pn-windows-server.md)] computer.  
  
3.  If you are using NLB, select **The deployment uses an NLB**.  
  
4.  If you are using SSL offloading, in the **SSL Header** box, type the SSL header for the SSL offloading system.  
  
    > [!NOTE]
    >  The SSL header is not a URL or domain. It is an agreed-on header value for the HTTP request that is configured on the device that is handling the SSL offloading. Review the SSL offloading device documentation for the header value.  
  
5.  Select **OK**.  
  
#### Configure domain names for IFD  
 To configure [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] for [!INCLUDE[pn_ifd_short](../includes/pn-ifd-short.md)], you must start [!INCLUDE[pn_deploymentmanager](../includes/pn-deploymentmanager.md)] and run the [!INCLUDE[pn_Internet_Facing_Deployment_Configuration_Wizard](../includes/pn-internet-facing-deployment-configuration-wizard.md)] to add or revise the domain values. Depending on how you deployed the [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] role group or separate server role installation, and the configuration of each server in the NLB cluster, the **Web Application Server Domain**, **Organization Web Service Domain**, and **Discovery Web Service Domain** values use the NLB virtual cluster domain name. For example, if the Web Application Server is installed on an Internet-facing NLB cluster that has the FQDN virtual name *crmcluster.contoso.com*, enter `contoso.com` as the **Web Application Server Domain** value.  
  
 For more information about how to configure internal web address and external domain values, see [Configure IFD for Microsoft Dynamics 365 Customer Engagement (on-premises)](https://technet.microsoft.com/library/dn609803.aspx).  
  
<a name="BKMKLicense"></a>   
#### License tab  
 After opening the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]**Properties** dialog box, select the **License** tab.  
  
 The **License** tab displays a summary of all [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] users that are configured in the deployment. <!-- For information about each of these client access license types, see [Dynamics 365 Customer Engagement (on-premises) purchase plans](https://go.microsoft.com/fwlink/p/?LinkId=306766).  -->
  
 The following information for all [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] users and their respective client access license (CAL) types is displayed:  
  
-   **Administrative Users**. Shows the total number of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] users configured as administrative users.  
  
-   **Professional CALs Required**. Shows the total number of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] users configured with the Professional client access license (CAL) in the deployment.  
  
-   **Basic CALs Required**. Shows the total number of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] users configured with the Basic CAL in the deployment.  
  
-   **Essential CALs Required**. Shows the total number of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] users configured with the Essential CAL in the deployment.  
  
-   **Server Licenses Required**. Shows the total number of [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] licenses in the deployment.  
  
 The **License** tab also displays the product ID you can use to identify and validate your copy of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] and a link to the **Change Product Key** dialog box. To change the product key, see [Change the product key](change-the-product-key.md).  
  
 If the [!INCLUDE[pn_deploymentmanager](../includes/pn-deploymentmanager.md)] cannot access one or more organizations, the license counts are shown as "Unavailable."  
  
> [!NOTE]
>  If a user is a member of multiple organizations and uses a different license in different organizations, the [!INCLUDE[pn_deploymentmanager](../includes/pn-deploymentmanager.md)] reports that user as using the highest privilege level license. For example, if the user has a Full user license in one organization and a Limited license in another organization, that user is reported as using one Full license.  
>   
>  Users who have the [!INCLUDE[pn_Deployment_Administrator](../includes/pn-deployment-administrator.md)] role do not automatically become [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] users and do not consume a CAL.  
  
<a name="BKMKUsage"></a>   
#### Usage Reporting tab  
 On the Usage Reporting tab, indicate whether you want to allow organizations in the deployment to participate anonymously in the [!INCLUDE[pn_Customer_Experience_Program](../includes/pn-customer-experience-program.md)]. When selected, the application automatically sends basic, anonymous information to Microsoft about how you use Dynamics 365 Customer Engagement (on-premises) and the types and number of errors you encounter. This information helps Microsoft solve problems and improve products and features. If you accept, each organization in the deployment can be configured to send data to Microsoft. If you decline for the entire deployment, no organization is able to send data, regardless of the organization's usage reporting setting.  
  
###### Allow usage reporting  
  
1.  After you open the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] **Properties** dialog box, select the **Usage Reporting** tab.  
  
2.  Select the **Allow organizations to participate anonymously in the [!INCLUDE[pn_Customer_Experience_Program](../includes/pn-customer-experience-program.md)]** option.  

  
## See also  
 [Configure claims-based authentication](configure-claims-based-authentication.md)   
 [Configure an Internet-facing deployment](configure-an-internet-facing-deployment.md)   
 [Change the product key](change-the-product-key.md)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]