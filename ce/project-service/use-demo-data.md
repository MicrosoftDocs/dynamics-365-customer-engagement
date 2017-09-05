---
title: "Experiment with demo data (Dynamics 365 for Project Service Automation) | MicrosoftDocs"
ms.custom: ""
ms.date: "2017-09-15"
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.technology: 
  - "project-service-automation"
ms.tgt_pltfrm: ""
ms.topic: "get-started-article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: c7dc07fc-4968-41a9-8562-4e0b0a52a990
caps.latest.revision: 13
ms.author: "mkaur"
manager: "brycho"
---
# Experiment with demo data (Project Service Automation)
To become familiar with [!INCLUDE[pn_project_service_auto](../includes/pn-project-service-auto.md)] automation capabilities in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] Customer Engagement, it’s useful to have a pre-configured environment to explore. For this purpose, we’ve created a separate managed solution that makes it easier to explore and learn about the new solution. Running this package deployer performs the following actions:  
  
-   Builds default parameters that drive behavior of [!INCLUDE[pn_project_service_auto](../includes/pn-project-service-auto.md)]  
  
-   Creates default working calendars  
  
-   Imports sample data such as resources, projects, prices, roles, and other key information  
  
-   Associates resources with the proper working calendar  
  
-   Updates images of contacts and accounts  
  
 The preview demo data has skills, roles, projects, opportunities, and other configurations and settings that might be found in a global IT consulting firm.  
  
> [!IMPORTANT]
> **There is no way to un-install the demo data.** You should only use this package on demonstration or test systems. Some elements of the demo data and package deployer may be used to provision basic [!INCLUDE[pn_project_service_auto](../includes/pn-project-service-auto.md)] requirements.  
  
## Install [!INCLUDE[pn_project_service_auto](../includes/pn-project-service-auto.md)] demo data  
 If you haven’t already, install the [!INCLUDE[pn_project_service_auto](../includes/pn-project-service-auto.md)] preferred solution. See [Install and customize Project Service Automation](../project-service/install-customize.md) for information on how to do this.  
  
 When the configuration completes, you can load the demo data.  
  
## Download and unpack the [!INCLUDE[pn_project_service_auto](../includes/pn-project-service-auto.md)] demo data  
 The demo data solution is distributed as a .zip file (**PS_DemoData_Preview.zip**) from the [Microsoft Download Center](http://go.microsoft.com/fwlink/p/?LinkID=799201).  
  
## Modify users  
 The [!INCLUDE[pn_project_service_auto](../includes/pn-project-service-auto.md)] demo data uses two standard users that act as two key roles in project-based organizations, a Project Manager (Prakash Kovvuru) and a Team Member (Tricia Fejfar). The [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] organization that you are using must have two users that act as these standard roles. If your system is purely a demo environment, we recommend you create users with these names. For preview, the users you use should have System Administrator privileges  in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] Customer Engagement.  
  
 If you want to use other user names, such as those of existing users on your tenant, edit the names in the config file named **DemoDataConfig.xml** within the **PkgFolder** folder in the demo data distribution package and replace the **NewName** value with the full name of your licenced and activated users. For example, if you have two users called User One and User Two, your config file would look like:  
  
```  
<configkeys>  
          <user SecurityRole="Project Manager" NewName="User One" OriginalName="Prakash Kovvuru"/>  
          <user SecurityRole="Project Consultant" NewName="User Two" OriginalName="Tricia Fejfar"/>  
          <key KeyValue="Yes" KeyName="DoProjectServiceProcessing"/>  
</configkeys>  
  
```  
  
## Run the package  
 To set up demo data:  
  
1.  Run **PackageDeployer.exe** in the unzipped folder.  
  
2.  Agree to the terms.  
  
3.  On the next window:  
  
    1.  Select deployment type **Office 365**.  
  
    2.  Use the user and password of a system administrator.  
  
    3.  Make sure **Display list of available organizations** is checked.  
  
4.  Select the appropriate preview organization.  
  
5.  Click **Next** four times. Demo data will take up to two hours to load. Ensure your client computer remains on and connected to the Internet during the process.  
  
