---
title: "Introduction to solutions (Developer Guide for Dynamics 365 Customer Engagement (on-premises))| MicrosoftDocs"
description: "Developers and authors create, package and maintain units that extend Dynamics 365 Customer Engagement (on-premises)"
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: get-started-article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: e41e1785-7dcd-46b9-a2eb-e4e848c3154c
caps.latest.revision: 59
author: shmcarth
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Introduction to solutions

[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Introduction to solutions](/powerapps/developer/common-data-service/introduction-solutions).

*Solutions* are how customizers and developers author, package, and maintain units of software that extend [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. Customizers and developers distribute solutions so that organizations can use Dynamics 365 Customer Engagement (on-premises) to install and uninstall the business functionality defined by the solution.  
  
<a name="BKMK_ExtensibilityChoices"></a>   
## Extensibility choices  
 Use solutions to extend the capability of Dynamics 365 Customer Engagement (on-premises). For software that operates outside the application, use traditional methods to package and install your application, such as an installer program.  
  
 If your application consists only of Dynamics 365 Customer Engagement (on-premises) solution components, it can be imported directly into [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]. You won't have to create an installer program.  
  
 ![An application with external components](media/external-components.png "An application with external components")  
  
 However, if your extensions include a combination of Dynamics 365 Customer Engagement (on-premises) solution components and external components, which are not Dynamics 365 Customer Engagement (on-premises) solution components, you'll need an installer.  
  
 For example, you can create a [!INCLUDE[pn_NET_Framework](../includes/pn-net-framework.md)] application that manages data stored in custom Dynamics 365 Customer Engagement (on-premises) entities using the web service APIs. People who install your application may install a Dynamics 365 Customer Engagement (on-premises) solution to create the custom entities and then install your application separately by using an installer. Or, you could include the installation of the Dynamics 365 Customer Engagement (on-premises) solution into the installer you create for your application.  
  
<a name="BKMK_VersionCompat"></a>   
## Version compatibility  
 Solutions exported from an earlier version of [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] can be imported into later versions as shown in the following chart.  
  
 ![Solution version compatiblity](media/crm_v9.0_solution_compatibility_chart.png) 
  
 Generally, solutions can be imported into organizations less than two versions higher than the version the solution was exported from. Service pack releases will provide the option to either export a solution with compatibility for that service pack, or just with capabilities included in the base version. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Maintain managed solutions: Version compatibility](maintain-managed-solutions.md#BKMK_VersionCompatibilty).  
  
> [!NOTE]
> For information about solutions created before [!INCLUDE [pn-crm-2015](../includes/pn-crm-2015.md)] see [Dynamics CRM 2016 Introduction to solutions > Version compatibility](https://msdn.microsoft.com/library/gg334576.aspx#BKMK_VersionCompat)
  
<a name="BKMK_SolutionComponents"></a>

## Solution components

 Solution components are created by using the customization tools or APIs included in Dynamics 365 Customer Engagement (on-premises) and are fully hosted in the application. The following diagram shows the types of solution components.  
  
 ![Solution Components](media/solution-components.png "Solution Components")  
  
 When you define a [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] solution you create a group of solution components that can be managed together.  
  
> [!NOTE]
>  Solutions can only add new solution components or overwrite existing solution components. Solutions can't be used to delete solution components.  
  
<a name="BKMK_UnmanagedandManagedSolutions"></a>   
## Unmanaged and managed solutions  
 There are two types of Dynamics 365 Customer Engagement (on-premises) solutions: *managed* and *unmanaged*. A managed solution is a completed solution that is intended to be distributed and installed. An unmanaged solution is one that is still under development or isn't intended to be distributed. When the unmanaged solution is complete and you want to distribute it, export it and package it as a managed solution.  
  
 The following diagram introduces how managed and unmanaged solutions interact with the system solution to control application behavior.  
  
 ![Solution layering](media/solution-layering.png "Solution layering")  
  
 **System solution**  
 The system solution represents the solution components defined within Dynamics 365 Customer Engagement (on-premises). Without any managed solutions or customizations, the system solution defines the default application behavior.  
  
 Many of the components in the system solution are customizable and can be used in managed solutions or unmanaged customizations.  
  
 **Managed solutions**  
 Managed solutions are installed on top of the system solution and can modify any customizable solution components or add more solution components. 
  
 Managed solutions can also be layered on top of other managed solutions. As long as a managed solution enables customization of its solution components, other managed solutions can be installed on top of it and modify any customizable solution components that it provides.  
  
 **Unmanaged customizations**  
 All customizable solution components provided by the system solution or any managed solutions can be customized in the unmanaged customizations.  
  
 **Unmanaged solutions**  
 Unmanaged solutions are groups of unmanaged customizations. Any unmanaged customized solution component can be associated with any number of unmanaged solutions.  
  
 You create a managed solution by exporting an unmanaged solution and selecting to package it as a managed solution.  
  
 **Application behavior**  
 The ultimate behavior of an instance of Dynamics 365 Customer Engagement (on-premises) for a specific organization is the culmination of the system solution, any managed solutions, and any unmanaged customizations.  
  
### Unmanaged solutions  
 When a solution is unmanaged, you can perform the following actions:  
  
- Add components.  
  
- Remove components.  
  
- Delete components that allow for deletion.  
  
- Export and import the unmanaged solution.  
  
- Export the solution as a managed solution.  
  
  [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create, Export, or Import an Unmanaged Solution](create-export-import-unmanaged-solution.md)  
  
#### Importing unmanaged solutions  
 When you import an unmanaged solution, you can edit its components in the new organization.  
  
> [!IMPORTANT]
>  When you import an unmanaged solution, the definitions of any solution components that already are in the organization will be overwritten. You can't undo this action.  
  
#### Unmanaged customizations  
 Each Dynamics 365 Customer Engagement (on-premises) organization contains customizable solution components. Together, all of these solution components are called the *default solution*. This is the solution you edit when you select **Customize the System** in the application. You can export this solution and the customizations in it in just like an unmanaged solution. However, you can't export the default solution as a managed solution.  
  
#### Create an unmanaged solution  
 If you don't intend to generate a managed solution, you don't have to create an unmanaged solution. You can customize the system directly. Organizations that just want to be able to edit, back up, and transport their customizations don't have to use the more advanced capabilities of the Dynamics 365 Customer Engagement (on-premises) solution framework.  
  
 When you create an unmanaged solution, you create a way to group a subset of the available customizable solution components. The solution components in an unmanaged solution are references to customizable solution components in the organization.  
  
 After you create an unmanaged solution, you can add solution components to it. By using this smaller set of components you can decide to only include those solution components that are relevant to a particular functionality. This allows for a smaller size package when you export your solution and makes a more manageable set of components.  
  
 Any components you add to your unmanaged solution are included in the customizable solution components for the system. Unmanaged solution components can be added to multiple unmanaged solutions.  
  
> [!IMPORTANT]
>  Because each unmanaged solution contains a reference to the shared group of solutions, changes you make to solution components in one solution are also applied for all unmanaged solutions that reference those solution components.  
  
> [!TIP]
>  You can also create unmanaged solutions just to provide convenient access to specific solution components. For example, you may use lots of HTML web resources but only some of them represent top-level user interface elements in your solution. You may want to create an unmanaged solution that includes only those top-level user interface components so that you can locate and open them easily.  
  
##### Solution publisher for unmanaged solutions  
 Each solution requires a solution publisher. For an unmanaged solution, the solution publisher provides a common customization prefix and option value prefix. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create a Solution Publisher](create-export-import-unmanaged-solution.md#BKMK_CreateSolutionPublisher)  
  
 Many solutions can be associated with a single solution publisher. Each organization will have a solution publisher called "Default Publisher for \<*OrganizationUniqueName*>". If you want all your unmanaged solutions to share the same customization prefix and option value prefix, we recommend that you just associate your unmanaged solutions with the default publisher for your organization.  
  
> [!NOTE]
>  The solution publisher controls how managed solutions can be updated. When you install a managed solution, the publisher is visible but you can't associate an unmanaged solution with it. If you intend to distribute a managed solution, see [Solution Publisher for managed solutions](introduction-solutions.md#BKMK_SoluitonPublisherManagedSolutions).  
  
#### Delete an unmanaged solution  
 If you delete an unmanaged solution, you just delete the group used to contain references to solution components. The solution components in an unmanaged solution remain in the system but they are no longer associated with the unmanaged solution you delete.  
  
> [!NOTE]
>  If you delete a solution component in an unmanaged solution, it is deleted from the system and is no longer available from any other unmanaged solution. Use "remove" instead of "delete" if you just want to remove a solution component from an unmanaged solution.  
  
### Managed solutions  
 If you intend to distribute your solution as a managed solution, export your unmanaged solution and select the **Managed** option in the **Package Type** dialog box.  
  
> [!NOTE]
>  After you generate a managed solution, you can't install it in the same Dynamics 365 Customer Engagement (on-premises) organization that contains the unmanaged solution used to create it. It must be installed in a different organization.  
  
 After you install a managed solution, the following applies:  
  
- You can't add or remove solution components in a managed solution.  
  
- You can't export a managed solution.  
  
- Deleting a managed solution uninstalls all the solution components in it.  
  
  [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create, Install, and Update a Managed Solution](create-install-update-managed-solution.md)  
  
  After you install a managed solution you may be able to customize the solution components if the creator of the managed solution has configured the managed solution to enable it. You must access the customizable solution components using **Customize the System** instead of through the managed solution itself.  
  
  Use [Managed Properties](introduction-solutions.md#BKMK_ManagedProperties) to control whether a solution component is customizable and what specific customization actions are enabled.  
  
<a name="BKMK_SoluitonPublisherManagedSolutions"></a>   
#### Solution publisher for managed solutions  
 When you intend to distribute managed solutions, the solution publisher record associated with your managed solution is created in each organization that installs your solution. Use the solution publisher to provide information about how people who install your solution can contact you.  
  
 The solution publisher for a managed solution is also important if you want to release an update to your managed solution. If you use the same solution publisher you can create a new managed solution with the ability to update a managed solution you previously released. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Maintain Managed Solutions](maintain-managed-solutions.md)  
  
<a name="BKMK_ManagedProperties"></a>   
## Managed properties  
 Using managed properties, the creator of a managed solution can control whether a solution component is customizable and which specific parts of it can be customized.  
  
> [!NOTE]
>  Managed properties must be set in an unmanaged solution. The managed property settings are only applied after the managed solution has been packaged and installed.  
  
 The exact managed properties available depend on the type of solution component. The following screenshot shows the managed properties for a custom entity.  
  
 ![Managed properties for an entity](media/entity-managed-properties.png "Managed properties for an entity")  
  
 By default, the managed property settings assume that any kind of solution component is fully customizable. Solution developers are encouraged to enable solution components in their solutions to be customizable. However, there are situations where the definition of a solution component must be "locked down" to avoid potential breaking changes or to make future maintenance of the solution component easier.  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use Managed Properties](use-managed-properties.md)  
  
<a name="BKMK_ConflictResolution"></a>   
## Conflict resolution  
 When two or more solutions define solution components differently, Dynamics 365 Customer Engagement (on-premises) resolve the conflict using two strategies, **Merge** and **Top Wins**. The following diagram illustrates the differences.  
  
 ![Two Solution conflict resolution strategies](media/solution-merge.png "Two Solution conflict resolution strategies")  
  
 **Merge**  
 User interface components (command bar, ribbons, forms, and site map) are merged. This means that the solution components are re-calculated from the lowest level to the highest so that the organization's unmanaged customizations are the last to be applied.  
  
 **Top Wins**  
 For all other solution components any conflict is calculated in favor of the customization that is applied last. For managed solutions this usually means that the last solution installed is applied. However, there is a special case when an update to a managed solution is installed.  
  
### Conflict resolution on the update of a managed solution  
 Because unmanaged customizations are considered "above" any managed solution in terms of conflict resolution, organizations installing an update to a managed solution may not see their changes applied because of unmanaged modifications. An option exists to make sure that changes applied by an update to a managed solution are available.  
  
 When you release an update to a managed solution, the organization installing the update can select:  
  
- To preserve any customizations it has applied on top of your managed solution.  
  
- To overwrite any customizations it has applied on top of your managed solution.  
  
  Organizations installing an update to a managed solution should work with the managed solution creator to evaluate which option is best.  
  
> [!IMPORTANT]
>  Changes to entity forms and the sitemap won't be overwritten even when the overwrite option is selected. Refer to [Merge Form Customizations](understand-managed-solutions-merged.md#BKMK_MergingFormCustomizations) and  [Merge Navigation (SiteMap) Customizations](understand-managed-solutions-merged.md#BKMK_MergingNavigationCustomizations) for guidance about managing changes. Some manual customization may be required to merge unmanaged customizations into changes included in an update to a managed solution.  
  
<a name="BKMK_DependencyTracking"></a>   
## Dependency tracking  
 The solutions framework automatically tracks dependencies for solution components. Every operation on a solution component automatically calculates any dependencies to other components in the system. The dependency information is used to maintain the integrity of the system and prevent operations that would lead to an inconsistent state.  
  
 As a result of dependency tracking, the following behaviors are enforced:  
  
- Deleting a component is prevented if another component in the system depends on it.  
  
- Exporting a solution warns the user if there are any missing components that could potentially cause failure when importing that solution in another system.  
  
   Warnings during export can be ignored if the solution developer intends that the solution is only to be installed in an organization where dependent components are expected to exist. For example, when you're creating a solution that's designed to be installed over a pre-installed "base" solution.  
  
- Importing a solution fails if all required components aren't included in the solution and also don't exist in the target system.  
  
  -   Additionally, when you import a managed solution, all required components must match the package type of the solution. A component in a managed solution can only depend on another managed component.  
  
  [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Dependency Tracking for Solution Components](dependency-tracking-solution-components.md)  
  
<a name="BKMK_SupportforMultipleLanguages"></a>   
## Support for multiple languages  
 Dynamics 365 Customer Engagement (on-premises) natively supports multiple languages. Whenever a language pack (sometimes referred to as a "MUI pack") is installed, user interface elements can be displayed in a different language.  
  
 There are a number of different tactics you should apply based on the type of solution components included in your solution. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create Solutions that Support Multiple Languages](create-solutions-support-multiple-languages.md)  
  
### See also  
 [Package and Distribute Extensions with Dynamics 365 Customer Engagement (on-premises) Solutions](package-distribute-extensions-use-solutions.md)   
 [Microsoft Dynamics 365 Customer Engagement patterns & principles for solution builders](https://go.microsoft.com/fwlink/p/?LinkID=533946)   
 [Plan For Solution Development](plan-solution-development.md)   
 [Dependency Tracking for Solution Components](dependency-tracking-solution-components.md)   
 [Create, Export, or Import an Unmanaged Solution](create-export-import-unmanaged-solution.md)   
 [Create, Install, and Update a Managed Solution](create-install-update-managed-solution.md)   
 [Uninstall or Delete a solution](uninstall-delete-solution.md)   
 [Create Solutions that Support Multiple Languages](create-solutions-support-multiple-languages.md)   
 [Solution Entities](solution-entities.md)   
 [Work with Solutions](work-solutions.md)   
 [Sample: Work With Solutions](sample-work-solutions.md)   
 [Sample: Detect Solution Dependencies](sample-detect-solution-dependencies.md)   
 [Solution Entities](solution-entities.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]