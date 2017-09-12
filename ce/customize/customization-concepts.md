---
title: "Customization concepts in Dynamics 365 Customer Engagement | MicrosoftDocs"
ms.custom: ""
ms.date: "2017-08-31"
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: ece68f5f-ad40-4bfa-975a-3e5bafb854aa
caps.latest.revision: 55
ms.author: "rdubois"
manager: "brycho"
---
# Customization concepts: metadata, solutions, and more
The way your organization works is unique. Some organizations have well-defined business processes that they apply using [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. Others aren’t happy with their current business processes and use [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] to apply new data and processes to their business. Whatever situation you find yourself in, you’ll find a lot of customization capabilities in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] so that it can work for your organization.  
  
 Of course you’re eager to get started, but please take a few minutes to read the content in this section. This will introduce you to important terms, give you some background about why things are done a certain way, and help you avoid potential problems in the future.  
  
<a name="BKMK_Metadata"></a>   
## What is metadata and why should you care?  
 In the past, you may have customized business applications by editing the source code. This created complications because each organization had unique changes and it was very difficult, or extremely expensive, to upgrade. Then application developers started exposing application programming interfaces (APIs) so that other developers could interact with the application and add their own logic without touching the source code. This was moderately better because it means developers can extend the application without changing it. But it still requires a developer to write code.  
  
 Today, modern business applications use a metadata-driven architecture so that people can customize the application without writing code. Metadata means “data about data” and it defines the structure of the data stored in the system. With this metadata, an application knows about any changes to the data structure and this enables the application to adapt as the data structure changes. Since the metadata is known, additional capabilities can be included that are tied to the metadata.  
  
 When you customize [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] using the customization tools in the application, you’re adding or updating the metadata or data used by features that depend on the metadata. Because we know the kinds of data used to customize the system, we can take this data into account and add new features to [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] without breaking your system. This way you should always be able to apply an update rollup or upgrade to the latest version and enjoy the best new features.  
  
> **Customize or Configure?**   
> Most people say they want to customize the application, so we use the word “customize” to describe changing the system to make it work the way you want. Some people prefer to use the word “configure” because it suggests that no code was required to make changes. Call it whatever you like, we just want to make it clear that you don’t need to be a developer to customize [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].  
  
 [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] provides a set of web services and APIs that allow developers to write code. When code is written using supported methods you can expect that it will continue to work when you upgrade your organization.  
  