6.  After loading completes, click **Finish** to exit the package deployer.  
  
## Verify the data  
 After the demo data completely loads to the **Resource Availability** page or the **Projects** page within the [!INCLUDE[pn_project_service_auto](../includes/pn-project-service-auto.md)] navigation menu, log in as one of the users defined in *Modify Users* above. You should see a list of projects and resources respectively. You can use the standard data import functions to review the status of your data load from the menu **Settings > Data Management > Data Imports**.  
  
## Add resource bookings  
 You can add resource bookings to make the **Resource Availability** page shows a more realistic assignment distribution. This file is currently not added automatically by the package deployer.  
  
1.  Go to **Settings > Data Management > Data Imports** and then click **Import Data**.  
  
2.  When prompted for the file, choose the file **Team Member Bookings** from the **PkgFolder** folder in the demo data that you extracted.  
  
3.  When prompted for a data map, choose **Team Member Bookings DM**.  
  
4.  Ignore any unmapped fields and complete the wizard.  
  
## Multi-currency scenarios and resource bookings  
 You can load two additional files from the **PkgFolder**:  
  
- **C1 Bookable Resources**: Populates resource bookings and team members to show how the **Resource Availability** view appears with more realistic bookings.  
  
- **Default Price Lists**: Populates the list of default price lists found in **Project Service > Parameters >Default Price Lists**. This helps demonstrate multi-currency, multi-organization functionality.  
  
 To load these files, you need to run Package Deployer a second time:  
  
1.  Open the **ImportConfig.xml** file in the **PkgFolder** folder using a text editor like Notepad.  
  
2.  Remove the comments around the two file names.  
  
3.  Re-run the package deployer, which will load just these two files. Note that all of the files already loaded will be skipped.  
  
## Activate products  
 If you want to explore using products and projects together, publish products and add them to price lists.  
  
1.  Go to **Settings > Product Catalog**.  
  
2.  Click **Families & Products**.  
  
3.  Select **Subscription Software** from the list and click **Publish > Publish Hierarchy**.  
  
4.  Refresh the grid to ensure that the family and associated items (Dynamics 365 Enterprise, Professional, and Standard) are now **Active**.  
  
5.  Go to **Project Service > Settings > Price Lists**. You will see different price lists for different currencies for Software Rates (such as France Software Rates 2016 or US Software Rates 2016).  
  
6.  For each currency you wish to use, open the price list.  
  
7.  Expand **Price List Items**, and add the three Dynamics 365 Software License products to the list.  
  
## Group collaboration  
 The [!INCLUDE[pn_office_365_groups](../includes/pn-office-365-groups.md)] integration feature is a great complement to [!INCLUDE[pn_project_service_auto](../includes/pn-project-service-auto.md)]. To turn it on in your environment:  
  
1.  Enable the solution from the [!INCLUDE[pn_crm_online_admin_center](../includes/pn-crm-online-admin-center.md)].  
  
2.  Go to **Settings > Office 365 Groups**.  
  
3.  Add two entities, Opportunity and Project.  
  
4.  Publish the changes.  
  
## Customize the demo data  
 You might want to use this package deployer technique to tailor a demo environment to a different industry, language, or scenario. For instance, you might want skills and roles appropriate for an accounting firm, or different organizational units, or different resource names.  
  
 If you’re familiar with the standard data management functions of [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)], you can use the contents of the **PkgFolder** in conjunction with editing the **ImportConfig.xml** file found in that folder to load subsets of data, or make changes to the demo data. For more information about the data import functions of [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] Customer Engagement, see [Import data](../admin/import-data-all-record-types.md).  
  
### See Also  
 [Administrator Guide](../project-service/admin-guide.md)   
 [Account Manager Guide](../project-service/account-manager-guide.md)   
 [Project Manager Guide](../project-service/project-manager-guide.md)   
 [Resource Manager Guide](../project-service/resource-manager-guide.md)   
 [Time, Expense, and Collaboration Guide](../project-service/time-expense-collaboration-guide.md)