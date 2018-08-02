---
title: "Install, deploy, and upgrade Unified Service Desk for Dynamics 365 Customer Engagement | MicrosoftDocs"
description: "Learn how to install or upgrade Unified Service Desk for Dynamics 365 Customer Engagement."
ms.custom:
  - dyn365-USD, dyn365-admin
ms.date: 08/23/2017
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "get-started-article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2013"
  - "Dynamics CRM 2015"
  - "Dynamics CRM 2016"
ms.assetid: e0fd70b6-73a4-4426-92d7-bb300457597e
caps.latest.revision: 8
author: kabala123
ms.author: kabala
manager: sakudes
tags: 
 - "MigrationHO"

---
# Install, deploy, and upgrade Unified Service Desk
Before you can install and deploy [!INCLUDE[pn_unified_service_desk_for_crm](../../includes/pn-unified-service-desk-for-crm.md)], you must identify the [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] instance that you want to build and deploy the configuration on. While you can use a new [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] instance, [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] works best when the [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] customization is mostly complete. [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] controls the call center agent’s view of [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] by manipulating windows, injecting [!INCLUDE[pn_JavaScript](../../includes/pn-javascript.md)], and so on. If major changes occur to the [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] environment after [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] is deployed, it might cause your [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] configuration to no longer work as required. While the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] configuration often comes later in a [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] implementation, having [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] in mind when designing your [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] environment is beneficial.  
  
 [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] installation and deployment is done in phases where initially you set up a development environment to configure agent applications using one of the sample [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] applications as the base. Next, you test how your configurations appear and work using the the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application by connecting to the [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] instance where you configured [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)]. Next, you use the customized [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] configuration on to a production instance of [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)], and the client application. The configuration includes the Customization Files package used to distribute to your agent’s computers any files and assemblies that are required.  
  
> [!IMPORTANT]
>  You can configure [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] to integrate with third-party line-of-business (LOB) applications. However, before deploying an integrated solution (involving [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and LOB applications) in the production environment in your organization, you must thoroughly test your integrated solution to ensure that the performance results are aligned with your expectations. [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] might not function appropriately if integrated with LOB applications that demonstrate user interface (UI) blocking, memory leak issues, and slow response times.  
  
 Listed below is the sequence that we recommend for installing and deploying [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] in your organization. Before installing [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)], ensure that you meet the system requirements: [Unified Service Desk system requirements](../../unified-service-desk/admin/unified-service-desk-system-requirements.md).  
  
## Step 1: Initial installation and deployment  
 Identify a [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] server where you want to deploy [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and a development computer that will be used for deploying [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] packages and then connecting to the packages by using the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client.  
  
1.  Install the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client on the development computer. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Install the Unified Service Desk Client](../../unified-service-desk/admin/install-upgrade-unified-service-desk-client.md)  
  
2.  Deploy [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] packages to the [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] instance. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Deploy Unified Service Desk packages to Dynamics 365 Server using Package Deployer](../../unified-service-desk/admin/deploy-sample-unified-service-desk-applications-using-package-deployer.md)  
  
3.  Run the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client, and connect to the [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] instance where you deployed the packages to verify that everything is working correctly. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Connect to Dynamics 365 instance using the Unified Service Desk client](../../unified-service-desk/admin/connect-dynamics-365-instance-using-unified-service-desk-client.md)  
  
 **Set up additional development computers**  
  
 To set up additional development computers for configuring your agent desktop applications using [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)], install the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client on the computer. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Install Unified Service Desk Client](../../unified-service-desk/admin/install-upgrade-deploy-unified-service-desk.md)  
  
## Step 2: Configure and test your agent application  
 Use your development environment to configure your agent application by building on one of the available sample applications you deployed, and then test it by connecting to the customized package using the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Use Unified Service Desk to configure your agent application](../../unified-service-desk/configure-agent-application-unified-service-desk.md)  
  
## Step 3: Deploy the customized agent application  
 After you have customized your agent application through configuration or custom code, you must install the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application along with any files required for the custom functionality on your agent’s computers. Consider creating a [!INCLUDE[pn_clickonce](../../includes/pn-clickonce.md)] application or an MSI package installer to bundle all the files together and deploy on the agent computers in your organization. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] see [MSDN: ClickOnce Security and Deployment](http://msdn.microsoft.com/library/t71a733d.aspx) or [MSDN: Windows Installer](http://msdn.microsoft.com/library/cc185688\(v=vs.85\).aspx)  
  
 You might also want to migrate your [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] configuration from a development/test to a production environment. You can use the new [!INCLUDE[pn_configuration_migration_tool](../../includes/pn-configuration-migration-tool.md)] to migrate your [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] configuration data across [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] instance. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Migrate your Unified Service Desk configuration to another Dynamics 365 server](../../unified-service-desk/admin/migrate-unified-service-desk-configuration-dynamics-365-server.md)  
    
  
## See also  
 [Unified Service Desk system requirements](../../unified-service-desk/admin/unified-service-desk-system-requirements.md)  
  
 [Install Unified Service Desk Client](../../unified-service-desk/admin/install-upgrade-unified-service-desk-client.md)  
  
 [Deploy sample Unified Service Desk applications to Dynamics 365 Server using Package Deployer](../../unified-service-desk/admin/deploy-sample-unified-service-desk-applications-using-package-deployer.md)  
  
 [Connect to Dynamics 365 instance using the Unified Service Desk client](../../unified-service-desk/admin/connect-dynamics-365-instance-using-unified-service-desk-client.md)   
 
