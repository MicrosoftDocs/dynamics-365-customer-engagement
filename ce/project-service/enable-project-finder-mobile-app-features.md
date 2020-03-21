---
title: Enable Project Finder Mobile app features 
description: How to enable Project Finder Mobile app features for Project Service
author: JohnPBurrows
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-projectservice
ms.date: 8/03/2018
ms.topic: article
ms.prod: 
ms.technology: 
ms.author: jburrows
audience: Admin
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365PS
---
# Enable Project Finder Mobile app features (Project Service)

[!INCLUDE[cc-applies-to-psa-app-1x-2x](../includes/cc-applies-to-psa-app-1x-2x.md)]

Your resources can use the Project Finder Mobile app on their phone with [!INCLUDE[pn_project_service_auto](../includes/pn-project-service-auto.md)] to find new projects to work on and update their skill sets.  
  
 The app is available for [!INCLUDE[tn_Apple_iphone](../includes/tn-apple-iphone.md)], [!INCLUDE[tn_android](../includes/tn-android.md)] phones, and [!INCLUDE[pn_windows_phone](../includes/pn-windows-phone.md)].  
  
 You need to set a couple of options in the parameters setting for your organizational unit to allow users to view projects' resource requirements and update their skills.  
  
> [!NOTE]
>  The Project Finder Mobile app only works with [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)], not with on-premises installations.  
  
1. Go to **Project Service > Parameters**.  
  
2. Click the parameters setting you want to use for allowing the Project Finder Mobile app features.  
  
3. In the **General** area, set **Resource requirements visible to resources** to **Yes**.  
  
4. Set **Allow skill update by resource** to **Yes**.  
  
   ![ProjectService&#95;ProjectFinderEnable](../project-service/media/project-service-project-finder-enable.png "ProjectService_ProjectFinderEnable")  
  
   This is a global setting. Project managers can set whether an individual project will be visible on that project's **Project Team** page.  
  
   ![ProjectService&#95;ProjectTeamVisible](../project-service/media/project-service-project-team-visible.png "ProjectService_ProjectTeamVisible")  
  
## Email notifications  
 [!INCLUDE[pn_project_service_auto](../includes/pn-project-service-auto.md)] sends emails regarding resource requests to the following recipients at the following times:  
  
|Recipient|Event|  
|---------------|-----------|  
|Project manager|-   When a resource signs up for a project with the Project Finder Mobile app.|  
|Resource|-   When the project work the resource has signed up for has already been fulfilled by another resource.<br />-   When their skill approval request has been approved or rejected.<br />-   When their project sign up request has been approved or rejected.|  
  
## Privacy notice  
 [!INCLUDE[cc_privacy_crm_project_finder_mobile_app](../includes/cc-privacy-crm-project-finder-mobile-app.md)]  
  
### See Also  
 [Set up resources](../project-service/set-up-resources.md)
