---
title: "Upgrade Dynamics 365 Server | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: 5a236c3e-0ef5-4e30-84ed-e624485a5585
caps.latest.revision: 39
ms.author: matp
author: Mattp123
manager: kvivek
---
# Upgrade Dynamics 365 Server



This section shows you how to run the actual in-place upgrade on Dynamics 365 Server with December 2016 Service Pack for Dynamics 365 (on-premises). If you encounter problems during the upgrade, see [Troubleshooting installation and upgrade](troubleshooting-installation-and-upgrade.md) in this guide.  
  
> [!CAUTION]
>  Following these steps may cause significant application downtime if issues occur during the upgrade. Instead of using an upgrade option that may affect the production deployment, we recommend that you migrate your deployment. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)][Microsoft Dynamics 365 Server upgrade options](plan-your-upgrade-to-microsoft-dynamics-365-server.md#BKMK_Upgradeoptions)  
  
> [!IMPORTANT]
>  We strongly recommend that you back up your existing [!INCLUDE[pn_crm_legacy](../includes/pn-crm-legacy.md)] data, including all reports and customizations, before you run Setup. In addition, we recommend that you implement the following backup strategy before you run Setup:  
>   
>  1.  Configure the existing deployment’s [!INCLUDE[pn_crm_legacy](../includes/pn-crm-legacy.md)] databases by using a simple recovery model.  
> 2.  Complete a full backup of all production configuration and organization databases and transaction logs.  
>   
>  [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Backing Up the Microsoft Dynamics 365 System](back-up-the-microsoft-dynamics-365-system.md)  
  
> [!IMPORTANT]
>  -   Only Dynamics 365 Server with December 2016 Service Pack for Dynamics 365 (on-premises) or later can be upgraded. For upgrade information from previous versions of Dynamics 365 Server, see [Upgrading from earlier versions of Microsoft Dynamics CRM Server](before-you-upgrade-issues-and-considerations.md#upgrading-from-earlier-versions-of-microsoft-dynamics-crm-server).  
> -   To upgrade an existing Dynamics 365 Server with December 2016 Service Pack for Dynamics 365 (on-premises) deployment, the user who is running [!INCLUDE [pn-dynamics-365-server-v-90](../includes/pn-dynamics-365-server-v-90.md)] Setup must be a member of the Deployment Administrators group. Additionally, the user must have `db_owner` permission on the existing Dynamics 365 Customer Engagement (on-premises) databases and have `sysadmin` permission on the [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)]. For more information about how to add a member to the Deployment Administrators group, see the `the New-CrmDeploymentAdministrator`[!INCLUDE[pn_PowerShell](../includes/pn-powershell.md)] command. More information: [Set properties using Powershell cmdlets](administer-the-deployment-using-windows-powershell.md). Alternatively, you can use [!INCLUDE[pn_deploymentmanager](../includes/pn-deploymentmanager.md)]. For more information about how to grant permission in [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)], see the [!INCLUDE[pn_SQL_Server_Management_Studio](../includes/pn-sql-server-management-studio.md)] Help.  
  
## Tasks to perform before the upgrade  
  
-   We recommend that you apply the latest [Microsoft Dynamics 365 On-Premise Cumulative Updates](https://support.microsoft.com/help/3142345/microsoft-dynamics-365-onpremise-cumulative-updates) before you start the upgrade.  
  
-   Meet all requirements as specified under [Microsoft Dynamics 365 Server hardware requirements](microsoft-dynamics-365-server-hardware-requirements.md) and [Microsoft Dynamics 365 Server software requirements](software-requirements-for-microsoft-dynamics-365-server.md).  
  
-   Log on to your domain as a user who has administrator-level permission.  
  
-   [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] replication isn’t supported with [!INCLUDE[pn_crm_legacy](../includes/pn-crm-legacy.md)]. If you run [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] replication, disable it.  
  
-   Uninstall Dynamics 365 Reporting Extensions if it’s installed on the same computer where Dynamics 365 Server is installed. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)][Uninstall or repair Microsoft Dynamics 365 Reporting Extensions](uninstall-repair-dynamics-365-reporting-extensions.md)  
  
