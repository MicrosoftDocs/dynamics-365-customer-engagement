---
title: "Customize the Help experience in Dynamics 365 Customer Engagement | MicrosoftDocs"
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
ms.assetid: 23ce096e-5950-4afb-8aef-a6eaf313bf88
caps.latest.revision: 28
ms.author: "rdubois"
manager: "brycho"
---
# Create custom Help
[!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] has a knowledge base application built in for online help. This help is hosted on the [Dynamics 365 documentation](https://docs.microsoft.com/dynamics365/) site, a central location where users can find articles, videos, eBooks, best practices, and tips regarding topical issues.  
  
 In addition to the built-in help, [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] offers customizable help and tooltips to provide contextual information to users filling in forms. You can replace default Help with the custom Help of your choice, at the global (organization) level or entity level. Custom Help makes the content exposed through the Help links more relevant to the user’s day-to-day activities. With a single, global URL you can override the out-of-the-box Help links for all customizable entities. Per entity URLs override the out-of-the-box Help links on grids and forms for a specific customizable entity. You can include additional parameters in the URL, such as language code and entity name. These parameters allow a developer to add functionality to redirect the user to a page that’s relevant to their language or the entity context within the application. The entity level custom Help settings are solution aware, therefore you can package them as a part of the solution and transport them between organizations or distribute them in solutions. Custom tooltips provide the ability to set the text that appears as a tooltip when the field is displayed in a form. Tooltips are also solution aware. For more information about tooltips, view: [Video: Customizable tooltips](http://www.youtube.com/watch?v=7oqtyF6FA8E&list=PLC3591A8FE4ADBE07&index=5)  
  
> [!NOTE]
>  Customizable Help is not available in [!INCLUDE[pn_moca_full](../includes/pn-moca-full.md)].  
  
 **Example of a custom URL at a global level**  
  
 You have a dynamic Help server to serve the Help content for the custom entities. Your solution almost entirely consists of the custom entities. You can specify the . aspx page that points to the Help server and pass the parameters in the URL. You can program the Help server to display the correct Help page based on the parameters passed.  
  
 **Example of a custom URL at an entity level**  
  
 You have a static set of Help webpages for the custom entities and customized out-of-the box (OOB) system entities. For example, you have added only two or three custom entities and heavily customized the opportunity entity. The rest of the OOB system entities remained unchanged. In this case, you can override the Help content for the custom entities and the `Opportunity` entity and use the default Help for the rest of the entities in your system.  
  
## Where to find help when you design your custom Help  
 When you build your own custom Help, check out the [Training & Adoption Kit for Microsoft Dynamics 365](http://go.microsoft.com/fwlink/p/?LinkID=395151). It contains a lot of ready-made material that you can use straight from the kit, or customize it. The Training & Adoption Kit includes eBooks for end users and administrators, user guides and quick references. ![Video button](../customize/media/video-icon.PNG "Video button")[Watch a short video on how to customize the training material in the training and adoption kit](http://go.microsoft.com/fwlink/p/?LinkId=837813).  
  
## Set up customizable Help  
 As an administrator, you can use the settings to override default Help at the global level.  
  
1. [!INCLUDE[proc_settings_administration](../includes/proc-settings-administration.md)]  
  
2. Click the **System settings** > **General** tab, as shown here.  
  
   ![Global custom Help in Dynamics 365](../customize/media/admin-global-help-url.PNG "Global custom Help in Dynamics 365")  
  
   To override the default Help for an entity, use the settings in **[!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]**.  
  
4. [!INCLUDE[proc_settings_customization](../includes/proc-settings-customization.md)]  
  
5. Click the **Customize the system** > **Components** > **Entity** > **General** tab. You must first enable custom Help at the global level.  
  
   ![Entity level custom Help in Dynamics 365](../customize/media/admin-entity-help-url.PNG "Entity level custom Help in Dynamics 365")  
  
   To append the parameters to a URL, set **Append Parameters to URL** in the **System settings** > **General** tab to **Yes**. Specify the parameters that will be attached to the URL:  
  
   -  User Language Code: `userlcid`  
  
   -  Entity Name: `entity`  
  
   -  Entry Point: `hierarchy chart` or `form`  
  
   -  Form Id: `formid`  
  
### See also  
 [Customize your Dynamics 365 system](../customize/customize-your-system.md)    
 [Community blog: CRM 2015 – Custom Help Content](http://community.dynamics.com/crm/b/sonomapartners/archive/2015/02/13/crm-2015-custom-help-content.aspx)   
 [Custom help options (Dynamics 365 SDK)](https://msdn.microsoft.com/library/dn817897.aspx)   
 [Use web resources to provide help content (Dynamics 365 SDK)](https://msdn.microsoft.com/library/dn817897.aspx)
