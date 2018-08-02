---
title: "Use OneNote in Dynamics 365 (online) (Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Use OneNote integration to store and share notes related to Dynamics 365 records."
keywords: "OneNote, Notes, notebook"
ms.date: 03/08/2017
ms.service: crm-online
ms.custom: 
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: e47db291-7f10-43c2-b29c-c348618e537b
author: brycho
ms.author: brycho
manager: amyla
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 5
topic-status: Editing
---

# Use OneNote in Dynamics 365 (online)

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]<br/>[!INCLUDE[cc-applies-to-update-8-2-0](../includes/cc_applies_to_update_8_2_0.md)]

If your administrator has set up [!INCLUDE[pn_onenote](../includes/pn-onenote.md)] integration with [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)], you can access a [!INCLUDE[pn_onenote](../includes/pn-onenote.md)] notebook directly from the activities area in [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)]. This doesn't replace the current Notes feature, but gives you another way to access notes stored in [!INCLUDE[pn_onenote](../includes/pn-onenote.md)]. When you add a [!INCLUDE[pn_onenote](../includes/pn-onenote.md)] section to a notebook, it's shown individually within [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] and in order of last modified time.  
  
 [Watch a short video (2:01) about OneNote integration](https://go.microsoft.com/fwlink/p/?linkid=837793)  
  
 More information about setting up [!INCLUDE[pn_onenote](../includes/pn-onenote.md)] integration if you're a system administrator: [Set up OneNote integration in Dynamics 365](../admin/set-up-onenote-integration-in-dynamics-365.md)  
  
<a name="BKMK_UseOneNote"></a>   
> [!NOTE]
>  If you aren't signed in to [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)], you'll go to the [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)] sign-in page when you select the title of the [!INCLUDE[pn_onenote](../includes/pn-onenote.md)] notebook. When you sign in, you'll go directly to the notebook.  
  
[//]: # (In step 2, I replaced the graphic with the plus sign in parentheses. That's all you need for this button and similarly, for the ellipsis. If you put the graphic back, you'll want to use a different one--icon.png included the tooltip in addition to the icon, and you only need the graphical element here.)
### Get started with OneNote (mobile-optimized app)

1. Open the record you want to open or edit the [!INCLUDE[pn_onenote](../includes/pn-onenote.md)] notebook for.  

2. In the **Timeline** section, select **Add info and activities (+)**, and then select **OneNote**.
  
   ![Choose OneNote in the Timeline section](media/onenote-option-in-timeline.png "Choose OneNote in the Timeline section")  
  
   If a notebook is already associated with the record, the notebook opens. Otherwise, a new notebook is created and opened.   
  
   ![Notebook linked to the record is opened](media/open-onenote.png "Notebook linked to the record is opened") 
  
3. The notebook is stored in the associated [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] folder for the record. If there is more than one associated folder, the notebook is created in the first folder.  
  
   ![Notebooks in Document Associated Grid](media/document-associated-grid.png "Notebooks in Document Associated Grid")

[//]: # (The graphic for step 3 is the same as for step 1. In the Note in step 3, I used the pn-crm-shortest.md token for "Dynamics 365," to match the token you used above. Also in the Note, please note that I changed ". onetoc2" to ".onetoc2". I assume it and .one are both file name extensions?)
### Get started with OneNote (web app)  

1. In the activities area of a record, select **OneNote**.  
  
   ![Choose OneNote on the activity wall](../basics/media/use-onenote.PNG "Choose OneNote on the activity wall")  
  
2. Select a notebook to make entries.  
  
   ![Select a notebook](../basics/media/select-notebook.PNG "Select a notebook")  
 
3. The notebook is stored in the associated [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] folder for the record. If there is more than one associated folder, the notebook is created in the first folder.  
  
   ![Notebooks in associated SharePoint folder](../basics/media/use-onenote.PNG "Notebooks in their associated SharePoint folder")  
  
> [!NOTE]
> - You can't edit the [!INCLUDE[pn_onenote](../includes/pn-onenote.md)] file from within [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]. This can be done only from the [!INCLUDE[pn_onenote](../includes/pn-onenote.md)] app that opens when you choose the [!INCLUDE[pn_onenote](../includes/pn-onenote.md)] link. In the web app, [!INCLUDE[pn_onenote](../includes/pn-onenote.md)] is opened in the [!INCLUDE[pn_onenote](../includes/pn-onenote.md)] app of [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] in a separate tab.  
> - Don't delete any [!INCLUDE[pn_onenote](../includes/pn-onenote.md)] .onetoc2 or .one file types in the **OneNote** section in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]. If you do, you won't be able to access your [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] [!INCLUDE[pn_onenote](../includes/pn-onenote.md)] notebook.  
> - Section groups that keep related sections together in [!INCLUDE[pn_onenote](../includes/pn-onenote.md)] aren't supported in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)].  
> - You can only rename a section in the desktop version of [!INCLUDE[pn_onenote](../includes/pn-onenote.md)]. If you rename a section in [!INCLUDE[pn_onenote](../includes/pn-onenote.md)] online, you won't see the updated section name in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)].  
  
### See also  
 [Set up OneNote integration in Dynamics 365](../admin/set-up-onenote-integration-in-dynamics-365.md)   
 [OneNote in Dynamics 365 FAQs](../basics/onenote-dynamics-365-faqs.md)   
 [Work with activities](../basics/work-with-activities.md)
