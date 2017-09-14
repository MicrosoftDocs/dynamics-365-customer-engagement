---
title: "Install Dynamics 365 for Field Service | MicrosoftDocs"
ms.custom: ""
ms.date: 09/30/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: "mkaur"
manager: "amyla"
---
# Install [!INCLUDE[pn_dyn_365_field_service](../includes/pn-dyn-365-field-service.md)]
[!INCLUDE[pn_dyn_365_field_service](../includes/pn-dyn-365-field-service.md)] is an end-to-end solution that you can use to manage your field service team.  
  
> [!IMPORTANT]
> - The capabilities in this solution require [!INCLUDE[pn_crm_2016](../includes/pn-crm-2016.md)].  
> - Before you install the [!INCLUDE[pn_field_service](../includes/pn-field-service.md)] solution, you need to accept the terms and conditions to configure it in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)].  
  
<a name="BKMK_online_Install"></a>   
## Install Field Service (online)  
 [!INCLUDE[pn_dyn_365_field_service](../includes/pn-dyn-365-field-service.md)] is a preferred solution. There are several ways to install it. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Onboard your organization and users to Dynamics 365 (online)](../admin/onboard-your-organization-and-users-to-dynamics-365-online.md)  
  
> [!IMPORTANT]
>  You can't run an older version of [!INCLUDE[pn_dyn_365_project_service_auto](../includes/pn-dyn-365-project-service-auto.md)] and a new version of [!INCLUDE[pn_fieldservice_long_sentencecase](../includes/pn-fieldservice-long-sentencecase.md)] on the same instance.  
  
<a name="BKMK_installOnprem"></a>   
<!--
## Install Field Service (on-premises)  
 This feature is supported of the way of the December 2016 Update for Microsoft Dynamics 365 (online) or later. Before you install [!INCLUDE[pn_field_service](../includes/pn-field-service.md)] (on-premises) make sure you have the following:  
  
-   A [!INCLUDE[pn_dyn_365_field_service](../includes/pn-dyn-365-field-service.md)] Enterprise Edition (online) license, or a [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] Enterprise Plan 1 or Plan 2 (online) license. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Read “Dual Use Rights" in the Licensing and Pricing Guide](https://go.microsoft.com/fwlink/?linkid=833491).  
  
-   Active on-premises deployment of Microsoft Dynamics 365 Server.  
  
-   A user account with Office 365 Global Administrator (online) and Dynamics 365 Directory Administrator (on-premises) credentials.  
  
1.  To download and install Field Service (on-premises), go to:                      [Microsoft Dynamics 365 Downloads](https://go.microsoft.com/fwlink/?linkid=837779).  
  
2.  Read and accept the license agreement.  
  
3.  Extract the files. The package deployer installation tool will launch automatically.  
  
    > [!NOTE]
    >  If the installation tool doesn't launch, run the PackageDeployer.exe tool from the Field Service sub-folder in the installation folder.  
  
4.  On the **Connect to Microsoft Dynamics CRM** screen, select **On-premises** **Deployment Type** and then enter your administrator credentials for the server.  
  
5.  Click **Next** and proceed through the installation steps.  
  
6.  On the **[!INCLUDE[pn_dyn_365_field_service](../includes/pn-dyn-365-field-service.md)] License Validation** screen, enter your Dynamics 365 (online) administrator credentials and then click **Next**.  
  
7.  Proceed through the installation steps to complete the installation.  
  
 The following online services or capabilities are not supported for on-premises use:  
  
|Service or Capability|Description|  
|---------------------------|-----------------|  
|Resource Schedule Optimization|Cloud-based add-on service that automates the assignment of resources to match work based on skills, availability, travel time, and other resource profile and work requirements.|  
|Connected Field Service|Cloud-based integration and process extension that connects Field Service to the Azure IoT Suite through the Internet of Things connector.|  
|Office 365 Exchange integration|Cloud-based integration that enables synchronization of assigned work and appointments with individual user calendars.|  
|Power BI|Cloud-based suite of business analytics tools to analyze data and share insights.|  
|Portal capabilities for Microsoft Dynamics 365|Cloud-based portal experiences that depend on online services.|  
|Voice of the Customer for Microsoft Dynamics 365|Cloud-based service to create and send surveys for feedback from your customers about products or services.|  
|Integration with Glympse|Connection to a third party, cloud-based service that enables businesses and channel partners to provide the benefits of real-time location sharing to their customers.|  
|Dynamics 365 for phones and tablets – mobile offline|Enhanced offline experiences for mobile users that depends on cloud-based services for synchronization.|  
|System Telemetry|Cloud-based insights into system operations and performance.|  
-->

<a name="BKMK_users"></a>   
## Add users  
 To learn more, see: [View user accounts and security roles](../field-service/view-user-accounts-security-roles.md).  
  
<a name="BKMK_customize"></a>   
## Customize Field Service forms and reports  
 If you want to customize any of the [!INCLUDE[pn_field_service](../includes/pn-field-service.md)] forms, dashboards, or reports, you can find more information about customizing Microsoft Dynamics 365 in the following links:  
  
-   [Customize your system](../customize/getting-started-customization.md)  
  
-   [Create and design forms](../customize/create-design-forms.md)  
  
-   [Create and edit dashboards](../customize/create-edit-dashboards.md)  
  
-   [Create and edit processes](../customize/guide-staff-through-common-tasks-processes.md)  
  
-   [Developers guide to reports for Dynamics 365](https://msdn.microsoft.com/library/gg328097.aspx)  
  
### See also  
 [Overview of Dynamics 365 for Field Service](../field-service/overview.md)<br>
 [View user accounts and security roles](../field-service/view-user-accounts-security-roles.md)   
 [Configure default settings](../field-service/configure-default-settings.md)   
 [Turn on auto geocoding](../field-service/turn-on-auto-geocoding.md)<br>
 [User's Guide](../field-service/user-guide.md)
