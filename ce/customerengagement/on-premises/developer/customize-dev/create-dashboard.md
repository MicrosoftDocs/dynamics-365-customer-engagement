---
title: "Create a dashboard (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Organization-owned dashboards can be created by using the Dynamics 365 Customer Engagement web services (SDK) or by customizing the entity form in Dynamics 365 Customer Engagement by editing the customizations.xml file."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 155a627a-fae8-4154-89a7-28b7fc912db0
caps.latest.revision: 28
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Create a dashboard

Organization-owned dashboards can be created by using the [!INCLUDE[cc-dyn365-ce-web-services](../../includes/cc-dyn365-ce-web-services.md)] or by customizing the entity form in [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] by editing the customizations.xml file.  
  
> [!NOTE]
>  Some dashboards that are created by using the SDK or by customizing the entity form are not supported by the Dashboard Designer in the Web application. For more information, see [Limitations: Creating dashboards by using the SDK or through form customization](#Limitations) later in this topic.  
  
 Before creating a dashboard, consider the following:  
  
- **Type of dashboard**: If you want your dashboards to be available across the organization and do not want to manage the access levels at a more detailed level, you might want to create an organization-owned dashboard. However, if you are concerned about the access privileges and security of your dashboard, consider creating a user-owned dashboard where you have more control on who can access it.  
  
     To create organization-owned dashboards, you must have the System Administrator or System Customizer role.  
  
- **Dashboard layout**: While creating dashboards, you have to use the FormXML to define the dashboard components and layout. For information about working with FormXML to define a dashboard, see [Dashboard Components and FormXML Elements](understand-dashboards-dashboard-components-formxml.md#DashboardComponentsandFormXML). For some sample FormXMLs of different types of dashboards, see [Sample Dashboards](sample-dashboards.md).  
  
<a name="UsingSDK"></a>   
## Create a dashboard by using the SDK  
 To create a dashboard, create an instance of `SystemForm` for an organization-owned dashboard, or `UserForm` for a user-owned dashboard. The following sample shows how to create an organization-owned dashboard.  
  
 [!code-csharp[VisualizationsAndDashboards#CRUDDashboards2](../../snippets/csharp/CRMV8/visualizationsanddashboards/cs/cruddashboards2.cs#cruddashboards2)]  
  
 For a complete sample, see [Sample: Create, Retrieve, Update and Delete (CRUD) a Dashboard](sample-create-retrieve-update-delete-dashboard.md). For a sample to create a user-owned dashboard, and assign it to another user, see [Sample: Assign a User-Owned Dashboard to Another User](sample-assign-user-owned-dashboard-another-user.md).  
  
<a name="UsingFormCustomization"></a>   
## Create an organization-owned dashboard by customizing the entity form  
 The customizations.xml file that is exported with an unmanaged solution contains definitions for entity forms and dashboards. You can add or modify the customizations.xml file to add or update a dashboard.  
  
#### Create a dashboard by customizing an entity form  
  
1. Log on to [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)].  
  
2. Export a solution. For information about doing so, see [Exporting, Preparing to Edit, and Importing the Ribbon](export-prepare-edit-import-ribbon.md).  
  
3. Browse to the customizations.xml file in the exported solution folder, and open it for editing.  
  
4. Browse to the end of the dashboards area in the customizations.xml file by searching for the following tag: `</Dashboards>`  
  
5. Before the `</Dashboards>` tag, add the following to define a new dashboard:  
  
   ```xml  
   <Dashboard>  
      <LocalizedNames>  
         <LocalizedName description="Dashboard_Name" languagecode="1033" />  
      </LocalizedNames>     
      <IsCustomizable>1</IsCustomizable>  
      <IsDefault>0</IsDefault>  
      <FormXml>  
         <forms type="dashboard">  
   *** Dashboard definition goes here. *** // See “Sample Dashboards” topic for the FormXML content to be used here.  
         </forms>  
      </FormXml>  
   </Dashboard>  
   ```  
  
6. Save the customizations.xml file.  
  
7. Import the .zip file as a solution in [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Exporting, Preparing to Edit, and Importing the Ribbon](export-prepare-edit-import-ribbon.md).  
  
<a name="Limitations"></a>   

## Limitations: Creating dashboards by using the SDK or through form customization  

 Certain dashboards that are created or modified using the [!INCLUDE[cc-dyn365-ce-web-services](../../includes/cc-dyn365-ce-web-services.md)] or through form customization are not supported by the dashboard designer in the Web application. Avoid the following while creating or modifying a dashboard using the SDK or through form customization.  
  
### General  
  
- **Problem**: You can create a dashboard that contains a tab without any section defined in the FormXML.  
  
  **Resolution**: Make sure that you create a dashboard with at least one section defined for each tab in the FormXML.  
  
- **Problem**: You can create a dashboard that does not have the same number of `<row>` elements for a section as specified in the `rowspan` property of a `<cell>` element of the section in the FormXML. Ideally, the `rowspan` property value of a `<cell>` element and the number of `<row>` elements in a section must be same.  
  
  **Resolution**: Make sure that you create a dashboard that has the same number of `<row>` elements for a section as specified in the `rowspan` property of a `<cell>` element in the section.  
  
### Grids  
 **Problem**: You can create a dashboard that contains grids with the `<AutoExpand>` parameter value set to `Auto` for the grid.  
  
 **Resolution**: Make sure that you specify the `<AutoExpand>` parameter value as `Fixed` for the grids in the FormXML while creating a dashboard.  
  
### IFRAMEs  
 **Problem**: You can create a dashboard that contains an IFRAME. This happens when you do not specify any value for the `<Url>` parameter for the IFRAME control in the FormXML.  
  
 **Resolution**: Make sure that you specify a value for the `<Url>` parameter while creating an IFRAME in the FormXML.  
  
### See also  
 [Dashboards for Microsoft Dynamics 365 Customer Engagement](analyze-data-with-dashboards.md)   
 [Using FormXML for Dashboards](understand-dashboards-dashboard-components-formxml.md)   
 [Actions on Dashboards](actions-dashboards.md)   
 [Sample dashboards](sample-dashboards.md)   
 [Sample: Create, Retrieve, Update and Delete (CRUD) a Dashboard](sample-create-retrieve-update-delete-dashboard.md)   
 [Customize Entity Forms in Microsoft Dynamics 365 Customer Engagement](customize-entity-forms.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]