<a name="BKMK_SupportedCust"></a>   
## What kinds of customizations are supported?  
 We expect that you can do most of your customization with the tools in the application. Everything you do by using those tools is supported by [!INCLUDE[cc_Microsoft](../includes/cc-microsoft.md)] because they apply changes to the metadata or data that depends on the metadata.  
  
 If the customization tools don’t meet your needs, you can install a solution provided by a third party or hire a developer to code your customizations. Either way, it’s good for you to understand supported customizations. If you need to invest in a solution that requires code, you should make sure that the code is written using only supported APIs. This helps you protect your investment in both [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] and any solutions you get.  
  
 Developers who extend [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] have a responsibility to follow rules and best practices documented in the SDK: [Best practices for developing with Dynamics 365](https://msdn.microsoft.com/library/gg509027.aspx). The SDK documents the APIs available to developers and provides guidance about how to best use them. [!INCLUDE[cc_Microsoft](../includes/cc-microsoft.md)] supports only the APIs and practices that are documented in the SDK. You may find something on the Internet that describes how you can solve a problem, but if it doesn’t leverage APIs documented in the SDK, it isn’t supported by [!INCLUDE[cc_Microsoft](../includes/cc-microsoft.md)]. Before you have a developer apply a change you should verify whether it uses supported methods.  
  
 If developers use the APIs and best practices described in the SDK we can be sure to test whether any of the changes we make to [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] has the potential to break existing customizations. Our goal is that code customizations written using supported methods will continue to work when new versions or updates of [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] are released. You benefit because you can upgrade to new versions with improved features without having developers change their code each time.  
  
 If we detect that a change in a new version of [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] will cause a supported customization to break, we will document what is affected and how people can change their code to fix it.  
  
<a name="BKMK_Unsupported"></a>   
## What kinds of customizations aren’t supported?  
 Just because certain APIs and programming practices aren’t supported by [!INCLUDE[cc_Microsoft](../includes/cc-microsoft.md)] doesn’t mean that they don’t work. “Unsupported by [!INCLUDE[cc_Microsoft](../includes/cc-microsoft.md)]” means exactly what it says: you can’t get support about these APIs or programming practices from [!INCLUDE[cc_Microsoft](../includes/cc-microsoft.md)]. We don’t test them and we don’t know if something we change will break them. We can’t predict what will happen if someone changes code in our application.  
  
 The developer who uses unsupported APIs and programming practices assumes the responsibility to support their code. They will need to test their code to make sure it works.  
  
 If you choose to use unsupported customizations in your [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] deployment you should be sure to document what was done and have a strategy to remove those customizations before you contact [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] Technical Support. If you need help with unsupported customizations, contact the developer or organization who prepared the customizations.  
  
<a name="BKMK_CommonUnsupportedCustomizations"></a>   
### Common unsupported customization practices  
 The following is a list of common customization practices that aren’t supported. This is not a complete list. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Supported extensions for Microsoft Dynamics 365: Unsupported customizations](https://msdn.microsoft.com/library/gg328350.aspx#Unsupported)  
  
 **Interacting with the web application Document Object Model (DOM) elements using JavaScript**  
 Any [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] libraries used anywhere in the application must only interact with the documented APIs. When [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] developers work with applications they frequently access DOM elements using specific names. Because [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] is a web application these techniques work, but they are likely to break during an update because the names of the elements they reference are subject to change at any time. We reserve the right to make any changes necessary in the application and this frequently means changing how the page is constructed. Adding any changes that depend on the current structure of the page means that you’ll need to invest in testing and perhaps changing the custom code in these scripts each time you apply an update to your application.  
  
 jQuery is a very common library used by [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] developers. Most of the benefit of using jQuery is that it simplifies a developer’s ability to access and create DOM elements, which is exactly what we do not support in the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] application pages. jQuery is recommended when developers are creating custom user interfaces with HTML web resources, but within the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]application pages, the supported APIs do not require jQuery to be used.  
  
 **Using any undocumented internal objects or methods using JavaScript**  
 [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] uses many [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] objects within pages. A [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] developer can discover these objects by debugging a page and then access and reuse these objects. We reserve the right to make any changes necessary to these objects, including removing them or changing the names of the methods. If a script references these objects, the script will break if they are not found.  
  
