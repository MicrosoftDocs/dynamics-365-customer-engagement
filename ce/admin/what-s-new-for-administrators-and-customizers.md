---
title: "What's new for administrators and customizers in Dynamics 365 Customer Engagement | MicrosoftDocs"
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
ms.assetid: 4a79d1b6-0745-4858-9cca-17ec161d60d7
caps.latest.revision: 392
author: "brycho"
ms.author: "brycho"
manager: "brycho"
---
# What's new for administrators and customizers
> [!IMPORTANT]
>  This page describes new features for [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] as of March 2017 and earlier. To learn about the latest features in the July 2017 update, go to [our new site on docs.microsoft.com](https://go.microsoft.com/fwlink/p/?linkid=851285).  
  
## What's new in March for Dynamics 365 (online)  
  
-   [Introducing Live Assist for Dynamics 365 Powered by Café X](#liveassist)  
  
-   [Resynchronize records that failed to synchronize](#resyncrecords)  
  
-   [pn_microsoftcrm connectors for Logic Apps, Flow, and PowerApps](#connectors)  
  
<a name="liveassist"></a>   
### Public Preview: Introducing Live Assist for Dynamics 365 Powered by CaféX  
 The capability for your customers to connect with your agents is a fundamental feature when you deliver leading service and support. Agents can conduct multiple, live chat sessions within [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] or [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] by using [!INCLUDE[Live_Assist_for_Dynamics_365](../includes/live-assist-for-dynamics-365.md)], which can be installed from the [!INCLUDE[pn_dyn_365_admin_center](../includes/pn-dyn-365-admin-center.md)]. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Install or remove a preferred solution](../admin/install-remove-preferred-solution.md)  
  
 [!INCLUDE[Live_Assist_for_Dynamics_365](../includes/live-assist-for-dynamics-365.md)] is developed by [!INCLUDE[pn-cafex.md](../includes/pn-cafex.md)] as a third-party solution. Administrators configure [!INCLUDE[Live_Assist_for_Dynamics_365](../includes/live-assist-for-dynamics-365.md)] from within [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] or [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] to provide a rich immersive experience for agents that includes presence control, chat indicators, and visual engagement with customers through co-browsing.  
  
> [!IMPORTANT]
>  -   This feature is currently available in North America (NAM), Canada (CAN), and Europe, Middle East, Africa (EMEA) regions.  
> - [!INCLUDE[cc_preview_features_send_us_feedback](../includes/cc-preview-features-send-us-feedback.md)] [Microsoft Connect](https://connect.microsoft.com/site687)  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Live Assist for Dynamics 365 Powered by CaféX](https://support.liveassistfor365.com/hc/en-us/articles/213670809-Caf%C3%A9X-Live-Assist-for-Microsoft-Dynamics-365)  
  
<a name="resyncrecords"></a>   
### Data Export Service: Resynchronize records that failed to synchronize  
 With this new preview feature for [!INCLUDE[cc_Data_Export_Service](../includes/cc-data-export-service.md)], you can recover from synchronization failures with on-demand resynchronization from the Export Profile toolbar.  
  
 ![Data Export Service toolbar](../admin/media/data-export-toolbar-resync.jpg "Data Export Service toolbar")  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Resolving synchronization issues](../admin/replicate-data-microsoft-azure-sql-database.md#resolve_issues)  
  
<a name="connectors"></a>   
### Dynamics 365 (online) connectors for Logic Apps, Flow, and PowerApps  
 Use [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)] Logic Apps or Microsoft Flow to set up automated workflows between a [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] instance and your choice from many other apps and services available to synchronize files, get notifications, collect data, and more. ![Logic App create a record](../admin/media/logic-app-step-1.png "Logic App create a record")  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create a logic app with the Dynamics 365 connector](https://docs.microsoft.com/en-us/azure/connectors/connectors-create-api-crmonline) and [Create a flow by using Dynamics 365 (online)](https://ms.flow.microsoft.com/en-us/documentation/connection-dynamics365/)  
  
 Use Microsoft PowerApps to quickly generate, customize, share, and run mobile apps with little or no code. With the [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] connector, in just a few minutes you can create useful mobile apps to share with your organization.  
  
 ![Power App contacts mobile app](../admin/media/power-app-contacts-app.png "Power App contacts mobile app")  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Connect from PowerApps to Dynamics 365](https://powerapps.microsoft.com/en-us/tutorials/connection-dynamics-crmonline/)  
  
## What's new in the [!INCLUDE[pn_crm_9_0_0_online](../includes/pn-crm-9-0-0-online.md)]  
  
-   [Introducing modular business apps, app designer, and site map designer](#BKMK_APPMODULES)  
  
-   [Processes unification and enhancements](#BKMK_BPU)  
  
-   [Create your own Learning Path (guided help) content for your users](#BKMK_LP)  
  
-   [Dynamics 365 for Field Service enhancements](#BKMK_FS)  
  
-   [Enhancements to Portal capabilities for Dynamics 365](#BKMK_PortalCap)  
  
-   [Mobile app enhancements](#BKMK_Mobile)  
  
-   [Relevance Search enhancements](#BKMK_RelevanceSearchGA)  
  
-   [Display the associated activities of the related entities](#BKMK_AssociatedActivities)  
  
-   [Editable Grid custom control](#BKMK_EditableGrid)  
  
-   [Power BI integration enhancements](#PowerBIv2)  
  
-   [Preview feature: Azure Cognitive Service integration](#AzreCognitiveIntegration)  
  
-   [Replicate Dynamics 365 (online) data to Azure SQL Database using Data Export](#DataExport)  
  
-   [Customer-initiated backup and restore](#BKMK_CustomerBackup)  
  
-   [Access restriction with trusted IP rules](#BKMK_TrustedIP)  
  
-   [View metrics about your instance with Organization Insights solution](#BKMK_OrgInsightsV2)  
  
-   [Preview feature: Customer Insights service](#BKMK_CustomerInsights)  
  
-   [Preview feature: Relationship Insights](#BKMK_RI)  
  
<a name="BKMK_APPMODULES"></a>   
### Introducing modular business apps, app designer, and site map designer  
 You can now create custom task-based apps for your users. Apps are solution-aware components that store references to the existing [!INCLUDE[pn_crm_2016_shortest](../includes/pn-crm-2016-shortest.md)] schema.  
  
 Use the new app designer to  quickly create simple (single entity) or complex (multi-entity) business apps. The app designer, which is a tile-based information structure, makes the process of designing apps very simple. Just pick the required set of components such as forms, views, dashboards, charts, and process flows, and create simple or complex apps like case management or lead management in no time. Once you’ve pulled together all the components you want, you can also validate your app for any missing or required components.  
  
 The new site map designer, which is integrated with the app designer, greatly simplifies the process of creating a navigation and site map for your apps. Use the WYSIWYG designer that lets you quickly drag and drop areas and sub areas within the site map.  
  
 After you design an app, you can control access and visibility to it by restricting it to specific roles.  
  
[!INCLUDE[proc_more_information](../includes/proc-more-information.md)]
  
-   [Design custom business apps by using the App Designer](https://go.microsoft.com/fwlink/p/?linkid=832957)  
  
-   [Accessing and switching apps](https://go.microsoft.com/fwlink/?linkid=832674)  
  
<a name="BKMK_BPU"></a>   
### Processes unification and enhancements  
 Defining and enforcing consistent processes is very important for any successful business. [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] provides a number processes, such as business process flows, mobile task flows, and workflows, to help organizations improve their productivity and customer satisfaction. Up until now, these processes were created and customized by using different design interfaces. In this release, we are making a first step in simplifying the design experience by unifying the customization user interface for business process flows, mobile task flows, and business rules. The new design environment is based on a visual drag-and-drop interface.  
  
 We are also adding a number of new powerful features and capabilities, such as concurrently running business processes and security role support for business process flows and mobile task flows. The following table lists some of the new features and their benefits.  
  
|Feature|Benefit|  
|-------------|-------------|  
|Switching between concurrently running business process flows|Concurrent business process flows let customizers configure multiple business processes and associate them with the same starting record. Users can switch between multiple business processes running concurrently,   and resume their work at the stage in the process that they were on.|  
|Process security|With concurrent business process flows, it's crucial to be able to separate business process definitions according to user roles. For example, a customizer can configure business processes in such a way that the sales people will not have access to the marketing or service team business process flows. Users can work on processes that their security role has access to without interfering with other people’s work.|  
|Automation (on-demand through process events)|Business process flows trigger events every time a process is applied to a record, its status is changed to Active, Finished, or Abandoned, or the stage is changed. This lets customizers call on-demand workflows to automate the execution of actions based on those events.|  
|Automation (through workflows)|Customizers can associate business process flows with synchronous (real-time) or asynchronous (background) workflows. The workflows are triggered by changes in the process instance or by changes in the fields of the participating records.|  
|Process designer|The new visual drag-and-drop process designer allows creating processes, such as business process flows and mobile task flows, as well as business rules with Portable Business Logic, through an intuitive graphical interface.|  
|Process finish or abandonment|Business process flows can be marked as **Active**, **Finished**, or **Abandoned**. This helps track the progress of processes from start to end through charts and reports, as well as enforcing stage gating rules for all stages of the process, including the final stage.|  
|Business recommendation|Customizers can create new business rules that, based on the data of records, display a suggestion bubble with text that helps guide users while they execute a business process flow or fill out a form.|  
|Key performance indicators (KPIs)|Business process flows now track the time taken on each stage and the total time taken for the process to complete. The reports can be created for the performance to be visualized and analyzed for optimization opportunities.|  
|Mobile task flows|Mobile task flows are generally available for online and internet-facing on-premises deployments. They support [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] solutions and security roles that allow customizers to separate task flows based on user role.|  
|Out-of-the-box [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] messages as actions|Certain [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] messages can now be called directly from workflows and actions, simplifying the automation of  tasks.|  
  
[!INCLUDE[proc_more_information](../includes/proc-more-information.md)]
  
-   [Create a business process flow](https://go.microsoft.com/fwlink/p/?linkid=832958)  
  
-   [Create a mobile task flow](https://go.microsoft.com/fwlink/p/?linkid=836909)  
  
-   [Create a business rule or business recommendation](https://go.microsoft.com/fwlink/?linkid=836910)  
  
<a name="BKMK_LP"></a>   
### Create your own Learning Path (guided help) content for your users  
 In [!INCLUDE[pn_crm_8_1_0_online](../includes/pn-crm-8-1-0-online.md)], we introduced Learning Path, which provides contextually-rich training, walkthroughs, videos, and articles right in the app at just the right time. With [!INCLUDE[pn_crm_8_2_0_online](../includes/pn-crm-8-2-0-online.md)], you can now create your own Learning Path experience for your [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] users. For example, create a custom Learning Path experience to train your sales team. Learning Path allows you to deliver custom content specific to the security role assigned to a user. This means, for example, that sales people see Learning Path sidebars and guided tasks specific to their role, and service reps see a different set of content. You can also display different content for the same security role in different organizations. You can even localize your content in different languages for different users and organizations.  
  
 Learning Path provides a great way to help people discover new features and become familiar with new forms or business processes at their own pace right from the app. This can help reduce training time and costs and enable team members to quickly become productive using [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)].  
  
[!INCLUDE[proc_more_information](../includes/proc-more-information.md)]
  
-   [Create your own guided help (Learning Path) for your users](https://go.microsoft.com/fwlink/?linkid=838983)  
  
- ![Video button](../admin/media/video-icon.PNG "Video button") [Watch a short video (1:49) on how Learning Path works](http://go.microsoft.com/fwlink/p/?LinkID=723184)  
  
<a name="BKMK_FS"></a>   
### Dynamics 365 for Field Service enhancements  
 We made the following enhancements:  
  
- **Connected field service:** Connected field service, new in this release, helps service organizations move from a costly break-fix model to a proactive and predictive service model by combining monitoring and predictive maintenance with Internet of Things (IoT) and machine learning. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use Connected Field Service to remotely monitor and service customer equipment](https://go.microsoft.com/fwlink/?linkid=834477).  
  
     Key benefits include:  
  
    -   Reduce downtime with proactive alerts from connected devices.  
  
    -   Address issues faster by remotely monitoring devices and keeping customers in the loop.  
  
    -   Reduce maintenance costs by dispatching a technician with the right expertise, availability, and location to do the job.  
  
         As a platform, IoT also enables ISVs and partners to enable new IoT scenarios on any [!INCLUDE[pn_crm_2016_shortest](../includes/pn-crm-2016-shortest.md)] entity.  
  
- **Resource scheduling optimization:** With resource scheduling optimization, you can set up the system to automatically schedule multiple items on a recurring basis to minimize overall travel time and make efficient use of all schedulable resources. Resource scheduling optimization takes into account a number of constraints and objectives when optimizing schedules, such as resource availability, skills required, priority and duration, and time windows. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Schedule multiple booking requirements on a recurring basis](https://go.microsoft.com/fwlink/?linkid=831403).  
  
- **Common scheduling experience:** With the new common scheduling experience, you can schedule anything. You can enable it for  any entity, including custom entities. For example, you can turn it on to schedule marketing visits for an opportunity or book time to work on a case, work orders, bookings, and more.  
  
     For organizations that use Field Service capabilities, you’ll see a new integrated scheduling experience.  
  
     For organizations that use Dynamics 365 Project Service Automation capabilities, you’ll have a new improved scheduling experience. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Schedule anything in Dynamics 365](http://go.microsoft.com/fwlink/?LinkID=773454).  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Dynamics 365 for Field Service User's Guide](http://go.microsoft.com/fwlink/p/?LinkId=773453)  
  
<a name="BKMK_PortalCap"></a>   
### Enhancements to Portal capabilities for Dynamics 365  
 We made many enhancements to Portal capabilities for Dynamics 365:  
  
- **Multi-language portal support:** By surfacing the multi-language content you create in Portal capabilities for Dynamics 365, you can support your customers, partners, and employees in multiple regions. Multi-language portals also support languages with multi-byte characters, such as Japanese, Chinese, and Korean.  
  
- **Faceted search for knowledge articles:** Search portal content by using different characteristics of knowledge articles as filters to improve how quickly customers can find the content they are looking for. Faceted portal searches can increase the visibility and effectiveness of content that may not have been surfaced through a traditional search.  
  
- **Content access levels for knowledge articles:** Develop a well-structured knowledge base and provide content to the right audience using content access levels. You can create structured learning paths for your users and prevent content that is not relevant from surfacing.  
  
- **Project Service Automation integration:** Vendor companies can use Project Service Automation integration to provide access and visibility for active and closed projects across all stages of a project lifecycle to their partner channel and customer. Partner project service team members, reviewers, and customers can view project status and view quotes, order forms, and bookable resources directly from the partner portal.  
  
- **Field Service integration:** Vendor companies can use the Field Service integration to expose information about active agreements, assets, work orders, invoices, and support cases to their partner channel and customers. Partner field service team members, reviewers, and customers can access this information directly from the partner portal.  
  
- **Multi-partner collaboration:** Distribute opportunities to multiple partners to maximize a sales opportunity and provide the best solutions for your customers’ needs. Partner sellers can work collaboratively to cover the needs of customers they normally couldn’t with the assistance of other partners and provide information to one another, such as product and pricing updates, notes or comments, and partner contacts to enhance the health of the opportunity.  
  
- **Partner onboarding and recruitment:** Use the partner recruitment and onboarding capabilities to identify, recruit, and onboard the best partners in your partner channel for better customer sales and service experiences.  Use built-in dashboards to get better visibility of your current partner channel and focus efforts into enhancing your channel coverage based on identified gaps.  
  
- **Partner locator:** Enable your customers to find the right partners in your partner ecosystem based on geographic location, product expertise, supported industries, partner categories, and more.  
  
- **Partner portal dashboard:** Partners can gain insight into their opportunity pipeline and their performance using portal dashboards. With this information, partners can make more informed decisions about opportunities they bid on, as well as currently active opportunities to more intelligently devote resources and improve the health of their relationships with customers and the parent organization.  
  
- **Deal registration and protection:** Enable your partner channel to register more deals by providing deal registration capabilities. Partners can register opportunities through the portal to get deal protection and other benefits.  Using these capabilities, encourage your partner channel to partner with you to sell more.  
  
<a name="BKMK_Mobile"></a>   
### Mobile app enhancements  
 We made the following enhancements:  
  
- **New layouts:** The new layouts in the mobile app have one important implication for admins and customizers. Items are now displayed in stacks to expose more info at once. Items in each section are stacked together by default, but you can use the form editor to change the way these sections are displayed to better reflect how your organization works.  
  
- **Multimedia content:** Users can now record multimedia content directly in the mobile app.  Please note that if you’re concerned about large files, you should recommend that users change the settings of their device to take lower resolution photos.  
  
- **Enhanced sync filter:** Users can now make more finely tuned choices about what info they want to sync to their devices. That means they don’t have to clog their device’s memory with large sets of records—they can take just what they need.  
  
- **JavaScript Support:** Offline mode now supports the ability to run ClientAPI (JavaScript), so you can run your client-side business logic while users are offline.  
  
- **Web Resources Support:** Offline mode now also supports web resources.  
  
[!INCLUDE[proc_more_information](../includes/proc-more-information.md)]
  
-   [Dynamics 365: What's new](http://go.microsoft.com/fwlink/p/?LinkId=511887)  
  
-   [Dynamics 365 for Phones and Tablets User's Guide](https://go.microsoft.com/fwlink/p/?linkid=637661)  
  
<a name="BKMK_RelevanceSearchGA"></a>   
### Relevance Search enhancements  
 With new facet and filter support, users have the ability to drill into and explore search results without having to repeatedly refine the search terms. The global Relevance Search facets are used for the fields common to most entities in [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)]. Four facets are displayed by default on the left side of the Relevance Search results page, as shown below. They represent **Record type**, **Owner**, **Modified On**, and **Created On** fields.  
  
 ![Relevance Search facets](../admin/media/relevance-search-facets-screen-centaurus-80-border.png "Relevance Search facets")  
  
 If a user selects a specific entity in the **Record type** facet, they can choose up  to four additional facets specific to the entity.   For example, for the Account entity, you can configure facets that will have information about the account’s annual revenue, the industry they are in, and the primary contact information. The non-text entity fields that you add  through **View Columns** in the entity **Quick Find View** are shown as entity-specific facets in the Relevance Search results page.  
  
 Other enhancements include:  
  
-   Users can now search in documents attached to email and appointments, as well as documents attached to a note.  
  
-   The **Option Set** and **Lookup** fields are  searchable fields in this release.  
  
-   We also added support for showing results for rows that are shared with a user.  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Configure Relevance Search for the organization](../admin/configure-relevance-search-organization.md)  
  
<a name="BKMK_AssociatedActivities"></a>   
### Display the associated activities of the related entities  
 We added a new flag called **Rollup View** in the customization user interface, on the **Relationship Behavior** form. It lets customizers indicate that associated activities of the related entity should be included in the **Activity Associated View** for the primary entity. The **Rollup View** flag can only be set if the following conditions are met:  
  
-   The primary and the related entity must be a 1:N (one-to-many) or N:1 (many-to-one) custom relationship. The flag can’t be set on any out-of-the-box system relationships.  
  
-   The primary entity for the relationship must be Account, Contact, or Opportunity. This is because these are the only entity forms in the system where the **Activity Associated View** appears. You can’t specify any other primary entity for activity rollups.  
  
-   The related entity must support Activities.  
  
 The valid options for the **Rollup View** flag are:  
  
- **Cascade None** (default)  
  
- **Cascade All**  
  
<a name="BKMK_EditableGrid"></a>   
### Editable Grid custom control  
 The new Editable Grid custom control supports inline editing, complex grid logic, and business rules. The Editable Grid control can be enabled at an entity level in the [!INCLUDE[pn_crm_2016_shortest](../includes/pn-crm-2016-shortest.md)] Web client, [!INCLUDE[pn_Mobile_Express_short](../includes/pn-mobile-express-short.md)], and [!INCLUDE[pn_moca_short](../includes/pn-moca-short.md)]. For dashboards,  editable grids are only available in [!INCLUDE[pn_Mobile_Express_short](../includes/pn-mobile-express-short.md)] and [!INCLUDE[pn_moca_short](../includes/pn-moca-short.md)].  
  
 To enable the Editable Grid control for various clients, go to **Settings** > **Customizations** > **Customize the System** > **Components** > **Entities**. In the **Information** dialog box for an entity, select the **Controls** tab.  
  
 ![Enable editable grid](../admin/media/editable-grid-enable-no-hierarchy-90.png "Enable editable grid")  
  
 Here are some examples for configuring  Editable Grid controls:  
  
-   Configure the Editable Grid control as a default control for various clients. This will let users toggle between read-only grids and editable grids.  
  
-   Configure Editable Grid control properties, such as **Group By** filter, **Lookup**, or related grid properties. This will provide inline editing capabilities in the main grid and the nested grid in one view, without having to switch records or views.  
  
-   Configure event handlers to support complex grid logic. For example, you can upload [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] libraries for the following events: **OnRecordSelect**, **OnSave**, and **OnChange**.  
  
-   Create business rules at an entity level to support business logic in editable grids.  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Make grids (lists) editable in Dynamics 365 using the Editable Grid custom control](../customize/make-grids-lists-editable-custom-control.md)  
  
<a name="PowerBIv2"></a>   
### Power BI integration enhancements  
 Building on the [!INCLUDE[pn_microsoft_power_bi](../includes/pn-microsoft-power-bi.md)] enhancements from the previous release, [!INCLUDE[pn_power_bi](../includes/pn-power-bi.md)] dashboards can now be added to [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] personal dashboards. This release also brings support for [!INCLUDE[pn_dyn_365_tablets](../includes/pn-dyn-365-tablets.md)] and [!INCLUDE[pn_dyn_365_phones](../includes/pn-dyn-365-phones.md)] mobile clients.  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use Power BI with Dynamics 365](../admin/use-power-bi.md)  
  
<a name="AzreCognitiveIntegration"></a>   
### Preview feature: Azure Cognitive Service integration  
 [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)] Cognitive Services includes several APIs that leverage the power of machine learning. Some [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] features can use the text analytics APIs to detect sentiment, key phrases, topics, and language from the text found in your [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] data.  Similarly, using the recommendation API, [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] can automatically make product recommendations to your users.   Several features are available that tap into the capabilities of [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)] Text Analytics and Recommendations services.  
  
[!INCLUDE[proc_more_information](../includes/proc-more-information.md)]
  
-   [Preview feature: Create and manage models to make product recommendations](../admin/public-preview-create-and-manage-models-to-make-product-recommendations.md)  
  
-   [Preview feature: Automatically suggest knowledge articles](../admin/public-preview-automatically-suggest-knowledge-articles.md)  
  
-   [Preview feature: Topic analysis](../admin/public-preview-topic-analysis.md)  
  
-   [Preview feature: Suggest similar cases for a case](../admin/public-preview-suggest-similar-cases-for-a-case.md)  
  
-   [Preview feature: Enable document suggestions](../admin/enable-document-suggestions.md)  
  
<a name="DataExport"></a>   
### Replicate Dynamics 365 (online) data to Azure SQL Database using Data Export  
 [!INCLUDE[cc_Data_Export_Service](../includes/cc-data-export-service.md)] is an add-on service made available as a [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] solution that adds the ability to replicate [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] data to a [!INCLUDE[pn_ms_azure_sql_database](../includes/pn-ms-azure-sql-database.md)] store in a customer-owned [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)] subscription. The supported target destinations are [!INCLUDE[pn_ms_azure_sql_database](../includes/pn-ms-azure-sql-database.md)] and [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)][!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] on [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)] virtual machines. [!INCLUDE[cc_Data_Export_Service](../includes/cc-data-export-service.md)] intelligently synchronizes the entire [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] data initially and thereafter synchronizes on a continuous basis as changes occur (delta changes) in the [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] system. This helps enable several analytics and reporting scenarios on top of [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] data with [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)] data and analytics services and opens up new possibilities for customers and partners to build custom solutions.  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Replicate Dynamics 365 (online) data to Azure SQL Database](../admin/replicate-data-microsoft-azure-sql-database.md)  
  
<a name="BKMK_CustomerBackup"></a>   
### Customer-initiated backup and restore  
 Protecting your [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] data and providing continuous availability of service is important for you and for us. You have multiple options for backing up and restoring your [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] instances. In [!INCLUDE[pn_crm_8_1_0_online_subsequent](../includes/pn-crm-8-1-0-online-subsequent.md)], we introduced on-demand backups that you can perform on  Production and Sandbox instances. There are two types of [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] backups: system and on-demand.  
  
 About system backups:  
  
-   All your instances are backed up.  
  
-   System backups occur daily.  
  
-   System backups are retained for up to three days. Check your expiration date.  
  
-   System backups do not count against your storage limits.  
  
 About on-demand backups:  
  
-   You can back up Production and Sandbox instances.  
  
-   You can only restore to a Sandbox instance. To restore to a Production instance, first switch to a Sandbox instance. See [Switch an instance](https://technet.microsoft.com/library/dn896590.aspx).  
  
-   Only [!INCLUDE[pn_crm_8_1_0_online_subsequent](../includes/pn-crm-8-1-0-online-subsequent.md)] or later versions are supported for backup.  
  
-   On-demand backups are retained for up to three days. Check your expiration date.  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Backup and restore instances](https://technet.microsoft.com/library/mt748060.aspx).  
  
<a name="BKMK_TrustedIP"></a>   
### Access restriction with trusted IP rules  
 You can limit access to [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] to users with trusted IP addresses to reduce unauthorized access. When trusted IP address restrictions are set in a user’s profile and the user tries to log in from an untrusted IP address, access to [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] is blocked.  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Restrict access to Dynamics 365 (online) with trusted IP rules](https://technet.microsoft.com/library/mt761734.aspx).  
  
<a name="BKMK_OrgInsightsV2"></a>   
### View metrics about your instance with Organization Insights solution  
 The Organization Insights **dashboard** surfaces key data points around activity, usage, performance, and quality of service on the [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] instance. The new Organization Insights **solution** adds more insights and metrics such as who are your most active users, which entities are being used, which are the top failing workflows and plugins, and the storage used by your organization's tables.  
  
[!INCLUDE[proc_more_information](../includes/proc-more-information.md)]
  
-   [View metrics about your instance with the Organization Insights solution](https://go.microsoft.com/fwlink/p/?linkid=832971)  
  
-   [Watch a short video (2:20) about the Organization Insights solution](https://go.microsoft.com/fwlink/p/?linkid=835917)  
  
<a name="BKMK_CustomerInsights"></a>   
### Preview feature: Customer Insights service  
 Customer Insights is a cloud-based SaaS service that enables organizations of all sizes to bring together data from multiple sources and generate knowledge and insights to build a holistic 360° view of their customers. Customer Insights delivers the ability to connect to transactional data sources and model profiles of customers and their interactions. It enables organizations to generate insights through key performance indicators (KPIs) about their business. The Customer Insights application transforms the profile, interaction, and KPI’s into rich visuals that you can customize and organize to focus on what matters to you.  
  
 ![](media/HowCustomerInsightsWorks.png "Customer Insights: How it works")
  
> [!NOTE]
>  Customer Insights is offered as a preview feature for [!INCLUDE[pn_crm_8_2_0_online](../includes/pn-crm-8-2-0-online.md)]. A preview feature is a feature that is not complete, but is made available before it’s officially released so customers can get early access and provide feedback. Preview features aren’t meant for production use and may have limited or restricted functionality. Preview features must be [enabled by an administrator](http://go.microsoft.com/fwlink/p/?LinkID=625975).  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Customer Insights service](https://go.microsoft.com/fwlink/p/?linkid=828361)  
  
<a name="BKMK_RI"></a>   
### Preview feature: Relationship Insights  
 Many sales professionals spend a large part of their day working in [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)], [!INCLUDE[pn_MS_Outlook_Short](../includes/pn-ms-outlook-short.md)], and [!INCLUDE[pn_Microsoft_Exchange](../includes/pn-microsoft-exchange.md)]. And the more you use them, the more these systems become filled with invaluable details about your plans, activities, meetings, communications, sales successes, and more. The new  *Relationship Insights* suite of features in [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] continuously analyzes this vast collection of customer-interaction data to help you better understand your business relationships, evaluate your activities in relation to previous successes, and choose the best path forward.  
  
 Relationship Insights includes the following sub-features, which all work together to amplify their individual strengths:  
  
-   Relationship assistant  
  
-   Email engagement  
  
-   Auto capture  
  
 For more information on each of these features, see [Dynamics 365: What's new](http://go.microsoft.com/fwlink/p/?LinkId=511887)  
  
> [!NOTE]
>  All Relationship Insights features are offered as preview features for [!INCLUDE[pn_crm_8_2_0_online](../includes/pn-crm-8-2-0-online.md)]. A preview feature is a feature that is not complete, but is made available before it’s officially released so customers can get early access and provide feedback. Preview features aren’t meant for production use and may have limited or restricted functionality. Preview features must be [enabled by an administrator](http://go.microsoft.com/fwlink/p/?LinkID=625975). You can enable or disable each Relationship Insights feature individually on the **Previews** tab in the **System Settings** dialog box.  
  
 Configuration settings for the Relationship Insights features are provided on a new tabbed settings page. To find it, go to **Settings > System > Relationship Insights**. From here you can enable, disable, and configure the various sub-features. The settings you make here apply to all users.  
  
 For requirements, prerequisites, and complete details about how to set up and configure Relationship Insights, see [Configure Relationship Insights features](http://go.microsoft.com/fwlink/p/?LinkId=824713)  
  
## What's new in CRM Online 2016 Update 1  
  
-   [In-app training increases user adoption and productivity](../admin/what-s-new-for-administrators-and-customizers.md#BKMK_MARS)  
  
-   [Self-service portals for an external non-Dynamics 365 audience](../admin/what-s-new-for-administrators-and-customizers.md#BKMK_Portals)  
  
-   [Feedback and ratings on entities](../admin/what-s-new-for-administrators-and-customizers.md#BKMK_Feedback)  
  
-   [Project-based sales](../admin/what-s-new-for-administrators-and-customizers.md#BKMK_ProjectService)  
  
-   [Field service management](../admin/what-s-new-for-administrators-and-customizers.md#BKMK_FieldService)  
  
-   [Enhanced Power BI integration](#BKMK_PowerBI)  
  
-   [Preview feature: Dynamics 365 recommends products by using Azure Machine Learning](../admin/what-s-new-for-administrators-and-customizers.md#BKMK_ProductRecommendations)  
  
-   [Preview feature: Dynamics 365 suggests knowledge base articles  by using Azure Machine Learning](../admin/what-s-new-for-administrators-and-customizers.md#BKMK_CaseRecommendations)  
  
-   [SLAs for any custom entity and other system entities](../admin/what-s-new-for-administrators-and-customizers.md#BKMK_SLA)  
  
-   [Interactive service hub enhancements](../admin/what-s-new-for-administrators-and-customizers.md#BKMK_ISH)  
  
-   [Unified Service Desk enhancements](../admin/what-s-new-for-administrators-and-customizers.md#BKMK_USDEnhancements)  
  
-   [Rich mobile offline experience](../admin/what-s-new-for-administrators-and-customizers.md#BKMK_MobileOffline)  
  
-   [Mobile management enhancements](../admin/what-s-new-for-administrators-and-customizers.md#BKMK_MobileManagement)  
  
-   [Mobile devices conditional access](../admin/what-s-new-for-administrators-and-customizers.md#BKMK_CondAccess)  
  
-   [Mobile app preparation is faster after customization](../admin/what-s-new-for-administrators-and-customizers.md#BKMK_MobileSpeed)  
  
-   [Keep track of company news from a mobile device](../admin/what-s-new-for-administrators-and-customizers.md#BKMK_CompanyNews)  
  
-   [Organization Insights Dashboard shows system usage stats](../admin/what-s-new-for-administrators-and-customizers.md#BKMK_OIDashboard)  
  
-   [Customer field for any entity](../admin/what-s-new-for-administrators-and-customizers.md#BKMK_CustomerField)  
  
-   [New datacenter in India](../admin/what-s-new-for-administrators-and-customizers.md#BKMK_India)  
  
-   [Package Deployer tool now runs from a command prompt](../admin/what-s-new-for-administrators-and-customizers.md#BKMK_PackageDeployer)  
  
-   [Preview feature: Display multi-entity search results in a single list by using  Relevance Search](../admin/what-s-new-for-administrators-and-customizers.md#BKMK_RelevanceSearch)  
  
<a name="BKMK_MARS"></a>   
### In-app guidance increases user adoption and productivity  
 In this release, we’re introducing Learning Path, a new guided user experience that provides context-sensitive, interactive, and scenario-based guided tasks and sidebars personalized to the user, their lifecycle stage, and role. Whether the user is participating in a trial, has just purchased, or has recently updated their service, Learning Path helps them onboard quickly, facilitates adoption, and improves productivity.  
  
 In this release, we’re providing Learning Path guidance for onboarding, what’s new, and frequent tasks such as lead management in the web and mobile apps.  
  
 ![Contents page for Learning Path in Dynamics 365 &#40;online&#41;](../admin/media/learning-path.PNG "Contents page for Learning Path in Dynamics 365 (online)")  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] ![Video button](../admin/media/video-icon.PNG "Video button") [Watch a short video (1:49) on Learning Path](http://go.microsoft.com/fwlink/p/?LinkId=723184), [On/off switch for Learning Path (guided help)](https://go.microsoft.com/fwlink/P/?linkid=832758)  
  
<a name="BKMK_Portals"></a>   
### Self-service portals for external audiences  
 This release introduces the first Microsoft-published version of portal capabilities for [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)]. Portal capabilities for CRM empower the 84% majority who prefer to find answers on their own through self-service and community options.  
  
> [!NOTE]
>  Portal capabilities are provided as an add-on for customers who upgrade to the latest version ([!INCLUDE[pn_crm_8_1_0_online_subsequent](../includes/pn-crm-8-1-0-online-subsequent.md)]).  
  
 We’re extending CRM to the web to include:  
  
-   Profile management capabilities  
  
-   Configurable business components  
  
-   Rich web content configuration capabilities  
  
-   Responsive design for desktop, tablet, and mobile  
  
 Customers can purchase portal instances as an add-on in the [!INCLUDE[pn_dyn_365_admin_center](../includes/pn-dyn-365-admin-center.md)]. These portal instances can then be configured to work with their CRM Online instances. The provisioning system automatically deploys the portal solution to [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)].  
  
 Out-of-the-box portal solutions include:  
  
- **Custom portal.** The custom portal is a basic portal that contains flows and pages common to all portals. It includes basic support content as well as custom applications to meet the specific support needs of different organizations, including login/authentication features and contact pages.  
  
- **Customer Self-Service portal.** Lets customers access self-service knowledge and support resources, increasing customer satisfaction, reducing call center volumes, and ultimately allowing service agents to focus their efforts on issues of greatest impact.  
  
- **Employee Self-Service portal.** Creates an efficient and well-informed workforce by streamlining common tasks and empowering every employee with a definitive source of knowledge. Employee self-service is now available worldwide using CRM Online and portal capabilities, and is available in all CRM Online markets.  
  
- **Community portal.** Enables peer-to-peer interactions between experts in the community, subject matter experts within an organization, and internal and external users. Communities organically grow the catalog of available knowledge from knowledge base articles, forums, and blogs. Participants can provide feedback through rating and comments features. Contributors can also receive alerts on content revisions and workflow updates.  
  
- **Partner  portal.** Create an environment for interacting with your partners and collaborating on sales opportunities to provide products and services based on your customers' needs.  
  
     Partner relationship management portal capabilities include:  
  
    -   Account and contact management  
  
    -   Channel opportunity management  
  
    -   Partner profiling  
  
    -   Opportunity distribution  
  
    -   Delegated administration  
  
[!INCLUDE[proc_more_information](../includes/proc-more-information.md)]
  
[//]: # (Broken link)
-   [Administrator's Guide to portal capabilities](https://www.microsoft.com/en-us/dynamics/crm-setup-and-administration/administrator-s-guide-to-portal-capabilities-for-microsoft-dynamics-crm.aspx)  
  
- ![Video button](../admin/media/video-icon.PNG "Video button") [Watch a short video (2:22) on CRM portal capabilities](https://www.microsoft.com/en-us/dynamics/crm-setup-and-administration/administrator-s-guide-to-portal-capabilities-for-microsoft-dynamics-crm.aspx)  
  
<a name="BKMK_Feedback"></a>   
### Feedback and ratings on entities  
 You can enable feedback on entities to allow customers to write feedback for any entity record, or rate the entity records within a range of allowed ratings. For example, enable feedback or ratings on the Case entity to receive feedback on the customer’s support experience. When several customers rate a record, the ratings can be consolidated through a custom rollup field.  
  
 By default, feedback is enabled for the Knowledge Article entity and the rollup field is added to Knowledge Article entity.  
  
 ![Enable an entity for feedback](../admin/media/enable-entity-feedback.png "Enable an entity for feedback")  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Enable an entity for feedback](http://go.microsoft.com/fwlink/p/?LinkId=789262)  
  
<a name="BKMK_ProjectService"></a>   
### Project-based sales  
 Project service automation capabilities for CRM Online provide an end-to-end solution that empowers organizations to deliver project-based engagements on time and within budget. Project service automation capabilities help you:  
  
-   Estimate, quote, and contract work  
  
-   Plan and assign resources  
  
-   Enable team collaboration  
  
-   Capture time, expense, and progress data for real-time insights and accurate invoicing  
  
> [!NOTE]
>  Project service automation capabilities are provided as an add-on for customers who upgrade to the latest version ([!INCLUDE[pn_crm_8_1_0_online_subsequent](../includes/pn-crm-8-1-0-online-subsequent.md)]).  
  
 Project service automation capabilities include:  
  
- **Project-based contracts.** Project contracts relate quotes and orders to project plans, financial estimates, labor pricing, and billing arrangements, like time and materials or fixed price. The contract highlights key metrics, including profitability and feasibility.  
  
- **Project planning.** Visual project planning and estimation includes predecessors, automatic task scheduling, and views of sales and cost information for time and expenses. You can use the resulting plan in quotes and project contracts.  
  
- **Resource management.** Resource information includes the skills and proficiencies of your workforce. You can view and filter resources based on skills and availability, so you can assign the right people to the right projects. You can also track resource utilization and forecasting metrics.  
  
- **Time and expenses.** Team members can use the web or mobile apps to record time and expenses for multiple projects. Managers can easily approve new entries while understanding the financial implications of the newly-approved items.  
  
- **Project billing.** Project invoices reflect the terms of the contract and the approved work and expenses. The financial impact of project work, including costs, unbilled revenue, and invoices, is recorded for use in analytics and integration into financial systems.  
  
 Both project service automation capabilities and field service capabilities (see below) share a resource pool, with resource schedules appearing in both.  
  
[!INCLUDE[proc_more_information](../includes/proc-more-information.md)]
  
-   [Manage project-based sales with CRM project serivce](http://go.microsoft.com/fwlink/p/?LinkID=789265)  
  
- ![Video button](../admin/media/video-icon.PNG "Video button") [Watch a short video (2:41) on project service capabilities](http://go.microsoft.com/fwlink/p/?LinkID=799450)  
  
<a name="BKMK_FieldService"></a>   
### Field service management  
 Field service is an end-to-end solution that delivers advanced scheduling, inventory tracking, and asset management for service depots and highly mobile, in-field specialists who need to fulfill work orders and provide preventive maintenance across multiple sites under complex service agreements.  
  
> [!NOTE]
>  Field service capabilities are provided as an add-on for customers who upgrade to the latest version ([!INCLUDE[pn_crm_8_1_0_online_subsequent](../includes/pn-crm-8-1-0-online-subsequent.md)]).  
  
 Field service capabilities include:  
  
- **Characteristics and proficiency ratings.** You can define proficiency and competency levels and set them as requirements for a work order. Proficiency and competency levels are also part of the worker profile, so you can make an appropriate match when scheduling resources.  
  
- **Detached schedule support.** Field service capabilities support time allocation outside of a work order. For example, a field tech can schedule time for lunch or supply provisioning without having to associate that time with an empty work order.  
  
- **Out-of-the-box business processes.** The CRM Online incident management business process is closely aligned with the work order process. If a field service work order originates from a case, the originating case is visually part of that workflow, which spans from case creation through work order completion.  
  
- **Mobile enhancements.** Drip scheduling enhances and de-clutters the user experience by displaying fewer upcoming work orders. It also improves dispatch control by limiting the number of declined work orders or change requests by field techs.  
  
 Both field service capabilities and project service capabilities (see above) share a resource pool, with resource schedules appearing in both.  
  
[!INCLUDE[proc_more_information](../includes/proc-more-information.md)]
  
-   [Install the Field Service solution](http://go.microsoft.com/fwlink/p/?LinkID=780817)  
  
- ![Video button](../admin/media/video-icon.PNG "Video button") [Watch a short video (2:21) on field service capabilities](http://go.microsoft.com/fwlink/p/?LinkID=785803)  
  
<a name="BKMK_PowerBI"></a>   
### Enhanced Power BI integration  
 Enhanced [!INCLUDE[pn_microsoft_power_bi](../includes/pn-microsoft-power-bi.md)] integration lets you discover, analyze, and share data-sourced visualizations with colleagues. [!INCLUDE[pn_power_bi](../includes/pn-power-bi.md)] provides information workers and everyday business users with data analysis and visualization capabilities to get better business insights.  
  
 Features available in this release include:  
  
-   New Service Content Pack includes several key service indicators such as cases created, cases resolved, satisfaction percentage, top agent leaders, and most used and viewed KB articles.  
  
-   Improved Sales Manager Content Pack includes OData (Open Data Protocol) version 4.0 support.  
  
-   The ability to embed [!INCLUDE[pn_power_bi_for_office_365_short](../includes/pn-power-bi-for-office-365-short.md)] tiles directly from a CRM user dashboard without having to switch to the [!INCLUDE[pn_power_bi_for_office_365_short](../includes/pn-power-bi-for-office-365-short.md)] service.  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Embed Power BI tiles in your personal dashboard](https://tnstage.redmond.corp.microsoft.com/library/dn708055.aspx)  
  
<a name="BKMK_ProductRecommendations"></a>   
### Preview feature: Product recommendations using Azure Machine Learning  
 Imagine being able to make product recommendations to your customers when they select an item for purchase. When you connect CRM Online to the [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)] Recommendations API using Azure Machine Learning, this becomes available to you. You can use the Recommendations API to build an advanced machine learning model for automatic cross-sell product recommendations based on historical transaction data. Once you add the product recommendations capability in CRM Online by using the Recommendations API, a native capability is added to the product catalog to generate automatic recommendations by configuring connectivity to the service. In addition,  you set up the product catalog and  synchronization to build a machine-learning-based recommendation model. You will then use this model to make recommendations in CRM Online transactions, such as opportunity, quote, or order level, to suggest additional cross-sell products and help improve the total value of the deal.  
  
> [!NOTE]
>  Product recommendations is offered as a preview feature for CRM Online customers only. A preview feature is a feature that is not complete, but is made available before it’s officially released so customers can get early access and provide feedback. Preview features aren’t meant for production use and may have limited or restricted functionality. Preview features must be [enabled by a CRM administrator](http://go.microsoft.com/fwlink/p/?LinkID=625975).  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Preview feature: Create and manage models to make product recommendations](https://technet.microsoft.com/library/mt703320.aspx)  
  
<a name="BKMK_CaseRecommendations"></a>   
### Preview feature: Knowledge base article suggestions using Azure Machine Learning  
 You want your customer service reps to quickly resolve cases with high customer satisfaction. Using the [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)] Machine Learning Text Analytics service with CRM Online, you can set up service case analysis to automatically provide your support staff with more relevant solutions from the knowledge base. They spend less time searching for answers and more time providing the right response.  
  
> [!NOTE]
>  Knowledge base suggestions is offered as a preview feature for CRM Online customers only. A preview feature is a feature that is not complete, but is made available before it’s officially released so customers can get early access and provide feedback. Preview features aren’t meant for production use and may have limited or restricted functionality. Preview features must be [enabled by a CRM administrator](http://go.microsoft.com/fwlink/p/?LinkID=625975).  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Preview feature: Automatically suggest knowledge articles](https://technet.microsoft.com/library/mt703319.aspx)  
  
<a name="BKMK_SLA"></a>   
### SLAs for any custom entity and other system entities  
 In previous releases of CRM, SLAs were enabled by default just for the Case entity.  Now users can enable SLAs for any custom entity, and for any of the following system entities:  
  
-   All activity entities (such as Email, Task, and Appointment) except recurring appointments (RecurringAppointmentMaster)  
  
-   Account  
  
-   Contact  
  
-   Invoice  
  
-   Opportunity  
  
-   Quote  
  
-   Lead  
  
-   Order  
  
 ![Enable for SLAs](../admin/media/enable-sla.png "Enable for SLAs")  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Enable entities for service level agreements (SLAs)](http://go.microsoft.com/fwlink/p/?LinkID=789263)  
  
<a name="BKMK_ISH"></a>   
### Interactive service hub enhancements  
 The interactive service hub can now be integrated with [Unified Service Desk](https://technet.microsoft.com/library/dn798673.aspx) so users can open and control interactive service hub pages inside [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)].  
  
 We have also enhanced the interactive service hub in other ways. You can now:  
  
-   Add iFrames and web resources to the interactive experience forms to support extensibility scenarios  
  
-   Configure the lookup field properties to show filtered records in the interactive experience forms  
  
-   Configure language filters in the Knowledge Article Search pane so Customer Service Reps can filter knowledge articles based on languages  
  
-   Add the SLA timer to the Main interactive experience form  
  
 We also made metadata sync improvements to reduce download times for users.  
  
 For more information on enhancements to the interactive service hub for customer service reps, see [What's new for end users](http://go.microsoft.com/fwlink/p/?LinkId=511887).  
  
<a name="BKMK_USDEnhancements"></a>   
### Unified Service Desk enhancements  
 We’ve enhanced [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] in several ways:  
  
- **Interactive service hub integration.** The [interactive service hub](http://go.microsoft.com/fwlink/p/?LinkId=625970) can now be integrated with [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] so users can open and control interactive service hub pages inside [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)].  
  
- **[!INCLUDE[pn_ms_Windows_Update](../includes/pn-ms-windows-update.md)].** [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] also supports [!INCLUDE[pn_ms_Windows_Update](../includes/pn-ms-windows-update.md)] now. [!INCLUDE[pn_ms_Windows_Update](../includes/pn-ms-windows-update.md)] is an easy and free way to help keep Microsoft applications (like the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] client) safer and running smoothly. Just turn it on, and you'll get the latest security and other important updates from Microsoft automatically, or you can choose to apply updates manually.  
  
- **Demo packages.** New demo packages include samples for new [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] environments, upgrading existing [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] environments, and interactive service hub integration .  
  
- **Telemetry.** You can now help improve [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] by sending usage data to Microsoft anonymously.  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [What's new in Unified Service Desk update 2.1](https://technet.microsoft.com/library/dn798673.aspx)  
  
<a name="BKMK_MobileOffline"></a>   
### Rich mobile offline experience  
 Mobile offline synchronization, an enhanced offline experience that goes further than the offline drafts experience, is now available for CRM Online customers. The new mobile offline capabilities provide a richer offline experience for end users, allowing them to view, update, and add records while using the mobile apps offline—without having to save changes or additions as drafts first. The new mobile offline experience also supports conflict detection.  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Configure mobile offline synchronization for CRM for phones and tablets](http://go.microsoft.com/fwlink/p/?LinkID=780818)  
  
 [Working offline with Dynamics CRM mobile apps (3:16)](http://go.microsoft.com/fwlink/p/?LinkId=798752)  
  
<a name="BKMK_MobileManagement"></a>   
### Mobile management enhancements  
 CRM mobile applications for iOS and [!INCLUDE[tn_android](../includes/tn-android.md)] can now be managed by [!INCLUDE[pn_intune](../includes/pn-intune.md)] Mobile Application Management (MAM) without enrolling the device. This protects company data in [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] without requiring IT to enroll and deeply manage the user's entire device. This is particularly useful for bring-your-own-device (BYOD) scenarios where end users don’t want to or can’t enroll their devices for IT management. This capability is also useful if a device is already enrolled in another MDM solution.  
  
<a name="BKMK_CondAccess"></a>   
### Mobile devices conditional access  
 Use [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)] with CRM Online to set up conditional access from mobile devices. You configure conditions for CRM access at the [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)][!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] group level. For example, you might want to set up conditions that require multi-factor authentication for mobile users accessing CRM when they’re not at work—or maybe you want to require it at all times. You can also set up conditions that require the user’s mobile device to be compliant with your policies before the user can access CRM.  
  
 If you configure conditional access, before a user can connect to CRM, the device they use must be:  
  
-   Enrolled with [!INCLUDE[pn_intune](../includes/pn-intune.md)] or a domain-joined PC  
  
-   Registered in [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)][!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] (this happens automatically when the device is enrolled with [!INCLUDE[pn_intune](../includes/pn-intune.md)])  
  
-   Compliant with any [!INCLUDE[pn_ms_System_Center_Config_Mgr_short](../includes/pn-ms-system-center-config-mgr-short.md)] compliance policies deployed to that device  
  
 If a conditional access condition is not met, the user receives one of the following messages when they sign in:  
  
-   If the device isn’t enrolled with [!INCLUDE[pn_intune](../includes/pn-intune.md)], or isn’t registered in [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)][!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)], a message provides instructions about how to install the company portal app, enroll the device, and (for [!INCLUDE[tn_android](../includes/tn-android.md)] and iOS devices), activate email, which associates the device’s [!INCLUDE[pn_Exchange](../includes/pn-exchange.md)] ActiveSync ID with the device record in [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)][!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)].  
  
-   If the device isn’t compliant, a message directs the user to the [!INCLUDE[pn_intune](../includes/pn-intune.md)] web portal where they can find information about the problem and how to remediate it.  
  
> [!NOTE]
>  To use conditional access, you must have an [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)][!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] premium subscription.  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Secure and manage Dynamics 365 for phones and tablets](../mobile-app/secure-manage-phones-tablets.md)  
  
<a name="BKMK_MobileSpeed"></a>   
### Mobile app preparation is faster after customization  
 We made metadata generation improvements to reduce configuration times for mobile users after you customize your CRM system. The metadata package that's generated after you make customizations contains only the items that have changed. Instead of starting over if there's a problem downloading the metadata package, the download starts from where it left off the next time a user starts the app.  
  
<a name="BKMK_CompanyNews"></a>   
### Keep track of company news from a mobile device  
 The Company news and timeline solution lets users see the latest and most important news from [!INCLUDE[pn_bing](../includes/pn-bing.md)] news on their mobile devices. News articles are organized by time (Today, This Week, Last Week) and contain the headline, date/time, and source of the news article. Important events are detected and categorized, including management changes, earnings releases, new offerings, cost cutting, growth, legal issues, acquisitions, and partnerships.  
  
 You can use a new custom control to add and configure a news feed for the mobile apps.  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Get the Company news and social timeline for CRM for phones and tablets](http://go.microsoft.com/fwlink/p/?LinkId=789264)  
  
<a name="BKMK_OIDashboard"></a>   
### Preview feature: Organization Insights Dashboard shows system usage stats  
 Use the new Organization Insights Dashboard to get a quick overview of key areas (such as activity and usage) for your CRM Online instance. See views like the number of active users and form load times.  
  
 ![Organization Insights dashboard](../admin/media/organization-insights-dashboard-new-feature.png "Organization Insights dashboard")  
  
> [!NOTE]
>  The Organization Insights Dashboard is offered as a preview feature for CRM Online customers only. A preview feature is a feature that is not complete, but is made available before it's officially released so customers can get early access and provide feedback. Preview features aren't meant for production use, and may have limited or restricted functionality. Preview features must be [enabled by a CRM administrator](http://go.microsoft.com/fwlink/p/?LinkID=625975).  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Preview feature: View metrics about your instance with Organization Insights dashboard](https://technet.microsoft.com/library/mt703628.aspx)  
  
<a name="BKMK_CustomerField"></a>   
### Customer field for any entity  
 Previously, several out-of-the-box entities in [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)], such as the Case, Lead, and Opportunity, entities contained a field that represented a customer (account or contact). With this release, you'll be able to add the Customer field to any system or custom entity to track the customer information you need.  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create and edit fields](../customize/create-edit-fields.md)  
  
<a name="BKMK_India"></a>   
### New datacenter in India  
 We're opening a new datacenter in India. Once available, you can open new tenants or migrate existing tenants to this datacenter.  
  
<a name="BKMK_PackageDeployer"></a>   
### Package Deployer tool now runs from a command prompt  
 The Package Deployer tool has been expanded to run from a command prompt and it accepts a parameter that allows for more control over solution package deployment, including language selection and the option to preserve data. The [!INCLUDE[pn_ms_Windows_short](../includes/pn-ms-windows-short.md)][!INCLUDE[pn_PowerShell_short](../includes/pn-powershell-short.md)] cmdlets for the Package Deployer include the same enhanced functionality.  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use Package Deployer tool at the command line](https://technet.microsoft.com/library/dn647420.aspx)  
  
<a name="BKMK_RelevanceSearch"></a>   
### Preview feature: Display multi-entity search results in a single list by using Relevance Search  
 Relevance Search delivers fast and comprehensive search results in a single list, sorted by relevance. To boost performance, Relevance Search uses a dedicated search service external to [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)], powered by [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)]. As an administrator or customizer, you can enable and configure Relevance Search in the user interface without writing code. Many of the configuration steps will look familiar to you, since the user interface is similar to the Quick Find configuration.  
  
> [!NOTE]
>  Relevance Search is offered as a preview feature for CRM Online customers only. A preview feature is a feature that is not complete, but is made available before it's officially released so customers can get early access and provide feedback. Preview features aren't meant for production use, and may have limited or restricted functionality. Preview features must be [enabled by a CRM administrator](http://go.microsoft.com/fwlink/p/?LinkID=625975).  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Preview feature: Configure Relevance Search for the organization](../admin/configure-relevance-search-organization.md)  
  
## What’s new in CRM Online 2016  
  
-   [Improve performance with the Prepare Client Customizations button](../admin/what-s-new-for-administrators-and-customizers.md#BKMK_PrepareClientCustomizations)  
  
-   [Store and manage private documents in OneDrive for Business](../admin/what-s-new-for-administrators-and-customizers.md#BKMK_OneDriveForBusn)  
  
-   [Use pre-formatted Excel templates to quickly create Excel documents directly from Dynamics 365](../admin/what-s-new-for-administrators-and-customizers.md#BKMK_ExcelTemplates)  
  
-   [Create standardized documents with Word templates](../admin/what-s-new-for-administrators-and-customizers.md#BKMK_WordTemplates)  
  
-   [Use Office Delve to find relevant and trending documents](../admin/what-s-new-for-administrators-and-customizers.md#BKMK_Delve)  
  
-   [Preview mobile forms and dashboards before deploying to Dynamics 365 for phones and tablets](../admin/what-s-new-for-administrators-and-customizers.md#BKMK_MobilePreview)  
  
-   [Experience the new visual controls in Dynamics 365 for phones and tablets](../admin/what-s-new-for-administrators-and-customizers.md#BKMK_VisualControls)  
  
-   [Manage just about any device with Intune device management](../admin/what-s-new-for-administrators-and-customizers.md#BKMK_InTune)  
  
-   [Mobile apps now support iFrames and HTML web resources](../admin/what-s-new-for-administrators-and-customizers.md#BKMK_Frame)  
  
-   [Create a task flow in Dynamics 365 for phones and tablets (preview feature)](../admin/what-s-new-for-administrators-and-customizers.md#BKMK_MobileTaskFlows)  
  
-   [Customize interactive service hub dashboards and forms](../admin/what-s-new-for-administrators-and-customizers.md#BKMK_CustomizeInteractiveDashboards)  
  
-   [Use server-side synchronization to connect Dynamics 365 (online) to Exchange on-premises](../admin/what-s-new-for-administrators-and-customizers.md#BKMK_SSS)  
  
-   [Monitor mailbox health using improved server-side sync performance dashboard](../admin/what-s-new-for-administrators-and-customizers.md#BKMK_SSSDashboard)  
  
-   [Define business rules based on business process flows](../admin/what-s-new-for-administrators-and-customizers.md#BKMK_DefineBusinessRules)  
  
-   [Preview feature: Import bulk data with new Data Loader service](../admin/what-s-new-for-administrators-and-customizers.md#BKMK_DataLoader)  
  
-   [Solution segmentation provides tighter control for solutions exports and patches](../admin/what-s-new-for-administrators-and-customizers.md#BKMK_SolutionSegmentation)  
  
-   [New, improved Unified Service Desk](../admin/what-s-new-for-administrators-and-customizers.md#BKMK_USD)  
  
<a name="BKMK_PrepareClientCustomizations"></a>   
### Improve performance with the Prepare Client Customizations button  
 Once you publish customizations, the first user to start one of the CRM Online mobile apps or the interactive service hub can experience performance issues, because their sign in prompts CRM Online to prepare the metadata package for download. That means the first user has to wait for both the metadata package preparation and the download (subsequent users only have to wait for the download).  
  
 Now you can improve performance for that first user by clicking the **Prepare Client Customizations** button after publishing your customizations. This prompts CRM to prepare the metadata package right then instead of waiting for the first user to start a mobile app or the interactive service hub.  
  
 ![Prepare Client Customizations button](../admin/media/prepare-client-customizations-button.png "Prepare Client Customizations button")  
  
<a name="BKMK_OneDriveForBusn"></a>   
### Store and manage private documents in OneDrive for Business  
 Now your users can use the right storage option for the right situation. For example, store private documents using the new [!INCLUDE[pn_onedrive_for_business](../includes/pn-onedrive-for-business.md)] option. For collaborative storage, use [!INCLUDE[pn_office_365_groups](../includes/pn-office-365-groups.md)], and for documents you want to share with a larger group or company-wide, use [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)].  
  
> [!NOTE]
> [!INCLUDE[pn_onedrive_for_business](../includes/pn-onedrive-for-business.md)] is currently available in [!INCLUDE[pn_sharepoint_online](../includes/pn-sharepoint-online.md)] and coming to [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] on-premises with [!INCLUDE[pn_sharepoint_2016](../includes/pn-sharepoint-2016.md)].  
  
[!INCLUDE[proc_more_information](../includes/proc-more-information.md)]
  
- ![Video button](../admin/media/video-icon.PNG "Video button") [Watch a short video (2:39) about OneDrive for Business](http://go.microsoft.com/fwlink/p/?LinkID=724421)  
  
<a name="BKMK_ExcelTemplates"></a>   
### Use pre-formatted Excel templates to quickly create Excel documents directly from CRM Online  
 If your team frequently creates the same [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] documents over and over in CRM Online, use [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] templates to speed up document creation. For example, use a pre-formatted template to monitor sales and project cash flow (pipeline analysis) or forecast sales. After creating and uploading a template, share it with the team.  
  
 ![Dynamics 365 Excel templates](../admin/media/whats-new-2016-excel-templates.png "Dynamics 365 Excel templates")  
  
[!INCLUDE[proc_more_information](../includes/proc-more-information.md)]
  
- ![Video button](../admin/media/video-icon.PNG "Video button") [Watch a short video (2:38) about Excel templates](http://go.microsoft.com/fwlink/p/?LinkID=690134)  
  
-   [Analyze your data with Excel templates](http://go.microsoft.com/fwlink/p/?LinkID=691932)  
  
<a name="BKMK_WordTemplates"></a>   
### Create standardized documents with Word templates  
 Standard documents are a cornerstone of business dealings – from quotes and contracts to work orders and invoices. With this release, your users can create documents from standardized templates, and pull in CRM Online data at the same time. Use templates to enhance productivity, reduce human error, and ensure consistent communication across the company.  
  
[!INCLUDE[proc_more_information](../includes/proc-more-information.md)]
  
- ![Video button](../admin/media/video-icon.PNG "Video button") [Watch a short video (2:38) about Word templates](http://go.microsoft.com/fwlink/p/?LinkID=690134)  
  
-   [Using Word templates in CRM](http://go.microsoft.com/fwlink/p/?LinkID=691937)  
  
<a name="BKMK_Delve"></a>   
### Use Office Delve to find relevant and trending documents  
 [!INCLUDE[pn_office_delve](../includes/pn-office-delve.md)] proactively surfaces trending documents relevant to you and your work. Discover new content and make new connections right from a dashboard.  
  
 ![Office Delve dashboard in Dynamics 365](../admin/media/whatsnew-2016-delve-dashboard.png "Office Delve dashboard in Dynamics 365")  
  
[!INCLUDE[proc_more_information](../includes/proc-more-information.md)]

-![Videobutton](../admin/media/video-icon.PNG"Videobutton")[Watchashortvideo(2:39)aboutDelve](http://go.microsoft.com/fwlink/p/?LinkID=724421)
  
-   [Enable Office Delve](https://www.microsoft.com/en-us/dynamics/crm-customer-center/enable-office-delve.aspx)  
  
<a name="BKMK_MobilePreview"></a>   
### Preview mobile forms and dashboards  
 Now it’s easier to configure [!INCLUDE[pn_Mobile_Express_short](../includes/pn-mobile-express-short.md)] and tablets once and deploy everywhere. See how your changes will look on tablets and phones in the new mobile form and dashboard previewer.  
  
<a name="BKMK_VisualControls"></a>   
### Experience the new visual controls in Dynamics 365 for phones and tablets  
 Use new visual controls in [!INCLUDE[pn_Mobile_Express_short](../includes/pn-mobile-express-short.md)] and tablets to help mobile users enter [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] data faster, and to provide a richer visual experience. This set of custom controls includes sliders, switches, star ratings, video embedding, and a calendar control that you can use to give users a view of their activities in a calendar format instead of a list.  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Visual controls in Dynamics 365 for phones and tablets](../mobile-app/customize-phones-tablets.md#BKMK_VisualControls)  
  
<a name="BKMK_InTune"></a>   
### Manage just about any device with Intune device management  
 Use the  mobile apps in conjunction with [!INCLUDE[pn_microsoft_intune](../includes/pn-microsoft-intune.md)]. [!INCLUDE[pn_intune](../includes/pn-intune.md)] provides mobile management capabilities that allow you to encrypt, remotely wipe, and apply policies to your  mobile apps to comply with your company’s security policies. Encrypt data with [!INCLUDE[pn_intune](../includes/pn-intune.md)] on [!INCLUDE[tn_apple](../includes/tn-apple.md)], [!INCLUDE[tn_android](../includes/tn-android.md)], and [!INCLUDE[pn_ms_Windows_short](../includes/pn-ms-windows-short.md)] devices.  
  
[!INCLUDE[proc_more_information](../includes/proc-more-information.md)]

-![Videobutton](../admin/media/video-icon.PNG"Videobutton")[Watchashortvideo(3:54)aboutmanagingmobileappswithMicrosoftIntune](http://go.microsoft.com/fwlink/p/?LinkID=690154)
  
<a name="BKMK_Frame"></a>   
### Mobile apps now support iFrames and HTML web resources  
 You can now use iFrames and web resources in forms for mobile apps, just like you can in the CRM Online web app.  
  
> [!NOTE]
>  For [!INCLUDE[pn_ms_Windows_short](../includes/pn-ms-windows-short.md)] devices, you must be using [!INCLUDE[pn_windows_10](../includes/pn-windows-10.md)].  
  
[!INCLUDE[proc_more_information](../includes/proc-more-information.md)]
  
- ![Video button](../admin/media/video-icon.PNG "Video button") [Watch a short video (4:32) about mobile mashups](http://go.microsoft.com/fwlink/p/?LinkID=724424)  
  
-   [iFrame and web resource support](http://go.microsoft.com/fwlink/p/?LinkID=691943)  
  
<a name="BKMK_MobileTaskFlows"></a>   
### Preview feature: Create a task flow in CRM for phones and tablets  
 New task-based experiences are immersive experiences that allow users to focus on the tasks they need to do, not the records they need to interact with. With task-based experiences, you can bring data from multiple entities into a single user experience. For example, if users need to do a series of follow-up steps after client meetings, create a task flow.  
  
 ![Example of mobile task flow](../admin/media/mobile-task-flow.png "Example of mobile task flow")  
  
> [!NOTE]
>  Mobile task flows are offered as a preview feature for CRM Online. Preview features are subject to specific limitations. [Learn more about preview features.](http://go.microsoft.com/fwlink/p/?LinkID=625975)  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create a new task flow](http://go.microsoft.com/fwlink/p/?LinkID=690168)  
  
<a name="BKMK_CustomizeInteractiveDashboards"></a>   
### Customize interactive service hub dashboards and forms  
 Interactive service hub dashboards provide workload information across single and multiple streams and enable service personnel to take action directly from a dashboard.  
  
 ![Dynamics 365 interactive service hub](../admin/media/whats-new-2016-service-hub.png "Dynamics 365 interactive service hub")  
  
 You can choose from four layouts to customize these dashboards. For example, customize streams, charts, filters, and sortable filters. Or create all-new dashboards.  
  
 This release also introduces two new types of forms for the interactive service hub: Card and Main InteractionCentric.  
  
 By default, these new forms are available for selected out-of-the-box entities enabled for the interaction-centric design. These include:  
  
1.  Case  
  
2.  Account  
  
3.  Contact  
  
4.  Social Profile  
  
5.  Custom entity  
  
6.  Activities:  
  
    1.  Email  
  
    2.  Phone call  
  
    3.  Task  
  
    4.  Appointment  
  
    5.  Social Activity  
  
    6.  Custom Activity  
  
 You can customize these forms or create new interactive-centric forms for any new custom entity that’s enabled for the interactive design. Quick create and quick view forms are shared between the web client and the interactive service hub.  
  
 You can also customize the Reference Panel (related items) on interactive service hub forms by adding vertical tabs.  
  
> [!NOTE]
>  Upgrades aren’t supported for version 1 of the interactive service hub. When you upgrade , your service hub forms (for valid service hub entities) won’t automatically be upgraded to include all customizations that you make to web client forms for the same entity. For example, if you have customized the main case form in the web client, the service hub case main form will be the system-defined form—it will not include any customizations. You’ll need to make those customizations manually (provided those customizations are supported in version 1).  
  
[!INCLUDE[proc_more_information](../includes/proc-more-information.md)]
  
- ![Video button](../admin/media/video-icon.PNG "Video button") [Watch a short video (3:34) about the interactive service hub](http://go.microsoft.com/fwlink/p/?LinkID=690166)  
  
-   [Configure interactive experience dashboards](../customize/configure-interactive-experience-dashboards.md)  
  
-   [Interactive service hub dashboards and forms help you prioritize workloads](http://go.microsoft.com/fwlink/p/?LinkID=625970)  
  
<a name="BKMK_SSS"></a>   
### Use server-side synchronization to connect CRM Online to Exchange on-premises  
 If you currently use CRM Online and [!INCLUDE[pn_Exchange](../includes/pn-exchange.md)] on-premises, and you synchronize email, appointments, contacts, and tasks with Dynamics CRM for Outlook, or if you synchronize email with the Email Router, you can now synchronize email, appointments, contacts, and tasks by using server-side synchronization.  
  
 ![Supported combinations of Dynamics 365 and server&#45;side sync](../admin/media/hybrid-server-side-sync.png "Supported combinations of Dynamics 365 and server-side sync")  
  
<a name="BKMK_SSSDashboard"></a>   
### Monitor mailbox health using improved Server-Side Synchronization Performance dashboard  
 If your organization uses server-side synchronization for email processing, you can use the improved Server-Side Synchronization Performance dashboard to monitor the health of mailboxes in your organization, and quickly troubleshoot problems.  
  
 ![Server&#45;side Synchronization Performance dashboard](../admin/media/server-side-sync-performance-dashboard.png "Server-side Synchronization Performance dashboard")  
  
<a name="BKMK_DefineBusinessRules"></a>   
### Define business rules based on business process flows  
 In a previous release, we enabled powerful scenarios where business logic could be executed based on the business process and stage. However, to use this functionality, you needed to write [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)]. By enabling rules to be defined based on the currently active process, the active stage, its category, or the selected stage, business logic can now be defined by business analysts. It’s much less costly to define these rules through the user interface and you can make updates to business logic more frequently to keep up with the pace of an ever-adapting business.  
  
<a name="BKMK_DataLoader"></a>   
### Preview feature: Import bulk data with the new Data Loader service  
 Use the new [!INCLUDE[cc_data_loader_service](../includes/cc-data-loader-service.md)] (accessed from a link in the CRM Online Admin Center) to import bulk data into CRM Online. Upload large data files to cloud staging tables where you can perform light data quality functions, and then push the data to CRM Online. This service also supports recurring data imports.  
  
> [!NOTE]
>  The [!INCLUDE[cc_data_loader_service](../includes/cc-data-loader-service.md)] is offered as a preview feature for CRM Online. Preview features are subject to specific limitations. [Learn more about preview features.](http://go.microsoft.com/fwlink/p/?LinkID=625975)  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Learn more about the Data Loader service](http://go.microsoft.com/fwlink/p/?LinkID=715719)  
  
<a name="BKMK_SolutionSegmentation"></a>   
### Solution segmentation provides tighter control for solutions exports and patches  
 With solution segmentation, you can export solutions with selected entity components, such as attributes, forms, or views, rather than entire entities with all the components. This will provide a tighter control over what you distribute in solutions and solution patches. You don’t have to write any code to create segmented solutions.  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use segmented solutions and patches to simplify solution updates](../customize/use-segmented-solutions-patches-simplify-updates.md)  
  
<a name="BKMK_USD"></a>   
### New, improved Unified Service Desk  
 [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] provides an agent desktop with information from CRM Online and third-party applications in a combined user interface. Improvements in [!INCLUDE[pn_unified_service_desk_20](../includes/pn-unified-service-desk-20.md)] include:  
  
-   An improved installation and deployment experience  
  
-   Support for OAuth  
  
-   Ability to integrate with third-party telemetry systems and analytics systems such as [!INCLUDE[pn_azure_hdinsight](../includes/pn-azure-hdinsight.md)]  
  
-   Improved administration and agent experience  
  
-   Performance and stability improvements  
  
[!INCLUDE[proc_more_information](../includes/proc-more-information.md)]
  
-   [What's new in Unified Service Desk](https://technet.microsoft.com/library/dn798673.aspx)