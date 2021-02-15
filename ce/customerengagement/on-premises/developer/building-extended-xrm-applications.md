---
title: "Dynamics 365 Customer Engagement application platform for building extended xRM applications (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Dynamics 365 Customer Engagement offers customers, partners, independent software vendors (ISVs), and systems integrators (SIs), a powerful platform for building line-of-business applications. These applications are often referred to as Extended Dynamics 365 Customer Engagement applications (xRM) applications because they leverage the relationship tracking capabilities beyond the typical customer relationship management (CRM) scenarios. "
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: get-started-article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 00564289-496e-4fd1-85c6-5e2d354a2f4d
caps.latest.revision: 18
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer

---
# Application platform for building extended xRM applications

Dynamics 365 Customer Engagement (on-premises) offers customers, partners, independent software vendors (ISVs), and systems integrators (SIs), a powerful platform for building line-of-business applications. These applications are often referred to as *Extended Dynamics 365 Customer Engagement (on-premises)* applications (*xRM*) applications because they leverage the relationship tracking capabilities beyond the typical customer relationship management (CRM) scenarios. These applications span across various industries including [Retail](https://www.microsoft.com/dynamics/retail.aspx), [Service industries](https://www.microsoft.com/dynamics/service-industries.aspx), [Manufacturing](https://www.microsoft.com/dynamics/manufacturing.aspx), [Distribution](https://www.microsoft.com/dynamics/distribution), [Financial services](https://www.microsoft.com/dynamics/crm-financial-services.aspx), and [Public sector](https://www.microsoft.com/dynamics/public-sector.aspx).  
  
 Dynamics 365 Customer Engagement (on-premises) includes additional capabilities for Operations and Financials. For developer documentation using these capabilities, see:  
  
-   [Dynamics 365 Customer Engagement (on-premises) Operations developer documentation](https://docs.microsoft.com/dynamics365/)  
  
-   [Dynamics 365 Customer Engagement (on-premises) Financials developer documentation](https://docs.microsoft.com/dynamics365/)  
  
## What does xRM mean for a developer?  
 Business applications typically model and track connections between various types of business data (people, places, and things). Dynamics 365 Customer Engagement (on-premises) provides for declarative development of relational business applications with flexible data models and dynamic services. In addition to  the declarative application capabilities, business applications built on [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] can be extended and integrated with external systems through a rich Software Development Kit (SDK).  
  
### Rapid application development  
 These days there is little time to write a lot of custom code to deliver solutions. To meet requirements for business applications you need a framework that provides the agility and flexibility to rapidly adapt to changes and get user acceptance and adoption.  
  
### You get a user interface ready for international use  
 Dynamics 365 Customer Engagement (on-premises) provides a user experience optimized for interacting with relational data. Users can navigate to, view, edit, report, and take action on their data using modern web and mobile applications available on iOS, [!INCLUDE[tn_android](../includes/tn-android.md)], and Windows. These applications have the ability to guide users through a business process and rules from start to finish. This user experience provides a common and consistent interaction model for a user who uses multiple business applications.  
  
 The Dynamics 365 Customer Engagement (on-premises) application supports many international languages and currencies. Your application inherits all these capabilities.  
  
### You get an extensible data and security model  
 Dynamics 365 Customer Engagement (on-premises) enable you to extend the out-of-the-box data model to meet the data storage and tracking needs of your business application. You can disable elements of this data model if they don’t apply to your business application. The data model is protected by an extensible security model to apply role, record and field level, as well as hierarchical security. All other aspects of the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] platform and user experience are driven by the data and security model you define. In this way, users only see and have access to the data and actions you choose.  
  
 Organizations can also add their own data elements and security to work seamlessly on top of the data model used by your application. Or other ISVs or SIs can build solutions on top of yours, just as yours is built on top of the default [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] data and security model.  
  
### You get extensible business logic  
 Defining and enforcing consistent business processes is one of the main reasons people use Dynamics 365 Customer Engagement (on-premises). You can use Dynamics 365 Customer Engagement (on-premises) to define and enforce consistent business processes and rules for your application.
  
 Organizations that use your application can modify or extend your default application business logic without writing code.  
  
### You get [!INCLUDE[pn_MS_Office_365](../includes/pn-ms-office-365.md)] integration  
 [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)] provides so many additional options to work with your application. With your application people will be able to:  
  
- Integrate with [!INCLUDE[pn_Exchange](../includes/pn-exchange.md)] and [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)] for email tracking, scheduling and task management.  
  
- Initiate instant messaging and phone calls with [!INCLUDE[pn_skype_for_business](../includes/pn-skype-for-business.md)].  
  
- Use [!INCLUDE[pn_power_bi_for_office_365_short](../includes/pn-power-bi-for-office-365-short.md)] to analyze data.  
  
- Edit data with [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)].  
  
- Take rich contextual notes with [!INCLUDE[pn_onenote](../includes/pn-onenote.md)].  
  
- Create personalized documents as a team with automatic document generation and real-time co-authoring.  
  
- Manage contextual documents across [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)], [!INCLUDE[pn_office_365_groups](../includes/pn-office-365-groups.md)], and [!INCLUDE[pn_onedrive_for_business](../includes/pn-onedrive-for-business.md)].  
  
- Get relevant content with [!INCLUDE[pn_office_delve](../includes/pn-office-delve.md)] based on what they're working on and who they're working with.  
  
### You get cross-platform mobile applications  
 The [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] mobile apps download metadata about your data model, security configuration, business processes and rules, transforming the out-of-the-box experience into a customized mobile app for your application.  
  
