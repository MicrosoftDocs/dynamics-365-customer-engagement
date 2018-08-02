---
title: View, block, or deactivate a social profile in social care sample application (Dynamics 365 for Customer Service) | MicrosoftDocs
description: See how to view, block, or deactivate a social profile in social care sample application in Dynamics 365 for Customer Service
keywords: View, block, or deactivate a social profile; Dynamics 365; Customer Service
author: anjgupta
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.author: anjgup
manager: shellyha
ms.date: 09/15/2017
ms.topic: article
ms.service: dynamics-365-customerservice
ms.assetid: 62e46aaf-aa48-4074-a771-bcb345734d4d
ms.custom: dyn365-customerservice
---

# View, block, or deactivate a social profile in social care sample application (Customer Service)

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Track the high influencers and the customers for your business, and save them as contacts in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] with their social profile information. You may want to get in touch with these resources later for marketing or brand-building purposes.  
  
 With the social care sample application, you can create a social profile and a corresponding contact automatically every time you create a case. You can also create social profiles for the authors of the posts who have a large number of followers or likes. These  social profiles can be viewed in the **Services** area. If a social profile exists for the author of the post, a new profile is not created.  
  
 Every social profile has a corresponding contact in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)]. A contact can have several social profiles, but a social profile can’t have several contacts.  
  
> [!NOTE]
>  The social profile data in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] is read-only. You can only view, block, define a workflow, or change the owner of the record.  
  
## View a social profile  
  
1. [!INCLUDE[proc_service_social_profiles](../includes/proc-service-social-profiles.md)]  
  
     The list of social profiles that are created in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] appears.  
  
2. Double-click any social profile to see the complete details.  
  
    The social profile form shows the name, profile link of the contact, and the cases associated with this social profile. You can also view the influencer score if it is included as part of the social feed.  
  
## Block a social profile  
 To make sure you receive only actionable social posts and avoid case creation for any unnecessary information, based on the social posts, you can block certain social profiles in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)].  
  
1.  Open the social profile you want to block.  
  
2.  In the **Blocked** drop-down menu, select **Yes**.  
  
3.  Click the **Save** button.  
  
## Deactivate a social profile  
 If you no longer work with a social profile, you can deactivate the profile temporarily. To do this, from the list of social profiles, select a profile, and click **Deactivate** on the command bar.  
  
 You can reactivate the profile by selecting it and clicking **Activate** on the command bar.
 
 ### See also
 [Sample application using Dynamics 365 Social Care Framework](https://msdn.microsoft.com/en-us/library/dn744885(v=crm.6).aspx)
