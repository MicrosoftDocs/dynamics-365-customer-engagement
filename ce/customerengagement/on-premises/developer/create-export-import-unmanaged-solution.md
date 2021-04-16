---
title: "Create, export, or import an unmanaged solution (Developer Guide for Dynamics 365 Customer Engagement (on-premises))| MicrosoftDocs"
description: "An unmanaged solution is useful as a way to group a set of unmanaged customizations into a set that can be transported between organizations"
ms.custom: 
ms.date: 04/02/2020
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - unmanaged solutions, creating; exporting; or importing
  - troubleshooting, importing solutions from earlier versions
  - solutions configuration page, about
  - solutions, maximum size of solutions to import
  - solution publishers, creating
  - creating solution publishers, list of fields for
  - distributing managed solutions, by using solution publishers
  - creating; exporting; or importing unmanaged solutions, creating solution publishers
  - creating; exporting; or importing unmanaged solutions, troubleshooting for importing from earlier versions
  - creating; exporting; or importing unmanaged solutions
  - unmanaged solutions, exporting and importing
  - unmanaged solutions, list of and description of fields
  - exporting or importing unmanaged solutions, about
  - creating; exporting; or importing unmanaged solutions, using the solutions configuration page
  - troubleshooting for importing solutions from earlier versions
  - creating; exporting; or importing unmanaged solutions, list of and description of fields for unmanaged solutions
  - importing unmanaged solutions, troubleshooting for importing from earlier versions
ms.assetid: d5a39fc3-054f-48d3-8dfc-64c4f8afe4dd
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Create, export, or import an unmanaged solution

[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Create, export, or import an unmanaged solution](/powerapps/developer/common-data-service/create-export-import-unmanaged-solution).

In addition to being a prerequisite to creating a managed solution, an unmanaged solution is useful as a way to group a set of unmanaged customizations into a set that can be transported between organizations.  

 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use solutions for your customizations](../customize/use-solutions-for-your-customizations.md).  

