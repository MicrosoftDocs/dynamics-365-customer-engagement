---
title: "Sample: Android Activity Tracker for Dynamics 365 for Customer Engagement apps and Web API (Developer Guide for Dynamics 365 for Customer Engagement apps)| MicrosoftDocs"
description: "The activity tracker sample application enables you to connect to your Dynamics 365 for Customer Engagement apps organization, query for your contacts, and add a quick activity record related to a contact."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: 3dc792cf-a9c4-45ea-9efe-895f15ade167
caps.latest.revision: 9
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Android Activity Tracker for Dynamics 365 for Customer Engagement apps and Web API

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

This sample code is for [!INCLUDE[pn_crm_8_2_0_both](../includes/pn-crm-8-2-0-both.md)] or later.              This code can be found at the following location on Github:              [https://github.com/DynamicsCRM/Android-Activity-Tracker-for-Dynamics-CRM-Web-API](https://github.com/DynamicsCRM/Android-Activity-Tracker-for-Dynamics-CRM-Web-API).  
  
## Requirements  
 This sample requires the [!INCLUDE[pn_win_azure_ad_auth_lib_adal](../includes/pn-win-azure-ad-auth-lib-adal.md)] and other packages. These packages are automatically downloaded and installed when you load the project’s solution. For this to work, you must have an active internet connection when loading and building the sample.  
  
 In addition to having access to a [!INCLUDE[pn_dyn_365](../includes/pn-dyn-365.md)] Customer Engagement organization to run the sample against, you will also need either a [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)] subscription for use with [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] or an ADFS administration account for use with [!INCLUDE[pn_crm_op_edition](../includes/pn-crm-onprem.md)] (IFD).  
  
 This sample requires Android Studio 2, JDK 1.8.0, Android 6.  
  
## Demonstrates  
  
|                                                                                               |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
|-----------------------------------------------------------------------------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| ![Activity Tracker app for Android](media/android-app.png "Activity Tracker app for Android") | The activity tracker sample application enables you to connect to your [!INCLUDE[pn_dyn_365](../includes/pn-dyn-365.md)] organization, query for your contacts, and add a quick activity record related to a contact.<br /><br /> Use this sample’s source code as a starting point to build your own apps that can access the CRM web services. This sample uses the [!INCLUDE[pn_win_azure_ad_auth_lib_adal](../includes/pn-win-azure-ad-auth-lib-adal.md)], and the Web API (OData v4 protocol).<br /><br /> For this code to work, you must first register your app with a supported identity provider ( [!INCLUDE[pn_adfs_short](../includes/pn-adfs-short.md)] or [!INCLUDE[pn_microsoft_azure_active_directory](../includes/pn-microsoft-azure-active-directory.md)]). For more information on registering an app with [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)], see                                  [Walkthrough: Register an app with Active Directory](walkthrough-register-app-active-directory.md). For more detailed information on the sample and instructions on how to build and run it, see the app’s                                  [README](https://github.com/DynamicsCRM/Android-Activity-Tracker-for-Dynamics-CRM-Web-API/blob/master/README.md). |
  
### See also  
 [Write mobile and modern apps](write-mobile-modern-apps.md)   
 [Dynamics 365 for Customer Engagement on Github](https://github.com/DynamicsCRM)   
 [OData.org](http://www.odata.org/)
