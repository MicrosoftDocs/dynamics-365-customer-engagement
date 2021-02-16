---
title: "Work with solutions (Dynamics 365 Customer Engagement on-premises)| MicrosoftDocs"
description: "Learn how solutions are distributed"
ms.custom: 
  - dyn365-deflc
ms.date: 12/04/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - powerapps
author: Mattp123
ms.assetid: ece68f5f-ad40-4bfa-975a-3e5bafb854aa
caps.latest.revision: 55
ms.author: "matp"
manager: "kvivek"
---

# Solutions overview  
[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Solutions overview](/powerapps/maker/common-data-service/solutions-overview)
 
In Dynamics 365 Customer Engagement (on-premises), solutions are leveraged to transport apps and components from one organization to another or to apply a set of customizations to existing apps. A solution can contain one or more apps as well as other components such as site maps, entities, processes, web resources, option sets, and more. You can get solutions from [AppSource](https://appsource.microsoft.com/) or from an independent software vendor (ISV). A solution is a file that you can import in to an environment as an app or to apply a set of customizations to an existing app.  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Whitepaper: Patterns and Principles for Solution Builders](https://go.microsoft.com/fwlink/p/?LinkID=533946)  
  
If you’re an ISV creating an app that you will distribute, you’ll need to use solutions. For more information about using solutions, see [Package and distribute extensions using solutions](../developer/package-distribute-extensions-use-solutions.md).  
  

<a name="BKMK_SolutionComponents"></a>   
### Solution components  
 A solution component represents something that you can potentially customize. Anything that can be included in a solution is a solution component. To view the components included in a solution, in solution explorer go to **Settings** > **Solutions** and then open the solution you want. The components are listed in the **Components** list. 

<!-- The following is a list of solution components that you can view in a solution:  
  
- Application Ribbon  

- App 
  
- Article Template  
  
- Business Rule  
  
- Chart  
  
- Connection Role  
  
- Contract Template  
 
- Custom Control
  
- Dashboard  
  
- Email Template  
  
- Entity  
  
- Entity Relationship  
  
- Field  
  
- Field Security Profile  
  
- Form  
  
- Mail Merge Template  
  
- Message  
  
- Option Set  
  
- Plug-in Assembly  
  
- Process  
  
- Sdk Message Processing Step  
  
- Security Role  
  
- Service Endpoint  
  
- Site Map  

- Virtual Entity Data Provider

- Virtual Entity Data Source
  
- Web Resource  -->
  
  Most solution components are nested within other solution components. For example, an entity contains forms, views, charts, fields, entity relationships, messages, and business rules. Each of those solution components requires an entity to exist. A field can’t exist outside of an entity. We say that the field is dependent on the entity. There are actually twice as many types of solution components as shown in the preceding list, but most of them are not visible in the application.  
  
  The purpose of having solution components is to keep track of any limitations on what can be customized using Managed properties and all the solution dependencies so that it can be exported, imported, and (in managed solutions) deleted without leaving anything behind.  
  
<a name="BKMK_ManagedAndUnmanagedSolutions"></a>   
### Managed and unmanaged solutions  
 A **managed** solution can be uninstalled after it is imported. All the components of that solution are deleted by uninstalling the solution.  
  
 When you import an **unmanaged** solution, you add all the components of that solution into your default solution. You can’t delete the components by uninstalling the solution.  
  
 When you import an **unmanaged** solution that contains solution components that you have already customized, your customizations will be overwritten by the customizations in the unmanaged solution. You can’t undo this.  
  
> [!IMPORTANT]
>  Install an unmanaged solution only if you want to add all the components to your default solution and overwrite any existing customizations.  
  
 Even if you don’t plan on distributing your solution, you might want to create and use an unmanaged solution to have a separate view that only includes those parts of the application that you have customized. Whenever you customize something, just add it to the unmanaged solution that you created.  
  
 To create a **managed** solution, you choose the managed solution option when you export the solution. If you create a managed solution, you can’t import it back into the same organization you used to create it. You can only import it into a different organization.  
  
<a name="BKMK_HowSolutionsAreApplied"></a>   
### How solutions are applied  
 All solutions are evaluated as layers to determine what your app will actually do. The following diagram shows how managed and unmanaged solutions are evaluated and how changes in them will appear in your organization.  
  
 ![Solution layering](../customize/media/solution-layering.png "Solution layering")  
  
 Starting from the bottom and working up to top:  
  
 **System Solution**  
 The system solution is like a managed solution that every organization has. The system solution is the definition of all the out-of-the box components in the system.  
  
 **Managed Solutions**  
 Managed solutions can modify the system solution components and add new components. If multiple managed solutions are installed, the first one installed is below the managed solution installed later. This means that the second solution installed can customize the one installed before it. When two managed solutions have conflicting definitions, the general rule is “Last one wins." If you uninstall a managed solution, the managed solution below it takes effect. If you uninstall all managed solution, the default behavior defined within the system solution is applied.  
  
 **Unmanaged Customizations**  
 Unmanaged customizations are any change you have made to your organization through an unmanaged solution. The system solution defines what you can or can't customize by using managed properties. Publishers of managed solutions have the same ability to limit your ability to customize solution components that they add in their solution. You can customize any of the solution components that do not have managed properties that prevent you from customization them.  
  
 **Application Behavior**  
 This is what you actually see in your organization. The default system solution plus any managed solutions, plus any unmanaged customizations you have applied.  
  
<a name="BKMK_ManagedProperties"></a>   
### Managed properties  
 Some components can’t be customized. These components in the system solution have metadata that prevents you from customizing them. These are called **managed properties**. The publisher of a managed solution can also set the managed properties to prevent you from customizing their solution in ways they don’t want you to.  
  
<a name="BKMK_Dependencies"></a>   
### Solution dependencies  
 Because of the way that managed solutions are layered some managed solutions can be dependent on solution components in other managed solutions. Some solution publishers will take advantage of this to build solutions that are modular. You may need to install a “base” managed solution first and then you can install a second managed that will further customize the components in the base managed solution. The second managed solution depends on solution components that are part of the first solution.  
  
 The system tracks these dependencies between solutions. If you try to install a solution that requires a base solution that isn’t installed, you won’t be able to install the solution. You will get a message saying that the solution requires another solution to be installed first. Similarly, because of the dependencies, you can’t uninstall the base solution while a solution that depends on it is still installed. You have to uninstall the dependent solution before you can uninstall the base solution.  
  
### See also  
 [Getting started with customization](../customize/getting-started-customization.md)   
 [Privileges you need for customization](../customize/privileges-required-customization.md)   
 


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]