<a name="BKMK_CreateUnmanagedSolution"></a>   
## Create an unmanaged solution  
 Every solution requires a publisher. If you do not intend to distribute your solution, you can use the default publisher already created for your organization. See [Create a Solution Publisher](create-export-import-unmanaged-solution.md#BKMK_CreateSolutionPublisher) for information about how to create a solution publisher.  

 The following table lists the fields and descriptions that a solution contains.  


|      Field Label       |                                                                                                                                                              Description                                                                                                                                                               |
|------------------------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|    **Display Name**    |                                                                                                                                                       The name for the solution.                                                                                                                                                       |
|        **Name**        |                                     Dynamics 365 Customer Engagement (on-premises) generates a unique name is based on the **Display Name**. You can edit the unique name. The unique name must only contain alphanumeric characters or the underscore character.                                     |
|     **Publisher**      |                                                                                                                                Use the **Publisher** lookup to associate the solution with a publisher.                                                                                                                                |
|      **Version**       |                                                                                                                     Specify a version with the following format: major.minor.build.revision, for example: 1.0.0.0.                                                                                                                     |
| **Configuration Page** | If you include an HTML Web resource in your solution, you can use this lookup to add it as your designated configuration page.<br /><br /> [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use the Solution Configuration Page](create-export-import-unmanaged-solution.md#BKMK_UseSolutionConfigurationPage) |
|    **Description**     |                                                                                                                                  Use this field to include any relevant details about your solution.                                                                                                                                   |

 After you create an unmanaged solution you can add solution components by creating them in the context of this solution or by adding existing components from other solutions. For more information abouthow to create a solution programmatically, see [Create a Solution](work-solutions.md#BKMK_CreateASolution)  

<a name="BKMK_CreateSolutionPublisher"></a>   
### Create a solution publisher  
 If you want to distribute managed solutions, you should create a `Publisher`. The following table lists the fields and descriptions that a `Publisher` contains.  


|          Label          |                                                                                                                                                                                                       Description                                                                                                                                                                                                        |
|-------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|    **Display Name**     |                                                                                                                                                                       The name that to display in the **Publisher** lookup field in the solution.                                                                                                                                                                        |
|        **Name**         |                               Dynamics 365 Customer Engagement (on-premises) generate a unique name is based on the **Display Name**. The unique name can only contain alphanumeric characters and the underscore character. **Note:**  You use the `Unique Name` to uniquely identify a `Publisher`. Managed solutions that share the same publisher can update each other.                               |
|     **Description**     |                                                                                                                                                                           Use this field to include any relevant details about your solution.                                                                                                                                                                            |
|       **Prefix**        |                   The customization prefix helps you identify which publisher added a solution component. For example the prefix is added to the logical name of any entities or attributes created in the context of a solution associated with this publisher. The prefix must be between two and eight characters long, and can contain only alphanumeric characters. It cannot start with 'mscrm'.                   |
| **Option Value Prefix** | This value lets you help separate options that you add to option sets to support merging options. A value is auto-generated based on the **Prefix** text to help make it more unique. The value must be between 10,000 and 99,999.<br /><br /> [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Merging Option set options](understand-managed-solutions-merged.md#BKMK_MergingOptionSetOptions) |
|   **Contact Details**   |                                                                                                                                                           Use these fields to add information that will enable people who install the solution to contact you.                                                                                                                                                           |

 See [Create a Publisher](work-solutions.md#BKMK_CreatePublisher) for information about how to create a publisher programmatically.  

<a name="BKMK_UseSolutionConfigurationPage"></a>   
### Use the Solution Configuration page  
 The solution configuration page provides a canvas you can use to display information or enable customers to perform actions in the context of your solution. Set the configuration page by using the **Configuration Page** lookup field to select a Web Page (HTML) Web resource included in the solution. This will cause a new **Configuration** node to appear in the Solution window underneath the **Information** node and above the **Components** node. The **Configuration** node will display the Web resource you set.  

 You can use the solution configuration page to display controls that will configure your solution. For example, you may provide some entities in your solution that control the behavior of your solution. By using the Web API for data access, you can provide custom controls on your Web resource page to update data in these entities.  

<a name="BKMK_UnmanagedSolution"></a>   
## Export an unmanaged solution  
 You may want to export an unmanaged solution in the following situations:  

- You have to edit certain XML content in the customizations.xml file, for example, you may want to edit the SiteMap or create customized ribbons.  

- You want to transport your unmanaged solution from one organization to another.  

- You want to create a backup of your current set of customizations.  

  Exporting an unmanaged solution will create a compressed (zipped) file that can then be imported into another organization or the same organization.  

  Only published customizations are included when you export a solution, so be sure to publish any changes before you export a solution.  

  When you export a solution by using the web application, if your solution contains any missing required components, you will see the **Missing Required Components** step. You can disregard this warning only if you intend to import this as an unmanaged solution back into the original organization. Otherwise, follow the instructions in the dialog box to cancel the export and add the required components.  

  Use the <xref:Microsoft.Crm.Sdk.Messages.ExportSolutionRequest> message to programmatically export a solution. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Export or Package a Solution](work-solutions.md#BKMK_ExportPackageSolution)  

  When you export a solution by using the web application, in the **Export System Settings (Advanced)** step, you can select which system settings to include in your solution. These options are available to developers by using the <xref:Microsoft.Crm.Sdk.Messages.ExportSolutionRequest> via the members available in the request. See the remarks for the request for details about which settings are included.  

  You can pick a target version when you export a solution. You can export a solution that is compliant with earlier versions. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Export a solution for a specific Dynamics 365 Customer Engagement (on-premises) version]().  

<a name="BKMK_ImportUnmanagedSolution"></a>   
## Import an unmanaged solution  
 You should import an unmanaged solution in the following situations:  

- You want to transport a set of customizations from one organization to another, and you want to allow the solution components to be changed.  

- You want to restore or revert to an earlier set of solution component definitions  

  Importing an unmanaged solution is an additive process. Importing an older version of a managed solution will not remove solution components included in a newer version. However the definition of any solution component properties will be overwritten with the definition included in the last unmanaged solution you import.  

> [!IMPORTANT]
>  Changes applied by importing an unmanaged solution cannot be uninstalled. Do not install an unmanaged solution if you want to roll back the changes.  

 This operation is performed programmatically by using the <xref:Microsoft.Crm.Sdk.Messages.ImportSolutionRequest> message. You can write code to execute this message asynchronously. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use ExecuteAsync to execute messages asynchronously](/powerapps/developer/common-data-service/org-service/use-executeasync). You can track the progress of the import or generate a report of the success of the import by using the `ImportJob` entity. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Install or Upgrade a Solution](work-solutions.md#BKMK_InstallUpgradeSolution)  

> [!IMPORTANT]
>  Installing a solution or publishing customizations can interfere with normal system operation. We recommend that you schedule solution imports when it's least disruptive to users.  

<a name="BKMK_MaxSizeOfSolution"></a>   
### Maximum size of solution to import  
 For [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] the maximum size for a solution is 29.296 MB.  

 For on-premises organizations, the default maximum size for a solution is 6 MB, but this can be increased as needed.  

[!INCLUDE[cc_sdk_onpremises_note](../includes/cc-sdk-onpremises-note.md)]

 Change the maximum allowed size by editing the [\<httpRuntime>](https://msdn.microsoft.com/library/e1f13641\(v=vs.100\).aspx) element in the web.config file for the application. Edit the `executionTimeout` and `maxRequestLength` attributes to allow for the necessary size. After you finish installing the solution you can set it to the size you want.  

### See also  
 [Plan For Solution Development](plan-solution-development.md)   
 [Package and Distribute Extensions with Dynamics 365 Customer Engagement (on-premises) Solution](package-distribute-extensions-use-solutions.md)   
 [Customization Solutions File Schema](customize-dev/customization-solutions-file-schema.md)   
 [Create, Install, and Update a Managed Solution](create-install-update-managed-solution.md)   
 [Uninstall or Delete a solution](uninstall-delete-solution.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]