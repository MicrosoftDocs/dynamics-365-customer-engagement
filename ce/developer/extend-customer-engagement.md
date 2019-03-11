---
title: "Extend Dynamics 365 for Customer Engagement apps (Developer Guide for Dynamics 365 for Customer Engagement apps) | MicrosoftDocs"
description: "Understand the different ways you can write code to change how a Dynamics 365 for Customer Engagement apps system works, build your own application using it, or integrate the system with other products."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: get-started-article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: 156dadf2-e2bf-496c-8d72-a94e71469fb1
caps.latest.revision: 17
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Extend Dynamics 365 for Customer Engagement apps

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

The extensibility platform is the heart of [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps. When you use the [!INCLUDE[cc-dyn365-ce-web-services](../includes/cc-dyn365-ce-web-services.md)], you are building on top of this system. The [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps platform supports several types of deployments with the power of choice: [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] apps, [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps installed on your own server (on-premises), or a hosted deployment of [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps. The security model protects the platform from unauthorized access across the Web.  
  
[!INCLUDE[cc_sdk_onpremises_note](../includes/cc-sdk-onpremises-note.md)] 

When you develop an application that uses the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] server, you use Web services to communicate with the underlying xRM platform layer. [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps use a metadata driven architecture to provide the flexibility to create custom entities and additional system entity attributes and also to make upgrades and enable transportation of solutions easier. This allows for changes in the data structure without requiring any change to code in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps.  
  
 The xRM platform does not impose business-specific logic. This layer imposes only generic constraints such as security. It contains the building blocks for an application, but by itself is nothing more than a collection of related objects. However, the interaction between those objects is used to implement more extensible logic such as the quote-to-order-to-invoice processing and pricing logic.  
  
 The xRM platform also controls access to data through security, controls access to the database, and raises events for workflow processes and custom business logic implementations (plug-ins). The platform layer provides for both incoming and outgoing email processing through [!INCLUDE[pn_Exchange_Server_full](../includes/pn-exchange-server-full.md)].
  
 ![Dynamics 365 for Customer Engagement apps SDK architecture](media/crm-v5s-architecture.png "Dynamics 365 for Customer Engagement apps SDK architecture")  
  
## In This Section  
 [Dynamics 365 for Customer Engagement application platform - A platform for building extended Dynamics 365 for Customer Engagement (xRM) applications](building-extended-xrm-applications.md)  
 [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps provides a powerful platform for building line-of-business applications. These applications are often referred to as Extended CRM (xRM) applications because they leverage the relationship tracking capabilities beyond the typical customer relationship management (CRM) scenarios. This topic introduces  resources to learn more about this capability.  
  
 [Supported Extensions for Dynamics 365 for Customer Engagement apps](supported-extensions.md)  
 When you create extensions it is important that you choose to implement them in a supported way. This protects your investment by helping to insure that you can upgrade to new releases of [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps and use the latest capabilities as they are released. This topic describes which extensions are supported and which are not.  
  
 [The Metadata and Data Models in Dynamics 365 for Customer Engagement](metadata-data-models.md)  
 [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps use a metadata driven architecture to provide the flexibility to create custom entities and additional system entity attributes. This structure also makes upgrades and the transportation of customizations easier. The data structure can change without requiring any change to code in the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] server or client applications.  
  
 Topics in this section describe how you can easily view the metadata, create and edit metadata with code, and query metadata to create dynamic applications which react to changes or metadata differences found in separate organizations.  
  
 [Extend Dynamics 365 for Customer Engagement on the server](extend-customer-engagement.md)  
 This section describes capabilities to extend [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps on the server. Compared to extensions you can apply on the client, extensions performed on the server are applied consistently regardless of the client application used to interact with the platform. Whenever possible, extensions which apply business logic should be applied on the server.  
  
 Topics in this section describe how to deploy custom business logic using plug-ins, processes, the asynchronous service, Azure extensions and more.  
  
 [Extend Dynamics 365 for Customer Engagement apps on the client](extend-client.md)  
 This section contains information about changes developers and customizers can make to extend [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps within the clients provided for [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)]: web application, [!INCLUDE[pn_Microsoft_Dynamics_CRM_Mobile](../includes/pn-dyn-365-phones.md)], and [!INCLUDE[pn_moca_full](../includes/pn-moca-full.md)] . You apply these extensions by using [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] and web resources. These clients are designed to allow you to add extensions which can be applied for all clients rather than each one separately.  
  
 Client extensions can provide a very rich and responsive experience for users because the code runs on their device. However, critical business logic should not be applied only by client-side scripts. Unlike extensions that are applied on the server, client extensions cannot apply business logic for data entering the system by other means, such as integrations with other systems, custom clients, or data import.  
  
 [Customize Dynamics 365 for Customer Engagement applications](customize-dev/customize-applications.md)  
 [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] client applications include the web application, [!INCLUDE[pn_Microsoft_Dynamics_CRM_Mobile](../includes/pn-dyn-365-phones.md)], and [!INCLUDE[pn_moca_full](../includes/pn-moca-full.md)]. Each of these clients reference a common set of data that controls visual elements of the clients. This *application metadata* is usually edited using customization tools in the application or third-party tools. Other clients can also reference this application metadata if they want to leverage configuration options defined for specific organizations.  
  
 For an in-depth guide to customization by using the tools available in the web application see the [Customization Guide](../customize/overview.md). The topics in this section describe the structure of the data edited by those tools or third-party tools.  
  
 [Package and distribute extensions using solutions](package-distribute-extensions-use-solutions.md)  
 Solutions give you a framework for packaging, installing, and uninstalling components that provide specific business functionality. Solutions are used by ISVs and other [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps solution providers to distribute extensions they create, but you will also use them to transfer customizations between different organizations you may use in your development process, such as separate development, test, and production organizations.  
  
 [Extend Dynamics 365 for Outlook](extend-customer-engagement-outlook.md)  
 [!INCLUDE[pn_microsoft_dynamics_crm_for_outlook](../includes/pn-microsoft-dynamics-crm-for-outlook.md)] let users interact with data while they’re offline and not connected to a server. [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] includes features that let you extend your solutions to offline scenarios by calling the web services offline from your custom code. In addition, the <xref:Microsoft.Crm.Outlook.Sdk> assembly provides programmatic support for basic [!INCLUDE[pn_MS_Outlook_Short](../includes/pn-ms-outlook-short.md)] actions such as synchronization, going offline or online, and [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] state verification. Offline programming uses the [!INCLUDE[pn_ms_asp_net_development_server](../includes/pn-ms-asp-net-development-server.md)].  
  
 [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps include features that allow administrators to customize and manage filters for their users. Filter templates provide the starting point for entity synchronization on [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)]. Filters determine which entity collections are synchronized to [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)] and to [!INCLUDE[pn_MS_SQL_Express](../includes/pn-ms-sql-express.md)] for offline-enabled [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] solutions.  
  
 [Integrate Dynamics 365 for Customer Engagement apps with SharePoint](integration-dev/integrate-sharepoint.md)  
 [!INCLUDE[pn_ms_sharepoint_server](../includes/pn-ms-sharepoint-server.md)] is a collaboration and content management application that simplifies how people store, find, and share information. It helps people to collaborate effectively by having secure access to documents and information that they require to make business decisions.  
  
 The [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] apps integration feature enables you to store and manage documents on [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] apps in the context of a [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps record, and use the [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] apps document management abilities in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps, such as checking the document in and out, viewing version history, and changing document properties.  
  
 [Integrate Dynamics 365 for Customer Engagement apps with OneNote](integration-dev/integrate-onenote.md)  
 Set up [!INCLUDE[pn_onenote](../includes/pn-onenote.md)] Integration in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps so that a dedicated [!INCLUDE[pn_onenote](../includes/pn-onenote.md)] notebook is automatically created for the selected entity records in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] apps. This feature provides you the ability to easily take notes in the context of a Dynamics 365 for Customer Engagement apps record in various formats such as pictures, drawings, formatted text (bullet points and tables), and voice recordings in a OneNote notebook. You can access the OneNote notebook directly on the activity wall in the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps web client or from the record form in the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] mobile apps.  
  
## Related Sections  
[Release history](release-history.md)<br />
[What's new for developers: Dynamics 365 for Customer Engagement apps](whats-new-developers.md)<br />
[Start here](get-started-sdk.md)<br />
[Connect to Dynamics 365 for Customer Engagement apps](connect-customer-engagement.md)<br />
[The Security Model of Dynamics 365 for Customer Engagement apps](security-dev/security-model.md)<br />
[Model your business data](model-business-data.md)<br />
[Manage Your Data](manage-data.md)<br />
[Manage your deployment](manage-deployment.md)<br />
[Sample code directory](sample-code-directory.md)<br />
[Programming Reference](programming-reference.md)<br />