---
title: "Customize SiteMaps (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The SiteMap provides the structure for navigation in Dynamics 365 Customer Engagement. The SiteMap entity stores information about the site map, and the SiteMap.SiteMapXml attribute stores the XML that defines the site map."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 54f00cc7-0653-423d-abe0-5344ad3711c3
caps.latest.revision: 14
author: KumarVivek
ms.author: kvivek
search.audienceType: 
  - developer

---
# Customize SiteMaps

The SiteMap provides the structure for navigation in [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)]. The `SiteMap` entity stores information about the site map, and the `SiteMap.SiteMapXml` attribute stores the XML that defines the site map. The site map XML is exposed as the `SiteMap` node in the              customizations.xml file of an exported unmanaged solution.  
  
 The structure of navigation defined in the site map XML is  evaluated together with your security privileges to display navigation options in the application. If your security privileges do not provide read access to an entity specified in the site map XML, the navigation option will not be displayed to you.  
  
 With the introduction of modular business apps in the [!INCLUDE[pn_crm_8_2_0_online](../../includes/pn-crm-8-2-0-online.md)], where each app has its own custom navigation and elements defined, there are two types of site maps now available in [!INCLUDE[pn_dyn_365](../../includes/pn-dyn-365.md)]:  
  
- Default site map that contains the navigation information for the default app (**[!INCLUDE[pn_dyn_365](../../includes/pn-dyn-365.md)] - custom**). This site map controls the navigation for your default [!INCLUDE[pn_dyn_365](../../includes/pn-dyn-365.md)] instance.  
  
- App-specific site maps that contain navigation information for a modular business app.  
  
  You can use the `SiteMap.IsAppAware` attribute to distinguish between the two types of site maps: 0 indicates the default site map; 1 indicates the app-specific site map.  
  
  You can edit the default and app-specific site maps to change the application navigation, edit labels, add or change icons, or add or remove elements. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Change application navigation using the SiteMap](change-application-navigation-using-sitemap.md)
  
  You can use a site map editor or programmatically update site map. 
  
## In This Section  
 [Change application navigation using the SiteMap](change-application-navigation-using-sitemap.md)  
  
 [Pass parameters to a URL using the SiteMap](pass-parameters-url-using-sitemap.md)   
  
 [SiteMap schema](sitemap-schema.md)  
  
### See also  
 [Customize Microsoft Dynamics 365 Customer Engagement applications](customize-applications.md)   
 <!--[Define access permission for modular business apps in Dynamics 365 Customer Engagement](../create-manage-business-apps.md) -->


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]