-   To determine the location of the Dynamics 365 Customer Engagement (on-premises) installation files, see the [Microsoft Dynamics 365, version 9.0 Readme](/dynamics365-release-plan/2019wave2/).  
  
## Run the upgrade  
  
1.  In the folder where the Dynamics 365 Server files are located, go to the Server\amd64 folder, and then double-click **SetupServer.exe**.  
  
2.  On the **Welcome to Microsoft Dynamics CRM Server Setup** page, we recommend that you select **Get updates for Microsoft Dynamics CRM** to make sure that Setup has the most recent installation files. Select **Next**. After Setup is done checking for updates, select **Next** again.  
  
    > [!IMPORTANT]
    >  For the **Get updates for Microsoft Dynamics CRM** functionality to work you must:  
    >   
    >  -   Have an Internet connection on the computer where Setup is running.  
    > -   Enable [!INCLUDE[pn_Microsoft_Update](../includes/pn-microsoft-update.md)] for “other [!INCLUDE[cc_Microsoft](../includes/cc-microsoft.md)] products” on the [!INCLUDE[pn_Windows_Server](../includes/pn-windows-server.md)] computer where Dynamics 365 Server [!INCLUDE[pn_Setup](../includes/pn-setup.md)] is running.  
  
3.  On the **Product Key Information** page, type your product key in the **Product key** boxes, and then select **Next**.  
  
    > [!NOTE]
    >  If you purchased Dynamics 365 for Customer Enagement through a [!INCLUDE[pn_ms_Volume_Licensing](../includes/pn-ms-volume-licensing.md)] program, the license key is provided in the **license.txt** file, which is included in the [!INCLUDE[pn_crm_legacy](../includes/pn-crm-legacy.md)] installation files.  
  
4.  On the **License Agreement** page, review the information and if you accept the license agreement, select **I accept this license agreement**, and then select **I Accept**.  
  
5.  If Setup detects that components are missing, the **Install Required Components** page appears.  
  
    -   If you have already installed the required components, this page won’t appear.  
  
    -   If you haven’t installed the required components listed, you can install them now. Select **Install**. When the components are installed, the status column changes from **Not Installed** to **Installed**, and you can select **Next** to continue.  
  
    > [!NOTE]
    >  If you’re prompted to restart the computer, do so, and then start Setup again.  
  
6.  On the **Upgrade to Microsoft Dynamics CRM** page, you can select an organization to upgrade or leave the choice **\<None>** so that no organizations will be upgraded during Setup. Before you select an organization, consider the following:  
  
    -   Notice that any organization not upgraded will become disabled after the upgrade is complete. To upgrade organizations after Setup is complete, use the `Import-CrmOrganization`[!INCLUDE[pn_PowerShell](../includes/pn-powershell.md)] command. Alternatively, you can use [!INCLUDE[pn_deploymentmanager](../includes/pn-deploymentmanager.md)].  
  
     Click **Next** to upgrade [!INCLUDE[pn_crm_legacy](../includes/pn-crm-legacy.md)].  
  