<a name="BKMK_Solutions"></a>   
## What you need to know about solutions  
 Solutions exist so that a set of customizations can be purchased, shared or otherwise transported from one organization to another. You can get solutions from [AppSource](https://appsource.microsoft.com/) or from an independent software vendor (ISV). A [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] solution is a file that you can import to apply a set of customizations.  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Whitepaper: Patterns and Principles for Solution Builders](http://go.microsoft.com/fwlink/p/?LinkID=533946)  
  
> [!NOTE]
>  If you’re an ISV creating a customization that you will distribute, you’ll need to use solutions. For more information about using solutions, see [Package and distribute sxtensions](https://msdn.microsoft.com/library/gg334530.aspx).  
  
 If you are just interested in customizing your organization, here is what you need to know about solutions:  
  
-   Creating solutions is optional. You can customize your [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] system directly without ever creating a solution.  
  
-   When you customize the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] system directly, you work with a special solution called the **Default Solution**. This solution contains all the components in your system.  
  
-   You can export your Default Solution to create a backup of the customizations you have defined in your organization. This is good to have in a worst case scenario.  
  
<a name="BKMK_SolutionComponents"></a>   
### Solution components  
 A solution component represents something that you can potentially customize. Anything that can be included in a solution is a solution component. The following is a list of solution components that you can view in a solution:  
  
-   Application Ribbon  
  
-   Article Template  
  
-   Business Rule  
  
-   Chart  
  
-   Connection Role  
  
-   Contract Template  
  
-   Dashboard  
  
-   Email Template  
  
-   Entity  
  
-   Entity Relationship  
  
-   Field  
  
-   Field Security Profile  
  
-   Form  
  
-   Mail Merge Template  
  
-   Message  
  
-   Option Set  
  
-   Plug-in Assembly  
  
-   Process  
  
-   Sdk Message Processing Step  
  
-   Security Role  
  
-   Service Endpoint  
  
-   Site Map  
  
-   Web Resource  
  
 Most solution components are nested within other solution components. For example, an entity contains forms, views, charts, fields, entity relationships, messages, and business rules. Each of those solution components requires an entity to exist. A field can’t exist outside of an entity. We say that the field is dependent on the entity. There are actually twice as many types of solution components as shown in the preceding list, but most of them are not visible in the application.  
  
 The purpose of having solution components is to keep track of any limitations on what can be customized using [Managed properties](../customize/customization-concepts.md#BKMK_ManagedProperties) and all the [Solution dependencies](../customize/customization-concepts.md#BKMK_Dependencies) so that it can be exported, imported, and (in managed solutions) deleted without leaving anything behind.  
  
<a name="BKMK_ManagedAndUnmanagedSolutions"></a>   
### Managed and unmanaged solutions  
 A **managed** solution can be uninstalled after it is imported. All the components of that solution are removed by uninstalling the solution.  
  
 When you import an **unmanaged** solution, you add all the components of that solution into your default solution. You can’t remove the components by uninstalling the solution.  
  
 When you import an **unmanaged** solution that contains solution components that you have already customized, your customizations will be overwritten by the customizations in the unmanaged solution. You can’t undo this.  
  
> [!IMPORTANT]
>  Install an unmanaged solution only if you want to add all the components to your default solution and overwrite any existing customizations.  
  
 Even if you don’t plan on distributing your solution, you might want to create and use an unmanaged solution to have a separate view that only includes those parts of the application that you have customized. Whenever you customize something, just add it to the unmanaged solution that you created.  
  
 You can only export your Default Solution as an unmanaged solution.  
  
 To create a **managed** solution, you choose the managed solution option when you export the solution. If you create a managed solution, you can’t import it back into the same organization you used to create it. You can only import it into a different organization.  
  
<a name="BKMK_HowSolutionsAreApplied"></a>   
### How solutions are applied  
 All solutions are evaluated as layers to determine what your [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] application will actually do. The following diagram shows how managed and unmanaged solutions are evaluated and how changes in them will appear in your organization.  
  
 ![Solution layering](../customize/media/solution-layering.png "Solution layering")  
  
 Starting from the bottom and working up to top:  
  
 **System Solution**  
 The system solution is like a managed solution that every organization has. The system solution is the definition of all the out-of-the box components in the system.  
  
 **Managed Solutions**  
 Managed solutions can modify the system solution components and add new components. If multiple managed solutions are installed, the first one installed is below the managed solution installed later. This means that the second solution installed can customize the one installed before it. When two managed solutions have conflicting definitions, the general rule is “Last one wins”. If you uninstall a managed solution, the managed solution below it takes effect. If you uninstall all managed solution, the default behavior defined within the system solution is applied.  
  
 **Unmanaged Customizations**  
 Unmanaged customizations are any change you have made to your organization through an unmanaged solution. The system solution defines what you can or cannot customize by using [Managed properties](../customize/customization-concepts.md#BKMK_ManagedProperties). Publishers of managed solutions have the same ability to limit your ability to customize solution components that they add in their solution. You can customize any of the solution components that do not have managed properties that prevent you from customization them.  
  
 **Application Behavior**  
 This is what you actually see in your organization. The default system solution plus any managed solutions, plus any unmanaged customizations you have applied.  
  
<a name="BKMK_ManagedProperties"></a>   
### Managed properties  
 Some parts of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] can’t be customized. These items in the system solution have metadata that prevents you from customizing them. These are called **managed properties**. The publisher of a managed solution can also set the managed properties to prevent you from customizing their solution in ways they don’t want you to.  
  
<a name="BKMK_Dependencies"></a>   
### Solution dependencies  
 Because of the way that managed solutions are layered some managed solutions can be dependent on solution components in other managed solutions. Some solution publishers will take advantage of this to build solutions that modular. You may need to install a “base” managed solution first and then you can install a second managed that will further customize the components in the base managed solution. The second managed solution depends on solution components that are part of the first solution.  
  
 [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] tracks these dependencies between solutions. If you try to install a solution that requires a base solution that isn’t installed, you won’t be able to install the solution. You will get a message saying that the solution requires another solution to be installed first. Similarly, because of the dependencies, you can’t uninstall the base solution while a solution that depends on it is still installed. You have to uninstall the dependent solution before you can uninstall the base solution.  
  
<a name="BKMK_SolutionPublisher"></a>   
### Solution publisher  
 Every solution has a publisher. The default solution has a publisher named “Default Publisher for \<your organization name>”.  
  
 The publisher record contains a **Prefix** value. The default value of this prefix is “new”. When you create new solution components, this prefix will be appended to the name. This is a quick way that allows people to understand what solution the components are part of.  
  
 Before you start customizing the system we recommend that you change the prefix value for the default publisher to something that identifies your company.  
  
##### To change the Solution Publisher Prefix for the default publisher  
  
1. [!INCLUDE[proc_settings_customization](../includes/proc-settings-customization.md)]  
  
2.  Select **Publishers**.  
  
3.  If there is more than one publisher, open the one with the **Display Name** that starts with **Default Publisher for** *\<your organization name>*.  
  
4.  At the bottom of the form, update the **Prefix** field to change the default value of “new” to something that identifies your organization.  
  
5.  When you change the value, make sure to tab to the next field. The **Option Value Prefix** will automatically generate a number based on the customization prefix. This number is used when you add options to option sets and provides an indicator of which solution was used to add the option.  
  
<a name="BKMK_PublishingCustomizations"></a>   
## Publishing customizations  
 Certain customizations that make changes to the user interface require that they be published before people can use them in the application. Publishing provides a way for you to save your work before you have finished and then come back and finish at a later time. Publishing is only required when you change a solution component. When you create or delete a solution component, publishing occurs automatically. Before you export a solution, you’ll be prompted to publish customizations. This is because any unpublished customizations won’t be included in the solution.  
  
 When you perform customizations that will appear in [!INCLUDE[pn_moca_full](../includes/pn-moca-full.md)] you should always explicitly publish your customizations to make sure that every item is synchronized with the [!INCLUDE[pn_moca_short](../includes/pn-moca-short.md)] application.  
  
> [!NOTE]
>  Publishing customizations can interfere with normal system operation. In a production environment we recommend that you schedule publishing customizations when it’s least disruptive to users.  
  
 The following solution components require publishing when they are updated:  
  
-   Application Ribbon  
  
-   Entity  
  
-   Entity Relationship  
  
-   Field  
  
-   Form  
  
-   Message  
  
-   Option Set  
  
-   Site Map  
  
-   Web Resource  
  
> [!NOTE]
>  When using [!INCLUDE[pn_crm_app_for_outlook_short](../includes/pn-crm-app-for-outlook-short.md)] it can take at least an hour for customization changes to take effect. You can make the changes appear immediately in [!INCLUDE[pn_Internet_Explorer](../includes/pn-internet-explorer.md)] by clearing the cache. To do this, go to **Tools** > **Internet Options** and under **Browsing history** select the **Delete** button. Uncheck all browsing history items except “Temporary Internet files and website files” and “Cookies and website data” and then select **Delete**.  
  
<a name="BKMK_PrepareClientCustomizations"></a>   
## Prepare client customizations to improve performance for mobile and interactive service hub  
 Once you publish customizations, the first user to start one of the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] mobile apps or the interactive service hub can experience performance issues, because their sign in prompts [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] to prepare the metadata package for download. That means the first user has to wait for both the metadata package preparation and the download (subsequent users only have to wait for the download).  
  
 You can improve performance for that first user by clicking the **Prepare Client Customizations** button after publishing your customizations. This prompts [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] to prepare the metadata package right then instead of waiting for the first user to start a mobile app or the interactive service hub.  
  
 ![Prepare Client Customizations button](../customize/media/prepare-client-customizations-button.png "Prepare Client Customizations button")  
  
 The metadata package that's generated after you make customizations contains only the items that have changed, instead of the complete set of metadata. Also, instead of starting over if there's a problem downloading the metadata package to a mobile device, the download starts from where it left off the next time a user starts the app.  
  
<a name="BKMK_changesinperformance"></a>   
## Changes that affect Dynamics 365 organization performance  
 Importing solutions and applying customizations that change metadata can affect [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] organization performance. Actions that can interfere with normal system operation include:  
  
-   Add, remove, or change entities, alternate keys, attributes, or relationships.  
  
     More information: [Create and edit entities](../customize/create-edit-entities.md); [Define alternate keys for an entity](../developer/define-alternate-keys-for-an-entity.md); [Edit an organization's attributes](Edit%20an%20organization's%20attributes.md); [Create and edit entity relationships](../customize/create-edit-entity-relationships.md)  
  
-   [Import solutions](../customize/use-solutions-for-your-customizations.md#BKMK_ImportSolutions)  
  
-   [Publish customizations](../customize/customization-concepts.md#BKMK_PublishingCustomizations)  
  
If you’re applying these changes to a production system, we recommend that you schedule these operations when it is least disruptive to users.  
  
<a name="BKMK_CombineCustomizations"></a>   
## Combine customization capabilities  
 Each of the topics in the “Customize your Dynamics 365 system” section describe individual customization capabilities in considerable depth. But it’s important to keep in mind that the solutions to meeting your business requirements will frequently use one of the capabilities together with one or more other capabilities.  
  
<a name="BKMK_ChooseTheRightCustomization"></a>   
### Choose the right customization capability for the job  
 The law of instrument states “If all you have is a hammer, everything looks like a nail.” With all the different customization capabilities available in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] it’s easy to become familiar with one of them and seek to use it to solve every problem. As you evaluate the business problems you want to solve, think about the end result you want to achieve and then work backwards to how you can get there.  
  
<a name="BKMK_AdditionalCapabilities"></a>   
## Additional capabilities not included in this guide  
 In addition to the capabilities described in “Customize your Dynamics 365 system,” you should be familiar with additional capabilities not described in detail here. This section introduces some of the capabilities and include links to other resources where you can find more information.  
  
<a name="BKMK_DocumentManagement"></a>   
### Document management  
 Document management allows for integration between [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] and [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)]. For information about how to enable and configure document management, see [Document management](../admin/manage-documents-using-sharepoint.md) or [Manage SharePoint documents from within Dynamics 365](http://go.microsoft.com/fwlink/p/?LinkId=513226). Developers should look at the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] SDK topic: [Integrate SharePoint with Dynamics 365](https://msdn.microsoft.com/library/gg334768.aspx).  
  
<a name="BKMK_FieldSecurityProfiles"></a>   
### Field security profiles  
 You can set an extra level of security for a custom field you have added to a form by using field security profiles. To enable field-level security, you must set the **Field Security** property for the custom field and then specify the permissions you will allow for this field to any field security profiles you have created. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create a field security profile](http://go.microsoft.com/fwlink/p/?LinkId=320542) and [Add teams or users to a field security profile](../admin/add-teams-users-field-security-profile.md).  
  
<a name="BKMK_Localization"></a>   
### Localization  
 If your organization has people who use a language other than the base language you chose when you deployed [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)], you can add more languages.  
  
 For [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)], you’ll find all the languages are already installed; you just need to enable them.  
  