### You get business intelligence  
 People using your application will be able to gain insight into your business and proactively anticipate business needs.  
  
 They will be able to use [!INCLUDE[pn_power_bi_for_office_365_short](../includes/pn-power-bi-for-office-365-short.md)], interactive dashboards and reports, advanced visualizations, and natural language Q&A. People will have visibility into business performance with at-a-glance dashboards and contextual charts inside your business application.  
  
### You can build on top of the platform  
 The web services built into [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] allow developers familiar with standards based web technologies to extend and integrate their business applications built on Dynamics 365 Customer Engagement (on-premises) using HTML, [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)], and CSS, and the [!INCLUDE[pn_NET_Framework](../includes/pn-net-framework.md)]. [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] expose the same end user and administrative capabilities you've seen in the UI through a RESTful web service API built on open standards including OAuth 2.0 and OData v4. Because [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] embraces web standards, external systems can integrate with your business application built on [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] using their platform and languages of choice.  
  
## Learn more about building extended Dynamics 365 Customer Engagement (on-premises) (xRM) solutions  
 View these videos to learn more:  
  
 [Building xRM Solutions I: Introduction](https://youtu.be/GI54dCi2sIg)  
 Dynamics 365 Customer Engagement (on-premises) app capabilities can be leveraged to build line of business applications, managing any relationship and interaction versus customer relationships and interactions.  In this video, we’ll walk through  the capabilities within Dynamics 365 Customer Engagement (on-premises) application platform, including:  
  
- Rapid application development  
  
- Business process management  
  
- Business intelligence  
  
- User experience  
  
  [Building xRM Solutions II: Configuration](https://youtu.be/MC2NaanB5Mk)  
  In this video, the terms configuration and customization are used interchangeably                          and refer to an iterative process of defining the data model, security model, navigation, forms and views, business process flows, business rules, business process automation, and solution packaging.  
  
  [Building xRM Solutions III: Code](https://youtu.be/c-TrDYQ6VQY)  
  In this video, we’ll cover four main concepts to consider when extending Dynamics 365 Customer Engagement (on-premises) to build a xRM solution:
  
- Client extensions  
  
- Server extensions  
  
- Integration  
  
- Custom user experiences  
  
## Related documentation  
 User interface ready for international use  
 -   [Create solutions that support multiple languages](create-solutions-support-multiple-languages.md)  
  
- [Export Customized Entity and Field Text for Translation](../customize/export-customized-entity-field-text-translation.md)  
  
  Extensible security model  
  -   [Security concepts for Dynamics 365 Customer Engagement (on-premises)](../admin/security-concepts.md)  
  
- [The security model of Dynamics 365 Customer Engagement (on-premises)](security-dev/security-model.md)  
  
  Extensible data model  
  -   [Model your business data in Dynamics 365 Customer Engagement (on-premises)](model-business-data.md)  
  
- [The metadata and data models in Dynamics 365 Customer Engagement (on-premises)](metadata-data-models.md)  
  
  Extensible business logic  
  -   [Guide staff through common tasks with processes](../customize/guide-staff-through-common-tasks-processes.md)   
- [Write workflows to automate business processes](automate-business-processes-customer-engagement.md)  
  
- [Write plug-ins to extend business processes](write-plugin-extend-business-processes.md)  
  
  [!INCLUDE[pn_MS_Office_365](../includes/pn-ms-office-365.md)] integration  
  
- [Extend Dynamics 365 Customer Engagement (on-premises)](../admin/extend.md)  
  
- [Integrate Dynamics 365 Customer Engagement (on-premises) with SharePoint](integration-dev/integrate-sharepoint.md)  
  
- [Integrate Dynamics 365 Customer Engagement (on-premises) with OneNote](integration-dev/integrate-onenote.md)  
  
  Cross-platform mobile applications  
  [User Guide (Dynamics 365 for phones and tablets)](../../../mobile-app/dynamics-365-phones-tablets-users-guide.md)
  
  <!-- Business intelligence  
  [Use Power BI with Dynamics 365 Customer Engagement (on-premises)](../admin/use-power-bi.md)  -->
  
  Extensible platform  
  -   [Extend Dynamics 365 Customer Engagement (on-premises) on the server](extend-dynamics-365-server.md)  
  
- [Extend Dynamics 365 Customer Engagement on the client](extend-client.md)  
  
- [Customize Dynamics 365 Customer Engagement applications](customize-dev/customize-applications.md)  
  
- [Package and distribute extensions using solutions](package-distribute-extensions-use-solutions.md)  
  
### See also  
 [Supported extensions for Dynamics 365 Customer Engagement (on-premises)](supported-extensions.md)   
 [The metadata and data models in Dynamics 365 Customer Engagement (on-premises)](metadata-data-models.md)   
 [Extend Dynamics 365 Customer Engagement (on-premises) on the server](extend-dynamics-365-server.md)   
 [Extend Dynamics 365 Customer Engagement (on-premises) on the client](extend-client.md)   
 [Customize Dynamics 365 Customer Engagement applications](customize-dev/customize-applications.md)   
 [Package and distribute extensions using solutions](package-distribute-extensions-use-solutions.md)    
 [Extend Dynamics 365 Customer Engagement (on-premises) for Outlook](extend-customer-engagement-outlook.md)   
 [Integrate Dynamics 365 Customer Engagement (on-premises) with SharePoint](integration-dev/integrate-sharepoint.md)   
 [Integrate Dynamics 365 Customer Engagement (on-premises) with OneNote](integration-dev/integrate-onenote.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]