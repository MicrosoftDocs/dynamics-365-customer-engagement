---
title: "Use solutions for your customizations in Dynamics 365 Customer Engagement | MicrosoftDocs"
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
ms.assetid: f993c4ed-1fc3-4e47-bef1-d38695ddb11a
caps.latest.revision: 57
ms.author: "rdubois"
manager: "brycho"
---
# Use solutions for your customizations
All customizations in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] are done in the context of a solution. If you aren’t sure about what a solution is, please see [What you need to know about solutions](Customization-concepts.md#BKMK_Solutions).  
  
<a name="BKMK_UsingDefaultSolution"></a>   
## The default solution  
 When you customize [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)], you’ll typically work with the default solution. To open the default solution, navigate to **Settings** > **Customizations** and select **Customize the System**.  
  
> [!TIP]
>  After you have the default solution open, use `Ctrl+D` to create a favorite or bookmark in your browser. This will help you open it faster even if you don’t already have the web application open.  
  
 Every organization has a default solution and it has some unique properties. The default solution contains all the solution components available in your organization. Other solutions may include a subset of the solution components visible in the default solution, but the default solution contains all of them.  
  
> [!TIP]
>  Before you start creating new customizations, remember to change the solution publisher customization prefix. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Solution Publisher](Customization%20concepts.md#BKMK_SolutionPublisher).  
  
<a name="BKMK_NavigateToASpecificSolution"></a>   
## Navigate to a specific solution  
 If your organization already has a specific solution you should work in, this is how you can find it. To create a new solution, see [Create your own solution](../customize/use-solutions-for-your-customizations.md#BKMK_CreateSolution).  
  
#### Open an unmanaged solution  
  
1. [!INCLUDE[proc_settings_customization](../includes/proc-settings-customization.md)]  
  
2.  Choose **Solutions**.  
  
3.  Double-click the unmanaged solution that you want to work in to open it.  
  
 When you’re in the solution, you’ll see solution components. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Add Solution Components](../customize/use-solutions-for-your-customizations.md#BKMK_AddSolutionComponents)  
  
<a name="BKMK_UsingSolutionExplorer"></a>   
## Use the solution explorer  
 Within the solution explorer you can navigate through a hierarchy of nodes using the navigation pane on the left side as shown in the following screenshot:  
  
 ![Default solution with entities collapsed in Dynamics 365](../customize/media/crm-itpro-cust-defaultsolutionentitiescollapsed.PNG "Default solution with entities collapsed in Dynamics 365")  
  
> [!NOTE]
>  Use your mouse and keyboard when working with customization tools in the solution explorer. This part of the application isn’t optimized for touch.  
  
 As you select each node, you can see a list of the solution components. The actions available in the command bar will change depending on the context of the node you have selected and if the solution is the default solution or a managed solution. With unmanaged solutions that are not the default solution, you can use the **Add Existing** command to bring in solution components that aren’t already in the solution.  
  
 With managed solutions there will be no commands available and you’ll see the message:  
  
 **You can’t directly edit the components within a managed solution. If the managed properties for solution components are set to allow customizations, you can edit them in the Customizations area or from another unmanaged solution**.  
  
 You’ll need to locate the solution component in the default solution and try to edit it there or add it to another unmanaged solution that you’ve created. The solution component might not be customizable. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Managed Properties](Customization%20concepts.md#BKMK_ManagedProperties)  
  
 Many of the customizations you’ll want to do will involve entities. You can expand the **Entities** node to show a list of all the entities in the system that can be customized in some way. You can further expand each entity to see the solutions components that are part of the entity as shown with the account entity in the following screenshot:  
  
 ![Default Solution showing expanded account entity](../customize/media/crm-itpro-cust-defaultsolution.PNG "Default Solution showing expanded account entity")  
  
 For details about customizing the individual solution components found in the solution explorer, see the following topics:  
  
-   For entity, entity relationships, field and message customizations, see [Metadata](Create%20and%20edit%20metadata.md).  
  
-   For entity forms see [Forms](Create%20and%20design%20forms.md).  
  
-   For processes, see [Processes](Create%20and%20edit%20processes.md).  
  
-   For business rules, see [Business Rules](Create%20and%20edit%20business%20rules.md).  
  
<a name="BKMK_CreateSolution"></a>   
## Create your own solution  
 Because the default solution contains all the solutions components, it may be easier for you to locate just the solution components that you’ve customized if you create a separate solution and do all your customization there. This also makes it easy to export a backup of your solution as a smaller file. If you choose to do this, you must always remember to add any of the solution components you edit to this solution. When you create new solution components, you should always create them in the context of this solution. This way the solution publisher customization prefix will be applied consistently. After you have created solution components in your solution, or added existing solution components to that solution, you can also edit them in the default solution if you wish.  
  
 For more information about creating your own custom solution, see [Introduction to solutions](https://msdn.microsoft.com/en-us/library/gg334576.aspx)  
  
1.  Navigate to **Settings** > **Solutions**.  
  
2.  Choose **New** and complete the required fields for the solution  
  
    |Field|Description|  
    |-----------|-----------------|  
    |**Display Name**|The name shown in the list of solutions. You can change this later.|  
    |**Name**|The unique name of the solution. This is generated using the value you enter in the Display Name field. You can edit this before you save the solution, but after you save the solution, you can’t change it.|  
    |**Publisher**|You can select the default publisher or create a new publisher. Unless you plan to distribute your solution, you should just use the default publisher for your organization.|  
    |**Version**|Enter a number for the version of your solution. This is only important if you export your solution. The version number will be included in the file name when you export the solution.|  
  
3.  Choose **Save**.  
  
 After you save the solution, you may wish to add information to fields that aren’t required. These steps are optional. Use the **Description** field to describe the solution and choose an HTML web resource as a **Configuration Page** for the solution. The configuration page is typically used by ISVs who distribute solutions. When this is set, a new **Configuration** node appears below the **Information** node to display this web resource. Developers will use this page to include instructions or controls to allow you to set configuration data or launch their solution.  
  
<a name="BKMK_AddSolutionComponents"></a>   
### Add solution components  
 After you’ve created your solution, it won’t contain any solution components. You can create new solution components or use the **Add Existing** button in the list menu to add any solution components from the default solution.  
  
 When you do this you may see a **Missing Required Components** dialog.  
  
 ![Add Required Components Dialog](../customize/media/crm-itpro-cust-addrequiredcomponents.PNG "Add Required Components Dialog")  
  
 This dialog alerts you that the solution component has dependencies on other solution components. If you select **No, do not include required components**, the solution may fail if you import it into another organization where all those required components do not exist. If the solution import succeeds, the behavior in the other solution may not be identical as the original organization because the components are configured differently than those in the source solution.  
  
 Generally, it’s safer to include the required components if you intend to export the solution into another organization. If you don’t add these components when you add an individual solution component, you can come back later, select the solution component you added, and choose **Add Required Components** from the menu.  
  
 If you don’t intend to export the solution, or if you only intend to export it as an unmanaged solution and import it back into the same organization, it isn’t necessary to include required components. If you ever export the solution you’ll see another warning indicating that some required components are missing. If you are only going to import this solution back into the same organization, it is OK to disregard this warning. The steps to edit application navigation or the ribbon without using a third-party editing tool expect that you’ll export the solution back into the same organization.  
  
<a name="BKMK_ImportUpgradExportSolutions"></a>   
## Import, update, and export solutions  
 How often you import, update, or export solutions may depend on the size of your organization, your internal development practices, and whether you are developing a solution that is to be distributed as a managed solution.  
  
-   If you have a small organization with few customizations, and you’re the only customizer, you may never export or import solutions except to periodically export the default solution to create a backup or if you choose to use or buy a managed solution provided by someone else.  
  
-   Some organizations will have an outside company create customizations for them. In this case, they’ll export any customizations that they currently have and send them to the outside company. That company will develop and test customizations and send them back to the organization to be imported.  
  
-   Large organizations may have several teams of people customizing the system. They may have a separate organization just for development and customizations. These organizations frequently also have a separate test organizations and a UAT (User Acceptance Testing) organizations in addition to a production organization which everyone in the organization actually uses. These organizations depend on exporting and importing customizations from one organization to the next in the process of creating, testing, and verifying the solutions.  
  
 The strategy you choose should depend on your needs. Some important things to keep in mind:  
  
-   You can’t export your default solution as a managed solution.  
  
-   You can import your default solution only to the organization from which you exported it.  
  
-   We don’t support importing a default solution taken from an on-premise deployment into a [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] organization or a default solution taken from a [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] organization into an on-premises deployment. We do support importing custom solutions between these deployment types, but not default solutions.  
  
-   When you export a managed solution, you can’t import it back into the organization it was exported from.  
  
-   Only export a solution as a managed solution when you intend to distribute it.  
  
-   Never import an unmanaged solution unless you are sure you want to accept all the customizations in it and allow any of those customizations to overwrite any customizations you previously created.  
  
-   Solutions can’t delete anything. Importing an unmanaged solution might overwrite existing customizations, but it can’t entirely remove them. For example, if you create a custom field for an entity, and then import a solution containing the definition of that entity that doesn’t have the custom field, the custom field you created will still be there. Also, any changes defined within the solution you imported will be there.  
  
-   You can’t import a custom entity with the same name as an existing entity. [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] allows duplicate display names, though.  
  
-   You can import only items that you have organization-level access to create, read, and update.  
  
-   You must have the System Administrator security role to import security roles, organization settings, sdk message processing steps, and plug-in assemblies.  
  
-   If you import customizations that include a language that is not installed on your system, any labels defined in the customizations will default to the base language of the Microsoft Dynamics 365 system the customizations were imported from.  
  
-   All imported security roles will be attached to the root business unit.  
  
-   If an imported security role originated from the same [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] system, any changes applied to the security role will be merged. All privileges on system entities for the security role will be replaced by privileges defined by the security role that is being imported.  
  
<a name="BKMK_ImportSolutions"></a>   
### Import solutions  
 You can import solutions manually using the steps below. Only import solutions that you've obtained from a trusted source. Customizations might include code that can send data to external sources. You can import the default solution only to the organization from which you exported it, but not into a different organization.  
  
1. [!INCLUDE[proc_settings_solutions](../includes/proc-settings-solutions.md)]  
  
2.  In the solutions list menu, choose **Import**.  
  
3.  In the **Import Solution** dialog, **Select Solution Package** step browse to the compressed (.zip or .cab) file that contains the solution you want to import.  
  
4.  Choose **Next**.  
  
5.  You can view information about the solution before you choose **Import**.  
  
6.  You may need to wait a few moments while the solution import completes. If it is successful, you can view the results and choose **Close**.  
  
 If you have imported any changes that require publishing, you must publish customizations before they will be available. See [Publishing Customizations](Customization%20concepts.md#BKMK_PublishingCustomizations) for more information.  
  
 If the import isn’t successful, you will see a report showing any errors or warnings that were captured. You can choose **Download Log File** to capture details about what caused the import to fail. The most common cause for a solution import to fail is that the solution did not contain some required solution components.  
  
 When you download the log file, you will find an XML file that you can open using [!INCLUDE[pn_MS_Excel_Full](../includes/pn-ms-excel-full.md)] and view the contents.  
  
> [!NOTE]
>  You can’t edit an active routing rule set. Therefore, if you’re importing a solution that includes an active routing rule set into an organization where the rule already exists with the same ID, the solution import will fail. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create rules to automatically route cases](http://go.microsoft.com/fwlink/p/?LinkID=391680)  
  
<a name="BKMK_UpdateSolutions"></a>   
### Update solutions  
 There are times when you may wish to install an update to an existing managed solution. The procedure is similar to installing a new managed solution, except you will get some different options. If you are updating a solution you got from someone else, you should get guidance from the solution publisher about which options you should choose.  
  
1. [!INCLUDE[proc_settings_solutions](../includes/proc-settings-solutions.md)]  
  
2.  In the solutions list menu choose **Import**.  
  
3.  In the **Import Solution** dialog, **Select Solution Package** step browse to the compressed (.zip or .cab) file that contains the solution you want to update.  
  
4.  Choose **Next**.  
  
5.  You can view information about the solution before you choose **Next**. This page will display a yellow bar saying **This solution package contains an update for a solution that is already installed**.  
  
6.  You will have the following options:  
  
    - **Maintain customizations (recommended)**  
  
         Selecting this option will maintain any unmanaged customizations performed on components but also implies that some of the updates included in this solution will not take effect.  
  
    - **Overwrite Customizations**  
  
         Selecting this option overwrites any unmanaged customizations previously performed on components included in this solution. All updates included in this solution will take effect.  
  
     Choose the appropriate option and then choose **Next**.  
  
7.  You may need to wait a few moments while the solution import completes. If it is successful, you can view the results and choose **Close**.  
  
 If you have imported any changes that require publishing, you must publish customizations before they will be available. See [Publishing Customizations](Customization%20concepts.md#BKMK_PublishingCustomizations) for more information.  
  
 Solution publishers may ask you to export your existing unmanaged customizations, update their managed solution using the option to overwrite customizations, and then re-import your unmanaged customizations. This will help ensure that the changes they are expecting are applied while preserving your customizations.  
  
<a name="BKMK_ExportSolutions"></a>   
### Export solutions  
 We recommend that you export your unmanaged customizations periodically so that you have a backup in case anything happens. You cannot export managed solutions.  
  
1. [!INCLUDE[proc_settings_solutions](../includes/proc-settings-solutions.md)]  
  
2.  In the list select the solution you want to export and choose **Export**.  
  
3.  In the **Publish Customizations** step you will be reminded that only published customizations are exported and you will have the option to **Publish All Customizations** before you choose **Next**.  
  
4.  If your solution contains any missing required components you will see the **Missing Required Components** step. You can disregard this warning only if you intend to import this as an unmanaged solution back into the original organization. Otherwise, follow the instructions in the dialog to cancel the export and add the required components.  
  
5.  In the **Export System Settings (Advanced)** step you can choose certain system settings to include in your solution. If your solution depends on any of the groups of system settings, select them and choose **Next**.  
  
     See [Settings options for solution export](../customize/use-solutions-for-your-customizations.md#BKMK_SettingsOptionsOnSolutionExport) for details about the settings that will be included with each option.  
  
6.  In the **Package Type** step, you must choose whether to export the solution as an **Unmanaged** or **Managed** solution.  
  
7.  The next step allows you to choose a target solution for a specific Dynamics 365 version. This option is typically used by ISVs who may want to export a solution that is compliant with a previous version. Unless you intend to import this solution into an organization that is not upgraded to the same version as the organization version you are using, accept the default.  
  
     For more information, see the SDK topic [Export a solution for a specific Dynamics 365 version](https://msdn.microsoft.com/library/dn689055.aspx).  
  
8.  Choose **Export** to download the solution file.  
  
 The exact behavior for downloading files varies between browsers.  
  
> [!NOTE]
>  You can "Export As" solutions from [!INCLUDE[pn_crm_8_2_0_online](../includes/pn-crm-8-2-0-online.md)] into [!INCLUDE[pn_crm_8_1_0_online](../includes/pn-crm-8-1-0-online.md)] and from [!INCLUDE[pn_crm_8_2_0_op](../includes/pn-crm-8-2-0-op.md)] into [!INCLUDE[pn_crm_8_1_0_op](../includes/pn-crm-8-1-0-op.md)].  
  
<a name="BKMK_SettingsOptionsOnSolutionExport"></a>   
## Settings options for solution export  
 The following table shows the options available when you export a solution:  
  
|Group|Setting|Description|  
|-----------|-------------|-----------------|  
|Auto-numbering|Campaign Prefix|Prefix used for campaign numbering.|  
|Case Prefix|Prefix to use for all cases throughout [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].|  
|Contract Prefix|Prefix to use for all contracts throughout [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)].|  
|Invoice Prefix|Prefix to use for all invoice numbers throughout [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)].|  
|Article Prefix|Prefix to use for all articles in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)].|  
|Order Prefix|Prefix to use for all orders throughout [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)].|  
|Unique String Length|Number of characters appended to invoice, quote, and order numbers.|  
|Calendar|Calendar Type|Calendar type for the system. Set to Gregorian US by default|  
|Date Format Code|Information about how the date is displayed throughout Microsoft Dynamics 365.|  
|Date Separator|Character used to separate the month, the day, and the year in dates throughout [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)].|  
|Max Appointment Duration|Maximum number of days an appointment can last.|  
|Show Week Number|Information that specifies whether to display the week number in calendar displays throughout [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)].|  
|Time Format Code|Information that specifies how the time is displayed throughout [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)].|  
|Week Start Day Code|Designated first day of the week throughout [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)].|  
|Customization|Is Application Mode Enabled|Indicates whether loading of [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] in a browser window that does not have address, tool, and menu bars is enabled.|  
|Email-tracking|Allow Unresolved Address Email Send|Indicates whether users are allowed to send email to unresolved parties (parties must still have an email address).|  
|Ignore Internal Email|Indicates whether incoming email sent by internal [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] users or queues should be tracked.|  
|Max Tracking Number|Maximum tracking number before recycling takes place.|  
|Render Secure Frame For Email|Flag to render the body of email in the webform in an IFRAME with the security='restricted' attribute set. This is additional security but can cause a credentials prompt.|  
|Tracking Prefix|History list of tracking token prefixes.|  
|Tracking Token Base|Base number used to provide separate tracking token identifiers to users belonging to different deployments.|  
|Tracking Token Digits|Number of digits used to represent a tracking token identifier.|  
|General|Block Attachments|Prevent upload or download of certain attachment types that are considered dangerous.|  
|Currency Format Code|Information about how currency symbols are placed throughout [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)].|  
|Currency Symbol|Currency Symbol|  
|Full Name Display Order|Order in which names are to be displayed throughout [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)].|  
|||  
|Presence Enabled|Information on whether IM presence is enabled.|  
|Negative Format|Information that specifies how negative numbers are displayed throughout [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)].|  
|Number Format|Specification of how numbers are displayed throughout [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)].|  
|Pricing Decimal Precision|Number of decimal places that can be used for prices.|  
|Share To Previous Owner On Assign|Information that specifies whether to share to previous owner on assign.|  
|Marketing|Allow Automatic Response Creation|Indicates whether automatic response creation is allowed|  
|Allow Automatic Unsubscribe|Indicates whether automatic unsubscribe is allowed.|  
|Allow Automatic Unsubscribe Acknowledgement|Indicates whether automatic unsubscribe acknowledgement email is allowed to send.|  
|Allow Marketing Email Execution|Indicates whether marketing emails execution is allowed.|  
|[!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)] Synchronization|Allow Address Book Synchronization|Indicates whether background address book synchronization in Microsoft Office Outlook is allowed.|  
|Allow Offline Scheduled Synchronization|Indicates whether background offline synchronization in [!INCLUDE[pn_MS_Outlook_Full](../includes/pn-ms-outlook-full.md)] is allowed.|  
|Allow Scheduled Synchronization|Indicates whether scheduled synchronizations to [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)] are allowed.|  
|Email Send Polling Frequency|Normal polling frequency used for sending email in [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)].|  
|Min Address Synchronization Frequency|Normal polling frequency used for address book synchronization in [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)].|  
|Min Offline Synchronization Frequency|Normal polling frequency used for background offline synchronization in [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)].|  
|Min Synchronization Frequency|Minimum allowed time between scheduled [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)] synchronizations.|  
|Auto-Tag Max Cycles|Maximum number of aggressive polling cycles executed for email auto-tagging when a new email is received.|  
|Auto-Tag Interval|Normal polling frequency used for email auto-tagging in [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)].|  
||||  
|ISV Config|Service Calendar Appearance Configuration|You can define visual styles for service calendars. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)][MSDN: Service Calendar Appearance Configuration](https://msdn.microsoft.com/library/gg309501.aspx)|  
  
<a name="BKMK_PrivacyNotice"></a>   
## Privacy notices  
 [!INCLUDE[cc_privacy_crm_gcc_solution_import](../includes/cc-privacy-crm-gcc-solution-import.md)]  
  
 [!INCLUDE[cc_privacy_crm_customizations](../includes/cc-privacy-crm-customizations.md)]  
  
## See Also  
 [Getting started with customization](Getting-started-customization.md)   
 [Use segmented solutions and patches to simplify solution updates](Use-segmented-solutions-patches-simplify-solution-updates.md)   
 [Privileges required for customization](Privileges-required-customization.md)   
 [Customization concepts](Customization-concepts.md)     
 [Whitepaper: Patterns and Principles for Solution Builders](http://go.microsoft.com/fwlink/p/?LinkID=533946)