> [!NOTE]
>  Enabling a language can take several minutes. During this time, people might not be able to use [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].  
  
#### Enable additional languages  
  
1. [!INCLUDE[proc_settings_administration](../includes/proc-settings-administration.md)]  
  
2.  Choose **Languages**.  
  
3.  In the **Language Settings** dialog box, choose any available languages and choose **Apply** to enable them.  
  
 While you can enable additional languages, the localized text is only available for text that’s included in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] before it is customized. You can only customize [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] using the base language. Users of other languages will see the text in the base language unless you export translations and add localized text for any user interface items that you have added or changed. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Export customized entity and field text for translation](http://go.microsoft.com/fwlink/p/?LinkId=320545)  
  
> [!NOTE]
>  Because customization is supported only in the base language, as the System Customizer you may be working with the base language set as your language preference. To verify that the translated text is appearing, you must change your language preference for the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] user interface. To perform additional customization work, you must change back to the base language.  
  
<a name="BKMK_SecurityRoles"></a>   
### Security roles  
 A discussion of implementing security for your organization is beyond the scope of this guide. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Control data access](../admin/security-roles-privileges.md)  
  
### See also  
 [Getting started with customization](../customize/getting-started-customization.md)   
 [Privileges you need for customization](../customize/privileges-required-customization.md)   
 [Using solutions](../customize/use-solutions-for-your-customizations.md)