7.  On the **Specify Service Accounts** page, Setup will add the service accounts used for the [!INCLUDE[pn_crm_legacy](../includes/pn-crm-legacy.md)] Server services. You can use the existing service accounts or specify new ones. For information about the permissions required to run these services see [Minimum permissions required for Microsoft Dynamics 365 Setup and services](security-considerations-for-microsoft-dynamics-365.md#BKMK_MinimumPermissions).  
  
8.  If you want to use server-side synchronization and/or [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] for the deployment, leave this box blank.  [!INCLUDE[proc_more_information](../includes/proc-more-information.md)][ntegrate your email system with Microsoft Dynamics 365](../admin/integrate-synchronize-your-email-system.md)  
  
     Otherwise, on the **Specify E-mail Router Settings** in the, **Email router server name** box, type the name of the computer where the [!INCLUDE[pn_emailrouter](../includes/pn-emailrouter.md)] will be installed. This computer will route Dynamics 365 Customer Engagement (on-premises) email messages. If you leave the box blank but decide later you want to use the [!INCLUDE[pn_emailrouter](../includes/pn-emailrouter.md)], you must add the computer where the [!INCLUDE[pn_emailrouter](../includes/pn-emailrouter.md)] Service is running (part of the [!INCLUDE[pn_Asynchronous_Service](../includes/pn-asynchronous-service.md)]) when you use Network Service, or if you use a domain user account, the account to the PrivUserGroup security group.  
  
     Select **Next**.  
  
9. On the **Select Microsoft Update Preference** page, select whether you want to use [!INCLUDE[pn_Microsoft_Update](../includes/pn-microsoft-update.md)] for checking for updates for your [!INCLUDE[cc_Microsoft](../includes/cc-microsoft.md)] products, and select **Next**. We recommend that you use [!INCLUDE[pn_Microsoft_Update](../includes/pn-microsoft-update.md)] to check for updates because this helps keep your computer up-to-date and secure. For more information about the legal terms and privacy with [!INCLUDE[pn_Microsoft_Update](../includes/pn-microsoft-update.md)] licensing, see [Windows Update FAQ](https://go.microsoft.com/fwlink/p/?LinkID=196513).  
  
10. The **System Checks** page appears. This page is a summary of all requirements and recommendations for a successful installation. Errors must be resolved before installation can continue. If no errors, or only warnings appear, you can continue with the installation. To do this, select **Next**.  
  
11. The **Service Disruption Warning** page appears. This page lists all services that will be stopped or restarted during Setup. Verify the suitability of the services that will be stopped or restarted, and then select **Next**.  
  
12. Review the **Ready to Upgrade the Application** page, and select **Back** to correct any errors. When you are ready to continue, select **Upgrade**.  
  
     When Setup completes successfully, the [!INCLUDE[pn_crm_legacy](../includes/pn-crm-legacy.md)] Server Setup completed page appears. If the Reporting Server instance that you specified during this Setup points to the local computer where Dynamics 365 Server is installed, Setup provides an option to invoke Dynamics 365 Reporting Extensions [!INCLUDE[pn_Setup](../includes/pn-setup.md)].  
  
13. For a full server deployment running on the [!INCLUDE[pn_SQL_Server_Reporting](../includes/pn-sql-server-reporting.md)] computer, select the **Launch Microsoft Dynamics 365 Reporting Extensions Setup** check box to install Dynamics 365 Reporting Extensions. Select **Finish**.  
  
> [!IMPORTANT]
>  -   After you upgrade, you must install the Dynamics 365 Reporting Extensions to create, run, and schedule reports in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. For instructions, see [Install Microsoft Dynamics 365 Reporting Extensions](install-microsoft-dynamics-365-reporting-extensions.md) in this guide.  
> -   You can’t install the Dynamics 365 Reporting Extensions before you install or upgrade Dynamics 365 Server.  
> -   If you had Language Packs provisioned in your deployment, to continue to use multiple languages, in-place upgrade each language pack, and then provision them. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)][Upgrade and deploy a Language Pack](upgrade-and-enable-a-language-pack.md)  
> -   Notice that Setup turns on HTTP compression on the server that’s running [!INCLUDE[pn_iis](../includes/pn-iis.md)] where the web application is installed. If you use another method to compress HTTP communications, you may want to turn this feature off after Setup completes. To do this, start [!INCLUDE[pn_ms_Internet_Information_Services_Manager_short](../includes/pn-ms-internet-information-services-manager-short.md)], choose the website, double-click **Compression**, and then clear the compression check boxes.  
  
## See also  
 [Administer the deployment using Windows PowerShell](administer-the-deployment-using-windows-powershell.md)   </br>
 



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]